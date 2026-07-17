# Pola i właściwości klasy biznesowej: `Syncfusion.Windows.Forms.Tools.SystemInfo`
Nazwa tabeli: `SystemInfos`
Tytuł: Informacja systemowa
Opis: Przechowuje systemowe informacje konfiguracyjne identyfikowane unikalnym kluczem. Zawiera parametry wewnętrzne systemu, takie jak numery wersji i ustawienia globalne.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Ident | `Soneta.Business.Db.SysInfoIdentifier` | bazodanowe, enum |  |  |
| Value | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SysInfoIdentifier (`Soneta.Business.Db.SysInfoIdentifier`)
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
