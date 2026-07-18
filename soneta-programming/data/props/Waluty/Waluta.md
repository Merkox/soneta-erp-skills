# Pola i właściwości klasy biznesowej: `Soneta.Waluty.Waluta`
Nazwa tabeli: `Waluty`
Opis: Słownik walut stosowanych w systemie. Definiuje symbole, nazwy i krotności walut oraz opcjonalny stały przelicznik do EUR wykorzystywany w rozliczeniach.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Calkowity | `string` | bazodanowe |  |  |
| Dziesietny | `string` | bazodanowe |  |  |
| Euro | `Soneta.Waluty.Euro` (subrow) | bazodanowe |  |  |
| Euro.Data | `Date` | bazodanowe |  | Data od której obowiązuje stały przelicznik do EUR |
| Euro.Krotnosc | `double` | bazodanowe |  |  |
| Euro.Kurs | `double` | bazodanowe |  |  |
| Euro.StalyKurs | `bool` | bazodanowe |  |  |
| Kraj | `string` | bazodanowe |  |  |
| Krotnosc | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Notowania | `SubTable` | podlista |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Zero | `Currency` | tylko-odczyt |  |  |
