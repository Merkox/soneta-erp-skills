# Pola i właściwości klasy biznesowej: `Soneta.Zadania.EtapWykonujacy`
Nazwa tabeli: `EtapyWykonujacy`
Tytuł: Operatorzy przypisani do etapów projektów
Opis: Przypisanie operatora do etapu projektu CRM. Umożliwia określenie, którzy operatorzy są odpowiedzialni za realizację poszczególnych etapów projektu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Etap | `Soneta.Zadania.EtapProjektu` | bazodanowe, tylko-odczyt |  |  |
| Operator | `App.Operator` | bazodanowe |  |  |
