# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.LokalizacjaNier`
Nazwa tabeli: `LokalizacjeNier`
Tytuł: Lokalizacja nieruchomości
Opis: Słownik lokalizacji nieruchomości na potrzeby rozliczania podatku od nieruchomości. Przechowuje nazwę lokalizacji oraz powiązane dane historyczne o podmiotach płatności, okresach rozliczeniowych i przedmiotach opodatkowania.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `LokalizacjaNierHistoria`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 1
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Blokada |
| Historia | `HistorySubTable<Soneta.SrodkiTrwale.LokalizacjaNierHistoria>` | podlista |  |  |
| Last | `Soneta.SrodkiTrwale.LokalizacjaNierHistoria` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa lokalizacji nieruchomości |
| OkresRozliczen | `Soneta.SrodkiTrwale.OkresRozliczen` (enum) | tylko-odczyt |  | Okres rozliczeń |
| Opis | `string` | tylko-odczyt |  | Opis |
| PodmiotPlatnosci | `Soneta.CRM.Kontrahent` | tylko-odczyt |  | Podmiot płatności |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OkresRozliczen (`Soneta.SrodkiTrwale.OkresRozliczen`)
- `Miesieczny` = 0 — miesięczny
- `Roczny` = 1 — roczny
