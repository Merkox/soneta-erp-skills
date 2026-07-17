# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.RezerwacjaStanowiskaPracy`
Nazwa tabeli: `RezerStanowPracy`
Tytuł: Rezerwacja stanowiska pracy
Opis: Rejestr rezerwacji stanowisk pracy przez pracowników. Umożliwia planowanie i zarządzanie dostępnością miejsc pracy z określeniem okresu, celu rezerwacji oraz osoby, dla której stanowisko jest zarezerwowane.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CelRezerwacji | `Soneta.RealEstate.Models.Database.CelRezerwacji` | bazodanowe | Cel rezerwacji | Cel rezerwacji stanowiska |
| DataModyfikacji | `System.DateTime` | bazodanowe | Data modyfikacji | Data i godzina modyfikacji |
| DataRezerwacji | `System.DateTime` | bazodanowe | Data rezerwacji | Data i godzina rezerwacji |
| JednostkaOrganizacyjna | `Soneta.Kadry.Wydzial` |  | Jednostka organizacyjna |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres | Okres rezerwacji |
| Osoba | `Soneta.Business.IWykonujacy` | bazodanowe | Stanowisko pracy dla danej osoby | Osoba dla której przypisano stanowisko pracy |
| Rezerwujacy | `Soneta.Business.IWykonujacy` | bazodanowe | Rezerwujacy | Osoba rezerwująca stanowisko pracy |
| RoomAndLocation | `string` |  |  |  |
| StanowiskoPracy | `Soneta.RealEstate.Models.Database.StanowiskoPracy` | bazodanowe | Stanowisko pracy | Stanowisko pracy |
