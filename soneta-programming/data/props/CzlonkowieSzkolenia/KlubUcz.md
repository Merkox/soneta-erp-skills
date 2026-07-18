# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.KlubUcz`
Nazwa tabeli: `KlubyUcz`
Tytuł: Kluby/koła uczestników
Opis: Element szczegółowy uczestnika (KlubUcz). Rejestruje przynależność członka do klubu lub koła, umożliwiając przypisanie uczestnika do wielu jednostek organizacyjnych jednocześnie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `UczestnikBase` → `UczestnikBase`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Klub | `Soneta.CzlonkowieSzkolenia.Config.Klub` | bazodanowe, tylko-odczyt |  |  |
| UczestnikBase | `Soneta.CzlonkowieSzkolenia.UczestnikBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
