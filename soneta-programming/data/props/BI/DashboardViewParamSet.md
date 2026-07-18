# Pola i właściwości klasy biznesowej: `Soneta.BI.DashboardViewParamSet`
Nazwa tabeli: `DashParamSets`
Tytuł: Zestawy parametrów paneli BI
Opis: Nazwany zestaw parametrów panelu BI (DashboardView). Umożliwia zapisanie konfiguracji filtrów i parametrów raportu jako zestawu, który użytkownik może przełączać. Jeden z zestawów może być oznaczony jako domyślny.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DashboardView | `Db.DashboardView` | bazodanowe, tylko-odczyt |  |  |
| Default | `bool` | bazodanowe | Domyślny |  |
| Identity | `System.Guid` | bazodanowe |  |  |
| IdentityType | `string` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa zestawu |  |
| Params | `SubTable<Soneta.BI.DashboardViewParam>` | podlista |  |  |
