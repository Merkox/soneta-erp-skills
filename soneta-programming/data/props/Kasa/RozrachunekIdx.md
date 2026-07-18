# Pola i właściwości klasy biznesowej: `Soneta.Kasa.RozrachunekIdx`
Nazwa tabeli: `RozrachunkiIdx`
Tytuł: Rozrachunki
Opis: Indeks rozrachunków umożliwiający szybkie wyszukiwanie i filtrowanie płatności i zapłat wg różnych kryteriów. Przechowuje zagregowane informacje o stanie rozliczenia dokumentu, kwotach do rozliczenia, terminach oraz datach księgowania, wspierając analizy należności i zobowiązań.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 20
- podlisty: 0
- subrowy: 0
- razem: 22

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| DataKsiegowania | `Date` | bazodanowe |  |  |
| DataOstatniegoKsi | `Date` | bazodanowe, tylko-odczyt |  | Data ostatniego rozliczenia księgowego |
| DataPierwszego | `Date` | bazodanowe, tylko-odczyt |  |  |
| DataPierwszegoKsi | `Date` | bazodanowe, tylko-odczyt |  | Data pierwszego rozliczenia księgowego |
| DataRozliczenia | `Date` | bazodanowe, tylko-odczyt |  |  |
| DoRozliczenia | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Dokument | `Soneta.Kasa.IRozliczalny` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Ewidencja SP |  |
| Kwota | `Currency` | bazodanowe, tylko-odczyt |  |  |
| KwotaRozliczona | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Numer | `string` | bazodanowe, tylko-odczyt |  |  |
| Opis | `string` | bazodanowe, tylko-odczyt |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| PrzeterminowanoDni | `int` | tylko-odczyt |  |  |
| StanNoty | `Soneta.Kasa.PlatnoscStanNoty` (enum) | tylko-odczyt |  |  |
| SymbolKontaKsi | `string` | bazodanowe, tylko-odczyt |  | Oznaczenie konta księgowania |
| Termin | `Date` | bazodanowe, tylko-odczyt |  |  |
| TerminPlanowany | `Date` | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.Kasa.TypRozrachunku` (enum) | bazodanowe, tylko-odczyt |  |  |
| WeryfikacjaTransakcji | `Soneta.Kasa.IWeryfikacjaTransakcji` | tylko-odczyt |  |  |
| Zwrot | `bool` | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dokument | `IRozliczalny` | `Platnosc`, `Zaplata` |
| Podmiot | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PlatnoscStanNoty (`Soneta.Kasa.PlatnoscStanNoty`)
- `WymagaInicjalizacji` = 0
- `NieNaliczaj` = 1 — Nie naliczaj
- `Naliczaj` = 2
- `NieDotyczy` = 3
- `RozliczonoWTerminie` = 4
- `RozliczonoStandardowe` = 5 — Rozliczono (standardowe)
- `RozliczonoPoTerminie` = 6

### TypRozrachunku (`Soneta.Kasa.TypRozrachunku`)
- `Należność` = 10
- `Zobowiązanie` = 11
- `Wpłata` = 20
- `Wypłata` = 21
