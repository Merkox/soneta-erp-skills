# Pola i właściwości klasy biznesowej: `Soneta.CRM.Region`
Nazwa tabeli: `Regiony`
Tytuł: Regiony sprzedażowe
Opis: Słownik regionów sprzedażowych służący do grupowania planów i operatorów według obszarów geograficznych lub biznesowych. Umożliwia analizę i raportowanie sprzedaży w podziale na regiony.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Określa czy region jest zablokowany. |
| Kod | `string` | bazodanowe |  |  |
| Kontrahenci | `Soneta.Business.SubTable<Soneta.CRM.Kontrahent>` |  |  |  |
| Nadrzedny | `Soneta.CRM.Region` | bazodanowe | Nadrzędny |  |
| Nazwa | `string` | bazodanowe |  |  |
| Obszary | `Soneta.Business.SubTable<Soneta.CRM.RegionObszar>` |  |  |  |
| Opiekun | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| PlanySprzedazowe | `Soneta.Business.SubTable` |  |  |  |
| Podregiony | `Soneta.Business.SubTable<Soneta.CRM.Region>` |  |  |  |
| Rodzaj | `Soneta.CRM.Enums.RegionTypeEnum` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RegionTypeEnum (`Soneta.CRM.Enums.RegionTypeEnum`)
- `Custom` = 1 — Własne
- `Country` = 2 — Kraj
- `Voivodeship` = 3 — Województwo
- `District` = 4 — Powiat
- `Municipality` = 5 — Gmina
- `City` = 6 — Miejscowość
- `PostalCode` = 7 — Kod Pocztowy
