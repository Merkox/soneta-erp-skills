# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.Config.UnifiedRegister`
Nazwa tabeli: `UnifiedRgs`
Tytuł: Wykazy akt
Opis: Wykaz akt (jednolity rzeczowy wykaz akt) obowiązujący w danym okresie. Stanowi konfigurowalny katalog klasyfikacyjny dokumentów zgodny z instrukcją kancelaryjną, zawierający hierarchiczną strukturę klas wykazów akt.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Locked | `bool` | bazodanowe | Zablokowane | Definicja wykazu akt zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa wykazu akt |
| PartialReadOnly | `bool` | tylko-odczyt |  |  |
| Period | `FromTo` | bazodanowe, podlista | Okres | Okres obowiązywania definicji |
| Symbol | `string` | bazodanowe | Symbol | Symbol wykazu akt |
| UnifiedRegisterClasses | `SubTable<Soneta.Workflow.Dms.Config.UnifiedRegisterClass>` | podlista |  |  |
