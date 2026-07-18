# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.EntitleRole`
Nazwa tabeli: `EntitleRoles`
Tytuł: Role uprawnienia
Opis: Przypisanie roli systemowej do uprawnienia (oddziału praw). Określa zestaw praw dostępu obowiązujący w danym oddziale.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Entitle` → `Entitle`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Entitle | `App.Entitle` | bazodanowe, tylko-odczyt, guided-parent |  | Uprawnienia, którym dana rola została przypisana. |
| Role | `App.Role` | tylko-odczyt |  |  |
| RoleGuid | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
