# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PracownikWArchiwum`
Nazwa tabeli: `PracWArchiwum`
Tytuł: Pracownicy w archiwum
Opis: Element szczegółowy pracownika (Pracownik). Okres przebywania pracownika w archiwum, rejestrujący zakres dat, w których kartoteka pracownika była oznaczona jako archiwalna (nieaktywna).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
