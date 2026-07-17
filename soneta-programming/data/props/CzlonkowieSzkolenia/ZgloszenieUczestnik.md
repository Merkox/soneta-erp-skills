# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik`
Nazwa tabeli: `ZgloszeniaUczest`
Tytuł: Uczestnicy
Opis: Pozycje uczestników na zgłoszeniu szkoleniowym. Łączy konkretnego uczestnika ze zgłoszeniem i grupą szkoleniową, przechowując status zapisu, oceny, obecność oraz dane do rozliczeń finansowych.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IZrodloHarmWplaty`, `IEmailElement`

- pola bazodanowe: 23
- pola kalkulowane (z klas biznesowych): 36

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresEmail | `string` | bazodanowe |  | Adres poczty elektronicznej |
| CertyfikatyUczestnika | `Soneta.Business.SubTable` |  |  |  |
| DataPrzeniesienia | `Soneta.Types.Date` | bazodanowe |  | Data przeniesienia na inną grupę. |
| DataUzyskania | `Soneta.Types.Date` |  |  |  |
| DataZaliczenia | `Soneta.Types.Date` | bazodanowe |  | Data zaliczenia kursu. |
| DlaModulow | `bool` |  |  |  |
| DokumentyHan | `Soneta.Business.View` |  |  |  |
| Egzamin | `bool` | bazodanowe |  |  |
| Egzaminy | `Soneta.Business.View` |  |  |  |
| GrupaSzkol | `Soneta.CzlonkowieSzkolenia.GrupaSzkol` |  |  |  |
| HarmWplat | `bool` | bazodanowe |  | Określa czy jest indywidualny harmonogram wpłat. |
| HarmonogramyWplat | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.HarmonogramWplat>` |  |  |  |
| IndywidualnaCena | `Soneta.Types.Currency` |  |  |  |
| IndywidualnyKoszt | `bool` |  |  |  |
| IndywidualnyRabat | `Soneta.Types.Percent` |  |  |  |
| Info | `string` |  |  |  |
| JestHarmonogram | `bool` |  |  |  |
| JestJednoZgloszenieUczestnik | `bool` |  |  |  |
| JestRozliczenie | `bool` |  |  |  |
| JestStorno | `bool` |  |  |  |
| JestZapotrzebowanie | `bool` |  |  |  |
| KorespPlatnik | `bool` | bazodanowe |  | Korespondencja wysyłana na adres płatnika |
| ListaRez | `bool` | bazodanowe |  | Określa czy uczestnik znajduje sie na liście rezerwowej |
| Lp | `int` |  |  |  |
| MailTo | `string` |  |  |  |
| Modulowe | `bool` |  |  |  |
| NazwiskoImie | `string` |  |  |  |
| NumerZgl | `string` | bazodanowe | Numer zgłoszenie |  |
| OcenaKoncowa | `string` | bazodanowe |  |  |
| OdznaczeniaUczestnika | `Soneta.Business.SubTable` |  |  |  |
| OtrzymujeMaterialy | `bool` | bazodanowe |  |  |
| PassingGrades | `System.Collections.Generic.IEnumerable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik.PassingGrade>` |  |  |  |
| Platnicy | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZgloszeniePlatnik>` |  |  |  |
| Platnik | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| PozycjeDokHan | `Soneta.Business.View` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` |  |  |  |
| Przeniesienia | `Soneta.Business.View` |  |  |  |
| RodzajSzkol | `Soneta.CzlonkowieSzkolenia.RodzajSzkol` | bazodanowe |  |  |
| SaDokumenty | `bool` |  |  |  |
| SaTylkoZapotrzebowania | `bool` |  |  |  |
| StanZgloszeniaUczest | `Soneta.CzlonkowieSzkolenia.StanZgloszeniaUczest` | bazodanowe, enum | Stan zgłoszenia |  |
| StatusZgloszenia | `Soneta.CzlonkowieSzkolenia.StatusZgloszenia` | bazodanowe, enum |  |  |
| Tryb | `Soneta.CzlonkowieSzkolenia.TrybZajec` | bazodanowe |  |  |
| Uczestnik | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe |  |  |
| UkonczoneSzkolenie | `Soneta.HR.UkończoneSzkolenie` | bazodanowe |  |  |
| Uprawnienia | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.UprawnienieZgloszenia>` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Wyroznienia | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.Wyroznienie>` |  |  |  |
| Zaliczone | `bool` | bazodanowe |  |  |
| Zapotrzebowanie | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| ZespolSzkol | `Soneta.CzlonkowieSzkolenia.ZespolSzkol` | bazodanowe |  |  |
| ZgloszeniaPozDok | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZgloszeniePozDok>` |  |  |  |
| ZgloszeniaUczGrupy | `Soneta.Business.SubTable<Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa>` |  |  |  |
| Zgloszenie | `Soneta.CzlonkowieSzkolenia.Zgloszenie` | bazodanowe |  |  |
| ZgloszeniePierwotne | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |
| ZgloszenieUczGrupa | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczGrupa` |  |  |  |
| ZgloszenieUczestnikRow | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` |  |  |  |
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
