# Pola i właściwości klasy biznesowej: `Soneta.Kasa.Zaplata`
Nazwa tabeli: `Zaplaty`
Tytuł: Wpłaty i wypłaty
Opis: Zapis kasowy lub bankowy reprezentujący faktyczną wpłatę lub wypłatę środków pieniężnych. Rejestruje kwotę, kurs walutowy, sposób zapłaty oraz powiązanie z raportem ewidencji. Podlega rozliczaniu z płatnościami, obsłudze magazynu walut, mechanizmowi MPP oraz preliminarzowi płatności.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IRozliczalny`, `IElementKsiegowalny`, `IZrodloOpisuAnalitycznego`, `IDaneKontrahentaHost`, `IDokumentCRM`

- pola bazodanowe (zapisywalne): 33
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 37
- podlisty: 18
- subrowy: 4
- razem: 94

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaPrzelewow | `bool` | bazodanowe | Blokada przelewów |  |
| Bufor | `bool` | tylko-odczyt |  |  |
| Czas | `Time` | bazodanowe, tylko-odczyt |  |  |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` | tylko-odczyt |  |  |
| DataDokumentu | `Date` | bazodanowe |  |  |
| DataRozliczenia | `Date` | bazodanowe, tylko-odczyt |  |  |
| DoRozliczenia | `Currency` | tylko-odczyt |  |  |
| Dokument | `Soneta.Kasa.IDokumentKasowy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Dokumenty | `SubTable<Soneta.Kasa.RozliczenieSP>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe, tylko-odczyt |  |  |
| EwidencjaWalutowa | `bool` | tylko-odczyt |  |  |
| Handlowa | `bool` | bazodanowe |  | Czy zapłata dotyczy operacji zakwalifikowanej jako handlowa |
| HistoriaWindykacji | `SubTable<Soneta.Windykacja.Windykacja>` | podlista |  |  |
| Karta | `Soneta.Kasa.KartaPlatnicza` (subrow) | bazodanowe |  |  |
| Karta.Nazwa | `string` | bazodanowe |  |  |
| Karta.Numer | `string` | bazodanowe |  |  |
| Karta.WaznaDo | `YearMonth` | bazodanowe |  |  |
| Kierunek | `Soneta.Core.KierunekPlatnosci` (enum) | bazodanowe, tylko-odczyt |  |  |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` | tylko-odczyt |  |  |
| KsiegujZbiorczo | `bool` | bazodanowe |  |  |
| Kurs | `double` | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| KwotaKsiegi | `Currency` | bazodanowe, tylko-odczyt |  |  |
| KwotaMPP | `Currency` | bazodanowe | Kwota VAT/MPP |  |
| KwotaRaportu | `Currency` | bazodanowe |  |  |
| KwotaRozliczona | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  |  |
| MagazynWalut | `Soneta.Kasa.MagazynWalut` (enum) | bazodanowe |  | Pole informujące, czy zapłata podlega rozliczaniu w magazynie walut. Może być wyłączone tylko dla zapisów nie podlegających rozliczeniu. |
| MozliweMechanizmyMPP | `bool` | tylko-odczyt |  |  |
| NumerDokumentu | `string` | bazodanowe |  |  |
| NumeryDokumentow | `string` | bazodanowe |  |  |
| Obroty | `SubTable` | podlista |  |  |
| OkresVAT | `FromTo` | bazodanowe, podlista | Okres VAT |  |
| OperacjeBankowe | `SubTable<Soneta.Kasa.OperacjaBankowa>` | podlista |  |  |
| Opis | `string` | bazodanowe |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| PozycjeDokRozlicz | `SubTable<Soneta.Kasa.PozycjaDokRozlicz>` | podlista |  |  |
| PozycjePrzelewu | `SubTable<Soneta.Kasa.PozycjaPrzelewu>` | podlista |  |  |
| PreliminarzPoz | `Soneta.Kasa.PreliminarzPozycja` | bazodanowe |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowy` (subrow) | bazodanowe |  |  |
| Rachunek.Bank | `Soneta.Kasa.IBank` | bazodanowe |  |  |
| Rachunek.Numer | `Soneta.Kasa.NumerRachunku` (subrow) | bazodanowe |  |  |
| Rachunek.Numer.CS | `string` | bazodanowe |  |  |
| Rachunek.Numer.IBAN | `bool` | tylko-odczyt |  |  |
| Rachunek.Numer.IsEmpty | `bool` | tylko-odczyt |  |  |
| Rachunek.Numer.Kierunek | `string` | bazodanowe |  |  |
| Rachunek.Numer.Kraj | `string` | bazodanowe |  |  |
| Rachunek.Numer.NRB | `bool` | tylko-odczyt |  |  |
| Rachunek.Numer.Numer | `string` | bazodanowe |  |  |
| Rachunek.Numer.NumerF | `string` | tylko-odczyt |  |  |
| Rachunek.Numer.PKO | `bool` | tylko-odczyt |  |  |
| Rachunek.Numer.Pełny | `string` |  | Numer rachunku |  |
| Rachunek.Numer.PełnyNRB | `string` |  | Numer rachunku |  |
| Rachunek.Numer.SEPA | `bool` | tylko-odczyt |  |  |
| Rachunek.SWIFT | `string` | bazodanowe |  |  |
| Rachunek.WgBank | `Key` | podlista |  |  |
| Raport | `Soneta.Core.IRaportEwidencjiSP` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Rozliczana | `bool` | bazodanowe |  |  |
| Rozliczenia | `System.Collections.IList` | podlista |  |  |
| RozliczoneDokumenty | `string` | tylko-odczyt |  |  |
| Rozliczono | `bool` | tylko-odczyt |  |  |
| Rozrachunki | `SubTable<Soneta.Kasa.RozrachunekIdx>` | podlista |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | bazodanowe |  |  |
| Stan | `Soneta.Kasa.StanZapłaty` (enum) | bazodanowe, tylko-odczyt |  |  |
| StanRozliczenia | `Soneta.Kasa.StanRozliczenia` (enum) | tylko-odczyt |  |  |
| Słownie | `string` | tylko-odczyt |  |  |
| SłownieUpr | `string` | tylko-odczyt | Słownie |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypRozrachunku` (enum) | tylko-odczyt |  |  |
| WartoscWgKursu | `Currency` | bazodanowe |  |  |
| WartoscWgMagazynuWalut | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Wartość | `Currency` | tylko-odczyt |  |  |
| Windykacja | `Soneta.Windykacja.WindykacjaInfo` (subrow) | bazodanowe |  |  |
| Windykacja.Data | `Date` | bazodanowe |  |  |
| Windykacja.Stan | `Soneta.Windykacja.StanWindykacji` | bazodanowe |  |  |
| Windykacja.Termin | `Date` | bazodanowe |  |  |
| Windykacja.WgStan | `Key` | podlista |  |  |
| Wpłata | `Currency` | tylko-odczyt |  |  |
| Wynagrodzenie | `bool` | bazodanowe, tylko-odczyt |  | Zapłata została zakwalifikowana jako odnosząca się do wynagrodzenia. |
| WynagrodzenieMetoda | `Soneta.Kasa.WynagrodzenieMetoda` (enum) | bazodanowe |  | Jak ma zostać ustalona wartość flagi 'Wynagrodzenie'. |
| Wypłata | `Currency` | tylko-odczyt |  |  |
| ZadaniaCRM | `SubTable` | podlista |  |  |
| Zaksięgowana | `bool` | tylko-odczyt |  |  |
| Zaliczki | `SubTable` | podlista |  |  |
| ZapisyKsiegowe | `SubTable` | podlista |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.RozliczenieSP>` | podlista |  |  |
| Zasoby | `SubTable<Soneta.Kasa.ZasobMW>` | podlista |  |  |
| ZasobySkopiowaneDo | `Soneta.Kasa.Wplata` | tylko-odczyt |  |  |
| ZasobySkopiowaneZ | `Soneta.Kasa.Wyplata` | bazodanowe, tylko-odczyt |  |  |
| ZasobyWgOkresu | `View` | podlista |  |  |
| Zatwierdzona | `bool` | tylko-odczyt |  |  |
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
