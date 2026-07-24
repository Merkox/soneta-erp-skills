# Providery rejestru konfiguracji (`IConfigRegProvider`)

Referencja warstwy, która buduje i zapisuje drzewo `ConfigReg`. Dla osób pracujących
w kodzie `Soneta.Business\Config\Reg\`.

## Spis treści

- [Kontrakt interfejsu](#kontrakt-interfejsu)
- [Jak loader chodzi po drzewie](#jak-loader-chodzi-po-drzewie)
- [Jak updater zapisuje drzewo](#jak-updater-zapisuje-drzewo)
- [Katalog providerów](#katalog-providerów)
- [Wzorce implementacyjne](#wzorce-implementacyjne)
- [Dodanie nowego providera — przepis](#dodanie-nowego-providera--przepis)
- [Typowe błędy](#typowe-błędy)

## Kontrakt interfejsu

`IConfigRegProvider.cs` — interfejs jest **`internal`**, więc żyje wyłącznie wewnątrz
`Soneta.Business`. Dodatki spoza tego assembly sterują rejestrem atrybutem `[ConfigReg]`,
nie własnym providerem.

```csharp
internal interface IConfigRegProvider {
    IEnumerable<(ConfigReg Reg, object? Value)> GetChildren(ConfigReg parent, object value);
    bool HasAnyChild(ConfigReg parent, object? value) => true;
    IConfigRegProvider? GetByReg(ConfigReg reg) => throw new NotImplementedException();
    void SaveChild(ConfigReg child, Session session, List<Method> delayed) { }
    void AfterSaveChildren(ConfigReg child, Session session, List<Method> delayed) { }
    Type? GetChildType(ConfigReg child) => null;
}
```

| Metoda | Rola |
|---|---|
| `GetChildren(parent, value)` | Wylicza dzieci węzła. Zwraca **pary**: gotowy węzeł oraz wartość, która zostanie podana jako `value` przy rekurencji w dół. Te dwie rzeczy bywają różne — węzeł może mieć `EditValue` leniwe, a rekurencja potrzebuje wartości od razu. |
| `HasAnyChild(parent, value)` | Skrót pozwalający **nie schodzić** w puste poddrzewo. Zwrócenie `false` powoduje usunięcie już dodanego węzła z rodzica. Uwaga na sygnaturę: loader podaje tu `parent` (rodzica!) oraz `child.EditValue`. |
| `GetByReg(reg)` | Mapuje węzeł na provider odpowiedzialny za jego dzieci. `null` = liść. Domyślna implementacja **rzuca wyjątek**, więc każdy provider mający dzieci musi ją nadpisać. |
| `SaveChild(child, session, delayed)` | Zapisuje **dziecko** do sesji. Wołane tylko gdy `child.RegState != Unchanged`. |
| `AfterSaveChildren(child, session, delayed)` | Wołane po zapisaniu całego poddrzewa dziecka — miejsce na zdarzenia domykające (np. `invokeImported`). Wołane **zawsze**, niezależnie od `RegState`. |
| `GetChildType(child)` | Ustala prawdziwy typ wartości wczytanej z JSON jako `object`. Używane przez `ConfigRegMerger` przy porównywaniu liści. |

## Jak loader chodzi po drzewie

`ConfigRegLoader.LoadAll` — rekurencja jest krótka i warto ją znać na pamięć:

```csharp
parent.Children = [];
foreach (var (child, childValue) in provider.GetChildren(parent, value)) {
    parent.AddChild(child);
    var childProvider = provider.GetByReg(child);
    if (childProvider is not null && childValue is not null) {
        if (childProvider.HasAnyChild(parent, child.EditValue))
            LoadAll(child, childValue, childProvider, options);
        else
            parent.Children.Remove(child);
    }
}
```

Konsekwencje, o które łatwo się potknąć:

- **Zwrócenie `null` jako `Value` zatrzymuje schodzenie w dół** — nawet jeśli `GetByReg`
  zwróci provider. Tak realizowane są liście w `AddinConfigRegProvider`
  (`yield return (węzeł, null)`).
- Węzeł jest dodawany do rodzica **przed** sprawdzeniem `HasAnyChild` i dopiero potem
  ewentualnie usuwany.
- `SessionState.ThrowIfCancellationRequested()` na wejściu — budowa rejestru całej bazy jest
  długa i przerywalna.
- `ConfigRegLoadOptions.IncludeDefaults = false` usuwa po drodze wartości domyślne
  (z pominięciem pól `IsKeyValue`). Domyślnie `true`.

## Jak updater zapisuje drzewo

`ConfigRegSessionUpdater.SaveNode` — cała logika zapisu w kilkunastu liniach:

```csharp
foreach (var child in reg.Children!) {
    if (child.IsConflict) throw …;                      // konflikt blokuje zapis całości
    if (reg.ChildrenMode == StrictCollection &&
        child.RegState is not (Added or Unchanged)) throw …;

    if (child.RegState != Unchanged)
        provider.SaveChild(child, session, delayed);     // ← provider RODZICA

    if (child.Children is not null && child.RegState != Deleted)
        SaveNode(child, provider.GetByReg(child) ?? throw …);

    provider.AfterSaveChildren(child, session, delayed);
}
```

Całość opakowana jest w:

```csharp
session.InImport = true;                     // omija część logiki biznesowej
using var transaction = session.Logout(true);
SaveNode(root, rootProvider);
foreach (var action in delayed) action();    // odłożone akcje
transaction.Commit();
```

**Dlaczego `delayed`:** kolejność węzłów w drzewie nie odpowiada kolejności zależności
w bazie. Wiersz wskazywany przez pole może powstać dopiero w dalszej części przebiegu, więc
ustawienie referencji odkłada się na koniec. Ten sam mechanizm niesie `invokeImported`
(zdarzenia po imporcie) — patrz test `ConfigReg_ImportConfigWithDependancy`, gdzie prawo do
magazynu wskazuje magazyn tworzony w innej gałęzi drzewa.

## Katalog providerów

### `RootConfigRegProvider`

Korzeń `"Register"`. W konstruktorze woła `Session.Modules.ForceLoadAll()` i tworzy po jednym
`ModuleConfigRegProvider` na moduł. Dzieci: wszystkie moduły + `"Addins"` + `"Storage"`.

Nazwa modułu przechodzi przez `CalcModuleName` — moduł o nazwie `Storage` dostaje nazwę
`StorageModule`, żeby nie kolidować z węzłem `"Storage"` (plikami).

### `ModuleConfigRegProvider`

Dzieci modułu: najpierw węzeł `"Config"` (z właściwości `BusinessModule.Config`, typu
`CfgNodeProxy`), potem tabele konfiguracyjne. Węzły tabel dostają nazwę `TableInfo.TableName`
i `ChildrenMode = PartialCollection`.

Filtr tabel:

```csharp
p.TableInfo is { IsConfig: true, IsGuided: true }
    && !IsHidden(ti) && !IsGuidedKey(ti)      // Hide=true / klucz guidowany
|| IsInclude(ti)                              // Include=true
```

### `TableConfigRegProvider`

Dzieci: wiersze z `table.PrimaryKey` jako węzły **bez nazwy**.

- **Struktury drzewiaste**: `GetTreeKeyInfo` szuka klucza, który jest domyślną relacją tabeli
  do samej siebie. Gdy istnieje, na poziomie tabeli pojawiają się tylko wiersze korzeniowe
  (pole relacji `null` w wersji `Original`), a węzły dostają `IsTreeStructure = true`.
  Wyszukiwanie po kluczach schodzi wtedy w głąb drzewa — `ConfigRegExtensions.FirstByKeys`.
- `HasAnyChild` → `PrimaryKey.IsEmpty == false`, czyli puste tabele znikają z rejestru.
- `SaveChild` dla zmienionego wiersza ustawia `RowStatus.NoOriginal`, woła `GetEdit(true, false)`
  i `invokeImporting()`, a następnie `RowConfigRegProvider.SaveRow`.
- `AfterSaveChildren` odkłada `invokeImported()` na listę `delayed`.

### `RowConfigRegProvider`

Najbardziej rozbudowany provider — dzieci wiersza w trzech grupach:

1. **SubRow** — kolumny `col.IsSubRow` → `SubRowConfigRegProvider`.
2. **Pola** — pozostałe kolumny z `GetRegColumns()`, z pominięciem pola relacji nadrzędnej.
3. **SubTable** — relacje obce (`ForeignRelationInfos`) guidowane lub domyślne, jako węzły
   `ChildrenMode = StrictCollection`.

**Wyznaczanie `IsKeyValue`** (kolejność): pola klucza unikalnego nadrzędnej `SubTable` →
pola dowolnego klucza unikalnego tabeli → kolumna `Guid`.

**Kolejność pól** (`GetNamePriority`) — kosmetyczna, ale wpływa na czytelność JSON-a i na
`Caption` węzłów bez nazwy: pola klucza podstawowego (w kolejności klucza), potem
`Parent`/`Owner`/`TableName`, `Kod`/`Symbol`, `Name`/`Nazwa`,
`FullName`/`Opis`/`ProjectNamespace`, `Guid`, reszta.

**Wartości leniwe**: pola i podtabele dostają `Func<ConfigReg, object?>` zamiast wartości —
odczyt rekordu następuje dopiero przy sięgnięciu po `EditValue`. Wersję rekordu (`currentRec`
vs `originalRec`) wybiera `ConfigRegOptions.RowVersion`.

`SaveRow` (statyczna, używana też przez `SubTableConfigRegProvider`) tworzy wiersz przez
`Table.CreateEmptyRow`, honorując pole selektora — typ wiersza wynika z wartości selektora
odczytanej z rejestru.

### `SubTableConfigRegProvider` i `SubRowConfigRegProvider`

`SubRowConfigRegProvider` to `RowConfigRegProvider` dla `SubRowInfo` kolumny — dziedziczy całą
logikę pól.

`SubTableConfigRegProvider` obsługuje kolekcje podrzędne: dzieci to wiersze `SubTable`,
a `SaveChild` przed utworzeniem wiersza ustawia pole relacji do rodzica.

### `ConfigModuleConfigRegProvider`

Węzeł `"Config"` — konfiguracja modułu trzymana w drzewie `CfgNode`.

- Dzieci: podwęzły (`cfgNode.Node.Subkeys`) oraz atrybuty z prefiksem `@`
  (`'@' + attr.Name`).
- Pomijane: podwęzeł `Storages` pod węzłem `Business` (pliki są w gałęzi `"Storage"`), oraz
  właściwości `CfgNodeProxy` oznaczone `[ConfigReg(Ignore = true)]`.
- Nazwy węzłów bywają wielowyrazowe — `NormalizePropName` skleja je w PascalCase, żeby
  odnaleźć odpowiadającą właściwość proxy.
- **Węzły historyczne**: przy `CfgNodeType.HistoryNode` nazwa dziecka jest datą i przy zapisie
  jest parsowana oraz formatowana jako `yyyy/MM/dd` (`CultureInfo.InvariantCulture`). Typ
  tworzonego węzła bierze się z `[ConfigReg(ChildrenType = …)]`, a w jego braku z kontekstu
  rodzica (`HistoryNode` → `HistoryLeaf`, proxy dziedziczące `CfgHistoryNodeProxy` →
  `HistoryNode`, węzeł z dziećmi → `Node`, inaczej `Leaf`).

### `StorageConfigRegProvider`

Węzeł `"Storage"` — pliki z `Login.StorageProvider`, foldery jako węzły pośrednie.

- **Nazwa pliku zawiera kontekst**: `"nazwa.xml,<StorageContext>"`. Plik może istnieć
  w wielu kontekstach (np. globalny i operatora) — `GetAvailableContexts` rozwija je
  w osobne węzły.
- Typ wartości: `string` dla `.txt`, `.xml`, `.repx`, `.aspx`; w pozostałych przypadkach
  `byte[]`.
- Ścieżkę odtwarza `CalcPath`, wspinając się po rodzicach aż do `ConfigStorageProvider`.

### `AddinsConfigRegProvider` / `AddinConfigRegProvider`

Węzeł `"Addins"` — wiersze `SystemInfo` z niepustym `Addin`, po jednym węźle na nazwę dodatku.
Dzieci pojedynczego dodatku: `@Version`, `@DataHash`, `@UseInCommon`, `@UseInServer` oraz
węzeł o **tej samej nazwie co rodzic** niosący binaria (`GetBinary()` / `SetBinary()`).

Dodanie nowego dodatku nadaje kolejny `SysInfoIdentifier` z zakresu `AddinsStart..AddinsStop`.

## Wzorce implementacyjne

**Wartość leniwa** — gdy odczyt jest kosztowny albo wymaga rekordu rodzica:

```csharp
private object CreateLazy(ColumnInfo columnInfo) => (ConfigReg reg) => {
    var record = GetRecord(reg.Parent?.EditValue, opts);
    return record is null ? null : columnInfo.GetFieldValueWithCheck(row, record);
};
```

`ConfigReg.EditValue` rozpoznaje `Func<ConfigReg, object?>` i podmienia się na wynik przy
pierwszym odczycie.

**Atrybuty jako liście** — konwencja `@nazwa` dla wartości skalarnych węzła (konfiguracja,
dodatki). W `GetByReg` zwracaj `null` dla nazw zaczynających się od `@`, żeby loader nie
schodził niżej.

**Rozgałęzienie po nazwie węzła** — `GetByReg` jest zwykle prostym `switch`/`FirstOrDefault`
po `reg.Name`. Trzymaj nazwy w stałych (`RootConfigRegProvider.StorageName`,
`ConfigReg.ConfigModuleName`), bo te same łańcuchy pojawiają się w JSON i w ścieżkach `Find`.

## Dodanie nowego providera — przepis

1. **Zdecyduj, czyim dzieckiem jest nowa gałąź** i dopisz ją w `GetChildren` providera
   rodzica, zwracając parę `(węzeł, wartość-do-rekurencji)`.
2. **Zarejestruj provider w `GetByReg` rodzica** — bez tego loader trafi na domyślną
   implementację rzucającą `NotImplementedException`.
3. **Ustaw `ChildrenMode`** na węźle: `Properties` dla obiektu, `StrictCollection` gdy rejestr
   ma określać zawartość kolekcji w całości.
4. **Oznacz pola tożsamości** `IsKeyValue = true` — bez nich `EqualsByKeys` spadnie do
   porównywania wszystkich liści i scalanie będzie tworzyć duplikaty.
5. **Zaimplementuj `SaveChild`** obsługując trzy stany: `Added`, `Modified`, `Deleted`.
   Wszystko, co dotyka innych wierszy, odłóż na `delayed`.
6. **Rozważ `HasAnyChild`**, jeśli gałąź bywa pusta — inaczej rejestr spuchnie o puste węzły.
7. **Napisz test** w `ConfigRegTest.cs`, najprościej przez `UpdateSessionFromJson`. Sprawdź
   obie strony: budowę drzewa (`CreateRegFromSession` + `DebugInfo`) i zapis do sesji.

## Typowe błędy

| Objaw | Przyczyna |
|---|---|
| `NotImplementedException` przy wczytywaniu rejestru | Provider ma dzieci, ale nie nadpisał `GetByReg`. |
| „Nie można zapisywać rejestru z brakiem dostępu do podrejestru” | `GetByReg` zwróciło `null` dla węzła, który ma `Children`. |
| Gałąź nie schodzi głębiej mimo poprawnego `GetByReg` | `GetChildren` zwróciło `null` jako drugi element pary. |
| Scalanie duplikuje wiersze zamiast aktualizować | Brak `IsKeyValue` albo `EqualsByKeys` nie ma po czym dopasować węzłów. |
| Wiersze znikają po imporcie | Kolekcja jest `StrictCollection` (`$strict`), a rejestr nie zawiera wszystkich wierszy. |
| „Zapisywany rejestr StrictCollection …tylko z elementów Added” | Próba zapisu strict-kolekcji zawierającej `Modified`/`Deleted`. |
| Referencja do wiersza pusta po imporcie | Ustawienie pola nie zostało odłożone na `delayed`, a wiersz docelowy powstawał później. |
