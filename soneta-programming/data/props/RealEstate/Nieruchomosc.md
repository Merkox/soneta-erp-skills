# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Nieruchomosc`
Nazwa tabeli: `Nieruchomosci`
Tytuł: Nieruchomości
Opis: Główna kartoteka nieruchomości obejmująca budynki, lokale, pomieszczenia i liczniki. Przechowuje dane techniczne, lokalizacyjne, własnościowe oraz parametry handlowe obiektu. Obsługuje hierarchiczną strukturę nieruchomości nadrzędnych i podrzędnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZasobCRM`, `IDocumentHostCRM`, `IObiektDoPlanowania`

- pola bazodanowe: 60
- pola kalkulowane (z klas biznesowych): 27

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActualDate | `Soneta.Business.ActualDate` |  |  |  |
| Aktywne | `bool` | bazodanowe | Aktywne | Wpozwala na określenie, czy nieruchomość jest aktywna |
| AktywnyDo | `Soneta.Types.Date` | bazodanowe | Aktywny do |  |
| AktywnyOd | `Soneta.Types.Date` | bazodanowe | Aktywny od |  |
| BudynekNadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` |  | Budynek nadrzędny |  |
| Cel | `string` | bazodanowe | Cel |  |
| DataBudowy | `Soneta.Types.Date` | bazodanowe | Data budowy | Data budowy nieruchomości |
| DataDelegalizacji | `Soneta.Types.Date` | bazodanowe | Data delegalizacji | Data delegalizacji |
| DataInstalacji | `Soneta.Types.Date` | bazodanowe | Data instalacji | Data instalacji |
| DataKW | `Soneta.Types.Date` | bazodanowe | Data KW | Data wpisu do księgi wieczystej |
| DataLegalizacji | `Soneta.Types.Date` | bazodanowe | Data legalizacji | Data legalizacji |
| DataMontazu | `Soneta.Types.Date` | bazodanowe | Data montażu | Data montażu |
| DataProdukcji | `Soneta.Types.Date` | bazodanowe | Data produkcji | Data produkcji |
| DataUtworzenia | `Soneta.Types.Date` | bazodanowe | Data utworzenia | Data utworzenia |
| DeviceParentContext | `Soneta.RealEstate.Models.Database.Nieruchomosc` |  |  |  |
| Dlugosc | `double` | bazodanowe | Długość | Długość |
| DokumentyCRM | `Soneta.Business.SubTable<Soneta.Zadania.DokumentCRM>` |  |  |  |
| FocusedName | `string` |  |  |  |
| Glowny | `bool` | bazodanowe | Główny |  |
| Historia | `Soneta.Business.HistorySubTable` |  |  |  |
| HistoriaPodleglosci | `Soneta.Business.FromToSubTable<Soneta.RealEstate.Models.Database.NieruchomoscRef>` |  |  |  |
| HistoriaZmian | `Soneta.Business.HistorySubTable<Soneta.RealEstate.Models.Database.NieruchomoscHis>` |  |  |  |
| Identyfikator | `string` | bazodanowe | Identyfikator | Unikalny identyfikator nieruchomości |
| Inwentarz | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe | Środek trwały, wyposażenie | Środek trwały, wyposażenie |
| KodZasobu | `string` |  |  |  |
| KondygnacjeNad | `int` | bazodanowe | Kondygnacje nadziemne | Ilość kondygnacji nadziemnych |
| KondygnacjePod | `int` | bazodanowe | Kondygnacje podziemne | Ilość kondygnacji podzmienych |
| Kubatura | `double` | bazodanowe | Kubatura | Kubatura |
| Last | `Soneta.RealEstate.Models.Database.NieruchomoscHis` |  |  |  |
| LiczbaOsob | `int` | bazodanowe | Liczba osób |  |
| LiczbaStanowisk | `int` | bazodanowe | Maksymalna liczba stanowisk. |  |
| LicznikNadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nadrzędny licznik główny |  |
| LicznikiPodrzedne | `Soneta.RealEstate.Models.Database.Nieruchomosc[]` |  |  |  |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja nieruchomości | Lokalizacja nieruchomości. |
| Nadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nieruchomość nadrzędna | Nieruchomość główna (dla nieruchomości grupowych) lub nieruchomość poprzedzająca. |
| NadrzednyId | `int` |  |  |  |
| NadrzednyIdentyfikator | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa nieruchomości |
| NazwaZasobu | `string` |  |  |  |
| NieruchomosciUzyte | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.NieruchomoscUzyta>` |  |  |  |
| NrEwidencjiGiB | `string` | bazodanowe | Ewidencja Grutów i Budynków |  |
| NrFabryczny | `string` | bazodanowe | Numer fabryczny |  |
| NrPlomby | `string` | bazodanowe | Numer plomby |  |
| Numer | `string` | bazodanowe | Numer |  |
| NumerKW | `string` | bazodanowe | Numer KW | Numer księgi wieczystej |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis nieruchomości |
| Podelementy | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.Nieruchomosc>` |  |  |  |
| PodelementyWgAktualnosci | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.NieruchomoscRef>` |  |  |  |
| Podrzedne | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.Nieruchomosc>` |  |  |  |
| PodrzedneWgAktualnosci | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.NieruchomoscRef>` |  |  |  |
| PowierzchniaUzytkowa | `double` | bazodanowe | Powierzchnia użytkowa |  |
| PowierzchniaZabudowy | `double` | bazodanowe | Powierzchnia zabudowy |  |
| Pozwolenie | `bool` | bazodanowe | Pozwolenie na budowę | Pozwolenie na budowę |
| Producent | `Soneta.CRM.Kontrahent` | bazodanowe | Producent |  |
| PrognozaZuzycia | `double` | bazodanowe | Prognoza zużycia |  |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe | Projekt |  |
| Przeznaczenie | `string` | bazodanowe | Przeznaczenie | Przeznaczenie nieruchomości |
| RezerwujCalePomieszczenie | `bool` | bazodanowe | Rezerwuj całe pomieszczenie | Domyślna opcja rezerwacji całego pomieszczenia dla kierownika. |
| Rodzaj | `string` | bazodanowe | Rodzaj | Rodzaj nieruchomości |
| RodzajNieruchomosci | `Soneta.RealEstate.Enums.RealEstateKind` | bazodanowe, enum | Rodzaj nieruchomości |  |
| RozliczeniaLokalu | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.RozliczenieMediow>` |  |  |  |
| RozliczeniaNieruchomosci | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.RozliczenieMediow>` |  |  |  |
| SerializedDiagram | `Soneta.Business.MemoText` | bazodanowe | Serializowane dane diagramu | Określa serializowane dane diagramu |
| SrodkiTrwale | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.NieruSrTrwalyRel>` |  |  |  |
| StanNieruchomosci | `Soneta.RealEstate.Models.Database.Config.StanNieruchomosci` | bazodanowe | Stan obiektu |  |
| Stawka | `Soneta.Types.Currency` | bazodanowe |  | Stawka za jednostkę czasu wypożyczenia. |
| Symbol | `string` | bazodanowe | Symbol |  |
| Szerokosc | `double` | bazodanowe | Szerokość | Szerokość |
| Technologia | `string` | bazodanowe | Technologia | Technologia nieruchomości |
| TowarUsluga | `Soneta.Towary.Towar` | bazodanowe |  | Towar typu usługa, do rozliczenia użycia. |
| Towary | `Soneta.Business.SubTable<Soneta.RealEstate.UslugaNieruch>` |  |  |  |
| TypNieruchomosc | `Soneta.RealEstate.Models.Database.Config.TypNieruchomosc` | bazodanowe | Typ nieruchomości | Typ nieruchomości. |
| TypZaokraglenia | `Soneta.Zadania.TypZaokraglenia` | bazodanowe, enum |  | Określa rodzaj zaokrąglenia. |
| TypZasobu | `string` |  |  |  |
| UILocation | `Soneta.Types.UILocation` |  |  |  |
| Udzial | `double` | bazodanowe | Udział |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość |  |
| Wlasciciel | `Soneta.CRM.Kontrahent` | bazodanowe | Właściciel | Właściciel nieruchomości |
| Wlasne | `bool` | bazodanowe | Nieruchomość własna | Oznacza nieruchomość własną. |
| Wydzialy | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.NieruWydzialRel>` |  |  |  |
| Wypozyczane | `bool` | bazodanowe | Możliwość wypożyczenia nieruchomości. | Oznacza możliwość wypożyczania nieruchmości. |
| Wysokosc | `double` | bazodanowe | Wysokość | Wysokość |
| Zarzadca | `Soneta.CRM.Kontrahent` | bazodanowe | Zarządca | Zarządca nieruchomości |
| ZasobyCRM | `Soneta.Business.SubTable` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RealEstateKind (`Soneta.RealEstate.Enums.RealEstateKind`)
- `Counter` = 0 — Licznik
- `Building` = 1 — Budynek
- `Construction` = 2 — Budowla
- `Storey` = 3 — Kondygnacja
- `Room` = 4 — Pomieszczenie
- `Premises` = 5 — Lokal
- `Lot` = 6 — Działka
- `Installation` = 7 — Instalacja
- `Parking` = 8
- `ParkingSpot` = 9 — Miejsce postojowe
- `All` = 100 — Wszystkie

### TypZaokraglenia (`Soneta.Zadania.TypZaokraglenia`)
- `Gora` = 0 — W górę
- `Dol` = 1 — W dół
- `DoBliskiejWartosci` = 2 — Do najbliższej wartości
- `Proporcjonalnie` = 3 — Proporcjonalnie
