# Pola i właściwości klasy biznesowej: `Soneta.Kasa.FormatWymianyElektronicznej`
Nazwa tabeli: `FormatyWymElektr`
Tytuł: Rachunki bankowe
Opis: Definicja formatu pliku do elektronicznej wymiany danych z bankami. Określa typ formatu (import wyciągów, eksport przelewów) oraz powiązany serializer odpowiedzialny za konwersję danych między systemem a formatem bankowym.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaSerializera | `string` | bazodanowe |  |  |
| Parametry | `Soneta.Kasa.ParametrySerializera` |  |  |  |
| ParametrySerializera | `Soneta.Business.MemoText` | bazodanowe |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Serializer | `Soneta.Kasa.FormatWymianyElektronicznejSerializer` |  |  |  |
| Typ | `Soneta.Kasa.TypFormatuWymianyElektronicznej` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypFormatuWymianyElektronicznej (`Soneta.Kasa.TypFormatuWymianyElektronicznej`)
- `EksportPrzelewów` = 1
