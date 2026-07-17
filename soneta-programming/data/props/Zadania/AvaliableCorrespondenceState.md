# Pola i właściwości klasy biznesowej: `Soneta.Zadania.AvaliableCorrespondenceState`
Nazwa tabeli: `AvalCorreStates`
Tytuł: Dostepne stany korespondencji
Opis: Konfiguracja dozwolonych przejść między stanami korespondencji. Określa, na jaki stan docelowy można zmienić dany stan wyjściowy korespondencji.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.Zadania.StanKoresp` | bazodanowe | Dostępny stan |  |
| Parent | `Soneta.Zadania.StanKoresp` | bazodanowe | Stan wyjściowy |  |
