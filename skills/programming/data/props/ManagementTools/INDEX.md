# Moduł `ManagementTools` — tabele biznesowe

- Opis: Moduł narzędzi zarządzania platformy enova365. Zawiera rejestr konfiguracji systemu umożliwiający przechowywanie i wersjonowanie ustawień w formacie JSON.
- Tabel: **1**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| ConfigRegistry | Rejestr konfiguracji | `ConfigRegistries` |  |  |  |  |  | [ConfigRegistry.md](ConfigRegistry.md) |

