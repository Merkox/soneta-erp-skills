# Pola i właściwości klasy biznesowej: `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania`
Nazwa tabeli: `CzynnObDoPlan`
Tytuł: Czynności dla obiektu do planowania
Opis: Czynność przypisana do obiektu do planowania w określonym okresie. Łączy definicję czynności z obiektem i elementem struktury organizacyjnej, umożliwiając planowanie konkretnych zadań na zasobach.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaCzynnosciNaObiekcie` | bazodanowe |  |  |
| ElementStruktury | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| Kod | `string` |  |  |  |
| ObiektDoPlanowania | `Soneta.Kalend.ObiektDoPlanowania` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
