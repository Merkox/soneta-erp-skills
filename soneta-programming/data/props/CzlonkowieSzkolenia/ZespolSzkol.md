# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZespolSzkol`
Nazwa tabeli: `ZespolySzkol`
Tytuł: Zespoły
Opis: Zespoły szkoleniowe wydzielone w ramach grupy szkoleniowej. Umożliwiają podział uczestników grupy na mniejsze podgrupy do realizacji zajęć laboratoryjnych, ćwiczeniowych lub projektowych.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` | bazodanowe |  |  |
| IloscGodzinRealizacja | `double` |  |  |  |
| IloscUczestnikow | `int` |  |  |  |
| Lp | `int` | bazodanowe | Numer kolejny zespołu |  |
| PrzedmiotyRoznica | `System.Collections.ArrayList` |  |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| StrLp | `string` |  |  |  |
| Uczestnicy | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik>` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi | Dodatkowe uwagi. |
| View | `Soneta.Business.View` |  |  |  |
| WliczajDoZajec | `bool` | bazodanowe | Wliczaj do zajęć zrealizowanych |  |
| Zajecia | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase>` |  |  |  |
| ZajeciaGrupyZespolu | `Soneta.Business.View` |  |  |  |
| ZajeciaWszystkieWliczane | `System.Collections.Generic.IEnumerable<Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase>` |  |  |  |
