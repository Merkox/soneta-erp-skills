# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewnSprzedazOperator`
Nazwa tabeli: `KSeFIdentWewnSpOp`
Tytuł: Przypisani operatorzy dla sprzedaży dla identyfikatora wewnętrznego KSeF
Opis: Tabela przechowuje przypisania operatorów do wewnętrznych identyfikatorów KSeF dla sprzedaży. ŝączy identyfikator wewnętrzny KSeF z operatorem odpowiedzialnym za wystawianie faktur elektronicznych w ramach danego identyfikatora.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IdentWewnKSeF | `Soneta.Core.KSeFIdentWewn` | bazodanowe, tylko-odczyt |  |  |
| Operator | `App.Operator` | bazodanowe |  |  |
