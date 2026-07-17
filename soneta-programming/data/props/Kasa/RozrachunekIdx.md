# Pola i właściwości klasy biznesowej: `Soneta.Kasa.RozrachunekIdx`
Nazwa tabeli: `RozrachunkiIdx`
Tytuł: Rozrachunki
Opis: Indeks rozrachunków umożliwiający szybkie wyszukiwanie i filtrowanie płatności i zapłat wg różnych kryteriów. Przechowuje zagregowane informacje o stanie rozliczenia dokumentu, kwotach do rozliczenia, terminach oraz datach księgowania, wspierając analizy należności i zobowiązań.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 19
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataKsiegowania | `Soneta.Types.Date` | bazodanowe |  |  |
| DataOstatniegoKsi | `Soneta.Types.Date` | bazodanowe |  | Data ostatniego rozliczenia księgowego |
| DataPierwszego | `Soneta.Types.Date` | bazodanowe |  |  |
| DataPierwszegoKsi | `Soneta.Types.Date` | bazodanowe |  | Data pierwszego rozliczenia księgowego |
| DataRozliczenia | `Soneta.Types.Date` | bazodanowe |  |  |
| DoRozliczenia | `Soneta.Types.Currency` | bazodanowe |  |  |
| Dokument | `Soneta.Kasa.IRozliczalny` | bazodanowe, iface-ref |  |  |
| EwidencjaSP | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Ewidencja SP |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| KwotaRozliczona | `Soneta.Types.Currency` | bazodanowe |  |  |
| Numer | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Podmiot | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  |  |
| PrzeterminowanoDni | `int` |  |  |  |
| StanNoty | `Soneta.Kasa.PlatnoscStanNoty` | enum |  |  |
| SymbolKontaKsi | `string` | bazodanowe |  | Oznaczenie konta księgowania |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| TerminPlanowany | `Soneta.Types.Date` | bazodanowe |  |  |
| Typ | `Soneta.Kasa.TypRozrachunku` | bazodanowe, enum |  |  |
| WeryfikacjaTransakcji | `Soneta.Kasa.IWeryfikacjaTransakcji` |  |  |  |
| Zwrot | `bool` | bazodanowe |  |  |

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
