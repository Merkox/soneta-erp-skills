# Pola i właściwości klasy biznesowej: `Soneta.Windykacja.DefinicjaSprawyWindykacyjnej`
Nazwa tabeli: `DefSprawWind`
Tytuł: Definicje spraw windykacyjnych
Opis: Szablon (definicja) sprawy windykacyjnej określający schemat postępowania windykacyjnego. Zawiera symbol, nazwę, numerację oraz listę etapów, przez które przechodzi sprawa windykacyjna od momentu jej utworzenia.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie definicji. Zablokowane definicje dokumentów nie będą wyświetlane w liście wyboru. |
| DependentWfDefinition | `IDependentWfDefinition` | tylko-odczyt |  |  |
| Domyslny | `bool` | bazodanowe | Domyślna |  |
| Etapy | `LpSubTable<Soneta.Windykacja.EtapDefinicjiWindykacji>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  | Pełna nazwa definicji dokumentu wykorzystywana do wyszukiwania deifnicji. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  | Ustawienia określające sposób numeracji dokumentów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  | Skrótowa nazwa definicji dokumentu wykorzystywana do wyszukiwania definicji oraz numeracji spraw windykacyjnych. |
