# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfilu`
Nazwa tabeli: `ZklPozKwalWykszt`
Tytuł: Pozycje wykształcenia profilu
Opis: Tabela opisuje poziom i kierunek wykształcenia. Umożliwia ewidencję wymagań edukacyjnych dla stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Typ` (`Soneta.HR.ZKL.Enums.WyksztalcenieProfiluSelektor`) — wiele typów w jednej tabeli, podtypów: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kierunek | `Soneta.HR.IZklPozycjaSlownika` | bazodanowe, iface-ref | Kierunek |  |
| Profil | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny` | bazodanowe, tylko-odczyt |  |  |
| Specjalnosc | `string` | bazodanowe | Specjalność |  |
| Typ | `Soneta.HR.ZKL.Enums.WyksztalcenieProfiluSelektor` (enum) | bazodanowe, tylko-odczyt, selektor | Typ |  |
| TytulStopien | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.TytulZawodowyStopienNaukowy` | bazodanowe | Tytuł/stopień |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `ZasadniczeZawodoweNiezbedne` | 10 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfiluZasadniczeZawodoweNiezbedne` | Zasadnicze zawodowe |
| `ZasadniczeZawodowePozadane` | 20 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfiluZasadniczeZawodowePozadane` | Zasadnicze zawodowe |
| `SrednieNiezbedne` | 30 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfiluSrednieNiezbedne` | Średnie |
| `SredniePozadane` | 40 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfiluSredniePozadane` | Średnie |
| `WyzszeNiezbedne` | 50 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfiluWyzszeNiezbedne` | Wyższe |
| `WyzszePozadane` | 60 | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.PozycjaWyksztalceniaProfiluWyzszePozadane` | Wyższe |

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
