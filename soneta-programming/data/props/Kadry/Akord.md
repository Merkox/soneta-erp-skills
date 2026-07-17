# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Akord`
Nazwa tabeli: `Akordy`
Opis: Akord przypisany do pracownika w ramach jednostki organizacyjnej. Łączy pracownika z definicją akordu, określając typ akordu, okres obowiązywania i wydział, w którym praca akordowa jest realizowana.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe |  |  |
| Dni | `Soneta.Business.DateSubTable<Soneta.Kalend.DzienAkorduBase>` |  |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Kadry.AkordHistoria>` |  |  |  |
| Last | `Soneta.Kadry.AkordHistoria` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PelnyOkres | `bool` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypAkordu` | bazodanowe, enum |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Zestawienia | `Soneta.Business.FromToSubTable<Soneta.Kalend.ZestawienieAkorduBase>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAkordu (`Soneta.Kadry.TypAkordu`)
- `Prosty` = 1
- `Grupowy` = 2
