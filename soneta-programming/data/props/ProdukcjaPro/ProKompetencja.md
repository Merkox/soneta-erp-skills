# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProKompetencja`
Nazwa tabeli: `ProKompetencje`
Tytuł: Właściwości produkcyjne
Opis: Słownik właściwości (kompetencji) produkcyjnych przypisywanych do zasobów. Definiuje wymagania kwalifikacyjne i parametry techniczne zasobów, takie jak umiejętności operatorów czy parametry maszyn, wykorzystywane przy doborze zasobów do operacji produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie właściwości. |
| Kod | `string` | bazodanowe |  | Kod właściwości. |
| Nazwa | `string` | bazodanowe |  | Nazwa właściwości. |
| Ograniczenie | `bool` | bazodanowe |  | Ograniczenie listy operatorów porównań dla właściwości. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis właściwości. |
| Pozycje | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProPozycjaKompetencji>` |  |  |  |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` | bazodanowe, enum | Rodzaj zasobu | Rodzaj zasobu dla właściwości. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRodzajZasobu (`Soneta.ProdukcjaPro.ProRodzajZasobu`)
- `None` = 0
- `GniazdoProdukcyjne` = 1 — Gniazdo produkcyjne
- `JednostkaRobocza` = 2 — Jednostka robocza
- `Narzedzie` = 4 — Narzędzie
- `Kooperacja` = 8 — Kooperacja
- `All` = 15 — Wszystkie
