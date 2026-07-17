# Pola i właściwości klasy biznesowej: `Soneta.Kadry.UmowaZewnetrzna`
Nazwa tabeli: `UmowyZewnetrzne`
Tytuł: Umowy zewnętrzne
Opis: Umowa zewnętrzna (np. kontrakt B2B, umowa o współpracę) zawarta z pracownikiem. Zawiera dane dokumentu, okres obowiązywania, jednostkę organizacyjną, definicję dokumentu, powiązanego kontrahenta i opcjonalną kontynuację poprzedniej umowy.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZrodloPodzielnikaKosztow`, `IUmowaZKalendarzem`, `IZrodloPlanu`, `IDostepnoscHost`, `IZrodloNieobecnosci`, `IZrodloWnioskuONieobecnosc`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CRU | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DniPlanu | `Soneta.Business.DateSubTable` |  |  |  |
| DniPracyUmowy | `Soneta.Business.DateSubTable<Soneta.Kalend.DzienPracyUmowy>` |  |  |  |
| ElemRozliPracownika | `Soneta.Business.SubTable<Soneta.Place.ElementRozliczeniaPracownika>` |  |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Kadry.UmowaZewnetrznaHistoria>` |  |  |  |
| InformacjeDoRozl | `Soneta.Business.SubTable<Soneta.Kadry.InformacjaDoRozliczenia>` |  |  |  |
| KalendarzeUmowy | `Soneta.Business.SubTable<Soneta.Kalend.KalendarzBase>` |  |  |  |
| Kod | `string` |  |  |  |
| KontynuacjaUmowy | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe |  |  |
| Last | `Soneta.Kadry.UmowaZewnetrznaHistoria` |  |  |  |
| Nieobecnosci | `Soneta.Business.FromToSubTable<Soneta.Kalend.Nieobecnosc>` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerPelny | `string` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Podzielniki | `Soneta.Business.SubTable<Soneta.Core.PodzielnikKosztow>` |  |  |  |
| PowiazanyKontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| RegulyDostepnosci | `Soneta.Business.SubTable<Soneta.Kalend.RegulaDostepnosci>` |  |  |  |
| Seria | `string` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypUmowyZewnetrznej` | bazodanowe, enum |  |  |
| WartosciZRozliczen | `Soneta.Types.Currency` |  |  |  |
| WnioskiUrlopowe | `Soneta.Business.SubTable<Soneta.Kadry.WniosekUrlopowy>` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Zestawienia | `Soneta.Business.FromToSubTable<Soneta.Kalend.ZestawienieUmowyZewnetrznej>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypUmowyZewnetrznej (`Soneta.Kadry.TypUmowyZewnetrznej`)
- `Wszystkie` = 0 — Wszystkie
- `UmowaB2B` = 1 — Umowa B2B
- `UmowaAPT` = 2 — Umowa APT
