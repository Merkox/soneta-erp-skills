# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.Config.TypNieruchomosc`
Nazwa tabeli: `TypyNieruchom`
Tytuł: Typy nieruchomości
Opis: Słownik typów nieruchomości określający sposób klasyfikacji obiektów w kartotece. Definiuje rodzaj formularza, prefiks identyfikatora, jednostki odczytu liczników oraz algorytmy przetwarzania dla każdego typu.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnyAlgorytm | `bool` |  |  |  |
| AlgorytmNieruchomosci | `Soneta.RealEstate.AlgorytmNieruchomosci` | bazodanowe |  | Algorytm dla typu nieruchomości |
| AlgorytmNieruchomosci.Aktywny | `bool` | bazodanowe |  |  |
| AlgorytmNieruchomosci.Kod | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ClassName | `string` |  |  |  |
| DefPageXml | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| DefinedType | `System.Type` |  |  |  |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| DomyslnaDefinicja | `Soneta.Zadania.DefZadania` | bazodanowe |  | Domyślna definicja zdarzenia |
| Domyslny | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślny typ nieruchomości. |
| Formularz | `Soneta.RealEstate.Enums.RealEstateFormType` | bazodanowe, enum | Rodzaj formularza | Określa sposób wyświetlania formularza |
| JednostkaOdczytu | `string` | bazodanowe | Jednostka odczytu | Jednostka odczytu pomiaru licznika |
| Kod | `string` |  |  |  |
| KodAlgorytmu | `Soneta.Business.MemoText` |  |  |  |
| LenIdent | `int` | bazodanowe |  | Długość kodu identyfikatora. |
| Namespace | `object` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa rodzaju nieruchomości. |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| Precyzja | `int` | bazodanowe | Precyzja zaokrąglenia ilości. |  |
| PrefixIdent | `string` | bazodanowe | Prefix identyfilatora | Prefix identyfikatora nieruchomości. |
| PrzeniesOdczyt | `bool` | bazodanowe | Przeniesienie odczytu | Automatyczne przenoszenie odczytu do powiązanych umów |
| Rodzaj | `Soneta.RealEstate.Enums.RealEstateKind` | bazodanowe, enum | Rodzaj nieruchomości |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Stany | `Soneta.Business.LpSubTable<Soneta.RealEstate.Models.Database.Config.StanNieruchomosci>` |  |  |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol rodzaju nieruchomości. |
| Udostepnione | `bool` | bazodanowe | Pomieszczenie udostępnione do rezerwacji. |  |
| UkryjWStrukturze | `bool` | bazodanowe | Obiekt niewidoczny w strukturze nieruchomości |  |
| Xml | `Soneta.Business.MemoText` |  |  |  |

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
