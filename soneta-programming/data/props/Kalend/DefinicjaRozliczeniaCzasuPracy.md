# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaRozliczeniaCzasuPracy`
Nazwa tabeli: `DefRozlCzasPracy`
Tytuł: Definicje dokumentów rozliczenia czasu pracy
Opis: Konfigurowalna definicja dokumentu rozliczenia czasu pracy. Określa rodzaj rozliczenia, strefy zlecenia i rozliczenia nadgodzin, sposób numeracji oraz powiązanie z serią dokumentów.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| DoRozliczenia | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe | Do rozliczenia |  |
| IsZlecenie | `bool` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kalend.RodzajeRozliczeńCzasuPracy` | bazodanowe, enum |  |  |
| Rozliczenie | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe | Rozliczenie |  |
| Seria | `bool` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Weryfikatory | `Soneta.Business.SubTable<Soneta.Kalend.WeryfikatorRozliczeniaCzasuPracy>` |  |  |  |
| ZgodneDoRozliczenia | `bool` | bazodanowe |  |  |
| ZgodneRozliczenie | `bool` | bazodanowe |  |  |
| Zlecenie | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe | Zlecenie |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeRozliczeńCzasuPracy (`Soneta.Kalend.RodzajeRozliczeńCzasuPracy`)
- `Nieokreślony` = 0
- `Zlecenie` = 1 — Zlecenie pracy w nadgodzinach
- `RozliczenieWyjściaPrywatnego` = 2
- `Rozliczenie` = 3 — Wolne za nadgodziny
- `WniosekOWyjściePrywatne` = 4
- `WniosekOWyjścieSłużbowe` = 5
