# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Budzetowanie.PlanVariantRel`
Nazwa tabeli: `PlanVariantsRel`
Tytuł: Definicje wersji planów dla Wariantu planów
Opis: Przypisanie definicji wersji planu do wariantu planów budżetowych. Określa, które typy wersji planów są dostępne w ramach danego wariantu budżetowania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefPlanVersion | `Soneta.Zadania.Budzetowanie.DefPlanVersion` | bazodanowe | Definicja wersji planu dostępna dla Wariantu planów |  |
| PlanVariant | `Soneta.Zadania.Budzetowanie.PlanVariant` | bazodanowe, tylko-odczyt | Wariant planów |  |
