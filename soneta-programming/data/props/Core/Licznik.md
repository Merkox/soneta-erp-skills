# Pola i właściwości klasy biznesowej: `Soneta.Core.Licznik`
Nazwa tabeli: `Liczniki`
Opis: Systemowa tabela liczników służąca do generowania kolejnych numerów. Każdy licznik posiada unikalną nazwę i ostatnio wydany numer, wykorzystywany m.in. do numeracji dokumentów i innych obiektów wymagających sekwencji.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| Ostatni | `int` | bazodanowe |  |  |
