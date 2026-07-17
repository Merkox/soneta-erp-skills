# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.LokalizacjaNierHistoria`
Nazwa tabeli: `LokalizacjeNierH`
Tytuł: Historia lokalizacji nieruchomości
Opis: Element szczegółowy lokalizacji nieruchomości (LokalizacjaNier). Przechowuje historyczne dane o lokalizacji nieruchomości, w tym podmiot płatności, okres rozliczeń podatku od nieruchomości oraz przedmioty opodatkowania obowiązujące w danym okresie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Lokalizacja` → `LokalizacjaNier`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe | Aktualność | Data aktualności |
| ChangeInfoIdent | `string` |  |  |  |
| ElementyPrzedmiotuOpodatkowania | `Soneta.Business.LpSubTable<Soneta.SrodkiTrwale.PrzedmiotOp>` |  |  |  |
| Lokalizacja | `Soneta.SrodkiTrwale.LokalizacjaNier` | bazodanowe, guided-parent |  | Lokalizacja nieruchomości |
| OkresRozliczen | `Soneta.SrodkiTrwale.OkresRozliczen` | bazodanowe, enum | Okres rozliczeń | Okres rozliczeń |
| Opis | `string` | bazodanowe |  | Opis |
| Parent | `Soneta.Business.Row` |  |  |  |
| PodmiotPlatnosci | `Soneta.CRM.Kontrahent` | bazodanowe |  | Podmiot płatności |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OkresRozliczen (`Soneta.SrodkiTrwale.OkresRozliczen`)
- `Miesieczny` = 0 — miesięczny
- `Roczny` = 1 — roczny
