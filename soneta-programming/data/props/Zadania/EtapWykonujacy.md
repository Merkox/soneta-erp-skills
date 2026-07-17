# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EtapWykonujacy`
Nazwa tabeli: `EtapyWykonujacy`
Tytuł: Operatorzy przypisani do etapów projektów
Opis: Przypisanie operatora do etapu projektu CRM. Umożliwia określenie, którzy operatorzy są odpowiedzialni za realizację poszczególnych etapów projektu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Etap | `Soneta.Zadania.EtapProjektu` | bazodanowe |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
