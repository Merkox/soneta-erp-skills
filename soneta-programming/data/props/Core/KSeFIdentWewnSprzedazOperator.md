# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewnSprzedazOperator`
Nazwa tabeli: `KSeFIdentWewnSpOp`
Tytuł: Przypisani operatorzy dla sprzedaży dla identyfikatora wewnętrznego KSeF
Opis: Tabela przechowuje przypisania operatorów do wewnętrznych identyfikatorów KSeF dla sprzedaży. ŝączy identyfikator wewnętrzny KSeF z operatorem odpowiedzialnym za wystawianie faktur elektronicznych w ramach danego identyfikatora.
Tabela konfiguracyjna: Tak

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IdentWewnKSeF | `Soneta.Core.KSeFIdentWewn` | bazodanowe, tylko-odczyt |  |  |
| Operator | `App.Operator` | bazodanowe |  |  |
