# Pola i właściwości klasy biznesowej: `Soneta.Zadania.TypUrzadzenia`
Nazwa tabeli: `TypyUrzadzen`
Tytuł: Typy urządzeń
Opis: Klasyfikacja urządzeń serwisowych. Definiuje typ urządzenia z domyślnymi parametrami gwarancji, przeglądów, formularzem użytkownika oraz powiązanymi definicjami zleceń i wypożyczeń.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefPageXml | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |
| DefWypozyczenia | `Soneta.Zadania.DefZadania` | bazodanowe | Domyślna definicja wypożyczenia | Definicja domyślnego wypożyczenia dla urządzeń danego rodzaju. |
| DefZlecenia | `Soneta.Zadania.DefZadania` | bazodanowe | Domyślna definicja zlecenia | Definicja domyślnego zlecenia dla urządzeń danego rodzaju. |
| DefinedType | `System.Type` |  |  |  |
| Domyslny | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślny typ urządzenia. |
| FiltrTowaru | `string` | bazodanowe | Filtr towaru | Filtr wg jakiego wyświetlana jest lista towarów na urządzeniu. |
| Formularz | `Soneta.Core.RodzajFormularzaUrzadzenia` | bazodanowe, enum | Rodzaj formularza | Określa sposób wyświetlania formularza |
| Gwarancja | `int` | bazodanowe |  | Gwarancja urządzenia. |
| LenIdent | `int` | bazodanowe |  | Długość kodu identyfikatora. |
| Modele | `Soneta.Business.SubTable<Soneta.Zadania.ModelUrz>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa rodzaju urządzenia. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| PrefixIdent | `string` | bazodanowe | Prefix identyfilatora | Prefix identyfikatora urządzenia. |
| PrzegladOkres | `int` | bazodanowe |  | Co ile miesięcy przegląd. |
| Symbol | `string` | bazodanowe | Symbol | Symbol rodzaju urządzenia. |
| Xml | `Soneta.Business.MemoText` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajFormularzaUrzadzenia (`Soneta.Core.RodzajFormularzaUrzadzenia`)
- `Zwykły` = 0 — Zwykły
- `Użytkownika` = 1
