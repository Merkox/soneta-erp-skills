# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruchomoscHis`
Nazwa tabeli: `NieruchomosciHis`
Tytuł: Historia nieruchomości
Opis: Element szczegółowy nieruchomości (Nieruchomosc). Przechowuje historyczne wersje danych nieruchomości z okresu ich aktualności. Umożliwia śledzenie zmian parametrów technicznych, własnościowych i lokalizacyjnych obiektu w czasie.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDocumentHostCRM`

- pola bazodanowe: 59
- pola kalkulowane (z klas biznesowych): 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Aktywne | `bool` | bazodanowe | Aktywne | Wpozwala na określenie, czy nieruchomość jest aktywna |
| AktywnyDo | `Soneta.Types.Date` | bazodanowe | Aktywny do |  |
| AktywnyOd | `Soneta.Types.Date` | bazodanowe | Aktywny od |  |
| CanUpdateRealEstateParent | `bool` |  |  |  |
| Cel | `string` | bazodanowe | Cel |  |
| DataBudowy | `Soneta.Types.Date` | bazodanowe | Data budowy | Data budowy nieruchomości |
| DataDelegalizacji | `Soneta.Types.Date` | bazodanowe | Data delegalizacji | Data delegalizacji |
| DataInstalacji | `Soneta.Types.Date` | bazodanowe | Data instalacji | Data instalacji |
| DataKW | `Soneta.Types.Date` | bazodanowe | Data KW | Data wpisu do księgi wieczystej |
| DataLegalizacji | `Soneta.Types.Date` | bazodanowe | Data legalizacji | Data legalizacji |
| DataMontazu | `Soneta.Types.Date` | bazodanowe | Data montażu | Data montażu |
| DataProdukcji | `Soneta.Types.Date` | bazodanowe | Data produkcji | Data produkcji |
| DataUtworzenia | `Soneta.Types.Date` | bazodanowe | Data utworzenia | Data utworzenia |
| Dictionary | `string` |  |  |  |
| Dlugosc | `double` | bazodanowe | Długość | Długość |
| DokumentyCRM | `Soneta.Business.SubTable<Soneta.Zadania.DokumentCRM>` |  |  |  |
| Glowny | `bool` | bazodanowe | Główny |  |
| Identyfikator | `string` |  |  |  |
| Inwentarz | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe | Środek trwały, wyposażenie | Środek trwały, wyposażenie |
| IsReasonRequired | `bool` |  |  |  |
| IsStandardBuilding | `bool` |  |  |  |
| IsStandardConstruction | `bool` |  |  |  |
| IsStandardCounter | `bool` |  |  |  |
| IsStandardForm | `bool` |  |  |  |
| IsStandardInstallation | `bool` |  |  |  |
| IsStandardLot | `bool` |  |  |  |
| IsStandardParking | `bool` |  |  |  |
| IsStandardParkingSpot | `bool` |  |  |  |
| IsStandardPremises | `bool` |  |  |  |
| IsStandardRoom | `bool` |  |  |  |
| IsStandardStorey | `bool` |  |  |  |
| KondygnacjeNad | `int` | bazodanowe | Kondygnacje nadziemne | Ilość kondygnacji nadziemnych |
| KondygnacjePod | `int` | bazodanowe | Kondygnacje podziemne | Ilość kondygnacji podzmienych |
| Kubatura | `double` | bazodanowe | Kubatura | Kubatura |
| LiczbaOsob | `int` | bazodanowe | Liczba osób |  |
| LiczbaStanowisk | `int` | bazodanowe | Maksymalna liczba stanowisk. |  |
| LicznikNadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nadrzędny licznik główny |  |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja urządzenia | Lokalizacja nieruchomości. |
| Nadrzedny | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nieruchomość nadrzędna | Nieruchomość główna (dla nieruchomości grupowych) lub nieruchomość poprzedzająca. |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa nieruchomości |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
| NrEwidencjiGiB | `string` | bazodanowe | Ewidencja Grutów i Budynków |  |
| NrFabryczny | `string` | bazodanowe | Numer fabryczny |  |
| NrPlomby | `string` | bazodanowe | Numer plomby |  |
| Numer | `string` | bazodanowe | Numer |  |
| NumerKW | `string` | bazodanowe | Numer KW | Numer księgi wieczystej |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis nieruchomości |
| OpisAktualizacji | `Soneta.Business.MemoText` | bazodanowe | Opis aktualizacji | Opis aktualizacji zapisu |
| PowierzchniaUzytkowa | `double` | bazodanowe | Powierzchnia użytkowa |  |
| PowierzchniaZabudowy | `double` | bazodanowe | Powierzchnia zabudowy |  |
| PowodAktualizacji | `string` | bazodanowe | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| Pozwolenie | `bool` | bazodanowe | Pozwolenie na budowę | Pozwolenie na budowę |
| Producent | `Soneta.CRM.Kontrahent` | bazodanowe | Producent |  |
| PrognozaZuzycia | `double` | bazodanowe | Prognoza zużycia |  |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe | Projekt |  |
| Przeznaczenie | `string` | bazodanowe | Przeznaczenie | Przeznaczenie nieruchomości |
| RezerwujCalePomieszczenie | `bool` | bazodanowe | Rezerwuj całe pomieszczenie | Domyślna opcja rezerwacji całego pomieszczenia dla kierownika. |
| Rodzaj | `string` | bazodanowe | Rodzaj | Rodzaj nieruchomości |
| StanNieruchomosci | `Soneta.RealEstate.Models.Database.Config.StanNieruchomosci` | bazodanowe | Stan obiektu |  |
| Stawka | `Soneta.Types.Currency` | bazodanowe |  | Stawka za jednostkę czasu wypożyczenia. |
| Symbol | `string` | bazodanowe | Symbol |  |
| Szerokosc | `double` | bazodanowe | Szerokość | Szerokość |
| Technologia | `string` | bazodanowe | Technologia | Technologia nieruchomości |
| TowarUsluga | `Soneta.Towary.Towar` | bazodanowe |  | Towar typu usługa, do rozliczenia użycia. |
| TypZaokraglenia | `Soneta.Zadania.TypZaokraglenia` | bazodanowe, enum |  | Określa rodzaj zaokrąglenia. |
| Udzial | `double` | bazodanowe | Udział |  |
| UpdateDescription | `string` |  |  |  |
| UpdateReason | `string` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość |  |
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
