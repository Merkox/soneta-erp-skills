# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.VehicleAssetRel`
Nazwa tabeli: `VehicleAssetsRel`
Tytuł: Relacje pojazdów do środków trwałych
Opis: Tabela powiązań pojazdów ze środkami trwałymi i wyposażeniem. Umożliwia przypisanie środków trwałych do pojazdu z uwzględnieniem okresu obowiązywania powiązania, np. zamontowany GPS, zestaw opon zimowych.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Asset | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe |  |  |
| Period | `Soneta.Types.FromTo` | bazodanowe | Okres |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe |  |  |
| VehicleHis | `Soneta.Vehicles.VehicleHis` |  |  |  |
