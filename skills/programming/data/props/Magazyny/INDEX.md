# Moduł `Magazyny` — tabele biznesowe

- Opis: Moduł gospodarki magazynowej obsługujący ewidencję stanów, obrotów i zasobów magazynowych. Definiuje magazyny, okresy magazynowe, partie towarów (grupy dostaw) oraz mechanizmy wyceny rozchodu (FIFO, LIFO, wg cechy).
- Tabel: **5**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| GrupaDostaw | Partie | `GrupyDostaw` |  |  |  | IKodowany |  | [GrupaDostaw.md](GrupaDostaw.md) |
| Magazyn |  | `Magazyny` | konfig | root |  | IRightsSource, IElementSlownika |  | [Magazyn.md](Magazyn.md) |
| Obrot | Obrót | `Obroty` |  |  |  |  |  | [Obrot.md](Obrot.md) |
| OkresMagazynowy | Okresy magazynowe | `OkresyMag` | konfig | root |  |  |  | [OkresMagazynowy.md](OkresMagazynowy.md) |
| Zasob | Zasób | `Zasoby` |  |  |  |  |  | [Zasob.md](Zasob.md) |

