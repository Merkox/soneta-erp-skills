# Pola i właściwości klasy biznesowej: `Soneta.Config.Reg.ConfigRegistry`
Nazwa tabeli: `ConfigRegistries`
Tytuł: Rejestr konfiguracji
Opis: Tabela przechowuje wpisy rejestru konfiguracji systemu enova365. Każdy wpis zawiera nazwę, opis, dane w formacie JSON oraz informacje o wersji bazy danych i dacie utworzenia lub modyfikacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 2
- subrowy: 0
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DatabaseVersion | `string` | bazodanowe | Wersja bazy danych |  |
| DateCreated | `System.DateTime` | bazodanowe | Data utworzenia |  |
| DateModified | `System.DateTime` | bazodanowe | Data modyfikacji |  |
| Description | `MemoText` | bazodanowe, podlista | Opis |  |
| Json | `MemoText` | bazodanowe, podlista | Json |  |
| LastEditDate | `System.DateTime` | tylko-odczyt |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| RegType | `Soneta.Config.Reg.RegType` (enum) | bazodanowe | Typ rejestru |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RegType (`Soneta.Config.Reg.RegType`)
- `Backup` = 0
- `Operational` = 1
