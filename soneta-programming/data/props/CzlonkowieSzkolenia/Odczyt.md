# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.Odczyt`
Nazwa tabeli: `Odczyty`
Opis: Rejestr odczytów i wykładów organizowanych poza regularnymi szkoleniami. Przechowuje dane o jednorazowych wystąpieniach, prelekcjach lub referatach z datą, godziną i przypisanym wykładowcą.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasDo | `Soneta.Types.Time` | bazodanowe | Godzina zakończenia | Godzina zakończenia. |
| CzasOd | `Soneta.Types.Time` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia. |
| Czlonkowie | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.OdczytCzlonek>` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data odczytu | Data odczytu. |
| Nazwa | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy |  |
| Opis | `string` | bazodanowe | Opis | Krótki opis odczytu. |
| Wykladowca | `Soneta.CzlonkowieSzkolenia.WykladowcaSzkol` | bazodanowe | Wykładowca |  |
