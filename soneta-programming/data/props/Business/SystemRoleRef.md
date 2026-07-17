# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.SystemRoleRef`
Nazwa tabeli: `SystemRoleRefs`
Tytuł: Referencje roli
Opis: Powiązanie między rolami systemowymi. Umożliwia budowanie hierarchii ról, gdzie rola nadrzędna zawiera uprawnienia ról podrzędnych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Role` → `SystemRole`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Connected | `Soneta.Business.Db.SystemRole` | bazodanowe | Powiązana rola |  |
| Role | `Soneta.Business.Db.SystemRole` | bazodanowe, guided-parent | Rola |  |
