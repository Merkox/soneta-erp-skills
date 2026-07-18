# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODO.GIODOZbiorKategoria`
Nazwa tabeli: `GIODOZbioryKateg`
Tytuł: GIODO przetwarzania - kategoria
Opis: Powiązanie zbioru danych RODO z kategorią (osób, danych osobowych, odbiorców). Umożliwia przypisanie wielu kategorii do jednego zbioru danych, opisując zakres przetwarzanych informacji.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kategoria | `Soneta.Core.GIODO.IGIODOKategoria` | bazodanowe, tylko-odczyt | Kategoria | Kategorie osób, danych osobowych przypisanych do czynności |
| Nazwa | `string` | bazodanowe |  | Nazwa kategorii przypisanej do czynności przetwarzania |
| ZbiorDanych | `Soneta.Core.GIODO.GIODOZbiorDanych` | bazodanowe, tylko-odczyt | Czynność przetwarzania | Czynność przetwarzania |
