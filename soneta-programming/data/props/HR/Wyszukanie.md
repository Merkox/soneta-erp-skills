# Pola i właściwości klasy biznesowej: `Soneta.HR.Wyszukanie`
Nazwa tabeli: `Wyszukania`
Tytuł: Wyszukania
Opis: Zdefiniowane kryteria wyszukiwania kandydatów lub pracowników o określonych kompetencjach. Umożliwia zapisanie zestawu wymagań z wagami i progami minimalnymi w celu dopasowania pracowników do potrzeb.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisLinia | `string` | tylko-odczyt |  |  |
| OpisPierwszaLinia | `string` | tylko-odczyt |  |  |
| Pozycje | `LpSubTable<Soneta.HR.PozycjaWyszukania>` | podlista |  |  |
| WymaganeMinimum | `decimal` | bazodanowe |  |  |
