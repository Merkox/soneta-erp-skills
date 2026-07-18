# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaStanowiska`
Nazwa tabeli: `DefStanowisk`
Tytuł: Definicje stanowisk
Opis: Słownik stanowisk pracy w organizacji. Określa nazwę, funkcję, specjalność oraz powiązania z kalendarzem pracy, grupą zaszeregowania i kodem wykonywanego zawodu.
Tabela konfiguracyjna: Tak
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `DefinicjaStanowiskaHist`
Implementuje interfejsy: `IŹródłoKartyOpisuStanowiska`

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 22
- subrowy: 0
- razem: 38

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BadaniaLekarskie | `SubTable<Soneta.HR.BadaniaLekarskieDefinicjiStanowiska>` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjeCzynnikowSzkodliwych | `SubTable<Soneta.HR.CzynnikSzkodliwyDefinicjiStanowiska>` | podlista |  |  |
| DefinicjeCzynnikowSzkodliwychGotowe | `bool` | bazodanowe |  |  |
| DefinicjeDokumentow | `SubTable<Soneta.HR.DokumentDefinicjiStanowiska>` | podlista |  |  |
| GrupyZaszeregowania | `SubTable<Soneta.HR.GrupaZaszeregowaniaDefinicjiStanowiska>` | podlista |  |  |
| Historia | `HistorySubTable<Soneta.HR.DefinicjaStanowiskaHist>` | podlista |  |  |
| Kalendarz | `Soneta.Kalend.Kalendarz` | bazodanowe, tylko-odczyt |  |  |
| Kandydatury | `SubTable<Soneta.HR.Rekrutacja>` | podlista |  |  |
| KartyOpisuStanowiska | `SubTable<Soneta.HR2.KartaOpisuStanowiskaBase>` | podlista |  |  |
| Last | `Soneta.HR.DefinicjaStanowiskaHist` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| ObszaryOdpowiedzialnosci | `SubTable<Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciStanowiska>` | podlista |  |  |
| ObszaryOdpowiedzialnosciGotowe | `bool` | bazodanowe |  |  |
| Powiazania | `SubTable<Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefinicjiStanowisk>` | podlista |  |  |
| PowiazaniaZkl | `SubTable<Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefStanSlownikiZkl>` | podlista |  |  |
| ProfileKompetencjiMerytorycznych | `SubTable<Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiMerytorycznych>` | podlista |  |  |
| ProfileKompetencjiUniwersalnych | `SubTable<Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiUniwersalnych>` | podlista |  |  |
| ProfileKwalifikacyjne | `SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny>` | podlista |  |  |
| ProfileSzkolenIUprawnien | `SubTable<Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.ProfilSzkolenIUprawnien>` | podlista |  |  |
| ProfileZadaniowe | `SubTable<Soneta.HR.ZKL.Profile.Zadaniowy.ProfilZadaniowy>` | podlista |  |  |
| SzkoleniaBHP | `SubTable<Soneta.HR.SzkolenieBHPDefinicjiStanowiska>` | podlista |  |  |
| Uprawnienia | `SubTable<Soneta.HR.UprawnienieDefinicjiStanowiska>` | podlista |  |  |
| Wakaty | `SubTable<Soneta.HR2.RekrutacjaWakat>` | podlista |  |  |
| WspolpracaWewnetrznaJednostki | `SubTable<Soneta.HR.ZKL.Stanowiska.Relacje.WspolpracaWewnetrznaJednostkiDefStan>` | podlista |  |  |
| Wydziały | `SubTable<Soneta.HR.WydziałDefinicjiStanowiska>` | podlista |  |  |
| WysilekGotowe | `bool` | bazodanowe |  |  |
| WysilekSubTable | `SubTable<Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefStanSlownikiZkl>` | podlista |  |  |
| Zaszeregowanie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Zaszeregowanie.Godzinowe | `bool` | tylko-odczyt |  |  |
| Zaszeregowanie.Miesięczne | `bool` | tylko-odczyt |  |  |
| Zaszeregowanie.RodzajStawki | `Soneta.Kadry.RodzajStawkiZaszeregowania` (enum) | bazodanowe |  |  |
| Zaszeregowanie.Stawka | `Currency` | bazodanowe |  |  |
| Zaszeregowanie.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` (enum) |  |  |  |
| Zaszeregowanie.WgElement | `Key` | podlista |  |  |
| Zaszeregowanie.WskaznikKrotnosc | `double` | bazodanowe |  |  |
| Zaszeregowanie.WskaznikNazwa | `string` | bazodanowe |  |  |
| Zaszeregowanie.Wymiar | `Fraction` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajStawkiZaszeregowania (`Soneta.Kadry.RodzajStawkiZaszeregowania`)
- `Godzinowa` = 0 — Za godzinę
- `Miesieczna` = 1 — Miesięcznie
- `DochodDeklarowany` = 2 — Dochód deklarowany

### TypStawkiZaszeregowania (`Soneta.Kadry.TypStawkiZaszeregowania`)
- `Dowolna` = 0 — Dowolna
- `Minimalna` = 1
- `ZZakresu` = 2
- `WgWskaźnika` = 3
- `Nieokreślona` = 10
