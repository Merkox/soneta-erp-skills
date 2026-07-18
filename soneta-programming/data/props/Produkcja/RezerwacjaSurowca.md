# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.RezerwacjaSurowca`
Nazwa tabeli: `RezerwacjeSur`
Tytuł: Rezerwacje surowca
Opis: Rezerwacja surowca magazynowego na potrzeby realizacji zlecenia produkcyjnego. Przypisuje konkretny zasób magazynowy lub pozycję dokumentu przychodowego do pozycji technologicznej (surowca), blokując zarezerwowaną ilość towaru i zapobiegając jego wydaniu na inne cele.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataRezerwacji | `System.DateTime` | bazodanowe, tylko-odczyt | Data | Data rezerwacji. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość rezerwacji. |
| Operator | `App.Operator` | bazodanowe, tylko-odczyt |  | Operator dokonujący rezerwacji. |
| PozycjaPrzychod | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Pozycja | Rezerwowana pozycja dokumentu handlowego. |
| SurowiecTechn | `Soneta.Produkcja.PozycjaTechn` | bazodanowe | Surowiec | Surowiec technologiczny. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar rezerwacji. |
| ZasobPrzychod | `Soneta.Magazyny.Zasob` | bazodanowe | Zasób | Rezerwowany zasób. |
