# Pola i właściwości klasy biznesowej: `Soneta.BI.ModelTable`
Nazwa tabeli: `ModelTables`
Tytuł: Tabele modelu
Opis: Element szczegółowy modelu danych (DataModel). Wskazuje tabelę źródłową, z której model pobiera dane do analizy. Kolejność tabel definiuje priorytet źródeł w zapytaniu analitycznym.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  |  |
| Model | `Soneta.BI.DataModel` | bazodanowe, tylko-odczyt | Model danych |  |
| Proxy | `Soneta.BI.TableProxy` (subrow) | bazodanowe | Tabela źródłowa |  |
| Proxy.TableName | `string` | bazodanowe, tylko-odczyt | Nazwa tabeli źródłowej |  |
| Proxy.TableObject | `Soneta.BI.DataModel` | bazodanowe, tylko-odczyt | Tabela źródłowa |  |
| Proxy.TableSource | `Soneta.BI.Interfaces.ITableSource` | tylko-odczyt |  |  |
| Proxy.WgTableObject | `Key` | podlista |  |  |
| TableSource | `Soneta.BI.Interfaces.ITableSource` | tylko-odczyt |  |  |
