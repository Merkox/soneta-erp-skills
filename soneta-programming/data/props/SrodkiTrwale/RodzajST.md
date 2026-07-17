# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.RodzajST`
Nazwa tabeli: `KRST`
Tytuł: Klasyfikacja Rodzajowa Środków Trwałych
Opis: Słownik klasyfikacji rodzajowej środków trwałych (KRŚT). Umożliwia przypisanie symbolu, stawki amortyzacji oraz powiązania z klasyfikacjami PKOB i PKWiU. Stanowi podstawę do prawidłowego naliczania odpisów amortyzacyjnych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Środek zablokowany |
| Grupa | `Soneta.SrodkiTrwale.RodzajST` |  |  |  |
| GrupaSymbol | `string` |  |  |  |
| IsGrupa | `bool` |  |  |  |
| IsPodgrupa | `bool` |  |  |  |
| IsRodzaj | `bool` |  |  |  |
| KRST91 | `string` | bazodanowe |  | Symbol wg klasyfikacji 1991 |
| KST2010 | `string` | bazodanowe |  | Symbol wg klasyfikacji 2010 |
| Kod | `string` |  |  |  |
| Opis | `string` | bazodanowe |  | Opis rodzaju środków trwałych |
| OpisPelny | `Soneta.Business.MemoText` | bazodanowe | Opis pełny | Opis pełny rodzaju środków trwałych |
| PKOB | `string` | bazodanowe |  | Państwowa Klasyfikacja Obiektów Budowlanych |
| PKWiU | `string` | bazodanowe |  | Państwowa Klasyfikacja Wyrobów i Usług |
| Podgrupa | `Soneta.SrodkiTrwale.RodzajST` |  |  |  |
| PodgrupaSymbol | `string` |  |  |  |
| Podstawa | `Soneta.SrodkiTrwale.PodstawaKST` | bazodanowe, enum | Rozporządzenie | Podstawa prawna klasyfikacji |
| StawkaDo | `Soneta.Types.Percent` | bazodanowe |  | Max. stwaka amortyzacji |
| StawkaOd | `Soneta.Types.Percent` | bazodanowe |  | Min. stwaka amortyzacji |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.SrodkiTrwale.TypSrodkaTrwalego` | bazodanowe, enum |  | Typ rodzaju środka trwałego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PodstawaKST (`Soneta.SrodkiTrwale.PodstawaKST`)
- `Brak` = 1
- `Rozporzadzenie2010` = 2 — 2010
- `Rozporzadzenie2016` = 3 — 2016

### TypSrodkaTrwalego (`Soneta.SrodkiTrwale.TypSrodkaTrwalego`)
- `Brak` = 0
- `ŚrodekTrwały` = 1
- `WartośćNiematerialnaIPrawna` = 2
- `Wyposażenie` = 3
