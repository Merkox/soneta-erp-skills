# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PozycjaObiektuAktualizacjiCzasu`
Nazwa tabeli: `PozObAktCzas`
Tytuł: Powiązania obiektu oraz pozycji aktualizacji czasu
Opis: Powiązanie obiektu do planowania z pozycją aktualizacji ewidencji czasu pracy. Łączy pozycję aktualizacji czasu z obiektem i czynnością, umożliwiając przypisanie czynności do obiektów w ramach aktualizacji ewidencji.
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
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiCzasu` | bazodanowe, tylko-odczyt |  |  |
