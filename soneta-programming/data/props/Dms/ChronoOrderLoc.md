# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.IK.ChronoOrderLoc`
Nazwa tabeli: `ChronoOrderLocs`
Tytuł: Lokalizacje składów
Opis: Zawiera dane dotyczące lokalizacji składów chronologicznych w module DMS. Lokalizacje składów są powiązane z tabelą ChronoOrders i służą do określania lokalizacji składów chronologicznych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IPermissionClient`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Access | `Soneta.Workflow.Enums.AccessEnum` (enum) | bazodanowe | Dostęp | Dostęp do lokalizacji składu |
| Active | `bool` | bazodanowe | Aktywny | Aktywna lokalizacja składów |
| Creator | `App.Operator` | bazodanowe, tylko-odczyt | Założył | Operator, który założył lokalizację składu |
| Localization | `Soneta.CRM.Lokalizacja` | bazodanowe |  |  |
| Name | `string` | bazodanowe | Nazwa | Nazwa lokalizacji składów |
| Permissions | `SubTable<Db.Permissions.RecordPermission>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol lokalizacji składów |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AccessEnum (`Soneta.Workflow.Enums.AccessEnum`)
- `Public` = 0 — Publiczny - dostępny w całości
- `PartialPublic` = 1 — Publiczny - dostępny częściowo
- `Private` = 2 — Niepubliczny
