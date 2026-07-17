# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.CatRolRelation`
Nazwa tabeli: `CatRolRelations`
Tytuł: Rola powiązana z kategorią.
Opis: Relacja wiele-do-wielu między kategoriami ról a rolami systemowymi. Przypisuje role do kategorii dla celów organizacji i prezentacji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| RelatedRoleCategory | `Soneta.Business.Db.RoleCategory` | bazodanowe | Kategoria roli | Kategoria, której przyporządkowana jest rola. |
| RelatedSystemRole | `Soneta.Business.Db.SystemRole` | bazodanowe | Role | Rola, powiązana z kategorią. |
