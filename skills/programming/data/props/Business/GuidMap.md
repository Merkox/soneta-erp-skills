# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.GuidMap`
Nazwa tabeli: `GuidMaps`
Opis: Uniwersalne powiązanie między dwoma dowolnymi rekordami identyfikowanymi przez GUID. Umożliwia tworzenie typowanych relacji między obiektami z różnych modułów.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| From | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| Tag | `int` | bazodanowe |  |  |
| To | `System.Guid` | bazodanowe, tylko-odczyt |  |  |
| Type | `Db.GuidMapType` (enum) | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GuidMapType (`Db.GuidMapType`)
- `SessionReader` = 2
