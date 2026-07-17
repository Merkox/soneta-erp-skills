# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaStanowiska`
Nazwa tabeli: `DefStanowisk`
Tytuł: Definicje stanowisk
Opis: Słownik stanowisk pracy w organizacji. Określa nazwę, funkcję, specjalność oraz powiązania z kalendarzem pracy, grupą zaszeregowania i kodem wykonywanego zawodu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IŹródłoKartyOpisuStanowiska`

- pola bazodanowe: 28
- pola kalkulowane (z klas biznesowych): 28

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BadaniaLekarskie | `Soneta.Business.SubTable<Soneta.HR.BadaniaLekarskieDefinicjiStanowiska>` |  |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaFunkcji | `Soneta.HR.DefinicjaFunkcji` | bazodanowe |  |  |
| DefinicjeCzynnikowSzkodliwych | `Soneta.Business.SubTable<Soneta.HR.CzynnikSzkodliwyDefinicjiStanowiska>` |  |  |  |
| DefinicjeCzynnikowSzkodliwychGotowe | `bool` | bazodanowe |  |  |
| DefinicjeDokumentow | `Soneta.Business.SubTable<Soneta.HR.DokumentDefinicjiStanowiska>` |  |  |  |
| Funkcja | `string` | bazodanowe |  |  |
| FunkcjaPelna | `string` | bazodanowe |  |  |
| Grupa | `Soneta.Kadry.GrupaZaszeregowania` | bazodanowe |  |  |
| GrupyZaszeregowania | `Soneta.Business.SubTable<Soneta.HR.GrupaZaszeregowaniaDefinicjiStanowiska>` |  |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.HR.DefinicjaStanowiskaHist>` |  |  |  |
| InterpretacjaKalendarza | `Soneta.Kadry.InterpretacjaKalendarza` | bazodanowe, enum |  |  |
| Kalendarz | `Soneta.Kalend.Kalendarz` | bazodanowe |  |  |
| Kandydatury | `Soneta.Business.SubTable<Soneta.HR.Rekrutacja>` |  |  |  |
| KartyOpisuStanowiska | `Soneta.Business.SubTable<Soneta.HR2.KartaOpisuStanowiskaBase>` |  |  |  |
| KodPracyWSzczWarunkach | `Soneta.Kadry.KodPracyWSzególnychWarunkachCharakterze` | bazodanowe |  |  |
| KodWykonywanegoZawodu | `Soneta.Kadry.KodWykonywanegoZawodu` | bazodanowe |  |  |
| KodWymiany | `string` | bazodanowe |  |  |
| Last | `Soneta.HR.DefinicjaStanowiskaHist` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NieNadpisujKalendarza | `bool` | bazodanowe |  |  |
| ObszaryOdpowiedzialnosci | `Soneta.Business.SubTable<Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciStanowiska>` |  |  |  |
| ObszaryOdpowiedzialnosciGotowe | `bool` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
| OpisStanowiskaZeSkierowaniaNaBad | `string` | bazodanowe |  |  |
| Powiazania | `Soneta.Business.SubTable<Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefinicjiStanowisk>` |  |  |  |
| PowiazaniaZkl | `Soneta.Business.SubTable<Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefStanSlownikiZkl>` |  |  |  |
| ProfileKompetencjiMerytorycznych | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiMerytorycznych>` |  |  |  |
| ProfileKompetencjiUniwersalnych | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kompetencje.ProfilKompetencjiUniwersalnych>` |  |  |  |
| ProfileKwalifikacyjne | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Kwalifikacyjny.ProfilKwalifikacyjny>` |  |  |  |
| ProfileSzkolenIUprawnien | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.SzkoleniaIUprawnienia.ProfilSzkolenIUprawnien>` |  |  |  |
| ProfileZadaniowe | `Soneta.Business.SubTable<Soneta.HR.ZKL.Profile.Zadaniowy.ProfilZadaniowy>` |  |  |  |
| Specjalosc | `string` | bazodanowe |  |  |
| Stanowisko | `string` | bazodanowe |  |  |
| StanowiskoPelne | `string` | bazodanowe |  |  |
| SzkoleniaBHP | `Soneta.Business.SubTable<Soneta.HR.SzkolenieBHPDefinicjiStanowiska>` |  |  |  |
| TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` | bazodanowe, enum |  |  |
| Uprawnienia | `Soneta.Business.SubTable<Soneta.HR.UprawnienieDefinicjiStanowiska>` |  |  |  |
| Wakaty | `Soneta.Business.SubTable<Soneta.HR2.RekrutacjaWakat>` |  |  |  |
| WspolpracaWewnetrznaJednostki | `Soneta.Business.SubTable<Soneta.HR.ZKL.Stanowiska.Relacje.WspolpracaWewnetrznaJednostkiDefStan>` |  |  |  |
| Wydziały | `Soneta.Business.SubTable<Soneta.HR.WydziałDefinicjiStanowiska>` |  |  |  |
| WysilekGotowe | `bool` | bazodanowe |  |  |
| WysilekSubTable | `Soneta.Business.SubTable<Soneta.HR.ZKL.Stanowiska.Relacje.PowiazanieDefStanSlownikiZkl>` |  |  |  |
| Zaszeregowanie | `Soneta.Kadry.Zaszeregowanie` | bazodanowe |  |  |
| Zaszeregowanie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Zaszeregowanie.Godzinowe | `bool` |  |  |  |
| Zaszeregowanie.Miesięczne | `bool` |  |  |  |
| Zaszeregowanie.RodzajStawki | `Soneta.Kadry.RodzajStawkiZaszeregowania` | bazodanowe, enum |  |  |
| Zaszeregowanie.Stawka | `Soneta.Types.Currency` | bazodanowe |  |  |
| Zaszeregowanie.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` | enum |  |  |
| Zaszeregowanie.WgElement | `Soneta.Business.Key` |  |  |  |
| Zaszeregowanie.WskaznikKrotnosc | `double` | bazodanowe |  |  |
| Zaszeregowanie.WskaznikNazwa | `string` | bazodanowe |  |  |
| Zaszeregowanie.Wymiar | `Soneta.Types.Fraction` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### InterpretacjaKalendarza (`Soneta.Kadry.InterpretacjaKalendarza`)
- `WgPlanu` = 0
- `WgObecnosci` = 1 — Wg obecności
- `WgZestawien` = 2 — Wg zestawień

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
