# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RoleCategory`
Nazwa tabeli: `RolesCategory`
Tytuł: Kategorie roli
Opis: Kategoria grupująca role systemowe. Umożliwia organizację ról w logiczne grupy ułatwiające zarządzanie uprawnieniami.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CategoryName | `string` | bazodanowe | Nazwa kategorii | Nazwa kategorii roli |
| Description | `string` | bazodanowe | Opis |  |
| RelatedRole | `SubTable<Db.CatRolRelation>` | podlista |  |  |
