# Pola i właściwości klasy biznesowej: `Soneta.Zadania.AvaliableState`
Nazwa tabeli: `AvaliableStates`
Tytuł: Dostepne stany
Opis: Konfiguracja dozwolonych przejść między stanami realizacji zadania CRM. Określa, na jaki stan docelowy można zmienić dany stan wyjściowy zadania.
Tabela konfiguracyjna: Tak

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.Zadania.StanZadania` | bazodanowe | Dostępny stan |  |
| Parent | `Soneta.Zadania.StanZadania` | bazodanowe, tylko-odczyt | Stan wyjściowy |  |
