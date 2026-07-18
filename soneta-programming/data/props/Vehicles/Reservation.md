# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Reservation`
Nazwa tabeli: `Reservations`
Tytuł: Rezerwacje
Opis: Główna tabela rezerwacji pojazdów rejestrująca wypożyczenia floty firmowej. Przechowuje dane o pojeździe, kierowcy, trasie, celu, okresie, odczytach licznika początkowym i końcowym, stanie rezerwacji, poziomie paliwa oraz miejscach odbioru i zwrotu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDocumentHostCRM`, `IEmailElement`

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 9
- pola tylko-odczyt: 18
- podlisty: 5
- subrowy: 1
- razem: 50

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` | tylko-odczyt |  |  |
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| Booker | `IRezerwujacy` | bazodanowe | Rezerwujący |  |
| CanCreateFinalReading | `bool` | tylko-odczyt |  |  |
| CanCreateInitialReading | `bool` | tylko-odczyt |  |  |
| Contractor | `Soneta.CRM.Kontrahent` | bazodanowe | Kontrahent |  |
| Data | `Date` | tylko-odczyt |  |  |
| DateFrom | `System.DateTime` | bazodanowe | Data od |  |
| DateTo | `System.DateTime` | bazodanowe | Data do |  |
| Definicja | `Soneta.Core.IDefinicjaDokumentu` | tylko-odczyt, iface-ref |  |  |
| Definition | `Soneta.Vehicles.Models.Database.Config.ReservationDef` | bazodanowe | Definicja |  |
| Description | `string` | bazodanowe | Opis | Opis |
| Destination | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja kontrahenta |  |
| DokumentyCRM | `SubTable<Soneta.Zadania.DokumentCRM>` | podlista |  |  |
| End | `System.DateTime` | tylko-odczyt |  |  |
| FinalReading | `Soneta.Vehicles.VehicleReading` | bazodanowe, tylko-odczyt | Odczyt końcowy | Odczyt końcowy pomiaru licznika |
| FinalReadingValue | `int` |  |  |  |
| From | `Date` |  |  |  |
| FuelLevel | `string` | bazodanowe | Poziom paliwa | Poziom paliwa |
| IDokumentNumerPelny | `string` | tylko-odczyt |  |  |
| InitialReading | `Soneta.Vehicles.VehicleReading` | bazodanowe, tylko-odczyt | Odczyt początkowy | Odczyt początkowy pomiaru licznika |
| IsReadOnlyCreateReading | `bool` | tylko-odczyt |  |  |
| IsStanReadOnly | `bool` | tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| Length | `decimal` | bazodanowe | Długość | Długość trasy |
| MailTo | `string` | tylko-odczyt |  |  |
| Notes | `MemoText` | bazodanowe, podlista | Uwagi |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe | Numer |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| PickupLocation | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Miejsce odbioru |  |
| Purpose | `string` | bazodanowe | Cel | Cel |
| ReservationState | `Soneta.Vehicles.Models.Database.Config.ReservationState` | bazodanowe | Stan |  |
| Resource | `object` | tylko-odczyt |  |  |
| ReturnLocation | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Miejsce oddania |  |
| SchedulerInterval | `Interval` |  |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Text | `string` |  |  |  |
| TimeFrom | `Time` |  |  |  |
| TimeTo | `Time` |  |  |  |
| To | `Date` |  |  |  |
| TripType | `Soneta.Samochodowka.TypTrasy` (enum) | bazodanowe | Typ Trasy |  |
| Vehicle | `Soneta.Vehicles.Vehicle` | bazodanowe | Pojazd |  |
| VehicleContext | `Soneta.Vehicles.Vehicle` |  |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definicja | `IDefinicjaDokumentu` | `ChronoOrder` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypTrasy (`Soneta.Samochodowka.TypTrasy`)
- `Brak` = 0
- `Lokalna` = 1
- `Krajowa` = 2
- `Międzynarodowa` = 3
