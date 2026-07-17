# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.Config.VehicleType`
Nazwa tabeli: `VehicleTypes`
Tytuł: Typy pojazdów
Opis: Słownik typów pojazdów określający sposób klasyfikacji obiektów we flocie. Definiuje typ biznesowy pojazdu, rodzaj formularza, zakładki użytkownika oraz wskazuje domyślny typ stosowany przy tworzeniu nowych pojazdów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BusinessType | `Soneta.Samochodowka.TypPojazdu` | bazodanowe, enum |  | Typ pojazdu |
| DefPageXml | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |
| Default | `bool` | bazodanowe | Domyślny | Określa, że jest to domyślny typ pojazdu. |
| DefaultLayoutXml | `Soneta.Business.MemoText` |  |  |  |
| DefinedType | `System.Type` |  |  |  |
| Form | `Soneta.Vehicles.Enums.VehicleFormType` | bazodanowe, enum | Rodzaj formularza | Określa sposób wyświetlania formularza |
| IsNetPage | `bool` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa typu pojazdu. |
| States | `Soneta.Business.LpSubTable<Soneta.Vehicles.Models.Database.Config.VehicleState>` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol typu pojazdu. |
| UserBookmarkName | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Xml | `Soneta.Business.MemoText` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypPojazdu (`Soneta.Samochodowka.TypPojazdu`)
- `Brak` = 0
- `SamochódDo900` = 1
- `SamochódPonad900` = 2
- `Motocykl` = 3
- `Motorower` = 4

### VehicleFormType (`Soneta.Vehicles.Enums.VehicleFormType`)
- `Standard` = 0 — Zwykły
- `User` = 1 — Użytkownika
