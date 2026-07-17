# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewnSprzedazOddzial`
Nazwa tabeli: `KSeFIdentWewnSpOd`
Tytuł: Przypisane oddziały dla sprzedaży dla identyfikatora wewnętrznego KSeF
Opis: Tabela przechowuje przypisania oddziałów firmy do wewnętrznych identyfikatorów KSeF dla sprzedaży. ŝączy identyfikator wewnętrzny KSeF z oddziałem, którego dokumenty sprzedaży są wysyłane do Krajowego Systemu e-Faktur.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| IdentWewnKSeF | `Soneta.Core.KSeFIdentWewn` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
