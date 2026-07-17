# Pola i właściwości klasy biznesowej: `Soneta.Kadry.InformacjaDoRozliczenia`
Nazwa tabeli: `InformacjeDoRozl`
Opis: Element szczegółowy umowy zewnętrznej (UmowaZewnetrzna). Informacja do rozliczenia umowy zewnętrznej łącząca umowę z definicją elementu rozliczenia i okresem, dla którego ma być naliczony dany składnik wynagrodzenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementuRozliczenia` | bazodanowe |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Kadry.InformacjeDoRozliczeniaHistoria>` |  |  |  |
| Last | `Soneta.Kadry.InformacjeDoRozliczeniaHistoria` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe |  |  |
