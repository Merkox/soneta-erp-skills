# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOZbiorKategoria`
Nazwa tabeli: `GIODOZbioryKateg`
Tytuł: GIODO przetwarzania - kategoria
Opis: Powiązanie zbioru danych RODO z kategorią (osób, danych osobowych, odbiorców). Umożliwia przypisanie wielu kategorii do jednego zbioru danych, opisując zakres przetwarzanych informacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kategoria | `Soneta.Core.GIODO.IGIODOKategoria` | bazodanowe | Kategoria | Kategorie osób, danych osobowych przypisanych do czynności |
| Nazwa | `string` | bazodanowe |  | Nazwa kategorii przypisanej do czynności przetwarzania |
| ZbiorDanych | `Soneta.Core.GIODO.GIODOZbiorDanych` | bazodanowe | Czynność przetwarzania | Czynność przetwarzania |
