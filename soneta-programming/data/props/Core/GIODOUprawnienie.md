# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOUprawnienie`
Nazwa tabeli: `GIODOUprawnienia`
Tytuł: Uprawnienia
Opis: Uprawnienie RODO przyznane osobie do przetwarzania danych osobowych. Zawiera definicję uprawnienia, datę, numer, treść, okres obowiązywania, daty przyznania i odebrania, oddział oraz powiązanie z ewentualnym wycofaniem uprawnienia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data |
| Definicja | `Soneta.Core.GIODODefinicjaUprawnienia` | bazodanowe | Definicja | Definicja uprawnienia |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Odebrane | `Soneta.Types.Date` | bazodanowe |  | Uprawnienie odebrane od dnia |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Okres, na który przyznano uprawnienie |
| Przyznane | `Soneta.Types.Date` | bazodanowe |  | Uprawnienie porzyznane od dnia |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Oświadczenie | Treść oświadczenia |
| Uprawniony | `Soneta.Core.IGIODOUprawnienieHost` | bazodanowe, iface-ref | Uprawniony | Zapis, do którego przypisano informacja o uprawnieniu |
| WycofaneUprawnienia | `Soneta.Business.SubTable<Soneta.Core.GIODOUprawnienie>` |  |  |  |
| WycofanieUprawnienia | `Soneta.Core.GIODOUprawnienie` | bazodanowe |  |  |
| Zatwierdzone | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Uprawniony | `IGIODOUprawnienieHost` | `KontaktOsoba`, `Pracownik` |
