# Moduł `Windykacja` — tabele biznesowe

- Opis: Moduł obsługujący procesy windykacji należności. Zawiera definicje schematów windykacyjnych, akcje windykacyjne, monity oraz śledzenie statusów windykacji kontrahentów.
- Tabel: **6**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DefinicjaSprawyWindykacyjnej | Definicje spraw windykacyjnych | `DefSprawWind` | konfig | root |  | IRightsSource | TypDokumentu (1) | [DefinicjaSprawyWindykacyjnej.md](DefinicjaSprawyWindykacyjnej.md) |
| EtapDefinicjiWindykacji | Etapy definicji windykacji | `EtapyDefWind` | konfig | root |  |  |  | [EtapDefinicjiWindykacji.md](EtapDefinicjiWindykacji.md) |
| PozycjaSprawyWindykacyjnej | Pozycje spraw windykacyjnych | `PozSprawWind` |  | child: Sprawa→SprawaWindykacyjna |  |  |  | [PozycjaSprawyWindykacyjnej.md](PozycjaSprawyWindykacyjnej.md) |
| SprawaWindykacyjna | Sprawy windykacyjne | `SprawyWindyk` |  | root |  | IEmailElement, IDokumentCRM |  | [SprawaWindykacyjna.md](SprawaWindykacyjna.md) |
| StanWindykacji | Definicje etapu sprawy | `StanyWindykacji` | konfig | root |  |  |  | [StanWindykacji.md](StanWindykacji.md) |
| Windykacja |  | `Windykacje` |  | child: Dokument→IRozliczalny |  |  |  | [Windykacja.md](Windykacja.md) |

