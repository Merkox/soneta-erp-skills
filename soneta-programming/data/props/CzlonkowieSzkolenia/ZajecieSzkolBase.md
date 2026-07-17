# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase`
Nazwa tabeli: `ZajeciaSzkol`
Tytuł: Zajęcia
Opis: Harmonogram zajęć szkoleniowych realizowanych w ramach grup szkoleniowych. Definiuje poszczególne spotkania z datami, godzinami, przedmiotami, wykładowcami i salami, stanowiąc podstawę ewidencji frekwencji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoOceny`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` |  |  |  |
| CzasDo | `Soneta.Types.Time` | bazodanowe | Godzina zakończenia | Godzina zakończenia. |
| CzasOd | `Soneta.Types.Time` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia. |
| Data | `Soneta.Types.Date` | bazodanowe | Data zajęcia | Data zajęcia. |
| Description | `string` |  |  |  |
| DlugoscPrzerw | `int` | bazodanowe | Długość przerw | Sumaryczna długość przerw w minutach. |
| End | `System.DateTime` |  |  |  |
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` | bazodanowe |  |  |
| IloscGodzin | `double` | bazodanowe | Liczba godzin | Liczba jednostek lekcyjnych. |
| JestKontrolaHarmonogramu | `bool` |  |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe | Kontrahent, któremu wynajmujemy salę | Kontrahent, któremu wynajmujemy salę. |
| Nazwa | `string` | bazodanowe |  |  |
| NieWliczac | `bool` | bazodanowe |  | Nie wliczać do wymiaru godzin. |
| PowiązaneOceny | `Soneta.Business.SubTable<Soneta.Oceny.OcenaRealizacja>` |  |  |  |
| PrzedmiotSzkol | `Soneta.CzlonkowieSzkolenia.PrzedmiotSzkol` | bazodanowe | Przedmiot realizowany na zajęciach | Przedmiot realizowany na zajęciach. |
| Resource | `object` |  |  |  |
| Sala | `Soneta.CzlonkowieSzkolenia.SalaSzkol` |  |  |  |
| SaleSzkol | `Soneta.Business.SubTable` |  |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Stan | `Soneta.CzlonkowieSzkolenia.StanZajeciaSzkol` | bazodanowe, enum | Stan zajęcia | Stan zajęcia szkoleniowego. |
| Start | `System.DateTime` |  |  |  |
| Text | `string` |  |  |  |
| Typ | `Soneta.CzlonkowieSzkolenia.TypZajeciaSzkol` | bazodanowe, enum |  |  |
| Uczestnicy | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZajecieUczestnik>` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Dodatkowe uwagi | Dodatkowe uwagi. |
| Wykladowca | `Soneta.CzlonkowieSzkolenia.WykladowcaSzkol` |  |  |  |
| WykladowcySzkol | `Soneta.Business.SubTable` |  |  |  |
| WykladowcySzkolKomisja | `System.Collections.IEnumerable` |  |  |  |
| WykladowcySzkolLekcja | `System.Collections.IEnumerable` |  |  |  |
| WykladowcySzkolWizytacja | `System.Collections.IEnumerable` |  |  |  |
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
