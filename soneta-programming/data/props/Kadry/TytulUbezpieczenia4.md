# Pola i właściwości klasy biznesowej: `Soneta.Kadry.TytulUbezpieczenia4`
Nazwa tabeli: `TytulyUbezpiecz4`
Tytuł: Tytuły ubezpieczenia
Opis: Słownik tytułów ubezpieczenia społecznego i zdrowotnego zgodnych z klasyfikacją ZUS. Określa kod tytułu, okres obowiązywania oraz rodzaje wymaganych ubezpieczeń (emerytalne, rentowe, chorobowe, wypadkowe, zdrowotne).
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CalyOpis | `string` |  |  |  |
| Chorobowe | `Soneta.Kadry.TypUbezpieczenia` | bazodanowe, enum |  |  |
| Dotyczy | `Soneta.Kadry.UbezpieczenieDotyczy` | bazodanowe, enum |  |  |
| Emerytalne | `Soneta.Kadry.TypUbezpieczenia` | bazodanowe, enum |  |  |
| Kategoria | `string` | bazodanowe |  |  |
| Kod | `int` | bazodanowe |  |  |
| KodText | `string` |  | Kod |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `string` |  | Opis |  |
| Opis1 | `string` | bazodanowe |  |  |
| Opis2 | `string` | bazodanowe |  |  |
| Opis3 | `string` | bazodanowe |  |  |
| Opis4 | `string` | bazodanowe |  |  |
| OpisS | `string` |  | Opis |  |
| Platnik | `Soneta.Kadry.PłatnikSkładek` | bazodanowe, enum |  |  |
| PodmiotPodstawowy | `int` |  |  |  |
| Rentowe | `Soneta.Kadry.TypUbezpieczenia` | bazodanowe, enum |  |  |
| Rozszerzenie | `int` |  |  |  |
| Wypadkowe | `Soneta.Kadry.TypUbezpieczenia` | bazodanowe, enum |  |  |
| Zdrowotne | `Soneta.Kadry.TypUbezpieczenia` | bazodanowe, enum |  |  |

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
