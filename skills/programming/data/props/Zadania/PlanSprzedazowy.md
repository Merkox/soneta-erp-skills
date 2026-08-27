# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Models.SalesPlans.PlanSprzedazowy`
Nazwa tabeli: `PlanySprzedazowe`
Tytuł: Plany sprzedażowe
Opis: Plan sprzedażowy przypisany do operatora lub regionu w określonym przedziale czasowym. Zawiera wartość docelową, powiązanie z definicją realizacji oraz możliwość tworzenia hierarchicznych planów podrzędnych.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | bazodanowe | Aktywny | Aktywny |
| CanGenerateSubs | `bool` |  |  |  |
| DateFrom | `Date` | bazodanowe | Data od | Data od |
| DateTo | `Date` | bazodanowe | Data do | Data do |
| DefRealizacjiPlanu | `Soneta.Zadania.Models.SalesPlans.DefRealizacjiPlanu` | bazodanowe | Definicja realizacji planu | Określa wg jakiej definicji ma być wyliczana realizacja planu sprzedaży |
| Definition | `Soneta.Zadania.Models.SalesPlans.DefPlanuSprzedazy` | bazodanowe |  |  |
| Is365 | `bool` | tylko-odczyt |  |  |
| IsNot365 | `bool` | tylko-odczyt |  |  |
| Kwartal | `Soneta.Zadania.Quarter` (enum) |  |  |  |
| Miesiac | `Soneta.Zadania.Month` (enum) |  |  |  |
| Nadrzedny | `Soneta.Zadania.Models.SalesPlans.PlanSprzedazowy` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa |
| Operator | `App.Operator` | bazodanowe | Operator | Operatora można wybrać tylko spośród pozycji dodanych w Zespole Sprzedażowym.   Aby dodać operatora, przejdź do: Ustawienia → CRM → Ogólne → Zespół sprzedażowy. |
| OperatorSupervisors | `System.Collections.Generic.List<Soneta.CRM.Opiekun>` | podlista |  |  |
| PercentValue | `double` | tylko-odczyt |  |  |
| PodRegiony | `bool` | bazodanowe | Uwzględnij podregiony | Określa czy do wyliczenia realizacji planu będą uwzględnione podregiony wybranego regionu |
| Pole | `string` |  |  |  |
| RealizacjaWg | `Soneta.Zadania.Enums.RegionOperator` (enum) | bazodanowe | Realizacja według | Określa czy realizacja planu ma się wyliczać według przypisanego Operatora czy Regionu |
| Realization | `decimal` | tylko-odczyt | Realizacja |  |
| RealizationPercent | `Percent` | tylko-odczyt | % realizacji |  |
| Region | `Soneta.CRM.Region` | bazodanowe |  |  |
| Rok | `int` |  |  |  |
| SalePlans | `SubTable<Soneta.Zadania.Models.SalesPlans.PlanSprzedazowy>` | podlista |  |  |
| SalePlansView | `View` | podlista |  |  |
| StanPlanu | `Soneta.Zadania.Models.SalesPlans.StanPlanu` | bazodanowe | Stan planu | Określa bieżący stan realizacji planu sprzedażowego. |
| Symbol | `string` | bazodanowe |  |  |
| Value | `Currency` | bazodanowe | Wartość | Wartość |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RegionOperator (`Soneta.Zadania.Enums.RegionOperator`)
- `Region` = 0 — Regionów
- `Operator` = 1 — Operatorów

### Month (`Soneta.Zadania.Month`)
- `Empty` = 0
- `Jan` = 1 — Styczeń
- `Feb` = 2 — Luty
- `Mar` = 3 — Marzec
- `Apr` = 4 — Kwiecień
- `May` = 5 — Maj
- `Jun` = 6 — Czerwiec
- `Jul` = 7 — Lipiec
- `Aug` = 8 — Sierpień
- `Sep` = 9 — Wrzesień
- `Oct` = 10 — Październik
- `Nov` = 11 — Listopad
- `Dec` = 12 — Grudzień

### Quarter (`Soneta.Zadania.Quarter`)
- `Empty` = 0
- `Q1` = 1 — Pierwszy kwartał
- `Q2` = 2 — Drugi kwartał
- `Q3` = 3 — Trzeci kwartał
- `Q4` = 4 — Czwarty kwartał
