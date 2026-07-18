# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RoleCategory`
Nazwa tabeli: `RolesCategory`
Tytuł: Kategorie roli
Opis: Kategoria grupująca role systemowe. Umożliwia organizację ról w logiczne grupy ułatwiające zarządzanie uprawnieniami.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CategoryName | `string` | bazodanowe | Nazwa kategorii | Nazwa kategorii roli |
| Description | `string` | bazodanowe | Opis |  |
| RelatedRole | `SubTable<Db.CatRolRelation>` | podlista |  |  |
