# Pola i właściwości klasy biznesowej: `Soneta.Kadry.UmowaZewnetrzna`
Nazwa tabeli: `UmowyZewnetrzne`
Tytuł: Umowy zewnętrzne
Opis: Umowa zewnętrzna (np. kontrakt B2B, umowa o współpracę) zawarta z pracownikiem. Zawiera dane dokumentu, okres obowiązywania, jednostkę organizacyjną, definicję dokumentu, powiązanego kontrahenta i opcjonalną kontynuację poprzedniej umowy.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `UmowaZewnetrznaHistoria`
Implementuje interfejsy: `IZrodloPodzielnikaKosztow`, `IUmowaZKalendarzem`, `IZrodloPlanu`, `IDostepnoscHost`, `IZrodloNieobecnosci`, `IZrodloWnioskuONieobecnosc`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 7
- podlisty: 14
- subrowy: 1
- razem: 31

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CRU | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DniPlanu | `DateSubTable` | podlista |  |  |
| DniPracyUmowy | `DateSubTable<Soneta.Kalend.DzienPracyUmowy>` | podlista |  |  |
| ElemRozliPracownika | `SubTable<Soneta.Place.ElementRozliczeniaPracownika>` | podlista |  |  |
| Historia | `HistorySubTable<Soneta.Kadry.UmowaZewnetrznaHistoria>` | podlista |  |  |
| InformacjeDoRozl | `SubTable<Soneta.Kadry.InformacjaDoRozliczenia>` | podlista |  |  |
| KalendarzeUmowy | `SubTable<Soneta.Kalend.KalendarzBase>` | podlista |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| KontynuacjaUmowy | `Soneta.Kadry.UmowaZewnetrzna` | bazodanowe |  |  |
| Last | `Soneta.Kadry.UmowaZewnetrznaHistoria` | tylko-odczyt |  |  |
| Nieobecnosci | `FromToSubTable<Soneta.Kalend.Nieobecnosc>` | podlista |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Podzielniki | `SubTable<Soneta.Core.PodzielnikKosztow>` | podlista |  |  |
| PowiazanyKontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| RegulyDostepnosci | `SubTable<Soneta.Kalend.RegulaDostepnosci>` | podlista |  |  |
| Seria | `string` | bazodanowe |  |  |
| Typ | `Soneta.Kadry.TypUmowyZewnetrznej` (enum) | bazodanowe, tylko-odczyt |  |  |
| WartosciZRozliczen | `Currency` | tylko-odczyt |  |  |
| WnioskiUrlopowe | `SubTable<Soneta.Kadry.WniosekUrlopowy>` | podlista |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Zestawienia | `FromToSubTable<Soneta.Kalend.ZestawienieUmowyZewnetrznej>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypUmowyZewnetrznej (`Soneta.Kadry.TypUmowyZewnetrznej`)
- `Wszystkie` = 0 — Wszystkie
- `UmowaB2B` = 1 — Umowa B2B
- `UmowaAPT` = 2 — Umowa APT
