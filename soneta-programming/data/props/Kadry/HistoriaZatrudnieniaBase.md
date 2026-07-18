# Pola i właściwości klasy biznesowej: `Soneta.Kadry.HistoriaZatrudnieniaBase`
Nazwa tabeli: `HistZatrudnien`
Tytuł: Historia zatrudnienia
Opis: Historia zatrudnienia pracownika u poprzednich pracodawców oraz okresy nauki. Rejestruje nazwy zakładów pracy, okresy zatrudnienia, efektywny staż, typ wpisu (praca/nauka) oraz dane niezbędne do wyliczenia stażu pracy i uprawnień urlopowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IManagedRowInfoHost`

- pola bazodanowe (zapisywalne): 19
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 10
- podlisty: 9
- subrowy: 2
- razem: 40

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres1 | `string` | bazodanowe |  |  |
| Adres2 | `string` | bazodanowe |  |  |
| AgencjaPracyTyczasowej | `bool` | bazodanowe |  |  |
| DataDostarczeniaZaswiadczenia | `Date` | bazodanowe | Data dostarczenia zaswiadczenia |  |
| EfektywnyOkres | `FromTo` | bazodanowe, podlista |  |  |
| GrupaStanowisk | `Soneta.HR.GrupaStanowisk` | bazodanowe |  |  |
| Informacja | `string` | tylko-odczyt |  |  |
| Informacja1 | `string` | bazodanowe |  |  |
| Informacja2 | `string` | bazodanowe |  |  |
| KodWykonywanegoZawodu | `int` | bazodanowe |  |  |
| Korekta | `Soneta.Kadry.StazPracy` | bazodanowe |  |  |
| KorygowanyOkres | `Periods` | tylko-odczyt |  |  |
| ManagedState | `Soneta.Core.ManagedRowStates` (enum) | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| ObszarFunkcjonalny | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.ObszarFunkcjonalny` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| OkresStaz | `Soneta.Kadry.StazPracy` | tylko-odczyt |  |  |
| OkresyNiewliczane | `FromToSubTable<Soneta.Kadry.OkresNiewliczany>` | podlista |  |  |
| OkresyPracyTymczasowej | `SubTable<Soneta.Kadry.OkresWykonywaniaPracyTymczasowej>` | podlista |  |  |
| Podstawy | `SubTable<Soneta.Kadry.PodstawaStazu>` | podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RodzajDokumentu | `Soneta.Kadry.RodzajDokumentu` (enum) | bazodanowe |  |  |
| Staz | `Soneta.Kadry.StazPracyPracownika` (subrow) | bazodanowe |  |  |
| Staz.Podstawy | `SubTable` | podlista |  |  |
| Staz.RodzajPodstawy | `Soneta.Kadry.RodzajPodstawyStażuPracy` (enum) | tylko-odczyt |  |  |
| Staz.Staz | `Soneta.Kadry.StazPracy` | bazodanowe |  |  |
| StazEfektywnegoOkresu | `Soneta.Kadry.StazPracy` | tylko-odczyt |  |  |
| Szkola | `Soneta.Kadry.TypSzkoły` (enum) | bazodanowe |  |  |
| SzkolaStaz | `Soneta.Kadry.StazPracy` | bazodanowe |  |  |
| TyUb | `Soneta.Kadry.TytulUbezpieczenia` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypHistoriiZatrudnienia` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wyksztalcenie | `Soneta.HR.ZKL.ZKLPracownik.Kwalifikacje.WyksztalceniePracownika` (subrow) | bazodanowe | Wykształcenie |  |
| Wyksztalcenie.Kierunek | `Soneta.HR.IZklPozycjaSlownika` | bazodanowe, iface-ref | Kierunek |  |
| Wyksztalcenie.Poziom | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomWyksztalcenia` | bazodanowe | Poziom |  |
| Wyksztalcenie.TytulStopien | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.TytulZawodowyStopienNaukowy` | bazodanowe | Tytuł/stopień |  |
| Wyksztalcenie.WgKierunek | `Key` | podlista |  |  |
| Wyksztalcenie.WgPoziom | `Key` | podlista |  |  |
| Wyksztalcenie.WgTytulStopien | `Key` | podlista |  |  |
| ZawszeIlościowo | `bool` | tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Wyksztalcenie.Kierunek | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ManagedRowStates (`Soneta.Core.ManagedRowStates`)
- `Pending` = 1 — Wprowadzany
- `Active` = 2 — Przetwarzany
- `Finished` = 3 — Zakończony
- `Abandoned` = 4 — Porzucony
- `Removed` = 5 — Usunięty

### RodzajDokumentu (`Soneta.Kadry.RodzajDokumentu`)
- `ŚwiadectwoPracy` = 0 — Świadectwo pracy
- `Zaświadczenie` = 1

### RodzajPodstawyStażuPracy (`Soneta.Kadry.RodzajPodstawyStażuPracy`)
- `OkresNauki` = 1
- `StazDoUrlopu` = 2
- `StazPracy` = 4
- `StazPracyWFirmie` = 8

### TypHistoriiZatrudnienia (`Soneta.Kadry.TypHistoriiZatrudnienia`)
- `Zatrudnienie` = 1
- `Wyksztalcenie` = 2

### TypSzkoły (`Soneta.Kadry.TypSzkoły`)
- `Inna` = 0
- `ZasadniczaSzkołaZawodowa` = 3 — Zasadnicza szkoła zawodowa (3 lata)
- `ŚredniaSzkołaOgólnokształcąca` = 4 — Średnia szkoła ogólnokształcąca (4 lata)
- `ŚredniaSzkołaZawodowa` = 5 — Średnia szkoła zawodowa (5 lat)
- `SzkołaPolicealna` = 6 — Szkoła policealna (6 lat)
- `SzkołaWyższa` = 8 — Szkoła wyższa (8 lat)
