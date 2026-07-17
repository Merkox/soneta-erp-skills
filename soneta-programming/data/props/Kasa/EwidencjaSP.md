# Pola i właściwości klasy biznesowej: `Soneta.Kasa.EwidencjaSP`
Nazwa tabeli: `EwidencjeSP`
Tytuł: Ewidencje ŚP
Opis: Ewidencja środków pieniężnych — kasa gotówkowa lub rachunek bankowy firmy. Definiuje walutę, typ ewidencji, parametry raportów kasowych, formaty eksportu/importu bankowego, konfigurację magazynu walut, bankowość elektroniczną online oraz obsługę rachunków VAT w mechanizmie podzielonej płatności.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IRightsSource`

- pola bazodanowe: 50
- pola kalkulowane (z klas biznesowych): 23

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Auto | `bool` | bazodanowe |  |  |
| AutoRozliczanieWgNumerow | `bool` | bazodanowe |  | Automatyczne rozliczanie zapłat wg numerów po imporcie wyciągów. |
| AutoRozliczanieWgPrzelewow | `bool` | bazodanowe |  | Automatyczne rozliczanie wypłat wg przelewów po imporcie wyciągów. |
| AutomatyczneRozliczanie | `bool` | bazodanowe |  |  |
| BankOnline | `Soneta.Kasa.BankowoscElektroniczna.SerwisBankowy` | bazodanowe |  | Webserwis obsługujący tą ewidencję |
| BankOnlineConfig | `Soneta.Business.MemoText` | bazodanowe |  | Konfiguracja bankowości online |
| Blokada | `bool` | bazodanowe |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  | Algorytm (C#) wyliczenia numeru rachunku |
| CodeBinder | `Soneta.Business.Compiler.ICodeEditorSource` |  |  | Kod algorytmu rachunków wirtualnych |
| CtxOddziałFirmy | `Soneta.Core.OddzialFirmy` |  |  |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu dla raportów SP |
| DefinicjaED | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Definicja dokumentu w ewidencji dokumentów |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| Domyslny | `bool` | bazodanowe |  |  |
| EksportPrzelewow | `Soneta.Kasa.FormatWymianyElektronicznej` | bazodanowe |  |  |
| EksportPrzelewowWal | `Soneta.Kasa.FormatWymianyElektronicznej` | bazodanowe |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Elixir | `Soneta.Kasa.ElixirInfo` | bazodanowe |  |  |
| Elixir.Kierunek | `string` | bazodanowe |  |  |
| Elixir.Numer | `string` | bazodanowe |  |  |
| FiltrImportu | `string` | bazodanowe |  |  |
| FiltrImportuExt | `Soneta.Business.MemoText` | bazodanowe |  | Pole dla konfiguracji robionej przez Soneta.Banki v2 |
| FiltrImportuWB | `Soneta.Kasa.ImportWyciagowBankowychFilterBase` |  |  |  |
| FiltrImportuWBInfo | `Soneta.Kasa.ImportWyciagowBankowychFilterInfo` |  |  |  |
| Firma | `Soneta.Core.OddzialFirmy` |  |  |  |
| IdentyfikacjaWgPolaPodmiot | `Soneta.Kasa.IdentyfikacjaWgPolaPodmiot` | bazodanowe, enum |  | Sposób wykorzystania tabeli identyfikacji podmiotów |
| ImportWyciagow | `Soneta.Kasa.FormatWymianyElektronicznej` |  |  |  |
| KSeFOpis | `string` | bazodanowe |  | Opis rachunku KSeF |
| Karta | `Soneta.Kasa.KartaPlatnicza` | bazodanowe |  |  |
| Karta.Nazwa | `string` | bazodanowe |  |  |
| Karta.Numer | `string` | bazodanowe |  |  |
| Karta.WaznaDo | `Soneta.Types.YearMonth` | bazodanowe |  |  |
| KasowanieOperacji | `bool` | bazodanowe |  | Czy z wyciągu można kasować operacje bankowe. |
| MagazynWalut | `bool` | bazodanowe |  |  |
| MethodName | `string` |  |  | Nazwa metody lub właściwości w generowanym kodzie algorytmu. |
| Nadrzędne | `Soneta.Business.SubTable<Soneta.Kasa.SubEwidencjaSP>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NiestandardowyFiltrImportu | `Soneta.Business.MemoText` | bazodanowe |  | Filtr importu utworzony za pomocą kreatora |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| OkresRaportow | `Soneta.Kasa.OkresRaportuESP` | bazodanowe, enum |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| Podrzędne | `Soneta.Business.SubTable<Soneta.Kasa.SubEwidencjaSP>` |  |  |  |
| PowiazaneRachunkiRozliczeniowe | `Soneta.Business.SubTable<Soneta.Kasa.EwidencjaSP>` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| PowiazanyRachunekVAT | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Powiązany rachunek VAT |  |
| ProcesorWyciaguKod | `Soneta.Business.MemoText` | bazodanowe |  | Kod obróbki wyciągów |
| ProcesorWyciaguWlaczony | `bool` | bazodanowe |  | Włącznik kodu obróbki wyciagów |
| Rachunek | `Soneta.Kasa.RachunekBankowy` |  |  |  |
| RachunekVAT | `bool` | bazodanowe | Rachunek VAT |  |
| RachunkiWirtualne | `Soneta.Kasa.TypRachunkówWirtualnych` | bazodanowe, enum |  |  |
| RodzajRaportow | `Soneta.Kasa.RodzajRaportuESP` | bazodanowe, enum |  |  |
| RozliczenieWyplatMW | `Soneta.Kasa.MagazynWalut` | bazodanowe, enum |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| SaldoBO | `Soneta.Types.Currency` | bazodanowe |  |  |
| ScisleRozliczanieMPP | `bool` | bazodanowe | Ścisłe rozliczanie MPP | Ścisłe rozliczanie dokumentów MPP po imporcie wyciągów |
| Segment | `string` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| SymbolWaluty | `string` |  |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypEwidencjiSP` | bazodanowe, enum |  |  |
| TypDanych | `Soneta.Kasa.TypDanychESP` | bazodanowe, enum |  |  |
| UjemneStanyWKasie | `bool` | bazodanowe |  |  |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe |  |  |
| Wielooddzialowosc | `bool` |  |  |  |
| Zero | `Soneta.Types.Currency` |  |  |  |

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
