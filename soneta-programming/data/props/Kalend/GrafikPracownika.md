# Pola i właściwości klasy biznesowej: `Soneta.Kalend.GrafikPracownika`
Nazwa tabeli: `GrafPracownikow`
Tytuł: Grafiki pracowników
Opis: Powiązanie pracownika z grafikiem pracy. Przypisuje pracownika do konkretnego grafiku harmonogramu, umożliwiając planowanie czasu pracy w ramach zespołu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Grafik | `Soneta.Kalend.GrafikPracy` | bazodanowe, tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
