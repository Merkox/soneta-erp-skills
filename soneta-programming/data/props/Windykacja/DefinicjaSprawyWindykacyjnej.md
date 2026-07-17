# Pola i właściwości klasy biznesowej: `Soneta.Windykacja.DefinicjaSprawyWindykacyjnej`
Nazwa tabeli: `DefSprawWind`
Tytuł: Definicje spraw windykacyjnych
Opis: Szablon (definicja) sprawy windykacyjnej określający schemat postępowania windykacyjnego. Zawiera symbol, nazwę, numerację oraz listę etapów, przez które przechodzi sprawa windykacyjna od momentu jej utworzenia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie definicji. Zablokowane definicje dokumentów nie będą wyświetlane w liście wyboru. |
| DependentWfDefinition | `Soneta.Business.IDependentWfDefinition` |  |  |  |
| Domyslny | `bool` | bazodanowe | Domyślna |  |
| Etapy | `Soneta.Business.LpSubTable<Soneta.Windykacja.EtapDefinicjiWindykacji>` |  |  |  |
| Nazwa | `string` | bazodanowe |  | Pełna nazwa definicji dokumentu wykorzystywana do wyszukiwania deifnicji. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  | Ustawienia określające sposób numeracji dokumentów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  | Skrótowa nazwa definicji dokumentu wykorzystywana do wyszukiwania definicji oraz numeracji spraw windykacyjnych. |
