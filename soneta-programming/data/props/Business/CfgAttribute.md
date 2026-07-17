# Pola i właściwości klasy biznesowej: `Soneta.Config.CfgAttribute`
Nazwa tabeli: `CfgAttributes`
Tytuł: Dane konfiguracji
Opis: Atrybut (wartość) przypisany do węzła konfiguracji. Przechowuje nazwę, typ i wartość pojedynczego ustawienia konfiguracyjnego.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Node` → `CfgNode`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BinaryValue | `Soneta.Business.MemoBin` |  |  |  |
| MemoValue | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Name | `string` | bazodanowe |  |  |
| Node | `Soneta.Config.CfgNode` | bazodanowe, guided-parent |  |  |
| StrValue | `string` | bazodanowe |  |  |
| Type | `Soneta.Config.AttributeType` | bazodanowe, enum |  |  |
| Value | `object` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AttributeType (`Soneta.Config.AttributeType`)
- `_null` = 0
- `_string` = 1 — Napis
- `_int` = 2 — Liczba całkowita
- `_date` = 3 — Data
- `_datetime` = 4 — Data i czas
- `_boolean` = 6 — Warunek
- `_double` = 7 — Liczba rzeczywista
- `_decimal` = 8 — Kwota
- `_FromTo` = 9 — Okres dat
- `_YearMonth` = 10 — Miesiąc
- `_Fraction` = 11 — Ułamek
- `_time` = 12 — Czas
- `_currency` = 13 — Kwota w walucie
- `_percent` = 14 — Procent
- `_text` = 15
- `_binary` = 16
- `_guid` = 17
