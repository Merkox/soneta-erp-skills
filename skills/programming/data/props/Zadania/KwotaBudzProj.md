# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.KwotaBudzProj`
Nazwa tabeli: `KwotyBudzProj`
Tytuł: Kwoty budzetu projektu
Opis: Zapis kwotowy i ilościowy na pozycji budżetu projektu. Rejestruje planowane lub zrealizowane wartości dla danego okresu, wersji planu i etapu budżetowego.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BudzetProjektu | `Soneta.Zadania.Budzetowanie.BudzetProjektu` | bazodanowe |  | Budzet projektu, z którym powiązana jest kwota |
| Data | `Date` | bazodanowe | Data | Data wprowadzenia kwoty. |
| EtapBudzetu | `Soneta.Core.IEtapBudzetu` | bazodanowe |  |  |
| Ilosc | `Amount` | bazodanowe | Ilość |  |
| Korekta | `bool` | bazodanowe | Korekta |  |
| Kwota | `Currency` | bazodanowe | Kwota |  |
| Operator | `App.Operator` | bazodanowe | Operator |  |
| PoczatekOkresu | `Date` | bazodanowe | Data | Początek okresu. |
| PozycjaBudzProj | `Soneta.Zadania.Budzetowanie.PozycjaBudzProj` | bazodanowe |  | Pozycja budżetu projektu, z którą powiązane jest kwota |
| RodzajKwotyBudzProj | `Soneta.Zadania.Budzetowanie.RodzajKwotyBudzProj` (enum) | bazodanowe |  |  |
| Uwagi | `string` | bazodanowe | Uwagi |  |
| WersjaPlanu | `Soneta.Zadania.Budzetowanie.WersjaPlanu` | bazodanowe, tylko-odczyt |  | Wersja planu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajKwotyBudzProj (`Soneta.Zadania.Budzetowanie.RodzajKwotyBudzProj`)
- `PlanKoszt` = 0
- `Realizacja` = 1
- `PlanPrzychod` = 2
