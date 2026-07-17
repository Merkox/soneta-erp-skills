# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.ZKLPracownik.Kwalifikacje.KwalifikacjePracownikaZkl`
Nazwa tabeli: `ZKLKwalPrac`
Tytuł: Kwalifikacje pracownika
Opis: Tabela przechowuje informacje o kwalifikacjach przypisanych do konkretnych pracowników, takich jak dodatkowe kwalifikacje, umiejętność obsługi maszyn, znajomość sytemów IT i języków programowania. Dane te wykorzystywane są do oceny zgodności pracownika z wymaganiami stanowiska.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataUzyskania | `Soneta.Types.Date` | bazodanowe | Data uzyskania |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Poziom | `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomUmiejetnosci` | bazodanowe | Poziom |  |
| Pozycja | `Soneta.HR.IZklPozycjaSlownika` | iface-ref |  |  |
| PozycjaBase | `Soneta.HR.IZklPozycjaSlownika` | bazodanowe, iface-ref | Pozycja słownika |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| Typ | `Soneta.HR.ZKL.Enums.TypKwalifikacjiPracownika` | bazodanowe, enum | Typ kwalifikacji pracownika |  |
| TypPotwierdzenia | `Soneta.HR.ZKL.Profile.Kwalifikacyjny.TypPotwierdzenia` | bazodanowe | Typ potwierdzenia |  |
| Uwagi | `string` | bazodanowe | Uwagi |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Pozycja | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |
| PozycjaBase | `IZklPozycjaSlownika` | `Benefit`, `DefinicjaCzynnikowSzkodliwych`, `DefinicjaJęzykaObcego`, `DefinicjaStopiaZnajomościJęzykaObcego`, `DefinicjaSzkolenia`, `DefinicjaSzkoleniaBHP`, `DefinicjaUprawnienia`, `DodatkowaKwalifikacjaZawodowa`, `DokumentProcedura`, `DostepDoSystemow`, `GrupaKompetencjiMerytorycznych`, `GrupaKompetencjiUniwersalnych`, `GrupaStanowisk`, `GrupaSzkolenIUprawnien`, `GrupaZadan`, `KategoriaCzynnikowSzkodliwych`, `KategoriaGrupyStanowisk`, `KategoriePracownikow`, `KierunekKsztalceniaSzkolySrednie`, `KierunekKsztalceniaSzkolyWyzsze`, `KierunekKsztalceniaSzkolyZawodowe`, `KompetencjaMerytoryczna`, `KompetencjaUniwersalna`, `ObslugaMaszynIUrzadzen`, `ObszarFunkcjonalny`, `Odpowiedzialnosc`, `OkresDoswiadczeniaZawodowego`, `PoziomRozwojuKompetencjiMerytorycznych`, `PoziomRozwojuKompetencjiUniwersalnych`, `PoziomUmiejetnosci`, `PoziomWyksztalcenia`, `StopienOdpowiedzialnosci`, `SystemITJezykProgramowania`, `TypPotwierdzenia`, `TytulZawodowyStopienNaukowy`, `WyposazenieStanowiska`, `Wysilek`, `ZadanieZkl` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypKwalifikacjiPracownika (`Soneta.HR.ZKL.Enums.TypKwalifikacjiPracownika`)
- `None` = 0 — Brak
- `DodatkoweKwalifikacje` = 10 — Dodatkowe kwalifikacje
- `ObslugaMaszynUrzadzen` = 20 — Obsługa maszyn i urządzeń
- `SystemyITJezykiProgramowania` = 30 — Systemy IT, języki programowania
