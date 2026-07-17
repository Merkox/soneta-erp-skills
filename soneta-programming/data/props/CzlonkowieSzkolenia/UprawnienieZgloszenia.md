# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.UprawnienieZgloszenia`
Nazwa tabeli: `UprawZglosz`
Tytuł: Uprawnienie zgłoszenia
Opis: Uprawnienia zawodowe generowane na podstawie ukończonego szkolenia. Łączy zgłoszenie uczestnika z uprawnieniem pracowniczym, które zostaje nadane po pozytywnym zakończeniu kursu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Uprawnienie | `Soneta.HR.UprawnieniePracownika` | bazodanowe |  |  |
| Zgloszenie | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |
