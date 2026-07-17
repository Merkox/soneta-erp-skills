# Pola i właściwości klasy biznesowej: `Soneta.EwidencjaVat.NagEwidencjiVATAkcyzy`
Nazwa tabeli: `NagEwidencjiVATT`
Tytuł: Nagłóweki ewidencji VAT
Opis: Element szczegółowy dokumentu ewidencji (DokEwidencji). Nagłówek ewidencji VAT/akcyzy grupujący elementy dotyczące jednego dokumentu podatkowego. Przechowuje dane podmiotu, kwoty netto/VAT/brutto, parametry rozliczenia VAT, moment powstania obowiązku podatkowego oraz obsługuje procedury OSS/IOSS i oznaczenia KSeF.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Ewidencja` → `DokEwidencji`

- pola bazodanowe: 29
- pola kalkulowane (z klas biznesowych): 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Soneta.Types.Currency` |  |  |  |
| Brutto | `Soneta.Types.Currency` | bazodanowe |  | Wartość brutto |
| Bufor | `bool` |  |  |  |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` |  |  |  |
| DataDokumentu | `Soneta.Types.Date` |  |  |  |
| DataPowstania | `Soneta.Types.Date` | bazodanowe |  | Data powstania obow. pod. VAT |
| DataRozliczenia | `Soneta.Types.Date` |  |  |  |
| DataRozliczeniaOSS | `Soneta.Types.Date` | bazodanowe | Data rozliczenia OSS/IOSS | Data rozliczenia w VAT |
| DataZaewidencjonowania | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DefinicjaPowstaniaObowiazku | `Soneta.EwidencjaVat.DefinicjaPowstaniaObowiazkuVAT` | bazodanowe |  | Definicja momentu powstania obowiązku podatkowego VAT |
| DoRozliczenia | `bool` | bazodanowe |  | Określa, czy nagłówek ewidencji został już rozliczony. |
| Elementy | `Soneta.Business.LpSubTable<Soneta.EwidencjaVat.ElemEwidencjiVATAkcyzy>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe, guided-parent |  | Dokument ewidencji nagłówka |
| Korekta | `bool` |  |  |  |
| KorektaDo | `Soneta.Core.DokEwidencji` |  |  |  |
| Koszty | `Soneta.EwidencjaVat.NagEwidencjiVATAkcyzy.KosztyCalculator` |  |  |  |
| Kraj | `Soneta.Core.KrajTbl` | bazodanowe | Kraj VAT |  |
| KrajWydania | `Soneta.Core.KrajTbl` | bazodanowe | Kraj wydania | Kraj wydania towaru w procedurze OSS/IOSS |
| NaglowkiRozliczeniaVAT | `Soneta.Business.SubTable<Soneta.EwidencjaVat.NagRozliczeniaVATAkcyzy>` |  |  |  |
| Netto | `Soneta.Types.Currency` | bazodanowe |  | Wartość netto |
| NrDokumentuK | `string` | bazodanowe |  | Nr korygowanego dokumentu |
| Numer | `string` | bazodanowe |  |  |
| NumerDokumentu | `string` | bazodanowe |  | Numer dokumentu |
| OkresRozliczenia | `string` |  |  |  |
| OpisVATUslug | `string` |  |  |  |
| OznaczenieKSeF | `Soneta.Core.OznaczenieKSeF_JPK` | bazodanowe, enum | Oznaczenie KSeF (JPK) | Oznaczenie KSeF (JPK) |
| PodatnikVAT | `bool` | bazodanowe | Podatnik VAT | Czy podmiot jest podatnikiem VAT |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  |  |
| PowstanieObowiazku | `Soneta.EwidencjaVat.PowstanieObowiazkuVAT` | bazodanowe |  |  |
| PowstanieObowiazku.IloscDniWarunku | `int` | bazodanowe |  |  |
| PowstanieObowiazku.Kasowe | `Soneta.EwidencjaVat.RozliczenieKasoweVAT` | bazodanowe, enum |  |  |
| PowstanieObowiazku.Memorialowe | `Soneta.EwidencjaVat.RozliczenieMemorialoweVAT` | bazodanowe, enum |  |  |
| PowstanieObowiazku.Warunek | `Soneta.EwidencjaVat.WarunekRozliczeniaVAT` | bazodanowe, enum |  |  |
| PowstanieObowiazku.WarunekPrawoOdliczenia | `bool` | bazodanowe | Prawo odliczenia | Prawo odliczenia VAT, jeżeli rozliczony przez wypełnienie warunku |
| PowstanieObowiazku.Zasada | `Soneta.EwidencjaVat.ZasadaRozliczaniaVAT` | bazodanowe, enum |  |  |
| ProceduraOSS | `Soneta.EwidencjaVat.ProceduraOSS` | bazodanowe, enum | Procedura | Typ zastosowanej procedury OSS/IOSS |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` | bazodanowe, enum |  |  |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` | bazodanowe, enum |  |  |
| TerminPlatnosci | `Soneta.Types.Date` |  |  |  |
| Typ | `Soneta.EwidencjaVat.TypEwidencjiVAT` | bazodanowe, enum |  |  |
| VAT | `Soneta.Types.Currency` | bazodanowe |  | Wartość podatku VAT |
| Waluta | `Soneta.Waluty.Waluta` |  | Waluta |  |
| WartoscEur | `Soneta.EwidencjaVat.INettoVATBrutto` |  | Wartości w Eur |  |
| WartoscKsi | `Soneta.EwidencjaVat.INettoVATBrutto` |  | Wartości księgowe |  |

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
