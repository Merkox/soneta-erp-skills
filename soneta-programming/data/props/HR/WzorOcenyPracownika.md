# Pola i właściwości klasy biznesowej: `Soneta.HR.WzorOcenyPracownika`
Nazwa tabeli: `WzoryOcenPrac`
Tytuł: Wzory ocen
Opis: Szablony ocen pracowniczych definiujące zestaw kryteriów do zastosowania. Wzór oceny grupuje wybrane kryteria w spójny formularz, który następnie jest wykorzystywany przy tworzeniu ocen.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| ElementyOceny | `Soneta.Business.SubTable<Soneta.HR.ElementWzoruOcenyPracownika>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
