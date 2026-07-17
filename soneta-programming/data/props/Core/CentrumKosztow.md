# Pola i właściwości klasy biznesowej: `Soneta.Core.CentrumKosztow`
Nazwa tabeli: `CentraKosztow`
Opis: Słownik centrów kosztów używanych do klasyfikacji kosztów w opisie analitycznym. Każde centrum posiada unikalną nazwę, opis oraz flagę blokady.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe | Opis | Opis centrum kosztów. |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Symbol | `string` |  |  |  |
| Zablokowane | `bool` | bazodanowe |  |  |
