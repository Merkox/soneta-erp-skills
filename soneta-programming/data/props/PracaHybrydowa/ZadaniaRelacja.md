# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.ZadaniaRelacja`
Nazwa tabeli: `ZadRelacje`
Tytuł: Relacje Zadań pracy hybrydowej
Opis: Powiązania między zadaniami w kontekście pracy hybrydowej. Umożliwia definiowanie zależności (np. poprzedzanie, blokowanie) między zadaniami z kontrolą poprawności łączenia.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| PowiazaneIsEnded | `string` | tylko-odczyt |  |  |
| RelacjaTyp | `Soneta.PracaZdalna.Enums.ZadaniaRelacjaTyp` (enum) | bazodanowe, tylko-odczyt |  |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| ZadaniePowiazane | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ZadaniaRelacjaTyp (`Soneta.PracaZdalna.Enums.ZadaniaRelacjaTyp`)
- `Blocking` = 1 — Następujący
- `BlockedBy` = 2 — Poprzedzający
- `Related` = 3 — Powiązany
