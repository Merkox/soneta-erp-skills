# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Nieruchomosc`
Nazwa tabeli: `Nieruchomosci`
Tytuł: Nieruchomości
Opis: Główna kartoteka nieruchomości obejmująca budynki, lokale, pomieszczenia i liczniki. Przechowuje dane techniczne, lokalizacyjne, własnościowe oraz parametry handlowe obiektu. Obsługuje hierarchiczną strukturę nieruchomości nadrzędnych i podrzędnych.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `NieruchomoscHis`
Implementuje interfejsy: `IZasobCRM`, `IDocumentHostCRM`, `IObiektDoPlanowania`
Selektor: pole `RodzajNieruchomosci` (`Soneta.RealEstate.Enums.RealEstateKind`) — wiele typów w jednej tabeli, podtypów: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActualDate | `ActualDate` |  |  |  |
| Aktywne | `bool` | bazodanowe | Aktywne | Wpozwala na określenie, czy nieruchomość jest aktywna |
| AktywnyDo | `Date` | bazodanowe | Aktywny do |  |
| AktywnyOd | `Date` | bazodanowe | Aktywny od |  |
| BudynekNadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | tylko-odczyt | Budynek nadrzędny |  |
| Cel | `string` | bazodanowe | Cel |  |
| DataBudowy | `Date` | bazodanowe | Data budowy | Data budowy nieruchomości |
| DataDelegalizacji | `Date` | bazodanowe | Data delegalizacji | Data delegalizacji |
| DataInstalacji | `Date` | bazodanowe | Data instalacji | Data instalacji |
| DataKW | `Date` | bazodanowe | Data KW | Data wpisu do księgi wieczystej |
| DataLegalizacji | `Date` | bazodanowe | Data legalizacji | Data legalizacji |
| DataMontazu | `Date` | bazodanowe | Data montażu | Data montażu |
| DataProdukcji | `Date` | bazodanowe | Data produkcji | Data produkcji |
| DataUtworzenia | `Date` | bazodanowe | Data utworzenia | Data utworzenia |
| DeviceParentContext | `Soneta.RealEstate.Models.Database.Nieruchomosc` |  |  |  |
| Dlugosc | `double` | bazodanowe | Długość | Długość |
| DokumentyCRM | `SubTable<Soneta.Zadania.DokumentCRM>` | podlista |  |  |
| FocusedName | `string` | tylko-odczyt |  |  |
| Glowny | `bool` | bazodanowe | Główny |  |
| Historia | `HistorySubTable` | podlista |  |  |
| HistoriaPodleglosci | `FromToSubTable<Soneta.RealEstate.Models.Database.NieruchomoscRef>` | podlista |  |  |
| HistoriaZmian | `HistorySubTable<Soneta.RealEstate.Models.Database.NieruchomoscHis>` | podlista |  |  |
| Identyfikator | `string` | bazodanowe | Identyfikator | Unikalny identyfikator nieruchomości |
| Inwentarz | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe | Środek trwały, wyposażenie | Środek trwały, wyposażenie |
| KodZasobu | `string` | tylko-odczyt |  |  |
| KondygnacjeNad | `int` | bazodanowe | Kondygnacje nadziemne | Ilość kondygnacji nadziemnych |
| KondygnacjePod | `int` | bazodanowe | Kondygnacje podziemne | Ilość kondygnacji podzmienych |
| Kubatura | `double` | bazodanowe | Kubatura | Kubatura |
| Last | `Soneta.RealEstate.Models.Database.NieruchomoscHis` | tylko-odczyt |  |  |
| LiczbaOsob | `int` | bazodanowe | Liczba osób |  |
| LiczbaStanowisk | `int` | bazodanowe | Maksymalna liczba stanowisk. |  |
| LicznikNadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nadrzędny licznik główny |  |
| LicznikiPodrzedne | `Soneta.RealEstate.Models.Database.Nieruchomosc[]` | podlista |  |  |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja nieruchomości | Lokalizacja nieruchomości. |
| Nadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe, tylko-odczyt | Nieruchomość nadrzędna | Nieruchomość główna (dla nieruchomości grupowych) lub nieruchomość poprzedzająca. |
| NadrzednyId | `int` |  |  |  |
| NadrzednyIdentyfikator | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa nieruchomości |
| NazwaZasobu | `string` | tylko-odczyt |  |  |
| NieruchomosciUzyte | `SubTable<Soneta.RealEstate.Models.Database.NieruchomoscUzyta>` | podlista |  |  |
| NrEwidencjiGiB | `string` | bazodanowe | Ewidencja Grutów i Budynków |  |
| NrFabryczny | `string` | bazodanowe | Numer fabryczny |  |
| NrPlomby | `string` | bazodanowe | Numer plomby |  |
| Numer | `string` | bazodanowe | Numer |  |
| NumerKW | `string` | bazodanowe | Numer KW | Numer księgi wieczystej |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis nieruchomości |
| Podelementy | `SubTable<Soneta.RealEstate.Models.Database.Nieruchomosc>` | podlista |  |  |
| PodelementyWgAktualnosci | `SubTable<Soneta.RealEstate.Models.Database.NieruchomoscRef>` | podlista |  |  |
| Podrzedne | `SubTable<Soneta.RealEstate.Models.Database.Nieruchomosc>` | podlista |  |  |
| PodrzedneWgAktualnosci | `SubTable<Soneta.RealEstate.Models.Database.NieruchomoscRef>` | podlista |  |  |
| PowierzchniaUzytkowa | `double` | bazodanowe | Powierzchnia użytkowa |  |
| PowierzchniaZabudowy | `double` | bazodanowe | Powierzchnia zabudowy |  |
| Pozwolenie | `bool` | bazodanowe | Pozwolenie na budowę | Pozwolenie na budowę |
| Producent | `Soneta.CRM.Kontrahent` | bazodanowe | Producent |  |
| PrognozaZuzycia | `double` | bazodanowe | Prognoza zużycia |  |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe | Projekt |  |
| Przeznaczenie | `string` | bazodanowe | Przeznaczenie | Przeznaczenie nieruchomości |
| RezerwujCalePomieszczenie | `bool` | bazodanowe | Rezerwuj całe pomieszczenie | Domyślna opcja rezerwacji całego pomieszczenia dla kierownika. |
| Rodzaj | `string` | bazodanowe | Rodzaj | Rodzaj nieruchomości |
| RodzajNieruchomosci | `Soneta.RealEstate.Enums.RealEstateKind` (enum) | bazodanowe, tylko-odczyt, selektor | Rodzaj nieruchomości |  |
| RozliczeniaLokalu | `SubTable<Soneta.RealEstate.Models.Database.RozliczenieMediow>` | podlista |  |  |
| RozliczeniaNieruchomosci | `SubTable<Soneta.RealEstate.Models.Database.RozliczenieMediow>` | podlista |  |  |
| SerializedDiagram | `MemoText` | bazodanowe, podlista | Serializowane dane diagramu | Określa serializowane dane diagramu |
| SrodkiTrwale | `SubTable<Soneta.RealEstate.Models.Database.NieruSrTrwalyRel>` | podlista |  |  |
| StanNieruchomosci | `Soneta.RealEstate.Models.Database.Config.StanNieruchomosci` | bazodanowe | Stan obiektu |  |
| Stawka | `Currency` | bazodanowe |  | Stawka za jednostkę czasu wypożyczenia. |
| Symbol | `string` | bazodanowe | Symbol |  |
| Szerokosc | `double` | bazodanowe | Szerokość | Szerokość |
| Technologia | `string` | bazodanowe | Technologia | Technologia nieruchomości |
| TowarUsluga | `Soneta.Towary.Towar` | bazodanowe |  | Towar typu usługa, do rozliczenia użycia. |
| Towary | `SubTable<Soneta.RealEstate.UslugaNieruch>` | podlista |  |  |
| TypNieruchomosc | `Soneta.RealEstate.Models.Database.Config.TypNieruchomosc` | bazodanowe | Typ nieruchomości | Typ nieruchomości. |
| TypZaokraglenia | `Soneta.Zadania.TypZaokraglenia` (enum) | bazodanowe |  | Określa rodzaj zaokrąglenia. |
| TypZasobu | `string` | tylko-odczyt |  |  |
| UILocation | `UILocation` |  |  |  |
| Udzial | `double` | bazodanowe | Udział |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi |  |
| Wartosc | `Currency` | bazodanowe | Wartość |  |
| Wlasciciel | `Soneta.CRM.Kontrahent` | bazodanowe | Właściciel | Właściciel nieruchomości |
| Wlasne | `bool` | bazodanowe | Nieruchomość własna | Oznacza nieruchomość własną. |
| Wydzialy | `SubTable<Soneta.RealEstate.Models.Database.NieruWydzialRel>` | podlista |  |  |
| Wypozyczane | `bool` | bazodanowe | Możliwość wypożyczenia nieruchomości. | Oznacza możliwość wypożyczania nieruchmości. |
| Wysokosc | `double` | bazodanowe | Wysokość | Wysokość |
| Zarzadca | `Soneta.CRM.Kontrahent` | bazodanowe | Zarządca | Zarządca nieruchomości |
| ZasobyCRM | `SubTable` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `RodzajNieruchomosci`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Counter` | 0 | `Soneta.RealEstate.Models.RealEstateCounter` | Licznik |
| `Building` | 1 | `Soneta.RealEstate.Models.RealEstateBuilding` | Budynek |
| `Construction` | 2 | `Soneta.RealEstate.Models.RealEstateConstruction` | Budowla |
| `Storey` | 3 | `Soneta.RealEstate.Models.RealEstateStorey` | Kondygnacja |
| `Room` | 4 | `Soneta.RealEstate.Models.RealEstateRoom` | Pomieszczenie |
| `Premises` | 5 | `Soneta.RealEstate.Models.RealEstatePremises` | Lokal |
| `Lot` | 6 | `Soneta.RealEstate.Models.RealEstateLot` | Działka |
| `Installation` | 7 | `Soneta.RealEstate.Models.RealEstateInstallation` | Instalacja |
| `Parking` | 8 | `Soneta.RealEstate.Models.RealEstateParking` | Parking |
| `ParkingSpot` | 9 | `Soneta.RealEstate.Models.RealEstateParkingSpot` | Parking |

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
