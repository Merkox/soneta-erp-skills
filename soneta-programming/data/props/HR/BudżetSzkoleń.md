# Pola i właściwości klasy biznesowej: `Soneta.HR.BudżetSzkoleń`
Nazwa tabeli: `BudzetySzkolen`
Tytuł: Budżety szkoleń
Opis: Budżet przeznaczony na szkolenia w ramach jednostki organizacyjnej. Umożliwia planowanie i kontrolę wydatków szkoleniowych, porównując plan z realizacją i zaplanowanymi kosztami.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Plan | `Currency` | bazodanowe |  |  |
| Pozostaje | `Currency` | tylko-odczyt |  |  |
| Realizacja | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Szkolenia | `SubTable<Soneta.HR.RealizacjaSzkolenia>` | podlista |  |  |
| WnioskiOSzkolenia | `SubTable<Soneta.HR.WniosekOSzkolenie>` | podlista |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe, tylko-odczyt | Jednostka organizacyjna |  |
| Wykonany | `bool` | bazodanowe |  |  |
| Zaplanowane | `Currency` | bazodanowe, tylko-odczyt |  |  |
