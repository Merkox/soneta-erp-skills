# Moduł `HR2` — tabele biznesowe

- Opis: Rozszerzenie modułu HR o dodatkowe funkcjonalności. Zawiera zaawansowane mechanizmy zarządzania kompetencjami, celami, ocenami okresowymi i rozwojem pracowników.
- Tabel: **14**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| CelOkresowyPracownika | Cele okresowe | `CeleOkresowePrac` |  | root |  |  |  | [CelOkresowyPracownika.md](CelOkresowyPracownika.md) |
| DefinicjaElementuOpisuStanowiska | Definicje elementów opisu stanowisk | `DefElOpisuStanow` | konfig | root |  |  |  | [DefinicjaElementuOpisuStanowiska.md](DefinicjaElementuOpisuStanowiska.md) |
| ElementKartyOpisuStanowiska | Elementy KOS | `ElementyKOS` |  | child: Karta→KartaOpisuStanowiskaBase |  |  |  | [ElementKartyOpisuStanowiska.md](ElementKartyOpisuStanowiska.md) |
| ElementWynagDod | Elementy wynagrodzenia | `ElementyWynagDod` | konfig | child: Stanowisko→DefinicjaStanowiskaHist |  |  |  | [ElementWynagDod.md](ElementWynagDod.md) |
| KartaKompetencjiPracownika | Karty kompetencji | `KartyKompPrac` |  | root |  |  |  | [KartaKompetencjiPracownika.md](KartaKompetencjiPracownika.md) |
| KartaOpisuStanowiskaBase | Karty opisu stanowisk | `KartyOpStanowisk` |  | root |  |  | TypyKartOpisuStanowiska (2) | [KartaOpisuStanowiskaBase.md](KartaOpisuStanowiskaBase.md) |
| KartaRealizacjiCelu | Karty realizacji celu | `KartyReazCelPrac` |  | root |  |  |  | [KartaRealizacjiCelu.md](KartaRealizacjiCelu.md) |
| KategoriaElementuOpisuStanowiska | Kategorie elementów opisu stanowisk | `KatElOpisuStanow` | konfig | root |  |  |  | [KategoriaElementuOpisuStanowiska.md](KategoriaElementuOpisuStanowiska.md) |
| KompetencjaKartyOpisuStanowiska | Kompetencje KOS | `KompetencjeKOS` |  | child: Karta→KartaOpisuStanowiskaBase |  |  |  | [KompetencjaKartyOpisuStanowiska.md](KompetencjaKartyOpisuStanowiska.md) |
| KompetencjaPracownika | Kompetencje | `KompetencjePrac` |  | child: Karta→KartaKompetencjiPracownika |  |  |  | [KompetencjaPracownika.md](KompetencjaPracownika.md) |
| OfertaPracy | Ogłoszenia o pracę | `OfertyPracy` |  |  |  | IŹródłoRekrutacji, IŹródłoKartyOpisuStanowiska |  | [OfertaPracy.md](OfertaPracy.md) |
| RealizacjaCelu | Realizacje celu pracowników | `RealizacjeCelPrc` |  | child: Karta→KartaRealizacjiCelu |  |  |  | [RealizacjaCelu.md](RealizacjaCelu.md) |
| RekrutacjaAplikacja | Aplikacje | `RekrutAplikacje` |  | root |  | IŹródłoRekrutacji |  | [RekrutacjaAplikacja.md](RekrutacjaAplikacja.md) |
| RekrutacjaWakat | Wakaty | `RekrutWakaty` |  | root |  | IŹródłoRekrutacji, IŹródłoKartyOpisuStanowiska |  | [RekrutacjaWakat.md](RekrutacjaWakat.md) |

