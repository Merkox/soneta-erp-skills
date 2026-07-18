# Pola i właściwości klasy biznesowej: `Soneta.Towary.ElemOpakowan`
Nazwa tabeli: `ElemyOpakowan`
Tytuł: Elementy schematów opakowań/gratisów
Opis: Element szczegółowy schematu opakowań/gratisów (SchemOpakowan). Definiuje pojedynczy składnik schematu opakowań/gratisów, określając towar-opakowanie/gratis, jego ilość oraz progi ilościowe towaru bazowego, przy których opakowanie/gratis jest wydawane. Pozwala na automatyczne generowanie pozycji opakowaniowych/gratisowych na dokumentach handlowych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Schemat` → `SchemOpakowan`

- pola bazodanowe (zapisywalne): 10
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CenaBrutto | `DoubleCy` | bazodanowe | Cena brutto | Cena brutto gratisu. |
| CenaNetto | `DoubleCy` | bazodanowe | Cena netto | Cena netto gratisu. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe |  | Ilość. |
| IloscMinimalna | `double` | bazodanowe |  | Ilość minimalna towaru dla której są wydawane opakowania. |
| IloscTowaru | `double` | bazodanowe |  | Ilość towaru dla której są wydawane opakowania. |
| Lp | `int` | bazodanowe |  |  |
| MaxWystapien | `int` | bazodanowe | Maksymalna ilość wystąpień | Maksymalna ilość wystąpień. |
| Opakowanie | `Soneta.Towary.Towar` | bazodanowe |  | Towar będący elementem schematu. |
| Polacz | `bool` | bazodanowe | Połącz | Wymusza wzajemne przeliczanie ceny netto i brutto. |
| PriorytetGratisu | `int` | bazodanowe | Priorytet gratisu | Priorytet gratisu. |
| Schemat | `Soneta.Towary.SchemOpakowan` | bazodanowe, tylko-odczyt, guided-parent |  | Schemat, do którego należy ta pozycja |
