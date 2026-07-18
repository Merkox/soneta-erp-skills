# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZespolSzkol`
Nazwa tabeli: `ZespolySzkol`
Tytuł: Zespoły
Opis: Zespoły szkoleniowe wydzielone w ramach grupy szkoleniowej. Umożliwiają podział uczestników grupy na mniejsze podgrupy do realizacji zajęć laboratoryjnych, ćwiczeniowych lub projektowych.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 7
- subrowy: 0
- razem: 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` | bazodanowe |  |  |
| IloscGodzinRealizacja | `double` | tylko-odczyt |  |  |
| IloscUczestnikow | `int` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe | Numer kolejny zespołu |  |
| PrzedmiotyRoznica | `System.Collections.ArrayList` | podlista |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| StrLp | `string` | tylko-odczyt |  |  |
| Uczestnicy | `SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik>` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi | Dodatkowe uwagi. |
| View | `View` | podlista |  |  |
| WliczajDoZajec | `bool` | bazodanowe | Wliczaj do zajęć zrealizowanych |  |
| Zajecia | `SubTable<Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase>` | podlista |  |  |
| ZajeciaGrupyZespolu | `View` | podlista |  |  |
| ZajeciaWszystkieWliczane | `System.Collections.Generic.IEnumerable<Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase>` | podlista |  |  |
