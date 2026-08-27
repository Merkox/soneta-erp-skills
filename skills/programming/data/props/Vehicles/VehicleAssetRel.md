# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.VehicleAssetRel`
Nazwa tabeli: `VehicleAssetsRel`
Tytuł: Relacje pojazdów do środków trwałych
Opis: Tabela powiązań pojazdów ze środkami trwałymi i wyposażeniem. Umożliwia przypisanie środków trwałych do pojazdu z uwzględnieniem okresu obowiązywania powiązania, np. zamontowany GPS, zestaw opon zimowych.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Asset | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe |  |  |
| Period | `FromTo` | bazodanowe, podlista | Okres |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe |  |  |
| VehicleHis | `Soneta.Vehicles.VehicleHis` |  |  |  |
