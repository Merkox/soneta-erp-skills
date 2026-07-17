# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.VehicleDetails`
Nazwa tabeli: `VehiclesDetails`
Tytuł: Szczegóły Pojazdu
Opis: Rozszerzona kartoteka pojazdów przechowująca szczegółowe dane techniczne, rejestracyjne, gwarancyjne i biznesowe. Zawiera informacje o modelu, VIN, silniku, kolorze, właścicielu, serwisancie, dokumencie zakupu oraz karcie paliwowej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDocumentHostCRM`

- pola bazodanowe: 24
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Color | `string` | bazodanowe | Kolor |  |
| Department | `Soneta.Kadry.Wydzial` | bazodanowe | Dział |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis pojazdu |  |
| DokumentyCRM | `Soneta.Business.SubTable<Soneta.Zadania.DokumentCRM>` |  |  |  |
| Emmision | `string` | bazodanowe | Norma emisji CO2 |  |
| EngineCapacity | `double` | bazodanowe | Pojemność silnika |  |
| FirstRegDate | `Soneta.Types.Date` | bazodanowe | Data pierwszej rejestracji |  |
| FirstRegistrationDate | `Soneta.Types.Date` | bazodanowe | Data pierwszej rejestracji |  |
| FuelCardNo | `string` | bazodanowe | Numer karty paliwowej |  |
| LastReading | `Soneta.Vehicles.VehicleReading` |  |  |  |
| Limit | `double` | bazodanowe | Roczny limit kilometrów |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa pojazdu |
| Owner | `Soneta.CRM.Kontrahent` | bazodanowe | Właściciel |  |
| Power | `double` | bazodanowe | Moc silnika |  |
| ProductionYear | `int` | bazodanowe | Rok produkcji |  |
| PurchaseDate | `Soneta.Types.Date` | bazodanowe | Data zakupu |  |
| PurchaseDocument | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument zakupu |  |
| Readings | `Soneta.Business.View<Soneta.Vehicles.VehicleReading>` |  |  |  |
| Seats | `int` | bazodanowe | Liczba miejsc |  |
| Service | `Soneta.CRM.Kontrahent` | bazodanowe | Serwisant |  |
| Transmission | `string` | bazodanowe | Skrzynia biegów |  |
| VIN | `string` | bazodanowe | VIN |  |
| Vehicle | `Soneta.Vehicles.Vehicle` |  |  |  |
| VehicleBase | `Soneta.Samochodowka.Pojazd` | bazodanowe |  |  |
| VehicleBrand | `Soneta.Business.Db.DictionaryItem` |  |  |  |
| VehicleModel | `string` | bazodanowe | Model pojazdu |  |
| VehicleState | `Soneta.Vehicles.Models.Database.Config.VehicleState` | bazodanowe | Stan pojazdu |  |
| VehicleType | `Soneta.Vehicles.Models.Database.Config.VehicleType` | bazodanowe | Typ pojazdu |  |
| WarrantyDate | `Soneta.Types.Date` | bazodanowe | Data gwarancji |  |
