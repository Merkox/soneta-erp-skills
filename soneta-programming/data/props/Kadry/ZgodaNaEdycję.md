# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZgodaNaEdycję`
Nazwa tabeli: `ZgodyNaEdycje`
Tytuł: Zgody na edycję danych
Opis: Zgoda na edycję danych kadrowo-płacowych w zamkniętym okresie dla danej jednostki organizacyjnej. Umożliwia tymczasowe odblokowanie edycji w module Kadry, Płace lub Web, z możliwością wycofania zgody.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kadry | `bool` | bazodanowe |  |  |
| LimityNieobecnosci | `bool` | bazodanowe |  |  |
| Nazwa | `string` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Place | `bool` | bazodanowe |  |  |
| Poczatek | `Soneta.Types.YearMonth` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| Web | `bool` | bazodanowe |  |  |
| Wycofana | `bool` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
