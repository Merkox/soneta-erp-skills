# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOKategoriaOdbiorcow`
Nazwa tabeli: `GIODOKategOdb`
Tytuł: Kategorie odbiorców
Opis: Słownik kategorii odbiorców danych osobowych w kontekście RODO. Określa grupy podmiotów, którym mogą być udostępniane dane osobowe. Każda kategoria posiada nazwę, opis i flagę blokady.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe | Nazwa kategorii | Nazwa kategorii |
| Opis | `MemoText` | bazodanowe, podlista | Opis kategorii | Opis kategorii |
