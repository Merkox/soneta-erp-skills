# Pola i właściwości klasy biznesowej: `Soneta.CRM.KategoriaKth`
Nazwa tabeli: `KategorieKth`
Tytuł: Tabela powiązań kategorii z kontrahentami
Opis: Element szczegółowy kontrahenta (KategoriaKth). Przypisuje kontrahentowi jedną z predefiniowanych kategorii, umożliwiając klasyfikację i segmentację bazy kontrahentów według dowolnych kryteriów biznesowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Kontrahent` → `Kontrahent`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kategoria | `Soneta.CRM.DefKategKth` | bazodanowe |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, guided-parent |  |  |
