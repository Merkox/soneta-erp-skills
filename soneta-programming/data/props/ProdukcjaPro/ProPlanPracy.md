# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProPlanPracy`
Nazwa tabeli: `ProPlanyPracy`
Tytuł: Plany pracy
Opis: Element szczegółowy zasobu operacji zlecenia (ProZasobOperacjiZlecenia). Definiuje zaplanowane okna czasowe pracy zasobu w ramach operacji zlecenia, określając daty i godziny rozpoczęcia oraz zakończenia poszczególnych bloków pracy służące do harmonogramowania produkcji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zasob` → `ProZasobOperacjiZlecenia`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.TimeSec` |  |  | Czas planu pracy. |
| CzasRozpoczecia | `Soneta.Types.TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia planu pracy. |
| CzasZakonczenia | `Soneta.Types.TimeSec` |  | Czas zakończenia | Czas zakończenia planu pracy. |
| DataRozpoczecia | `Soneta.Types.Date` |  | Data rozpoczęcia | Data rozpoczęcia planu pracy. |
| DataZakonczenia | `Soneta.Types.Date` |  | Data zakończenia | Data zakończenia planu pracy. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa planu pracy. |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia planu pracy. |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia planu pracy. |
| Zasob | `Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia` | bazodanowe, guided-parent | Zasób | Zasób dla planu pracy. |
