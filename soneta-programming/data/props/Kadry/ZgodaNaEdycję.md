# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZgodaNaEdycję`
Nazwa tabeli: `ZgodyNaEdycje`
Tytuł: Zgody na edycję danych
Opis: Zgoda na edycję danych kadrowo-płacowych w zamkniętym okresie dla danej jednostki organizacyjnej. Umożliwia tymczasowe odblokowanie edycji w module Kadry, Płace lub Web, z możliwością wycofania zgody.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kadry | `bool` | bazodanowe |  |  |
| LimityNieobecnosci | `bool` | bazodanowe |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Place | `bool` | bazodanowe |  |  |
| Poczatek | `YearMonth` | bazodanowe |  |  |
| Termin | `Date` | bazodanowe |  |  |
| Web | `bool` | bazodanowe |  |  |
| Wycofana | `bool` | bazodanowe, tylko-odczyt |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt | Jednostka organizacyjna |  |
