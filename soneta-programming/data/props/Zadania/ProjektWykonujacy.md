# Pola i właściwości klasy biznesowej: `Soneta.Zadania.ProjektWykonujacy`
Nazwa tabeli: `ProjektyWyk`
Tytuł: Wykonujący projekty
Opis: Przypisanie operatora jako wykonawcy projektu CRM. Umożliwia wskazanie zespołu operatorów zaangażowanych w realizację danego projektu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Operator | `App.Operator` | bazodanowe |  |  |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe, tylko-odczyt |  |  |
