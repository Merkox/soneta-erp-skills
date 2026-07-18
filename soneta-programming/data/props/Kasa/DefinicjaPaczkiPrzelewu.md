# Pola i właściwości klasy biznesowej: `Soneta.Kasa.DefinicjaPaczkiPrzelewu`
Nazwa tabeli: `DefPaczekPrze`
Tytuł: Definicje paczek przelewów
Opis: Szablon definicji paczki przelewów określający sposób numeracji i grupowania przelewów do eksportu. Umożliwia tworzenie wielu wariantów paczek z różnymi seriami numeracyjnymi, np. oddzielnie dla przelewów krajowych i zagranicznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 1
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Określa zablokowanie definicji. Zablokowane definicje dokumentów nie będą wyświetlane w liście wyboru. |
| Domyslny | `bool` | bazodanowe | Domyślna |  |
| Nazwa | `string` | bazodanowe |  | Pełna nazwa definicji dokumentu wykorzystywana do wyszukiwania deifnicji. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  | Ustawienia określające sposób numeracji dokumentów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  | Skrótowa nazwa definicji dokumentu wykorzystywana do wyszukiwania definicji oraz numeracji paczek przelewów. |
| WidoczneCechy | `MemoText` | podlista |  |  |
