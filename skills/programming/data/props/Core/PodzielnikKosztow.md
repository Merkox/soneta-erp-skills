# Pola i właściwości klasy biznesowej: `Soneta.Core.PodzielnikKosztow`
Nazwa tabeli: `PodzielKosztow`
Tytuł: Podzielniki kosztów
Opis: Element szczegółowy źródła podzielnika kosztów (IZrodloPodzielnikaKosztow). Reprezentuje konkretny podzielnik kosztów z nazwą i powiązaniem do definicji algorytmu podziału.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zrodlo` → `IZrodloPodzielnikaKosztow`
Historyczna: Tak — wersje (historia) w tabeli `HistoriaPodzielnika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Core.DefinicjaPodzielnikaKosztow` | bazodanowe |  |  |
| Historia | `HistorySubTable<Soneta.Core.HistoriaPodzielnika>` | podlista |  |  |
| Last | `Soneta.Core.HistoriaPodzielnika` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
| TypZrodla | `string` | tylko-odczyt | Typ źródła |  |
| Zrodlo | `Soneta.Core.IZrodloPodzielnikaKosztow` | bazodanowe, tylko-odczyt, guided-parent, iface-ref | Źródło podzielnika |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IZrodloPodzielnikaKosztow` | `KosztRMK`, `Pracownik`, `SrodekTrwalyBase`, `Umowa`, `UmowaZewnetrzna`, `ZestawPodzielnikowKosztow` |
