# Pola i właściwości klasy biznesowej: `Soneta.Core.ElemSysWartosc`
Nazwa tabeli: `ElemSysWartosci`
Tytuł: Wartości ElemSysZewn
Opis: Zawiera wartości ElemSysZewn, aby umożliwić poprawne parowanie w relacji n -> 1 między powiązanymi elementami systemu. Mechanizm ten zapewnia jednoznaczne przypisanie danych oraz prawidłowe odwzorowanie zależności.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElemSysZewn | `Soneta.Core.ElemSysZewn` | bazodanowe, tylko-odczyt | ElemSysZewn |  |
| Wartosc | `string` | bazodanowe | Wartość |  |
