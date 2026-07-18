# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.EkoRodzajSilnika`
Nazwa tabeli: `EkoRodzSilnikow`
Tytuł: Rodzaje silników
Opis: Słownik rodzajów silników pojazdów na potrzeby rozliczeń środowiskowych. Definiuje typy silników (np. benzynowy, diesel, elektryczny) z opisem. Stanowi podstawę do przypisania paliw i stawek opłat za emisję do poszczególnych pojazdów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Opis | `string` | bazodanowe, tylko-odczyt |  | Opis rodzaju silnika |
| Paliwa | `SubTable<Soneta.Samochodowka.EkoPaliwoSilnika>` | podlista |  |  |
| Symbol | `string` | bazodanowe, tylko-odczyt |  | Symbol silnika |
