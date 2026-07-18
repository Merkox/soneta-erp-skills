# Pola i właściwości klasy biznesowej: `Soneta.Oceny.SkalaOcen`
Nazwa tabeli: `SkaleOcen`
Tytuł: Skale ocen
Opis: Definicja skali używanej do oceniania w arkuszach ocen. Określa rodzaj skali (np. punktowa, opisowa), możliwość wielowyboru z limitami zaznaczeń oraz parametry wyświetlania, stanowiąc podstawę systemu oceniania.
Tabela konfiguracyjna: Tak
Guided: root
Selektor: pole `Rodzaj` (`Soneta.Oceny.RodzajeSkalOcen`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Calkowite | `bool` | bazodanowe |  |  |
| DlugoscPola | `int` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Oceny.ElementSkaliOcen>` | podlista |  |  |
| Indywidualny | `bool` | bazodanowe | Szablon indywidualny |  |
| Info | `string` | tylko-odczyt |  |  |
| Max | `decimal` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| PytanieGraficzne | `bool` | bazodanowe |  |  |
| PytanieZalezne | `bool` | bazodanowe |  |  |
| Rodzaj | `Soneta.Oceny.RodzajeSkalOcen` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| UdostepnijZalaczniki | `bool` | bazodanowe |  |  |
| Wielowybor | `bool` | bazodanowe | Wielowybór |  |
| WielowyborMax | `int` | bazodanowe | Maksymalna liczba zaznaczeń |  |
| WielowyborMin | `int` | bazodanowe | Minimalna liczba zaznaczeń |  |
| WielowyborMinMaxInfo | `string` | tylko-odczyt |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standardowa` | 1 | `Soneta.Oceny.SkalaOcenStandardowa` | Standardowa skala ocen |
| `Opisowa` | 2 | `Soneta.Oceny.SkalaOcenOpisowa` | Opisowa skala ocen |
| `WgWykonania` | 3 | `Soneta.Oceny.SkalaOcenWgWykonania` | Skala ocen wg wykonania |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeSkalOcen (`Soneta.Oceny.RodzajeSkalOcen`)
- `Standardowa` = 1
- `Opisowa` = 2
- `WgWykonania` = 3

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
