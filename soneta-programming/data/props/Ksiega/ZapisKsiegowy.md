# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.ZapisKsiegowy`
Nazwa tabeli: `ZapisyKsiegowe`
Tytuł: Zapisy księgowe
Opis: Zapis księgowy to pojedyncza pozycja dekretu przypisana do konkretnego konta w planie kont. Rejestruje kwotę operacji i kwotę zapisu po stronie Winien lub Ma, wraz z kursem walutowym. Obsługuje rozliczenia księgowe, zapisy pomocnicze, powiązania z elementami księgowalnymi oraz zapisy zamknięcia okresu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dekret` → `DekretBase`
Implementuje interfejsy: `IElementKsiegowalny`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 7
- pola tylko-odczyt: 38
- podlisty: 8
- subrowy: 0
- razem: 61

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe, tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| DataPodatkowa | `Date` | bazodanowe |  |  |
| DataRozliczenia | `Date` | bazodanowe, tylko-odczyt |  |  |
| DefinicjaEwidencji | `Soneta.Core.DefinicjaDokumentu` | bazodanowe, tylko-odczyt |  |  |
| Dekret | `Soneta.Ksiega.DekretBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DoRozliczeniaKwotyOperacji | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaKwotyZapisu | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaMa | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaMaOperacji | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaSaldo | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaSaldoOperacji | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaWinien | `Currency` | tylko-odczyt |  |  |
| DoRozliczeniaWinienOperacji | `Currency` | tylko-odczyt |  |  |
| ElementKsiegowalny | `Soneta.Core.IElementKsiegowalny` | bazodanowe, iface-ref |  | Element księgowalny zapisu |
| ElementSlownika | `Soneta.Core.IElementSlownika` | iface-ref |  |  |
| Grupa | `int` | bazodanowe, tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| KolumnaRyczałt | `Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy.KolumnaKPiRRyczałt` (enum) |  |  |  |
| Konto | `Soneta.Ksiega.KontoBase` | bazodanowe |  |  |
| Kurs | `double` | bazodanowe |  |  |
| KwotaOperacji | `Currency` | bazodanowe, tylko-odczyt |  |  |
| KwotaOperacjiRozliczenia | `Currency` | tylko-odczyt |  |  |
| KwotaZapisu | `Currency` | bazodanowe, tylko-odczyt |  |  |
| KwotaZapisuRozliczenia | `Currency` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  |  |
| LpKonta | `int` | bazodanowe, tylko-odczyt |  |  |
| Ma | `Currency` |  |  |  |
| MaOperacji | `Currency` |  |  |  |
| NazwaElementuKsiegowalnego | `string` | tylko-odczyt |  |  |
| Numer | `string` | tylko-odczyt |  |  |
| NumerDokumentu | `string` | bazodanowe, tylko-odczyt |  |  |
| NumerEwidencji | `string` | bazodanowe, tylko-odczyt |  |  |
| OK | `bool` | tylko-odczyt |  | Określa poprawność zapisu |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe, tylko-odczyt |  | Okres obrachunkowy |
| Opis | `string` | bazodanowe |  |  |
| OpisAnalityczny | `System.Collections.Generic.List<Soneta.Ksiega.ElemOpisuAnalitycznego>` | podlista |  |  |
| OpisBledu | `string` | tylko-odczyt |  |  |
| OpisyAnalityczne | `SubTable<Soneta.Ksiega.ElemOpisuAnalZapRel>` | podlista |  |  |
| OpisyPowiazane | `SubTable<Soneta.Ksiega.ElemOpisuAnalitycznego>` | podlista |  |  |
| PowiazanieExcel | `string` |  |  |  |
| Rozliczenia | `System.Collections.IList` | podlista |  |  |
| RozliczeniaMa | `SubTable<Soneta.Ksiega.RozliczenieKS>` | podlista |  |  |
| RozliczeniaWinien | `SubTable<Soneta.Ksiega.RozliczenieKS>` | podlista |  |  |
| RozliczonaKwotaOperacji | `Currency` | bazodanowe, tylko-odczyt |  |  |
| RozliczonaKwotaZapisu | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Saldo | `Currency` | tylko-odczyt |  |  |
| Seria | `string` | tylko-odczyt |  |  |
| StanRozliczenia | `Soneta.Kasa.StanRozliczenia` (enum) | tylko-odczyt |  |  |
| Strona | `Soneta.Core.StronaKsiegowania` (enum) | bazodanowe, tylko-odczyt |  |  |
| StronaRozliczenia | `Soneta.Core.StronaKsiegowania` (enum) | tylko-odczyt |  |  |
| Typ | `Soneta.Ksiega.TypZapisu` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypDziennika | `Soneta.Ksiega.TypDziennika` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypWgKonta | `Soneta.Ksiega.TypZapisuWgKonta` (enum) | bazodanowe |  |  |
| Winien | `Currency` |  |  |  |
| WinienOperacji | `Currency` |  |  |  |
| Zaksiegowany | `bool` | tylko-odczyt |  |  |
| ZapisGlowny | `Soneta.Ksiega.ZapisKsiegowy` | bazodanowe |  |  |
| ZapisZamkniecia | `bool` | bazodanowe, tylko-odczyt | Zapis zamknięcia |  |
| ZapisyKsiegowe | `SubTable<Soneta.Ksiega.ZapisKsiegowy>` | podlista |  |  |
| ZapisyPomocnicze | `SubTable<Soneta.Ksiega.ZapisKsiegowy>` | podlista |  |  |

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
