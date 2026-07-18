# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOKategoriaDanychOsobowych`
Nazwa tabeli: `GIODOKategDnOsob`
Tytuł: Kategorie danych osobowych
Opis: Słownik kategorii danych osobowych w kontekście RODO (np. dane identyfikacyjne, adresowe, finansowe). Każda kategoria posiada nazwę, opis i flagę blokady. Wykorzystywana przy definiowaniu zbiorów i czynności przetwarzania.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa kategorii | Nazwa kategorii |
| Opis | `MemoText` | bazodanowe, podlista | Opis kategorii | Opis kategorii |
