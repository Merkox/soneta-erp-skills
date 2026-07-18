# Pola i właściwości klasy biznesowej: `Soneta.Kasa.Wyplata`
Nazwa tabeli: `Wyplaty`
Tytuł: Wypłaty
Opis: Wypłata wynagrodzenia dla pracownika w ramach listy płac. Zawiera kwotę do wypłaty, miesiąc deklaracji PIT i ZUS, kurs walutowy oraz zbiera elementy składowe wynagrodzenia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentPlatny`, `IDokumentKsiegowalny`, `IZrodloOpisuAnalitycznego`

- pola bazodanowe (zapisywalne): 15
- pola kalkulowane (zapisywalne): 20
- pola tylko-odczyt: 35
- podlisty: 19
- subrowy: 1
- razem: 90

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaPrzelewow | `bool` |  | Blokada przelewów |  |
| Bufor | `bool` | bazodanowe, tylko-odczyt |  |  |
| Czas | `Time` | tylko-odczyt |  |  |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  |  |
| DataDokumentu | `Date` |  |  |  |
| DataRozliczenia | `Date` | tylko-odczyt |  |  |
| Definicja | `IRow` | bazodanowe |  |  |
| DoRozliczenia | `Currency` | tylko-odczyt |  |  |
| Dokument | `Soneta.Kasa.IDokumentKasowy` | tylko-odczyt, iface-ref |  |  |
| Dokumenty | `SubTable<Soneta.Kasa.RozliczenieSP>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | tylko-odczyt |  |  |
| EwidencjaWalutowa | `bool` | tylko-odczyt |  |  |
| Handlowa | `bool` |  |  |  |
| HistoriaWindykacji | `SubTable<Soneta.Windykacja.Windykacja>` | podlista |  |  |
| Karta | `Soneta.Kasa.KartaPlatnicza` | tylko-odczyt |  |  |
| Kierunek | `Soneta.Core.KierunekPlatnosci` (enum) | tylko-odczyt |  |  |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` | tylko-odczyt |  |  |
| KsiegujZbiorczo | `bool` |  |  |  |
| Kurs | `double` | bazodanowe |  |  |
| Kwota | `Currency` |  |  |  |
| KwotaKsiegi | `Currency` | tylko-odczyt |  |  |
| KwotaMPP | `Currency` |  |  |  |
| KwotaRaportu | `Currency` |  |  |  |
| KwotaRozliczona | `Currency` | tylko-odczyt |  |  |
| ListaPlac | `IRow` | bazodanowe |  |  |
| Lp | `int` |  |  |  |
| MagazynWalut | `Soneta.Kasa.MagazynWalut` (enum) |  |  |  |
| MiesWstecz | `int` | bazodanowe |  |  |
| MiesiacDeklaracji | `YearMonth` | bazodanowe | Miesiąc deklaracji |  |
| MiesiacZUSDzien | `Date` | bazodanowe | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| MozliweMechanizmyMPP | `bool` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.CoreModule.NumerDokumentuRecord` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerDokumentu | `string` |  |  |  |
| NumeryDokumentow | `string` |  |  |  |
| Obroty | `SubTable` | podlista |  |  |
| OkresVAT | `FromTo` | podlista |  |  |
| OperacjeBankowe | `SubTable<Soneta.Kasa.OperacjaBankowa>` | podlista |  |  |
| Opis | `string` |  |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | iface-ref |  |  |
| Powiazanie | `IRow` | bazodanowe |  |  |
| PozycjeDokRozlicz | `SubTable<Soneta.Kasa.PozycjaDokRozlicz>` | podlista |  |  |
| PozycjePrzelewu | `SubTable<Soneta.Kasa.PozycjaPrzelewu>` | podlista |  |  |
| Pracownik | `IRow` | bazodanowe |  |  |
| PreliminarzPoz | `Soneta.Kasa.PreliminarzPozycja` |  |  |  |
| Rachunek | `Soneta.Kasa.RachunekBankowy` | tylko-odczyt |  |  |
| Raport | `Soneta.Core.IRaportEwidencjiSP` | tylko-odczyt, iface-ref |  |  |
| Rozliczana | `bool` |  |  |  |
| Rozliczenia | `System.Collections.IList` | podlista |  |  |
| RozliczoneDokumenty | `string` | tylko-odczyt |  |  |
| Rozliczono | `bool` | tylko-odczyt |  |  |
| Rozrachunki | `SubTable<Soneta.Kasa.RozrachunekIdx>` | podlista |  |  |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` |  |  |  |
| Stan | `Soneta.Kasa.StanZapłaty` (enum) | tylko-odczyt |  |  |
| StanRozliczenia | `Soneta.Kasa.StanRozliczenia` (enum) | tylko-odczyt |  |  |
| Słownie | `string` | tylko-odczyt |  |  |
| SłownieUpr | `string` | tylko-odczyt | Słownie |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypRozrachunku` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `Currency` | bazodanowe |  | Wartość (kwota do wypłaty) dokumentu w PLN |
| WartoscCy | `Currency` | bazodanowe |  | Wartość (kwota do wypłaty) dokumentu po przeliczeniu na walutę listy płac |
| WartoscWgKursu | `Currency` |  |  |  |
| WartoscWgMagazynuWalut | `Currency` | tylko-odczyt |  |  |
| Wartość | `Currency` | tylko-odczyt |  |  |
| Windykacja | `Soneta.Windykacja.WindykacjaInfo` | tylko-odczyt |  |  |
| Wpłata | `Currency` | tylko-odczyt |  |  |
| WspKoszty50 | `Percent` | bazodanowe |  |  |
| Wynagrodzenie | `bool` | tylko-odczyt |  | Zapłata została zakwalifikowana jako odnosząca się do wynagrodzenia. |
| WynagrodzenieMetoda | `Soneta.Kasa.WynagrodzenieMetoda` (enum) |  |  |  |
| Wypłata | `Currency` | tylko-odczyt |  |  |
| ZadaniaCRM | `SubTable` | podlista |  |  |
| Zaksięgowana | `bool` | tylko-odczyt |  |  |
| Zaliczki | `SubTable` | podlista |  |  |
| ZapisObliczen | `MemoText` | bazodanowe, podlista |  |  |
| ZapisyKsiegowe | `SubTable` | podlista |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.RozliczenieSP>` | podlista |  |  |
| Zasoby | `SubTable<Soneta.Kasa.ZasobMW>` | podlista |  |  |
| ZasobySkopiowaneDo | `Soneta.Kasa.Wplata` | tylko-odczyt |  |  |
| ZasobySkopiowaneZ | `Soneta.Kasa.Wyplata` | tylko-odczyt |  |  |
| ZasobyWgOkresu | `View` | podlista |  |  |
| Zatwierdzona | `bool` | tylko-odczyt |  |  |
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
