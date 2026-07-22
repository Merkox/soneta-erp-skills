# Potoki: wczytywanie, porównywanie, scalanie, zapis

Referencja klas sterujących rejestrem konfiguracji oraz warstwy trwałości i UI.

## Spis treści

- [ConfigRegOptions i ConfigRegLoadOptions](#configregoptions-i-configregloadoptions)
- [ConfigRegLoader — źródła rejestru](#configregloader--źródła-rejestru)
- [ConfigRegDiffer — co się zmieniło](#configregdiffer--co-się-zmieniło)
- [ConfigRegMerger — naniesienie zmian](#configregmerger--naniesienie-zmian)
- [ConfigRegConcater — wybieranie węzłów](#configregconcater--wybieranie-węzłów)
- [ConfigRegSessionUpdater — zapis do bazy](#configregsessionupdater--zapis-do-bazy)
- [Trwałość: tabela ConfigRegistry](#trwałość-tabela-configregistry)
- [UI: ConfigRegManager](#ui-configregmanager)

## `ConfigRegOptions` i `ConfigRegLoadOptions`

```csharp
public class ConfigRegOptions(Session session) {
    public Session Session { get; }
    public RowVersion RowVersion { get; set; } = RowVersion.Current;
    public bool UseStringFieldAsKeyValue { get; set; }   // zadeklarowane, nigdzie nieczytane
}

public class ConfigRegLoadOptions {
    public static readonly ConfigRegLoadOptions Default = new();
    public bool IncludeDefaults { get; set; } = true;
}
```

`RowVersion` decyduje, czy pola czytane są z `currentRec` czy `originalRec` — przydatne, gdy
chcesz zdjąć rejestr ze stanu sprzed edycji w sesji. `IncludeDefaults = false` odsiewa wartości
domyślne już w trakcie budowy drzewa (pomijając pola kluczowe).

Uwaga: wszystkie miejsca w produkcyjnym kodzie wołają `ConfigRegLoadOptions.Default`.

## `ConfigRegLoader` — źródła rejestru

```csharp
// stan aktualnej bazy
ConfigRegLoader.FromCurrentDatabase(opts, rootProvider, ConfigRegLoadOptions.Default);

// zrzut z pliku *.reg.json albo z kolumny ConfigRegistry.Json
ConfigRegLoader.FromJson(json, session);
```

`FromJson` dokłada do `JsonSerializerOptions` konwertery biznesowe powiązane z sesją
(`AddBusinessConverters`) — bez sesji rejestru nie da się odczytać, bo referencje do wierszy
rozwiązywane są w jej kontekście.

Rejestr wczytany z JSON ma wszystkie wartości typu `object`. Nadaje się do scalenia
i zapisu, ale nie do bezpośredniego porównywania typów.

## `ConfigRegDiffer` — co się zmieniło

```csharp
var differ = new ConfigRegDiffer(targetRoot: regZBazy, sourceRoot: regZeZrzutu);
differ.Go();
```

Oznacza w **drzewie docelowym** stany `Added` / `Modified` / `Deleted` względem źródła.
Węzły obecne w źródle, a nieobecne w celu, są doklejane do celu jako `Deleted` (głęboka kopia).
Zmiana dziecka propaguje `Modified` na przodków.

Typowe użycie: „co zmieniło się w bazie od czasu zrzutu” — zrzut jako źródło, aktualny stan
bazy jako cel, a potem `regTarget.RemoveUnchanged()` żeby zostały same różnice.

`Result` jest zadeklarowane, ale **nigdy nie ustawiane** — testy asertują `null`.

## `ConfigRegMerger` — naniesienie zmian

```csharp
var merger = new ConfigRegMerger(target: dbReg, rootProvider);
var merged = merger.Merge(source: jsonReg);
```

Nanosi źródło na cel, modyfikując **cel w miejscu** i ustawiając `RegState` na tym, co
faktycznie wymaga zapisu. Wynik jest wejściem dla `ConfigRegSessionUpdater`.

Zasady:

- Oba korzenie muszą nazywać się `Register`, inaczej wyjątek („Porównać można tylko
  konfigurację root”).
- Dopasowanie węzłów: `targetList.FirstByKeys(child)` → `EqualsByKeys` (nazwa → pola
  `IsKeyValue` → `Guid` → wszystkie liście), ze schodzeniem w struktury drzewiaste.
- Liść o równej wartości nie generuje zmiany; przy okazji uzupełniany jest typ wartości
  z `GetChildType`, jeśli cel miał `object`.
- Węzeł nieobecny w celu jest klonowany jako `Added`; pusta kolekcja `StrictCollection`
  degraduje się do `PartialCollection`.
- Po zastosowaniu kolekcji `StrictCollection` wiersze celu nieobjęte źródłem dostają
  `Deleted` (z pominięciem wierszy, dla których `GetCanDelete()` jest `false`), a sama
  kolekcja przechodzi w `PartialCollection`.

`Merger` można wołać wielokrotnie na tym samym celu — tak działa „Importuj kolejny rejestr”
i scalanie paczek w UI.

## `ConfigRegConcater` — wybieranie węzłów

Buduje nowy rejestr z **wybranych węzłów** innego rejestru, odtwarzając po drodze ścieżkę od
korzenia (`CheckParent` klonuje brakujących przodków).

```csharp
var concater = new ConfigRegConcater(dbRoot: leftReg, root: rightReg) { WithLinked = true, OneLevel = false };
concater.Concat(selectedNodes);
```

- `WithLinked` — dociąga wiersze wskazywane przez wartości typu `Row`, odnajdując je
  w `dbRoot` ścieżką `moduł/tabela/Guid=…`.
- `OneLevel` — ogranicza dociąganie do jednego poziomu zależności.
- `Resync()` — czyści mapę sklonowanych węzłów. Konieczne po usunięciu węzłów z rejestru
  docelowego, inaczej ponowne dodanie tego samego węzła nic nie zrobi (patrz test
  `ConfigReg_Concater_AddDeleteAdd`).

## `ConfigRegSessionUpdater` — zapis do bazy

```csharp
new ConfigRegSessionUpdater(reg, session, rootProvider).Update();
```

Przebieg opisuje [providers.md](providers.md#jak-updater-zapisuje-drzewo). Najważniejsze
warunki brzegowe:

- **Konflikt blokuje całość** — pierwszy węzeł z `IsConflict` przerywa zapis wyjątkiem.
- **`StrictCollection` tylko z `Added`/`Unchanged`** — po scaleniu kolekcje strict są już
  zdegradowane do `PartialCollection`, więc napotkanie strict-a ze stanami zmian oznacza,
  że rejestr trafił do zapisu z pominięciem `Merger`.
- Zapis idzie w `session.Logout(true)` przy `session.InImport = true`, a `delayed` wykonuje
  się przed `Commit`.

## Trwałość: tabela `ConfigRegistry`

`ManagementTools.business.xml` — moduł `ManagementTools` (`internal="true"`,
`versionName="system"`), namespace `Soneta.Config.Reg`.

| Kolumna | Typ | Uwagi |
|---|---|---|
| `Name` | string(60) | klucz `ByName`, unikalny i podstawowy |
| `Description` | text(80) | |
| `Json` | text | całość rejestru |
| `DatabaseVersion` | string(30) | `CoreTools.FullVersion` w chwili zapisu |
| `RegType` | `RegType` | `Backup` / `Operational` — **zapisywane zawsze `Operational`** |
| `DateCreated`, `DateModified` | datetime | `LastEditDate` zwraca `DateModified` lub `DateCreated` |

Tabela jest `config="false"`, więc sam rejestr nie wchodzi do rejestru konfiguracji.
Klasy: `ConfigRegistry` (wiersz) i `ConfigRegistries` (tabela). Dostęp:
`session.GetManagementTools().ConfigRegistries`. Prawa: wpis w `Business.rightstree.xml`.

Alternatywa dla tabeli to plik `*.reg.json` zapisywany przez `SaveToJson` jako `NamedStream`.
Źródło wskazuje się przez `ConfigRegSourceParams` (plik **albo** wpis rejestru — pola wzajemnie
się blokują przez `IsReadOnlyJson`/`IsReadOnlyRegistry`).

## UI: `ConfigRegManager`

Formularz *Narzędzia konfiguracyjne → Zarządzanie konfiguracją*
(`ConfigRegManager.cs` + `ConfigRegManager.General.pageform.xml`). Widoczny dla operatorów
z rolą pełnego dostępu (`SystemRoles.FullAccessRolesGuid`), licencja min. Złoty,
`ConfigSession = true`.

Pięć operacji (`ConfigRegOperations`), każda ustawia lewe i prawe drzewo:

| Operacja | Lewe drzewo | Prawe drzewo | Mechanizm |
|---|---|---|---|
| `ExportWholeDb` | — | stan bazy | `Loader.FromCurrentDatabase` |
| `ExportSelectedDb` | stan bazy | wybrane elementy | `ConfigRegConcater` (`AddSelected`, `…WithLinked`, `…WithLinked1`) |
| `ExportDiffs` (`SearchDiffs`) | zrzut | zmiany w bazie | `ConfigRegDiffer` + `RemoveUnchanged` |
| `ImportIntoDb` | rejestr źródłowy | różnice do zapisania | `ConfigRegMerger` → `SaveToSession` |
| `MergeIntoOne` | rejestr źródłowy | rejestr docelowy | wielokrotny `ConfigRegMerger` |

Prezentacja drzewa: grid z `TreeNodesValue`, kolorowanie po `RegState`
(`Added` zielony, `Modified` żółty, `Deleted` i `IsConflict` czerwony). Filtrowanie
(„Tylko zmiany”, „Tylko konflikty”, „Ukryj zera i puste”) realizuje worker
`ConfigRegManagerExtender`, podmieniając kolekcję `Children` widoczną dla grida — samo drzewo
pozostaje kompletne.

Lista zapisanych rejestrów: `ConfigRegViewInfo` → folder *Narzędzia konfiguracyjne →
Rejestr konfiguracji*, zasób `ConfigRegList`.

**Uwaga przy zmianach w UI:** `ConfigRegManager` trzyma `merger` i `concater` jako pola
i tworzy je leniwie przy pierwszym użyciu. Operacje rozpoczynające nowy scenariusz przechodzą
przez `Go(...)`, które odtwarza `ConfigRegOptions` i `RootConfigRegProvider`, ale **nie** zeruje
tych dwóch pól — o czym trzeba pamiętać, dokładając nową operację.
