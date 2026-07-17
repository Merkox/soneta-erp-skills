# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.LokalizacjaNier`
Nazwa tabeli: `LokalizacjeNier`
Tytuł: Lokalizacja nieruchomości
Opis: Słownik lokalizacji nieruchomości na potrzeby rozliczania podatku od nieruchomości. Przechowuje nazwę lokalizacji oraz powiązane dane historyczne o podmiotach płatności, okresach rozliczeniowych i przedmiotach opodatkowania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Blokada |
| Historia | `Soneta.Business.HistorySubTable<Soneta.SrodkiTrwale.LokalizacjaNierHistoria>` |  |  |  |
| Last | `Soneta.SrodkiTrwale.LokalizacjaNierHistoria` |  |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa lokalizacji nieruchomości |
| OkresRozliczen | `Soneta.SrodkiTrwale.OkresRozliczen` | enum |  | Okres rozliczeń |
| Opis | `string` |  |  | Opis |
| PodmiotPlatnosci | `Soneta.CRM.Kontrahent` |  |  | Podmiot płatności |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OkresRozliczen (`Soneta.SrodkiTrwale.OkresRozliczen`)
- `Miesieczny` = 0 — miesięczny
- `Roczny` = 1 — roczny
