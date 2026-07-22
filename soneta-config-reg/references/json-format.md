# Format `*.reg.json` i ścieżki węzłów

Referencja serializacji rejestru konfiguracji. Kod: `RegConfigJsonConverter.cs`
(`JsonConverter<ConfigReg>`), wejście/wyjście przez `ConfigReg.ToJson` i
`ConfigRegLoader.FromJson`.

## Spis treści

- [Koperta](#koperta)
- [Sigile](#sigile)
- [Odwzorowanie węzłów na JSON](#odwzorowanie-węzłów-na-json)
- [Wartości](#wartości)
- [Ścieżki `Find`](#ścieżki-find)
- [Pełny przykład](#pełny-przykład)

## Koperta

```json
{
  "Version": 1,
  "Register": { "…": "…" }
}
```

`Version` jest zapisywane na stałe jako `1` (`ConfigRegSerialization`); przy odczycie nie jest
sprawdzane. `Register` to korzeń drzewa. Pliki eksportowane z UI mają rozszerzenie
`*.reg.json` (`FileDialogInfo.AddRegJsonFilter`), ale format to zwykły JSON.

## Sigile

Znaczniki sterujące — wszystkie zaczynają się od `$`, `#` lub `@`, żeby nie kolidować
z nazwami pól.

| Sigil | Gdzie | Znaczenie |
|---|---|---|
| `#Nazwa` | klucz właściwości | Pole tożsamości (`IsKeyValue`). Po tych polach dopasowywane są wiersze przy porównywaniu i scalaniu. |
| `@Nazwa` | klucz właściwości | Atrybut węzła `CfgNode` (konfiguracja) lub dodatku. |
| `"$": "added\|modified\|deleted"` | właściwość obiektu | Stan węzła (`RegState`). Brak = `Unchanged`. |
| `{"$v": …, "$": "…"}` | opakowanie liścia | Liść, który poza wartością niesie stan. Bez stanu liść zapisuje się „gołą” wartością. |
| `"$strict"` | pierwszy element tablicy | `ChildrenMode = StrictCollection` — kolekcja określa stan docelowy **w całości**; wiersze nieobecne w rejestrze zostaną usunięte. |
| `"$added"` / `"$modified"` / `"$deleted"` | element tablicy | Stan samej kolekcji. |
| `{"$blob": "nazwa1.txt"}` | wartość liścia | Wartość wyniesiona poza JSON (duże teksty i binaria). |

**Tablica bez `$strict` jest `PartialCollection`** — potrafi tylko dodawać i aktualizować
wiersze, nigdy nie usuwa. To bezpieczniejszy domyślny tryb i taki właśnie mają węzły tabel.
Węzły `SubTable` przeciwnie — powstają jako `StrictCollection`.

### `$blob`

Wynoszenie dużych wartości działa tylko, gdy konwerter ma ustawiony słownik `Blobs`
(pole `internal`). Kwalifikują się: `MemoText` od 2 linii, `string` z co najmniej dwoma
znakami nowej linii, `MemoBin`/`byte[]` od 16 bajtów. Nazwa pliku powstaje jako
`<nazwa-pola><kolejny-numer>.txt|.bin`. Przy odczycie brak wpisu w `Blobs` to błąd.

## Odwzorowanie węzłów na JSON

Konwerter wybiera jedną z trzech postaci na podstawie `IsLeaf` i `ChildrenMode`:

| Węzeł | JSON |
|---|---|
| Liść, `Properties` | goła wartość, albo `{"$v": …, "$": "…"}` gdy ma stan |
| `Children != null`, `Properties` | obiekt `{ … }`; najpierw pola `#klucz`, potem reszta |
| `PartialCollection` / `StrictCollection` | tablica `[ … ]`, poprzedzona `"$strict"` i/lub stanem |

Węzły **bez nazwy** (wiersze) występują wyłącznie jako elementy tablic — stąd brak dla nich
klucza właściwości.

Przy odczycie (`ReadObject`) każda właściwość tworzy dziecko o typie `object`; prawdziwy typ
ustala się dopiero przy scalaniu, przez `IConfigRegProvider.GetChildType` i
`ConfigReg.ConvertEditValue`. Dlatego rejestr wczytany z JSON-a sam z siebie nie wie, że
`"Currency"` to `FeatureTypeNumber`.

## Wartości

| Typ | Zapis |
|---|---|
| Liczby | `decimal` przy odczycie; konwersja do `int`/`double`/`enum` przy scalaniu |
| `bool` | `true` / `false` |
| Enum | nazwa jako tekst (przy `SetCompoundValuesAsStrings`), przy odczycie akceptowana też liczba |
| `Guid` | tekst |
| Referencja do wiersza | `Tabela:guid`, `Tabela:id`, albo samo `guid`/`id` gdy typ kolumny wystarcza — `ConfigRegRowProxy.FromString`, rozpoznanie po obecności `-` |
| `MemoBin` / `byte[]` | Base64 (lub `$blob`) |
| Data / czas | typy `Date`, `Time`, `YearMonth`; `null` mapuje się na `MinValue`/`Empty` |
| Pozostałe | `TypeConverter` typu docelowego z `CultureInfo.InvariantCulture` |

Serializacja używa `JavaScriptEncoder.UnsafeRelaxedJsonEscaping`, więc polskie znaki
i cudzysłowy w treściach XML pozostają czytelne.

## Ścieżki `Find`

`ConfigReg.Find(path)` / `FindRequired(path)` przyjmują ścieżkę segmentową rozdzielaną `/`.

| Zapis | Znaczenie |
|---|---|
| `"/"` | korzeń drzewa |
| `Business/FeatureDefs` | zejście po nazwach |
| `Name=CECHA` | element kolekcji, którego podwęzeł `Name` ma wartość `CECHA` |
| `TableName=Towary&Name=Dwa` | dopasowanie po wielu polach (koniunkcja) |
| `#0` | element kolekcji po indeksie |
| `Guid=00000003-aaaa-…` | typowe dopasowanie wiersza guidowanego |

Przykłady z testów:

```csharp
reg.FindRequired("Business/FeatureDefs/Name=CECHA/Category");
reg.FindRequired("Business/Config/mail/@EMailAddress");
reg.FindRequired("Core/OddzialyFirmy/Guid=00000011-aaaa-aaaa-aaaa-aaaaaaaaaaaa/Pododdzialy");
reg.FindRequired("Storage/reports/handelzakres-dokumenty/dokumenty.xml");
```

**Nazwy są kodowane** przy tworzeniu węzła (`EncodeName`): `\` → `\\`, `&` → `\&`,
`=` → `\=`, a `/` zamieniany na `-`. Dlatego nazwa pliku czy pola zawierająca ukośnik nie
rozbije ścieżki, ale też nie odnajdziesz jej po oryginalnym brzmieniu.

Pliki storage niosą kontekst w nazwie po przecinku:
`Storage/reports/…/dokumenty z pozycjami.xml,00000000-0015-0001-0001-000000000000`.

## Pełny przykład

Fragment obrazujący komplet sigili — wiersz zmieniony, pola z osobnymi stanami, kolekcja
strict oraz atrybuty konfiguracji:

```json
{
  "Version": 1,
  "Register": {
    "Business": {
      "Config": {
        "mail": {
          "@EMailAddress": "biuro@firma.pl",
          "@Password": "=G3228825…"
        }
      },
      "Entitles": ["$added", {
        "$": "added",
        "#Guid": "00000002-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
        "Name": "ENTITLE"
      }],
      "FeatureDefs": [{
        "$": "modified",
        "#Guid": "00000003-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
        "TableName": "Towary",
        "Name": "CECHA",
        "Category":   { "$v": "",    "$": "deleted"  },
        "TypeNumber": { "$v": "Int", "$": "added"    },
        "Code":       { "$v": "",    "$": "modified" }
      }],
      "RuntimeProjects": [{
        "#Name": "PROJ NAME",
        "Description": "NEW DESC",
        "References": ["$strict",
          { "#Reference": "REF1" },
          { "Reference": "REF3" }
        ]
      }]
    }
  }
}
```

Co ten fragment zrobi po imporcie:

- `mail` — ustawi dwa atrybuty konfiguracji modułu `Business`.
- `Entitles` — doda uprawnienie o podanym `Guid`.
- `FeatureDefs` — w cesze o podanym `Guid` wyczyści `Category`, ustawi `TypeNumber` i `Code`.
- `References` — **zostawi tylko** `REF1` i doda `REF3`; pozostałe referencje projektu zostaną
  usunięte, bo kolekcja jest `$strict`.

Odpowiadające testy: `ConfigReg_SaveToJson_WhenRegStateIsChanged`,
`ConfigReg_LoadFromJson_WhenRegStateIsChanged`, `ConfigReg_UpdateSession_WhenStrictSubTable`,
`ConfigReg_UpdateSession_AddConfig`.
