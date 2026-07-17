# Pola i właściwości klasy biznesowej: `Soneta.Waluty.Waluta`
Nazwa tabeli: `Waluty`
Opis: Słownik walut stosowanych w systemie. Definiuje symbole, nazwy i krotności walut oraz opcjonalny stały przelicznik do EUR wykorzystywany w rozliczeniach.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Calkowity | `string` | bazodanowe |  |  |
| Dziesietny | `string` | bazodanowe |  |  |
| Euro | `Soneta.Waluty.Euro` | bazodanowe |  |  |
| Euro.Data | `Soneta.Types.Date` | bazodanowe |  | Data od której obowiązuje stały przelicznik do EUR |
| Euro.Krotnosc | `double` | bazodanowe |  |  |
| Euro.Kurs | `double` | bazodanowe |  |  |
| Euro.StalyKurs | `bool` | bazodanowe |  |  |
| Kraj | `string` | bazodanowe |  |  |
| Krotnosc | `int` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Notowania | `Soneta.Business.SubTable` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Zero | `Soneta.Types.Currency` |  |  |  |
