# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Models.SalesPlans.PlanSprzedazowy`
Nazwa tabeli: `PlanySprzedazowe`
Tytuł: Plany sprzedażowe
Opis: Plan sprzedażowy przypisany do operatora lub regionu w określonym przedziale czasowym. Zawiera wartość docelową, powiązanie z definicją realizacji oraz możliwość tworzenia hierarchicznych planów podrzędnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | bazodanowe | Aktywny | Aktywny |
| CanGenerateSubs | `bool` |  |  |  |
| DateFrom | `Soneta.Types.Date` | bazodanowe | Data od | Data od |
| DateTo | `Soneta.Types.Date` | bazodanowe | Data do | Data do |
| DefRealizacjiPlanu | `Soneta.Zadania.Models.SalesPlans.DefRealizacjiPlanu` | bazodanowe | Definicja realizacji planu | Określa wg jakiej definicji ma być wyliczana realizacja planu sprzedaży |
| Definition | `Soneta.Zadania.Models.SalesPlans.DefPlanuSprzedazy` | bazodanowe |  |  |
| Is365 | `bool` |  |  |  |
| IsNot365 | `bool` |  |  |  |
| Kwartal | `Soneta.Zadania.Quarter` | enum |  |  |
| Miesiac | `Soneta.Zadania.Month` | enum |  |  |
| Nadrzedny | `Soneta.Zadania.Models.SalesPlans.PlanSprzedazowy` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa |
| Operator | `Soneta.Business.App.Operator` | bazodanowe | Operator | Operatora można wybrać tylko spośród pozycji dodanych w Zespole Sprzedażowym.   Aby dodać operatora, przejdź do: Ustawienia → CRM → Ogólne → Zespół sprzedażowy. |
| OperatorSupervisors | `System.Collections.Generic.List<Soneta.CRM.Opiekun>` |  |  |  |
| PercentValue | `double` |  |  |  |
| PodRegiony | `bool` | bazodanowe | Uwzględnij podregiony | Określa czy do wyliczenia realizacji planu będą uwzględnione podregiony wybranego regionu |
| Pole | `string` |  |  |  |
| RealizacjaWg | `Soneta.Zadania.Enums.RegionOperator` | bazodanowe, enum | Realizacja według | Określa czy realizacja planu ma się wyliczać według przypisanego Operatora czy Regionu |
| Realization | `decimal` |  | Realizacja |  |
| RealizationPercent | `Soneta.Types.Percent` |  | % realizacji |  |
| Region | `Soneta.CRM.Region` | bazodanowe |  |  |
| Rok | `int` |  |  |  |
| SalePlans | `Soneta.Business.SubTable<Soneta.Zadania.Models.SalesPlans.PlanSprzedazowy>` |  |  |  |
| SalePlansView | `Soneta.Business.View` |  |  |  |
| StanPlanu | `Soneta.Zadania.Models.SalesPlans.StanPlanu` | bazodanowe | Stan planu | Określa bieżący stan realizacji planu sprzedażowego. |
| Symbol | `string` | bazodanowe |  |  |
| Value | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość |

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
