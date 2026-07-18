# Pola i właściwości klasy biznesowej: `Syncfusion.Windows.Forms.Tools.SystemInfo`
Nazwa tabeli: `SystemInfos`
Tytuł: Informacja systemowa
Opis: Przechowuje systemowe informacje konfiguracyjne identyfikowane unikalnym kluczem. Zawiera parametry wewnętrzne systemu, takie jak numery wersji i ustawienia globalne.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `MemoText` | bazodanowe, podlista |  |  |
| Ident | `Db.SysInfoIdentifier` (enum) | bazodanowe |  |  |
| Value | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SysInfoIdentifier (`Db.SysInfoIdentifier`)
- `Version` = 1
- `Name` = 2
- `Description1` = 3
- `Description2` = 4
- `Description3` = 5
- `Guid` = 7
- `NumerSeryjny` = 10
- `ConfigVersion` = 11
- `LocalLicence` = 12
- `ConversionInProgress` = 13
- `ConstraintsNotCreated` = 14
- `ConfigRefreshTime` = 15
- `App` = 16
- `VersionStart` = 100
- `VersionStop` = 199
- `DllsStart` = 200
- `DllsStop` = 299
- `BusinessIntegrity` = 500
- `TestBackupPath` = 600
- `AllowOtherExtensions` = 610
- `AllowRunWithoutExtensions` = 611
- `AddinsStart` = 700
- `AddinsStop` = 799
- `SendToAnalyze` = 801
- `IsFullTextSearchOn` = 802
- `SupportsFeaturesTables` = 900
