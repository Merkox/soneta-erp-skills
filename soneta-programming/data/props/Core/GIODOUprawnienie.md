# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOUprawnienie`
Nazwa tabeli: `GIODOUprawnienia`
Tytuł: Uprawnienia
Opis: Uprawnienie RODO przyznane osobie do przetwarzania danych osobowych. Zawiera definicję uprawnienia, datę, numer, treść, okres obowiązywania, daty przyznania i odebrania, oddział oraz powiązanie z ewentualnym wycofaniem uprawnienia.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe | Data | Data |
| Definicja | `Soneta.Core.GIODODefinicjaUprawnienia` | bazodanowe, tylko-odczyt | Definicja | Definicja uprawnienia |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Odebrane | `Date` | bazodanowe |  | Uprawnienie odebrane od dnia |
| Okres | `FromTo` | bazodanowe, podlista |  | Okres, na który przyznano uprawnienie |
| Przyznane | `Date` | bazodanowe |  | Uprawnienie porzyznane od dnia |
| Tresc | `MemoText` | bazodanowe, podlista | Oświadczenie | Treść oświadczenia |
| Uprawniony | `Soneta.Core.IGIODOUprawnienieHost` | bazodanowe, tylko-odczyt, iface-ref | Uprawniony | Zapis, do którego przypisano informacja o uprawnieniu |
| WycofaneUprawnienia | `SubTable<Soneta.Core.GIODOUprawnienie>` | podlista |  |  |
| WycofanieUprawnienia | `Soneta.Core.GIODOUprawnienie` | bazodanowe, tylko-odczyt |  |  |
| Zatwierdzone | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Uprawniony | `IGIODOUprawnienieHost` | `KontaktOsoba`, `Pracownik` |
