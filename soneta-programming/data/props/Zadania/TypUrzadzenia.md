# Pola i właściwości klasy biznesowej: `Soneta.Zadania.TypUrzadzenia`
Nazwa tabeli: `TypyUrzadzen`
Tytuł: Typy urządzeń
Opis: Klasyfikacja urządzeń serwisowych. Definiuje typ urządzenia z domyślnymi parametrami gwarancji, przeglądów, formularzem użytkownika oraz powiązanymi definicjami zleceń i wypożyczeń.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 3
- subrowy: 0
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefPageXml | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika. |  |
| DefWypozyczenia | `Soneta.Zadania.DefZadania` | bazodanowe | Domyślna definicja wypożyczenia | Definicja domyślnego wypożyczenia dla urządzeń danego rodzaju. |
| DefZlecenia | `Soneta.Zadania.DefZadania` | bazodanowe | Domyślna definicja zlecenia | Definicja domyślnego zlecenia dla urządzeń danego rodzaju. |
| DefinedType | `System.Type` | tylko-odczyt |  |  |
| Domyslny | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślny typ urządzenia. |
| FiltrTowaru | `string` | bazodanowe | Filtr towaru | Filtr wg jakiego wyświetlana jest lista towarów na urządzeniu. |
| Formularz | `Soneta.Core.RodzajFormularzaUrzadzenia` (enum) | bazodanowe | Rodzaj formularza | Określa sposób wyświetlania formularza |
| Gwarancja | `int` | bazodanowe |  | Gwarancja urządzenia. |
| LenIdent | `int` | bazodanowe |  | Długość kodu identyfikatora. |
| Modele | `SubTable<Soneta.Zadania.ModelUrz>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa rodzaju urządzenia. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| PrefixIdent | `string` | bazodanowe | Prefix identyfilatora | Prefix identyfikatora urządzenia. |
| PrzegladOkres | `int` | bazodanowe |  | Co ile miesięcy przegląd. |
| Symbol | `string` | bazodanowe | Symbol | Symbol rodzaju urządzenia. |
| Xml | `MemoText` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajFormularzaUrzadzenia (`Soneta.Core.RodzajFormularzaUrzadzenia`)
- `Zwykły` = 0 — Zwykły
- `Użytkownika` = 1
