# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.EkoPaliwoStawka`
Nazwa tabeli: `EkoPaliwaStawki`
Tytuł: Stawki opłat za emisję
Opis: Element szczegółowy powiązania paliwa z silnikiem (EkoPaliwoSilnika). Przechowuje historyczne stawki opłat za emisję spalin obowiązujące w danym okresie dla konkretnego rodzaju paliwa i silnika. Służy do naliczania opłat za korzystanie ze środowiska w rozliczeniach środowiskowych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `PaliwoSilnika` → `EkoPaliwoSilnika`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe | Okres aktualności | Okres obowiązywania stawki |
| PaliwoSilnika | `Soneta.Samochodowka.EkoPaliwoSilnika` | bazodanowe, guided-parent |  | Paliwo silnika |
| Parent | `Soneta.Business.Row` |  |  |  |
| Stawka | `Soneta.Types.Currency` | bazodanowe | Stawka | Wysokość stawki za emisję |
