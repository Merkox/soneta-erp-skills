# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOKategoriaOdbiorcow`
Nazwa tabeli: `GIODOKategOdb`
Tytuł: Kategorie odbiorców
Opis: Słownik kategorii odbiorców danych osobowych w kontekście RODO. Określa grupy podmiotów, którym mogą być udostępniane dane osobowe. Każda kategoria posiada nazwę, opis i flagę blokady.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa kategorii | Nazwa kategorii |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis kategorii | Opis kategorii |
