# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.LokalizacjaNierHistoria`
Nazwa tabeli: `LokalizacjeNierH`
Tytuł: Historia lokalizacji nieruchomości
Opis: Element szczegółowy lokalizacji nieruchomości (LokalizacjaNier). Przechowuje historyczne dane o lokalizacji nieruchomości, w tym podmiot płatności, okres rozliczeń podatku od nieruchomości oraz przedmioty opodatkowania obowiązujące w danym okresie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Lokalizacja` → `LokalizacjaNier`
Historia: Tak — zapis historyczny tabeli `LokalizacjaNier`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista | Aktualność | Data aktualności |
| ChangeInfoIdent | `string` | tylko-odczyt |  |  |
| ElementyPrzedmiotuOpodatkowania | `LpSubTable<Soneta.SrodkiTrwale.PrzedmiotOp>` | podlista |  |  |
| Lokalizacja | `Soneta.SrodkiTrwale.LokalizacjaNier` | bazodanowe, tylko-odczyt, guided-parent |  | Lokalizacja nieruchomości |
| OkresRozliczen | `Soneta.SrodkiTrwale.OkresRozliczen` (enum) | bazodanowe | Okres rozliczeń | Okres rozliczeń |
| Opis | `string` | bazodanowe |  | Opis |
| Parent | `Row` | tylko-odczyt |  |  |
| PodmiotPlatnosci | `Soneta.CRM.Kontrahent` | bazodanowe |  | Podmiot płatności |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OkresRozliczen (`Soneta.SrodkiTrwale.OkresRozliczen`)
- `Miesieczny` = 0 — miesięczny
- `Roczny` = 1 — roczny
