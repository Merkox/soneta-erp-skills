# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.GuidMap`
Nazwa tabeli: `GuidMaps`
Opis: Uniwersalne powiązanie między dwoma dowolnymi rekordami identyfikowanymi przez GUID. Umożliwia tworzenie typowanych relacji między obiektami z różnych modułów.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| From | `System.Guid` | bazodanowe |  |  |
| Tag | `int` | bazodanowe |  |  |
| To | `System.Guid` | bazodanowe |  |  |
| Type | `Soneta.Business.Db.GuidMapType` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GuidMapType (`Soneta.Business.Db.GuidMapType`)
- `SessionReader` = 2
