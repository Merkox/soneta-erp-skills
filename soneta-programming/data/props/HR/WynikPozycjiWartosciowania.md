# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Wyniki.WynikPozycjiWartosciowania`
Nazwa tabeli: `ZklWynikPozWart`
Tytuł: Wyniki pozycji wartościowania
Opis: Element szczegółowy wartościowania stanowiska (WartosciowanieStanowiska). Przechowuje wyliczoną wartość punktową dla konkretnej pozycji słownikowej w ramach kryterium analitycznego, z rozbiciem na punkty bazowe i mnożnik.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AnalityczneIdent | `System.Guid` | bazodanowe |  |  |
| AnalityczneNazwa | `string` | bazodanowe |  |  |
| KryteriumAnalityczne | `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.KryteriumAnalityczne` |  |  |  |
| Mnoznik | `decimal` | bazodanowe | Mnożnik |  |
| Pozycja | `Soneta.HR.ZKL.Wartosciowanie.Macierze.PozycjaMacierzy` | bazodanowe | Pozycja słownika |  |
| Pozycja.Ident | `System.Guid` | bazodanowe | Identyfikator pozycji słownika |  |
| Pozycja.Nazwa | `string` | bazodanowe | Nazwa pozycji |  |
| Pozycja.Opis | `string` | bazodanowe | Opis pozycji |  |
| Pozycja.Opis2 | `string` | bazodanowe | Opis2 pozycji |  |
| Pozycja.PozycjaSlownika | `Soneta.HR.IZklPozycjaSlownika` | iface-ref |  |  |
| Pozycja.Slownik | `string` | bazodanowe | Nazwa słownika |  |
| Pozycja.Typ | `string` | bazodanowe | Typ pozycji, tabela słownika |  |
| PozycjaSlownika | `Soneta.HR.IZklPozycjaSlownika` | iface-ref |  |  |
| PunktyBazowe | `int` | bazodanowe | Punkty bazowe |  |
| SyntetyczneNazwa | `string` | bazodanowe |  |  |
| WartoscWyliczona | `decimal` | bazodanowe | Wartość wyliczona |  |
| WartosciowanieStanowiska | `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.WartosciowanieStanowiska` | bazodanowe | Wartościowanie stanowiska |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Pozycja.PozycjaSlownika | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
| PozycjaSlownika | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
