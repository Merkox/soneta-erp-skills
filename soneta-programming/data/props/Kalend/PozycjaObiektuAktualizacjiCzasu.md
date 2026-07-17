# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PozycjaObiektuAktualizacjiCzasu`
Nazwa tabeli: `PozObAktCzas`
Tytuł: Powiązania obiektu oraz pozycji aktualizacji czasu
Opis: Powiązanie obiektu do planowania z pozycją aktualizacji ewidencji czasu pracy. Łączy pozycję aktualizacji czasu z obiektem i czynnością, umożliwiając przypisanie czynności do obiektów w ramach aktualizacji ewidencji.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| ObiektAktualizacji | `Soneta.Kalend.ObiektAktualizacjiKalendarza` | bazodanowe |  |  |
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiCzasu` | bazodanowe |  |  |
