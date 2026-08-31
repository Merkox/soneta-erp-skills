# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.DmsStateDef`
Nazwa tabeli: `DmsStateDefs`
Tytuł: Definicje statusów DMS
Opis: Przechowuje definicje statusów dla modułu DMS, identyfikowane unikalną nazwą oraz kodem. Służy jako baza konfiguracji statusów, które są następnie przypisywane do konkretnych obiektów w tabeli DMSState.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `string` | bazodanowe | Kod | Kod definicji statusu DMS |
| Description | `MemoText` | bazodanowe, podlista | Opis | Opis definicji statusu DMS |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji statusu DMS |
| States | `SubTable<Soneta.Workflow.Dms.DmsState>` | podlista |  |  |
