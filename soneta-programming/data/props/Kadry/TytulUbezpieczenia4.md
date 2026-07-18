# Pola i właściwości klasy biznesowej: `Soneta.Kadry.TytulUbezpieczenia4`
Nazwa tabeli: `TytulyUbezpiecz4`
Tytuł: Tytuły ubezpieczenia
Opis: Słownik tytułów ubezpieczenia społecznego i zdrowotnego zgodnych z klasyfikacją ZUS. Określa kod tytułu, okres obowiązywania oraz rodzaje wymaganych ubezpieczeń (emerytalne, rentowe, chorobowe, wypadkowe, zdrowotne).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 1
- subrowy: 0
- razem: 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CalyOpis | `string` | tylko-odczyt |  |  |
| Chorobowe | `Soneta.Kadry.TypUbezpieczenia` (enum) | bazodanowe |  |  |
| Dotyczy | `Soneta.Kadry.UbezpieczenieDotyczy` (enum) | bazodanowe |  |  |
| Emerytalne | `Soneta.Kadry.TypUbezpieczenia` (enum) | bazodanowe |  |  |
| Kategoria | `string` | bazodanowe |  |  |
| Kod | `int` | bazodanowe |  |  |
| KodText | `string` | tylko-odczyt | Kod |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `string` | tylko-odczyt | Opis |  |
| Opis1 | `string` | bazodanowe |  |  |
| Opis2 | `string` | bazodanowe |  |  |
| Opis3 | `string` | bazodanowe |  |  |
| Opis4 | `string` | bazodanowe |  |  |
| OpisS | `string` | tylko-odczyt | Opis |  |
| Platnik | `Soneta.Kadry.PłatnikSkładek` (enum) | bazodanowe |  |  |
| PodmiotPodstawowy | `int` | tylko-odczyt |  |  |
| Rentowe | `Soneta.Kadry.TypUbezpieczenia` (enum) | bazodanowe |  |  |
| Rozszerzenie | `int` | tylko-odczyt |  |  |
| Wypadkowe | `Soneta.Kadry.TypUbezpieczenia` (enum) | bazodanowe |  |  |
| Zdrowotne | `Soneta.Kadry.TypUbezpieczenia` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PłatnikSkładek (`Soneta.Kadry.PłatnikSkładek`)
- `Standardowy` = 0 — Standardowy
- `Pracownik` = 1
- `Chałupnik` = 2
- `Ubezpieczony` = 3
- `Płatnik` = 4
- `Duchowny` = 5
- `Zakonnik` = 6
- `Budżet` = 7
- `Prokurator` = 8
- `Sędzia` = 9
- `UbezpieczonyRefundacja` = 10
- `PłatnikZusUbezpieczonyZdrow` = 11
- `Doktorant` = 12

### TypUbezpieczenia (`Soneta.Kadry.TypUbezpieczenia`)
- `Brak` = 0
- `Obowiazkowe` = 1
- `Dobrowolne` = 2

### UbezpieczenieDotyczy (`Soneta.Kadry.UbezpieczenieDotyczy`)
- `Inny` = 0
- `Pracownik` = 1
- `Uczen` = 2
- `Zleceniobiorca` = 3
- `Wlasciciel` = 4
- `OsobaWspolpracujaca` = 5
