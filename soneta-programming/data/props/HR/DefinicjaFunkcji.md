# Pola i właściwości klasy biznesowej: `Soneta.HR.DefinicjaFunkcji`
Nazwa tabeli: `DefinicjeFunkcji`
Tytuł: Definicje funkcji
Opis: Słownik funkcji pełnionych przez pracowników w organizacji. Pozwala oddzielić funkcję (np. kierownik, specjalista) od stanowiska, co umożliwia elastyczne modelowanie struktury organizacyjnej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Funkcja | `string` | bazodanowe |  |  |
| FunkcjaPelna | `string` | bazodanowe |  |  |
| KodWymiany | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
