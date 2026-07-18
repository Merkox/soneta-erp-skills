# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik`
Nazwa tabeli: `ZgloszeniaUczest`
Tytuł: Uczestnicy
Opis: Pozycje uczestników na zgłoszeniu szkoleniowym. Łączy konkretnego uczestnika ze zgłoszeniem i grupą szkoleniową, przechowując status zapisu, oceny, obecność oraz dane do rozliczeń finansowych.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IZrodloHarmWplaty`, `IEmailElement`

- pola bazodanowe (zapisywalne): 21
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 18
- podlisty: 15
- subrowy: 0
- razem: 58

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresEmail | `string` | bazodanowe |  | Adres poczty elektronicznej |
| CertyfikatyUczestnika | `SubTable` | podlista |  |  |
| DataPrzeniesienia | `Date` | bazodanowe |  | Data przeniesienia na inną grupę. |
| DataUzyskania | `Date` | tylko-odczyt |  |  |
| DataZaliczenia | `Date` | bazodanowe |  | Data zaliczenia kursu. |
| DlaModulow | `bool` | tylko-odczyt |  |  |
| DokumentyHan | `View` | podlista |  |  |
| Egzamin | `bool` | bazodanowe |  |  |
| Egzaminy | `View` | podlista |  |  |
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` |  |  |  |
| HarmWplat | `bool` | bazodanowe |  | Określa czy jest indywidualny harmonogram wpłat. |
| HarmonogramyWplat | `SubTable<Soneta.CzlonkowieSzkolenia.HarmonogramWplat>` | podlista |  |  |
| IndywidualnaCena | `Currency` |  |  |  |
| IndywidualnyKoszt | `bool` |  |  |  |
| IndywidualnyRabat | `Percent` |  |  |  |
| Info | `string` | tylko-odczyt |  |  |
| JestHarmonogram | `bool` | tylko-odczyt |  |  |
| JestJednoZgloszenieUczestnik | `bool` | tylko-odczyt |  |  |
| JestRozliczenie | `bool` | tylko-odczyt |  |  |
| JestStorno | `bool` | tylko-odczyt |  |  |
| JestZapotrzebowanie | `bool` | tylko-odczyt |  |  |
| KorespPlatnik | `bool` | bazodanowe |  | Korespondencja wysyłana na adres płatnika |
| ListaRez | `bool` | bazodanowe |  | Określa czy uczestnik znajduje sie na liście rezerwowej |
| Lp | `int` | tylko-odczyt |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| Modulowe | `bool` | tylko-odczyt |  |  |
| NazwiskoImie | `string` | tylko-odczyt |  |  |
| NumerZgl | `string` | bazodanowe | Numer zgłoszenie |  |
| OcenaKoncowa | `string` | bazodanowe |  |  |
| OdznaczeniaUczestnika | `SubTable` | podlista |  |  |
| OtrzymujeMaterialy | `bool` | bazodanowe |  |  |
| PassingGrades | `System.Collections.Generic.IEnumerable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik.PassingGrade>` | podlista |  |  |
| Platnicy | `SubTable<Soneta.CzlonkowieSzkolenia.ZgloszeniePlatnik>` | podlista |  |  |
| Platnik | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| PozycjeDokHan | `View` | podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| Przeniesienia | `View` | podlista |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  |  |
| SaDokumenty | `bool` | tylko-odczyt |  |  |
| SaTylkoZapotrzebowania | `bool` | tylko-odczyt |  |  |
| StanZgloszeniaUczest | `Soneta.CzlonkowieSzkolenia.StanZgloszeniaUczest` (enum) | bazodanowe | Stan zgłoszenia |  |
| StatusZgloszenia | `Soneta.CzlonkowieSzkolenia.StatusZgloszenia` (enum) | bazodanowe |  |  |
| Tryb | `Soneta.CzlonkowieSzkolenia.TrybZajec` | bazodanowe |  |  |
| UkonczoneSzkolenie | `Soneta.HR.UkończoneSzkolenie` | bazodanowe |  |  |
| Uprawnienia | `SubTable<Soneta.CzlonkowieSzkolenia.UprawnienieZgloszenia>` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Wyroznienia | `SubTable<Soneta.CzlonkowieSzkolenia.Wyroznienie>` | podlista |  |  |
| Zaliczone | `bool` | bazodanowe |  |  |
| Zapotrzebowanie | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  |  |
| ZespolSzkol | `Soneta.CzlonkowieSzkolenia.ZespolSzkol` | bazodanowe |  |  |
| ZgloszeniaPozDok | `SubTable<Soneta.CzlonkowieSzkolenia.ZgloszeniePozDok>` | podlista |  |  |
| ZgloszeniaUczGrupy | `SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa>` | podlista |  |  |
| Zgloszenie | `Soneta.CzlonkowieSzkolenia.Zgloszenie` | bazodanowe |  |  |
| ZgloszeniePierwotne | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |
| ZgloszenieUczGrupa | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa` | tylko-odczyt |  |  |
| ZgloszenieUczestnikRow | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | tylko-odczyt |  |  |
| Zgloszony | `Soneta.Core.ITrainee` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanZgloszeniaUczest (`Soneta.CzlonkowieSzkolenia.StanZgloszeniaUczest`)
- `Bufor` = 0 — Bufor
- `Zatwierdzony` = 1

### StatusZgloszenia (`Soneta.CzlonkowieSzkolenia.StatusZgloszenia`)
- `Aktywne` = 0 — Aktywne
- `Skreślone` = 1
- `Przeniesiony` = 2
- `Niedopuszczony` = 3
- `Wprowadzony` = 4
- `WstepnaAkceptacja` = 5 — Wstępna akceptacja
