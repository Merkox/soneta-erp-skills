# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.Models.Database.Config.VehicleType`
Nazwa tabeli: `VehicleTypes`
Tytuł: Typy pojazdów
Opis: Słownik typów pojazdów określający sposób klasyfikacji obiektów we flocie. Definiuje typ biznesowy pojazdu, rodzaj formularza, zakładki użytkownika oraz wskazuje domyślny typ stosowany przy tworzeniu nowych pojazdów.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BusinessType | `Soneta.Samochodowka.TypPojazdu` (enum) | bazodanowe |  | Typ pojazdu |
| DefPageXml | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika. |  |
| Default | `bool` | bazodanowe | Domyślny | Określa, że jest to domyślny typ pojazdu. |
| DefaultLayoutXml | `MemoText` | podlista |  |  |
| DefinedType | `System.Type` | tylko-odczyt |  |  |
| Form | `Soneta.Vehicles.Enums.VehicleFormType` (enum) | bazodanowe | Rodzaj formularza | Określa sposób wyświetlania formularza |
| IsNetPage | `bool` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa typu pojazdu. |
| States | `LpSubTable<Soneta.Vehicles.Models.Database.Config.VehicleState>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol typu pojazdu. |
| UserBookmarkName | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Xml | `MemoText` | podlista |  |  |

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
