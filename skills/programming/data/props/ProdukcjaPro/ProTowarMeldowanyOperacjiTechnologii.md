# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProTowarMeldowanyOperacjiTechnologii`
Nazwa tabeli: `ProTowaryMeldOT`
Tytuł: Towary meldowane operacji technologii
Opis: Element szczegółowy operacji wzorcowej (IProOperacjaWzorcowa). Wskazuje towar, który podlega meldowaniu w ramach operacji technologicznej, określając wyrób lub półprodukt raportowany jako efekt wykonania operacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `IProOperacjaWzorcowa`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Operacja | `Soneta.ProdukcjaPro.IProOperacjaWzorcowa` | bazodanowe, guided-parent |  | Operacja dla towaru meldowanego. |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | tylko-odczyt | Operacja technologii | Operacja technologii dla towaru meldowanego operacji technologii. |
| TowarMeldowany | `Soneta.ProdukcjaPro.IProTowarMeldowany` | bazodanowe | Towar meldowany | Towar meldowany operacji technologii. |
