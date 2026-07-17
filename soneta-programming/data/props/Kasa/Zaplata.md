# Pola i właściwości klasy biznesowej: `Soneta.Kasa.Zaplata`
Nazwa tabeli: `Zaplaty`
Tytuł: Wpłaty i wypłaty
Opis: Zapis kasowy lub bankowy reprezentujący faktyczną wpłatę lub wypłatę środków pieniężnych. Rejestruje kwotę, kurs walutowy, sposób zapłaty oraz powiązanie z raportem ewidencji. Podlega rozliczaniu z płatnościami, obsłudze magazynu walut, mechanizmowi MPP oraz preliminarzowi płatności.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRozliczalny`, `IElementKsiegowalny`, `IZrodloOpisuAnalitycznego`, `IDaneKontrahentaHost`, `IDokumentCRM`

- pola bazodanowe: 50
- pola kalkulowane (z klas biznesowych): 44

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaPrzelewow | `bool` | bazodanowe | Blokada przelewów |  |
| Bufor | `bool` |  |  |  |
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` |  |  |  |
| DataDokumentu | `Soneta.Types.Date` | bazodanowe |  |  |
| DataRozliczenia | `Soneta.Types.Date` | bazodanowe |  |  |
| DoRozliczenia | `Soneta.Types.Currency` |  |  |  |
| Dokument | `Soneta.Kasa.IDokumentKasowy` | bazodanowe, iface-ref |  |  |
| Dokumenty | `Soneta.Business.SubTable<Soneta.Kasa.RozliczenieSP>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| EwidencjaWalutowa | `bool` |  |  |  |
| Handlowa | `bool` | bazodanowe |  | Czy zapłata dotyczy operacji zakwalifikowanej jako handlowa |
| HistoriaWindykacji | `Soneta.Business.SubTable<Soneta.Windykacja.Windykacja>` |  |  |  |
| Karta | `Soneta.Kasa.KartaPlatnicza` | bazodanowe |  |  |
| Karta.Nazwa | `string` | bazodanowe |  |  |
| Karta.Numer | `string` | bazodanowe |  |  |
| Karta.WaznaDo | `Soneta.Types.YearMonth` | bazodanowe |  |  |
| Kierunek | `Soneta.Core.KierunekPlatnosci` | bazodanowe, enum |  |  |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` |  |  |  |
| KsiegujZbiorczo | `bool` | bazodanowe |  |  |
| Kurs | `double` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaKsiegi | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaMPP | `Soneta.Types.Currency` | bazodanowe | Kwota VAT/MPP |  |
| KwotaRaportu | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaRozliczona | `Soneta.Types.Currency` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| MagazynWalut | `Soneta.Kasa.MagazynWalut` | bazodanowe, enum |  | Pole informujące, czy zapłata podlega rozliczaniu w magazynie walut. Może być wyłączone tylko dla zapisów nie podlegających rozliczeniu. |
| MozliweMechanizmyMPP | `bool` |  |  |  |
| NumerDokumentu | `string` | bazodanowe |  |  |
| NumeryDokumentow | `string` | bazodanowe |  |  |
| Obroty | `Soneta.Business.SubTable` |  |  |  |
| OkresVAT | `Soneta.Types.FromTo` | bazodanowe | Okres VAT |  |
| OperacjeBankowe | `Soneta.Business.SubTable<Soneta.Kasa.OperacjaBankowa>` |  |  |  |
| Opis | `string` | bazodanowe |  |  |
| OpisAnalityczny | `Soneta.Business.SubTable` |  |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| PozycjeDokRozlicz | `Soneta.Business.SubTable<Soneta.Kasa.PozycjaDokRozlicz>` |  |  |  |
| PozycjePrzelewu | `Soneta.Business.SubTable<Soneta.Kasa.PozycjaPrzelewu>` |  |  |  |
| PreliminarzPoz | `Soneta.Kasa.PreliminarzPozycja` | bazodanowe |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowy` | bazodanowe |  |  |
| Rachunek.Bank | `Soneta.Kasa.IBank` | bazodanowe |  |  |
| Rachunek.Numer | `Soneta.Kasa.NumerRachunku` | bazodanowe |  |  |
| Rachunek.Numer.CS | `string` | bazodanowe |  |  |
| Rachunek.Numer.IBAN | `bool` |  |  |  |
| Rachunek.Numer.IsEmpty | `bool` |  |  |  |
| Rachunek.Numer.Kierunek | `string` | bazodanowe |  |  |
| Rachunek.Numer.Kraj | `string` | bazodanowe |  |  |
| Rachunek.Numer.NRB | `bool` |  |  |  |
| Rachunek.Numer.Numer | `string` | bazodanowe |  |  |
| Rachunek.Numer.NumerF | `string` |  |  |  |
| Rachunek.Numer.PKO | `bool` |  |  |  |
| Rachunek.Numer.Pełny | `string` |  | Numer rachunku |  |
| Rachunek.Numer.PełnyNRB | `string` |  | Numer rachunku |  |
| Rachunek.Numer.SEPA | `bool` |  |  |  |
| Rachunek.SWIFT | `string` | bazodanowe |  |  |
| Rachunek.WgBank | `Soneta.Business.Key` |  |  |  |
| Raport | `Soneta.Core.IRaportEwidencjiSP` | bazodanowe, iface-ref |  |  |
| Rozliczana | `bool` | bazodanowe |  |  |
| Rozliczenia | `System.Collections.IList` |  |  |  |
| RozliczoneDokumenty | `string` |  |  |  |
| Rozliczono | `bool` |  |  |  |
| Rozrachunki | `Soneta.Business.SubTable<Soneta.Kasa.RozrachunekIdx>` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | bazodanowe |  |  |
| Stan | `Soneta.Kasa.StanZapłaty` | bazodanowe, enum |  |  |
| StanRozliczenia | `Soneta.Kasa.StanRozliczenia` | enum |  |  |
| Słownie | `string` |  |  |  |
| SłownieUpr | `string` |  | Słownie |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypRozrachunku` | enum |  |  |
| WartoscWgKursu | `Soneta.Types.Currency` | bazodanowe |  |  |
| WartoscWgMagazynuWalut | `Soneta.Types.Currency` | bazodanowe |  |  |
| Wartość | `Soneta.Types.Currency` |  |  |  |
| Windykacja | `Soneta.Windykacja.WindykacjaInfo` | bazodanowe |  |  |
| Windykacja.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Windykacja.Stan | `Soneta.Windykacja.StanWindykacji` | bazodanowe |  |  |
| Windykacja.Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| Windykacja.WgStan | `Soneta.Business.Key` |  |  |  |
| Wpłata | `Soneta.Types.Currency` |  |  |  |
| Wynagrodzenie | `bool` | bazodanowe |  | Zapłata została zakwalifikowana jako odnosząca się do wynagrodzenia. |
| WynagrodzenieMetoda | `Soneta.Kasa.WynagrodzenieMetoda` | bazodanowe, enum |  | Jak ma zostać ustalona wartość flagi 'Wynagrodzenie'. |
| Wypłata | `Soneta.Types.Currency` |  |  |  |
| ZadaniaCRM | `Soneta.Business.SubTable` |  |  |  |
| Zaksięgowana | `bool` |  |  |  |
| Zaliczki | `Soneta.Business.SubTable` |  |  |  |
| ZapisyKsiegowe | `Soneta.Business.SubTable` |  |  |  |
| Zaplaty | `Soneta.Business.SubTable<Soneta.Kasa.RozliczenieSP>` |  |  |  |
| Zasoby | `Soneta.Business.SubTable<Soneta.Kasa.ZasobMW>` |  |  |  |
| ZasobySkopiowaneDo | `Soneta.Kasa.Wplata` |  |  |  |
| ZasobySkopiowaneZ | `Soneta.Kasa.Wyplata` | bazodanowe |  |  |
| ZasobyWgOkresu | `Soneta.Business.View` |  |  |  |
| Zatwierdzona | `bool` |  |  |  |
| Zwrot | `bool` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IDokumentKasowy` | `DokKasowyBase`, `DokumentHandlowy` |
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Raport | `IRaportEwidencjiSP` | `DokEwidencji`, `RaportESP` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekPlatnosci (`Soneta.Core.KierunekPlatnosci`)
- `Brak` = 0
- `Przychod` = 1 — Przychód
- `Rozchod` = 2 — Rozchód

### MagazynWalut (`Soneta.Kasa.MagazynWalut`)
- `NiePodlega` = 0 — Nie podlega
- `WgKursuDnia` = 1
- `WgZasobów` = 2
- `WgZasobowHistoryczne` = 3

### StanRozliczenia (`Soneta.Kasa.StanRozliczenia`)
- `Nierozliczony` = 0
- `Czesciowo` = 1 — Częściowo
- `Calkowicie` = 2 — Rozliczony
- `NiePodlega` = 3

### StanZapłaty (`Soneta.Kasa.StanZapłaty`)
- `Bufor` = 0 — Bufor
- `Zatwierdzona` = 1
- `Zaksięgowana` = 2

### TypRozrachunku (`Soneta.Kasa.TypRozrachunku`)
- `Należność` = 10
- `Zobowiązanie` = 11
- `Wpłata` = 20
- `Wypłata` = 21

### WynagrodzenieMetoda (`Soneta.Kasa.WynagrodzenieMetoda`)
- `Wylicz` = 0 — Wylicz
- `Wynagrodzenie` = 1
- `InnaZapłata` = 2
