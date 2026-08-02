# Moduł `Waluty` — tabele biznesowe

- Opis: Moduł obsługujący kursy walut i tabele kursowe. Zawiera definicje walut, tabele kursowe z NBP i ECB oraz mechanizmy przeliczania wartości walutowych.
- Tabel: **3**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| KursWaluty |  | `KursyWalut` | konfig | child: Tabela→TabelaKursowa |  |  |  | [KursWaluty.md](KursWaluty.md) |
| TabelaKursowa | Tabele kursowe | `TabeleKursowe` | konfig | root |  |  |  | [TabelaKursowa.md](TabelaKursowa.md) |
| Waluta |  | `Waluty` | konfig | root |  |  |  | [Waluta.md](Waluta.md) |

