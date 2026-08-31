# Pola i właściwości klasy biznesowej: `Soneta.Place.OświadczenieZusOpieka`
Nazwa tabeli: `OswiadZusOpieka`
Tytuł: Oświadczenia do zasiłku opiekuńczego
Opis: Oświadczenie pracownika wymagane do przyznania zasiłku opiekuńczego z ZUS. Rejestruje dane opiekuna, podopiecznego i liczbę wykorzystanych dni opieki w poszczególnych kategoriach wiekowych.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DzieckoChoreDo14lat | `int` | bazodanowe |  |  |
| DzieckoDo8lat | `int` | bazodanowe |  |  |
| DzieckoDo8tygodna | `int` | bazodanowe |  |  |
| DzieckoNiepelnospDo18lat | `int` | bazodanowe |  |  |
| Limit14 | `int` | tylko-odczyt |  |  |
| Limit30 | `int` | tylko-odczyt |  |  |
| Limit60 | `int` | tylko-odczyt |  |  |
| Opiekun | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| Podopieczny | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| PozostaliChorzy | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
