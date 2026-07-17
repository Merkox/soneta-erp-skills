# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.PlanowanieZasobow.Definicje.DefinicjaPlanowaniaZasobow`
Nazwa tabeli: `DefPlanZasob`
Tytuł: Definicje planowania zasobów
Opis: Słownik definicji dokumentów planowania zasobów w module ZKL. Stanowi szablon konfiguracyjny określający sposób tworzenia i przeliczania dokumentów planowania zasobów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada |  |
| DefinicjaProcesu | `System.Guid` | bazodanowe |  |  |
| DependentWfDefinition | `Soneta.Business.IDependentWfDefinition` |  |  |  |
| Korekta | `bool` | bazodanowe | Korekta | Flaga określająca czy definicja przeznaczona jest dla korekty |
| Nazwa | `string` | bazodanowe | Nazwa |  |
