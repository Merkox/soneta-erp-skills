# Pola i właściwości klasy biznesowej: `Soneta.Oceny.SkalaOcen`
Nazwa tabeli: `SkaleOcen`
Tytuł: Skale ocen
Opis: Definicja skali używanej do oceniania w arkuszach ocen. Określa rodzaj skali (np. punktowa, opisowa), możliwość wielowyboru z limitami zaznaczeń oraz parametry wyświetlania, stanowiąc podstawę systemu oceniania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 5
- podlisty: 2
- subrowy: 0
- razem: 18

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
| Rodzaj | `Soneta.Oceny.RodzajeSkalOcen` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
| UdostepnijZalaczniki | `bool` | bazodanowe |  |  |
| Wielowybor | `bool` | bazodanowe | Wielowybór |  |
| WielowyborMax | `int` | bazodanowe | Maksymalna liczba zaznaczeń |  |
| WielowyborMin | `int` | bazodanowe | Minimalna liczba zaznaczeń |  |
| WielowyborMinMaxInfo | `string` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeSkalOcen (`Soneta.Oceny.RodzajeSkalOcen`)
- `Standardowa` = 1
- `Opisowa` = 2
- `WgWykonania` = 3

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
