# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ElementZestawuDodatków`
Nazwa tabeli: `ElementyZestDod`
Tytuł: Elementy zestawów
Opis: Element szczegółowy zestawu dodatków (ZestawDodatków). Pojedynczy element płacowy wchodzący w skład zestawu dodatków, powiązany z definicją elementu wynagrodzenia.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Zestaw` → `ZestawDodatków`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Zestaw | `Soneta.Kadry.ZestawDodatków` | bazodanowe, tylko-odczyt, guided-parent |  |  |
