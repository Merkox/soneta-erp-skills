# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.SrodekTrwalyLeasing`
Nazwa tabeli: `SrodkiTrwaleLeas`
Tytuł: Leasing
Opis: Element szczegółowy środka trwałego (SrodekTrwalyBase). Przechowuje historyczne warunki umowy leasingowej powiązanej ze środkiem trwałym, w tym wartość umowy, opłatę wstępną, wartość wykupu, harmonogram rat, limit podatkowy pojazdu oraz zasady odliczeń VAT.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Srodek` → `SrodekTrwalyBase`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Aktywa | `Soneta.Types.Currency` |  |  |  |
| Amortyzacja | `Soneta.Types.Currency` |  |  |  |
| Kapital | `Soneta.Types.Currency` |  |  |  |
| KapitalDys | `Soneta.Types.Currency` |  |  |  |
| KapitalPLN | `Soneta.Types.Currency` |  |  |  |
| KosztyDodatkowe | `Soneta.Types.Currency` | bazodanowe |  | Koszty dodatkowe |
| KosztyDodatkowePLN | `Soneta.Types.Currency` |  |  |  |
| KosztyUbezpieczenia | `Soneta.Types.Currency` | bazodanowe |  | Koszty ubezpieczenia |
| KosztyUbezpieczeniaPLN | `Soneta.Types.Currency` |  |  |  |
| LimitPodatkowyPoj | `Soneta.Types.Currency` | bazodanowe | Limit podatkowy pojazdu |  |
| OdliczeniaVAT | `Soneta.SrodkiTrwale.LeasingOdliczeniaVAT` | bazodanowe, enum | Odliczenia VAT |  |
| OdliczeniaVATStr | `string` |  |  |  |
| Odsetki | `Soneta.Types.Currency` |  |  |  |
| OdsetkiDys | `Soneta.Types.Currency` |  |  |  |
| OdsetkiPLN | `Soneta.Types.Currency` |  |  |  |
| OplataWstepnaKwota | `Soneta.Types.Currency` | bazodanowe |  | Opłata wstępna - kwota |
| OplataWstepnaPLN | `Soneta.Types.Currency` |  |  |  |
| OplataWstepnaProcent | `Soneta.Types.Percent` | bazodanowe |  | Opłata wstępna - procent |
| PoprzednieRaty | `System.Collections.Generic.List<Soneta.SrodkiTrwale.RataLeasingST>` |  |  |  |
| PozostaleKoszty | `Soneta.Types.Currency` |  |  |  |
| PozycjeUL | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.RataLeasingST>` |  |  |  |
| ProporcjaWartosci | `Soneta.Types.Percent` | bazodanowe |  | Proporcja wartości |
| ProporcjaWykupu | `Soneta.Types.Percent` | bazodanowe |  | Proporcja wykupu |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe, guided-parent |  |  |
| StawkaAmortyzacji | `Soneta.Types.Percent` |  |  |  |
| SumaRat | `Soneta.Types.Currency` | bazodanowe |  | Suma rat netto |
| SumaRatPLN | `Soneta.Types.Currency` |  |  |  |
| TypyOplat | `Soneta.Business.LpSubTable<Soneta.SrodkiTrwale.TypOplatyLeasing>` |  |  |  |
| UmowaLeasingu | `Soneta.SrodkiTrwale.DokumentUL` | bazodanowe | Umowa leasingu |  |
| WartoscNettoPoj | `Soneta.Types.Currency` | bazodanowe | Wartość netto pojazdu |  |
| WartoscUmowy | `Soneta.Types.Currency` | bazodanowe |  | Wartość umowy |
| WartoscUmowyPLN | `Soneta.Types.Currency` |  |  |  |
| WartoscWykupuKwota | `Soneta.Types.Currency` | bazodanowe |  | Wartość wykupu- kwota |
| WartoscWykupuPLN | `Soneta.Types.Currency` |  |  |  |
| WartoscWykupuProcent | `Soneta.Types.Percent` | bazodanowe |  | Wartość wykupu - procent |
| WycenaAktywa | `Soneta.Types.Currency` |  |  |  |
| WycenaZobowiazania | `Soneta.Types.Currency` |  |  |  |
| WysokoscRaty | `Soneta.Types.Currency` |  |  |  |
| ZatwierdzonyHarmonogram | `bool` | bazodanowe |  | Czy zatwierdzony harmonogram |
| ZdyskontowanaOplata | `Soneta.Types.Currency` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### LeasingOdliczeniaVAT (`Soneta.SrodkiTrwale.LeasingOdliczeniaVAT`)
- `Nie` = 0 — Nie
- `P50` = 10 — 50%
- `P100` = 20 — 100%
