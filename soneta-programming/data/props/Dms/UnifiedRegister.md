# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.UnifiedRegister`
Nazwa tabeli: `UnifiedRgs`
Tytuł: Wykazy akt
Opis: Wykaz akt (jednolity rzeczowy wykaz akt) obowiązujący w danym okresie. Stanowi konfigurowalny katalog klasyfikacyjny dokumentów zgodny z instrukcją kancelaryjną, zawierający hierarchiczną strukturę klas wykazów akt.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Locked | `bool` | bazodanowe | Zablokowane | Definicja wykazu akt zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa wykazu akt |
| PartialReadOnly | `bool` |  |  |  |
| Period | `Soneta.Types.FromTo` | bazodanowe | Okres | Okres obowiązywania definicji |
| Symbol | `string` | bazodanowe | Symbol | Symbol wykazu akt |
| UnifiedRegisterClasses | `Soneta.Business.SubTable<Soneta.Workflow.Dms.Config.UnifiedRegisterClass>` |  |  |  |
