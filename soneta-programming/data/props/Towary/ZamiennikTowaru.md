# Pola i właściwości klasy biznesowej: `Soneta.Towary.ZamiennikTowaru`
Nazwa tabeli: `ZamiennikiTowaru`
Opis: Element szczegółowy towaru (Towar). Definiuje zamiennik towarowy, czyli alternatywny towar mogący zastąpić dany asortyment na dokumentach handlowych. Przechowuje współczynnik przeliczeniowy ilości, informację o dwustronności zamiany oraz kolejność priorytetową zamienników.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Towar` → `Towar`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BiezacyTowar | `Soneta.Towary.Towar` |  |  |  |
| Dwustronny | `bool` | bazodanowe | Dwustronny | Czy zamienniki jest dwustronny. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa zamienników na towarze. |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt, guided-parent | Towar | Towar, dla którego zdefiniowany jest zamiennik |
| Wspolczynnik | `Fraction` | bazodanowe | Współczynnik | Współczynnik wyliczania jednostki zamiennika z jednostki towaru. |
| WspolczynnikWzor | `string` | tylko-odczyt | Wzór | Wzór pokazujący sposób przeliczania jednostek. |
| Zamiennik | `Soneta.Towary.Towar` | bazodanowe | Zamiennik | Towar, dla którego zdefiniowany jest zamiennik |
| Zamienniki | `Soneta.Towary.Towar` |  |  |  |
