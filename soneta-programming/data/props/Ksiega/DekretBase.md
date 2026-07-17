# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DekretBase`
Nazwa tabeli: `Dziennik`
Tytuł: Dziennik księgowy
Opis: Dekret księgowy stanowi podstawową jednostkę zapisu w dzienniku księgowym. Grupuje zapisy księgowe dotyczące jednej operacji gospodarczej, zawiera numer ewidencji, datę, opis oraz sumy stron Winien i Ma. Obsługuje dekrety buforowe, dekrety zamknięcia okresu, grupowanie zapisów oraz predekretację za pomocą schematów księgowych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 26
- pola kalkulowane (z klas biznesowych): 33

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` | bazodanowe |  |  |
| CzyRelacjeOpisow | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Core.DefinicjaDokumentu` |  |  |  |
| DefinicjaEwidencji | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  |  |
| DekretGlowny | `Soneta.Ksiega.DekretBase` | bazodanowe |  |  |
| DekretZamkniecia | `bool` | bazodanowe | Dekret zamknięcia | Dekret zamknięcia okresu (miesiąca) |
| DekretyPomocnicze | `Soneta.Business.SubTable<Soneta.Ksiega.DekretBase>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe |  |  |
| Firma | `Soneta.Core.OddzialFirmy` |  |  |  |
| GrupowanieZapisow | `bool` | bazodanowe |  | Określa czy dekret obsługuje grupowanie zapisów i kontrolę dwustronności zapisów w obrębie grup |
| InicjowanieOpisowZapisowInfo | `string` |  |  |  |
| JestKPiRPo2026 | `bool` |  |  |  |
| JestKPiRPrzed2026 | `bool` |  |  |  |
| JestKS | `bool` |  |  |  |
| JestRyczaltPo2026 | `bool` |  |  |  |
| JestRyczaltPrzed2026 | `bool` |  |  |  |
| KPiR | `Soneta.Ksiega.KPiR` | bazodanowe |  |  |
| KPiR.AdresKontrahenta | `string` |  |  |  |
| KPiR.Data | `Soneta.Types.Date` |  |  |  |
| KPiR.Lp | `int` | bazodanowe |  |  |
| KPiR.LpMiesiac | `string` |  |  |  |
| KPiR.Miesiac | `string` |  |  |  |
| KPiR.NazwaKontrahenta | `string` |  |  |  |
| KPiR.NumerDokumentu | `string` |  |  |  |
| KPiR.OpisZdarzenia | `string` |  |  |  |
| KPiR.Stan | `Soneta.Ksiega.StanyZapisuKPiR` | bazodanowe, enum |  |  |
| KPiR.Uwagi | `string` | bazodanowe |  |  |
| KPiRWorker | `Soneta.KP.EwidencjaWorkers.KPiRWorker` |  |  |  |
| Kod | `string` |  |  |  |
| KwotaOperacjiGospodarczej | `Soneta.Types.Currency` | bazodanowe |  | Kwota operacji gospodarczej JPK |
| Ma | `Soneta.Types.Currency` | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerDokumentu | `string` | bazodanowe |  |  |
| NumerEwidencji | `string` | bazodanowe |  |  |
| OK | `bool` |  |  | Określa poprawność dekretu |
| Oddzial | `Soneta.Core.OddzialFirmy` |  |  |  |
| Okres | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe |  | Okres obrachunkowy |
| Opis | `string` | bazodanowe |  |  |
| OpisBledu | `string` |  |  |  |
| OpisBleduPreview | `string` |  |  |  |
| Saldo | `Soneta.Types.Currency` |  |  |  |
| Schemat | `Soneta.Ksiega.SchematKsiegowy` | bazodanowe |  |  |
| Storno | `Soneta.Ksiega.DekretBase` |  |  |  |
| Symbol | `string` | bazodanowe |  | Symbol dokumentu dekretu |
| SymbolNumeruZrodlaEwidencji | `string` |  |  |  |
| Typ | `Soneta.Ksiega.TypDziennika` | bazodanowe, enum |  |  |
| TypWgKont | `Soneta.Ksiega.TypDekretuWgKont` | bazodanowe, enum |  |  |
| Winien | `Soneta.Types.Currency` | bazodanowe |  |  |
| Wprowadzil | `Soneta.Business.App.Operator` |  |  |  |
| Zamkniety | `bool` |  |  |  |
| Zapisy | `Soneta.Business.LpSubTable<Soneta.Ksiega.ZapisKsiegowy>` |  |  |  |
| Zatwierdzil | `Soneta.Business.App.Operator` |  |  |  |

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
