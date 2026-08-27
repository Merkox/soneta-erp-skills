# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.CatRolRelation`
Nazwa tabeli: `CatRolRelations`
Tytuł: Rola powiązana z kategorią.
Opis: Relacja wiele-do-wielu między kategoriami ról a rolami systemowymi. Przypisuje role do kategorii dla celów organizacji i prezentacji.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| RelatedRoleCategory | `Db.RoleCategory` | bazodanowe, tylko-odczyt | Kategoria roli | Kategoria, której przyporządkowana jest rola. |
| RelatedSystemRole | `Db.SystemRole` | bazodanowe, tylko-odczyt | Role | Rola, powiązana z kategorią. |
