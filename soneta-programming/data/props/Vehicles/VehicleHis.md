# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.VehicleHis`
Nazwa tabeli: `VehiclesHis`
Tytuł: Historia pojazdów
Opis: Element szczegółowy pojazdu (Pojazd). Przechowuje historyczne wersje danych pojazdu z okresu ich aktualności, w tym dane rejestracyjne, techniczne, własnościowe i przypisanie dysponenta. Umożliwia śledzenie zmian parametrów pojazdu w czasie.
Tabela konfiguracyjna: Nie
Guided: root
Historia: Tak

- pola bazodanowe (zapisywalne): 28
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 8
- podlisty: 5
- subrowy: 0
- razem: 43

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| Color | `string` | bazodanowe | Kolor |  |
| Department | `Soneta.Kadry.Wydzial` | bazodanowe | Dział |  |
| Description | `MemoText` | bazodanowe, podlista | Opis pojazdu |  |
| Dictionary | `string` | tylko-odczyt |  |  |
| Dysponent | `Soneta.Kasa.IPodmiotKasowy` | bazodanowe, iface-ref |  | Dysponent pojazdu |
| Emmision | `string` | bazodanowe | Norma emisji CO2 |  |
| EngineCapacity | `double` | bazodanowe | Pojemność silnika |  |
| FirstRegDate | `Date` | bazodanowe | Data pierwszej rejestracji |  |
| FirstRegistrationDate | `Date` | bazodanowe | Data pierwszej rejestracji |  |
| FuelCardNo | `string` | bazodanowe | Numer karty paliwowej |  |
| HistHost | `Db.HistHost` (enum) | tylko-odczyt |  |  |
| IsReasonRequired | `bool` | tylko-odczyt |  |  |
| Limit | `double` | bazodanowe | Roczny limit kilometrów |  |
| Marka | `string` | bazodanowe |  | Marka pojadu |
| Name | `string` | bazodanowe | Nazwa | Nazwa pojazdu |
| NrRejestracyjny | `string` | bazodanowe |  | Numer rejestracyjny pojazdu |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisAktualizacji | `MemoText` | bazodanowe, podlista | Opis aktualizacji | Opis aktualizacji zapisu |
| Owner | `Soneta.CRM.Kontrahent` | bazodanowe | Właściciel |  |
| Paliwa | `SubTable<Soneta.Samochodowka.PaliwoPojazdu>` | podlista |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| Power | `double` | bazodanowe | Moc silnika |  |
| PowodAktualizacji | `string` | bazodanowe, tylko-odczyt | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| ProductionYear | `int` | bazodanowe | Rok produkcji |  |
| PurchaseDate | `Date` | bazodanowe | Data zakupu |  |
| PurchaseDocument | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument zakupu |  |
| Rodzaj | `Soneta.Samochodowka.RodzajPojazdu` (enum) | bazodanowe |  | Rodzaj pojazdu |
| RodzajSilnika | `Soneta.Samochodowka.EkoRodzajSilnika` | bazodanowe |  | Rodzaj silnika z pojeździe |
| Seats | `int` | bazodanowe | Liczba miejsc |  |
| Service | `Soneta.CRM.Kontrahent` | bazodanowe | Serwisant |  |
| Transmission | `string` | bazodanowe | Skrzynia biegów |  |
| UpdateDescription | `string` |  |  |  |
| UpdateReason | `string` |  |  |  |
| VIN | `string` | bazodanowe | VIN |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe, tylko-odczyt |  |  |
| VehicleBase | `Soneta.Vehicles.Vehicle` | tylko-odczyt |  |  |
| VehicleBrand | `Db.DictionaryItem` | tylko-odczyt |  |  |
| VehicleModel | `string` | bazodanowe | Model pojazdu |  |
| VehicleState | `Soneta.Vehicles.Models.Database.Config.VehicleState` | bazodanowe | Stan pojazdu |  |
| VehicleType | `Soneta.Vehicles.Models.Database.Config.VehicleType` | bazodanowe | Typ pojazdu |  |
| WarrantyDate | `Date` | bazodanowe | Data gwarancji |  |
| Wycofany | `bool` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Dysponent | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### HistHost (`Db.HistHost`)
- `PracHistorie` = 1 — Pracownicy
- `UmowaHistorie` = 2 — Umowy
- `NieruchomosciHis` = 3 — Nieruchomości
- `VehicleHis` = 4 — Pojazdy
- `DefinicjaStanowiskaHist` = 5 — Definicje stanowiska

### RodzajPojazdu (`Soneta.Samochodowka.RodzajPojazdu`)
- `Prywatny` = 1 — Samochód prywatny
- `Firmowy` = 2 — Samochód firmowy
- `Inny` = 3
