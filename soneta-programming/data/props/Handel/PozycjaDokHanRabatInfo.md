# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaDokHanRabatInfo`
Nazwa tabeli: `PozHanRabatInfo`
Tytuł: Informacja o cenie pozycji dokumentu handlowego
Opis: Element szczegółowy pozycji dokumentu handlowego (PozycjaDokHandlowego). Przechowuje informacje o naliczonych rabatach: rodzaj, sposób naliczenia i wartość procentową.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pozycja` → `PozycjaDokHandlowego`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Business.IPozycjaDokHandlowegoRabatInfoHost` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  |  |
| Pozycja | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe, guided-parent |  | Pozycja dokumentu handlowego. |
| Rabat | `Soneta.Types.Percent` | bazodanowe |  |  |
| Rodzaj | `Soneta.Handel.RodzajNaliczeniaCenyRabatu` | bazodanowe, enum | Rodzaj naliczenia rabatu |  |
| Sposob | `Soneta.Towary.WliczanieRabatu` | bazodanowe, enum | Sposób naliczenia rabatu |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

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

### WliczanieRabatu (`Soneta.Towary.WliczanieRabatu`)
- `PrzepiszDoPozycjiDokumentu` = 0 — Przepisz do pozycji dokumentu
- `MaksymalnyRabatPozycjiDokumentu` = 1
- `MinimalnyRabatPozycjiDokumentu` = 2
- `SumujRabatyPozycjiDokumentu` = 3
- `NaliczajKolejnoRabatyPozycjiDokumentu` = 4
