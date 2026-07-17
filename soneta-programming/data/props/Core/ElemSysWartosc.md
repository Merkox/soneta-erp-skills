# Pola i właściwości klasy biznesowej: `Soneta.Core.ElemSysWartosc`
Nazwa tabeli: `ElemSysWartosci`
Tytuł: Wartości ElemSysZewn
Opis: Zawiera wartości ElemSysZewn, aby umożliwić poprawne parowanie w relacji n -> 1 między powiązanymi elementami systemu. Mechanizm ten zapewnia jednoznaczne przypisanie danych oraz prawidłowe odwzorowanie zależności.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ElemSysZewn | `Soneta.Core.ElemSysZewn` | bazodanowe | ElemSysZewn |  |
| Wartosc | `string` | bazodanowe | Wartość |  |
