# Pola i właściwości klasy biznesowej: `Soneta.CRM.Region`
Nazwa tabeli: `Regiony`
Tytuł: Regiony sprzedażowe
Opis: Słownik regionów sprzedażowych służący do grupowania planów i operatorów według obszarów geograficznych lub biznesowych. Umożliwia analizę i raportowanie sprzedaży w podziale na regiony.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`
Selektor: pole `Rodzaj` (`Soneta.CRM.Enums.RegionTypeEnum`) — wiele typów w jednej tabeli, podtypów: 7

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
| Rodzaj | `Soneta.CRM.Enums.RegionTypeEnum` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Custom` | 1 | `Soneta.CRM.CustomRegion` | Własne |
| `Country` | 2 | `Soneta.CRM.CountryRegion` | Kraj |
| `Voivodeship` | 3 | `Soneta.CRM.VoivodeshipRegion` | Województwo |
| `District` | 4 | `Soneta.CRM.DistrictRegion` | Powiat |
| `Municipality` | 5 | `Soneta.CRM.MunicipalityRegion` | Gmina |
| `City` | 6 | `Soneta.CRM.CityRegion` | Miejscowość |
| `PostalCode` | 7 | `Soneta.CRM.PostalCodeRegion` | Kod Pocztowy |

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
