# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ZapisKsiegowy`
Nazwa tabeli: `ZapisyKsiegowe`
Tytuł: Zapisy księgowe
Opis: Zapis księgowy to pojedyncza pozycja dekretu przypisana do konkretnego konta w planie kont. Rejestruje kwotę operacji i kwotę zapisu po stronie Winien lub Ma, wraz z kursem walutowym. Obsługuje rozliczenia księgowe, zapisy pomocnicze, powiązania z elementami księgowalnymi oraz zapisy zamknięcia okresu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dekret` → `DekretBase`
Implementuje interfejsy: `IElementKsiegowalny`

- pola bazodanowe: 26
- pola kalkulowane (z klas biznesowych): 35

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataPodatkowa | `Soneta.Types.Date` | bazodanowe |  |  |
| DataRozliczenia | `Soneta.Types.Date` | bazodanowe |  |  |
| DefinicjaEwidencji | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Dekret | `Soneta.Ksiega.DekretBase` | bazodanowe, guided-parent |  |  |
| DoRozliczeniaKwotyOperacji | `Soneta.Types.Currency` |  |  |  |
| DoRozliczeniaKwotyZapisu | `Soneta.Types.Currency` |  |  |  |
| DoRozliczeniaMa | `Soneta.Types.Currency` |  |  |  |
| DoRozliczeniaMaOperacji | `Soneta.Types.Currency` |  |  |  |
| DoRozliczeniaSaldo | `Soneta.Types.Currency` |  |  |  |
| DoRozliczeniaSaldoOperacji | `Soneta.Types.Currency` |  |  |  |
| DoRozliczeniaWinien | `Soneta.Types.Currency` |  |  |  |
| DoRozliczeniaWinienOperacji | `Soneta.Types.Currency` |  |  |  |
| ElementKsiegowalny | `Soneta.Core.IElementKsiegowalny` | bazodanowe, iface-ref |  | Element księgowalny zapisu |
| ElementSlownika | `Soneta.Core.IElementSlownika` | iface-ref |  |  |
| Grupa | `int` | bazodanowe |  |  |
| Kod | `string` |  |  |  |
| KolumnaRyczałt | `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRRyczałt` | enum |  |  |
| Konto | `Soneta.Ksiega.KontoBase` | bazodanowe |  |  |
| Kurs | `double` | bazodanowe |  |  |
| KwotaOperacji | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaOperacjiRozliczenia | `Soneta.Types.Currency` |  |  |  |
| KwotaZapisu | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaZapisuRozliczenia | `Soneta.Types.Currency` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| LpKonta | `int` | bazodanowe |  |  |
| Ma | `Soneta.Types.Currency` |  |  |  |
| MaOperacji | `Soneta.Types.Currency` |  |  |  |
| NazwaElementuKsiegowalnego | `string` |  |  |  |
| Numer | `string` |  |  |  |
| NumerDokumentu | `string` | bazodanowe |  |  |
| NumerEwidencji | `string` | bazodanowe |  |  |
| OK | `bool` |  |  | Określa poprawność zapisu |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe |  | Okres obrachunkowy |
| Opis | `string` | bazodanowe |  |  |
| OpisAnalityczny | `System.Collections.Generic.List<Soneta.Ksiega.ElemOpisuAnalitycznego>` |  |  |  |
| OpisBledu | `string` |  |  |  |
| OpisyAnalityczne | `Soneta.Business.SubTable<Soneta.Ksiega.ElemOpisuAnalZapRel>` |  |  |  |
| OpisyPowiazane | `Soneta.Business.SubTable<Soneta.Ksiega.ElemOpisuAnalitycznego>` |  |  |  |
| PowiazanieExcel | `string` |  |  |  |
| Rozliczenia | `System.Collections.IList` |  |  |  |
| RozliczeniaMa | `Soneta.Business.SubTable<Soneta.Ksiega.RozliczenieKS>` |  |  |  |
| RozliczeniaWinien | `Soneta.Business.SubTable<Soneta.Ksiega.RozliczenieKS>` |  |  |  |
| RozliczonaKwotaOperacji | `Soneta.Types.Currency` | bazodanowe |  |  |
| RozliczonaKwotaZapisu | `Soneta.Types.Currency` | bazodanowe |  |  |
| Saldo | `Soneta.Types.Currency` |  |  |  |
| Seria | `string` |  |  |  |
| StanRozliczenia | `Soneta.Kasa.StanRozliczenia` | enum |  |  |
| Strona | `Soneta.Core.StronaKsiegowania` | bazodanowe, enum |  |  |
| StronaRozliczenia | `Soneta.Core.StronaKsiegowania` | enum |  |  |
| Typ | `Soneta.Ksiega.TypZapisu` | bazodanowe, enum |  |  |
| TypDziennika | `Soneta.Ksiega.TypDziennika` | bazodanowe, enum |  |  |
| TypWgKonta | `Soneta.Ksiega.TypZapisuWgKonta` | bazodanowe, enum |  |  |
| Winien | `Soneta.Types.Currency` |  |  |  |
| WinienOperacji | `Soneta.Types.Currency` |  |  |  |
| Zaksiegowany | `bool` |  |  |  |
| ZapisGlowny | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe |  |  |
| ZapisZamkniecia | `bool` | bazodanowe | Zapis zamknięcia |  |
| ZapisyKsiegowe | `Soneta.Business.SubTable<Soneta.Ksiega.ZapisKsiegowy>` |  |  |  |
| ZapisyPomocnicze | `Soneta.Business.SubTable<Soneta.Ksiega.ZapisKsiegowy>` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ElementKsiegowalny | `IElementKsiegowalny` | `Platnosc`, `RozliczenieKS`, `ZapisKsiegowy`, `Zaplata` |
| ElementSlownika | `IElementSlownika` | `Bank`, `CentrumKosztow`, `DokumentHandlowy`, `ElemSlownika`, `EwidencjaSP`, `GrupaSzkol`, `InstytucjaFinansowaPPK`, `Kontrahent`, `KosztRMK`, `Lead`, `Magazyn`, `OddzialFirmy`, `Pojazd`, `Pracownik`, `ProWydzial`, `ProZasob`, `ProZlecenie`, `Projekt`, `RodzajSzkol`, `RodzajZrodla`, `SrodekTrwalyBase`, `Towar`, `Transakcja`, `UrzadCelny`, `UrzadSkarbowy`, `Urzadzenie`, `Wydzial`, `ZUS`, `Zadanie`, `ZrodloFinansowania` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StronaKsiegowania (`Soneta.Core.StronaKsiegowania`)
- `Brak` = 0
- `Winien` = 1
- `Ma` = 2

### KolumnaKPiRRyczałt (`Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRRyczałt`)
- `NieDotyczy` = 0
- `Stawka1` = 101 — 17,00% (20,00% do 31.12.2020) Stawka 1
- `Stawka2` = 102 — 15,00% (17,00% do 31.12.2020) Stawka 2
- `Stawka3` = 103 — 8,50% Stawka 3
- `Stawka4` = 104 — 5,50% Stawka 4
- `Stawka5` = 105 — 3,00% Stawka 5
- `Stawka6` = 106 — 10,00% Stawka 6
- `Stawka7` = 107 — 2,00% Stawka 7
- `Stawka8` = 108 — 12,50% Stawka 8
- `Stawka9` = 109 — 14,00% Stawka 9
- `Stawka10` = 110 — 12,00% Stawka 10

### StanRozliczenia (`Soneta.Kasa.StanRozliczenia`)
- `Nierozliczony` = 0
- `Czesciowo` = 1 — Częściowo
- `Calkowicie` = 2 — Rozliczony
- `NiePodlega` = 3

### TypDziennika (`Soneta.Ksiega.TypDziennika`)
- `Brak` = 0 — Brak
- `Dekret` = 1
- `BO` = 2

### TypZapisu (`Soneta.Ksiega.TypZapisu`)
- `Brak` = 0 — Brak
- `Zwykły` = 1
- `Walutowy` = 2

### TypZapisuWgKonta (`Soneta.Ksiega.TypZapisuWgKonta`)
- `Brak` = 0 — Nieokreślony
- `Bilansowy` = 1
- `Pozabilansowy` = 2
