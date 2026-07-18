# Pola i właściwości klasy biznesowej: `Soneta.BI.AppearanceItemDefinition`
Nazwa tabeli: `AppItemDefs`
Tytuł: Definicje barw
Opis: Element szczegółowy zestawu barw (AppearanceSetDefinition). Definiuje pojedynczą barwę w palecie kolorów — jej nazwę i wartość koloru. Barwy są przypisywane do przedziałów danych w wizualizacjach BI.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definition` → `AppearanceSetDefinition`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Color | `int` | bazodanowe | Kolor |  |
| ColorEditor | `System.Drawing.Color` |  |  |  |
| Definition | `Soneta.BI.AppearanceSetDefinition` | bazodanowe, tylko-odczyt, guided-parent | Definicja zestawu |  |
| Lp | `int` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
