# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.DmsState`
Nazwa tabeli: `DmsStates`
Tytuł: Status DMS
Opis: Przechowuje informacje o statusach przypisanych do konkretnych obiektów (dokumentów, spraw) w module DMS. Pozwala na przypisanie definicji statusu do różnych typów obiektów, zapewnia możliwość ustawienia nazwy wyświetlanej na obiekcie oraz umożliwia ustawienie domyślnego statusu i jego aktywności w systemie.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BasicDocStates | `SubTable<Soneta.Workflow.Dms.BasicDocument>` | podlista |  |  |
| FormattedName | `string` | bazodanowe | Nazwa formatowana | Nazwa statusu DMS wyświetlana dla obiektu |
| IsActive | `bool` | bazodanowe | Aktywny | Status aktywny |
| IsDefault | `bool` | bazodanowe | Domyślny | Status domyślny |
| MatterStates | `SubTable<Soneta.Workflow.Dms.Matter>` | podlista |  |  |
| ObjectGuid | `System.Guid` | bazodanowe, tylko-odczyt | Guid obiektu | Guid obiektu, do którego jest przypisany ten status |
| ObjectType | `string` | bazodanowe, tylko-odczyt | Typ obiektu | Typ obiektu, do którego jest przypisany ten status |
| SortOrder | `int` | bazodanowe | Kolejność | Kolejność statusu |
| StateDef | `Soneta.Workflow.Dms.DmsStateDef` | bazodanowe | Definicja statusu | Definicja statusu DMS |
| StateDefCode | `string` | tylko-odczyt |  |  |
| StateDefName | `string` | tylko-odczyt |  |  |
