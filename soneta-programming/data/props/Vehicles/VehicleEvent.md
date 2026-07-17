# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.VehicleEvent`
Nazwa tabeli: `VehicleEvents`
Tytuł: Zdarzenia pojazdów
Opis: Rejestr zdarzeń związanych z pojazdami, takich jak przeglądy, naprawy czy odczyty liczników. Każde zdarzenie jest powiązane z zadaniem w module CRM i może zawierać odczyt pomiaru licznika pojazdu.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Comments | `Soneta.Business.MemoText` | bazodanowe | Uwagi |  |
| CreationDate | `Soneta.Types.Date` | bazodanowe | Data utworzenia | Data utworzenia |
| Number | `string` | bazodanowe | Numer |  |
| Reading | `int` |  |  |  |
| ReadingDate | `Soneta.Types.Date` |  |  |  |
| ReadingTime | `Soneta.Types.Time` |  |  |  |
| Task | `Soneta.Vehicles.Models.VehicleTask` | bazodanowe | Zadanie |  |
| Vehicle | `Soneta.Vehicles.Vehicle` |  |  |  |
| VehicleReading | `Soneta.Vehicles.VehicleReading` | bazodanowe | Odczyt | Odczyt pomiaru licznika |
