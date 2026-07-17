# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Permissions.UserGroupMember`
Nazwa tabeli: `UserGroupMembers`
Tytuł: Członkowie grupy użytkowników
Opis: Członkostwo w grupie użytkowników. ŝączy operatora lub inny podmiot autoryzowany z grupą i umożliwia blokowanie przynależności.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `UserGroup` → `UserGroup`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Locked | `bool` | bazodanowe | Zablokowany | Określa czy członek grupy użytkowników jest zablokowany |
| Member | `Soneta.Business.Db.Permissions.IAuthorised` | bazodanowe, iface-ref | Członek | Określa członka grupy użytkowników |
| UserGroup | `Soneta.Business.Db.Permissions.UserGroup` | bazodanowe, guided-parent | Grupa użytkowników | Określa grupę użytkowników |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Member | `IAuthorised` | `Operator`, `UserGroup` |
