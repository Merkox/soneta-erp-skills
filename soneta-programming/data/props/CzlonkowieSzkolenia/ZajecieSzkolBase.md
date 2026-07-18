# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase`
Nazwa tabeli: `ZajeciaSzkol`
Tytuł: Zajęcia
Opis: Harmonogram zajęć szkoleniowych realizowanych w ramach grup szkoleniowych. Definiuje poszczególne spotkania z datami, godzinami, przedmiotami, wykładowcami i salami, stanowiąc podstawę ewidencji frekwencji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoOceny`

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 11
- podlisty: 5
- subrowy: 0
- razem: 32

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| CzasDo | `Time` | bazodanowe | Godzina zakończenia | Godzina zakończenia. |
| CzasOd | `Time` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia. |
| Data | `Date` | bazodanowe | Data zajęcia | Data zajęcia. |
| Description | `string` | tylko-odczyt |  |  |
| DlugoscPrzerw | `int` | bazodanowe | Długość przerw | Sumaryczna długość przerw w minutach. |
| End | `System.DateTime` | tylko-odczyt |  |  |
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` | bazodanowe |  |  |
| IloscGodzin | `double` | bazodanowe | Liczba godzin | Liczba jednostek lekcyjnych. |
| JestKontrolaHarmonogramu | `bool` | tylko-odczyt |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe | Kontrahent, któremu wynajmujemy salę | Kontrahent, któremu wynajmujemy salę. |
| Nazwa | `string` | bazodanowe |  |  |
| NieWliczac | `bool` | bazodanowe |  | Nie wliczać do wymiaru godzin. |
| PowiązaneOceny | `SubTable<Soneta.Oceny.OcenaRealizacja>` | podlista |  |  |
| PrzedmiotSzkol | `Soneta.CzlonkowieSzkolenia.PrzedmiotSzkol` | bazodanowe | Przedmiot realizowany na zajęciach | Przedmiot realizowany na zajęciach. |
| Resource | `object` | tylko-odczyt |  |  |
| Sala | `Soneta.CzlonkowieSzkolenia.SalaSzkol` |  |  |  |
| SaleSzkol | `SubTable` | podlista |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Stan | `Soneta.CzlonkowieSzkolenia.StanZajeciaSzkol` (enum) | bazodanowe | Stan zajęcia | Stan zajęcia szkoleniowego. |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Text | `string` |  |  |  |
| Typ | `Soneta.CzlonkowieSzkolenia.TypZajeciaSzkol` (enum) | bazodanowe, tylko-odczyt |  |  |
| Uczestnicy | `SubTable<Soneta.CzlonkowieSzkolenia.ZajecieUczestnik>` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Dodatkowe uwagi | Dodatkowe uwagi. |
| Wykladowca | `Soneta.CzlonkowieSzkolenia.WykladowcaSzkol` |  |  |  |
| WykladowcySzkol | `SubTable` | podlista |  |  |
| WykladowcySzkolKomisja | `System.Collections.IEnumerable` | tylko-odczyt |  |  |
| WykladowcySzkolLekcja | `System.Collections.IEnumerable` | tylko-odczyt |  |  |
| WykladowcySzkolWizytacja | `System.Collections.IEnumerable` | tylko-odczyt |  |  |
| Zablokowany | `bool` | bazodanowe |  | Zajecie jest zablokowane. |
| ZespolSzkol | `Soneta.CzlonkowieSzkolenia.ZespolSzkol` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanZajeciaSzkol (`Soneta.CzlonkowieSzkolenia.StanZajeciaSzkol`)
- `Rezerwacja` = 1 — Rezerwacja
- `Zajęte` = 2
- `Odwołane` = 3
- `Razem` = 99

### TypZajeciaSzkol (`Soneta.CzlonkowieSzkolenia.TypZajeciaSzkol`)
- `Lekcja` = 1 — Lekcja
- `Wynajem` = 2
- `EgzaminZwyczajny` = 3
- `EgzaminPoprawkowy` = 4
- `EgzaminRozszerzony` = 5
