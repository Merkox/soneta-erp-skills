# Pola i właściwości klasy biznesowej: `Soneta.CRM.Region`
Nazwa tabeli: `Regiony`
Tytuł: Regiony sprzedażowe
Opis: Słownik regionów sprzedażowych służący do grupowania planów i operatorów według obszarów geograficznych lub biznesowych. Umożliwia analizę i raportowanie sprzedaży w podziale na regiony.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 5
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Określa czy region jest zablokowany. |
| Kod | `string` | bazodanowe |  |  |
| Kontrahenci | `SubTable<Soneta.CRM.Kontrahent>` | podlista |  |  |
| Nadrzedny | `Soneta.CRM.Region` | bazodanowe | Nadrzędny |  |
| Nazwa | `string` | bazodanowe |  |  |
| Obszary | `SubTable<Soneta.CRM.RegionObszar>` | podlista |  |  |
| Opiekun | `App.Operator` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| PlanySprzedazowe | `SubTable` | podlista |  |  |
| Podregiony | `SubTable<Soneta.CRM.Region>` | podlista |  |  |
| Rodzaj | `Soneta.CRM.Enums.RegionTypeEnum` (enum) | bazodanowe, tylko-odczyt |  |  |

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
