# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZasobMeldunku`
Nazwa tabeli: `ProZasobyM`
Tytuł: Zasoby meldunków
Opis: Element szczegółowy zasobu meldunku (ProMeldunek). Rejestruje zasób produkcyjny (gniazdo, pracownika lub narzędzie) wykorzystany w ramach meldunku. Przechowuje informacje o rodzaju zasobu, stawce, ilościach, czasie pracy planowanym i rzeczywistym oraz wartościach.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Meldunek` → `ProMeldunek`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `TimeSec` | bazodanowe |  | Czas zasobu meldunku. |
| CzasJednostkowy | `double` | bazodanowe | Czas jednostkowy | Czas jednostkowy zasobu meldunku. |
| CzasJednostkowyPlanowany | `double` | bazodanowe | Czas jednostkowy | Czas jednostkowy planowany zasobu meldunku. |
| CzasPlanowany | `TimeSec` | bazodanowe | Czas planowany | Czas planowany zasobu meldunku. |
| CzasZarejestrowany | `TimeSec` | bazodanowe | Czas zarejestrowany | Czas zarejestrowany zasobu meldunku. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość zasobu meldunku. |
| IloscJednostkowa | `double` | bazodanowe | Ilość jednostkowa | Ilość jednostkowa zasobu meldunku. |
| IloscJednostkowaPlanowana | `double` | bazodanowe | Ilość jednostkowa planowana | Ilość jednostkowa planowana zasobu meldunku. |
| IloscPlanowana | `Amount` | bazodanowe | Ilość planowana | Ilość planowana zasobu meldunku. |
| IloscZarejestrowana | `Amount` | bazodanowe | Ilość zarejestrowana | Ilość zarejestrowana zasobu meldunku. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa zasobu meldunku. |
| Meldunek | `Soneta.ProdukcjaPro.ProMeldunek` | bazodanowe, guided-parent |  | Meldunek dla zasobu meldunku. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis zasobu meldunku. |
| PominWKalkulacji | `bool` | bazodanowe | Pomiń w kalkulacji | Pomijanie w kalkulacji zasobu meldunku. |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` (enum) | bazodanowe | Rodzaj zasobu | Rodzaj zasobu meldunku. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka zasobu meldunku. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość zasobu meldunku. |
| WartoscPlanowana | `Currency` | bazodanowe | Wartość planowana | Wartość planowana zasobu meldunku. |
| WartoscStawki | `Currency` | bazodanowe | Wartość stawki | Wartość stawki zasobu meldunku. |
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
