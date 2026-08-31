# Pola i właściwości klasy biznesowej: `Soneta.CRM.BranzaKth`
Nazwa tabeli: `BranzeKth`
Tytuł: Branże kontrahentów
Opis: Element szczegółowy kontrahenta (BranzaKth). Przypisuje kontrahentowi branżę ze słownika, umożliwiając klasyfikację bazy klientów według sektorów działalności gospodarczej.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Kontrahent` → `Kontrahent`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Branza | `Soneta.CRM.Config.Branza` | bazodanowe, tylko-odczyt |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt, guided-parent |  |  |
