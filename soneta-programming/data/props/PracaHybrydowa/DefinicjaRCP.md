# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.RCP.Models.Database.DefinicjaRCP`
Nazwa tabeli: `DefinicjeRCP`
Tytuł: Definicje rejestracji czasu pracy
Opis: Szablon rejestracji czasu pracy (RCP). Konfiguruje parametry ewidencji czasu pracy: algorytmy akcji, blokady wyświetlania i edycji, dzienny wymiar czasu oraz opcje rejestracji miejsca i trybu pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 26
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytmAkcji | `bool` |  |  |  |
| AlgorytmAkcji | `Soneta.PracaZdalna.RCP.Models.Database.Algorytm` | bazodanowe |  | Algorytm akcji dla definicji rejestracji czasu pracy |
| AlgorytmAkcji.Aktywny | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla definicji rejestracji czasu pracy |
| AlgorytmAkcji.Kod | `Soneta.Business.MemoText` | bazodanowe | Kod algorytmu | Kod algorytmów dla rejestracji czasu pracy |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje rejestracji czasu pracy nie będą wyświetlane w liście wyboru. |
| BlokadaEdycji | `Soneta.PracaZdalna.RCP.Models.Database.BlokadaEdycji` | bazodanowe |  | Edytuj wyniki |
| BlokadaEdycji.Aktywna | `bool` | bazodanowe | Aktywna | Czy konfiguracja jest aktywna |
| BlokadaEdycji.DodatkoweDni | `int` | bazodanowe | Liczba dodatkowych dni | Liczba dodatkowych dni do zakresu |
| BlokadaEdycji.RodzajDni | `Soneta.PracaZdalna.RCP.Enums.TypeOofDaysToCalculate` | bazodanowe, enum | Dni wolne | Określa, w jaki sposób uwzględnić dane |
| BlokadaEdycji.WyliczWgKalend | `bool` | bazodanowe | Wylicz według dni z kalendarza | Czy wyliczyć według dni z kalendarza |
| BlokadaEdycji.Zakres | `Soneta.PracaZdalna.RCP.Enums.DataCollectionScope` | bazodanowe, enum | Zakres | Zakres wykonywania operacji na danych, np. wyświetlanie, edycja |
| BlokadaWyswietlenia | `Soneta.PracaZdalna.RCP.Models.Database.BlokadaWyswietlenia` | bazodanowe |  | Wyświetl wyniki |
| BlokadaWyswietlenia.Aktywna | `bool` | bazodanowe | Aktywna | Czy konfiguracja jest aktywna |
| BlokadaWyswietlenia.DodatkowyZakres | `int` | bazodanowe | Liczba dodatkowych dni | Liczba dodatkowych zakresów |
| BlokadaWyswietlenia.RodzajDni | `Soneta.PracaZdalna.RCP.Enums.TypeOofDaysToCalculate` | bazodanowe, enum | Dni wolne | Określa, w jaki sposób uwzględnić dane |
| BlokadaWyswietlenia.WyliczWgKalend | `bool` | bazodanowe | Wylicz według dni z kalendarza | Czy wyliczyć według dni z kalendarza |
| BlokadaWyswietlenia.Zakres | `Soneta.PracaZdalna.RCP.Enums.DataCollectionScope` | bazodanowe, enum | Zakres | Zakres wykonywania operacji na danych, np. wyświetlanie, edycja |
| ClassName | `string` |  |  |  |
| DziennyCzasPracy | `Soneta.Types.Time` | bazodanowe |  | Dzienny czas pracy |
| KodAlgorytmuAkcji | `Soneta.Business.MemoText` |  |  |  |
| Namespace | `object` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji rejestracji czasu pracy |
| Opis | `string` | bazodanowe | Opis | Opis definicji rejestracji czasu pracy |
| RejestrujMiejscePracy | `bool` | bazodanowe |  | Wybór miejsca pracy |
| RejestrujTrybPracy | `bool` | bazodanowe |  | Wybór trybu pracy |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| UzupelnijUwagi | `bool` | bazodanowe |  | Czy należy uzupełnić uwagi podczas edycji |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DataCollectionScope (`Soneta.PracaZdalna.RCP.Enums.DataCollectionScope`)
- `None` = 0 — Brak
- `CurrentDay` = 1 — Bieżący dzień
- `CurrentWeek` = 2 — Bieżący tydzień
- `CurrentMonth` = 3 — Bieżący miesiąc
- `CurrentYear` = 4 — Bieżący rok

### TypeOofDaysToCalculate (`Soneta.PracaZdalna.RCP.Enums.TypeOofDaysToCalculate`)
- `SelectedDay` = 0 — Wybrany dzień
- `PreviousWorkingDay` = 1 — Poprzedni dzień roboczy
