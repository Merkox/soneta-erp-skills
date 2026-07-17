# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Zadania.CzynnoscZadania`
Nazwa tabeli: `ZklCzynnZadan`
Tytuł: Czynności zadań
Opis: Opisuje czynności składowe realizowane w ramach zadania. Pozwala na szczegółowe modelowanie pracy i analizę nakładu oraz odpowiedzialności.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Zadanie | `Soneta.HR.ZKL.Slowniki.Zadania.ZadanieZkl` | bazodanowe | Zadanie czynności |  |
