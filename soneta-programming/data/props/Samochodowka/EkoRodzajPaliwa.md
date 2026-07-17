# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.EkoRodzajPaliwa`
Nazwa tabeli: `EkoRodzajePaliw`
Tytuł: Rodzaje paliw (środowisko)
Opis: Słownik rodzajów paliw na potrzeby rozliczeń środowiskowych. Zawiera symbol, nazwę oraz gęstość paliwa niezbędną do przeliczenia ilości na masę. Służy do naliczania opłat za korzystanie ze środowiska z tytułu emisji spalin.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Gestosc | `double` | bazodanowe |  | Gęstość paliwa w kg/l |
| Nazwa | `string` | bazodanowe |  | Nazwa paliwa |
| Silniki | `Soneta.Business.SubTable<Soneta.Samochodowka.EkoPaliwoSilnika>` |  |  |  |
| Symbol | `string` | bazodanowe |  | Symbol paliwa |
