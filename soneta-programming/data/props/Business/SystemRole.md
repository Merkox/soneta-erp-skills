# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.SystemRole`
Nazwa tabeli: `SystemRoles`
Tytuł: Role systemowe
Opis: Rola systemowa definiująca zestaw praw dostępu. Może być pełna lub cząstkowa, systemowa lub użytkownika, i jest przypisywana do uprawnień (oddziałów praw).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IEntitle`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 6
- podlisty: 11
- subrowy: 0
- razem: 22

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CompatibleWithVersion | `bool` | tylko-odczyt |  |  |
| ConnectedRoles | `System.Collections.Generic.IEnumerable<Db.ISystemRole>` | podlista |  |  |
| CurrentRole | `App.Role` | tylko-odczyt |  |  |
| Destiny | `Db.SystemRoleDestiny` (enum) | bazodanowe | Przeznaczenie |  |
| Entitles | `SubTable<Db.EntitleRef>` | podlista |  |  |
| Generation | `int` | bazodanowe, tylko-odczyt | Generacja |  |
| History | `Internal.SchemaHistory` |  |  |  |
| IsSystem | `bool` | bazodanowe, tylko-odczyt | Systemowa |  |
| LegacyRole | `App.Role` | tylko-odczyt |  |  |
| LicModules | `Licence.LicencjaProgramu[]` | podlista |  |  |
| Locked | `bool` | bazodanowe | Blokada |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa roli |
| Parents | `SubTable<Db.SystemRoleRef>` | podlista |  |  |
| ParentsRoles | `System.Collections.Generic.IEnumerable<Db.ISystemRole>` | podlista |  |  |
| Partial | `bool` | bazodanowe | Cząstkowa |  |
| Powiazane | `SubTable<Db.SystemRoleRef>` | podlista |  |  |
| RelatedRoleCategory | `SubTable<Db.CatRolRelation>` | podlista |  |  |
| Rights | `SubTable<Db.Right>` | podlista |  |  |
| Role | `App.Role` | tylko-odczyt |  |  |
| RoleText | `MemoText` | bazodanowe, podlista |  |  |
| WszystkieNadrzędne | `System.Collections.Generic.IEnumerable<Db.ISystemRole>` | podlista |  |  |
| WszystkiePowiązane | `System.Collections.Generic.IEnumerable<Db.ISystemRole>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SystemRoleDestiny (`Db.SystemRoleDestiny`)
- `Neutral` = 0 — Neutralna
- `Forms` = 1 — Dla operatorów
- `Net` = 2 — Dla pulpitów
- `Common` = 3 — Wszystkie
