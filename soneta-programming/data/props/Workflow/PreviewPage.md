# Pola i właściwości klasy biznesowej: `Soneta.Workflow.PreviewPage`
Nazwa tabeli: `PreviewPages`
Tytuł: Okna podglądu
Opis: Definicja okna podglądu wyświetlanego w kontekście procesu workflow lub zadania. Pozwala skonfigurować dodatkowe zakładki i widoki prezentujące dane dokumentów dodatkowych, z możliwością ustalenia priorytetu wyświetlania i typu strony.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataTable | `Table` | podlista |  |  |
| DataType | `System.Type` | tylko-odczyt |  |  |
| Description | `string` | bazodanowe | Opis | Opis okna podglądu |
| Host | `IPreviewPageHost` | bazodanowe, tylko-odczyt, iface-ref | Definicja dokumentu dodatkowego | Definicja dokumentu dodatkowego |
| Locked | `bool` | bazodanowe | Zablokowany |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa okna podglądu |
| PageType | `Soneta.Workflow.PreviewPageType` (enum) | bazodanowe | Typ okna |  |
| Priority | `int` | bazodanowe | Priorytet |  |
| TableName | `string` | bazodanowe, tylko-odczyt | Typ obiektu | Określa typ obiektu |
| TaskDefinition | `Db.TaskDefinition` | bazodanowe |  |  |
| WFDefinition | `Soneta.Workflow.Config.WFDefinition` | bazodanowe |  |  |
| Xml | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IPreviewPageHost` | `DbTupleDefinition`, `DefZadania`, `TaskDefinition` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PreviewPageType (`Soneta.Workflow.PreviewPageType`)
- `Defined` = 1 — Zakładka użytkownika
