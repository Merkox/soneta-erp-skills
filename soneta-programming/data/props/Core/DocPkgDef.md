# Pola i właściwości klasy biznesowej: `Soneta.Core.DocPkgDef`
Nazwa tabeli: `DocPkgDefs`
Tytuł: Definicje paczek dokumentów
Opis: Tabela konfiguracyjna przechowująca definicje paczek dokumentów, stanowiące szablony dla tworzenia nowych paczek. Każda definicja posiada unikalny symbol i nazwę oraz może być oznaczona jako domyślna.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 1
- razem: 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowAttItems | `bool` | bazodanowe |  | Flaga włączająca możliwość dodawania rekordów paczki typu Załącznik. |
| AllowKSeFItems | `bool` | bazodanowe |  | Flaga włączająca możliwość dodawania rekordów paczki typu KSeF. |
| AllowRegistItems | `bool` | bazodanowe |  | Flaga włączająca możliwość dodawania rekordów paczki typu Ewidencja. |
| Blocked | `bool` | bazodanowe |  | Określa zablokowanie definicji. Zablokowane definicje dokumentów nie będą wyświetlane w liście wyboru. |
| IsDefault | `bool` | bazodanowe | Domyślna |  |
| Name | `string` | bazodanowe |  | Pełna nazwa definicji dokumentu wykorzystywana do wyszukiwania definicji. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  | Ustawienia określające sposób numeracji dokumentów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Offset | `bool` | bazodanowe |  | Przesunięcie wstecz o jeden miesiąc względem miesiąca bieżącego dla okresu obowiązywania paczki. |
| SendToOcrOnPkgClose | `bool` | bazodanowe |  | Wyślij do OCR podczas zamykania paczki. |
| Symbol | `string` | bazodanowe |  | Skrótowa nazwa definicji dokumentu wykorzystywana do wyszukiwania definicji oraz numeracji paczek dokumentów. |
| UseMatrixAttachments | `bool` | bazodanowe |  | Stosuj matrycę dla załączników przy zamknięciu paczki. |
| UseMatrixRegisterDoc | `bool` | bazodanowe |  | Stosuj matrycę dla plików ewidencji przy zamknięciu paczki. |
| WidoczneCechy | `MemoText` | podlista |  |  |
