# Pola i właściwości klasy biznesowej: `Soneta.CRM.KategoriaKth`
Nazwa tabeli: `KategorieKth`
Tytuł: Tabela powiązań kategorii z kontrahentami
Opis: Element szczegółowy kontrahenta (KategoriaKth). Przypisuje kontrahentowi jedną z predefiniowanych kategorii, umożliwiając klasyfikację i segmentację bazy kontrahentów według dowolnych kryteriów biznesowych.
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
| Kategoria | `Soneta.CRM.DefKategKth` | bazodanowe, tylko-odczyt |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt, guided-parent |  |  |
