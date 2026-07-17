# Pola i właściwości klasy biznesowej: `Soneta.Core.PodzielnikKosztow`
Nazwa tabeli: `PodzielKosztow`
Tytuł: Podzielniki kosztów
Opis: Element szczegółowy źródła podzielnika kosztów (IZrodloPodzielnikaKosztow). Reprezentuje konkretny podzielnik kosztów z nazwą i powiązaniem do definicji algorytmu podziału.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zrodlo` → `IZrodloPodzielnikaKosztow`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Core.DefinicjaPodzielnikaKosztow` | bazodanowe |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Core.HistoriaPodzielnika>` |  |  |  |
| Last | `Soneta.Core.HistoriaPodzielnika` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
| TypZrodla | `string` |  | Typ źródła |  |
| Zrodlo | `Soneta.Core.IZrodloPodzielnikaKosztow` | bazodanowe, guided-parent, iface-ref | Źródło podzielnika |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IZrodloPodzielnikaKosztow` | `KosztRMK`, `Pracownik`, `SrodekTrwalyBase`, `Umowa`, `UmowaZewnetrzna`, `ZestawPodzielnikowKosztow` |
