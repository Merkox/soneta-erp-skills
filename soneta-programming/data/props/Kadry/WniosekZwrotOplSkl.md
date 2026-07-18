# Pola i właściwości klasy biznesowej: `Soneta.Kadry.WniosekZwrotOplSkl`
Nazwa tabeli: `WniosZwrotOplSkl`
Tytuł: Wniosek o zwrot nienależnie opłaconych składek
Opis: Wniosek właściciela (przedsiębiorcy) o zwrot nienależnie opłaconych składek ZUS za dany rok. Zawiera definicję dokumentu, numer, datę i rok, za który przysługuje zwrot.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| IsReadOnlyDefinicja | `bool` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| ZwrotZaRok | `int` | bazodanowe |  |  |
