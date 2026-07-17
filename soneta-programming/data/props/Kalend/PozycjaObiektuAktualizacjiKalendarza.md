# Pola i właściwości klasy biznesowej: `Soneta.Kalend.PozycjaObiektuAktualizacjiKalendarza`
Nazwa tabeli: `PozObAktKalend`
Tytuł: Powiązania obiektu oraz pozycji aktualizacji kalendarza
Opis: Powiązanie obiektu do planowania z pozycją aktualizacji kalendarza planu pracy. Łączy pozycję aktualizacji z obiektem i czynnością, umożliwiając przypisanie konkretnych czynności do obiektów w ramach aktualizacji planu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| ObiektAktualizacji | `Soneta.Kalend.ObiektAktualizacjiKalendarza` | bazodanowe |  |  |
| Pozycja | `Soneta.Kalend.PozycjaAktualizacjiKalendarza` | bazodanowe |  |  |
