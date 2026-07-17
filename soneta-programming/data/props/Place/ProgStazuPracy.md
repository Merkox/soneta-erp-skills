# Pola i właściwości klasy biznesowej: `Soneta.Place.ProgStazuPracy`
Nazwa tabeli: `ProgiStazuPracy`
Opis: Element szczegółowy definicji elementu wynagrodzenia (DefinicjaElementu). Definiuje próg stażu pracy (w latach) i odpowiadającą mu wartość procentową dodatku, tworząc tabelę progów stażowych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefinicjaElementu`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe, guided-parent |  |  |
| Prog | `int` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.Percent` | bazodanowe |  |  |
