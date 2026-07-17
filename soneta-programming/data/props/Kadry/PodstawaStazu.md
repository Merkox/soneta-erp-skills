# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PodstawaStazu`
Nazwa tabeli: `PodstawyStazow`
Tytuł: Podstawy stażu pracy
Opis: Element szczegółowy historii zatrudnienia (HistoriaZatrudnieniaBase). Przypisanie definicji podstawy stażu do konkretnego wpisu historii zatrudnienia, określające które rodzaje stażu powinny uwzględniać dany okres pracy lub nauki.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kadry.DefPodstawyStazu` | bazodanowe |  |  |
| Staż | `Soneta.Kadry.StazPracy` |  |  |  |
| Zatrudnienie | `Soneta.Kadry.HistoriaZatrudnieniaBase` | bazodanowe |  |  |
