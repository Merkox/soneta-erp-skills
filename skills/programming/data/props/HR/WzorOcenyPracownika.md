# Pola i właściwości klasy biznesowej: `Soneta.HR.WzorOcenyPracownika`
Nazwa tabeli: `WzoryOcenPrac`
Tytuł: Wzory ocen
Opis: Szablony ocen pracowniczych definiujące zestaw kryteriów do zastosowania. Wzór oceny grupuje wybrane kryteria w spójny formularz, który następnie jest wykorzystywany przy tworzeniu ocen.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| ElementyOceny | `SubTable<Soneta.HR.ElementWzoruOcenyPracownika>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisLinia | `string` | tylko-odczyt |  |  |
| OpisPierwszaLinia | `string` | tylko-odczyt |  |  |
