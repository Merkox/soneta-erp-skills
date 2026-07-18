# Pola i właściwości klasy biznesowej: `Soneta.Core.Licznik`
Nazwa tabeli: `Liczniki`
Opis: Systemowa tabela liczników służąca do generowania kolejnych numerów. Każdy licznik posiada unikalną nazwę i ostatnio wydany numer, wykorzystywany m.in. do numeracji dokumentów i innych obiektów wymagających sekwencji.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| Ostatni | `int` | bazodanowe |  |  |
