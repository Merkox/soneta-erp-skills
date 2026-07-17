# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.EntitleRef`
Nazwa tabeli: `EntitleRefs`
Tytuł: Referencje uprawnień
Opis: Powiązanie uprawnienia (oddziału praw) z rolą systemową. Określa, która rola jest przypisana do danego uprawnienia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Entitle` → `Entitle`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Entitle | `Soneta.Business.App.Entitle` | bazodanowe, guided-parent | Uprawnienie |  |
| Role | `Soneta.Business.Db.SystemRole` | bazodanowe | Powiązana rola |  |
