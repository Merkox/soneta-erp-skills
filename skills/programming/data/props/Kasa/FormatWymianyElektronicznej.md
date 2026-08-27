# Pola i właściwości klasy biznesowej: `Soneta.Kasa.FormatWymianyElektronicznej`
Nazwa tabeli: `FormatyWymElektr`
Tytuł: Rachunki bankowe
Opis: Definicja formatu pliku do elektronicznej wymiany danych z bankami. Określa typ formatu (import wyciągów, eksport przelewów) oraz powiązany serializer odpowiedzialny za konwersję danych między systemem a formatem bankowym.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Typ` (`Soneta.Kasa.TypFormatuWymianyElektronicznej`) — wiele typów w jednej tabeli, podtypów: 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaSerializera | `string` | bazodanowe |  |  |
| Parametry | `Soneta.Kasa.ParametrySerializera` | tylko-odczyt |  |  |
| ParametrySerializera | `MemoText` | bazodanowe, podlista |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Serializer | `Soneta.Kasa.FormatWymianyElektronicznejSerializer` |  |  |  |
| Typ | `Soneta.Kasa.TypFormatuWymianyElektronicznej` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `EksportPrzelewów` | 1 | `Soneta.Kasa.FormatEksportuPrzelewów` | Format eksportu przelewów |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypFormatuWymianyElektronicznej (`Soneta.Kasa.TypFormatuWymianyElektronicznej`)
- `EksportPrzelewów` = 1
