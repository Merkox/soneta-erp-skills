# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Permissions.UserGroup`
Nazwa tabeli: `UserGroups`
Tytuł: Grupy użytkowników
Opis: Grupa użytkowników do zarządzania uprawnieniami na poziomie rekordów. Umożliwia zbiorowe przypisywanie praw dostępu do obiektów biznesowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IAuthorised`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Locked | `bool` | bazodanowe | Zablokowana | Określa czy grupa użytkowników jest zablokowana |
| Members | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.UserGroupMember>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa | Określa nazwę grupy użytkowników |
| Permissions | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.RecordPermission>` |  |  |  |
| UserGroupMembers | `Soneta.Business.SubTable<Soneta.Business.Db.Permissions.UserGroupMember>` |  |  |  |
