# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProPlanPracy`
Nazwa tabeli: `ProPlanyPracy`
Tytuł: Plany pracy
Opis: Element szczegółowy zasobu operacji zlecenia (ProZasobOperacjiZlecenia). Definiuje zaplanowane okna czasowe pracy zasobu w ramach operacji zlecenia, określając daty i godziny rozpoczęcia oraz zakończenia poszczególnych bloków pracy służące do harmonogramowania produkcji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zasob` → `ProZasobOperacjiZlecenia`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `TimeSec` | tylko-odczyt |  | Czas planu pracy. |
| CzasRozpoczecia | `TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia planu pracy. |
| CzasZakonczenia | `TimeSec` |  | Czas zakończenia | Czas zakończenia planu pracy. |
| DataRozpoczecia | `Date` |  | Data rozpoczęcia | Data rozpoczęcia planu pracy. |
| DataZakonczenia | `Date` |  | Data zakończenia | Data zakończenia planu pracy. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa planu pracy. |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia planu pracy. |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia planu pracy. |
| Zasob | `Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia` | bazodanowe, guided-parent | Zasób | Zasób dla planu pracy. |
