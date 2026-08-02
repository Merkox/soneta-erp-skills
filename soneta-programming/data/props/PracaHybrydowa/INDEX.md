# Moduł `PracaHybrydowa` — tabele biznesowe

- Opis: Moduł obsługujący pracę zdalną i hybrydową. Zawiera definicje miejsc pracy, harmonogramy pracy zdalnej oraz ewidencję obecności w biurze i poza nim.
- Tabel: **6**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| AreaPath | Obszary w systemie | `AreaPaths` |  | root |  |  |  | [AreaPath.md](AreaPath.md) |
| AreaPathTaskRel | Relacje zadań do obszarów | `AreaTaskRel` |  |  |  |  |  | [AreaPathTaskRel.md](AreaPathTaskRel.md) |
| DefinicjaRCP | Definicje rejestracji czasu pracy | `DefinicjeRCP` | konfig | root |  |  |  | [DefinicjaRCP.md](DefinicjaRCP.md) |
| DefinicjaWerRCP | Definicje weryfikatorow rejestracji czasu pracy | `DefinicjeWerRCP` | konfig | root |  |  |  | [DefinicjaWerRCP.md](DefinicjaWerRCP.md) |
| RelChangeInfo | Relacje historii zmian | `RelChangeInfos` |  |  |  |  | ChangeInfoRelationType (2) | [RelChangeInfo.md](RelChangeInfo.md) |
| ZadaniaRelacja | Relacje Zadań pracy hybrydowej | `ZadRelacje` |  |  |  |  | ZadaniaRelacjaTyp (3) | [ZadaniaRelacja.md](ZadaniaRelacja.md) |

