# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PozycjaObiektuAktualizacjiKalendarza`
Nazwa tabeli: `PozObAktKalend`
Tytuł: Powiązania obiektu oraz pozycji aktualizacji kalendarza
Opis: Powiązanie obiektu do planowania z pozycją aktualizacji kalendarza planu pracy. Łączy pozycję aktualizacji z obiektem i czynnością, umożliwiając przypisanie konkretnych czynności do obiektów w ramach aktualizacji planu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe, tylko-odczyt |  |  |
| ObiektAktualizacji | `Soneta.Kalend.ObiektAktualizacjiKalendarza` | bazodanowe, tylko-odczyt |  |  |
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiKalendarza` | bazodanowe, tylko-odczyt |  |  |
