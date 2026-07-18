# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii`
Nazwa tabeli: `ProZasobyOT`
Tytuł: Zasoby operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Definiuje zasób (gniazdo, stanowisko, robociznę lub narzędzie) wymagany w operacji technologicznej z normami czasu wykonania i przygotowania, stawką kosztową, ilością oraz parametrami rejestracji i akordu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaRejestracji | `bool` | bazodanowe | Blokada rejestracji | Zablokowanie rejestracji czasów prac dla zasobu operacji technologii. |
| CzasJednostkowy | `double` | bazodanowe | Czas jednostkowy | Czas jednostkowy zasobu operacji technologii. |
| CzasTpz | `TimeSec` | bazodanowe | Czas tpz | Czas przygotowawczo-zakończeniowy zasobu operacji technologii. |
| CzasTw | `TimeSec` | bazodanowe | Czas tw | Czas wykonania zasobu operacji technologii. |
| DefinicjaAkordu | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe | Definicja akordu | Definicja akordu zasobu operacji technologii. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość zasobu operacji technologii. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa zasobu operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa zasobu operacji technologii. |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla zasobu operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | tylko-odczyt | Operacja technologii | Operacja technologii dla zasobu operacji technologii. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis zasobu operacji technologii. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji zasobu operacji technologii. |
| RelacjePozycjiKompetencji | `LpSubTable<Soneta.ProdukcjaPro.ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji>` | podlista |  |  |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` (enum) | bazodanowe | Rodzaj zasobu | Rodzaj zasobu operacji technologii. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka zasobu operacji technologii. |
| Wariantowosci | `LpSubTable<Soneta.ProdukcjaPro.ProWariantowoscZasobuOperacjiTechnologii>` | podlista |  |  |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość zasobu operacji technologii. |
| WartoscStawki | `Currency` | bazodanowe | Wartość stawki | Wartość stawki zasobu operacji technologii. |
| WyborZasobu | `Soneta.ProdukcjaPro.ProWyborZasobu` (enum) | bazodanowe | Wybór zasobu | Wybór zasobu dla zasobu operacji technologii. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Zasób | Zasób dla zasobu operacji technologii. |
| ZasobyOperacjiZlecen | `SubTable<Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia>` | podlista |  |  |

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
