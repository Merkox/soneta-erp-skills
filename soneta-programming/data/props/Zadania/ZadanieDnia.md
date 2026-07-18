# Pola i właściwości klasy biznesowej: `Soneta.Zadania.PracaZdalna.ZadaniaDnia.Models.ZadanieDnia`
Nazwa tabeli: `ZadaniaDnia`
Opis: Lista zadań przypisanych operatorowi na dany dzień. Umożliwia planowanie i śledzenie codziennych zadań do wykonania z datą ich dodania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `System.DateTime` | bazodanowe | Data dodania | Data dodania zadania |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
