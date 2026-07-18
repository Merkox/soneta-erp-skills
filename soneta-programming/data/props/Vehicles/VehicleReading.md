# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.VehicleReading`
Nazwa tabeli: `VehicleReadings`
Tytuł: Odczyty liczników pojazdów
Opis: Rejestr odczytów liczników (przebiegów) pojazdów z datą i osobą rejestrującą. Służy do monitorowania przebiegu pojazdu, kontroli zużycia oraz weryfikacji spójności odczytów chronologicznych w ramach rezerwacji i zdarzeń flotowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `Date` |  |  |  |
| DateTime | `System.DateTime` | bazodanowe | Data odczytu | Data odczytu |
| LastReading | `Soneta.Vehicles.VehicleReading` | tylko-odczyt |  |  |
| Performer | `IWykonujacy` | bazodanowe | Rejestrujący |  |
| Time | `Time` |  |  |  |
| Value | `int` | bazodanowe | Wartość | Odczyt licznika |
| Vehicle | `Soneta.Vehicles.Vehicle` | bazodanowe, tylko-odczyt |  |  |
