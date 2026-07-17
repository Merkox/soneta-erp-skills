# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProWariantowoscZasobuOperacjiTechnologii`
Nazwa tabeli: `ProWarZasobowOT`
Tytuł: Wariantowość zasobów operacji technologii
Opis: Element szczegółowy zasobu operacji technologii (ProZasobOperacjiTechnologii). Definiuje alternatywne zasoby z indywidualnymi stawkami i normami czasu jednostkowego oraz przygotowawczo-zakończeniowego, umożliwiając elastyczny dobór zamienników zasobów w operacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ZasobOperacjiTechnologii` → `ProZasobOperacjiTechnologii`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasTj | `Soneta.Types.TimeSec` | bazodanowe | Czas tj | Czas jednostkowy wariantowości zasobu operacji technologii. |
| CzasTpz | `Soneta.Types.TimeSec` | bazodanowe | Czas tpz | Czas przygotowawczo-zakończeniowy wariantowości zasobu operacji technologii. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wariantowości zasobu operacji technologii. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka wariantowości zasobu operacji technologii. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe | Zasób | Zasób dla zasobu operacji technologii. |
| ZasobOperacjiTechnologii | `Soneta.ProdukcjaPro.ProZasobOperacjiTechnologii` | bazodanowe, guided-parent | Zasób operacji technologii | Zasób operacji technologii dla wariantowości zasobu operacji technologii. |
