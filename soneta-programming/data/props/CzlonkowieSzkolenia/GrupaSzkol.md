# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.GrupaSzkol`
Nazwa tabeli: `GrupySzkol`
Tytuł: Grupy szkoleniowe
Opis: Grupy szkoleniowe stanowiące konkretne edycje kursów z określonym terminem i harmonogramem. Przechowują dane organizacyjne szkolenia: daty, tryb zajęć, status realizacji oraz powiązanie z rodzajem szkolenia i towarem do fakturowania.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IZrodloHarmWplaty`, `IEmailElement`, `IOceniany`, `IŹródłoOceny`

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 18
- podlisty: 18
- subrowy: 0
- razem: 50

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Certyfikaty | `View` | podlista |  |  |
| CzasDo | `TimeSec` | bazodanowe | Godzina rozpoczęcia | Godzina zakończenia grupy |
| CzasOd | `TimeSec` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia grupy |
| DataDo | `Date` | bazodanowe | Data zakończenia | Planowana data zakończenia. |
| DataOd | `Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia. |
| DataZamkniecia | `Date` | bazodanowe | Data zamknięcia | Data zamknięcia grupy szkoleniowej. |
| DokumentyHan | `View` | podlista |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| HarmonogramyWplat | `SubTable` | podlista |  |  |
| IloscGodzinPlan | `double` | tylko-odczyt |  | Ilość godzin zajęć na rodzaju szkolenia z uwzględnieniem modułów. |
| IloscGodzinPlanOgolem | `double` | tylko-odczyt |  | Ilość godzin zajęć na rodzaju szkolenia. |
| IloscGodzinRealizacja | `double` | tylko-odczyt |  | Sumaryczna ilość godzin zajęć dla grupy (bez zajęć dla zespołów). |
| IloscGodzinRealizacjaNaUczestnika | `double` | tylko-odczyt |  | Sumaryczna ilość godzin zajęć dla uczestnika. |
| IloscGodzinRealizacjaRazem | `double` | tylko-odczyt |  | Sumaryczna ilość godzin zajęć dla grupy i wszystkich zespołów. |
| IloscGodzinRealizacjaZespolow | `double` | tylko-odczyt |  | Sumaryczna ilość godzin zajęć dla wszystkich zespołow (bez zajęć dla grupy). |
| IloscUczestnikow | `int` | tylko-odczyt |  |  |
| IloscUczestnikowAktywnych | `int` | tylko-odczyt |  |  |
| IloscZajec | `int` | tylko-odczyt |  |  |
| IsStandardCourse | `bool` | tylko-odczyt |  |  |
| JestHarmonogram | `bool` | tylko-odczyt |  |  |
| JestZespol | `bool` | tylko-odczyt |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| Materialy | `SubTable<Soneta.CzlonkowieSzkolenia.GrupaMaterial>` | podlista |  |  |
| Modul | `Soneta.CzlonkowieSzkolenia.ModulSzkol` | bazodanowe | Moduł | Moduł z którym powiązane jest szkolenie. |
| Modulowe | `bool` | tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Numer | `string` | bazodanowe | Numer szkolenia | Numer szkolenia. |
| Oceniani | `SubTable` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| PowiązaneOceny | `SubTable` | podlista |  |  |
| PrzedmiotyRoznica | `System.Collections.ArrayList` | podlista |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  | Rodzaj szkolenia. |
| SaMaterialy | `bool` | tylko-odczyt |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| StatusGrupySzkol | `Soneta.CzlonkowieSzkolenia.StatusGrupySzkol` (enum) | bazodanowe |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe | Towar | Towar z którym powiązane jest szkolenie. |
| TowarWpisowe | `Soneta.Towary.Towar` | bazodanowe | Towar | Towar z którym powiązane jest wpisowe na studia. |
| Tryb | `Soneta.CzlonkowieSzkolenia.TrybZajec` | bazodanowe |  |  |
| TypeCaption | `string` | tylko-odczyt |  |  |
| Uczestnicy | `View` | podlista |  |  |
| UczestnicyGrupowo | `int` | bazodanowe | Uczestnicy grupowo | Uczestnicy zgłoszeni grupowo. |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi | Dodatkowe uwagi. |
| View | `View` | podlista |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Zajecia | `SubTable<Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase>` | podlista |  |  |
| ZajeciaWszystkieWliczane | `System.Collections.Generic.IEnumerable<Soneta.CzlonkowieSzkolenia.ZajecieSzkolBase>` | podlista |  |  |
| Zespoly | `LpSubTable<Soneta.CzlonkowieSzkolenia.ZespolSzkol>` | podlista |  |  |
| ZgloszeniaGrupy | `SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa>` | podlista |  |  |
| ZgloszeniaPozDok | `SubTable<Soneta.CzlonkowieSzkolenia.ZgloszeniePozDok>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusGrupySzkol (`Soneta.CzlonkowieSzkolenia.StatusGrupySzkol`)
- `WPrzygotowaniu` = 0 — W przygotowaniu
- `WRealizacji` = 1 — W realizacji
- `Zakończona` = 2
- `Zablokowana` = 3
- `Odwolana` = 4 — Odwołana
- `Wszystkie` = 99
