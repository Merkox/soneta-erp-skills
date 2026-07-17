# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.VehicleReading`
Nazwa tabeli: `VehicleReadings`
Tytuł: Odczyty liczników pojazdów
Opis: Rejestr odczytów liczników (przebiegów) pojazdów z datą i osobą rejestrującą. Służy do monitorowania przebiegu pojazdu, kontroli zużycia oraz weryfikacji spójności odczytów chronologicznych w ramach rezerwacji i zdarzeń flotowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Date | `Soneta.Types.Date` |  |  |  |
| DateTime | `System.DateTime` | bazodanowe | Data odczytu | Data odczytu |
| LastReading | `Soneta.Vehicles.VehicleReading` |  |  |  |
| Performer | `Soneta.Business.IWykonujacy` | bazodanowe | Rejestrujący |  |
| Time | `Soneta.Types.Time` |  |  |  |
| Value | `int` | bazodanowe | Wartość | Odczyt licznika |
| Vehicle | `Soneta.Vehicles.Vehicle` | bazodanowe |  |  |
