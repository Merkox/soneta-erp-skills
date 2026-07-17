# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.ChangeInfo`
Nazwa tabeli: `ChangeInfos`
Tytuł: Historia zmian
Opis: Rejestr zmian dokonanych na obiektach w systemie. Przechowuje informacje o operatorze, typie zmiany, dacie i szczegółach modyfikacji dla celów audytu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 13
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Business.MemoText` | bazodanowe | Dane dodatkowe | Dodatkowa informacja o danym zgłoszeniu. |
| Godzina | `Soneta.Types.Time` |  |  | Godzina wystąpienia tej zmiany. |
| HasAssignedTimeTrack | `bool` |  |  |  |
| Info | `string` | bazodanowe | Informacje | Dodatkowa informacja o danym zgłoszeniu. |
| LoggedWebOperator | `Soneta.Business.IWebOperator` | bazodanowe, iface-ref | Fizycznie zalogowany operator | Fizycznie zalogowany WebOperator |
| LoggedWebOperatorId | `int` |  |  |  |
| LoggedWebOperatorType | `string` | bazodanowe |  | Fizycznie zalogowany WebOperator |
| NoteToChange | `Soneta.Business.MemoText` | bazodanowe | Uwagi do zmian | Uwagi do zmian wymagane w metryce dokumentów. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator, który był zalogowany do systemu, który utworzył to zgłoszenie. |
| Row | `Soneta.Business.GuidedRow` |  | Zapis | Zmieniony zapis o ile nie został wcześniej skasowany. |
| SourceGuid | `System.Guid` | bazodanowe | Guid źródła | Unikalny identyfikator zapisu, do którego zostało wywołane zgłoszenie. |
| SourceTable | `string` | bazodanowe | Tabela źródła | Nazwa tabeli bazy danych zawierającej zapis, do którego zostało wywołane zgłoszenie. |
| TaskUser | `Soneta.Business.ITaskUser` | iface-ref |  |  |
| Time | `System.DateTime` | bazodanowe | Dzień | Data wystąpienia zgłoszenia. |
| Type | `Soneta.Business.ChangeInfoType` | bazodanowe, enum | Typ | Typ zgłoszenia określający powód jego zgłoszenia. |
| WebOperator | `Soneta.Business.IWebOperator` | bazodanowe, iface-ref | Użytkownik aplikacji web'owej | Informacje o uzytkowniku aplikacji web'owej |
| WebOperatorId | `int` |  |  |  |
| WebOperatorType | `string` | bazodanowe |  | Informacje o uzytkowniku aplikacji web'owej |
| WebUser | `string` | bazodanowe | Operator systemu | Operator zalogowany do systemu. |

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

### ChangeInfoType (`Soneta.Business.ChangeInfoType`)
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
