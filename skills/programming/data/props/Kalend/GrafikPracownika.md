# Pola i właściwości klasy biznesowej: `Soneta.Kalend.GrafikPracownika`
Nazwa tabeli: `GrafPracownikow`
Tytuł: Grafiki pracowników
Opis: Powiązanie pracownika z grafikiem pracy. Przypisuje pracownika do konkretnego grafiku harmonogramu, umożliwiając planowanie czasu pracy w ramach zespołu.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Grafik | `Soneta.Kalend.GrafikPracy` | bazodanowe, tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
