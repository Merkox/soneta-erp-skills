# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOWycofanieOświadczenia`
Nazwa tabeli: `GIODOWycofOsw`
Opis: Element szczegółowy definicji oświadczenia RODO (GIODODefinicjaOświadczenia). Definiuje relację wycofania - określa, które oświadczenie wycofuje inne, z flagami ostrzeżenia i automatycznego wycofania.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `GIODODefinicjaOświadczenia`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Auto | `bool` | bazodanowe |  |  |
| Definicja | `Soneta.Core.GIODODefinicjaOświadczenia` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Ostrzezenie | `bool` | bazodanowe |  |  |
| Wycofywany | `Soneta.Core.GIODODefinicjaOświadczenia` | bazodanowe |  |  |
