# Pola i właściwości klasy biznesowej: `Soneta.Kasa.Wyplata`
Nazwa tabeli: `Wyplaty`
Tytuł: Wypłaty
Opis: Wypłata wynagrodzenia dla pracownika w ramach listy płac. Zawiera kwotę do wypłaty, miesiąc deklaracji PIT i ZUS, kurs walutowy oraz zbiera elementy składowe wynagrodzenia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentPlatny`, `IDokumentKsiegowalny`, `IZrodloOpisuAnalitycznego`

- pola bazodanowe: 20
- pola kalkulowane (z klas biznesowych): 70

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaPrzelewow | `bool` |  | Blokada przelewów |  |
| Bufor | `bool` | bazodanowe |  |  |
| Czas | `Soneta.Types.Time` |  |  |  |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataDokumentu | `Soneta.Types.Date` |  |  |  |
| DataRozliczenia | `Soneta.Types.Date` |  |  |  |
| Definicja | `Soneta.Business.IRow` | bazodanowe |  |  |
| DoRozliczenia | `Soneta.Types.Currency` |  |  |  |
| Dokument | `Soneta.Kasa.IDokumentKasowy` | iface-ref |  |  |
| Dokumenty | `Soneta.Business.SubTable<Soneta.Kasa.RozliczenieSP>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` |  |  |  |
| EwidencjaWalutowa | `bool` |  |  |  |
| Handlowa | `bool` |  |  |  |
| HistoriaWindykacji | `Soneta.Business.SubTable<Soneta.Windykacja.Windykacja>` |  |  |  |
| Karta | `Soneta.Kasa.KartaPlatnicza` |  |  |  |
| Kierunek | `Soneta.Core.KierunekPlatnosci` | enum |  |  |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` |  |  |  |
| KsiegujZbiorczo | `bool` |  |  |  |
| Kurs | `double` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` |  |  |  |
| KwotaKsiegi | `Soneta.Types.Currency` |  |  |  |
| KwotaMPP | `Soneta.Types.Currency` |  |  |  |
| KwotaRaportu | `Soneta.Types.Currency` |  |  |  |
| KwotaRozliczona | `Soneta.Types.Currency` |  |  |  |
| ListaPlac | `Soneta.Business.IRow` | bazodanowe |  |  |
| Lp | `int` |  |  |  |
| MagazynWalut | `Soneta.Kasa.MagazynWalut` | enum |  |  |
| MiesWstecz | `int` | bazodanowe |  |  |
| MiesiacDeklaracji | `Soneta.Types.YearMonth` | bazodanowe | Miesiąc deklaracji |  |
| MiesiacZUSDzien | `Soneta.Types.Date` | bazodanowe | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| MozliweMechanizmyMPP | `bool` |  |  |  |
| Numer | `Soneta.Core.CoreModule.NumerDokumentuRecord` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerDokumentu | `string` |  |  |  |
| NumeryDokumentow | `string` |  |  |  |
| Obroty | `Soneta.Business.SubTable` |  |  |  |
| OkresVAT | `Soneta.Types.FromTo` |  |  |  |
| OperacjeBankowe | `Soneta.Business.SubTable<Soneta.Kasa.OperacjaBankowa>` |  |  |  |
| Opis | `string` |  |  |  |
| OpisAnalityczny | `Soneta.Business.SubTable` |  |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | iface-ref |  |  |
| Powiazanie | `Soneta.Business.IRow` | bazodanowe |  |  |
| PozycjeDokRozlicz | `Soneta.Business.SubTable<Soneta.Kasa.PozycjaDokRozlicz>` |  |  |  |
| PozycjePrzelewu | `Soneta.Business.SubTable<Soneta.Kasa.PozycjaPrzelewu>` |  |  |  |
| Pracownik | `Soneta.Business.IRow` | bazodanowe |  |  |
| PreliminarzPoz | `Soneta.Kasa.PreliminarzPozycja` |  |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowy` |  |  |  |
| Raport | `Soneta.Core.IRaportEwidencjiSP` | iface-ref |  |  |
| Rozliczana | `bool` |  |  |  |
| Rozliczenia | `System.Collections.IList` |  |  |  |
| RozliczoneDokumenty | `string` |  |  |  |
| Rozliczono | `bool` |  |  |  |
| Rozrachunki | `Soneta.Business.SubTable<Soneta.Kasa.RozrachunekIdx>` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` |  |  |  |
| Stan | `Soneta.Kasa.StanZapłaty` | enum |  |  |
| StanRozliczenia | `Soneta.Kasa.StanRozliczenia` | enum |  |  |
| Słownie | `string` |  |  |  |
| SłownieUpr | `string` |  | Słownie |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypRozrachunku` | bazodanowe, enum |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  | Wartość (kwota do wypłaty) dokumentu w PLN |
| WartoscCy | `Soneta.Types.Currency` | bazodanowe |  | Wartość (kwota do wypłaty) dokumentu po przeliczeniu na walutę listy płac |
| WartoscWgKursu | `Soneta.Types.Currency` |  |  |  |
| WartoscWgMagazynuWalut | `Soneta.Types.Currency` |  |  |  |
| Wartość | `Soneta.Types.Currency` |  |  |  |
| Windykacja | `Soneta.Windykacja.WindykacjaInfo` |  |  |  |
| Wpłata | `Soneta.Types.Currency` |  |  |  |
| WspKoszty50 | `Soneta.Types.Percent` | bazodanowe |  |  |
| Wynagrodzenie | `bool` |  |  | Zapłata została zakwalifikowana jako odnosząca się do wynagrodzenia. |
| WynagrodzenieMetoda | `Soneta.Kasa.WynagrodzenieMetoda` | enum |  |  |
| Wypłata | `Soneta.Types.Currency` |  |  |  |
| ZadaniaCRM | `Soneta.Business.SubTable` |  |  |  |
| Zaksięgowana | `bool` |  |  |  |
| Zaliczki | `Soneta.Business.SubTable` |  |  |  |
| ZapisObliczen | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ZapisyKsiegowe | `Soneta.Business.SubTable` |  |  |  |
| Zaplaty | `Soneta.Business.SubTable<Soneta.Kasa.RozliczenieSP>` |  |  |  |
| Zasoby | `Soneta.Business.SubTable<Soneta.Kasa.ZasobMW>` |  |  |  |
| ZasobySkopiowaneDo | `Soneta.Kasa.Wplata` |  |  |  |
| ZasobySkopiowaneZ | `Soneta.Kasa.Wyplata` |  |  |  |
| ZasobyWgOkresu | `Soneta.Business.View` |  |  |  |
| Zatwierdzona | `bool` |  |  |  |
| Zwrot | `bool` |  |  |  |

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
