# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.DmsState`
Nazwa tabeli: `DmsStates`
Tytuł: Status DMS
Opis: Przechowuje informacje o statusach przypisanych do konkretnych obiektów (dokumentów, spraw) w module DMS. Pozwala na przypisanie definicji statusu do różnych typów obiektów, zapewnia możliwość ustawienia nazwy wyświetlanej na obiekcie oraz umożliwia ustawienie domyślnego statusu i jego aktywności w systemie.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BasicDocStates | `Soneta.Business.SubTable<Soneta.Workflow.Dms.BasicDocument>` |  |  |  |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Nazwa statusu DMS wyświetlana dla obiektu |
| IsActive | `bool` | bazodanowe | Aktywny | Status aktywny |
| IsDefault | `bool` | bazodanowe | Domyślny | Status domyślny |
| MatterStates | `Soneta.Business.SubTable<Soneta.Workflow.Dms.Matter>` |  |  |  |
| ObjectGuid | `System.Guid` | bazodanowe | Guid obiektu | Guid obiektu, do którego jest przypisany ten status |
| ObjectType | `string` | bazodanowe | Typ obiektu | Typ obiektu, do którego jest przypisany ten status |
| SortOrder | `int` | bazodanowe | Kolejność | Kolejność statusu |
| StateDef | `Soneta.Workflow.Dms.DmsStateDef` | bazodanowe | Definicja statusu | Definicja statusu DMS |
| StateDefCode | `string` |  |  |  |
| StateDefName | `string` |  |  |  |
