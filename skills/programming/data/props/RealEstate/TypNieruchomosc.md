# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Config.TypNieruchomosc`
Nazwa tabeli: `TypyNieruchom`
Tytuł: Typy nieruchomości
Opis: Słownik typów nieruchomości określający sposób klasyfikacji obiektów w kartotece. Definiuje rodzaj formularza, prefiks identyfikatora, jednostki odczytu liczników oraz algorytmy przetwarzania dla każdego typu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`
Selektor: pole `Rodzaj` (`Soneta.RealEstate.Enums.RealEstateKind`) — wiele typów w jednej tabeli, podtypów: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmNieruchomosci | `Soneta.RealEstate.AlgorytmNieruchomosci` (subrow) | bazodanowe |  | Algorytm dla typu nieruchomości |
| AlgorytmNieruchomosci.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmNieruchomosci.Kod | `MemoText` | bazodanowe, podlista |  |  |
| ClassName | `string` | tylko-odczyt |  |  |
| DefPageXml | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika. |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| DefinedType | `System.Type` | tylko-odczyt |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| DomyslnaDefinicja | `Soneta.Zadania.DefZadania` | bazodanowe |  | Domyślna definicja zdarzenia |
| Domyslny | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślny typ nieruchomości. |
| Formularz | `Soneta.RealEstate.Enums.RealEstateFormType` (enum) | bazodanowe | Rodzaj formularza | Określa sposób wyświetlania formularza |
| JednostkaOdczytu | `string` | bazodanowe | Jednostka odczytu | Jednostka odczytu pomiaru licznika |
| Kod | `string` | tylko-odczyt |  |  |
| KodAlgorytmu | `MemoText` | podlista |  |  |
| LenIdent | `int` | bazodanowe |  | Długość kodu identyfikatora. |
| Namespace | `object` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa rodzaju nieruchomości. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Precyzja | `int` | bazodanowe | Precyzja zaokrąglenia ilości. |  |
| PrefixIdent | `string` | bazodanowe | Prefix identyfilatora | Prefix identyfikatora nieruchomości. |
| PrzeniesOdczyt | `bool` | bazodanowe | Przeniesienie odczytu | Automatyczne przenoszenie odczytu do powiązanych umów |
| Rodzaj | `Soneta.RealEstate.Enums.RealEstateKind` (enum) | bazodanowe, tylko-odczyt, selektor | Rodzaj nieruchomości |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Stany | `LpSubTable<Soneta.RealEstate.Models.Database.Config.StanNieruchomosci>` | podlista |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol rodzaju nieruchomości. |
| Udostepnione | `bool` | bazodanowe | Pomieszczenie udostępnione do rezerwacji. |  |
| UkryjWStrukturze | `bool` | bazodanowe | Obiekt niewidoczny w strukturze nieruchomości |  |
| Xml | `MemoText` | podlista |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Counter` | 0 | `Soneta.RealEstate.Models.Config.TypLicznika` | Typ licznika |
| `Building` | 1 | `Soneta.RealEstate.Models.Config.TypBudynku` | Typ budynku |
| `Construction` | 2 | `Soneta.RealEstate.Models.Config.TypBudowli` | Typ budowli |
| `Storey` | 3 | `Soneta.RealEstate.Models.Config.TypKondygnacji` | Typ kondygnacji |
| `Room` | 4 | `Soneta.RealEstate.Models.Config.TypPomieszczenia` | Typ pomieszczenia |
| `Premises` | 5 | `Soneta.RealEstate.Models.Config.TypLokalu` | Typ lokalu |
| `Lot` | 6 | `Soneta.RealEstate.Models.Config.TypDzialki` | Typ działki |
| `Installation` | 7 | `Soneta.RealEstate.Models.Config.TypInstalacji` | Typ instalacji |
| `Parking` | 8 | `Soneta.RealEstate.Models.Config.TypParkingu` | Typ parkingu |
| `ParkingSpot` | 9 | `Soneta.RealEstate.Models.Config.TypMiejscaPostojowego` | Typ miejsca postojowego |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RealEstateFormType (`Soneta.RealEstate.Enums.RealEstateFormType`)
- `Standard` = 0 — Zwykły
- `User` = 1 — Użytkownika

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
