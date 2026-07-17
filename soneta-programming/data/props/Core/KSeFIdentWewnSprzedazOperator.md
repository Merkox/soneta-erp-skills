# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewnSprzedazOperator`
Nazwa tabeli: `KSeFIdentWewnSpOp`
Tytuł: Przypisani operatorzy dla sprzedaży dla identyfikatora wewnętrznego KSeF
Opis: Tabela przechowuje przypisania operatorów do wewnętrznych identyfikatorów KSeF dla sprzedaży. ŝączy identyfikator wewnętrzny KSeF z operatorem odpowiedzialnym za wystawianie faktur elektronicznych w ramach danego identyfikatora.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IdentWewnKSeF | `Soneta.Core.KSeFIdentWewn` | bazodanowe |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
