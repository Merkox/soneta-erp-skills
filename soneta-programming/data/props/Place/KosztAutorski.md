# Pola i właściwości klasy biznesowej: `Soneta.Place.KosztAutorski`
Nazwa tabeli: `KosztyAutorskie`
Tytuł: Koszty autorskie
Opis: Ewidencja kosztów uzyskania przychodów z tytułu praw autorskich (50% KUP) pracownika. Rejestruje kwotę lub procent podstawy oraz czas pracy twórczej, wpływając na naliczanie podatku dochodowego.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasPrzepracowany | `Soneta.Types.Time` | bazodanowe | Czas przepracowany |  |
| CzasPrzepracowanyKorygowany | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| GodzBezKUP50 | `Soneta.Types.Time` | bazodanowe | Godziny bez KUP50 |  |
| GodzKUP50 | `Soneta.Types.Time` | bazodanowe | Godziny KUP50 |  |
| Kwota | `decimal` | bazodanowe | Podstawa |  |
| Miesiąc | `Soneta.Types.YearMonth` |  |  |  |
| Opis | `string` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Procent | `Soneta.Types.Percent` | bazodanowe | Podstawa |  |
| WspolczynnikKUP50 | `Soneta.Types.Percent` |  |  |  |
