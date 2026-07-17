# Pola i właściwości klasy biznesowej: `Soneta.Towary.ZamiennikTowaru`
Nazwa tabeli: `ZamiennikiTowaru`
Opis: Element szczegółowy towaru (Towar). Definiuje zamiennik towarowy, czyli alternatywny towar mogący zastąpić dany asortyment na dokumentach handlowych. Przechowuje współczynnik przeliczeniowy ilości, informację o dwustronności zamiany oraz kolejność priorytetową zamienników.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BiezacyTowar | `Soneta.Towary.Towar` |  |  |  |
| Dwustronny | `bool` | bazodanowe | Dwustronny | Czy zamienniki jest dwustronny. |
| JednostkaTow | `Soneta.Towary.Jednostka` | bazodanowe | JednostkaTow | Jednostka towaru. |
| JednostkaZam | `Soneta.Towary.Jednostka` | bazodanowe | JednostkaZam | Jednostka zamiennika. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa zamienników na towarze. |
| Towar | `Soneta.Towary.Towar` | bazodanowe, guided-parent | Towar | Towar, dla którego zdefiniowany jest zamiennik |
| Wspolczynnik | `Soneta.Types.Fraction` | bazodanowe | Współczynnik | Współczynnik wyliczania jednostki zamiennika z jednostki towaru. |
| WspolczynnikOdwrotny | `Soneta.Types.Fraction` |  |  |  |
| WspolczynnikWzor | `string` |  | Wzór | Wzór pokazujący sposób przeliczania jednostek. |
| Zamiennik | `Soneta.Towary.Towar` | bazodanowe | Zamiennik | Towar, dla którego zdefiniowany jest zamiennik |
| Zamienniki | `Soneta.Towary.Towar` |  |  |  |
