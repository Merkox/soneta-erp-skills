# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Config.DefinicjaRozliczeniaMediow`
Nazwa tabeli: `DefRozMediow`
Tytuł: Definicje rozliczeń mediów nieruchomości
Opis: Słownik definicji rozliczeń mediów określający zasady generowania dokumentów handlowych za zużycie mediów. Konfiguruje rodzaj rozliczenia, domyślny dokument i magazyn, okres rozliczeniowy, odbiorcę oraz źródła usług i stawek.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmUslugi | `Soneta.RealEstate.AlgorytmUslugi` (subrow) | bazodanowe |  | Algorytm dla definicji rozliczenia mediów nieruchomości |
| AlgorytmUslugi.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmUslugi.Kod | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje rozliczenia mediów nieruchomości nie będą wyświetlane w liście wyboru. |
| ClassName | `string` | tylko-odczyt |  |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| DefinicjaDokHandlowego | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja dokumentu handlowego | Domyślna definicja dokumentu handlowego generowanego dla tego rozliczenia |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| DomyslnaUslugaLicz | `bool` | bazodanowe | Pobierz domyślną usługę licznika |  |
| DomyslnaUslugaNieruch | `bool` | bazodanowe | Pobierz domyślną usługę nieruchomości |  |
| KodAlgorytmu | `MemoText` | podlista |  |  |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe | Domyślny magazyn | Określa domyślny magazyn. |
| Namespace | `object` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna definicji rozliczenia mediów nieruchomości |
| Odbiorca | `Soneta.RealEstate.Enums.MediaSettlementRecipient` (enum) | bazodanowe | Odbiorca | Określa odbiorcę dokumentu rozliczenia. |
| Okres | `int` | bazodanowe | Domyślny okres | Określa domyślny okres rozliczenia |
| Opis | `string` | bazodanowe | Opis | Opis definicji rozliczenia mediów nieruchomości |
| OsobnyDlaObiektu | `bool` | bazodanowe | Osobny dokument dla każdego obiektu | Określa czy wystawiać osobny dokument dla każdego obiektu. |
| Rodzaj | `Soneta.RealEstate.Enums.MediaSettlementKind` (enum) | bazodanowe | Rodzaj rozliczania | Określa rodzaj rozliczenia. |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol definicji rozliczenia mediów nieruchomości |
| UslugiLicz | `bool` | bazodanowe | Pobierz usługi licznika |  |
| UslugiNieruch | `bool` | bazodanowe | Pobierz usługi nieruchomości |  |
| Wedlug | `Soneta.RealEstate.Enums.MediaSettlementBy` (enum) | bazodanowe | Rozliczenie według | Określa typ nieruchomości rozliczanych. |
| ZapisZero | `bool` | bazodanowe | Zapisuj rozliczenia z zerową ilością |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### MediaSettlementBy (`Soneta.RealEstate.Enums.MediaSettlementBy`)
- `ByPremises` = 0 — Wg lokali
- `ByBuildings` = 1 — Wg budynków

### MediaSettlementKind (`Soneta.RealEstate.Enums.MediaSettlementKind`)
- `Monthly` = 0 — Miesięczne
- `Periodic` = 1 — Okresowe

### MediaSettlementRecipient (`Soneta.RealEstate.Enums.MediaSettlementRecipient`)
- `Owner` = 0 — Właściciel
- `Manager` = 1 — Zarządca
