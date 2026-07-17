# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaDokHanCenaInfo`
Nazwa tabeli: `PozHanCenaInfo`
Tytuł: Informacja o cenie pozycji dokumentu handlowego
Opis: Element szczegółowy pozycji dokumentu handlowego (PozycjaDokHandlowego). Przechowuje informacje o sposobie naliczenia ceny, definicji ceny i kierunku liczenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaDokHandlowego`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cena | `Soneta.Types.DoubleCy` | bazodanowe |  |  |
| Host | `Soneta.Business.IPozycjaDokHandlowegoCenaInfoHost` | bazodanowe |  |  |
| IndywidualnaDefinicjaCeny | `Soneta.Towary.DefinicjaCeny` | bazodanowe | Indywidualna definicja ceny |  |
| LiczonaOd | `Soneta.Handel.CenaLiczonaOd` | bazodanowe, enum | Cena liczona od |  |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe, guided-parent |  | Pozycja dokumentu handlowego. |
| Rodzaj | `Soneta.Handel.RodzajNaliczeniaCenyRabatu` | bazodanowe, enum | Rodzaj naliczenia ceny |  |
| SchematGratisow | `Soneta.Towary.SchemOpakowan` | bazodanowe | Schemat gratisów |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CenaLiczonaOd (`Soneta.Handel.CenaLiczonaOd`)
- `Niezdefiniowano` = 0
- `Netto` = 1
- `Brutto` = 2

### RodzajNaliczeniaCenyRabatu (`Soneta.Handel.RodzajNaliczeniaCenyRabatu`)
- `KartotekaTowarowa` = 0
- `Algorytm` = 1
- `IndywidualnyKazdegoTowaru` = 2 — Indywidualny każdego towaru
- `GrupowyKazdegoTowaru` = 3 — Grupowy każdego towaru
- `IndywidualnyGrupyTowarowej` = 4
- `GrupowyGrupyTowarowej` = 5
- `IndywidualnyWszystkichTowarow` = 6 — Indywidualny wszystkich towarów
- `GrupowyWszystkichTowarow` = 7 — Grupowy wszystkich towarów
- `OkresowyKazdegoTowaru` = 8 — Okresowy każdego towaru
- `PrzecenaOkresowa` = 9
- `Serwis` = 10
- `ZNadrzednejPozycji` = 11 — Z nadrzędnej pozycji
- `ZmianaPozycjiZatwierdzonegoDokumentu` = 12
- `RabatZaWczesniejszaPlatnosc` = 13 — Rabat za wcześniejszą płatność
