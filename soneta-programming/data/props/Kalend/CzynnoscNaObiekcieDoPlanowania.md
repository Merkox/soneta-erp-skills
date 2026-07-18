# Pola i właściwości klasy biznesowej: `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania`
Nazwa tabeli: `CzynnObDoPlan`
Tytuł: Czynności dla obiektu do planowania
Opis: Czynność przypisana do obiektu do planowania w określonym okresie. Łączy definicję czynności z obiektem i elementem struktury organizacyjnej, umożliwiając planowanie konkretnych zadań na zasobach.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaCzynnosciNaObiekcie` | bazodanowe, tylko-odczyt |  |  |
| ElementStruktury | `Soneta.Core.ElementStrukturyOrganizacyjnej` | bazodanowe |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| ObiektDoPlanowania | `Soneta.Kalend.ObiektDoPlanowania` | bazodanowe, tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
