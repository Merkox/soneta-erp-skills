# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Config.TypNieruchomosc`
Nazwa tabeli: `TypyNieruchom`
Tytuł: Typy nieruchomości
Opis: Słownik typów nieruchomości określający sposób klasyfikacji obiektów w kartotece. Definiuje rodzaj formularza, prefiks identyfikatora, jednostki odczytu liczników oraz algorytmy przetwarzania dla każdego typu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 8
- podlisty: 7
- subrowy: 2
- razem: 35

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
| Rodzaj | `Soneta.RealEstate.Enums.RealEstateKind` (enum) | bazodanowe, tylko-odczyt | Rodzaj nieruchomości |  |
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
