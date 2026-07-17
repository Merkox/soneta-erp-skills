# Pola i właściwości klasy biznesowej: `Soneta.Oceny.SkalaOcen`
Nazwa tabeli: `SkaleOcen`
Tytuł: Skale ocen
Opis: Definicja skali używanej do oceniania w arkuszach ocen. Określa rodzaj skali (np. punktowa, opisowa), możliwość wielowyboru z limitami zaznaczeń oraz parametry wyświetlania, stanowiąc podstawę systemu oceniania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Calkowite | `bool` | bazodanowe |  |  |
| DlugoscPola | `int` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Oceny.ElementSkaliOcen>` |  |  |  |
| Indywidualny | `bool` | bazodanowe | Szablon indywidualny |  |
| Info | `string` |  |  |  |
| Max | `decimal` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| PytanieGraficzne | `bool` | bazodanowe |  |  |
| PytanieZalezne | `bool` | bazodanowe |  |  |
| Rodzaj | `Soneta.Oceny.RodzajeSkalOcen` | bazodanowe, enum |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
| UdostepnijZalaczniki | `bool` | bazodanowe |  |  |
| Wielowybor | `bool` | bazodanowe | Wielowybór |  |
| WielowyborMax | `int` | bazodanowe | Maksymalna liczba zaznaczeń |  |
| WielowyborMin | `int` | bazodanowe | Minimalna liczba zaznaczeń |  |
| WielowyborMinMaxInfo | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeSkalOcen (`Soneta.Oceny.RodzajeSkalOcen`)
- `Standardowa` = 1
- `Opisowa` = 2
- `WgWykonania` = 3

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
