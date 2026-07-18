# Pola i właściwości klasy biznesowej: `Soneta.Place.ZaniechaniePodatkowe`
Nazwa tabeli: `ZaniechPodatkowe`
Tytuł: Zaniechania podatkowe
Opis: Zaniechanie poboru zaliczki na podatek dochodowy dla pracownika. Rejestruje kwotę zwolnienia, numer decyzji i zakres stosowania (etat/umowa), pomniejszając naliczaną zaliczkę PIT.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Decyzja | `string` | bazodanowe |  |  |
| Etat | `bool` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Roczne | `bool` | bazodanowe, tylko-odczyt |  |  |
| Umowa | `bool` | bazodanowe |  |  |
| Wartosc | `decimal` | bazodanowe |  |  |
