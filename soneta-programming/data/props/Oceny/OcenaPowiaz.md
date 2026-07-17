# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaPowiaz`
Nazwa tabeli: `OcenyPowiaz`
Tytuł: Powiązanie z ankietą
Opis: Powiązanie zewnętrznego podmiotu (np. kontrahenta) z procesem oceny jako źródło lub podmiot oceniany. Umożliwia przeprowadzanie ankiet i ocen dla podmiotów spoza struktury kadrowej, np. oceny dostawców lub badania satysfakcji klientów.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IOceniany`, `IŹródłoOceny`

- pola bazodanowe: 1
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  | Data utworzenia powiązania |
| Nazwa | `string` |  |  |  |
| Oceniani | `Soneta.Business.SubTable<Soneta.Oceny.OcenaOceniany>` |  |  |  |
| PowiązaneOceny | `Soneta.Business.SubTable<Soneta.Oceny.OcenaRealizacja>` |  |  |  |
