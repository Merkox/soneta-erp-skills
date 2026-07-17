# Pola i właściwości klasy biznesowej: `Soneta.CRM.BranzaKth`
Nazwa tabeli: `BranzeKth`
Tytuł: Branże kontrahentów
Opis: Element szczegółowy kontrahenta (BranzaKth). Przypisuje kontrahentowi branżę ze słownika, umożliwiając klasyfikację bazy klientów według sektorów działalności gospodarczej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Kontrahent` → `Kontrahent`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Branza | `Soneta.CRM.Config.Branza` | bazodanowe |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, guided-parent |  |  |
