# Pola i właściwości klasy biznesowej: `Soneta.Core.Substitute.SubstituteUser`
Nazwa tabeli: `SubstituteUsers`
Tytuł: Zastępstwa
Opis: Zastępstwo użytkownika w systemie. Określa zastępującego, zastępowanego, okres zastępstwa, uprawnienia zastępującego, definicję zastępstwa, stan oraz poziom przejmowanych obowiązków (bezpośredni lub kaskadowy).
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EndDate | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Data zakończenia |
| FromTo | `Soneta.Types.FromTo` | bazodanowe | Okres | Okres |
| IsActive | `bool` |  |  |  |
| IsCompleted | `bool` |  |  |  |
| IsExpectant | `bool` |  |  |  |
| IsVisibleStateForSubstitution | `bool` |  |  |  |
| LevelOfReplacement | `Soneta.Core.Substitute.LevelOfReplacement` | bazodanowe, enum | Przejmowane obowiązki | Określa czy zastępujący przejmuje tylko obowiązki zastępowanego, czy także osób które on zastępuje |
| Replaced | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Zastępowany | Określa zastępowanego |
| Replacement | `Soneta.Business.ITaskUser` | bazodanowe, iface-ref | Zastępujący | Określa zastępującego |
| SelectedEntitles | `Soneta.Business.Db.OperatorEntitle[]` | bazodanowe | Wybrane uprawnienia zastępującego | Określa wybrane uprawnienia zastępującego |
| StateForSubstitution | `Soneta.Core.Substitute.StateForSubstitution` | bazodanowe, enum | Stan | Stan |
| SubstituteAuthority | `Soneta.Business.App.Operator` | bazodanowe | Uprawnienia zastępującego | Określa uprawnienia zastępującego |
| SubstituteDef | `Soneta.Core.Substitute.SubstituteDef` | bazodanowe | Definicja zastępstwa | Definicja zastępstwa powiązana z zastępstwem |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Replaced | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| Replacement | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### LevelOfReplacement (`Soneta.Core.Substitute.LevelOfReplacement`)
- `OnlyReplaced` = 0 — Tylko Zastępowanego
- `AllLevels` = 1 — Zastępowanego oraz jemu przekazane

### StateForSubstitution (`Soneta.Core.Substitute.StateForSubstitution`)
- `Entered` = 0 — Wprowadzony
- `Active` = 1 — Aktywny
- `Expectant` = 2 — Oczekujący
- `Cancelled` = 3 — Anulowany
- `Completed` = 4 — Zakończony
- `All` = 5 — Razem
