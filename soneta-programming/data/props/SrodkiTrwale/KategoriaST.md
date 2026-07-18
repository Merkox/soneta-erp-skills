# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.KategoriaST`
Nazwa tabeli: `KategorieST`
Tytuł: Kategorie środka trwałego
Opis: Słownik kategorii środków trwałych służący do dodatkowej klasyfikacji majątku. Pozwala oznaczyć, czy kategoria dotyczy środków trwałych, wartości niematerialnych i prawnych, czy wyposażenia. Wspiera filtrowanie i raportowanie ewidencji.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Środek zablokowany |
| Kod | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa kategorii srodka trwałego |
| Opis | `string` | bazodanowe |  | Opis kategorii srodka trwałego |
| Symbol | `string` | bazodanowe |  | Symbol kategorii srodka trwałego |
| TypST | `bool` | bazodanowe | Typ środek trwały | Typ środek trwały |
| TypWNiP | `bool` | bazodanowe | Typ WNiP | Typ wartości niematerialne i prawne |
| TypWyposazenie | `bool` | bazodanowe | Typ wyposażenie | Typ wyposażenie |
