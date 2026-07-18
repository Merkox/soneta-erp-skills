# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOKategoriaOdbiorcow`
Nazwa tabeli: `GIODOKategOdb`
Tytuł: Kategorie odbiorców
Opis: Słownik kategorii odbiorców danych osobowych w kontekście RODO. Określa grupy podmiotów, którym mogą być udostępniane dane osobowe. Każda kategoria posiada nazwę, opis i flagę blokady.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa kategorii | Nazwa kategorii |
| Opis | `MemoText` | bazodanowe, podlista | Opis kategorii | Opis kategorii |
