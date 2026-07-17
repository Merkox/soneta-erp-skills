# Pola i właściwości klasy biznesowej: `Soneta.Place.DefinicjaListyPlac`
Nazwa tabeli: `DefListPlac`
Tytuł: Definicje list płac
Opis: Szablon listy płac określający zasady naliczania wynagrodzeń. Definiuje symbol, numerację, algorytm, walutę płatności i powiązanie z ewidencją dokumentów, stanowiąc podstawę do tworzenia list płac.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IDefinicjaDokumentuOA`

- pola bazodanowe: 24
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywna | `Soneta.Place.DefinicjaListyPlac` |  |  |  |
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaED | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu w ewidencji dokumentów |
| Definicje | `Soneta.Business.SubTable<Soneta.Place.DefinicjaListyPlac>` |  |  |  |
| DefinicjeElementow | `Soneta.Business.SubTable<Soneta.Place.DefinicjaElementu>` |  |  |  |
| KonfiguracjaOpisuAnalitycznego | `Soneta.Core.KonfiguracjaOpisuAnalitycznego` |  |  |  |
| KosztyUzyskaniaPrzychodu | `Soneta.Place.NaliczanieKosztówUzyskaniaPrzychodu` | bazodanowe, enum | Definicja |  |
| Nadrzedna | `Soneta.Place.DefinicjaListyPlac` | bazodanowe |  |  |
| NaliczajKosztyZeStosunkuPracy | `bool` |  |  |  |
| NaliczajUlgePodatkowa | `bool` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| PozwalajNaZmianeOpisu | `bool` | bazodanowe |  |  |
| ProceduraISO | `Soneta.Core.IsoProcedura` | bazodanowe | Definicja |  |
| Rozliczanie | `Soneta.Place.RozliczanieListPłac` | bazodanowe, enum | Definicja |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SchematPodzialowy | `Soneta.Core.ISchematPodziałowy` | bazodanowe, iface-ref |  |  |
| Seria | `bool` | bazodanowe | Definicja |  |
| Symbol | `string` | bazodanowe |  |  |
| UlgaPodatkowa | `bool` | bazodanowe | Definicja |  |
| WalutaPlatnosci | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| Wydzial | `bool` | bazodanowe | Jednostka organizacyjna |  |
| ZawszePrzeliczajOpisAnalityczny | `bool` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| SchematPodzialowy | `ISchematPodziałowy` | `SchematPodz` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### NaliczanieKosztówUzyskaniaPrzychodu (`Soneta.Place.NaliczanieKosztówUzyskaniaPrzychodu`)
- `NaliczajWszystkie` = 0 — Naliczaj wszystkie
- `NieNaliczajZeStosunkuPracy` = 1
- `NieNaliczajZeStosunkuPracy50` = 2
- `NieNaliczajProcentowe` = 4
- `NieNaliczajWWysokościStosunkuPracy` = 8
- `NieNaliczajProcentowe50` = 16
- `NieNaliczajProcentoweWarunkowo` = 32
- `NieNaliczajWWysokościStosunkuPracyWarunkowo` = 64
- `NieNaliczajKosztyAutorskie50` = 128

### RozliczanieListPłac (`Soneta.Place.RozliczanieListPłac`)
- `Domyślnie` = 0
- `Zawsze` = 1
- `Nigdy` = 2
