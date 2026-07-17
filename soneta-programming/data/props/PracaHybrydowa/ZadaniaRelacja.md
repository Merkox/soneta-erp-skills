# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.ZadaniaRelacja`
Nazwa tabeli: `ZadRelacje`
Tytuł: Relacje Zadań pracy hybrydowej
Opis: Powiązania między zadaniami w kontekście pracy hybrydowej. Umożliwia definiowanie zależności (np. poprzedzanie, blokowanie) między zadaniami z kontrolą poprawności łączenia.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| PowiazaneIsEnded | `string` |  |  |  |
| RelacjaTyp | `Soneta.PracaZdalna.Enums.ZadaniaRelacjaTyp` | bazodanowe, enum |  |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| ZadaniePowiazane | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ZadaniaRelacjaTyp (`Soneta.PracaZdalna.Enums.ZadaniaRelacjaTyp`)
- `Blocking` = 1 — Następujący
- `BlockedBy` = 2 — Poprzedzający
- `Related` = 3 — Powiązany
