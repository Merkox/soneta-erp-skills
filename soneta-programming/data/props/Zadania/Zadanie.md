# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Zadanie`
Nazwa tabeli: `Zadania`
Tytuł: Zadania i zdarzenia CRM
Opis: Zadanie lub zdarzenie CRM stanowiące podstawową jednostkę pracy w module zadaniowym. Zawiera terminy, kontrahenta, operatorów, stan realizacji, priorytet, wartości kosztowe oraz powiązania z projektem, kampanią i korespondencją.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `ITimeTrack`, `IElementSlownika`, `IEmailElement`, `IDocumentHostCRM`, `IManagedRowInfoHost`, `IToDoItemHost`
Selektor: pole `Rodzaj` (`Soneta.Core.RodzajZadania`) — wiele typów w jednej tabeli, podtypów: 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActivityRecordSequence | `Soneta.Core.RecordSequence` | tylko-odczyt |  |  |
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| Aktywny | `bool` | bazodanowe, tylko-odczyt | Aktywny | Wskazuje, czy zadanie w tym stanie jest aktywne (otwarte). |
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| Appearance | `DataAppearance` | tylko-odczyt |  |  |
| Areas | `SubTable` | podlista |  |  |
| Avatar | `Conversation.Interfaces.IAvatar` | tylko-odczyt |  |  |
| Calodzienne | `bool` |  |  |  |
| Color | `Soneta.Zadania.GoogleEventColor` (enum) | bazodanowe | Kolor | Określa kolor w kalendarzu Google |
| Contractor | `string` | tylko-odczyt |  |  |
| CzasDo | `TimeSec` | bazodanowe | Godzina zakończenia | Planowana godzina zakończenia zadania |
| CzasDo1 | `Time` |  |  |  |
| CzasDoWypozyczenia | `Time` | tylko-odczyt |  |  |
| CzasOd | `TimeSec` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia zadania |
| CzasOd1 | `Time` |  |  |  |
| CzasPlanowany | `Time` | bazodanowe | Planowany czas wykonania zadania | Planowany czas wykonania zadania |
| CzasPlanowanyZadan | `Time` |  | Czas planowany zadań | Planowany czas wykonywanych zadań |
| CzasPozostalyOffset | `Time` | bazodanowe |  | Offset czasu wykonania zadania dodany ręcznie |
| CzasPozostalyZadan | `Time` |  | Czas pozostały zadań | Pozostały czas wykonywanych zadań |
| CzasTrwaniaZadania | `Time` | tylko-odczyt |  |  |
| CzasWykonania | `TimeSec` | bazodanowe | Czas wykonania | Czas wykonania. |
| CzasWykonaniaZadan | `Time` | tylko-odczyt | Czas wykonania zadań | Łączny czas wykonania zadań |
| CzasZamkniecia | `Time` | bazodanowe | Godzina zamknięcia | Godzina zamknięcia zadania. |
| CzyZadanieOperatora | `bool` | tylko-odczyt |  |  |
| CzyZamykane | `bool` | tylko-odczyt |  |  |
| Data | `Date` | tylko-odczyt |  |  |
| DataDo | `Date` | bazodanowe | Data zakończenia | Planowana data zakończenia zadania |
| DataDoWypozyczenia | `Date` | tylko-odczyt |  |  |
| DataOd | `Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia zadania |
| DataSourceParent | `int?` | tylko-odczyt |  |  |
| DataZakonczenia | `Date` | bazodanowe | Data zakończenia zadania | Rzeczywista data zakończenia zadania |
| DataZamkniecia | `Date` | bazodanowe | Data zamknięcia | Data zamknięcia zadania. |
| Definicja | `Soneta.Zadania.DefZadania` | bazodanowe |  | Definicja zadania. |
| DefinitionSymbol | `string` | tylko-odczyt |  |  |
| DefinitionType | `System.Type` | tylko-odczyt |  |  |
| Description | `string` | tylko-odczyt |  |  |
| DoWykonania | `bool` | bazodanowe |  |  |
| DokCRMCzesci | `Soneta.Zadania.DokumentCRM` | tylko-odczyt |  |  |
| DokCRMHan | `Soneta.Zadania.DokumentCRM` | tylko-odczyt |  |  |
| DokCRMUslugi | `Soneta.Zadania.DokumentCRM` | tylko-odczyt |  |  |
| DokHanCzesci | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| DokHanCzesciPozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| DokHanHan | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| DokHanHanPozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| DokHanUslugi | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| DokHanUslugiPozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| DokumentyCRM | `SubTable<Soneta.Zadania.DokumentCRM>` | podlista |  |  |
| Dzial | `string` | bazodanowe | Dział | Dział |
| ETag | `string` | bazodanowe | Etag | Umożliwia weryfikację stanu zadania podczas synchronizacji |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| End | `System.DateTime` |  |  |  |
| EntitleGuid | `System.Guid` | bazodanowe |  | Uprawnienie dla którego przypisane jest zadanie. |
| EtapProjektu | `Soneta.Zadania.EtapProjektu` | bazodanowe |  |  |
| GoogleEventID | `string` | bazodanowe | Identyfikator | Identyfikator w kalendarzu Google. |
| HistoriaZadania | `SubTable<Soneta.Zadania.HistZadania>` | podlista |  |  |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| IconName | `string` | tylko-odczyt |  |  |
| IloscUrzadzen | `int` | tylko-odczyt |  |  |
| IsCopy | `bool` |  |  |  |
| IsNotZadanieOPZ | `bool` | tylko-odczyt |  |  |
| IsZadanieFromOPZ | `bool` | tylko-odczyt |  |  |
| IsZadanieOPZ | `bool` | tylko-odczyt |  |  |
| Kampania | `Soneta.Zadania.Kampania` | bazodanowe |  | Kampania, z którą powiązane jest zadanie |
| KanbanRecordSequence | `Soneta.Core.RecordSequence` | tylko-odczyt |  |  |
| KanbanSequence | `int` | tylko-odczyt |  |  |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| KontaktTelKom | `string` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent, którego dotyczy zadanie. |
| Korespondencja | `Soneta.Zadania.Korespondencja` | bazodanowe |  | Korespondencja, z którą powiązane jest zdarzenie |
| Koszt | `Currency` | bazodanowe | Koszt | Szacowany koszt zadania |
| KosztRach | `Currency` | tylko-odczyt |  |  |
| Lead | `Soneta.CRM.Lead` | bazodanowe |  | Lead, do którego przyporządkowane jest zadanie. |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja zadania | Lokalizacja zadania. |
| MailId | `string` | bazodanowe |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| MyActivityRecordSequence | `Soneta.Core.RecordSequence` | tylko-odczyt |  |  |
| Nadrzedne | `Soneta.Zadania.Zadanie` | bazodanowe | Zadanie nadrzędne | Zadanie główne (dla zadań grupowych) lub zadanie poprzedzające. |
| Nagrania | `SubTable<Soneta.Zadania.Cti.Models.RecordEvent>` | podlista |  |  |
| Name | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Krótka nazwa zadania lub zdarzenia, na podstawie której będzie można go wyszukiwać |
| NieruchomosciUzyte | `SubTable` | podlista |  |  |
| NotificationMessage | `Notifications.Models.NotificationMessage` |  |  |  |
| NotificationRowParamsProvider | `Notifications.NotificationParamsProvider` | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerKorespondencji | `string` | tylko-odczyt | Numer korespondencji |  |
| NumerPelny | `string` | tylko-odczyt |  |  |
| NumerProjektu | `string` | tylko-odczyt | Numer projektu |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest aktywność. |
| Okres | `FromTo` | podlista |  |  |
| Operator | `string` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis zadania | Dokładny opis zadania lub zdarzenia |
| OpisTxt | `string` | tylko-odczyt |  |  |
| PlanowanePrzeglady | `SubTable<Soneta.Zadania.PlanowanyPrzeglad>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable<Soneta.Ksiega.PowiazanieKontaBase>` | podlista |  |  |
| Poziom | `int` | tylko-odczyt |  |  |
| PracownikOPZ | `Soneta.Kadry.Pracownik` | bazodanowe | Pracownik OPZ | Pracownik wykonujący zadanie OPZ |
| Priority | `string` | tylko-odczyt |  |  |
| PriorytetIdent | `int` | bazodanowe | Priorytet | Priorytet zadania. Relacja do property Ident w liście priorytetów powiązanych z definicją zadania. |
| PriorytetZadania | `Soneta.Zadania.PriorytetZadania` | bazodanowe |  | Priorytet projektu. |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe |  | Projekt, z którym powiązane jest zadanie |
| Prowadzacy | `App.Operator` | bazodanowe | Zlecający | Osoba zlecająca zadanie |
| Przedstawiciel | `Soneta.CRM.KontaktOsoba` | bazodanowe | Przedstawiciel | Osoba odpowiedzialna za wykonanie zadania ze strony kontrahenta |
| Przeglad | `Soneta.Zadania.PlanowanyPrzeglad` |  |  |  |
| Przychod | `Currency` | bazodanowe | Przychód | Szacowany przychód zadania |
| PrzychodRach | `Currency` | tylko-odczyt |  |  |
| Przypomnienie | `Time` | bazodanowe | Przypomnienie | Czas przypomnienia o zadaniu |
| PrzypomnienieWg | `Soneta.Core.PrzypomnienieWg` (enum) | bazodanowe |  |  |
| Przypomnij | `bool` |  |  |  |
| Rodzaj | `Soneta.Core.RodzajZadania` (enum) | bazodanowe, tylko-odczyt, selektor | Rodzaj zadania | Rodzaj zadania. Może być zadanie lub zdarzenie. Dziedziczone z definicji. |
| Role | `App.Role` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  | Rola dla której przypisane jest zadanie. |
| SchedulerInterval | `Interval` |  |  |  |
| Sequence | `int` |  |  |  |
| Seria | `string` | bazodanowe | Seria | Seria aktywności. |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| StanIdent | `int` | bazodanowe | Stan | Stan zadania. Relacja do property Ident w liście stanów powiązanych z definicją zadania. |
| StanTransakcji | `Soneta.CRM.Config.StanTransakcji` | bazodanowe |  | Stan transakcji |
| StanZadania | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan projektu. |
| Start | `System.DateTime` |  |  |  |
| StopperIsRunning | `string` | tylko-odczyt |  |  |
| Synced | `bool` | bazodanowe | Zsynchronizowane | Określa czy zadanie zostało poprawnie zsynchronizowane z kalendarzem Google |
| TaskState | `string` | tylko-odczyt |  |  |
| Text | `string` |  |  |  |
| TimeTrackList | `SubTable<Soneta.Core.TimeTrack>` | podlista |  |  |
| ToDoItems | `SubTable<Soneta.Core.ToDoItem>` | podlista |  |  |
| Transakcja | `Soneta.CRM.Transakcja` | bazodanowe |  | Transakcja, do której przyporządkowane jest zadanie. |
| TypNadrzednego | `Soneta.Core.TypZadaniaNadrzednego` (enum) | bazodanowe | Typ zadania nadrzędnego | Rodzaj zadania nadrzędnego: główne (dla zadań grupowych) lub poprzedzające. |
| TypZadania | `Soneta.Zadania.TypZadania` | bazodanowe |  | Typ zadania |
| UprawnieniaNaAktywnosciach | `bool` | tylko-odczyt |  |  |
| Uprawnienie | `App.Entitle` |  |  |  |
| UrzadzeniaUzyte | `SubTable<Soneta.Zadania.UrzadzenieUzyte>` | podlista |  |  |
| Urzadzenie | `Soneta.Zadania.Urzadzenie` |  |  |  |
| UsedVehicles | `SubTable` | podlista |  |  |
| Usluga | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Usługa |  |
| UslugiZdarzen | `SubTable` | podlista |  |  |
| UsunieteZKalendarzaGoogle | `bool` | tylko-odczyt | Usunięte z kalendarza Google |  |
| Uwagi | `MemoText` | bazodanowe, podlista | Uwagi | Uwagi dotyczące zadania wpisywane przez operatora wykonującego zadanie. |
| WartoscWyliczana | `bool` | bazodanowe | Wartość wyliczana | Zakładane wartości wyliczane na podstawie listy produktów |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Wykonujacy | `App.Operator` | bazodanowe | Operator | Osoba wykonująca zadanie |
| WykonujacyOPZ | `IWykonujacy` |  |  |  |
| ZachowanieDat | `Soneta.Core.TaskDateDependency` (enum) | bazodanowe | Zachowanie dat | Określa zależności pomiędzy datami rozpoczęcia i zakończenia zadań podrzędnych względem zadania nadrzędnego |
| ZadaniaGrupowe | `View` | podlista |  |  |
| ZadaniaPodmiotu | `SubTable<Soneta.Zadania.Podmioty_Zadania.PodmiotZadanie>` | podlista |  |  |
| ZadaniaPodrzedne | `View` | podlista |  |  |
| ZadaniaPowiazane | `View` | podlista |  |  |
| ZadaniaPowiazanePodrzednego | `View` | podlista |  |  |
| ZadaniaWykonujacego | `SubTable<Soneta.Zadania.PracaZdalna.ZadaniaDnia.Models.ZadanieDnia>` | podlista |  |  |
| ZadanieDlaRoli | `bool` |  |  |  |
| ZadanieDlaUprawnienia | `bool` |  |  |  |
| ZadanieNadrzedneContext | `Soneta.Zadania.Zadanie` |  |  |  |
| ZasobyCRM | `SubTable<Soneta.Zadania.ZasobCRM>` | podlista |  |  |
| Zespol | `string` |  |  |  |
| dateStart | `System.DateTime` |  |  |  |
| dateStop | `System.DateTime` |  |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Rodzaj`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Zadanie` | 1 | `Soneta.Zadania.Zadanie` | Zadanie |
| `Zdarzenie` | 2 | `Soneta.Zadania.ZdarzenieExt` | Zdarzenie |
| `Zlecenie` | 3 | `Soneta.Zadania.ZlecenieExt` | Zlecenie |
| `Wypożyczenie` | 4 | `Soneta.Zadania.WypozyczenieExt` | Wypożyczenie |
| `OrgPracyZdalnej` | 5 | `Soneta.Zadania.Models.Zadania.HybridWork` | Praca hybrydowa |
| `Planowane` | 6 | `Soneta.RealEstate.Models.Planned` | Zdarzenie planowane |
| `Incydentalne` | 7 | `Soneta.RealEstate.Models.Incidental` | Zdarzenie incydentalne |
| `Pomiar` | 8 | `Soneta.RealEstate.Models.Measurement` | Pomiar |
| `Najem` | 9 | `Soneta.RealEstate.Models.Rent` | Najem |
| `Polisa` | 10 | `Soneta.RealEstate.Models.Policy` | Polisa |
| `Szkoda` | 11 | `Soneta.RealEstate.Models.Damage` | Szkoda |
| `Fleet` | 100 | `Soneta.Vehicles.Models.FleetEvent` | Zdarzenie pojazdu |
| `Grupujace` | 150 | `Soneta.Zadania.Models.Zadania.ZadanieGrupujace` | Zadanie grupujące |
| `Projektowe` | 151 | `Soneta.Zadania.Models.Zadania.ZadanieProjektowe` | Zadanie projektowe |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PrzypomnienieWg (`Soneta.Core.PrzypomnienieWg`)
- `Brak` = 0 — Brak
- `PrzedRozpoczęciem` = 1
- `PrzedZakończeniem` = 2

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

### TaskDateDependency (`Soneta.Core.TaskDateDependency`)
- `WithoutChildrenControl` = 0 — Bez kontroli podrzędnych
- `WithChildrenControl` = 1 — Kontrola podrzędnych
- `RecalculateTaskDates` = 2 — Podrzędne przeliczają

### TypZadaniaNadrzednego (`Soneta.Core.TypZadaniaNadrzednego`)
- `Główne` = 0 — Główne
- `Wątek` = 1
- `Grupowe` = 2

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
