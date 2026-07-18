# Pola i właściwości klasy biznesowej: `Soneta.Kasa.EwidencjaSP`
Nazwa tabeli: `EwidencjeSP`
Tytuł: Ewidencje ŚP
Opis: Ewidencja środków pieniężnych — kasa gotówkowa lub rachunek bankowy firmy. Definiuje walutę, typ ewidencji, parametry raportów kasowych, formaty eksportu/importu bankowego, konfigurację magazynu walut, bankowość elektroniczną online oraz obsługę rachunków VAT w mechanizmie podzielonej płatności.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IRightsSource`

- pola bazodanowe (zapisywalne): 40
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 14
- podlisty: 12
- subrowy: 3
- razem: 72

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Auto | `bool` | bazodanowe |  |  |
| AutoRozliczanieWgNumerow | `bool` | bazodanowe |  | Automatyczne rozliczanie zapłat wg numerów po imporcie wyciągów. |
| AutoRozliczanieWgPrzelewow | `bool` | bazodanowe |  | Automatyczne rozliczanie wypłat wg przelewów po imporcie wyciągów. |
| AutomatyczneRozliczanie | `bool` | bazodanowe |  |  |
| BankOnline | `Soneta.Kasa.BankowoscElektroniczna.SerwisBankowy` | bazodanowe |  | Webserwis obsługujący tą ewidencję |
| BankOnlineConfig | `MemoText` | bazodanowe, podlista |  | Konfiguracja bankowości online |
| Blokada | `bool` | bazodanowe |  |  |
| Code | `MemoText` | bazodanowe, podlista |  | Algorytm (C#) wyliczenia numeru rachunku |
| CodeBinder | `Compiler.ICodeEditorSource` |  |  | Kod algorytmu rachunków wirtualnych |
| CtxOddziałFirmy | `Soneta.Core.OddzialFirmy` |  |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu dla raportów SP |
| DefinicjaED | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu w ewidencji dokumentów |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| Domyslny | `bool` | bazodanowe |  |  |
| EksportPrzelewow | `Soneta.Kasa.FormatWymianyElektronicznej` | bazodanowe |  |  |
| EksportPrzelewowWal | `Soneta.Kasa.FormatWymianyElektronicznej` | bazodanowe |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Elixir | `Soneta.Kasa.ElixirInfo` (subrow) | bazodanowe |  |  |
| Elixir.Kierunek | `string` | bazodanowe |  |  |
| Elixir.Numer | `string` | bazodanowe |  |  |
| FiltrImportu | `string` | bazodanowe |  |  |
| FiltrImportuExt | `MemoText` | bazodanowe, podlista |  | Pole dla konfiguracji robionej przez Soneta.Banki v2 |
| FiltrImportuWB | `Soneta.Kasa.ImportWyciagowBankowychFilterBase` | tylko-odczyt |  |  |
| FiltrImportuWBInfo | `Soneta.Kasa.ImportWyciagowBankowychFilterInfo` |  |  |  |
| Firma | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| IdentyfikacjaWgPolaPodmiot | `Soneta.Kasa.IdentyfikacjaWgPolaPodmiot` (enum) | bazodanowe |  | Sposób wykorzystania tabeli identyfikacji podmiotów |
| KSeFOpis | `string` | bazodanowe |  | Opis rachunku KSeF |
| Karta | `Soneta.Kasa.KartaPlatnicza` (subrow) | bazodanowe |  |  |
| Karta.Nazwa | `string` | bazodanowe |  |  |
| Karta.Numer | `string` | bazodanowe |  |  |
| Karta.WaznaDo | `YearMonth` | bazodanowe |  |  |
| KasowanieOperacji | `bool` | bazodanowe |  | Czy z wyciągu można kasować operacje bankowe. |
| MagazynWalut | `bool` | bazodanowe |  |  |
| MethodName | `string` | tylko-odczyt |  | Nazwa metody lub właściwości w generowanym kodzie algorytmu. |
| Nadrzędne | `SubTable<Soneta.Kasa.SubEwidencjaSP>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NiestandardowyFiltrImportu | `MemoText` | bazodanowe, podlista |  | Filtr importu utworzony za pomocą kreatora |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| OkresRaportow | `Soneta.Kasa.OkresRaportuESP` (enum) | bazodanowe |  |  |
| Operator | `App.Operator` | bazodanowe, tylko-odczyt |  |  |
| Podrzędne | `SubTable<Soneta.Kasa.SubEwidencjaSP>` | podlista |  |  |
| PowiazaneRachunkiRozliczeniowe | `SubTable<Soneta.Kasa.EwidencjaSP>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| PowiazanyRachunekVAT | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Powiązany rachunek VAT |  |
| ProcesorWyciaguKod | `MemoText` | bazodanowe, podlista |  | Kod obróbki wyciągów |
| ProcesorWyciaguWlaczony | `bool` | bazodanowe |  | Włącznik kodu obróbki wyciagów |
| Rachunek | `Soneta.Kasa.RachunekBankowy` | tylko-odczyt |  |  |
| RachunekVAT | `bool` | bazodanowe | Rachunek VAT |  |
| RachunkiWirtualne | `Soneta.Kasa.TypRachunkówWirtualnych` (enum) | bazodanowe |  |  |
| RodzajRaportow | `Soneta.Kasa.RodzajRaportuESP` (enum) | bazodanowe |  |  |
| RozliczenieWyplatMW | `Soneta.Kasa.MagazynWalut` (enum) | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SaldoBO | `Currency` | bazodanowe |  |  |
| ScisleRozliczanieMPP | `bool` | bazodanowe | Ścisłe rozliczanie MPP | Ścisłe rozliczanie dokumentów MPP po imporcie wyciągów |
| Segment | `string` | tylko-odczyt |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe |  |  |
| SymbolWaluty | `string` | tylko-odczyt |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypEwidencjiSP` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypDanych | `Soneta.Kasa.TypDanychESP` (enum) | bazodanowe |  |  |
| UjemneStanyWKasie | `bool` | bazodanowe |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| Wielooddzialowosc | `bool` | tylko-odczyt |  |  |
| Zero | `Currency` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### IdentyfikacjaWgPolaPodmiot (`Soneta.Kasa.IdentyfikacjaWgPolaPodmiot`)
- `Zawsze` = 0
- `TylkoJesliNieMaNumeruRachunku` = 1 — Tylko jeśli nie ma numeru rachunku
- `Nigdy` = 2

### MagazynWalut (`Soneta.Kasa.MagazynWalut`)
- `NiePodlega` = 0 — Nie podlega
- `WgKursuDnia` = 1
- `WgZasobów` = 2
- `WgZasobowHistoryczne` = 3

### OkresRaportuESP (`Soneta.Kasa.OkresRaportuESP`)
- `Niezdefiniowany` = 0 — Niezdefiniowany
- `Dzienny` = 1
- `Tygodniowy` = 2
- `Dekadowy` = 3
- `Miesieczny` = 4
- `Niestandardowy` = 5

### RodzajRaportuESP (`Soneta.Kasa.RodzajRaportuESP`)
- `Okresowy` = 1 — Okresowy (standard)
- `DziennyMulti` = 2 — Dzienny (multi)

### TypDanychESP (`Soneta.Kasa.TypDanychESP`)
- `Dokumenty` = 1
- `Raporty` = 2
- `Ewidencje` = 3

### TypEwidencjiSP (`Soneta.Kasa.TypEwidencjiSP`)
- `Kasa` = 1
- `RachunekBankowy` = 2
- `KartaPłatnicza` = 3

### TypRachunkówWirtualnych (`Soneta.Kasa.TypRachunkówWirtualnych`)
- `Nieobsługuje` = 0 — Nie obsługuje
- `DlaKontrahenta` = 1
- `DlaDokumentu` = 2
- `DlaNależności` = 3
