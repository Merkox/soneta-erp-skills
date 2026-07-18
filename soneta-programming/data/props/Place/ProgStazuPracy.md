# Pola i właściwości klasy biznesowej: `Soneta.Place.ProgStazuPracy`
Nazwa tabeli: `ProgiStazuPracy`
Opis: Element szczegółowy definicji elementu wynagrodzenia (DefinicjaElementu). Definiuje próg stażu pracy (w latach) i odpowiadającą mu wartość procentową dodatku, tworząc tabelę progów stażowych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefinicjaElementu`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Prog | `int` | bazodanowe |  |  |
| Wartosc | `Percent` | bazodanowe |  |  |
