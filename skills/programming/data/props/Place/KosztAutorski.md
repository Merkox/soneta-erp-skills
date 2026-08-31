# Pola i właściwości klasy biznesowej: `Soneta.Place.KosztAutorski`
Nazwa tabeli: `KosztyAutorskie`
Tytuł: Koszty autorskie
Opis: Ewidencja kosztów uzyskania przychodów z tytułu praw autorskich (50% KUP) pracownika. Rejestruje kwotę lub procent podstawy oraz czas pracy twórczej, wpływając na naliczanie podatku dochodowego.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasPrzepracowany | `Time` | bazodanowe | Czas przepracowany |  |
| CzasPrzepracowanyKorygowany | `bool` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| GodzBezKUP50 | `Time` | bazodanowe | Godziny bez KUP50 |  |
| GodzKUP50 | `Time` | bazodanowe | Godziny KUP50 |  |
| Kwota | `decimal` | bazodanowe | Podstawa |  |
| Miesiąc | `YearMonth` |  |  |  |
| Opis | `string` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Procent | `Percent` | bazodanowe | Podstawa |  |
| WspolczynnikKUP50 | `Percent` | tylko-odczyt |  |  |
