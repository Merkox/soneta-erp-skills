# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfilu`
Nazwa tabeli: `ZklPozKwalWykszt`
Tytuł: Pozycje wykształcenia profilu
Opis: Tabela opisuje poziom i kierunek wykształcenia. Umożliwia ewidencję wymagań edukacyjnych dla stanowiska.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kierunek | `Soneta.HR.IZklPozycjaSlownika` | bazodanowe, iface-ref | Kierunek |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe, tylko-odczyt |  |  |
| Specjalnosc | `string` | bazodanowe | Specjalność |  |
| Typ | `Soneta.HR.ZKL.Enums.WyksztalcenieProfiluSelektor` (enum) | bazodanowe, tylko-odczyt | Typ |  |
| TytulStopien | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.TytulZawodowyStopienNaukowy` | bazodanowe | Tytuł/stopień |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kierunek | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WyksztalcenieProfiluSelektor (`Soneta.HR.ZKL.Enums.WyksztalcenieProfiluSelektor`)
- `None` = 0 — Brak
- `ZasadniczeZawodoweNiezbedne` = 10 — Zasadnicze zawodowe – wymagane
- `ZasadniczeZawodowePozadane` = 20 — Zasadnicze zawodowe – pożądane
- `SrednieNiezbedne` = 30 — Średnie – wymagane
- `SredniePozadane` = 40 — Średnie – pożądane
- `WyzszeNiezbedne` = 50 — Wyższe – wymagane
- `WyzszePozadane` = 60 — Wyższe – pożądane
