# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.TypDzialalUcz`
Nazwa tabeli: `TypyDzialalUcz`
Tytuł: Typy działalności uczestników
Opis: Element szczegółowy uczestnika (TypDzialalUcz). Przypisuje typ działalności do konkretnego uczestnika, pozwalając na wielokrotne oznaczenie członka różnymi rodzajami działalności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `UczestnikBase` → `UczestnikBase`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| TypDzialalnosci | `Soneta.CzlonkowieSzkolenia.Config.TypDzialalnosci` | bazodanowe |  |  |
| UczestnikBase | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe, guided-parent |  |  |
