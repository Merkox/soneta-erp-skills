# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRelacjaZasobPozycjaKompetencji`
Nazwa tabeli: `ProRZasobPKomp`
Tytuł: Relacje zasobów i pozycji właściwości
Opis: Element szczegółowy zasobu produkcyjnego (ProZasob). Wiąże zasób z konkretnymi pozycjami właściwości (kompetencji), określając kwalifikacje operatora lub parametry techniczne maszyny wymagane do realizacji operacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zasob` → `ProZasob`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe |  | Liczba porządkowa dla relacji zasób pozycja właściwości. |
| PozycjaKompetencji | `Soneta.ProdukcjaPro.ProPozycjaKompetencji` | bazodanowe | Pozycja właściwości | Pozycja właściwości dla relacji zasób pozycja właściwości. |
| Zasob | `Soneta.ProdukcjaPro.ProZasob` | bazodanowe, guided-parent | Zasób | Zasób dla relacji zasób pozycja właściwości. |
