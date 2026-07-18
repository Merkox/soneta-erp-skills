# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.TypDzialalUcz`
Nazwa tabeli: `TypyDzialalUcz`
Tytuł: Typy działalności uczestników
Opis: Element szczegółowy uczestnika (TypDzialalUcz). Przypisuje typ działalności do konkretnego uczestnika, pozwalając na wielokrotne oznaczenie członka różnymi rodzajami działalności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `UczestnikBase` → `UczestnikBase`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| TypDzialalnosci | `Soneta.CzlonkowieSzkolenia.Config.TypDzialalnosci` | bazodanowe, tylko-odczyt |  |  |
| UczestnikBase | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
