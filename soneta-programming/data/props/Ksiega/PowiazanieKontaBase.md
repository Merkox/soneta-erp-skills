# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PowiazanieKontaBase`
Nazwa tabeli: `PowiazaniaKont`
Tytuł: Powiązania kont
Opis: Element szczegółowy konta księgowego (KontoBase). Reprezentuje powiązanie między kontem a elementem słownika poprzez konto słownikowe, umożliwiając automatyczne tworzenie kont analitycznych na podstawie słowników (np. kontrahentów, pracowników).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Konto` → `KontoBase`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Element | `Soneta.Core.IElementSlownika` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Konto | `Soneta.Ksiega.KontoBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| KontoSlownikowe | `Soneta.Ksiega.KontoBase` | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.Ksiega.TypPowiazania` (enum) | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Element | `IElementSlownika` | `Bank`, `CentrumKosztow`, `DokumentHandlowy`, `ElemSlownika`, `EwidencjaSP`, `GrupaSzkol`, `InstytucjaFinansowaPPK`, `Kontrahent`, `KosztRMK`, `Lead`, `Magazyn`, `OddzialFirmy`, `Pojazd`, `Pracownik`, `ProWydzial`, `ProZasob`, `ProZlecenie`, `Projekt`, `RodzajSzkol`, `RodzajZrodla`, `SrodekTrwalyBase`, `Towar`, `Transakcja`, `UrzadCelny`, `UrzadSkarbowy`, `Urzadzenie`, `Wydzial`, `ZUS`, `Zadanie`, `ZrodloFinansowania` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypPowiazania (`Soneta.Ksiega.TypPowiazania`)
- `Brak` = 0
- `Slownikowe` = 1 — Słownikowe
- `Systemowe` = 2
