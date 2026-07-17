# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.SystemRole`
Nazwa tabeli: `SystemRoles`
Tytuł: Role systemowe
Opis: Rola systemowa definiująca zestaw praw dostępu. Może być pełna lub cząstkowa, systemowa lub użytkownika, i jest przypisywana do uprawnień (oddziałów praw).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IEntitle`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CompatibleWithVersion | `bool` |  |  |  |
| ConnectedRoles | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.ISystemRole>` |  |  |  |
| CurrentRole | `Soneta.Business.App.Role` |  |  |  |
| Destiny | `Soneta.Business.Db.SystemRoleDestiny` | bazodanowe, enum | Przeznaczenie |  |
| Entitles | `Soneta.Business.SubTable<Soneta.Business.Db.EntitleRef>` |  |  |  |
| Generation | `int` | bazodanowe | Generacja |  |
| History | `Soneta.Business.Internal.SchemaHistory` |  |  |  |
| IsSystem | `bool` | bazodanowe | Systemowa |  |
| LegacyRole | `Soneta.Business.App.Role` |  |  |  |
| LicModules | `Soneta.Business.Licence.LicencjaProgramu[]` |  |  |  |
| Locked | `bool` | bazodanowe | Blokada |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa roli |
| Parents | `Soneta.Business.SubTable<Soneta.Business.Db.SystemRoleRef>` |  |  |  |
| ParentsRoles | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.ISystemRole>` |  |  |  |
| Partial | `bool` | bazodanowe | Cząstkowa |  |
| Powiazane | `Soneta.Business.SubTable<Soneta.Business.Db.SystemRoleRef>` |  |  |  |
| RelatedRoleCategory | `Soneta.Business.SubTable<Soneta.Business.Db.CatRolRelation>` |  |  |  |
| Rights | `Soneta.Business.SubTable<Soneta.Business.Db.Right>` |  |  |  |
| Role | `Soneta.Business.App.Role` |  |  |  |
| RoleText | `Soneta.Business.MemoText` | bazodanowe |  |  |
| WszystkieNadrzędne | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.ISystemRole>` |  |  |  |
| WszystkiePowiązane | `System.Collections.Generic.IEnumerable<Soneta.Business.Db.ISystemRole>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SystemRoleDestiny (`Soneta.Business.Db.SystemRoleDestiny`)
- `Neutral` = 0 — Neutralna
- `Forms` = 1 — Dla operatorów
- `Net` = 2 — Dla pulpitów
- `Common` = 3 — Wszystkie
