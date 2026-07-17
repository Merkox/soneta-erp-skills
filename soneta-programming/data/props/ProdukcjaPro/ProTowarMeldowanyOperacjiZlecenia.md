# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProTowarMeldowanyOperacjiZlecenia`
Nazwa tabeli: `ProTowaryMeldOZ`
Tytuł: Towary meldowane operacji zleceń
Opis: Element szczegółowy operacji zlecenia (ProOperacjaZlecenia). Wskazuje towar podlegający meldowaniu w ramach operacji zlecenia produkcyjnego, określając wyrób lub półprodukt raportowany jako efekt wykonania operacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent |  | Operacja zlecenia dla towaru meldowanego. |
| TowarMeldowany | `Soneta.ProdukcjaPro.IProTowarMeldowany` | bazodanowe | Towar meldowany | Towar meldowany operacji zlecenia. |
