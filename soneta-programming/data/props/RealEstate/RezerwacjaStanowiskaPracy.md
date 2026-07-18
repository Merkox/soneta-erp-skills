# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.RezerwacjaStanowiskaPracy`
Nazwa tabeli: `RezerStanowPracy`
Tytuł: Rezerwacja stanowiska pracy
Opis: Rejestr rezerwacji stanowisk pracy przez pracowników. Umożliwia planowanie i zarządzanie dostępnością miejsc pracy z określeniem okresu, celu rezerwacji oraz osoby, dla której stanowisko jest zarezerwowane.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 5
- podlisty: 1
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CelRezerwacji | `Soneta.RealEstate.Models.Database.CelRezerwacji` | bazodanowe | Cel rezerwacji | Cel rezerwacji stanowiska |
| DataModyfikacji | `System.DateTime` | bazodanowe, tylko-odczyt | Data modyfikacji | Data i godzina modyfikacji |
| DataRezerwacji | `System.DateTime` | bazodanowe, tylko-odczyt | Data rezerwacji | Data i godzina rezerwacji |
| JednostkaOrganizacyjna | `Soneta.Kadry.Wydzial` | tylko-odczyt | Jednostka organizacyjna |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres | Okres rezerwacji |
| Osoba | `IWykonujacy` | bazodanowe | Stanowisko pracy dla danej osoby | Osoba dla której przypisano stanowisko pracy |
| Rezerwujacy | `IWykonujacy` | bazodanowe | Rezerwujacy | Osoba rezerwująca stanowisko pracy |
| RoomAndLocation | `string` | tylko-odczyt |  |  |
| StanowiskoPracy | `Soneta.RealEstate.Models.Database.StanowiskoPracy` | bazodanowe, tylko-odczyt | Stanowisko pracy | Stanowisko pracy |
