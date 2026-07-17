# Pola i właściwości klasy biznesowej: `Soneta.Zadania.DefZadania`
Nazwa tabeli: `DefZadan`
Tytuł: Definicje zadań CRM
Opis: Szablon zadania lub zdarzenia CRM. Konfiguruje rodzaj aktywności, numerację, stany, priorytety, powiadomienia e-mail, synchronizację z kalendarzem Google oraz parametry stopera i rozliczeń.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IManagedRowDefinion`, `ISysNotificationHost`, `IWizardReferenceHost`, `IWfPlugInReferenceHost`, `IWFDefinitionHost`, `IPreviewPageHost`

- pola bazodanowe: 81
- pola kalkulowane (z klas biznesowych): 39

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktualizujCzas | `bool` | bazodanowe | Aktualizuj czas zakończenia zadania | Aktualizuje datę i czas zakończenia zadania po zmianie stanu na nieaktywny |
| AlgorithmType | `Soneta.Zadania.AlgorithmType` | bazodanowe, enum |  |  |
| Algorytm | `bool` | bazodanowe |  | Określa czy istnieje algorytm dla zadania. |
| AlgorytmDlaNazwy | `string` |  |  |  |
| AlgorytmDlaOpisu | `string` |  |  |  |
| AlgorytmNazwyIOpisu | `Soneta.Business.MemoText` | bazodanowe | Kod kalkulatora dla nazwy i opisu zadania w kalendarzu | Kod kalkulatora dla nazwy i opisu zadania w kalendarzu. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie definicji. Zablokowane definicje zadań nie będą wyświetlane w liście wyboru. |
| Calodzienne | `bool` | bazodanowe | Zadanie całodzienne | Określa, czy zadanie jest całodzienne. |
| CechyKopiowane | `Soneta.Business.MemoText` | bazodanowe |  | Reprezentuje listę cech kopiowanych z aktywności nadrzędnej. |
| CechyWymagane | `Soneta.Business.MemoText` | bazodanowe |  | Reprezentuje listę cech wymaganych na aktywnościach. |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe | Kod kalkulatora dla zadania | Kod klasy kalkulatora dla zadania. |
| ColorsXml | `Soneta.Business.MemoText` |  |  |  |
| ConfigClass | `string` | bazodanowe | Klasa do zapisu konfiguracji | Klasa z definicją obiektu przechowującego statyczną konfigrację. |
| ConfigTypeFullName | `string` |  |  |  |
| CountersContractDefinition | `Soneta.Handel.DefDokHandlowego` |  |  |  |
| CreateProcess | `Soneta.Core.DbTuples.CreateProcessType` | bazodanowe, enum | Uruchom procesy |  |
| DataType | `System.Type` |  |  |  |
| DefDlaOutlook | `bool` | bazodanowe | Definicja dla importu z Outlook 2007 | Określa, czy definicja jest dla importu maili z Outlook 2007. |
| DefDokHanUslugi | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja dokumentu handlowego | Domyślna definicja dokumentu handlowego dla usług dla wypożyczenia/zlecenia serwisowego |
| DefKolorow | `Soneta.Business.MemoText` | bazodanowe | Definicja warunków kolorowania wierszy | Określa definicję warunków kolorowania wierszy. |
| DefinicjaDokHandlowego | `Soneta.Handel.DefDokHandlowego` | bazodanowe | Definicja dokumentu handlowego | Domyślna definicja dokumentu handlowego generowanego dla tego zadania |
| DescCode | `string` |  |  |  |
| DlaRoli | `bool` |  |  |  |
| DlaUprawnienia | `bool` |  |  |  |
| Domyslna | `bool` | bazodanowe | Domyślna | Określa, że jest to domyślna definicja zadania |
| DrugiSymbol | `string` | bazodanowe | Seria | Seria aktywności. |
| EngineCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| EngineCodeEditorSource | `Soneta.Business.Compiler.ICodeEditorSource` |  | Algorytm zadania | Algorytm zadania |
| EntitleGuid | `System.Guid` | bazodanowe |  | Domyślne uprawnienie dla którego przypisane jest zadanie. |
| EventColor | `Soneta.Zadania.GoogleEventColor` | bazodanowe, enum | Kolor zdarzenia w kalendarzu Google | Określa kolor zdarzenia w kalendarzu Google. |
| FiltrDokumentCRM | `string` | bazodanowe | Filtr dokumentow CRM | Filtr wg jakiego wyświetlana jest lista dokumentów CRM. |
| FiltrZasobu | `string` | bazodanowe | Filtr zasobu | Filtr wg jakiego wyświetlana jest lista zasobów IZasobCRM. |
| Formularz | `Soneta.Core.RodzajFormularzaZadania` | bazodanowe, enum | Rodzaj formularza | Określa sposób wyświetlania formularza |
| Grupowe | `Soneta.Zadania.DefZadania` | bazodanowe | Zadanie grupowe | Definicja podrzędnego zadania grupowego. |
| Historia | `bool` | bazodanowe | Czy zapisywać historię zmian |  |
| InicjujNazwe | `bool` | bazodanowe | Inicjuje nazwę zadania | Określa, czy zadanie ma zainicjowaną nazwę z definicji. |
| IntervalType | `Soneta.Zadania.TaskInterval` | bazodanowe, enum | Interwał czasowy |  |
| IntervalValue | `int` | bazodanowe | Wartość interwału czasowego |  |
| IsDefinicjaWizji | `bool` |  |  |  |
| IsDefinicjaWytycznej | `bool` |  |  |  |
| IsDefinicjaZadaniaOPZ | `bool` |  |  |  |
| IsProjectDefinition | `bool` |  |  |  |
| IsSource | `bool` |  |  |  |
| KanbanColor | `string` | bazodanowe | Kolor | Kolor na tablicy Kanban. |
| KanbanDefinition | `bool` | bazodanowe | Pobieranie stanów Kanban |  |
| Kategoria | `Soneta.Zadania.KategoriaAkt` | bazodanowe | Kategoria definicji | Kategoria definicji. |
| Kod | `string` |  |  |  |
| KontrolaCzasuZasobu | `Soneta.Core.TypKontroli` | bazodanowe, enum | Kontrola czasu zasobów | Określa sposób kontroli czasu zasobów przypisanych do zadania. |
| KontrolaDokCRM | `Soneta.Core.TypKontroli` | bazodanowe, enum | Kontrola dokumentu CRM. | Kontroluje dodawanie dokumentu CRM do wielu zadań. |
| KontrolaDostUrz | `Soneta.Core.TypKontroli` | bazodanowe, enum | Typ kontroli dostępności urządzenia | Określa typ kontroli dostępności urządzenia. |
| Kreatory | `Soneta.Business.SubTable<Soneta.Core.ManagedRowCreator>` |  |  |  |
| LeaseContractDefinition | `Soneta.Handel.DefDokHandlowego` |  |  |  |
| LiczbaStanow | `int` |  |  |  |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe | Domyślny magazyn | Określa, domyślny magazyn. |
| MailAutoTemplate | `Soneta.CRM.SzablonEmail` | bazodanowe | Szablon email autoamtyczny. | Określa szablon wg którego będzie utworzony mail automatyczny |
| MailDoKontrahenta | `Soneta.Core.RodzajWysylki` | bazodanowe, enum | Mail do kontrahenta. | Określa, czy mail zostanie wysłany do kontrahenta. |
| MailDoProwadzacego | `Soneta.Core.RodzajWysylki` | bazodanowe, enum | Mail do prowadzącego. | Określa, czy mail zostanie wysłany do prowadzącego. |
| MailDoWykonujacego | `Soneta.Core.RodzajWysylki` | bazodanowe, enum | Mail do wykonującego. | Określa, czy mail zostanie wysłany do wykonującego. |
| MailManualTemplate | `Soneta.CRM.SzablonEmail` | bazodanowe | Szablon mail na żądanie. | Określa szablon wg którego będzie utworzony mail na żądanie. |
| MailPrzyUtworzeniu | `bool` | bazodanowe | Mail przy utworzeniu. | Określa, czy mail zostanie wysłany przy utworzeniu. |
| MailPrzyZamknieciu | `bool` | bazodanowe | Mail przy zamknięciu. | Określa, czy mail zostanie wysłany przy zamknięciu. |
| MailPrzyZmianie | `bool` | bazodanowe | Mail przy zmianie. | Określa, czy mail zostanie wysłany przy zmianie. |
| Nadrzedne | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.DefZadaniaRelacja>` |  |  |  |
| NadrzedneNiePrzenos | `bool` | bazodanowe |  | Nie przenoś informacji z zadania nadrzędnego. |
| NameCode | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Pełna nazwa definicji zadania |
| NazwaZakladkiUz | `string` | bazodanowe | Nazwa zakładki użytkownika |  |
| NetDodawanie | `bool` | bazodanowe | Dodawanie w pulpicie kontrahenta | Możliwość dodawania zadań przez kontrahentów w pulpicie kontrahenta |
| NetDostep | `Soneta.Zadania.NetDostep` | bazodanowe, enum | Dostęp w pulpicie kontrahenta | Możliwość dostępu kontrahentów do zadań w pulpicie kontrahenta. |
| NetModul | `Soneta.Core.ModulyNet` | bazodanowe, enum | Moduł pulpitu kontrahenta | Dla jakiego modułu pulpitu kontrahenta definicja jest widoczna |
| NeutralName | `string` |  |  |  |
| NieWymagajCech | `bool` | bazodanowe |  | Określ, czy nie sprawdzać wymagalności cech aktywności. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Numeracja | Ustawienia określające sposób numeracji zadań |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| ObslugaCRU | `bool` | bazodanowe | Obsługa CRU | Określa, czy definicja zadania jest przeznaczona do obsługi Centralnego Rejestru Umów (CRU). |
| OknoPotwierdzenia | `bool` | bazodanowe | Okno potwierdzenia email | Określa, czy przy wysyłce pojawi się okno potwierdzenia. |
| OpisHTML | `bool` | bazodanowe | Opis w postaci HTML. | Określa, czy opis będzie w postaci HTML. |
| PlugIns | `Soneta.Business.SubTable` |  |  |  |
| Podrzedne | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.DefZadaniaRelacja>` |  |  |  |
| PokazKomunikat | `bool` | bazodanowe |  | Decyduje o pokazywaniu komunikatu o kontrahencie podczas jego ustawianiu na dokument CRM. |
| PowiazCzasWykonania | `bool` | bazodanowe |  | Powiąż czas wykonania z rozpoczęciem i zakończeniem. |
| Powiazane | `Soneta.Zadania.DefZadania` | bazodanowe | Zadanie powiązane | Przy zamknięciu zadania generuje automatycznie nowe zadanie o zadanej definicji |
| Priorytety | `Soneta.Business.LpSubTable<Soneta.Zadania.PriorytetZadania>` |  |  |  |
| Przypomnienie | `Soneta.Types.Time` | bazodanowe | Przypomnienie | Czas przypomnienia o zadaniu |
| PrzypomnienieWg | `Soneta.Core.PrzypomnienieWg` | bazodanowe, enum |  |  |
| Rodzaj | `Soneta.Core.RodzajZadania` | bazodanowe, enum | Rodzaj zadania | Rodzaj definicji zadania. Może być zadanie lub zdarzenie. |
| RodzajAdresu | `Soneta.Core.SlownikElem` | bazodanowe | Rodzaj adresu | Rodzaj adresu e-mail. |
| Role | `Soneta.Business.App.Role` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  | Domyślna rola dla której przypisane jest zadanie. |
| RoleName | `string` |  | Rola |  |
| RowType | `System.Type` |  |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| Stany | `Soneta.Business.LpSubTable<Soneta.Zadania.StanZadania>` |  |  |  |
| StoperAuto | `bool` | bazodanowe |  | Automatycznie uruchamiaj stoper. |
| StoperDostepny | `bool` | bazodanowe |  | Udostępnij funkcje stopera. |
| StoperWTle | `bool` | bazodanowe |  | Pozwól na działanie stopera w tle po zamknięciu formatki. |
| Symbol | `string` | bazodanowe | Symbol | Skrótowa nazwa definicji zadania wykorzystywana do wyszukiwania definicji oraz numeracji zadań CRM. |
| Synchronizowana | `bool` | bazodanowe | Synchronizacja z kalendarzami Google | Określa czy zadania definicji mają być synchronizowane z kalendarzami Google. |
| SysNotifications | `Soneta.Business.SubTable<Soneta.Business.Db.Notifications.SysNotification>` |  |  |  |
| TylkoPosrednio | `bool` | bazodanowe | Utwórz tylko pośrednio |  |
| Typy | `Soneta.Business.LpSubTable<Soneta.Zadania.TypZadania>` |  |  |  |
| UprawnieniaNaAktywnosciach | `bool` |  |  |  |
| Uprawnienie | `Soneta.Business.App.Entitle` |  |  |  |
| UseTaskMailingSystem | `bool` | bazodanowe | Wysyłka za pomocą tasku | Określa, czy mail zostanie wysłany własnym taskiem wysyłkowym czy mechanizmem wbudowanym. |
| WFDefinition | `Soneta.Workflow.Config.WFDefinitionExtend` |  |  |  |
| WartoscDokCRM | `Soneta.Core.WartoscDokCRM` | bazodanowe, enum | Wartość na dokumencie CRM. | Określa, rodzaj wartości na dokumencie CRM. |
| WfEngineCode | `Soneta.Business.MemoText` | bazodanowe |  |  |
| WfEngineCodeEditorSource | `Soneta.Business.Compiler.ICodeEditorSource` |  | Algorytm procesu | Algorytm procesu |
| WizardsRef | `Soneta.Business.LpSubTable<Soneta.Business.Db.Wizard.WizardReference>` |  |  |  |
| WysylkaNaAdres | `Soneta.Core.WysylkaNaAdres` | bazodanowe, enum | Adresy do wysyłki | Określa adresy do wysyłki. |
| Xml | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika. |  |
| XmlNET | `Soneta.Business.MemoText` | bazodanowe | Definicja zakładki użytkownika w pulpicie kontrahenta. |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### CreateProcessType (`Soneta.Core.DbTuples.CreateProcessType`)
- `Default` = 0 — Podczas zapisu dokumentu
- `OnAdded` = 1 — Podczas dodawania dokumentu

### ModulyNet (`Soneta.Core.ModulyNet`)
- `KadryPłace` = 1 — Kadry Płace
- `CRM` = 2 — CRM
- `Zamówienia` = 3 — Zamówienia

### PrzypomnienieWg (`Soneta.Core.PrzypomnienieWg`)
- `Brak` = 0 — Brak
- `PrzedRozpoczęciem` = 1
- `PrzedZakończeniem` = 2

### RodzajFormularzaZadania (`Soneta.Core.RodzajFormularzaZadania`)
- `Prosty` = 1 — Prosty
- `Pełny` = 2
- `Użytkownika` = 3
- `ZapytanieOfertowe` = 4 — Zapytanie ofertowe
- `Rozszerzony` = 5
- `Podstawowy` = 6

### RodzajWysylki (`Soneta.Core.RodzajWysylki`)
- `Brak` = 0 — Brak
- `DO` = 1
- `DW` = 2
- `UDW` = 3

### RodzajZadania (`Soneta.Core.RodzajZadania`)
- `Zadanie` = 1 — Zadanie
- `Zdarzenie` = 2
- `Zlecenie` = 3
- `Wypożyczenie` = 4
- `OrgPracyZdalnej` = 5 — Praca hybrydowa
- `Planowane` = 6 — Zdarzenie planowane
- `Incydentalne` = 7 — Zdarzenie incydentalne
- `Pomiar` = 8
- `Najem` = 9
- `Polisa` = 10
- `Szkoda` = 11
- `Rezerwacja` = 50 — Wewnętrzne
- `Kanban` = 51
- `Fleet` = 100 — Flota
- `Grupujace` = 150 — Zadanie grupujące
- `Projektowe` = 151 — Zadanie projektowe

### TypKontroli (`Soneta.Core.TypKontroli`)
- `Brak` = 0 — Brak
- `Ostrzegaj` = 1
- `Zabraniaj` = 2

### WartoscDokCRM (`Soneta.Core.WartoscDokCRM`)
- `Brutto` = 0 — Brutto
- `Netto` = 1

### WysylkaNaAdres (`Soneta.Core.WysylkaNaAdres`)
- `Pierwszy` = 0 — Pierwszy
- `Wszystkie` = 1

### AlgorithmType (`Soneta.Zadania.AlgorithmType`)
- `None` = 0 — Brak
- `ActivityCalculator` = 1 — Kod kalkulatora
- `EngineCode` = 2 — Jednozakładkowy

### GoogleEventColor (`Soneta.Zadania.GoogleEventColor`)
- `KolorKalendarza` = 0
- `Lawenda` = 1
- `Szalwia` = 2 — Szałwia
- `Winogrona` = 3
- `Flaming` = 4
- `Banan` = 5
- `Mandarynka` = 6
- `Paw` = 7
- `Grafit` = 8
- `Jagoda` = 9
- `Bazylia` = 10
- `Pomidor` = 11

### NetDostep (`Soneta.Zadania.NetDostep`)
- `Brak` = 0
- `Podglad` = 1 — Podgląd
- `Edycja` = 2

### TaskInterval (`Soneta.Zadania.TaskInterval`)
- `Days` = 0 — Dni
- `Months` = 1 — Miesięcy
- `Years` = 2 — Lat
