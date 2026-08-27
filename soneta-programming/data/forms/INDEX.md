# Indeks zakładek formularzy (pageform) — dane wygenerowane

Zakładek biznesowych: **5667** · typów danych: **2754** · zakładek systemowych: **12** · bibliotek UI: **31**.

Katalog do szybkiego wyszukania „obiekt → zakładki” bez uruchamiania skanera i bez
dostępu do DLL. **Nie zawiera pól ani sekcji** — pełną zawartość zakładki (pola,
sekcje danych, rozwinięte ścieżki `DataContext`/`EditValue`, `Include`, listy) wypisuje
na żądanie `scan-forms.csx` — patrz [../../references/scan-forms.md](../../references/scan-forms.md).

**Typ danych.** Nazwa zasobu ma postać `…<TYP>.<ZAKŁADKA>.pageform.xml`, więc typ to
segment **przed** nazwą zakładki — albo jawny atrybut `DataType` na `<DataForm>`, gdy jest.
Segment typu jest walidowany względem realnych `RowType`; dla okien konfiguracji
(folder `Config`) typ bierzemy z nazwy zakładki. Zakładek z jawnym `DataType`: **800**.

## Jak znaleźć zakładki obiektu

Zakładki biznesowe są rozdzielone na pliki `<Przestrzeń>.md` (jeden na przestrzeń nazw),
bo pełna lista nie mieści się w jednym odczycie. **Nie musisz wiedzieć, w której
przestrzeni jest typ** — wyszukaj go od razu we wszystkich:

```bash
rg '^\| Kontrahent \|' *.md            # wszystkie zakładki typu Kontrahent
rg -l '^\| DokumentHandlowy \|' *.md    # sam plik przestrzeni
rg '^\| \w*Pracownik\w* \|' *.md       # gdy nie znasz dokładnej nazwy typu
```

Po znalezieniu obiektu odczytaj jego pola: `dotnet script scan-forms.csx -- <Typ|Namespace.Typ> <KatalogDll>`.
Zakładki dokładane do wielu obiektów przez typ bazowy są niżej, w sekcji **systemowej**.

## Przestrzenie nazw

| Przestrzeń | Zakładek | Typów | Plik |
|---|---:|---:|---|
| Soneta.BI | 198 | 122 | [Soneta.BI.md](Soneta.BI.md) |
| Soneta.Business | 421 | 257 | [Soneta.Business.md](Soneta.Business.md) |
| Soneta.CRM | 197 | 100 | [Soneta.CRM.md](Soneta.CRM.md) |
| Soneta.Core | 419 | 283 | [Soneta.Core.md](Soneta.Core.md) |
| Soneta.CzlonkowieSzkolenia | 124 | 51 | [Soneta.CzlonkowieSzkolenia.md](Soneta.CzlonkowieSzkolenia.md) |
| Soneta.Deklaracje | 1305 | 401 | [Soneta.Deklaracje.md](Soneta.Deklaracje.md) |
| Soneta.EI | 49 | 26 | [Soneta.EI.md](Soneta.EI.md) |
| Soneta.Handel | 245 | 141 | [Soneta.Handel.md](Soneta.Handel.md) |
| Soneta.KadryPlace | 1010 | 510 | [Soneta.KadryPlace.md](Soneta.KadryPlace.md) |
| Soneta.Kasa | 186 | 143 | [Soneta.Kasa.md](Soneta.Kasa.md) |
| Soneta.KlientBiuraRachunkowego | 8 | 6 | [Soneta.KlientBiuraRachunkowego.md](Soneta.KlientBiuraRachunkowego.md) |
| Soneta.Ksiega | 347 | 237 | [Soneta.Ksiega.md](Soneta.Ksiega.md) |
| Soneta.Magazyny | 30 | 17 | [Soneta.Magazyny.md](Soneta.Magazyny.md) |
| Soneta.Net | 76 | 26 | [Soneta.Net.md](Soneta.Net.md) |
| Soneta.Printer | 3 | 2 | [Soneta.Printer.md](Soneta.Printer.md) |
| Soneta.Produkcja | 49 | 29 | [Soneta.Produkcja.md](Soneta.Produkcja.md) |
| Soneta.ProdukcjaPro | 173 | 91 | [Soneta.ProdukcjaPro.md](Soneta.ProdukcjaPro.md) |
| Soneta.PulpitKontrahenta | 32 | 8 | [Soneta.PulpitKontrahenta.md](Soneta.PulpitKontrahenta.md) |
| Soneta.PulpitPracownika | 1 | 1 | [Soneta.PulpitPracownika.md](Soneta.PulpitPracownika.md) |
| Soneta.RealEstate | 94 | 49 | [Soneta.RealEstate.md](Soneta.RealEstate.md) |
| Soneta.Support | 35 | 20 | [Soneta.Support.md](Soneta.Support.md) |
| Soneta.Towary | 97 | 42 | [Soneta.Towary.md](Soneta.Towary.md) |
| Soneta.Vehicles | 46 | 17 | [Soneta.Vehicles.md](Soneta.Vehicles.md) |
| Soneta.Workflow | 167 | 105 | [Soneta.Workflow.md](Soneta.Workflow.md) |
| Soneta.Zadania | 354 | 166 | [Soneta.Zadania.md](Soneta.Zadania.md) |
| SonetaExplorer.Config | 1 | 1 | [SonetaExplorer.Config.md](SonetaExplorer.Config.md) |

## Zakładki systemowe (typy ogólne)

Zakładki przypięte do typów bazowych/interfejsów ogólnych (`Row`, `GuidedRow`,
`ExportedRow`, `IRow`, `IGuidedRow`, `object`). Platforma dokłada je do **wielu obiektów**
przez dziedziczenie/interfejs — **nie są specyficzne dla obiektu** i nie wnoszą informacji
biznesowej (Załączniki, Notatki, Dyskusja, Panel BI, „Dodatkowe (cechy)”…). `scan-forms`
dla konkretnego obiektu ich nie raportuje — pełną definicję odczytasz podając typ ogólny,
np. `dotnet script scan-forms.csx -- Row <KatalogDll>`.

| Typ ogólny | Zakładka (plik) | Nazwa zakładki | Priority | Biblioteka (DLL) | Przestrzeń |
|---|---|---|---|---|---|
| IGuidedRow | HostTuples | Dokumenty dodatkowe | 997 | Soneta.Core.UI.dll | Soneta.Core |
| IGuidedRow | RefTuples | Powiązane dokumenty dodatkowe | 998 | Soneta.Core.UI.dll | Soneta.Core |
| IGuidedRow | DependentWorkflow | Obsługa procesu | 99998 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| IGuidedRow | Discussion | Dyskusja | 999998 | Soneta.Core.UI.dll | Soneta.Core |
| IRow | DefineFirst | Użytkownika | -5000 | Soneta.Business.UI.dll | Soneta.Business |
| IRow | Define | Dodatkowe (cechy) | 5000 | Soneta.Business.UI.dll | Soneta.Business |
| Row | AttachmentPage | Asystent/Załączniki | 9997 | Soneta.Net.Business.dll | Soneta.Net |
| Row | NotePage | Asystent/Notatki | 9998 | Soneta.Net.Business.dll | Soneta.Net |
| Row | FormDashboard | Panel BI | 9999 | Soneta.BI.UI.dll | Soneta.BI |
| Row | NotificationsNetPage | Asystent/Powiadomienia | 9999 | Soneta.Workflow.UI.dll | Soneta.Workflow |
| Row | TeczkaPage | Asystent/Teczki | 9999 | Soneta.CRM.UI.dll | Soneta.CRM |
| Row | ExplorerObjectPage | Wszystkie | 999999 | Soneta.Business.UI.dll | Soneta.Business |

## Liczba zakładek wg biblioteki

| Biblioteka (DLL) | Zakładek |
|---|---|
| Soneta.Deklaracje.UI.dll | 1303 |
| Soneta.KadryPlace.UI.dll | 1010 |
| Soneta.Handel.UI.dll | 455 |
| Soneta.Core.UI.dll | 405 |
| Soneta.Business.UI.dll | 362 |
| Soneta.Zadania.UI.dll | 354 |
| Soneta.Ksiega.UI.dll | 347 |
| Soneta.CRM.UI.dll | 198 |
| Soneta.BI.UI.dll | 197 |
| Soneta.Kasa.UI.dll | 186 |
| Soneta.ProdukcjaPro.UI.dll | 173 |
| Soneta.Workflow.UI.dll | 169 |
| Soneta.CzlonkowieSzkolenia.UI.dll | 124 |
| Soneta.RealEstate.UI.dll | 94 |
| Soneta.EI.UI.dll | 49 |
| Soneta.Net.Business.dll | 48 |
| Soneta.Vehicles.UI.dll | 46 |
| Soneta.Support.UI.dll | 35 |
| Soneta.Net.Test.dll | 30 |
| Soneta.Business.UI.DxReports.dll | 18 |
| Soneta.Core.dll | 17 |
| Soneta.Business.Licence.dll | 15 |
| Soneta.Business.dll | 14 |
| Soneta.Business.Forms.dll | 10 |
| Soneta.Handel.Reports.dll | 7 |
| Soneta.Business.Test.dll | 3 |
| Soneta.Printer.dll | 3 |
| Soneta.BI.Reports.dll | 2 |
| Soneta.Deklaracje.dll | 2 |
| Soneta.Oracle.dll | 2 |
| SonetaExplorer.dll | 1 |
