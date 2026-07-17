# Pola i właściwości klasy biznesowej: `Soneta.HR.BudżetSzkoleń`
Nazwa tabeli: `BudzetySzkolen`
Tytuł: Budżety szkoleń
Opis: Budżet przeznaczony na szkolenia w ramach jednostki organizacyjnej. Umożliwia planowanie i kontrolę wydatków szkoleniowych, porównując plan z realizacją i zaplanowanymi kosztami.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Plan | `Soneta.Types.Currency` | bazodanowe |  |  |
| Pozostaje | `Soneta.Types.Currency` |  |  |  |
| Realizacja | `Soneta.Types.Currency` | bazodanowe |  |  |
| Szkolenia | `Soneta.Business.SubTable<Soneta.HR.RealizacjaSzkolenia>` |  |  |  |
| WnioskiOSzkolenia | `Soneta.Business.SubTable<Soneta.HR.WniosekOSzkolenie>` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wykonany | `bool` | bazodanowe |  |  |
| Zaplanowane | `Soneta.Types.Currency` | bazodanowe |  |  |
