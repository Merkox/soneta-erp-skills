# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaZestawienia`
Nazwa tabeli: `StrefyZestawien`
Tytuł: Strefy zestawień
Opis: Element szczegółowy zestawienia czasu pracy (ZestawieniePracy). Pozycja zestawienia okresowego zawierająca definicję strefy i sumaryczny czas przepracowany w danej strefie w okresie rozliczeniowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zestawienie` → `ZestawieniePracy`
Implementuje interfejsy: `IRozliczenieNadgodzinHost`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Zestawienie | `Soneta.Kalend.ZestawieniePracy` | bazodanowe, tylko-odczyt, guided-parent |  |  |
