# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.EntitleRole`
Nazwa tabeli: `EntitleRoles`
Tytuł: Role uprawnienia
Opis: Przypisanie roli systemowej do uprawnienia (oddziału praw). Określa zestaw praw dostępu obowiązujący w danym oddziale.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Entitle` → `Entitle`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Entitle | `Soneta.Business.App.Entitle` | bazodanowe, guided-parent |  | Uprawnienia, którym dana rola została przypisana. |
| Role | `Soneta.Business.App.Role` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  |  |
