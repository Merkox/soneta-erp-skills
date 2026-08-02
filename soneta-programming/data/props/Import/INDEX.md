# Moduł `Import` — tabele biznesowe

- Opis: Moduł importu danych do księgowości. Zawiera definicje importu dokumentów z zewnętrznych systemów finansowo-księgowych.
- Tabel: **1**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| KwotySad | Kwoty SAD | `KwotySadow` |  | child: Ewidencja→DokEwidencji |  |  |  | [KwotySad.md](KwotySad.md) |

