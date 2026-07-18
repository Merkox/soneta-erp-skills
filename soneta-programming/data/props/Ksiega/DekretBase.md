# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DekretBase`
Nazwa tabeli: `Dziennik`
Tytuł: Dziennik księgowy
Opis: Dekret księgowy stanowi podstawową jednostkę zapisu w dzienniku księgowym. Grupuje zapisy księgowe dotyczące jednej operacji gospodarczej, zawiera numer ewidencji, datę, opis oraz sumy stron Winien i Ma. Obsługuje dekrety buforowe, dekrety zamknięcia okresu, grupowanie zapisów oraz predekretację za pomocą schematów księgowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 40
- podlisty: 4
- subrowy: 2
- razem: 59

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe, tylko-odczyt |  |  |
| CzyRelacjeOpisow | `bool` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` | tylko-odczyt |  |  |
| DefinicjaEwidencji | `Soneta.Core.DefinicjaDokumentu` | bazodanowe, tylko-odczyt |  |  |
| DekretGlowny | `Soneta.Ksiega.DekretBase` | bazodanowe, tylko-odczyt |  |  |
| DekretZamkniecia | `bool` | bazodanowe | Dekret zamknięcia | Dekret zamknięcia okresu (miesiąca) |
| DekretyPomocnicze | `SubTable<Soneta.Ksiega.DekretBase>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  |  |
| Firma | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| GrupowanieZapisow | `bool` | bazodanowe |  | Określa czy dekret obsługuje grupowanie zapisów i kontrolę dwustronności zapisów w obrębie grup |
| InicjowanieOpisowZapisowInfo | `string` | tylko-odczyt |  |  |
| JestKPiRPo2026 | `bool` | tylko-odczyt |  |  |
| JestKPiRPrzed2026 | `bool` | tylko-odczyt |  |  |
| JestKS | `bool` | tylko-odczyt |  |  |
| JestRyczaltPo2026 | `bool` | tylko-odczyt |  |  |
| JestRyczaltPrzed2026 | `bool` | tylko-odczyt |  |  |
| KPiR | `Soneta.Ksiega.KPiR` (subrow) | bazodanowe |  |  |
| KPiR.AdresKontrahenta | `string` | tylko-odczyt |  |  |
| KPiR.Data | `Date` | tylko-odczyt |  |  |
| KPiR.Lp | `int` | bazodanowe |  |  |
| KPiR.LpMiesiac | `string` | tylko-odczyt |  |  |
| KPiR.Miesiac | `string` | tylko-odczyt |  |  |
| KPiR.NazwaKontrahenta | `string` | tylko-odczyt |  |  |
| KPiR.NumerDokumentu | `string` | tylko-odczyt |  |  |
| KPiR.OpisZdarzenia | `string` | tylko-odczyt |  |  |
| KPiR.Stan | `Soneta.Ksiega.StanyZapisuKPiR` (enum) | bazodanowe, tylko-odczyt |  |  |
| KPiR.Uwagi | `string` | bazodanowe |  |  |
| KPiRWorker | `Soneta.KP.EwidencjaWorkers.KPiRWorker` | tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| KwotaOperacjiGospodarczej | `Currency` | bazodanowe |  | Kwota operacji gospodarczej JPK |
| Ma | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerDokumentu | `string` | bazodanowe, tylko-odczyt |  |  |
| NumerEwidencji | `string` | bazodanowe, tylko-odczyt |  |  |
| OK | `bool` | tylko-odczyt |  | Określa poprawność dekretu |
| Oddzial | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe, tylko-odczyt |  | Okres obrachunkowy |
| Opis | `string` | bazodanowe |  |  |
| OpisBledu | `string` | tylko-odczyt |  |  |
| OpisBleduPreview | `string` | tylko-odczyt |  |  |
| Saldo | `Currency` | tylko-odczyt |  |  |
| Schemat | `Soneta.Ksiega.SchematKsiegowy` | bazodanowe |  |  |
| Storno | `Soneta.Ksiega.DekretBase` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe |  | Symbol dokumentu dekretu |
| SymbolNumeruZrodlaEwidencji | `string` | tylko-odczyt |  |  |
| Typ | `Soneta.Ksiega.TypDziennika` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypWgKont | `Soneta.Ksiega.TypDekretuWgKont` (enum) | bazodanowe |  |  |
| Winien | `Currency` | bazodanowe, tylko-odczyt |  |  |
| Wprowadzil | `App.Operator` | tylko-odczyt |  |  |
| Zamkniety | `bool` | tylko-odczyt |  |  |
| Zapisy | `LpSubTable<Soneta.Ksiega.ZapisKsiegowy>` | podlista |  |  |
| Zatwierdzil | `App.Operator` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanyZapisuKPiR (`Soneta.Ksiega.StanyZapisuKPiR`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Bufor` = 1
- `Zatwierdzony` = 2
- `Przekreślony` = 3

### TypDekretuWgKont (`Soneta.Ksiega.TypDekretuWgKont`)
- `Brak` = 0 — Nieokreślony
- `Bilansowy` = 1
- `Pozabilansowy` = 2
- `Mieszany` = 3

### TypDziennika (`Soneta.Ksiega.TypDziennika`)
- `Brak` = 0 — Brak
- `Dekret` = 1
- `BO` = 2
