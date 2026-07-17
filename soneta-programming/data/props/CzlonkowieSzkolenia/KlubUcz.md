# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.KlubUcz`
Nazwa tabeli: `KlubyUcz`
Tytuł: Kluby/koła uczestników
Opis: Element szczegółowy uczestnika (KlubUcz). Rejestruje przynależność członka do klubu lub koła, umożliwiając przypisanie uczestnika do wielu jednostek organizacyjnych jednocześnie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `UczestnikBase` → `UczestnikBase`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Klub | `Soneta.CzlonkowieSzkolenia.Config.Klub` | bazodanowe |  |  |
| UczestnikBase | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe, guided-parent |  |  |
