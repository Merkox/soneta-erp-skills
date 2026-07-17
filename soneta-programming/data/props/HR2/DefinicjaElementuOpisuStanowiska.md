# Pola i właściwości klasy biznesowej: `Soneta.HR2.DefinicjaElementuOpisuStanowiska`
Nazwa tabeli: `DefElOpisuStanow`
Tytuł: Definicje elementów opisu stanowisk
Opis: Definicja pojedynczego elementu opisu stanowiska w ramach kategorii. Określa nazwę, priorytet wyświetlania i parametry edycji, stanowiąc szablon pól do wypełnienia na karcie opisu stanowiska.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| EdycjaOpisu | `bool` | bazodanowe |  |  |
| Kategoria | `Soneta.HR2.KategoriaElementuOpisuStanowiska` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaUI | `string` |  | Nazwa |  |
| NazwaWyswietlana | `string` | bazodanowe | Nazwa wyświetlana |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisJendaLinia | `string` |  |  |  |
| PozycjaDokumentu | `Soneta.Oceny.PozycjaDokumentuInfo` | bazodanowe |  |  |
| PozycjaDokumentu.Sekcja | `Soneta.Oceny.DefinicjaSekcjiDokumentu` | bazodanowe |  |  |
| PozycjaDokumentu.WgSekcja | `Soneta.Business.Key` |  |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Wielokrotny | `bool` | bazodanowe |  |  |
