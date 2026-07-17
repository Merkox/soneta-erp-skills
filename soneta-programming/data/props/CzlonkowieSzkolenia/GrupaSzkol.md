# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.GrupaSzkol`
Nazwa tabeli: `GrupySzkol`
Tytuł: Grupy szkoleniowe
Opis: Grupy szkoleniowe stanowiące konkretne edycje kursów z określonym terminem i harmonogramem. Przechowują dane organizacyjne szkolenia: daty, tryb zajęć, status realizacji oraz powiązanie z rodzajem szkolenia i towarem do fakturowania.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IZrodloHarmWplaty`, `IEmailElement`, `IOceniany`, `IŹródłoOceny`

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 35

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Certyfikaty | `Soneta.Business.View` |  |  |  |
| CzasDo | `Soneta.Types.TimeSec` | bazodanowe | Godzina rozpoczęcia | Godzina zakończenia grupy |
| CzasOd | `Soneta.Types.TimeSec` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia grupy |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Planowana data zakończenia. |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia. |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe | Data zamknięcia | Data zamknięcia grupy szkoleniowej. |
| DokumentyHan | `Soneta.Business.View` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| HarmonogramyWplat | `Soneta.Business.SubTable` |  |  |  |
| IloscGodzinPlan | `double` |  |  | Ilość godzin zajęć na rodzaju szkolenia z uwzględnieniem modułów. |
| IloscGodzinPlanOgolem | `double` |  |  | Ilość godzin zajęć na rodzaju szkolenia. |
| IloscGodzinRealizacja | `double` |  |  | Sumaryczna ilość godzin zajęć dla grupy (bez zajęć dla zespołów). |
| IloscGodzinRealizacjaNaUczestnika | `double` |  |  | Sumaryczna ilość godzin zajęć dla uczestnika. |
| IloscGodzinRealizacjaRazem | `double` |  |  | Sumaryczna ilość godzin zajęć dla grupy i wszystkich zespołów. |
| IloscGodzinRealizacjaZespolow | `double` |  |  | Sumaryczna ilość godzin zajęć dla wszystkich zespołow (bez zajęć dla grupy). |
| IloscUczestnikow | `int` |  |  |  |
| IloscUczestnikowAktywnych | `int` |  |  |  |
| IloscZajec | `int` |  |  |  |
| IsStandardCourse | `bool` |  |  |  |
| JestHarmonogram | `bool` |  |  |  |
| JestZespol | `bool` |  |  |  |
| MailTo | `string` |  |  |  |
| Materialy | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.GrupaMaterial>` |  |  |  |
| Modul | `Soneta.CzlonkowieSzkolenia.ModulSzkol` | bazodanowe | Moduł | Moduł z którym powiązane jest szkolenie. |
| Modulowe | `bool` |  |  |  |
| Nazwa | `string` |  |  |  |
| Numer | `string` | bazodanowe | Numer szkolenia | Numer szkolenia. |
| Oceniani | `Soneta.Business.SubTable` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| PowiązaneOceny | `Soneta.Business.SubTable` |  |  |  |
| PrzedmiotyRoznica | `System.Collections.ArrayList` |  |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  | Rodzaj szkolenia. |
| SaMaterialy | `bool` |  |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| StatusGrupySzkol | `Soneta.CzlonkowieSzkolenia.StatusGrupySzkol` | bazodanowe, enum |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe | Towar | Towar z którym powiązane jest szkolenie. |
| TowarWpisowe | `Soneta.Towary.Towar` | bazodanowe | Towar | Towar z którym powiązane jest wpisowe na studia. |
| Tryb | `Soneta.CzlonkowieSzkolenia.TrybZajec` | bazodanowe |  |  |
| TypeCaption | `string` |  |  |  |
| Uczestnicy | `Soneta.Business.View` |  |  |  |
| UczestnicyGrupowo | `int` | bazodanowe | Uczestnicy grupowo | Uczestnicy zgłoszeni grupowo. |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi | Dodatkowe uwagi. |
| View | `Soneta.Business.View` |  |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Zajecia | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase>` |  |  |  |
| ZajeciaWszystkieWliczane | `System.Collections.Generic.IEnumerable<Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase>` |  |  |  |
| Zespoly | `Soneta.Business.LpSubTable<Soneta.CzlonkowieSzkolenia.ZespolSzkol>` |  |  |  |
| ZgloszeniaGrupy | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa>` |  |  |  |
| ZgloszeniaPozDok | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZgloszeniePozDok>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusGrupySzkol (`Soneta.CzlonkowieSzkolenia.StatusGrupySzkol`)
- `WPrzygotowaniu` = 0 — W przygotowaniu
- `WRealizacji` = 1 — W realizacji
- `Zakończona` = 2
- `Zablokowana` = 3
- `Odwolana` = 4 — Odwołana
- `Wszystkie` = 99
