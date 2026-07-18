# Pola i właściwości klasy biznesowej: `Soneta.Oceny.UzasadnienieOceny`
Nazwa tabeli: `OcenyUzas`
Tytuł: Uzasadnienia oceny
Opis: Lista uzasadnień dostępnych dla elementu skali ocen. Pozwala określić listę predefiniowanych uzasadnień dostępnych do wyboru podczas uzupełniania oceny.
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
| ElementSkali | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe, tylko-odczyt |  |  |
| Uzasadnienie | `string` | bazodanowe |  |  |
