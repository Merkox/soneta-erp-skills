# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RoleCategory`
Nazwa tabeli: `RolesCategory`
Tytuł: Kategorie roli
Opis: Kategoria grupująca role systemowe. Umożliwia organizację ról w logiczne grupy ułatwiające zarządzanie uprawnieniami.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CategoryName | `string` | bazodanowe | Nazwa kategorii | Nazwa kategorii roli |
| Description | `string` | bazodanowe | Opis |  |
| RelatedRole | `Soneta.Business.SubTable<Soneta.Business.Db.CatRolRelation>` |  |  |  |
