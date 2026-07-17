# Pola i właściwości klasy biznesowej: `Soneta.Core.StanTeczki`
Nazwa tabeli: `StanyTeczek`
Tytuł: Stany teczek
Opis: Element szczegółowy definicji teczki (DefTeczki). Definiuje możliwe stany teczki (np. otwarta, zamknięta, w toku) z liczbą porządkową, nazwą, flagą aktywności i blokady.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefTeczki`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy teczka w tym stanie jest aktywne (otwarte). |
| Blokada | `bool` | bazodanowe | Zablokowany | Określa zablokowanie stanu. |
| Definicja | `Soneta.Core.DefTeczki` | bazodanowe, guided-parent |  | Definicja teczki, do której jest przypisany ten stan |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa stanu . |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa stanu |
