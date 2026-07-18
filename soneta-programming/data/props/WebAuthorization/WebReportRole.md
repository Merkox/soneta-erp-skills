# Pola i właściwości klasy biznesowej: `Soneta.Web.Business.App.WebReportRole`
Nazwa tabeli: `WebReportRoles`
Tytuł: Role raportu
Opis: Element szczegółowy raportu webowego (WebReport). Przypisuje rolę uprawnień do raportu, kontrolując które grupy użytkowników mogą go wyświetlać. Jeden raport może mieć wiele przypisanych ról.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Report` → `WebReport`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Report | `Soneta.Web.Business.App.WebReport` | bazodanowe, tylko-odczyt, guided-parent |  | Raport do którego przypisano rolę |
| Role | `App.Role` | tylko-odczyt |  |  |
| RoleGuid | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
