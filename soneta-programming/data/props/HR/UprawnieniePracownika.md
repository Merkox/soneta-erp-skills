# Pola i właściwości klasy biznesowej: `Soneta.HR.UprawnieniePracownika`
Nazwa tabeli: `UprawnieniaPrac`
Tytuł: Uprawnienia
Opis: Ewidencja uprawnień posiadanych przez pracownika. Rejestruje datę uzyskania, termin ważności, numer uprawnienia i organ wydający, umożliwiając kontrolę aktualności wymaganych kwalifikacji.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataUtraty | `Soneta.Types.Date` | bazodanowe |  |  |
| DataUzyskania | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe |  |  |
| Kategoria | `Soneta.HR.KategoriaUprawnienia` |  |  |  |
| Numer | `string` | bazodanowe | Numer uprawnienia |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| TerminWaznosci | `Soneta.Types.Date` | bazodanowe | Termin ważności |  |
| WażneDo | `Soneta.Types.Date` |  |  |  |
| WydanePrzez | `string` | bazodanowe |  |  |
| Zrodlo | `Soneta.HR.IŹródłoUzyskaniaUprawnienia` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IŹródłoUzyskaniaUprawnienia` | `WniosekOSzkolenie` |
