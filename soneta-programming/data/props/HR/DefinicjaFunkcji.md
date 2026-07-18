# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaFunkcji`
Nazwa tabeli: `DefinicjeFunkcji`
Tytuł: Definicje funkcji
Opis: Słownik funkcji pełnionych przez pracowników w organizacji. Pozwala oddzielić funkcję (np. kierownik, specjalista) od stanowiska, co umożliwia elastyczne modelowanie struktury organizacyjnej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Funkcja | `string` | bazodanowe |  |  |
| FunkcjaPelna | `string` | bazodanowe |  |  |
| KodWymiany | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisLinia | `string` | tylko-odczyt |  |  |
| OpisPierwszaLinia | `string` | tylko-odczyt |  |  |
