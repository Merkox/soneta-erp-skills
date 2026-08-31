# Pola i właściwości klasy biznesowej: `Soneta.HR.UprawnieniePracownika`
Nazwa tabeli: `UprawnieniaPrac`
Tytuł: Uprawnienia
Opis: Ewidencja uprawnień posiadanych przez pracownika. Rejestruje datę uzyskania, termin ważności, numer uprawnienia i organ wydający, umożliwiając kontrolę aktualności wymaganych kwalifikacji.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataUtraty | `Date` | bazodanowe |  |  |
| DataUzyskania | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.HR.DefinicjaUprawnienia` | bazodanowe |  |  |
| Kategoria | `Soneta.HR.KategoriaUprawnienia` |  |  |  |
| Numer | `string` | bazodanowe | Numer uprawnienia |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| TerminWaznosci | `Date` | bazodanowe | Termin ważności |  |
| WażneDo | `Date` | tylko-odczyt |  |  |
| WydanePrzez | `string` | bazodanowe |  |  |
| Zrodlo | `Soneta.HR.IŹródłoUzyskaniaUprawnienia` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Zrodlo | `IŹródłoUzyskaniaUprawnienia` | `WniosekOSzkolenie` |
