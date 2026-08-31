# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Macierze.MnoznikMacierzyWartosciowania`
Nazwa tabeli: `ZklWrtMxMnozniki`
Tytuł: Mnożniki macierzy kryteriów wartościowania
Opis: Tabela zawiera mnożniki korygujące wartości macierzy. Pozwala dostosować wyniki do specyfiki organizacji.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Macierz | `Soneta.HR.ZKL.Wartosciowanie.Macierze.MacierzWartosciowania` | bazodanowe, tylko-odczyt | Macierz wartościowania |  |
| Mnoznik | `decimal` | bazodanowe | Mnożnik |  |
| Pozycja | `Soneta.HR.ZKL.Wartosciowanie.Macierze.PozycjaMacierzy` (subrow) | bazodanowe | Pozycja |  |
| Pozycja.Ident | `System.Guid` | bazodanowe, tylko-odczyt | Identyfikator pozycji słownika |  |
| Pozycja.Nazwa | `string` | bazodanowe, tylko-odczyt | Nazwa pozycji |  |
| Pozycja.Opis | `string` | bazodanowe, tylko-odczyt | Opis pozycji |  |
| Pozycja.Opis2 | `string` | bazodanowe, tylko-odczyt | Opis2 pozycji |  |
| Pozycja.PozycjaSlownika | `Soneta.HR.IZklPozycjaSlownika` | iface-ref |  |  |
| Pozycja.Slownik | `string` | bazodanowe, tylko-odczyt | Nazwa słownika |  |
| Pozycja.Typ | `string` | bazodanowe, tylko-odczyt | Typ pozycji, tabela słownika |  |
| PozycjaSlownika | `Soneta.HR.IZklPozycjaSlownika` | iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Pozycja.PozycjaSlownika | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
| PozycjaSlownika | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
