# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PozycjaObiektuAktualizacjiCzasu`
Nazwa tabeli: `PozObAktCzas`
Tytuł: Powiązania obiektu oraz pozycji aktualizacji czasu
Opis: Powiązanie obiektu do planowania z pozycją aktualizacji ewidencji czasu pracy. Łączy pozycję aktualizacji czasu z obiektem i czynnością, umożliwiając przypisanie czynności do obiektów w ramach aktualizacji ewidencji.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe, tylko-odczyt |  |  |
| ObiektAktualizacji | `Soneta.Kalend.ObiektAktualizacjiKalendarza` | bazodanowe, tylko-odczyt |  |  |
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiCzasu` | bazodanowe, tylko-odczyt |  |  |
