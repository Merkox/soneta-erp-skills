# Pola i właściwości klasy biznesowej: `Soneta.Oceny.ElementSkaliOcen`
Nazwa tabeli: `ElementySkalOcen`
Tytuł: Elementy skal ocen
Opis: Element szczegółowy skali ocen (ElementSkaliOcen). Reprezentuje pojedynczą wartość dostępną w skali (np. ocenę 1-5, opis 'bardzo dobry'), wraz z wartością liczbową, punktacją i przedziałem wykonania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisJednaLinia | `string` | tylko-odczyt | Opis |  |
| Punktacja | `decimal` | bazodanowe | Punktacja |  |
| Skala | `Soneta.Oceny.SkalaOcen` | bazodanowe, tylko-odczyt |  |  |
| Skrot | `string` | bazodanowe |  |  |
| UzasadnieniaOceny | `SubTable<Soneta.Oceny.UzasadnienieOceny>` | podlista |  |  |
| Uzasadnienie | `bool` | bazodanowe |  |  |
| Wartosc | `decimal` | bazodanowe | Wartość |  |
| WykonanieDo | `decimal` | bazodanowe | Wykonanie do |  |
| WykonanieDoInt | `int` |  | Wykonanie do |  |
| WykonanieOd | `decimal` | bazodanowe | Wykonanie od |  |
| WykonanieOdInt | `int` |  | Wykonanie od |  |
