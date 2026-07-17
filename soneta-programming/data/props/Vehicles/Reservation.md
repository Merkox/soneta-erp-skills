# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Reservation`
Nazwa tabeli: `Reservations`
Tytuł: Rezerwacje
Opis: Główna tabela rezerwacji pojazdów rejestrująca wypożyczenia floty firmowej. Przechowuje dane o pojeździe, kierowcy, trasie, celu, okresie, odczytach licznika początkowym i końcowym, stanie rezerwacji, poziomie paliwa oraz miejscach odbioru i zwrotu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDocumentHostCRM`, `IEmailElement`

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 28

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Active | `bool` |  |  |  |
| AllDayEvent | `bool` |  |  |  |
| Booker | `Soneta.Business.IRezerwujacy` | bazodanowe | Rezerwujący |  |
| CanCreateFinalReading | `bool` |  |  |  |
| CanCreateInitialReading | `bool` |  |  |  |
| Contractor | `Soneta.CRM.Kontrahent` | bazodanowe | Kontrahent |  |
| Data | `Soneta.Types.Date` |  |  |  |
| DateFrom | `System.DateTime` | bazodanowe | Data od |  |
| DateTo | `System.DateTime` | bazodanowe | Data do |  |
| Definicja | `Soneta.Core.IDefinicjaDokumentu` | iface-ref |  |  |
| Definition | `Soneta.Vehicles.Models.Database.Config.ReservationDef` | bazodanowe | Definicja |  |
| Description | `string` | bazodanowe | Opis | Opis |
| Destination | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja kontrahenta |  |
| DokumentyCRM | `Soneta.Business.SubTable<Soneta.Zadania.DokumentCRM>` |  |  |  |
| End | `System.DateTime` |  |  |  |
| FinalReading | `Soneta.Vehicles.VehicleReading` | bazodanowe | Odczyt końcowy | Odczyt końcowy pomiaru licznika |
| FinalReadingValue | `int` |  |  |  |
| From | `Soneta.Types.Date` |  |  |  |
| FuelLevel | `string` | bazodanowe | Poziom paliwa | Poziom paliwa |
| IDokumentNumerPelny | `string` |  |  |  |
| InitialReading | `Soneta.Vehicles.VehicleReading` | bazodanowe | Odczyt początkowy | Odczyt początkowy pomiaru licznika |
| IsReadOnlyCreateReading | `bool` |  |  |  |
| IsStanReadOnly | `bool` |  |  |  |
| Kod | `string` |  |  |  |
| Length | `decimal` | bazodanowe | Długość | Długość trasy |
| MailTo | `string` |  |  |  |
| Notes | `Soneta.Business.MemoText` | bazodanowe | Uwagi |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe | Numer |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| PickupLocation | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Miejsce odbioru |  |
| Purpose | `string` | bazodanowe | Cel | Cel |
| ReservationState | `Soneta.Vehicles.Models.Database.Config.ReservationState` | bazodanowe | Stan |  |
| Resource | `object` |  |  |  |
| ReturnLocation | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Miejsce oddania |  |
| SchedulerInterval | `Soneta.Types.Interval` |  |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Start | `System.DateTime` |  |  |  |
| Text | `string` |  |  |  |
| TimeFrom | `Soneta.Types.Time` |  |  |  |
| TimeTo | `Soneta.Types.Time` |  |  |  |
| To | `Soneta.Types.Date` |  |  |  |
| TripType | `Soneta.Samochodowka.TypTrasy` | bazodanowe, enum | Typ Trasy |  |
| Vehicle | `Soneta.Vehicles.Vehicle` | bazodanowe | Pojazd |  |
| VehicleContext | `Soneta.Vehicles.Vehicle` |  |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |

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
