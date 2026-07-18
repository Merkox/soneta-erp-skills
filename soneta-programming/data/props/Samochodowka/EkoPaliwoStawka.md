# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.EkoPaliwoStawka`
Nazwa tabeli: `EkoPaliwaStawki`
Tytuł: Stawki opłat za emisję
Opis: Element szczegółowy powiązania paliwa z silnikiem (EkoPaliwoSilnika). Przechowuje historyczne stawki opłat za emisję spalin obowiązujące w danym okresie dla konkretnego rodzaju paliwa i silnika. Służy do naliczania opłat za korzystanie ze środowiska w rozliczeniach środowiskowych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `PaliwoSilnika` → `EkoPaliwoSilnika`
Historia: Tak — zapis historyczny tabeli `EkoPaliwoSilnika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista | Okres aktualności | Okres obowiązywania stawki |
| PaliwoSilnika | `Soneta.Samochodowka.EkoPaliwoSilnika` | bazodanowe, tylko-odczyt, guided-parent |  | Paliwo silnika |
| Parent | `Row` | tylko-odczyt |  |  |
| Stawka | `Currency` | bazodanowe | Stawka | Wysokość stawki za emisję |
