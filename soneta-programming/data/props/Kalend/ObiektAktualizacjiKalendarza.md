# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ObiektAktualizacjiKalendarza`
Nazwa tabeli: `ObAktKalend`
Tytuł: Powiązania obiektu oraz dokumentu aktualizacji kalendarza
Opis: Powiązanie obiektu do planowania z dokumentem aktualizacji kalendarza. Przypisuje obiekt (np. maszynę, stanowisko) do dokumentu aktualizacji, umożliwiając planowanie czasu pracy z uwzględnieniem zasobów.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Kalend.DokumentAktualizacjiKalendarza` | bazodanowe, tylko-odczyt |  |  |
| Obiekt | `Soneta.Kalend.ObiektDoPlanowania` | bazodanowe, tylko-odczyt |  |  |
