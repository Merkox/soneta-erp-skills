# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.AreaPath`
Nazwa tabeli: `AreaPaths`
Tytuł: Obszary w systemie
Opis: Rejestr obszarów (ścieżek folderów) w systemie enova365 powiązanych z konkretną bazą danych. Służy do mapowania zadań na miejsca w strukturze programu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DatabaseName | `string` | bazodanowe | Nazwa bazy danych |  |
| FolderPath | `string` | bazodanowe | Ścieżka w programie |  |
