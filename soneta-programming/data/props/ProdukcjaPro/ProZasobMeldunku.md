# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZasobMeldunku`
Nazwa tabeli: `ProZasobyM`
Tytuł: Zasoby meldunków
Opis: Element szczegółowy zasobu meldunku (ProMeldunek). Rejestruje zasób produkcyjny (gniazdo, pracownika lub narzędzie) wykorzystany w ramach meldunku. Przechowuje informacje o rodzaju zasobu, stawce, ilościach, czasie pracy planowanym i rzeczywistym oraz wartościach.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas zasobu meldunku. |
| CzasJednostkowy | `double` | bazodanowe | Czas jednostkowy | Czas jednostkowy zasobu meldunku. |
| CzasJednostkowyPlanowany | `double` | bazodanowe | Czas jednostkowy | Czas jednostkowy planowany zasobu meldunku. |
| CzasPlanowany | `Soneta.Types.TimeSec` | bazodanowe | Czas planowany | Czas planowany zasobu meldunku. |
| CzasZarejestrowany | `Soneta.Types.TimeSec` | bazodanowe | Czas zarejestrowany | Czas zarejestrowany zasobu meldunku. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość zasobu meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa zasobu meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana zasobu meldunku. |
| IloscPlanowana | `Soneta.Types.Amount` | bazodanowe | Ilość planowana | Ilość planowana zasobu meldunku. |
| IloscZarejestrowana | `Soneta.Types.Amount` | bazodanowe | Ilość zarejestrowana | Ilość zarejestrowana zasobu meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa zasobu meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla zasobu meldunku. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis zasobu meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji zasobu meldunku. |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` | bazodanowe, enum | Rodzaj zasobu | Rodzaj zasobu meldunku. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka zasobu meldunku. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość zasobu meldunku. |
| WartoscPlanowana | `Soneta.Types.Currency` | bazodanowe | Wartość planowana | Wartość planowana zasobu meldunku. |
| WartoscStawki | `Soneta.Types.Currency` | bazodanowe | Wartość stawki | Wartość stawki zasobu meldunku. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Zasób | Zasób dla zasobu meldunku. |
| ZasobOperacjiZlecenia | `Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia` | bazodanowe | Zasób operacji zlecenia | Zasób operacji zlecenia dla zasobu meldunku. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRodzajZasobu (`Soneta.ProdukcjaPro.ProRodzajZasobu`)
- `None` = 0
- `GniazdoProdukcyjne` = 1 — Gniazdo produkcyjne
- `JednostkaRobocza` = 2 — Jednostka robocza
- `Narzedzie` = 4 — Narzędzie
- `Kooperacja` = 8 — Kooperacja
- `All` = 15 — Wszystkie
