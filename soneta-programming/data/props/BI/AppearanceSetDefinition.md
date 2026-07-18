# Pola i właściwości klasy biznesowej: `Soneta.BI.AppearanceSetDefinition`
Nazwa tabeli: `AppSetDefs`
Tytuł: Zestawy barw
Opis: Nazwany zestaw barw (paleta kolorów) wykorzystywany w wizualizacjach BI. Grupuje definicje poszczególnych kolorów, które mogą być przypisywane do przedziałów danych lub serii na wykresach, zapewniając spójną kolorystykę analiz.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Items | `LpSubTable<Soneta.BI.AppearanceItemDefinition>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
