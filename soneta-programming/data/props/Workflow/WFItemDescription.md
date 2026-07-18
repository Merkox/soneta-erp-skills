# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Config.WFItemDescription`
Nazwa tabeli: `WFItemDescs`
Tytuł: Komentarze do elementów workflow
Opis: Komentarz tekstowy dołączany do elementów diagramu procesu workflow w ramach danej definicji. Służy do dokumentowania i opisywania poszczególnych kroków, tranzycji lub innych elementów procesu przez projektanta.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Comment | `string` | bazodanowe | Komentarz | Komentarz do wskazanego elementu workflow |
| WFDefinition | `Soneta.Workflow.Config.WFDefinition` | bazodanowe, tylko-odczyt | Definicja procesu | Definicja procesu |
