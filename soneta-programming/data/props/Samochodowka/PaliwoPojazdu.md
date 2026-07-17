# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.PaliwoPojazdu`
Nazwa tabeli: `PaliwaPojazdu`
Tytuł: Paliwa pojazdu
Opis: Element szczegółowy kartoteki pojazdu (Pojazd). Przypisuje rodzaje paliw kompatybilne z silnikiem pojazdu, ze wskazaniem paliwa domyślnego. Służy do prawidłowego rozliczania kosztów paliwa i naliczania opłat środowiskowych za emisję.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Domyslne | `bool` | bazodanowe | Domyślne | Czy domyślne paliwo dla silnika |
| PaliwoSilnika | `Soneta.Samochodowka.EkoPaliwoSilnika` | bazodanowe |  |  |
| Pojazd | `Soneta.Samochodowka.Pojazd` | bazodanowe |  |  |
