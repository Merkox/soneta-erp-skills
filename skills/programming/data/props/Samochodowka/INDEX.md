# Moduł `Samochodowka` — tabele biznesowe

- Opis: Moduł ewidencji przebiegu pojazdów (kilometrówka). Zawiera rejestr pojazdów, trasy, stawki za kilometry oraz rozliczenia kosztów przejazdów służbowych.
- Tabel: **10**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DefinicjaTrasy | Definicje tras | `DefinicjeTras` |  | root |  |  |  | [DefinicjaTrasy.md](DefinicjaTrasy.md) |
| EkoPaliwoSilnika | Paliwa silnika | `EkoPaliwaSilnika` | konfig |  | historyczna → EkoPaliwoStawka | IRowWithHistory |  | [EkoPaliwoSilnika.md](EkoPaliwoSilnika.md) |
| EkoPaliwoStawka | Stawki opłat za emisję | `EkoPaliwaStawki` | konfig | child: PaliwoSilnika→EkoPaliwoSilnika | historia → EkoPaliwoSilnika |  |  | [EkoPaliwoStawka.md](EkoPaliwoStawka.md) |
| EkoRodzajPaliwa | Rodzaje paliw (środowisko) | `EkoRodzajePaliw` | konfig | root |  |  |  | [EkoRodzajPaliwa.md](EkoRodzajPaliwa.md) |
| EkoRodzajSilnika | Rodzaje silników | `EkoRodzSilnikow` | konfig | root |  |  |  | [EkoRodzajSilnika.md](EkoRodzajSilnika.md) |
| KosztEP | KosztyEP | `KosztyEP` |  | root |  |  |  | [KosztEP.md](KosztEP.md) |
| PaliwoPojazdu | Paliwa pojazdu | `PaliwaPojazdu` |  |  |  |  |  | [PaliwoPojazdu.md](PaliwoPojazdu.md) |
| Pojazd |  | `Pojazdy` |  | root |  | IElementSlownika, IZasobCRM | VehicleBusinessType (1) | [Pojazd.md](Pojazd.md) |
| Przejazd |  | `Przejazdy` |  | root |  |  |  | [Przejazd.md](Przejazd.md) |
| RozliczenieEP | Rozliczenia | `RozliczeniaEP` |  | root |  | IDokumentKsiegowalny |  | [RozliczenieEP.md](RozliczenieEP.md) |

