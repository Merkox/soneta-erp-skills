# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefStanSlownikiZkl`
Nazwa tabeli: `PowDefStZklSlw`
Tytuł: Powiązania stanowisk z pozycjami słowników ZKL
Opis: Tabela służy do powiązania definicji poszczególnych stanowisk z odpowiednimi pozycjami w słownikach ZKL. Umożliwia jednoznaczne przypisanie stanowisk do obowiązujących klasyfikacji.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaStanowiska | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt | Definicja stanowiska |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pozycja | `Soneta.HR.IZklPozycjaSlownika` | bazodanowe, iface-ref | Pozycja słownika |  |
| TypPowiazania | `Soneta.HR.ZKL.Enums.TypPowiazaniaSlownikaZkl` (enum) | bazodanowe, tylko-odczyt | Typ powiązania |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Pozycja | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypPowiazaniaSlownikaZkl (`Soneta.HR.ZKL.Enums.TypPowiazaniaSlownikaZkl`)
- `None` = 0 — Brak
- `WyposazenieStanowiska` = 10 — Wyposażenie stanowiska
- `DokumentProcedura` = 20 — Dokument/procedura
- `Wysilek` = 30 — Wysiłek
- `DostepDoSystemow` = 40 — Dostęp do systemów
- `Benefit` = 50 — Benefit
