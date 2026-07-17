# Pola i właściwości klasy biznesowej: `Soneta.Core.TerminalPlatStanowisko`
Nazwa tabeli: `TerminalPlatStan`
Tytuł: Lista terminali płatniczych przypisanych do stanowiska
Opis: Przypisanie terminala płatniczego do stanowiska pracy. ŝączy konkretne stanowisko (identyfikowane nazwą) z terminalem płatniczym, umożliwiając automatyczny wybór terminala na danym stanowisku.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Stanowisko | `string` | bazodanowe |  |  |
| Terminal | `Soneta.Core.TerminalPlatniczy` | bazodanowe |  |  |
