# Moduł `Vehicles` — tabele biznesowe

- Opis: Moduł zarządzania flotą pojazdów. Zawiera kartotekę pojazdów, przeglądy, ubezpieczenia, tankowania, koszty eksploatacji oraz przypisania kierowców.
- Tabel: **16**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DamageEvent | Szkody komunikacyjne | `DamageEvents` |  | root |  | IEmailElement |  | [DamageEvent.md](DamageEvent.md) |
| Fine | Mandaty | `Fines` |  | root |  |  |  | [Fine.md](Fine.md) |
| Insurance | Ubezpieczenia pojazdów | `Insurances` |  | root |  | IEmailElement |  | [Insurance.md](Insurance.md) |
| Reservation | Rezerwacje | `Reservations` |  | root |  | IDocumentHostCRM, IEmailElement |  | [Reservation.md](Reservation.md) |
| ReservationDef | Definicje rezerwacji pojazdu | `ReservationDefs` | konfig | root |  | IRightsSource |  | [ReservationDef.md](ReservationDef.md) |
| ReservationState | Stany rezerwacji | `ReservStates` | konfig | root |  |  |  | [ReservationState.md](ReservationState.md) |
| TechInspection | Bdania techniczne pojazdów | `TechInspections` |  | root |  |  |  | [TechInspection.md](TechInspection.md) |
| UsedVehicle | Pojazdy wykorzystane | `UsedVehicles` |  |  |  |  |  | [UsedVehicle.md](UsedVehicle.md) |
| VehicleAssetRel | Relacje pojazdów do środków trwałych | `VehicleAssetsRel` |  |  |  |  |  | [VehicleAssetRel.md](VehicleAssetRel.md) |
| VehicleDetails | Szczegóły Pojazdu | `VehiclesDetails` |  | root |  | IDocumentHostCRM |  | [VehicleDetails.md](VehicleDetails.md) |
| VehicleEvent | Zdarzenia pojazdów | `VehicleEvents` |  | root |  |  |  | [VehicleEvent.md](VehicleEvent.md) |
| VehicleHis | Historia pojazdów | `VehiclesHis` |  | root | historia |  |  | [VehicleHis.md](VehicleHis.md) |
| VehicleReading | Odczyty liczników pojazdów | `VehicleReadings` |  | root |  |  |  | [VehicleReading.md](VehicleReading.md) |
| VehicleService | Usługa pojazdu | `VehicleServices` |  |  |  |  |  | [VehicleService.md](VehicleService.md) |
| VehicleState | Stany pojazdów | `VehicleStates` | konfig | root |  |  |  | [VehicleState.md](VehicleState.md) |
| VehicleType | Typy pojazdów | `VehicleTypes` | konfig | root |  |  |  | [VehicleType.md](VehicleType.md) |

