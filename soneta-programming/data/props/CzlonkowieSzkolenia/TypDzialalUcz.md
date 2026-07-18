# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.TypDzialalUcz`
Nazwa tabeli: `TypyDzialalUcz`
Tytuł: Typy działalności uczestników
Opis: Element szczegółowy uczestnika (TypDzialalUcz). Przypisuje typ działalności do konkretnego uczestnika, pozwalając na wielokrotne oznaczenie członka różnymi rodzajami działalności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `UczestnikBase` → `UczestnikBase`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| TypDzialalnosci | `Soneta.CzlonkowieSzkolenia.Config.TypDzialalnosci` | bazodanowe, tylko-odczyt |  |  |
| UczestnikBase | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
