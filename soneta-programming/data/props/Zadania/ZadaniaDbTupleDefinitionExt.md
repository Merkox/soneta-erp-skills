# Pola i właściwości klasy biznesowej: `Soneta.Zadania.ZadaniaDbTupleDefinitionExt`
Nazwa tabeli: `ZadaniaTDefExts`
Tytuł: Rozszerzenia definicji krotek dla tabeli Zadania
Opis: Element szczegółowy definicji krotki (DbTupleDefinition). Rozszerza mechanizm krotek bazy danych o dodatkowe parametry specyficzne dla zadań CRM, w tym powiązanie z procesami workflow.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DbTupleDefinition` → `DbTupleDefinition`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe, guided-parent |  |  |
| DefinicjaProcesu | `Soneta.Business.IWFDefinition` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| DefinicjaProcesu | `IWFDefinition` | `WFDefinition` |
