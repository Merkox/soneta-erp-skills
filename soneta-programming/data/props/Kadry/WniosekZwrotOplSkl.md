# Pola i właściwości klasy biznesowej: `Soneta.Kadry.WniosekZwrotOplSkl`
Nazwa tabeli: `WniosZwrotOplSkl`
Tytuł: Wniosek o zwrot nienależnie opłaconych składek
Opis: Wniosek właściciela (przedsiębiorcy) o zwrot nienależnie opłaconych składek ZUS za dany rok. Zawiera definicję dokumentu, numer, datę i rok, za który przysługuje zwrot.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokument`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| IsReadOnlyDefinicja | `bool` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| ZwrotZaRok | `int` | bazodanowe |  |  |
