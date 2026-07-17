# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia`
Nazwa tabeli: `ProZasobyOZ`
Tytuł: Zasoby operacji zleceń
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Definiuje zasób (gniazdo, robociznę, narzędzie) przypisany do operacji zlecenia z normami czasu wykonania i przygotowania, stawką, terminami pracy, ilościami zameldowanymi oraz parametrami rejestracji i kalkulacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe: 26
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaRejestracji | `bool` | bazodanowe | Blokada rejestracji | Zablokowanie rejestracji czasów prac dla zasobu operacji zlecenia. |
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas zasobu operacji zlecenia. |
| CzasJednostkowy | `double` | bazodanowe | Czas jednostkowy | Czas jednostkowy zasobu operacji zlecenia. |
| CzasRozpoczecia | `Soneta.Types.TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia zasobu zlecenia. |
| CzasTpz | `Soneta.Types.TimeSec` | bazodanowe | Czas tpz | Czas przygotowawczo-zakończeniowy zasobu operacji zlecenia. |
| CzasTw | `Soneta.Types.TimeSec` | bazodanowe | Czas tw | Czas wykonania zasobu operacji zlecenia. |
| CzasZakonczenia | `Soneta.Types.TimeSec` |  | Czas zakończenia | Czas zakończenia zasobu zlecenia. |
| CzasZameldowany | `Soneta.Types.TimeSec` | bazodanowe | Czas zameldowany | Czas zameldowany zasobu operacji zlecenia. |
| CzasyPracy | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProCzasPracy>` |  |  |  |
| DataRozpoczecia | `Soneta.Types.Date` |  | Data rozpoczęcia | Data rozpoczęcia zasobu zlecenia. |
| DataZakonczenia | `Soneta.Types.Date` |  | Data zakończenia | Data zakończenia zasobu zlecenia. |
| DefinicjaAkordu | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe | Definicja akordu | Definicja akordu zasobu operacji zlecenia. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość zasobu operacji zlecenia. |
| IloscDoZameldowania | `Soneta.Types.Amount` | bazodanowe | Ilość do zameldowania | Ilość do zameldowania zasobu operacji zlecenia. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa zasobu operacji zlecenia. |
| IloscZameldowana | `Soneta.Types.Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana zasobu operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa zasobu operacji zlecenia. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla zasobu operacji zlecenia. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis zasobu operacji zlecenia. |
| PlanyPracy | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProPlanPracy>` |  |  |  |
| PochodziZMeldunku | `bool` | bazodanowe | Pochodzi z meldunku | Zasób operacji zlecenia pochodzi z zasobu meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji zasobu operacji zlecenia. |
| RelacjePozycjiKompetencji | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji>` |  |  |  |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` | bazodanowe, enum | Rodzaj zasobu | Rodzaj zasobu operacji zlecenia. |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia zasobu operacji zlecenia. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka zasobu operacji zlecenia. |
| Wariantowosci | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProWariantowoscZasobuOperacjiZlecenia>` |  |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość zasobu operacji zlecenia. |
| WartoscStawki | `Soneta.Types.Currency` | bazodanowe | Wartość stawki | Wartość stawki zasobu operacji zlecenia. |
| WartoscZameldowana | `Soneta.Types.Currency` | bazodanowe | Wartość zameldowana | Wartość zameldowana zasobu operacji zlecenia. |
| WyborZasobu | `Soneta.ProdukcjaPro.ProWyborZasobu` | bazodanowe, enum | Wybór zasobu | Wybór zasobu dla zasobu operacji zlecenia. |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia zasobu operacji zlecenia. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Zasób | Zasób dla zasobu operacji zlecenia. |
| ZasobOperacjiTechnologii | `Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii` | bazodanowe | Zasób operacji technologii | Zasób operacji technologii dla zasobu operacji zlecenia. |
| ZasobyMeldunkow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProZasobMeldunku>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRodzajZasobu (`Soneta.ProdukcjaPro.ProRodzajZasobu`)
- `None` = 0
- `GniazdoProdukcyjne` = 1 — Gniazdo produkcyjne
- `JednostkaRobocza` = 2 — Jednostka robocza
- `Narzedzie` = 4 — Narzędzie
- `Kooperacja` = 8 — Kooperacja
- `All` = 15 — Wszystkie

### ProWyborZasobu (`Soneta.ProdukcjaPro.ProWyborZasobu`)
- `None` = 0
- `Kompetencje` = 1 — Wg właściwości
- `Zasob` = 2 — Wg zasobu
- `All` = 3 — Wszystkie
