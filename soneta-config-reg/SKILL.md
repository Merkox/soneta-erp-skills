---
name: soneta-config-reg
description: >
  Silnik REJESTRU KONFIGURACJI (ConfigReg, "rejestr konfiguracji") platformy Soneta
  (enova365, Triva) — od strony kodu C#: drzewo węzłów `ConfigReg`, providery
  `IConfigRegProvider` (Root/Module/ConfigModule/Table/Row/SubRow/SubTable/Storage/Addins),
  atrybut `[ConfigReg(Hide/Ignore/Include/ChildrenType)]` sterujący zakresem rejestru,
  format plików `*.reg.json`, oraz potok Loader → Differ/Merger → SessionUpdater
  zapisujący zmiany do sesji. Używaj ZAWSZE gdy użytkownik: (1) pyta o rejestr konfiguracji,
  ConfigReg, `Soneta.Config.Reg`, tabelę `ConfigRegistry` lub menu "Zarządzanie konfiguracją";
  (2) chce włączyć/wyłączyć tabelę, kolumnę lub węzeł konfiguracji z rejestru
  (`ConfigReg(Ignore=true)`, `Hide`, `Include`, `ChildrenType`); (3) pisze lub modyfikuje
  provider rejestru, obsługę zapisu (`SaveChild`, `delayed`), porównywanie (`ConfigRegDiffer`),
  scalanie (`ConfigRegMerger`) albo serializację (`RegConfigJsonConverter`);
  (4) buduje, czyta lub debuguje plik `*.reg.json` — sigile `$strict`, `$v`, `$`, `#klucz`,
  `@atrybut`, `$blob`, ścieżki typu `Business/FeatureDefs/Name=CECHA`;
  (5) diagnozuje przenoszenie ustawień między bazami przez rejestr (eksport całej bazy,
  różnice, import, scalanie paczek). Import/eksport danych przez XML (`dbinit.xml`,
  `<session>`) to INNY mechanizm → /soneta-config.
---

# Rejestr konfiguracji (ConfigReg) — silnik platformy Soneta

Rejestr konfiguracji to **zrzut całej konfiguracji bazy danych do drzewa węzłów**, które
da się zserializować do JSON, porównać z innym zrzutem, scalić i ponownie zapisać do bazy.
Służy do wersjonowania ustawień, śledzenia zmian i przenoszenia konfiguracji między bazami
(np. testowa → operacyjna).

Ten skill opisuje mechanizm **od strony kodu C#** — dla osób, które rozwijają silnik,
piszą providery albo sterują zakresem rejestru w swoich modułach.

## Kiedy ten skill, a kiedy inny

| Potrzeba | Skill |
|---|---|
| Rejestr konfiguracji: providery, węzły, `*.reg.json`, `[ConfigReg]`, merge/diff/zapis | **/soneta-config-reg** (ten) |
| Import/eksport danych przez **XML** (`<session>`, `*.dbinit.xml`, datapack, demo) | [/soneta-config](../soneta-config/SKILL.md) |
| ORM: `Row`/`Table`/`Module`, sesje i transakcje, `GuidedRow`, `OnImporting`/`OnImported` | [/soneta-programming](../soneta-programming/SKILL.md) |
| Definicja tabel i kolumn (w tym `<attribute>ConfigReg(...)</attribute>`) | [/soneta-business-xml](../soneta-business-xml/SKILL.md) |
| Formularz `ConfigRegManager.General.pageform.xml`, grid drzewa | [/soneta-form-xml](../soneta-form-xml/SKILL.md) |
| Operacje na bazie z CLI, weryfikacja na żywej aplikacji | [/soneta-tools](../soneta-tools/SKILL.md) |

**Nie myl dwóch mechanizmów przenoszenia ustawień.** XML (`<session>`, `/soneta-config`)
przenosi *wskazane rekordy* i jest starszym, ogólnym mechanizmem importu danych. ConfigReg
przenosi *stan konfiguracji* jako całość, z wykrywaniem różnic i scalaniem. Mają rozłączny kod.

## Mapa plików

Cały mechanizm jest zamknięty w ~30 plikach i nie ma konsumentów poza UI i testami.

| Obszar | Ścieżka |
|---|---|
| Silnik | `Soneta.Business\Config\Reg\` — namespace `Soneta.Config.Reg` |
| Trwałość (tabela `ConfigRegistry`) | `Soneta.Business\Config\Reg\ManagementTools.business.xml` |
| UI (formularz operacji + lista rejestrów) | `Soneta.Business.UI\UI\ConfigRegManager*`, `Soneta.Business.UI\ViewInfos\ConfigRegViewInfo.cs` |
| Atrybut sterujący | `Soneta.Business\Config\Reg\ConfigRegAttribute.cs` (typ w ns `Soneta.Business`) |
| Testy — **najlepsza specyfikacja mechanizmu** | `Soneta.Business.Test\ConfigRegTest.cs` |

## Model danych: węzeł `ConfigReg`

Jedna klasa (`ConfigReg.cs`) reprezentuje każdy poziom drzewa — moduł, tabelę, wiersz, pole,
węzeł konfiguracji, plik storage. Odróżnia je zestaw właściwości, nie typ.

| Właściwość | Znaczenie |
|---|---|
| `Name` / `IsNamed` | Węzeł **nazwany** = właściwość/tabela/moduł. Węzeł **bez nazwy** = element kolekcji (wiersz). `Name` na węźle bez nazwy rzuca wyjątek — sprawdzaj `IsNamed`. |
| `EditValue` / `EditValueType` | Wartość węzła. Może przechowywać `Func<ConfigReg, object?>` — wtedy liczy się **leniwie** przy pierwszym odczycie. Setter konwertuje wartość przez `ConvertEditValue`. |
| `Children` / `IsLeaf` | `Children == null` oznacza liść. Pusta lista to **nie** liść, tylko węzeł bez dzieci. |
| `ChildrenMode` | `Properties` (obiekt), `PartialCollection` (lista dodająca/aktualizująca), `StrictCollection` (lista określająca kolekcję w całości — brakujące wiersze zostaną **usunięte**). |
| `RegState` | `Unchanged` / `Added` / `Modified` / `Deleted` — wynik porównania lub scalenia. |
| `IsKeyValue` | Pole wchodzące w tożsamość wiersza (klucz unikalny lub `Guid`). Nigdy nie jest usuwane przez `RemoveDefaults`/`RemoveUnchanged`. |
| `IsTreeStructure` | Węzeł należy do struktury drzewiastej (tabela z relacją do samej siebie). |
| `IsConflict` / `Resolution` | Konflikt scalania — patrz „Stan mechanizmu” niżej. |

Metody, po które sięgniesz najczęściej:

- `Find(path)` / `FindRequired(path)` — nawigacja ścieżką, np.
  `reg.FindRequired("Business/FeatureDefs/Name=CECHA/Category")`. Składnię ścieżek opisuje
  [references/json-format.md](references/json-format.md).
- `DebugInfo` — czytelny zrzut całego poddrzewa z wcięciami i znacznikami `[+] [*] [-]`.
  Testy porównują właśnie ten tekst; przy diagnozie zaczynaj od niego.
- `EqualsByKeys(other)` — **tożsamość węzłów** przy porównywaniu i scalaniu. Kolejność reguł:
  nazwa (gdy oba nazwane) → wszystkie pola `IsKeyValue` → `Guid` → zgodność wszystkich liści.
- `RemoveDefaults()` / `RemoveUnchanged()` — odchudzanie drzewa przed zapisem.
- `ToJson(session, options)` — serializacja; wywołana na węźle innym niż root „opakowuje” go
  w sztuczną ścieżkę od roota, degradując po drodze `StrictCollection` → `PartialCollection`.

## Drzewo providerów

Drzewo nie jest budowane przez same węzły — buduje je hierarchia providerów. Każdy provider
zna *jeden poziom*: potrafi wyliczyć swoje dzieci i wskazać provider odpowiedzialny za każde
z nich.

```
RootConfigRegProvider                    "Register"
├── ModuleConfigRegProvider              po jednym na moduł sesji
│   ├── ConfigModuleConfigRegProvider    "Config" → CfgNode: podwęzły + "@atrybuty"
│   └── TableConfigRegProvider           tabele konfiguracyjne
│       └── RowConfigRegProvider         pola wiersza
│           ├── SubRowConfigRegProvider  pola typu SubRow
│           └── SubTableConfigRegProvider kolekcje podrzędne ($strict)
├── AddinsConfigRegProvider              "Addins" → SystemInfo z Addin
└── StorageConfigRegProvider             "Storage" → pliki i foldery StorageProvider
```

**Które tabele trafiają do rejestru** (`ModuleConfigRegProvider.cs`): `IsConfig && IsGuided`,
z pominięciem tabel oznaczonych `[ConfigReg(Hide = true)]` oraz tabel mających klucz guidowany;
dodatkowo dołączane są tabele z `[ConfigReg(Include = true)]`. Tabele bez rekordów są usuwane
z drzewa przez `HasAnyChild`.

Szczegóły kontraktu `IConfigRegProvider`, opis każdego providera i przepis na dodanie
własnego — [references/providers.md](references/providers.md).

## Potok operacji

```
        ConfigRegLoader.FromCurrentDatabase(opts, rootProvider, loadOpts)   ← stan bazy
        ConfigRegLoader.FromJson(json, session)                             ← zrzut z pliku/tabeli
                              │
        ┌─────────────────────┼─────────────────────┐
        ▼                     ▼                     ▼
  ConfigRegDiffer      ConfigRegMerger       ConfigRegConcater
  (co się zmieniło)    (nanieś źródło        (zbierz wybrane węzły
                        na cel, ustaw          + zależne wiersze)
                        RegState)
                              │
                              ▼
                  ConfigRegSessionUpdater.Update()      → zapis do sesji
                  ConfigReg.ToJson(session)             → plik *.reg.json / tabela ConfigRegistry
```

Kanoniczne użycie (wprost z `ConfigRegTest.UpdateSessionFromJson`):

```csharp
var opts     = new ConfigRegOptions(session);
var provider = new RootConfigRegProvider(opts);

var dbReg   = ConfigRegLoader.FromCurrentDatabase(opts, provider, ConfigRegLoadOptions.Default);
var jsonReg = ConfigRegLoader.FromJson(json, session);

var reg = new ConfigRegMerger(dbReg, provider).Merge(jsonReg);   // nanosi zmiany na dbReg
new ConfigRegSessionUpdater(reg, session, provider).Update();     // zapisuje do sesji
```

Opis każdego etapu, tabeli `ConfigRegistry` i pięciu operacji UI —
[references/pipelines.md](references/pipelines.md).

## Punkty rozszerzeń

### Z zewnątrz modułu: atrybut `[ConfigReg]`

To jedyny publiczny punkt sterowania — `IConfigRegProvider` jest `internal`, więc dodatek
spoza `Soneta.Business` nie napisze własnego providera.

| Właściwość | Gdzie stosować | Efekt |
|---|---|---|
| `Hide = true` | klasa tabeli | Wyklucza tabelę mimo że jest konfiguracyjna i guidowana. Przykład: `CfgNodes` (`Soneta.Business\Config\CfgNodes.cs`) — konfiguracja jest w rejestrze reprezentowana węzłem `Config`, nie surową tabelą. |
| `Ignore = true` | właściwość wiersza, pole rekordu, właściwość `CfgNodeProxy` | Pomija pojedynczą wartość. Stosuj dla **sekretów i danych lokalnych**: `Operator.Password`, `OperatorEx.PasswordHistory`, `ViewLicensesHash` w `Soneta.BI`. |
| `Include = true` | klasa tabeli | Dołącza tabelę niekonfiguracyjną. Przykład: `Dictionary` (`Soneta.Business\Db\Dictionary.cs`). |
| `ChildrenType` | klasa `CfgNodeProxy` | Wymusza typ tworzonych węzłów konfiguracji. Przykład: `Wskaźniki` w `Soneta.KadryPlace` → `CfgNodeType.HistoryNode` (węzły kluczowane datą). |

W `business.xml` atrybut zapisuje się jako element kolumny — patrz `Business.business.xml`:

```xml
<col name="Password" type="string" length="64" required="true" modifier="protected" specialaccess="true">
    <attribute>ConfigReg(Ignore=true)</attribute>
</col>
```

**Zasada przy nowej tabeli konfiguracyjnej:** jeśli tabela jest `config` + guidowana, znajdzie
się w rejestrze automatycznie i jej zawartość pojedzie do innych baz. Zanim ją dodasz, przejrzyj
kolumny pod kątem haseł, hashy, liczników i identyfikatorów instalacji — te oznacz `Ignore`.

### Wewnątrz silnika: nowy provider

Krótko: zaimplementuj `IConfigRegProvider`, zwróć węzły z `GetChildren`, w `GetByReg` odwzoruj
węzeł na provider potomny, a zapis obsłuż w `SaveChild` **rodzica** (provider zapisuje własne
dzieci, nie siebie). Pełny przepis wraz z pułapkami — [references/providers.md](references/providers.md).

## Reguły, które łatwo złamać

- **`SaveChild` należy do rodzica.** `ConfigRegSessionUpdater` woła `provider.SaveChild(child, …)`
  na providerze *poziomu wyżej*. Provider nigdy nie zapisuje węzła, do którego sam jest przypisany.
- **Odłożone akcje (`delayed`).** Referencje do wierszy i `invokeImported` trafiają na listę
  `List<Method> delayed`, wykonywaną dopiero po przejściu całego drzewa — bo wiersz docelowy może
  jeszcze nie istnieć w momencie ustawiania pola. Jeśli w `SaveChild` dotykasz innego wiersza,
  odłóż to działanie zamiast wykonywać od razu.
- **`StrictCollection` kasuje.** Kolekcja oznaczona `$strict` określa stan docelowy w całości;
  wiersze nieobecne w rejestrze zostaną usunięte. `ConfigRegSessionUpdater` odmówi zapisu, jeśli
  w takiej kolekcji znajdzie dzieci w stanie innym niż `Added`/`Unchanged`.
- **Leniwe `EditValue`.** Odczyt `EditValue` może uruchomić zapytanie do bazy albo odczyt pliku.
  W pętlach diagnostycznych używaj `IsNamed`/`Name`, nie `TextValue`.
- **`ConvertEditValue` jest jedynym miejscem konwersji.** Wartości z JSON przychodzą jako
  `string`/`decimal`/`bool` i typ docelowy ustala się dopiero przy scalaniu (`GetChildType`).
  Nowy typ wartości obsłuż tam, nie w providerze.
- **Zapis idzie przez `session.Logout(true)` z `InImport = true`** (`ConfigRegSessionUpdater.cs`)
  — omija część walidacji biznesowej. Nie wołaj `Update()` wewnątrz własnej transakcji.

## Stan mechanizmu — czego jeszcze nie ma

Zanim zaproponujesz zmianę opartą o te elementy, sprawdź, czy w ogóle działają:

- **Wykrywanie konfliktów jest niedokończone.** Gałąź ustawiająca konflikt na liściu jest
  zakomentowana w `ConfigRegMerger.cs`, a test `ConfigReg_MergeWithConflicts` ma
  `[Ignore("Mechanizm konfliktów do implementacji.")]`. UI już pokazuje filtr „Tylko konflikty”
  i `ConflictResolution`, ale logika rozstrzygania nie jest napisana.
- **`ConfigRegDiffer.Result` nigdy nie jest ustawiane** — testy asertują, że jest `null`.
- **`ConfigRegOptions.UseStringFieldAsKeyValue`** jest zadeklarowane i nigdzie nieczytane.
- **`RegType.Backup`** nie jest nigdzie zapisywane; wszystkie ścieżki zapisu wpisują `Operational`.
- Kilkanaście testów ma `[Ignore]` („Wyłączony do czasu weryfikacji”, „Bledy na pipeline”).
  **Za specyfikację przyjmuj testy przechodzące**, a przy zmianach sprawdź, czy któryś z wyłączonych
  nie opisuje właśnie tego, co poprawiasz.

## Testy jako specyfikacja

`Soneta.Business.Test\ConfigRegTest.cs` pokrywa mechanizm gęściej niż jakakolwiek dokumentacja.
Przy zmianie w silniku zacznij od znalezienia testu opisującego zachowanie:

| Zachowanie | Test |
|---|---|
| Budowa drzewa z sesji `BSubstitute` | `ConfigReg_CreateReg_FromSubstitute` |
| Pomijanie pustych tabel | `ConfigReg_ShouldNoRegNode_WhenEmptyTables` |
| Serializacja i odczyt `RegState` | `ConfigReg_SaveToJson_WhenRegStateIsChanged`, `ConfigReg_LoadFromJson_WhenRegStateIsChanged` |
| Brak różnic przy tym samym stanie | `ConfigReg_DiffsNoChanges_WhenSameConfigRegBSubstitute` |
| Dodanie / zmiana / usunięcie wiersza | `ConfigReg_DiffsAdded_…`, `ConfigReg_DiffsDeleted_…`, `ConfigReg_UpdateSession_AddRow`, `…_DeleteRow` |
| `$strict` na `SubTable` | `ConfigReg_UpdateSession_WhenStrictSubTable`, `…_StrictCollection` |
| Konfiguracja `CfgNode` | `ConfigReg_UpdateSession_AddConfig`, `…_UpdateConfig`, `…_DeleteConfig` |
| Storage i addiny | `ConfigReg_UpdateSession_AddStorage`, `…_AddAddin`, `…_CreateFilesElement`, `…_DeleteFileElement` |
| Struktury drzewiaste | `ConfigReg_UpdateSession_LoadingTree`, `…_LoadingTreeByGuid` |
| Wybieranie węzłów w UI (`Concater`) | `ConfigReg_Concater_AddDeleteAdd` |

Pomocnik `UpdateSessionFromJson(session, jsonData)` w tym pliku to najkrótsza droga do napisania
nowego testu: podajesz fragment JSON od poziomu modułu, a on robi load → merge → update.

## Powiązania

- [/soneta-config](../soneta-config/SKILL.md) — drugi mechanizm przenoszenia ustawień
  (XML `<session>`, `*.dbinit.xml`, datapack) oraz inwentaryzacja menu.
- [/soneta-programming](../soneta-programming/SKILL.md) — ORM pod spodem: `Row`/`Table`/`Module`,
  `GuidedRow` i `Datapack`, sesje i transakcje, `OnImporting`/`OnImported`, `Context`, testy
  integracyjne.
- [/soneta-business-xml](../soneta-business-xml/SKILL.md) — deklaracja tabel konfiguracyjnych
  i `<attribute>ConfigReg(...)</attribute>` w kolumnach.
- [/soneta-form-xml](../soneta-form-xml/SKILL.md) — formularz zarządzania rejestrem
  (grid drzewiasty, `Appearance` po `RegState`).
- [/soneta-erp](../soneta-erp/SKILL.md) — mapa wyboru skilla.
