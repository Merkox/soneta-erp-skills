# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia`
Nazwa tabeli: `ProZasobyOZ`
Tytuł: Zasoby operacji zleceń
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Definiuje zasób (gniazdo, robociznę, narzędzie) przypisany do operacji zlecenia z normami czasu wykonania i przygotowania, stawką, terminami pracy, ilościami zameldowanymi oraz parametrami rejestracji i kalkulacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaRejestracji | `bool` | bazodanowe | Blokada rejestracji | Zablokowanie rejestracji czasów prac dla zasobu operacji zlecenia. |
| Czas | `TimeSec` | bazodanowe |  | Czas zasobu operacji zlecenia. |
| CzasJednostkowy | `double` | bazodanowe | Czas jednostkowy | Czas jednostkowy zasobu operacji zlecenia. |
| CzasRozpoczecia | `TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia zasobu zlecenia. |
| CzasTpz | `TimeSec` | bazodanowe | Czas tpz | Czas przygotowawczo-zakończeniowy zasobu operacji zlecenia. |
| CzasTw | `TimeSec` | bazodanowe | Czas tw | Czas wykonania zasobu operacji zlecenia. |
| CzasZakonczenia | `TimeSec` |  | Czas zakończenia | Czas zakończenia zasobu zlecenia. |
| CzasZameldowany | `TimeSec` | bazodanowe | Czas zameldowany | Czas zameldowany zasobu operacji zlecenia. |
| CzasyPracy | `SubTable<Soneta.ProdukcjaPro.ProCzasPracy>` | podlista |  |  |
| DataRozpoczecia | `Date` |  | Data rozpoczęcia | Data rozpoczęcia zasobu zlecenia. |
| DataZakonczenia | `Date` |  | Data zakończenia | Data zakończenia zasobu zlecenia. |
| DefinicjaAkordu | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe | Definicja akordu | Definicja akordu zasobu operacji zlecenia. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość zasobu operacji zlecenia. |
| IloscDoZameldowania | `Amount` | bazodanowe | Ilość do zameldowania | Ilość do zameldowania zasobu operacji zlecenia. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa zasobu operacji zlecenia. |
| IloscZameldowana | `Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana zasobu operacji zlecenia. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa zasobu operacji zlecenia. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja dla zasobu operacji zlecenia. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis zasobu operacji zlecenia. |
| PlanyPracy | `LpSubTable<Soneta.ProdukcjaPro.ProPlanPracy>` | podlista |  |  |
| PochodziZMeldunku | `bool` | bazodanowe | Pochodzi z meldunku | Zasób operacji zlecenia pochodzi z zasobu meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji zasobu operacji zlecenia. |
| RelacjePozycjiKompetencji | `LpSubTable<Soneta.ProdukcjaPro.ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji>` | podlista |  |  |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` (enum) | bazodanowe | Rodzaj zasobu | Rodzaj zasobu operacji zlecenia. |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia zasobu operacji zlecenia. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka zasobu operacji zlecenia. |
| Wariantowosci | `LpSubTable<Soneta.ProdukcjaPro.ProWariantowoscZasobuOperacjiZlecenia>` | podlista |  |  |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość zasobu operacji zlecenia. |
| WartoscStawki | `Currency` | bazodanowe | Wartość stawki | Wartość stawki zasobu operacji zlecenia. |
| WartoscZameldowana | `Currency` | bazodanowe | Wartość zameldowana | Wartość zameldowana zasobu operacji zlecenia. |
| WyborZasobu | `Soneta.ProdukcjaPro.ProWyborZasobu` (enum) | bazodanowe | Wybór zasobu | Wybór zasobu dla zasobu operacji zlecenia. |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia zasobu operacji zlecenia. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Zasób | Zasób dla zasobu operacji zlecenia. |
| ZasobOperacjiTechnologii | `Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii` | bazodanowe | Zasób operacji technologii | Zasób operacji technologii dla zasobu operacji zlecenia. |
| ZasobyMeldunkow | `SubTable<Soneta.ProdukcjaPro.ProZasobMeldunku>` | podlista |  |  |

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
