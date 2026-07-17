# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Macierze.MnoznikMacierzyWartosciowania`
Nazwa tabeli: `ZklWrtMxMnozniki`
Tytuł: Mnożniki macierzy kryteriów wartościowania
Opis: Tabela zawiera mnożniki korygujące wartości macierzy. Pozwala dostosować wyniki do specyfiki organizacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Macierz | `Soneta.HR.ZKL.Wartosciowanie.Macierze.MacierzWartosciowania` | bazodanowe | Macierz wartościowania |  |
| Mnoznik | `decimal` | bazodanowe | Mnożnik |  |
| Pozycja | `Soneta.HR.ZKL.Wartosciowanie.Macierze.PozycjaMacierzy` | bazodanowe | Pozycja |  |
| Pozycja.Ident | `System.Guid` | bazodanowe | Identyfikator pozycji słownika |  |
| Pozycja.Nazwa | `string` | bazodanowe | Nazwa pozycji |  |
| Pozycja.Opis | `string` | bazodanowe | Opis pozycji |  |
| Pozycja.Opis2 | `string` | bazodanowe | Opis2 pozycji |  |
| Pozycja.PozycjaSlownika | `Soneta.HR.IZklPozycjaSlownika` | iface-ref |  |  |
| Pozycja.Slownik | `string` | bazodanowe | Nazwa słownika |  |
| Pozycja.Typ | `string` | bazodanowe | Typ pozycji, tabela słownika |  |
| PozycjaSlownika | `Soneta.HR.IZklPozycjaSlownika` | iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Pozycja.PozycjaSlownika | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
| PozycjaSlownika | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
