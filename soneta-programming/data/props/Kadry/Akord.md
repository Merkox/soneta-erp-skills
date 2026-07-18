# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Akord`
Nazwa tabeli: `Akordy`
Opis: Akord przypisany do pracownika w ramach jednostki organizacyjnej. Łączy pracownika z definicją akordu, określając typ akordu, okres obowiązywania i wydział, w którym praca akordowa jest realizowana.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `AkordHistoria`
Implementuje interfejsy: `IBazaZrodlaWyplaty`
Selektor: pole `Typ` (`Soneta.Kadry.TypAkordu`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe |  |  |
| Dni | `DateSubTable<Soneta.Kalend.DzienAkorduBase>` | podlista |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| Historia | `HistorySubTable<Soneta.Kadry.AkordHistoria>` | podlista |  |  |
| Last | `Soneta.Kadry.AkordHistoria` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| PelnyOkres | `bool` | bazodanowe, tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Typ | `Soneta.Kadry.TypAkordu` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Zestawienia | `FromToSubTable<Soneta.Kalend.ZestawienieAkorduBase>` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Prosty` | 1 | `Soneta.Kadry.AkordProsty` | Akord |
| `Grupowy` | 2 | `Soneta.Kadry.AkordGrupowy` | Akord grupowy |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
