# Pola i właściwości klasy biznesowej: `Soneta.CRM.BranzaKth`
Nazwa tabeli: `BranzeKth`
Tytuł: Branże kontrahentów
Opis: Element szczegółowy kontrahenta (BranzaKth). Przypisuje kontrahentowi branżę ze słownika, umożliwiając klasyfikację bazy klientów według sektorów działalności gospodarczej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Kontrahent` → `Kontrahent`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Branza | `Soneta.CRM.Config.Branza` | bazodanowe, tylko-odczyt |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt, guided-parent |  |  |
