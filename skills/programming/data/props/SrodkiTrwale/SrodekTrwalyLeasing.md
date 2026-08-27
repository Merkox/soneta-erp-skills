# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.SrodekTrwalyLeasing`
Nazwa tabeli: `SrodkiTrwaleLeas`
Tytuł: Leasing
Opis: Element szczegółowy środka trwałego (SrodekTrwalyBase). Przechowuje historyczne warunki umowy leasingowej powiązanej ze środkiem trwałym, w tym wartość umowy, opłatę wstępną, wartość wykupu, harmonogram rat, limit podatkowy pojazdu oraz zasady odliczeń VAT.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Srodek` → `SrodekTrwalyBase`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| Aktywa | `Currency` | tylko-odczyt |  |  |
| Amortyzacja | `Currency` | tylko-odczyt |  |  |
| Kapital | `Currency` | tylko-odczyt |  |  |
| KapitalDys | `Currency` | tylko-odczyt |  |  |
| KapitalPLN | `Currency` | tylko-odczyt |  |  |
| KosztyDodatkowe | `Currency` | bazodanowe |  | Koszty dodatkowe |
| KosztyDodatkowePLN | `Currency` | tylko-odczyt |  |  |
| KosztyUbezpieczenia | `Currency` | bazodanowe |  | Koszty ubezpieczenia |
| KosztyUbezpieczeniaPLN | `Currency` | tylko-odczyt |  |  |
| LimitPodatkowyPoj | `Currency` | bazodanowe | Limit podatkowy pojazdu |  |
| OdliczeniaVAT | `Soneta.SrodkiTrwale.LeasingOdliczeniaVAT` (enum) | bazodanowe | Odliczenia VAT |  |
| OdliczeniaVATStr | `string` | tylko-odczyt |  |  |
| Odsetki | `Currency` | tylko-odczyt |  |  |
| OdsetkiDys | `Currency` | tylko-odczyt |  |  |
| OdsetkiPLN | `Currency` | tylko-odczyt |  |  |
| OplataWstepnaKwota | `Currency` | bazodanowe |  | Opłata wstępna - kwota |
| OplataWstepnaPLN | `Currency` | tylko-odczyt |  |  |
| OplataWstepnaProcent | `Percent` | bazodanowe |  | Opłata wstępna - procent |
| PoprzednieRaty | `System.Collections.Generic.List<Soneta.SrodkiTrwale.RataLeasingST>` | podlista |  |  |
| PozostaleKoszty | `Currency` | tylko-odczyt |  |  |
| PozycjeUL | `SubTable<Soneta.SrodkiTrwale.RataLeasingST>` | podlista |  |  |
| ProporcjaWartosci | `Percent` | bazodanowe |  | Proporcja wartości |
| ProporcjaWykupu | `Percent` | bazodanowe |  | Proporcja wykupu |
| Srodek | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| StawkaAmortyzacji | `Percent` | tylko-odczyt |  |  |
| SumaRat | `Currency` | bazodanowe |  | Suma rat netto |
| SumaRatPLN | `Currency` | tylko-odczyt |  |  |
| TypyOplat | `LpSubTable<Soneta.SrodkiTrwale.TypOplatyLeasing>` | podlista |  |  |
| UmowaLeasingu | `Soneta.SrodkiTrwale.DokumentUL` | bazodanowe | Umowa leasingu |  |
| WartoscNettoPoj | `Currency` | bazodanowe | Wartość netto pojazdu |  |
| WartoscUmowy | `Currency` | bazodanowe |  | Wartość umowy |
| WartoscUmowyPLN | `Currency` | tylko-odczyt |  |  |
| WartoscWykupuKwota | `Currency` | bazodanowe |  | Wartość wykupu- kwota |
| WartoscWykupuPLN | `Currency` | tylko-odczyt |  |  |
| WartoscWykupuProcent | `Percent` | bazodanowe |  | Wartość wykupu - procent |
| WycenaAktywa | `Currency` | tylko-odczyt |  |  |
| WycenaZobowiazania | `Currency` | tylko-odczyt |  |  |
| WysokoscRaty | `Currency` | tylko-odczyt |  |  |
| ZatwierdzonyHarmonogram | `bool` | bazodanowe |  | Czy zatwierdzony harmonogram |
| ZdyskontowanaOplata | `Currency` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### LeasingOdliczeniaVAT (`Soneta.SrodkiTrwale.LeasingOdliczeniaVAT`)
- `Nie` = 0 — Nie
- `P50` = 10 — 50%
- `P100` = 20 — 100%
