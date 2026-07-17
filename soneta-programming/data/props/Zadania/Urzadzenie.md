# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Urzadzenie`
Nazwa tabeli: `Urzadzenia`
Tytuł: Urządzenia
Opis: Ewidencja urządzeń serwisowanych, wypożyczanych i własnych. Zawiera dane identyfikacyjne, gwarancję, lokalizację, powiązanie z towarem i środkiem trwałym oraz parametry rozliczeń wypożyczeń.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IKodowany`, `IZasobCRM`, `IElementSlownika`, `IDocumentHostCRM`

- pola bazodanowe: 23
- pola kalkulowane (z klas biznesowych): 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| Aktywne | `bool` | bazodanowe | Aktywne | Wpozwala na określenie, czy urządzenie jest aktywne |
| DataGwarancji | `Soneta.Types.Date` | bazodanowe | Data gwarancji | Data do jakiej obowiązuje gwarancja |
| DataSprzedazy | `Soneta.Types.Date` | bazodanowe | Data sprzedaży | Data sprzedaży urządzenia |
| DokumentHandlowy | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Lista towarów. |
| DokumentyCRM | `Soneta.Business.SubTable<Soneta.Zadania.DokumentCRM>` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Identyfikator | `string` | bazodanowe | Identyfikator | Unikalny identyfikator urządzenia |
| Inwentarz | `Soneta.SrodkiTrwale.IInwentarz` | bazodanowe, iface-ref | Środek trwały, wyposażenie | Środek trwały, wyposażenie |
| JednostkaRozliczenia | `Soneta.Towary.Jednostka` |  |  |  |
| Kod | `string` |  |  |  |
| KodZasobu | `string` |  |  |  |
| KodyKreskowe | `Soneta.Business.SubTable<Soneta.Core.KodKreskowy>` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent, do którego przypisane jest urządzenie. |
| Kontrola | `Soneta.Core.Kontrola` | enum |  |  |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja urządzenia | Lokalizacja urządzenia. |
| ModelUrz | `Soneta.Zadania.ModelUrz` | bazodanowe | Model urządzenia | Model urządzenia. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa urządzenia |
| NazwaZasobu | `string` |  |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisane jest urządzenie. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis urządzenia |
| PlanowanePrzeglady | `Soneta.Business.SubTable<Soneta.Zadania.PlanowanyPrzeglad>` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable<Soneta.Ksiega.PowiazanieKontaBase>` |  |  |  |
| PozycjaDokHandlowego | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja dokumentu handlowego |
| PrzegladOkres | `int` | bazodanowe |  | Co ile miesięcy przegląd |
| RodzajRozliczenia | `Soneta.Zadania.RodzajRozliczeniaUrzadzenia` | enum |  |  |
| Serwisant | `Soneta.Business.App.Operator` | bazodanowe | Serwisant | Serwisant odpowiedzialny za urządzenie |
| Serwisowane | `bool` | bazodanowe | Urządzenie przyjmowane do serwisu | Oznacza możliwość przyjmowania urządzenia do serwisu. |
| Stawka | `Soneta.Types.Currency` | bazodanowe |  | Stawka za jednostkę czasu wypożyczenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Lista towarów. |
| TowarUsluga | `Soneta.Towary.Towar` | bazodanowe |  | Towar typu usługa, do rozliczenia użycia. |
| TypUrzadzenia | `Soneta.Zadania.TypUrzadzenia` | bazodanowe | Typ urządzenia | Typ urządzenia. |
| TypZaokraglenia | `Soneta.Zadania.TypZaokraglenia` | bazodanowe, enum |  | Określa rodzaj zaokrąglenia. |
| TypZasobu | `string` |  |  |  |
| UrzadzeniaUzyte | `Soneta.Business.SubTable<Soneta.Zadania.UrzadzenieUzyte>` |  |  |  |
| Wlasne | `bool` | bazodanowe | Urządzenie własne | Oznacza urządzenie własne. |
| Wypozyczane | `bool` | bazodanowe | Możliwość wypożyczenia urządzenia. | Oznacza możliwość wypożyczania urządzenia. |
| Wypozyczenia | `Soneta.Business.View` |  |  |  |
| ZasobyCRM | `Soneta.Business.SubTable<Soneta.Zadania.ZasobCRM>` |  |  |  |
| Zlecenia | `Soneta.Business.View` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Inwentarz | `IInwentarz` | `SrodekTrwalyBase`, `Wyposazenie` |
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Kontrola (`Soneta.Core.Kontrola`)
- `Brak` = 0
- `Ostrzeżenie` = 1
- `Błąd` = 2

### RodzajRozliczeniaUrzadzenia (`Soneta.Zadania.RodzajRozliczeniaUrzadzenia`)
- `Brak` = 0 — Brak
- `Nieznane` = 1
- `Godzinowe` = 2
- `Dzienne` = 3
- `Miesieczne` = 4

### TypZaokraglenia (`Soneta.Zadania.TypZaokraglenia`)
- `Gora` = 0 — W górę
- `Dol` = 1 — W dół
- `DoBliskiejWartosci` = 2 — Do najbliższej wartości
- `Proporcjonalnie` = 3 — Proporcjonalnie
