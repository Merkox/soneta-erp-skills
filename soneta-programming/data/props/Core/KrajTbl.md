# Pola i właściwości klasy biznesowej: `Soneta.Core.KrajTbl`
Nazwa tabeli: `KrajeTbl`
Tytuł: Kraje
Opis: Słownik krajów zgodny ze standardem ISO-3166-1. Zawiera kody alfa-2, alfa-3, kod numeryczny, nazwę, obywatelstwo, symbol domyślnej waluty, flagę członkostwa w UE oraz blokadę. Używany do klasyfikacji podmiotów i adresów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Blokada - kraj zablokowany nie może być użyty do tworzenia nowych danych |
| CzyPolska | `bool` | tylko-odczyt |  |  |
| Kod2 | `string` | bazodanowe | Kod kraju alfa-2 | Dwuliterowy kod kraju wg standardu ISO-3166-1 |
| Kod3 | `string` | bazodanowe | Kod kraju alfa-3 | Trzyliterowy kod kraju wg standardu ISO-3166-1 |
| KodNum | `string` | bazodanowe | Kod cyfrowy kraju | Trzycyfrowy kod kraju wg standardu ISO-3166-1 |
| Nazwa | `string` | bazodanowe | Nazwa kraju | Nazwa kraju |
| Obywatelstwo | `string` | bazodanowe | Obywatelstwo |  |
| SymbolWaluty | `string` | bazodanowe | Symbol waluty | Symbol domyślnej waluty dla kraju |
| UE | `bool` | bazodanowe | Kraj UE | Kraj jest członkiem Unii Europejskiej |
