# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFIdentWewnSprzedazOddzial`
Nazwa tabeli: `KSeFIdentWewnSpOd`
Tytuł: Przypisane oddziały dla sprzedaży dla identyfikatora wewnętrznego KSeF
Opis: Tabela przechowuje przypisania oddziałów firmy do wewnętrznych identyfikatorów KSeF dla sprzedaży. ŝączy identyfikator wewnętrzny KSeF z oddziałem, którego dokumenty sprzedaży są wysyłane do Krajowego Systemu e-Faktur.
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
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
