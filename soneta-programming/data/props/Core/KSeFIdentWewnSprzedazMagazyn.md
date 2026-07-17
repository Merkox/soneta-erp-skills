# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewnSprzedazMagazyn`
Nazwa tabeli: `KSeFIdentWewnSpMg`
Tytuł: Przypisane magazyny dla sprzedaży dla identyfikatora wewnętrznego KSeF
Opis: Tabela przechowuje przypisania magazynów do wewnętrznych identyfikatorów KSeF dla sprzedaży. ŝączy identyfikator wewnętrzny KSeF z magazynem, z którego dokumenty sprzedaży są przekazywane do Krajowego Systemu e-Faktur.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IdentWewnKSeF | `Soneta.Core.KSeFIdentWewn` | bazodanowe |  |  |
| Magazyn | `Soneta.Core.IElementSlownika` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Magazyn | `IElementSlownika` | `Bank`, `CentrumKosztow`, `DokumentHandlowy`, `ElemSlownika`, `EwidencjaSP`, `GrupaSzkol`, `InstytucjaFinansowaPPK`, `Kontrahent`, `KosztRMK`, `Lead`, `Magazyn`, `OddzialFirmy`, `Pojazd`, `Pracownik`, `ProWydzial`, `ProZasob`, `ProZlecenie`, `Projekt`, `RodzajSzkol`, `RodzajZrodla`, `SrodekTrwalyBase`, `Towar`, `Transakcja`, `UrzadCelny`, `UrzadSkarbowy`, `Urzadzenie`, `Wydzial`, `ZUS`, `Zadanie`, `ZrodloFinansowania` |
