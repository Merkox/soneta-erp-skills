# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.RodzajST`
Nazwa tabeli: `KRST`
Tytuł: Klasyfikacja Rodzajowa Środków Trwałych
Opis: Słownik klasyfikacji rodzajowej środków trwałych (KRŚT). Umożliwia przypisanie symbolu, stawki amortyzacji oraz powiązania z klasyfikacjami PKOB i PKWiU. Stanowi podstawę do prawidłowego naliczania odpisów amortyzacyjnych.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Typ` (`Soneta.SrodkiTrwale.TypSrodkaTrwalego`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Środek zablokowany |
| Grupa | `Soneta.SrodkiTrwale.RodzajST` | tylko-odczyt |  |  |
| GrupaSymbol | `string` | tylko-odczyt |  |  |
| IsGrupa | `bool` | tylko-odczyt |  |  |
| IsPodgrupa | `bool` | tylko-odczyt |  |  |
| IsRodzaj | `bool` | tylko-odczyt |  |  |
| KRST91 | `string` | bazodanowe |  | Symbol wg klasyfikacji 1991 |
| KST2010 | `string` | bazodanowe |  | Symbol wg klasyfikacji 2010 |
| Kod | `string` | tylko-odczyt |  |  |
| Opis | `string` | bazodanowe |  | Opis rodzaju środków trwałych |
| OpisPelny | `MemoText` | bazodanowe, podlista | Opis pełny | Opis pełny rodzaju środków trwałych |
| PKOB | `string` | bazodanowe |  | Państwowa Klasyfikacja Obiektów Budowlanych |
| PKWiU | `string` | bazodanowe |  | Państwowa Klasyfikacja Wyrobów i Usług |
| Podgrupa | `Soneta.SrodkiTrwale.RodzajST` | tylko-odczyt |  |  |
| PodgrupaSymbol | `string` | tylko-odczyt |  |  |
| Podstawa | `Soneta.SrodkiTrwale.PodstawaKST` (enum) | bazodanowe, tylko-odczyt | Rozporządzenie | Podstawa prawna klasyfikacji |
| StawkaDo | `Percent` | bazodanowe |  | Max. stwaka amortyzacji |
| StawkaOd | `Percent` | bazodanowe |  | Min. stwaka amortyzacji |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.SrodkiTrwale.TypSrodkaTrwalego` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ rodzaju środka trwałego |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `ŚrodekTrwały` | 1 | `Soneta.SrodkiTrwale.RodzajSrodkaTrwalego` | Rodzaj środka trwałego |
| `WartośćNiematerialnaIPrawna` | 2 | `Soneta.SrodkiTrwale.RodzajWartosciNiematerialnejIPrawnej` | Rodzaj wartości niematerialnej i prawnej |

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
