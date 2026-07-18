# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruchomoscHis`
Nazwa tabeli: `NieruchomosciHis`
Tytuł: Historia nieruchomości
Opis: Element szczegółowy nieruchomości (Nieruchomosc). Przechowuje historyczne wersje danych nieruchomości z okresu ich aktualności. Umożliwia śledzenie zmian parametrów technicznych, własnościowych i lokalizacyjnych obiektu w czasie.
Tabela konfiguracyjna: Nie
Guided: root
Historia: Tak
Implementuje interfejsy: `IDocumentHostCRM`

- pola bazodanowe (zapisywalne): 53
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 15
- podlisty: 5
- subrowy: 0
- razem: 77

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| Aktywne | `bool` | bazodanowe | Aktywne | Wpozwala na określenie, czy nieruchomość jest aktywna |
| AktywnyDo | `Date` | bazodanowe | Aktywny do |  |
| AktywnyOd | `Date` | bazodanowe | Aktywny od |  |
| CanUpdateRealEstateParent | `bool` |  |  |  |
| Cel | `string` | bazodanowe | Cel |  |
| DataBudowy | `Date` | bazodanowe | Data budowy | Data budowy nieruchomości |
| DataDelegalizacji | `Date` | bazodanowe | Data delegalizacji | Data delegalizacji |
| DataInstalacji | `Date` | bazodanowe | Data instalacji | Data instalacji |
| DataKW | `Date` | bazodanowe | Data KW | Data wpisu do księgi wieczystej |
| DataLegalizacji | `Date` | bazodanowe | Data legalizacji | Data legalizacji |
| DataMontazu | `Date` | bazodanowe | Data montażu | Data montażu |
| DataProdukcji | `Date` | bazodanowe | Data produkcji | Data produkcji |
| DataUtworzenia | `Date` | bazodanowe | Data utworzenia | Data utworzenia |
| Dictionary | `string` | tylko-odczyt |  |  |
| Dlugosc | `double` | bazodanowe | Długość | Długość |
| DokumentyCRM | `SubTable<Soneta.Zadania.DokumentCRM>` | podlista |  |  |
| Glowny | `bool` | bazodanowe | Główny |  |
| Identyfikator | `string` |  |  |  |
| Inwentarz | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe | Środek trwały, wyposażenie | Środek trwały, wyposażenie |
| IsReasonRequired | `bool` | tylko-odczyt |  |  |
| IsStandardBuilding | `bool` | tylko-odczyt |  |  |
| IsStandardConstruction | `bool` | tylko-odczyt |  |  |
| IsStandardCounter | `bool` | tylko-odczyt |  |  |
| IsStandardForm | `bool` | tylko-odczyt |  |  |
| IsStandardInstallation | `bool` | tylko-odczyt |  |  |
| IsStandardLot | `bool` | tylko-odczyt |  |  |
| IsStandardParking | `bool` | tylko-odczyt |  |  |
| IsStandardParkingSpot | `bool` | tylko-odczyt |  |  |
| IsStandardPremises | `bool` | tylko-odczyt |  |  |
| IsStandardRoom | `bool` | tylko-odczyt |  |  |
| IsStandardStorey | `bool` | tylko-odczyt |  |  |
| KondygnacjeNad | `int` | bazodanowe | Kondygnacje nadziemne | Ilość kondygnacji nadziemnych |
| KondygnacjePod | `int` | bazodanowe | Kondygnacje podziemne | Ilość kondygnacji podzmienych |
| Kubatura | `double` | bazodanowe | Kubatura | Kubatura |
| LiczbaOsob | `int` | bazodanowe | Liczba osób |  |
| LiczbaStanowisk | `int` | bazodanowe | Maksymalna liczba stanowisk. |  |
| LicznikNadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nadrzędny licznik główny |  |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja urządzenia | Lokalizacja nieruchomości. |
| Nadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nieruchomość nadrzędna | Nieruchomość główna (dla nieruchomości grupowych) lub nieruchomość poprzedzająca. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa nieruchomości |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe, tylko-odczyt |  |  |
| NrEwidencjiGiB | `string` | bazodanowe | Ewidencja Grutów i Budynków |  |
| NrFabryczny | `string` | bazodanowe | Numer fabryczny |  |
| NrPlomby | `string` | bazodanowe | Numer plomby |  |
| Numer | `string` | bazodanowe | Numer |  |
| NumerKW | `string` | bazodanowe | Numer KW | Numer księgi wieczystej |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis nieruchomości |
| OpisAktualizacji | `MemoText` | bazodanowe, podlista | Opis aktualizacji | Opis aktualizacji zapisu |
| PowierzchniaUzytkowa | `double` | bazodanowe | Powierzchnia użytkowa |  |
| PowierzchniaZabudowy | `double` | bazodanowe | Powierzchnia zabudowy |  |
| PowodAktualizacji | `string` | bazodanowe, tylko-odczyt | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| Pozwolenie | `bool` | bazodanowe | Pozwolenie na budowę | Pozwolenie na budowę |
| Producent | `Soneta.CRM.Kontrahent` | bazodanowe | Producent |  |
| PrognozaZuzycia | `double` | bazodanowe | Prognoza zużycia |  |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe | Projekt |  |
| Przeznaczenie | `string` | bazodanowe | Przeznaczenie | Przeznaczenie nieruchomości |
| RezerwujCalePomieszczenie | `bool` | bazodanowe | Rezerwuj całe pomieszczenie | Domyślna opcja rezerwacji całego pomieszczenia dla kierownika. |
| Rodzaj | `string` | bazodanowe | Rodzaj | Rodzaj nieruchomości |
| StanNieruchomosci | `Soneta.RealEstate.Models.Database.Config.StanNieruchomosci` | bazodanowe | Stan obiektu |  |
| Stawka | `Currency` | bazodanowe |  | Stawka za jednostkę czasu wypożyczenia. |
| Symbol | `string` | bazodanowe | Symbol |  |
| Szerokosc | `double` | bazodanowe | Szerokość | Szerokość |
| Technologia | `string` | bazodanowe | Technologia | Technologia nieruchomości |
| TowarUsluga | `Soneta.Towary.Towar` | bazodanowe |  | Towar typu usługa, do rozliczenia użycia. |
| TypZaokraglenia | `Soneta.Zadania.TypZaokraglenia` (enum) | bazodanowe |  | Określa rodzaj zaokrąglenia. |
| Udzial | `double` | bazodanowe | Udział |  |
| UpdateDescription | `string` |  |  |  |
| UpdateReason | `string` |  |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi |  |
| Wartosc | `Currency` | bazodanowe | Wartość |  |
| Wlasciciel | `Soneta.CRM.Kontrahent` | bazodanowe | Właściciel | Właściciel nieruchomości |
| Wlasne | `bool` | bazodanowe | Nieruchomość własna | Oznacza nieruchomość własną. |
| Wypozyczane | `bool` | bazodanowe | Możliwość wypożyczenia nieruchomości. | Oznacza możliwość wypożyczania nieruchmości. |
| Wysokosc | `double` | bazodanowe | Wysokość | Wysokość |
| Zarzadca | `Soneta.CRM.Kontrahent` | bazodanowe | Zarządca | Zarządca nieruchomości |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypZaokraglenia (`Soneta.Zadania.TypZaokraglenia`)
- `Gora` = 0 — W górę
- `Dol` = 1 — W dół
- `DoBliskiejWartosci` = 2 — Do najbliższej wartości
- `Proporcjonalnie` = 3 — Proporcjonalnie
