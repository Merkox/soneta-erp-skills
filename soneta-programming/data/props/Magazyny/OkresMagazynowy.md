# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.OkresMagazynowy`
Nazwa tabeli: `OkresyMag`
Tytuł: Okresy magazynowe
Opis: Okres magazynowy definiujący przedział czasowy, w ramach którego ewidencjonowane są obroty i zasoby. Zamknięcie okresu blokuje możliwość modyfikacji danych magazynowych w tym przedziale.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Info | `string` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  | Określa okres czasu, dla którego jest aktualny ten okres magazynowy. |
| Poprzedni | `Soneta.Magazyny.OkresMagazynowy` | tylko-odczyt |  |  |
| Zamkniety | `bool` | bazodanowe | Zamknięty | Określa, czy okres magazynowy jest zamknięty bez prawa do jego modyfikacji. |
| ZamkniętyText | `string` | tylko-odczyt |  | Informacja o tym, czy okres jest zamknięty w postaci tekstowej. |
