# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.EkoRodzajSilnika`
Nazwa tabeli: `EkoRodzSilnikow`
Tytuł: Rodzaje silników
Opis: Słownik rodzajów silników pojazdów na potrzeby rozliczeń środowiskowych. Definiuje typy silników (np. benzynowy, diesel, elektryczny) z opisem. Stanowi podstawę do przypisania paliw i stawek opłat za emisję do poszczególnych pojazdów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Opis | `string` | bazodanowe |  | Opis rodzaju silnika |
| Paliwa | `Soneta.Business.SubTable<Soneta.Samochodowka.EkoPaliwoSilnika>` |  |  |  |
| Symbol | `string` | bazodanowe |  | Symbol silnika |
