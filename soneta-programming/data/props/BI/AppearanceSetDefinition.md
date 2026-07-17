# Pola i właściwości klasy biznesowej: `Soneta.BI.AppearanceSetDefinition`
Nazwa tabeli: `AppSetDefs`
Tytuł: Zestawy barw
Opis: Nazwany zestaw barw (paleta kolorów) wykorzystywany w wizualizacjach BI. Grupuje definicje poszczególnych kolorów, które mogą być przypisywane do przedziałów danych lub serii na wykresach, zapewniając spójną kolorystykę analiz.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 1
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Items | `Soneta.Business.LpSubTable<Soneta.BI.AppearanceItemDefinition>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
