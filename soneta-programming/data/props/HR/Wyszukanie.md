# Pola i właściwości klasy biznesowej: `Soneta.HR.Wyszukanie`
Nazwa tabeli: `Wyszukania`
Tytuł: Wyszukania
Opis: Zdefiniowane kryteria wyszukiwania kandydatów lub pracowników o określonych kompetencjach. Umożliwia zapisanie zestawu wymagań z wagami i progami minimalnymi w celu dopasowania pracowników do potrzeb.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| OpisLinia | `string` |  |  |  |
| OpisPierwszaLinia | `string` |  |  |  |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.HR.PozycjaWyszukania>` |  |  |  |
| WymaganeMinimum | `decimal` | bazodanowe |  |  |
