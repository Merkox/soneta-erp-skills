# Pola i właściwości klasy biznesowej: `Soneta.Place.ZaniechaniePodatkowe`
Nazwa tabeli: `ZaniechPodatkowe`
Tytuł: Zaniechania podatkowe
Opis: Zaniechanie poboru zaliczki na podatek dochodowy dla pracownika. Rejestruje kwotę zwolnienia, numer decyzji i zakres stosowania (etat/umowa), pomniejszając naliczaną zaliczkę PIT.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Decyzja | `string` | bazodanowe |  |  |
| Etat | `bool` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Roczne | `bool` | bazodanowe |  |  |
| Umowa | `bool` | bazodanowe |  |  |
| Wartosc | `decimal` | bazodanowe |  |  |
