# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaPowiaz`
Nazwa tabeli: `OcenyPowiaz`
Tytuł: Powiązanie z ankietą
Opis: Powiązanie zewnętrznego podmiotu (np. kontrahenta) z procesem oceny jako źródło lub podmiot oceniany. Umożliwia przeprowadzanie ankiet i ocen dla podmiotów spoza struktury kadrowej, np. oceny dostawców lub badania satysfakcji klientów.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOceniany`, `IŹródłoOceny`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data utworzenia powiązania |
| Nazwa | `string` | tylko-odczyt |  |  |
| Oceniani | `SubTable<Soneta.Oceny.OcenaOceniany>` | podlista |  |  |
| PowiązaneOceny | `SubTable<Soneta.Oceny.OcenaRealizacja>` | podlista |  |  |
