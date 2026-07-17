# Pola i właściwości klasy biznesowej: `Soneta.Config.Reg.ConfigRegistry`
Nazwa tabeli: `ConfigRegistries`
Tytuł: Rejestr konfiguracji
Opis: Tabela przechowuje wpisy rejestru konfiguracji systemu enova365. Każdy wpis zawiera nazwę, opis, dane w formacie JSON oraz informacje o wersji bazy danych i dacie utworzenia lub modyfikacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DatabaseVersion | `string` | bazodanowe | Wersja bazy danych |  |
| DateCreated | `System.DateTime` | bazodanowe | Data utworzenia |  |
| DateModified | `System.DateTime` | bazodanowe | Data modyfikacji |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis |  |
| Json | `Soneta.Business.MemoText` | bazodanowe | Json |  |
| LastEditDate | `System.DateTime` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| RegType | `Soneta.Config.Reg.RegType` | bazodanowe, enum | Typ rejestru |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RegType (`Soneta.Config.Reg.RegType`)
- `Backup` = 0
- `Operational` = 1
