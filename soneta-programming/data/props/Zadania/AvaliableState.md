# Pola i właściwości klasy biznesowej: `Soneta.Zadania.AvaliableState`
Nazwa tabeli: `AvaliableStates`
Tytuł: Dostepne stany
Opis: Konfiguracja dozwolonych przejść między stanami realizacji zadania CRM. Określa, na jaki stan docelowy można zmienić dany stan wyjściowy zadania.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.Zadania.StanZadania` | bazodanowe | Dostępny stan |  |
| Parent | `Soneta.Zadania.StanZadania` | bazodanowe | Stan wyjściowy |  |
