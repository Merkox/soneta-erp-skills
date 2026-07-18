# Pola i właściwości klasy biznesowej: `Soneta.Core.UIExtension`
Nazwa tabeli: `UIExtensions`
Tytuł: Definicje XML nagłówków lub stopek dokumentów
Opis: Definicja niestandardowego nagłówka lub stopki dokumentu. Przechowuje definicję XML formularza przypisaną do wskazanej tabeli (typu obiektu), z nazwą, grupą przeznaczenia (nagłówek/stopka) i kompatybilnością ze starym i nowym standardem.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EditValue | `IGuidedRow` |  |  |  |
| Grupa | `Soneta.Core.GrupaDefinicjiNaglowkaEnum` (enum) | bazodanowe | Grupa | Przeznaczenie nagłówka lub stopki |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa nagłówka lub stopki |
| PageForm | `MemoText` | bazodanowe, podlista | Definicja - obecny standard | Definicja zgodna z nowym standardem |
| Tabela | `string` | bazodanowe | Nazwa powiązanej tabeli | Nazwa tabeli, dla której elementu powstała definicja |
| XmlOld | `MemoText` | bazodanowe, podlista | Definicja - stary standard | Definicja zgodna ze starym standardem |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GrupaDefinicjiNaglowkaEnum (`Soneta.Core.GrupaDefinicjiNaglowkaEnum`)
- `Naglowek` = 1 — Nagłówek
- `Podsumowanie` = 2
- `Pozycja` = 3
