# Pola i właściwości klasy biznesowej: `Soneta.Kadry.TreśćOświadczenia`
Nazwa tabeli: `TresciOswiadczen`
Tytuł: Treści oświadczeń
Opis: Element szczegółowy definicji oświadczenia (DefinicjaOświadczenia). Wariant treści oświadczenia pracowniczego – pozwala zdefiniować wiele wzorów tekstu dla jednego typu oświadczenia, z oznaczeniem treści domyślnej.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefinicjaOświadczenia`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `Soneta.Kadry.DefinicjaOświadczenia` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Domyslna | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Tresc | `MemoText` | bazodanowe, podlista | Treść |  |
