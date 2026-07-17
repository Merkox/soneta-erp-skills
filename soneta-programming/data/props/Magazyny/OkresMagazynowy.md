# Pola i właściwości klasy biznesowej: `Soneta.Magazyny.OkresMagazynowy`
Nazwa tabeli: `OkresyMag`
Tytuł: Okresy magazynowe
Opis: Okres magazynowy definiujący przedział czasowy, w ramach którego ewidencjonowane są obroty i zasoby. Zamknięcie okresu blokuje możliwość modyfikacji danych magazynowych w tym przedziale.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Info | `string` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Określa okres czasu, dla którego jest aktualny ten okres magazynowy. |
| Poprzedni | `Soneta.Magazyny.OkresMagazynowy` |  |  |  |
| Zamkniety | `bool` | bazodanowe | Zamknięty | Określa, czy okres magazynowy jest zamknięty bez prawa do jego modyfikacji. |
| ZamkniętyText | `string` |  |  | Informacja o tym, czy okres jest zamknięty w postaci tekstowej. |
