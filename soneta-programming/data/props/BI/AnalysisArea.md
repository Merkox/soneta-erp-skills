# Pola i właściwości klasy biznesowej: `Soneta.BI.AnalysisArea`
Nazwa tabeli: `AnalysisAreas`
Tytuł: Obszary
Opis: Element szczegółowy obiektu obsługującego obszary (IAreaHost). Przypisuje definicję obszaru merytorycznego do modelu danych lub innego obiektu BI, określając jego pozycję. Umożliwia klasyfikowanie elementów BI według obszarów tematycznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AreaDefinition | `Soneta.BI.AnalysisAreaDefinition` | bazodanowe | Definicja obszaru |  |
| Host | `Soneta.BI.Interfaces.IAreaHost` | bazodanowe, iface-ref |  |  |
| Lp | `int` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IAreaHost` | `DataModel` |
