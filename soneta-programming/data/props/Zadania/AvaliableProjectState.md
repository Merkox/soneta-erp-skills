# Pola i właściwości klasy biznesowej: `Soneta.Zadania.AvaliableProjectState`
Nazwa tabeli: `AvalProjStates`
Tytuł: Dostepne stany projektów
Opis: Konfiguracja dozwolonych przejść między stanami realizacji projektu CRM. Określa, na jaki stan docelowy można zmienić dany stan wyjściowy projektu.
Tabela konfiguracyjna: Tak

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Child | `Soneta.Zadania.StanProjektu` | bazodanowe | Dostępny stan |  |
| Parent | `Soneta.Zadania.StanProjektu` | bazodanowe, tylko-odczyt | Stan wyjściowy |  |
