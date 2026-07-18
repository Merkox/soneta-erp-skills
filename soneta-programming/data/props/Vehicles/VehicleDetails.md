# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.VehicleDetails`
Nazwa tabeli: `VehiclesDetails`
Tytuł: Szczegóły Pojazdu
Opis: Rozszerzona kartoteka pojazdów przechowująca szczegółowe dane techniczne, rejestracyjne, gwarancyjne i biznesowe. Zawiera informacje o modelu, VIN, silniku, kolorze, właścicielu, serwisancie, dokumencie zakupu oraz karcie paliwowej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDocumentHostCRM`

- pola bazodanowe (zapisywalne): 22
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 3
- subrowy: 0
- razem: 29

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Color | `string` | bazodanowe | Kolor |  |
| Department | `Soneta.Kadry.Wydzial` | bazodanowe | Dział |  |
| Description | `MemoText` | bazodanowe, podlista | Opis pojazdu |  |
| DokumentyCRM | `SubTable<Soneta.Zadania.DokumentCRM>` | podlista |  |  |
| Emmision | `string` | bazodanowe | Norma emisji CO2 |  |
| EngineCapacity | `double` | bazodanowe | Pojemność silnika |  |
| FirstRegDate | `Date` | bazodanowe | Data pierwszej rejestracji |  |
| FirstRegistrationDate | `Date` | bazodanowe | Data pierwszej rejestracji |  |
| FuelCardNo | `string` | bazodanowe | Numer karty paliwowej |  |
| LastReading | `Soneta.Vehicles.VehicleReading` | tylko-odczyt |  |  |
| Limit | `double` | bazodanowe | Roczny limit kilometrów |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa pojazdu |
| Owner | `Soneta.CRM.Kontrahent` | bazodanowe | Właściciel |  |
| Power | `double` | bazodanowe | Moc silnika |  |
| ProductionYear | `int` | bazodanowe | Rok produkcji |  |
| PurchaseDate | `Date` | bazodanowe | Data zakupu |  |
| PurchaseDocument | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument zakupu |  |
| Readings | `View<Soneta.Vehicles.VehicleReading>` | podlista |  |  |
| Seats | `int` | bazodanowe | Liczba miejsc |  |
| Service | `Soneta.CRM.Kontrahent` | bazodanowe | Serwisant |  |
| Transmission | `string` | bazodanowe | Skrzynia biegów |  |
| VIN | `string` | bazodanowe | VIN |  |
| Vehicle | `Soneta.Vehicles.Vehicle` | tylko-odczyt |  |  |
| VehicleBase | `Soneta.Samochodowka.Pojazd` | bazodanowe, tylko-odczyt |  |  |
| VehicleBrand | `Db.DictionaryItem` | tylko-odczyt |  |  |
| VehicleModel | `string` | bazodanowe | Model pojazdu |  |
| VehicleState | `Soneta.Vehicles.Models.Database.Config.VehicleState` | bazodanowe | Stan pojazdu |  |
| VehicleType | `Soneta.Vehicles.Models.Database.Config.VehicleType` | bazodanowe | Typ pojazdu |  |
| WarrantyDate | `Date` | bazodanowe | Data gwarancji |  |
