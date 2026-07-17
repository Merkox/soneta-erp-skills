# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.DmsStateDef`
Nazwa tabeli: `DmsStateDefs`
Tytuł: Definicje statusów DMS
Opis: Przechowuje definicje statusów dla modułu DMS, identyfikowane unikalną nazwą oraz kodem. Służy jako baza konfiguracji statusów, które są następnie przypisywane do konkretnych obiektów w tabeli DMSState.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `string` | bazodanowe | Kod | Kod definicji statusu DMS |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis definicji statusu DMS |
| Name | `string` | bazodanowe | Nazwa | Nazwa definicji statusu DMS |
| States | `Soneta.Business.SubTable<Soneta.Workflow.Dms.DmsState>` |  |  |  |
