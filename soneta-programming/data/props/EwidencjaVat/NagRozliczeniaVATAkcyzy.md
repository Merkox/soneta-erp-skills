# Pola i właściwości klasy biznesowej: `Soneta.EwidencjaVat.NagRozliczeniaVATAkcyzy`
Nazwa tabeli: `NagRozliczenVATT`
Tytuł: Nagłówki rozliczeń VAT
Opis: Element szczegółowy nagłówka ewidencji VAT (NagEwidencjiVATAkcyzy). Nagłówek rozliczenia VAT rejestrujący moment powstania obowiązku podatkowego z datą, kwotami netto/VAT/brutto oraz statusem rozliczenia. Obsługuje rozliczenia kasowe (powiązanie z rozliczeniami SP), złe długi oraz rozliczenia ręczne.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Naglowek` → `NagEwidencjiVATAkcyzy`
Selektor: pole `Typ` (`Soneta.EwidencjaVat.TypRozliczeniaVAT`) — wiele typów w jednej tabeli, podtypów: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Currency` | tylko-odczyt |  |  |
| Brutto | `Currency` | bazodanowe, tylko-odczyt |  | Wartość rozlczenia brutto |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  | Data powstania obowiązku podatkowego VAT |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe, tylko-odczyt |  |  |
| Elementy | `LpSubTable<Soneta.EwidencjaVat.ElemRozliczeniaVATAkcyzy>` | podlista |  |  |
| EwidencjaRozliczenia | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  | Ewidencja rozliczeń kasowych |
| Naglowek | `Soneta.EwidencjaVat.NagEwidencjiVATAkcyzy` | bazodanowe, tylko-odczyt, guided-parent |  | Rozliczany nagłówek ewidencji VAT |
| Netto | `Currency` | bazodanowe, tylko-odczyt |  | Wartość rozliczenia netto |
| NumerDokumentu | `string` | bazodanowe, tylko-odczyt |  |  |
| NumerEwidencji | `string` | bazodanowe |  |  |
| Platnosc | `Soneta.Kasa.Platnosc` | bazodanowe, tylko-odczyt |  | Płatność będąca źrodłem rozliczania VAT złe długi |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Reczne | `bool` | bazodanowe, tylko-odczyt |  | Określa czy rozliczenie zostało naliczone ręcznie |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` (enum) | tylko-odczyt |  |  |
| RozliczenieSP | `Soneta.Kasa.RozliczenieSP` | bazodanowe, tylko-odczyt | Rozliczenie ŚP | Rozliczenie SP będące źrodłem rozliczania VAT |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` (enum) | tylko-odczyt |  |  |
| StatusRozliczenia | `Soneta.EwidencjaVat.StatusRozliczeniaVAT` (enum) | bazodanowe, tylko-odczyt |  | Status rozliczenia VAT |
| Typ | `Soneta.EwidencjaVat.TypRozliczeniaVAT` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ rozliczenia VAT |
| TypEwidencji | `Soneta.EwidencjaVat.TypEwidencjiVAT` (enum) | bazodanowe, tylko-odczyt |  | Typ ewidencji VAT |
| TypStatus | `string` | tylko-odczyt |  |  |
| VAT | `Currency` | bazodanowe, tylko-odczyt |  | Wartość rozliczenia podatku VAT |
| VATNaliczony | `Currency` | tylko-odczyt |  |  |
| WartoscEur | `Soneta.EwidencjaVat.INettoVATBrutto` | tylko-odczyt | Wartości w Eur |  |
| WartoscKsi | `Soneta.EwidencjaVat.INettoVATBrutto` | tylko-odczyt | Wartości księgowe |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Memoriałowe` | 1 | `Soneta.EwidencjaVat.NagRozliczeniaVATMemorialowe` | Nagłówek rozliczenia VAT - memoriałowe |
| `Kasowe` | 2 | `Soneta.EwidencjaVat.NagRozliczeniaVATKasowe` | Nagłówek rozliczenia VAT - kasowe |
| `KasoweZłeDługiKorekta` | 4 | `Soneta.EwidencjaVat.NagRozliczeniaVATKasoweZleDlugiKorekta` | Nagłówek rozliczenia VAT - kasowe złe długi (korekta) |
| `KasoweZłeDługi` | 5 | `Soneta.EwidencjaVat.NagRozliczeniaVATKasoweZleDlugi` | Nagłówek rozliczenia VAT - kasowe złe długi |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Podmiot | `IPodmiot` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

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

### StatusRozliczeniaVAT (`Soneta.EwidencjaVat.StatusRozliczeniaVAT`)
- `Brak` = 0 — Brak
- `WymuszoneWarunkiem` = 1 — Wymuszone warunkiem

### TypEwidencjiVAT (`Soneta.EwidencjaVat.TypEwidencjiVAT`)
- `Brak` = 0 — Brak
- `Sprzedaż` = 1 — Należny
- `Zakup` = 2 — Naliczony
- `SprzedażAkcyza` = 3 — Sprzedaż akcyza
- `ZakupAkcyza` = 4 — Zakup akcyza

### TypRozliczeniaVAT (`Soneta.EwidencjaVat.TypRozliczeniaVAT`)
- `Brak` = 0 — Brak
- `Memoriałowe` = 1 — Memoriałowe
- `Kasowe` = 2 — Kasowe
- `Ręczne` = 3 — Ręczne
- `KasoweZłeDługiKorekta` = 4 — Kasowe złe długi korekta
- `KasoweZłeDługi` = 5 — Kasowe złe długi
