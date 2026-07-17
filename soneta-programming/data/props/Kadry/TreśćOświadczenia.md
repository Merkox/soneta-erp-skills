# Pola i właściwości klasy biznesowej: `Soneta.Kadry.TreśćOświadczenia`
Nazwa tabeli: `TresciOswiadczen`
Tytuł: Treści oświadczeń
Opis: Element szczegółowy definicji oświadczenia (DefinicjaOświadczenia). Wariant treści oświadczenia pracowniczego – pozwala zdefiniować wiele wzorów tekstu dla jednego typu oświadczenia, z oznaczeniem treści domyślnej.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefinicjaOświadczenia`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicja | `Soneta.Kadry.DefinicjaOświadczenia` | bazodanowe, guided-parent |  |  |
| Domyslna | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Treść |  |
