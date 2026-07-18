# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.Permissions.UserGroup`
Nazwa tabeli: `UserGroups`
Tytuł: Grupy użytkowników
Opis: Grupa użytkowników do zarządzania uprawnieniami na poziomie rekordów. Umożliwia zbiorowe przypisywanie praw dostępu do obiektów biznesowych.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IAuthorised`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 3
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Locked | `bool` | bazodanowe | Zablokowana | Określa czy grupa użytkowników jest zablokowana |
| Members | `SubTable<Db.Permissions.UserGroupMember>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa | Określa nazwę grupy użytkowników |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| UserGroupMembers | `SubTable<Db.Permissions.UserGroupMember>` | podlista |  |  |
