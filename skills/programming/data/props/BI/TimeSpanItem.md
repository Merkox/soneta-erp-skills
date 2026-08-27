# Pola i właściwości klasy biznesowej: `Soneta.BI.TimeSpanItem`
Nazwa tabeli: `TimeSpanItems`
Tytuł: Elementy zestawu przedziałów czasowych
Opis: Element szczegółowy zestawu przedziałów czasowych (TimeSpanSet). Wiąże konkretną definicję przedziału czasowego z zestawem, określając jej pozycję. Umożliwia składanie zestawów z wielu niezależnych definicji przedziałów.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `Soneta.BI.TimeSpanDefinition` | bazodanowe | Definicja |  |
| Lp | `int` | bazodanowe |  |  |
| Set | `Soneta.BI.TimeSpanSet` | bazodanowe, tylko-odczyt | Zestaw | Zestaw przedziałów czasowych |
