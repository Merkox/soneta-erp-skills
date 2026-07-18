# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Urzadzenie`
Nazwa tabeli: `Urzadzenia`
Tytuł: Urządzenia
Opis: Ewidencja urządzeń serwisowanych, wypożyczanych i własnych. Zawiera dane identyfikacyjne, gwarancję, lokalizację, powiązanie z towarem i środkiem trwałym oraz parametry rozliczeń wypożyczeń.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IKodowany`, `IZasobCRM`, `IElementSlownika`, `IDocumentHostCRM`

- pola bazodanowe (zapisywalne): 22
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 8
- podlisty: 10
- subrowy: 0
- razem: 40

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| Aktywne | `bool` | bazodanowe | Aktywne | Wpozwala na określenie, czy urządzenie jest aktywne |
| DataGwarancji | `Date` | bazodanowe | Data gwarancji | Data do jakiej obowiązuje gwarancja |
| DataSprzedazy | `Date` | bazodanowe | Data sprzedaży | Data sprzedaży urządzenia |
| DokumentHandlowy | `Soneta.Handel.DokumentHandlowy` | bazodanowe |  | Lista towarów. |
| DokumentyCRM | `SubTable<Soneta.Zadania.DokumentCRM>` | podlista |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Identyfikator | `string` | bazodanowe | Identyfikator | Unikalny identyfikator urządzenia |
| Inwentarz | `Soneta.SrodkiTrwale.IInwentarz` | bazodanowe, iface-ref | Środek trwały, wyposażenie | Środek trwały, wyposażenie |
| JednostkaRozliczenia | `Soneta.Towary.Jednostka` | tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| KodZasobu | `string` | tylko-odczyt |  |  |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent, do którego przypisane jest urządzenie. |
| Kontrola | `Soneta.Core.Kontrola` (enum) | tylko-odczyt |  |  |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja urządzenia | Lokalizacja urządzenia. |
| ModelUrz | `Soneta.Zadania.ModelUrz` | bazodanowe | Model urządzenia | Model urządzenia. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa urządzenia |
| NazwaZasobu | `string` | tylko-odczyt |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisane jest urządzenie. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis urządzenia |
| PlanowanePrzeglady | `SubTable<Soneta.Zadania.PlanowanyPrzeglad>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable<Soneta.Ksiega.PowiazanieKontaBase>` | podlista |  |  |
| PozycjaDokHandlowego | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja dokumentu handlowego |
| PrzegladOkres | `int` | bazodanowe |  | Co ile miesięcy przegląd |
| RodzajRozliczenia | `Soneta.Zadania.RodzajRozliczeniaUrzadzenia` (enum) | tylko-odczyt |  |  |
| Serwisant | `App.Operator` | bazodanowe | Serwisant | Serwisant odpowiedzialny za urządzenie |
| Serwisowane | `bool` | bazodanowe | Urządzenie przyjmowane do serwisu | Oznacza możliwość przyjmowania urządzenia do serwisu. |
| Stawka | `Currency` | bazodanowe |  | Stawka za jednostkę czasu wypożyczenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Lista towarów. |
| TowarUsluga | `Soneta.Towary.Towar` | bazodanowe |  | Towar typu usługa, do rozliczenia użycia. |
| TypUrzadzenia | `Soneta.Zadania.TypUrzadzenia` | bazodanowe | Typ urządzenia | Typ urządzenia. |
| TypZaokraglenia | `Soneta.Zadania.TypZaokraglenia` (enum) | bazodanowe |  | Określa rodzaj zaokrąglenia. |
| TypZasobu | `string` | tylko-odczyt |  |  |
| UrzadzeniaUzyte | `SubTable<Soneta.Zadania.UrzadzenieUzyte>` | podlista |  |  |
| Wlasne | `bool` | bazodanowe | Urządzenie własne | Oznacza urządzenie własne. |
| Wypozyczane | `bool` | bazodanowe | Możliwość wypożyczenia urządzenia. | Oznacza możliwość wypożyczania urządzenia. |
| Wypozyczenia | `View` | podlista |  |  |
| ZasobyCRM | `SubTable<Soneta.Zadania.ZasobCRM>` | podlista |  |  |
| Zlecenia | `View` | podlista |  |  |

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
