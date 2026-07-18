# Pola i właściwości klasy biznesowej: `Soneta.Core.ElementPodzielnika`
Nazwa tabeli: `ElemPodzielnikow`
Tytuł: Elementy podzielników
Opis: Pozycja podzielnika kosztów przypisana do historycznej wersji podzielnika. Określa element podziałowy (np. centrum kosztów) i jego współczynnik udziału w podziale kosztów.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Historia` → `HistoriaPodzielnika`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElementPodzialowy | `Soneta.Core.IElementSlownika` | bazodanowe, iface-ref |  |  |
| Historia | `Soneta.Core.HistoriaPodzielnika` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Procent | `Percent` | tylko-odczyt |  |  |
| Wspolczynnik | `double` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| ElementPodzialowy | `IElementSlownika` | `Bank`, `CentrumKosztow`, `DokumentHandlowy`, `ElemSlownika`, `EwidencjaSP`, `GrupaSzkol`, `InstytucjaFinansowaPPK`, `Kontrahent`, `KosztRMK`, `Lead`, `Magazyn`, `OddzialFirmy`, `Pojazd`, `Pracownik`, `ProWydzial`, `ProZasob`, `ProZlecenie`, `Projekt`, `RodzajSzkol`, `RodzajZrodla`, `SrodekTrwalyBase`, `Towar`, `Transakcja`, `UrzadCelny`, `UrzadSkarbowy`, `Urzadzenie`, `Wydzial`, `ZUS`, `Zadanie`, `ZrodloFinansowania` |
