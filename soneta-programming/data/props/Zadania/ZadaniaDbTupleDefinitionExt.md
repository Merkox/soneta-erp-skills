# Pola i właściwości klasy biznesowej: `Soneta.Zadania.ZadaniaDbTupleDefinitionExt`
Nazwa tabeli: `ZadaniaTDefExts`
Tytuł: Rozszerzenia definicji krotek dla tabeli Zadania
Opis: Element szczegółowy definicji krotki (DbTupleDefinition). Rozszerza mechanizm krotek bazy danych o dodatkowe parametry specyficzne dla zadań CRM, w tym powiązanie z procesami workflow.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `DbTupleDefinition` → `DbTupleDefinition`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DbTupleDefinition | `Soneta.Core.DbTuples.DbTupleDefinition` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| DefinicjaProcesu | `IWFDefinition` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| DefinicjaProcesu | `IWFDefinition` | `WFDefinition` |
