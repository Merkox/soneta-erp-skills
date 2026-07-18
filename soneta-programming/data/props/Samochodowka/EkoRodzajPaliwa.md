# Pola i właściwości klasy biznesowej: `Soneta.Samochodowka.EkoRodzajPaliwa`
Nazwa tabeli: `EkoRodzajePaliw`
Tytuł: Rodzaje paliw (środowisko)
Opis: Słownik rodzajów paliw na potrzeby rozliczeń środowiskowych. Zawiera symbol, nazwę oraz gęstość paliwa niezbędną do przeliczenia ilości na masę. Służy do naliczania opłat za korzystanie ze środowiska z tytułu emisji spalin.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Gestosc | `double` | bazodanowe, tylko-odczyt |  | Gęstość paliwa w kg/l |
| Nazwa | `string` | bazodanowe, tylko-odczyt |  | Nazwa paliwa |
| Silniki | `SubTable<Soneta.Samochodowka.EkoPaliwoSilnika>` | podlista |  |  |
| Symbol | `string` | bazodanowe, tylko-odczyt |  | Symbol paliwa |
