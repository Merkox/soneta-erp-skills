# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaZestawienia`
Nazwa tabeli: `StrefyZestawien`
Tytuł: Strefy zestawień
Opis: Element szczegółowy zestawienia czasu pracy (ZestawieniePracy). Pozycja zestawienia okresowego zawierająca definicję strefy i sumaryczny czas przepracowany w danej strefie w okresie rozliczeniowym.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zestawienie` → `ZestawieniePracy`
Implementuje interfejsy: `IRozliczenieNadgodzinHost`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Zestawienie | `Soneta.Kalend.ZestawieniePracy` | bazodanowe, guided-parent |  |  |
