# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PozycjaDefKregu`
Nazwa tabeli: `PozycjeDefKregow`
Tytuł: Definicje definicji kręgów
Opis: Element szczegółowy definicji kręgu kosztów (DefinicjaKregu). Określa pojedynczą pozycję kręgu wskazującą konto (lub filtr kont) i stronę księgowania (Winien/Ma), która powinna uczestniczyć w bilansowaniu kręgu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Definicja` → `DefinicjaKregu`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Ksiega.DefinicjaKregu` | bazodanowe, tylko-odczyt, guided-parent |  | Definicja kręgu |
| Konto | `string` | bazodanowe |  | Symbol lub filtr konta |
| Lp | `int` | bazodanowe |  |  |
| Strona | `Soneta.Core.StronaKsiegowania` (enum) | bazodanowe |  | Strona księgowania |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StronaKsiegowania (`Soneta.Core.StronaKsiegowania`)
- `Brak` = 0
- `Winien` = 1
- `Ma` = 2
