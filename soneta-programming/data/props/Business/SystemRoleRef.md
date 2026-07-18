# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.SystemRoleRef`
Nazwa tabeli: `SystemRoleRefs`
Tytuł: Referencje roli
Opis: Powiązanie między rolami systemowymi. Umożliwia budowanie hierarchii ról, gdzie rola nadrzędna zawiera uprawnienia ról podrzędnych.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Role` → `SystemRole`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Connected | `Db.SystemRole` | bazodanowe, tylko-odczyt | Powiązana rola |  |
| Role | `Db.SystemRole` | bazodanowe, tylko-odczyt, guided-parent | Rola |  |
