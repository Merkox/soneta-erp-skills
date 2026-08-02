# Moduł `RMK` — tabele biznesowe

- Opis: Moduł rozliczeń międzyokresowych kosztów (RMK). Zawiera definicje harmonogramów rozliczania kosztów w czasie, pozycje rozliczeń oraz automatyczne generowanie dekretów.
- Tabel: **3**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DokumentRMK | Dokumenty RMK | `DokumentyRMK` |  | root |  | IDokumentKsiegowalny |  | [DokumentRMK.md](DokumentRMK.md) |
| KosztRMK | Koszty RMK | `KosztyRMK` |  | root |  | IElementSlownika, IZrodloPodzielnikaKosztow |  | [KosztRMK.md](KosztRMK.md) |
| ObrotRMK | Obroty RMK | `ObrotyRMK` |  |  |  | IZrodloOpisuAnalitycznego | TypObrotuRMK (2) | [ObrotRMK.md](ObrotRMK.md) |

