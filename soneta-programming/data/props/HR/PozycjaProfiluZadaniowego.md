# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Profile.Core.PozycjaProfiluZadaniowego`
Nazwa tabeli: `ZklPozProfilZdn`
Tytuł: Pozycje profilu zadaniowego
Opis: Pozwala na stworzenie wymagań i opisu zadań na danym stanowisku. Pozwala stworzyć profil zadań. Służy do operacyjnego opisu pracy dla stanowiska.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Lp | `int` | bazodanowe | Lp |  |
| Profil | `Soneta.HR.ZKL.Profile.Zadaniowy.ProfilZadaniowy` | bazodanowe |  |  |
| Uwagi | `string` | bazodanowe | Uwagi |  |
| Zadanie | `Soneta.HR.ZKL.Slowniki.Zadania.ZadanieZkl` | bazodanowe | Zadanie |  |
