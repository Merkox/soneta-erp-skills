# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProKompetencja`
Nazwa tabeli: `ProKompetencje`
Tytuł: Właściwości produkcyjne
Opis: Słownik właściwości (kompetencji) produkcyjnych przypisywanych do zasobów. Definiuje wymagania kwalifikacyjne i parametry techniczne zasobów, takie jak umiejętności operatorów czy parametry maszyn, wykorzystywane przy doborze zasobów do operacji produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie właściwości. |
| Kod | `string` | bazodanowe |  | Kod właściwości. |
| Nazwa | `string` | bazodanowe |  | Nazwa właściwości. |
| Ograniczenie | `bool` | bazodanowe |  | Ograniczenie listy operatorów porównań dla właściwości. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis właściwości. |
| Pozycje | `LpSubTable<Soneta.ProdukcjaPro.ProPozycjaKompetencji>` | podlista |  |  |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` (enum) | bazodanowe | Rodzaj zasobu | Rodzaj zasobu dla właściwości. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRodzajZasobu (`Soneta.ProdukcjaPro.ProRodzajZasobu`)
- `None` = 0
- `GniazdoProdukcyjne` = 1 — Gniazdo produkcyjne
- `JednostkaRobocza` = 2 — Jednostka robocza
- `Narzedzie` = 4 — Narzędzie
- `Kooperacja` = 8 — Kooperacja
- `All` = 15 — Wszystkie
