# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.PaliwoPojazdu`
Nazwa tabeli: `PaliwaPojazdu`
Tytuł: Paliwa pojazdu
Opis: Element szczegółowy kartoteki pojazdu (Pojazd). Przypisuje rodzaje paliw kompatybilne z silnikiem pojazdu, ze wskazaniem paliwa domyślnego. Służy do prawidłowego rozliczania kosztów paliwa i naliczania opłat środowiskowych za emisję.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Domyslne | `bool` | bazodanowe | Domyślne | Czy domyślne paliwo dla silnika |
| PaliwoSilnika | `Soneta.Samochodowka.EkoPaliwoSilnika` | bazodanowe, tylko-odczyt |  |  |
| Pojazd | `Soneta.Samochodowka.Pojazd` | bazodanowe, tylko-odczyt |  |  |
