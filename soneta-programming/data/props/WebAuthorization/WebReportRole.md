# Pola i właściwości klasy biznesowej: `Soneta.Web.Business.App.WebReportRole`
Nazwa tabeli: `WebReportRoles`
Tytuł: Role raportu
Opis: Element szczegółowy raportu webowego (WebReport). Przypisuje rolę uprawnień do raportu, kontrolując które grupy użytkowników mogą go wyświetlać. Jeden raport może mieć wiele przypisanych ról.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Report` → `WebReport`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Report | `Soneta.Web.Business.App.WebReport` | bazodanowe, guided-parent |  | Raport do którego przypisano rolę |
| Role | `Soneta.Business.App.Role` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  |  |
