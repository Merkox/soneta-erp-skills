# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.KwotaBudzProj`
Nazwa tabeli: `KwotyBudzProj`
Tytuł: Kwoty budzetu projektu
Opis: Zapis kwotowy i ilościowy na pozycji budżetu projektu. Rejestruje planowane lub zrealizowane wartości dla danego okresu, wersji planu i etapu budżetowego.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudzetProjektu | `Soneta.Zadania.Budzetowanie.BudzetProjektu` | bazodanowe |  | Budzet projektu, z którym powiązana jest kwota |
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data wprowadzenia kwoty. |
| EtapBudzetu | `Soneta.Core.IEtapBudzetu` | bazodanowe |  |  |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość |  |
| Korekta | `bool` | bazodanowe | Korekta |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe | Kwota |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe | Operator |  |
| PoczatekOkresu | `Soneta.Types.Date` | bazodanowe | Data | Początek okresu. |
| PozycjaBudzProj | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` | bazodanowe |  | Pozycja budżetu projektu, z którą powiązane jest kwota |
| RodzajKwotyBudzProj | `Soneta.Zadania.Budzetowanie.RodzajKwotyBudzProj` | bazodanowe, enum |  |  |
| Uwagi | `string` | bazodanowe | Uwagi |  |
| WersjaPlanu | `Soneta.Zadania.Budzetowanie.WersjaPlanu` | bazodanowe |  | Wersja planu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajKwotyBudzProj (`Soneta.Zadania.Budzetowanie.RodzajKwotyBudzProj`)
- `PlanKoszt` = 0
- `Realizacja` = 1
- `PlanPrzychod` = 2
