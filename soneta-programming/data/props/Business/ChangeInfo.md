# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.ChangeInfo`
Nazwa tabeli: `ChangeInfos`
Tytuł: Historia zmian
Opis: Rejestr zmian dokonanych na obiektach w systemie. Przechowuje informacje o operatorze, typie zmiany, dacie i szczegółach modyfikacji dla celów audytu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 17
- podlisty: 2
- subrowy: 0
- razem: 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `MemoText` | bazodanowe, podlista | Dane dodatkowe | Dodatkowa informacja o danym zgłoszeniu. |
| Godzina | `Time` | tylko-odczyt |  | Godzina wystąpienia tej zmiany. |
| HasAssignedTimeTrack | `bool` | tylko-odczyt |  |  |
| Info | `string` | bazodanowe, tylko-odczyt | Informacje | Dodatkowa informacja o danym zgłoszeniu. |
| LoggedWebOperator | `IWebOperator` | bazodanowe, tylko-odczyt, iface-ref | Fizycznie zalogowany operator | Fizycznie zalogowany WebOperator |
| LoggedWebOperatorId | `int` | tylko-odczyt |  |  |
| LoggedWebOperatorType | `string` | bazodanowe, tylko-odczyt |  | Fizycznie zalogowany WebOperator |
| NoteToChange | `MemoText` | bazodanowe, podlista | Uwagi do zmian | Uwagi do zmian wymagane w metryce dokumentów. |
| Operator | `App.Operator` | bazodanowe, tylko-odczyt |  | Operator, który był zalogowany do systemu, który utworzył to zgłoszenie. |
| Row | `GuidedRow` | tylko-odczyt | Zapis | Zmieniony zapis o ile nie został wcześniej skasowany. |
| SourceGuid | `System.Guid` | bazodanowe, tylko-odczyt | Guid źródła | Unikalny identyfikator zapisu, do którego zostało wywołane zgłoszenie. |
| SourceTable | `string` | bazodanowe, tylko-odczyt | Tabela źródła | Nazwa tabeli bazy danych zawierającej zapis, do którego zostało wywołane zgłoszenie. |
| TaskUser | `ITaskUser` | tylko-odczyt, iface-ref |  |  |
| Time | `System.DateTime` | bazodanowe, tylko-odczyt | Dzień | Data wystąpienia zgłoszenia. |
| Type | `ChangeInfoType` (enum) | bazodanowe, tylko-odczyt | Typ | Typ zgłoszenia określający powód jego zgłoszenia. |
| WebOperator | `IWebOperator` | bazodanowe, tylko-odczyt, iface-ref | Użytkownik aplikacji web'owej | Informacje o uzytkowniku aplikacji web'owej |
| WebOperatorId | `int` | tylko-odczyt |  |  |
| WebOperatorType | `string` | bazodanowe, tylko-odczyt |  | Informacje o uzytkowniku aplikacji web'owej |
| WebUser | `string` | bazodanowe, tylko-odczyt | Operator systemu | Operator zalogowany do systemu. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| LoggedWebOperator | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |
| TaskUser | `ITaskUser` | `KontaktOsoba`, `Operator`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego`, `WykladowcaSzkol` |
| WebOperator | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ChangeInfoType (`ChangeInfoType`)
- `Created` = 1 — Utworzony
- `Modified` = 2 — Zmieniony
- `Imported` = 3 — Importowany
- `Deleted` = 4 — Skasowany
- `Accepted` = 5 — Zatwierdzony
- `Rejected` = 6 — Do bufora
- `Login` = 7 — Logowanie
- `Logout` = 8 — Wylogowanie
- `Exported` = 9 — Eksportowany
- `ChangePassword` = 10 — Zmiana hasła
- `Canceled` = 11 — Anulowany
- `CurrentDayChanged` = 12 — Zmiana bieżącej daty
- `LoginFailed` = 13 — Nieudane logowanie
- `Reference` = 14 — Referencja
- `Bundle` = 15
- `Wprowadzony` = 20
- `Predekretowany` = 21
- `Zaksięgowany` = 22
- `WysłanyDoBanku` = 30
- `TableView` = 40 — Widok listy
- `FormView` = 41 — Formularz
- `Report` = 42 — Raport
- `XtraReport` = 43 — Raport DX
- `Fiscalized` = 50 — Dokument zafiskalizowany
- `ReceiptPrinted` = 51 — Paragon wydrukowany
- `Anonimizated` = 52 — Anonimizacja
- `Pseudonimizated` = 53 — Pseudonimizacja
- `ServiceDatabaseObfuscation` = 54 — Anonimizacja serwisowa bazy
- `Send` = 61 — Wysłano e-mail
- `SendException` = 62 — Błąd wysyłania e-mail
- `Signed` = 100 — Podpisany
- `OperacjaEDI` = 110 — Operacja EDI
- `ProcesKSeF` = 111 — Proces KSeF
- `OperacjaPUESC` = 120 — Operacja PUESC
- `SavingList` = 130 — Zapis ustawień tabeli
- `User` = 1000 — Inne
- `DbConversion` = 2000 — Konwersja bazy
