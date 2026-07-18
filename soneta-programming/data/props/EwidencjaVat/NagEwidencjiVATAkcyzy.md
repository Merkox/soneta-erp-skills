# Pola i właściwości klasy biznesowej: `Soneta.EwidencjaVat.NagEwidencjiVATAkcyzy`
Nazwa tabeli: `NagEwidencjiVATT`
Tytuł: Nagłóweki ewidencji VAT
Opis: Element szczegółowy dokumentu ewidencji (DokEwidencji). Nagłówek ewidencji VAT/akcyzy grupujący elementy dotyczące jednego dokumentu podatkowego. Przechowuje dane podmiotu, kwoty netto/VAT/brutto, parametry rozliczenia VAT, moment powstania obowiązku podatkowego oraz obsługuje procedury OSS/IOSS i oznaczenia KSeF.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ewidencja` → `DokEwidencji`

- pola bazodanowe (zapisywalne): 16
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 26
- podlisty: 2
- subrowy: 1
- razem: 45

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Currency` | tylko-odczyt |  |  |
| Brutto | `Currency` | bazodanowe, tylko-odczyt |  | Wartość brutto |
| Bufor | `bool` | tylko-odczyt |  |  |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` | tylko-odczyt |  |  |
| DataDokumentu | `Date` | tylko-odczyt |  |  |
| DataPowstania | `Date` | bazodanowe |  | Data powstania obow. pod. VAT |
| DataRozliczenia | `Date` | tylko-odczyt |  |  |
| DataRozliczeniaOSS | `Date` | bazodanowe | Data rozliczenia OSS/IOSS | Data rozliczenia w VAT |
| DataZaewidencjonowania | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe, tylko-odczyt |  |  |
| DefinicjaPowstaniaObowiazku | `Soneta.EwidencjaVat.DefinicjaPowstaniaObowiazkuVAT` | bazodanowe |  | Definicja momentu powstania obowiązku podatkowego VAT |
| DoRozliczenia | `bool` | bazodanowe, tylko-odczyt |  | Określa, czy nagłówek ewidencji został już rozliczony. |
| Elementy | `LpSubTable<Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt, guided-parent |  | Dokument ewidencji nagłówka |
| Korekta | `bool` | tylko-odczyt |  |  |
| KorektaDo | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Koszty | `Soneta.EwidencjaVat.NagEwidencjiVATAkcyzy.KosztyCalculator` | tylko-odczyt |  |  |
| Kraj | `Soneta.Core.KrajTbl` | bazodanowe, tylko-odczyt | Kraj VAT |  |
| KrajWydania | `Soneta.Core.KrajTbl` | bazodanowe | Kraj wydania | Kraj wydania towaru w procedurze OSS/IOSS |
| NaglowkiRozliczeniaVAT | `SubTable<Soneta.EwidencjaVat.NagRozliczeniaVATAkcyzy>` | podlista |  |  |
| Netto | `Currency` | bazodanowe, tylko-odczyt |  | Wartość netto |
| NrDokumentuK | `string` | bazodanowe |  | Nr korygowanego dokumentu |
| Numer | `string` | bazodanowe, tylko-odczyt |  |  |
| NumerDokumentu | `string` | bazodanowe, tylko-odczyt |  | Numer dokumentu |
| OkresRozliczenia | `string` | tylko-odczyt |  |  |
| OpisVATUslug | `string` | tylko-odczyt |  |  |
| OznaczenieKSeF | `Soneta.Core.OznaczenieKSeF_JPK` (enum) | bazodanowe | Oznaczenie KSeF (JPK) | Oznaczenie KSeF (JPK) |
| PodatnikVAT | `bool` | bazodanowe | Podatnik VAT | Czy podmiot jest podatnikiem VAT |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| PowstanieObowiazku | `Soneta.EwidencjaVat.PowstanieObowiazkuVAT` (subrow) | bazodanowe |  |  |
| PowstanieObowiazku.IloscDniWarunku | `int` | bazodanowe |  |  |
| PowstanieObowiazku.Kasowe | `Soneta.EwidencjaVat.RozliczenieKasoweVAT` (enum) | bazodanowe |  |  |
| PowstanieObowiazku.Memorialowe | `Soneta.EwidencjaVat.RozliczenieMemorialoweVAT` (enum) | bazodanowe |  |  |
| PowstanieObowiazku.Warunek | `Soneta.EwidencjaVat.WarunekRozliczeniaVAT` (enum) | bazodanowe |  |  |
| PowstanieObowiazku.WarunekPrawoOdliczenia | `bool` | bazodanowe | Prawo odliczenia | Prawo odliczenia VAT, jeżeli rozliczony przez wypełnienie warunku |
| PowstanieObowiazku.Zasada | `Soneta.EwidencjaVat.ZasadaRozliczaniaVAT` (enum) | bazodanowe |  |  |
| ProceduraOSS | `Soneta.EwidencjaVat.ProceduraOSS` (enum) | bazodanowe, tylko-odczyt | Procedura | Typ zastosowanej procedury OSS/IOSS |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` (enum) | bazodanowe |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` (enum) | bazodanowe |  |  |
| TerminPlatnosci | `Date` | tylko-odczyt |  |  |
| Typ | `Soneta.EwidencjaVat.TypEwidencjiVAT` (enum) | bazodanowe, tylko-odczyt |  |  |
| VAT | `Currency` | bazodanowe, tylko-odczyt |  | Wartość podatku VAT |
| Waluta | `Soneta.Waluty.Waluta` | tylko-odczyt | Waluta |  |
| WartoscEur | `Soneta.EwidencjaVat.INettoVATBrutto` | tylko-odczyt | Wartości w Eur |  |
| WartoscKsi | `Soneta.EwidencjaVat.INettoVATBrutto` | tylko-odczyt | Wartości księgowe |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OznaczenieKSeF_JPK (`Soneta.Core.OznaczenieKSeF_JPK`)
- `None` = 0 — Nie dotyczy
- `BFK` = 1
- `DI` = 2
- `OFF` = 3
- `NumerKSeF` = 4 — Numer KSeF

### RodzajPodmiotu (`Soneta.Core.RodzajPodmiotu`)
- `Krajowy` = 0
- `Eksportowy` = 1
- `EksportowyPodróżny` = 2
- `Unijny` = 3
- `UnijnyTrójstronny` = 4
- `BezVAT` = 5 — Bez VAT

### StatusPodmiotu (`Soneta.Core.StatusPodmiotu`)
- `PodmiotGospodarczy` = 0
- `Finalny` = 1

### ProceduraOSS (`Soneta.EwidencjaVat.ProceduraOSS`)
- `Brak` = 1
- `ProceduraOSS` = 2 — OSS
- `ProceduraIOSS` = 3 — IOSS

### RozliczenieKasoweVAT (`Soneta.EwidencjaVat.RozliczenieKasoweVAT`)
- `CząstkowoPrzyRozliczeniach` = 0 — Cząstkowo Przy Rozliczeniach
- `PoCałkowitymRozliczeniu` = 1 — Po Całkowitym Rozliczeniu

### RozliczenieMemorialoweVAT (`Soneta.EwidencjaVat.RozliczenieMemorialoweVAT`)
- `WgDatyZaewidencjonowania` = 0 — Wg Daty Zaewidencjonowania
- `WgDatyWplywu` = 1 — Wg Daty Wpływu
- `WgDatyWystawienia` = 2 — Wg Daty Wystawienia
- `WgDatyOperacji` = 3 — Wg Daty Operacji
- `WgTerminuPłatności` = 4 — Wg Terminu Płatności
- `WgDowolnejDaty` = 5 — Wg Dowolnej Daty

### TypEwidencjiVAT (`Soneta.EwidencjaVat.TypEwidencjiVAT`)
- `Brak` = 0 — Brak
- `Sprzedaż` = 1 — Należny
- `Zakup` = 2 — Naliczony
- `SprzedażAkcyza` = 3 — Sprzedaż akcyza
- `ZakupAkcyza` = 4 — Zakup akcyza

### WarunekRozliczeniaVAT (`Soneta.EwidencjaVat.WarunekRozliczeniaVAT`)
- `Brak` = 0 — Brak
- `DniOdDatyWplywu` = 1 — Dni Od Daty Wpływu
- `DniOdDatyWystawienia` = 2 — Dni Od Daty Wystawienia
- `DniOdDatyOperacji` = 3 — Dni Od Daty Operacji
- `DniOdDatyZaewidencjonowania` = 4 — Dni Od Daty Zaewidencjonowania
- `TerminPłatności` = 5 — Termin Płatności
- `DowolnaData` = 6 — Dowolna Data
- `DniaNastępnegoMiesiącaWgDatyOperacji` = 7 — Dnia Następnego Miesiąca Wg Daty Operacji

### ZasadaRozliczaniaVAT (`Soneta.EwidencjaVat.ZasadaRozliczaniaVAT`)
- `Memoriałowa` = 0 — Memoriałowa
- `Kasowa` = 1 — Kasowa
