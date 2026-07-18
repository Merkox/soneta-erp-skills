# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Akord`
Nazwa tabeli: `Akordy`
Opis: Akord przypisany do pracownika w ramach jednostki organizacyjnej. Łączy pracownika z definicją akordu, określając typ akordu, okres obowiązywania i wydział, w którym praca akordowa jest realizowana.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `AkordHistoria`
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 5
- subrowy: 0
- razem: 11

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
| Typ | `Soneta.Kadry.TypAkordu` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Zestawienia | `FromToSubTable<Soneta.Kalend.ZestawienieAkorduBase>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
