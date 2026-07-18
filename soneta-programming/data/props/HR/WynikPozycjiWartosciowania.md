# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Wyniki.WynikPozycjiWartosciowania`
Nazwa tabeli: `ZklWynikPozWart`
Tytuł: Wyniki pozycji wartościowania
Opis: Element szczegółowy wartościowania stanowiska (WartosciowanieStanowiska). Przechowuje wyliczoną wartość punktową dla konkretnej pozycji słownikowej w ramach kryterium analitycznego, z rozbiciem na punkty bazowe i mnożnik.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 15
- podlisty: 0
- subrowy: 1
- razem: 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AnalityczneIdent | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| AnalityczneNazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| KryteriumAnalityczne | `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumAnalityczne` | tylko-odczyt |  |  |
| Mnoznik | `decimal` | bazodanowe, tylko-odczyt | Mnożnik |  |
| Pozycja | `Soneta.HR.ZKL.Wartosciowanie.Macierze.PozycjaMacierzy` (subrow) | bazodanowe | Pozycja słownika |  |
| Pozycja.Ident | `System.Guid` | bazodanowe, tylko-odczyt | Identyfikator pozycji słownika |  |
| Pozycja.Nazwa | `string` | bazodanowe, tylko-odczyt | Nazwa pozycji |  |
| Pozycja.Opis | `string` | bazodanowe, tylko-odczyt | Opis pozycji |  |
| Pozycja.Opis2 | `string` | bazodanowe, tylko-odczyt | Opis2 pozycji |  |
| Pozycja.PozycjaSlownika | `Soneta.HR.IZklPozycjaSlownika` | iface-ref |  |  |
| Pozycja.Slownik | `string` | bazodanowe, tylko-odczyt | Nazwa słownika |  |
| Pozycja.Typ | `string` | bazodanowe, tylko-odczyt | Typ pozycji, tabela słownika |  |
| PozycjaSlownika | `Soneta.HR.IZklPozycjaSlownika` | tylko-odczyt, iface-ref |  |  |
| PunktyBazowe | `int` | bazodanowe, tylko-odczyt | Punkty bazowe |  |
| SyntetyczneNazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| WartoscWyliczona | `decimal` | bazodanowe, tylko-odczyt | Wartość wyliczona |  |
| WartosciowanieStanowiska | `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.WartosciowanieStanowiska` | bazodanowe, tylko-odczyt | Wartościowanie stanowiska |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Pozycja.PozycjaSlownika | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
| PozycjaSlownika | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
