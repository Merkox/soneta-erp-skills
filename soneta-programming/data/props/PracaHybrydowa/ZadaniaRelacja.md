# Pola i właściwości klasy biznesowej: `Soneta.PracaZdalna.ZadaniaRelacja`
Nazwa tabeli: `ZadRelacje`
Tytuł: Relacje Zadań pracy hybrydowej
Opis: Powiązania między zadaniami w kontekście pracy hybrydowej. Umożliwia definiowanie zależności (np. poprzedzanie, blokowanie) między zadaniami z kontrolą poprawności łączenia.
Tabela konfiguracyjna: Nie
Selektor: pole `RelacjaTyp` (`Soneta.PracaZdalna.Enums.ZadaniaRelacjaTyp`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| PowiazaneIsEnded | `string` | tylko-odczyt |  |  |
| RelacjaTyp | `Soneta.PracaZdalna.Enums.ZadaniaRelacjaTyp` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |
| ZadaniePowiazane | `Soneta.Zadania.Zadanie` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `RelacjaTyp`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Blocking` | 1 | `Soneta.PracaZdalna.ZadaniaRelacjaNastepujaca` | Zadanie następujące |
| `BlockedBy` | 2 | `Soneta.PracaZdalna.ZadaniaRelacjaPoprzedzajaca` | Zadanie poprzedzające |
| `Related` | 3 | `Soneta.PracaZdalna.ZadaniaRelacjaPowiazane` | Zadanie powiązane |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ZadaniaRelacjaTyp (`Soneta.PracaZdalna.Enums.ZadaniaRelacjaTyp`)
- `Blocking` = 1 — Następujący
- `BlockedBy` = 2 — Poprzedzający
- `Related` = 3 — Powiązany
