# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii`
Nazwa tabeli: `ProZasobyOT`
Tytuł: Zasoby operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Definiuje zasób (gniazdo, stanowisko, robociznę lub narzędzie) wymagany w operacji technologicznej z normami czasu wykonania i przygotowania, stawką kosztową, ilością oraz parametrami rejestracji i akordu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaRejestracji | `bool` | bazodanowe | Blokada rejestracji | Zablokowanie rejestracji czasów prac dla zasobu operacji technologii. |
| CzasJednostkowy | `double` | bazodanowe | Czas jednostkowy | Czas jednostkowy zasobu operacji technologii. |
| CzasTpz | `Soneta.Types.TimeSec` | bazodanowe | Czas tpz | Czas przygotowawczo-zakończeniowy zasobu operacji technologii. |
| CzasTw | `Soneta.Types.TimeSec` | bazodanowe | Czas tw | Czas wykonania zasobu operacji technologii. |
| DefinicjaAkordu | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe | Definicja akordu | Definicja akordu zasobu operacji technologii. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość zasobu operacji technologii. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa zasobu operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa zasobu operacji technologii. |
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla zasobu operacji technologii. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` |  | Operacja technologii | Operacja technologii dla zasobu operacji technologii. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis zasobu operacji technologii. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji zasobu operacji technologii. |
| RelacjePozycjiKompetencji | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji>` |  |  |  |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` | bazodanowe, enum | Rodzaj zasobu | Rodzaj zasobu operacji technologii. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka zasobu operacji technologii. |
| Wariantowosci | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProWariantowoscZasobuOperacjiTechnologii>` |  |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość zasobu operacji technologii. |
| WartoscStawki | `Soneta.Types.Currency` | bazodanowe | Wartość stawki | Wartość stawki zasobu operacji technologii. |
| WyborZasobu | `Soneta.ProdukcjaPro.ProWyborZasobu` | bazodanowe, enum | Wybór zasobu | Wybór zasobu dla zasobu operacji technologii. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Zasób | Zasób dla zasobu operacji technologii. |
| ZasobyOperacjiZlecen | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia>` |  |  |  |

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
