# Pola i właściwości klasy biznesowej: `Soneta.EwidencjaVat.NagRozliczeniaVATAkcyzy`
Nazwa tabeli: `NagRozliczenVATT`
Tytuł: Nagłówki rozliczeń VAT
Opis: Element szczegółowy nagłówka ewidencji VAT (NagEwidencjiVATAkcyzy). Nagłówek rozliczenia VAT rejestrujący moment powstania obowiązku podatkowego z datą, kwotami netto/VAT/brutto oraz statusem rozliczenia. Obsługuje rozliczenia kasowe (powiązanie z rozliczeniami SP), złe długi oraz rozliczenia ręczne.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Naglowek` → `NagEwidencjiVATAkcyzy`

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Akcyza | `Soneta.Types.Currency` |  |  |  |
| Brutto | `Soneta.Types.Currency` | bazodanowe |  | Wartość rozlczenia brutto |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data powstania obowiązku podatkowego VAT |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.LpSubTable<Soneta.EwidencjaVat.ElemRozliczeniaVATAkcyzy>` |  |  |  |
| EwidencjaRozliczenia | `Soneta.Core.DokEwidencji` | bazodanowe |  | Ewidencja rozliczeń kasowych |
| Naglowek | `Soneta.EwidencjaVat.NagEwidencjiVATAkcyzy` | bazodanowe, guided-parent |  | Rozliczany nagłówek ewidencji VAT |
| Netto | `Soneta.Types.Currency` | bazodanowe |  | Wartość rozliczenia netto |
| NumerDokumentu | `string` | bazodanowe |  |  |
| NumerEwidencji | `string` | bazodanowe |  |  |
| Platnosc | `Soneta.Kasa.Platnosc` | bazodanowe |  | Płatność będąca źrodłem rozliczania VAT złe długi |
| Podmiot | `Soneta.Core.IPodmiot` | bazodanowe, iface-ref |  |  |
| Reczne | `bool` | bazodanowe |  | Określa czy rozliczenie zostało naliczone ręcznie |
| RodzajPodmiotu | `Soneta.Core.RodzajPodmiotu` | enum |  |  |
| RozliczenieSP | `Soneta.Kasa.RozliczenieSP` | bazodanowe | Rozliczenie ŚP | Rozliczenie SP będące źrodłem rozliczania VAT |
| StatusPodmiotu | `Soneta.Core.StatusPodmiotu` | enum |  |  |
| StatusRozliczenia | `Soneta.EwidencjaVat.StatusRozliczeniaVAT` | bazodanowe, enum |  | Status rozliczenia VAT |
| Typ | `Soneta.EwidencjaVat.TypRozliczeniaVAT` | bazodanowe, enum |  | Typ rozliczenia VAT |
| TypEwidencji | `Soneta.EwidencjaVat.TypEwidencjiVAT` | bazodanowe, enum |  | Typ ewidencji VAT |
| TypStatus | `string` |  |  |  |
| VAT | `Soneta.Types.Currency` | bazodanowe |  | Wartość rozliczenia podatku VAT |
| VATNaliczony | `Soneta.Types.Currency` |  |  |  |
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
