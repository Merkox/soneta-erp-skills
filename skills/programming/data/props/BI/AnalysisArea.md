# Pola i właściwości klasy biznesowej: `Soneta.BI.AnalysisArea`
Nazwa tabeli: `AnalysisAreas`
Tytuł: Obszary
Opis: Element szczegółowy obiektu obsługującego obszary (IAreaHost). Przypisuje definicję obszaru merytorycznego do modelu danych lub innego obiektu BI, określając jego pozycję. Umożliwia klasyfikowanie elementów BI według obszarów tematycznych.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AreaDefinition | `Soneta.BI.AnalysisAreaDefinition` | bazodanowe | Definicja obszaru |  |
| Host | `Soneta.BI.Interfaces.IAreaHost` | bazodanowe, tylko-odczyt, iface-ref |  |  |
| Lp | `int` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IAreaHost` | `DataModel` |
