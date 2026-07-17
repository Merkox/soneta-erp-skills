# Pola i właściwości klasy biznesowej: `Soneta.BI.ModelTable`
Nazwa tabeli: `ModelTables`
Tytuł: Tabele modelu
Opis: Element szczegółowy modelu danych (DataModel). Wskazuje tabelę źródłową, z której model pobiera dane do analizy. Kolejność tabel definiuje priorytet źródeł w zapytaniu analitycznym.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  |  |
| Model | `Soneta.BI.DataModel` | bazodanowe | Model danych |  |
| Proxy | `Soneta.BI.TableProxy` | bazodanowe | Tabela źródłowa |  |
| Proxy.TableName | `string` | bazodanowe | Nazwa tabeli źródłowej |  |
| Proxy.TableObject | `Soneta.BI.DataModel` | bazodanowe | Tabela źródłowa |  |
| Proxy.TableSource | `Soneta.BI.Interfaces.ITableSource` |  |  |  |
| Proxy.WgTableObject | `Soneta.Business.Key` |  |  |  |
| TableSource | `Soneta.BI.Interfaces.ITableSource` |  |  |  |
