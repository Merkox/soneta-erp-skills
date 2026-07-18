# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.Odczyt`
Nazwa tabeli: `Odczyty`
Opis: Rejestr odczytów i wykładów organizowanych poza regularnymi szkoleniami. Przechowuje dane o jednorazowych wystąpieniach, prelekcjach lub referatach z datą, godziną i przypisanym wykładowcą.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasDo | `Time` | bazodanowe | Godzina zakończenia | Godzina zakończenia. |
| CzasOd | `Time` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia. |
| Czlonkowie | `SubTable<Soneta.CzlonkowieSzkolenia.OdczytCzlonek>` | podlista |  |  |
| Data | `Date` | bazodanowe | Data odczytu | Data odczytu. |
| Nazwa | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy |  |
| Opis | `string` | bazodanowe | Opis | Krótki opis odczytu. |
| Wykladowca | `Soneta.CzlonkowieSzkolenia.WykladowcaSzkol` | bazodanowe | Wykładowca |  |
