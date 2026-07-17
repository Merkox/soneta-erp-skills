# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardViewParamSet`
Nazwa tabeli: `DashParamSets`
Tytuł: Zestawy parametrów paneli BI
Opis: Nazwany zestaw parametrów panelu BI (DashboardView). Umożliwia zapisanie konfiguracji filtrów i parametrów raportu jako zestawu, który użytkownik może przełączać. Jeden z zestawów może być oznaczony jako domyślny.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DashboardView | `Soneta.Business.Db.DashboardView` | bazodanowe |  |  |
| Default | `bool` | bazodanowe | Domyślny |  |
| Identity | `System.Guid` | bazodanowe |  |  |
| IdentityType | `string` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa zestawu |  |
| Params | `Soneta.Business.SubTable<Soneta.BI.DashboardViewParam>` |  |  |  |
