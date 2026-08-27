# Moduł `RealEstate` — tabele biznesowe

- Opis: Moduł zarządzania nieruchomościami. Zawiera kartotekę nieruchomości, lokali, najemców, umowy najmu, rozliczenia mediów oraz mechanizmy fakturowania opłat.
- Tabel: **19**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| CelRezerwacji | Cele rezerwacji | `CeleRezerwacji` | konfig | root |  |  |  | [CelRezerwacji.md](CelRezerwacji.md) |
| DefinicjaAlgorytmuUslugi | Definicje algorytmów usług nieruchomości | `DefAlgUslug` | konfig | root |  |  |  | [DefinicjaAlgorytmuUslugi.md](DefinicjaAlgorytmuUslugi.md) |
| DefinicjaRozliczeniaMediow | Definicje rozliczeń mediów nieruchomości | `DefRozMediow` | konfig | root |  | IRightsSource |  | [DefinicjaRozliczeniaMediow.md](DefinicjaRozliczeniaMediow.md) |
| NieruSrTrwalyRel | Relacje nieruchomości do środków trwałych | `NieruSrTrwaleRel` |  |  |  |  |  | [NieruSrTrwalyRel.md](NieruSrTrwalyRel.md) |
| NieruWydzialRel | Relacje urządzeń do jednostek organizacyjnych | `NieruWydzialyRel` |  |  |  |  |  | [NieruWydzialRel.md](NieruWydzialRel.md) |
| Nieruchomosc | Nieruchomości | `Nieruchomosci` |  | root | historyczna → NieruchomoscHis | IZasobCRM, IDocumentHostCRM, IObiektDoPlanowania | RealEstateKind (10) | [Nieruchomosc.md](Nieruchomosc.md) |
| NieruchomoscHis | Historia nieruchomości | `NieruchomosciHis` |  | root | historia | IDocumentHostCRM |  | [NieruchomoscHis.md](NieruchomoscHis.md) |
| NieruchomoscRef | Struktura nieruchomości | `NieruchomosciRef` |  | child: Nieruchomosc→Nieruchomosc |  |  |  | [NieruchomoscRef.md](NieruchomoscRef.md) |
| NieruchomoscRel | Relacje nieruchomości | `NieruchomosciRel` |  |  |  |  |  | [NieruchomoscRel.md](NieruchomoscRel.md) |
| NieruchomoscUzyta | Nieruchomości wykorzystane | `NieruchomUzyte` |  |  |  |  |  | [NieruchomoscUzyta.md](NieruchomoscUzyta.md) |
| NieruchomoscZdarzenie | Zdarzenia nieruchmości | `NieruZdarzenia` |  | root |  |  |  | [NieruchomoscZdarzenie.md](NieruchomoscZdarzenie.md) |
| RezerwacjaStanowiskaPracy | Rezerwacja stanowiska pracy | `RezerStanowPracy` |  | root |  |  |  | [RezerwacjaStanowiskaPracy.md](RezerwacjaStanowiskaPracy.md) |
| RozliczenieMediow | Rozliczenia mediów | `RozMediow` |  | root |  | IDocumentHostCRM |  | [RozliczenieMediow.md](RozliczenieMediow.md) |
| StanNieruchomosci | Stany nieruchomości | `StanyNieruchom` | konfig | root |  |  |  | [StanNieruchomosci.md](StanNieruchomosci.md) |
| StanowiskoPracy | Stanowisko pracy | `StanowiskaPracy` |  | root |  |  |  | [StanowiskoPracy.md](StanowiskoPracy.md) |
| StnPracSrTrwalyRel | Relacje stanowisk do środków trwałych | `StnPracSrTrwRel` |  | root |  |  |  | [StnPracSrTrwalyRel.md](StnPracSrTrwalyRel.md) |
| TypNieruchomosc | Typy nieruchomości | `TypyNieruchom` | konfig | root |  | IRightsSource | RealEstateKind (10) | [TypNieruchomosc.md](TypNieruchomosc.md) |
| UslugaNieruch | Usługa nieruchomości | `UslugiNieruch` |  | root |  |  |  | [UslugaNieruch.md](UslugaNieruch.md) |
| UslugaZdarzenia | Usługi zdarzenia | `UslugiZdarzenia` |  |  |  |  |  | [UslugaZdarzenia.md](UslugaZdarzenia.md) |

