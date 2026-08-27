# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.VehicleEvent`
Nazwa tabeli: `VehicleEvents`
Tytuł: Zdarzenia pojazdów
Opis: Rejestr zdarzeń związanych z pojazdami, takich jak przeglądy, naprawy czy odczyty liczników. Każde zdarzenie jest powiązane z zadaniem w module CRM i może zawierać odczyt pomiaru licznika pojazdu.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Comments | `MemoText` | bazodanowe, podlista | Uwagi |  |
| CreationDate | `Date` | bazodanowe | Data utworzenia | Data utworzenia |
| Number | `string` | bazodanowe | Numer |  |
| Reading | `int` |  |  |  |
| ReadingDate | `Date` |  |  |  |
| ReadingTime | `Time` |  |  |  |
| Task | `Soneta.Vehicles.Models.VehicleTask` | bazodanowe, tylko-odczyt | Zadanie |  |
| Vehicle | `Soneta.Vehicles.Vehicle` | tylko-odczyt |  |  |
| VehicleReading | `Soneta.Vehicles.VehicleReading` | bazodanowe | Odczyt | Odczyt pomiaru licznika |
