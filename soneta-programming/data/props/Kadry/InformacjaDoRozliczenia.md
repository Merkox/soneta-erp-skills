# Pola i właściwości klasy biznesowej: `Soneta.Kadry.InformacjaDoRozliczenia`
Nazwa tabeli: `InformacjeDoRozl`
Opis: Element szczegółowy umowy zewnętrznej (UmowaZewnetrzna). Informacja do rozliczenia umowy zewnętrznej łącząca umowę z definicją elementu rozliczenia i okresem, dla którego ma być naliczony dany składnik wynagrodzenia.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `InformacjeDoRozliczeniaHistoria`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementuRozliczenia` | bazodanowe |  |  |
| Historia | `HistorySubTable<Soneta.Kadry.InformacjeDoRozliczeniaHistoria>` | podlista |  |  |
| Last | `Soneta.Kadry.InformacjeDoRozliczeniaHistoria` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Umowa | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe, tylko-odczyt |  |  |
