# Pola i właściwości klasy biznesowej: `Soneta.Oceny.ElementSkaliOcen`
Nazwa tabeli: `ElementySkalOcen`
Tytuł: Elementy skal ocen
Opis: Element szczegółowy skali ocen (ElementSkaliOcen). Reprezentuje pojedynczą wartość dostępną w skali (np. ocenę 1-5, opis 'bardzo dobry'), wraz z wartością liczbową, punktacją i przedziałem wykonania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisJednaLinia | `string` |  | Opis |  |
| Punktacja | `decimal` | bazodanowe | Punktacja |  |
| Skala | `Soneta.Oceny.SkalaOcen` | bazodanowe |  |  |
| Skrot | `string` | bazodanowe |  |  |
| UzasadnieniaOceny | `Soneta.Business.SubTable<Soneta.Oceny.UzasadnienieOceny>` |  |  |  |
| Uzasadnienie | `bool` | bazodanowe |  |  |
| Wartosc | `decimal` | bazodanowe | Wartość |  |
| WykonanieDo | `decimal` | bazodanowe | Wykonanie do |  |
| WykonanieDoInt | `int` |  | Wykonanie do |  |
| WykonanieOd | `decimal` | bazodanowe | Wykonanie od |  |
| WykonanieOdInt | `int` |  | Wykonanie od |  |
