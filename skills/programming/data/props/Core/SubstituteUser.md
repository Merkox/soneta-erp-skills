# Pola i właściwości klasy biznesowej: `Soneta.Core.Substitute.SubstituteUser`
Nazwa tabeli: `SubstituteUsers`
Tytuł: Zastępstwa
Opis: Zastępstwo użytkownika w systemie. Określa zastępującego, zastępowanego, okres zastępstwa, uprawnienia zastępującego, definicję zastępstwa, stan oraz poziom przejmowanych obowiązków (bezpośredni lub kaskadowy).
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| EndDate | `Date` | bazodanowe | Data zakończenia | Data zakończenia |
| FromTo | `FromTo` | bazodanowe, podlista | Okres | Okres |
| IsActive | `bool` | tylko-odczyt |  |  |
| IsCompleted | `bool` | tylko-odczyt |  |  |
| IsExpectant | `bool` | tylko-odczyt |  |  |
| IsVisibleStateForSubstitution | `bool` | tylko-odczyt |  |  |
| LevelOfReplacement | `Soneta.Core.Substitute.LevelOfReplacement` (enum) | bazodanowe | Przejmowane obowiązki | Określa czy zastępujący przejmuje tylko obowiązki zastępowanego, czy także osób które on zastępuje |
| Replaced | `ITaskUser` | bazodanowe, iface-ref | Zastępowany | Określa zastępowanego |
| Replacement | `ITaskUser` | bazodanowe, iface-ref | Zastępujący | Określa zastępującego |
| SelectedEntitles | `Db.OperatorEntitle[]` | bazodanowe, podlista | Wybrane uprawnienia zastępującego | Określa wybrane uprawnienia zastępującego |
| StateForSubstitution | `Soneta.Core.Substitute.StateForSubstitution` (enum) | bazodanowe | Stan | Stan |
| SubstituteAuthority | `App.Operator` | bazodanowe | Uprawnienia zastępującego | Określa uprawnienia zastępującego |
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
