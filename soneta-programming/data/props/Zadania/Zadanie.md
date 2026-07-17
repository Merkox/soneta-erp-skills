# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Zadanie`
Nazwa tabeli: `Zadania`
Tytuł: Zadania i zdarzenia CRM
Opis: Zadanie lub zdarzenie CRM stanowiące podstawową jednostkę pracy w module zadaniowym. Zawiera terminy, kontrahenta, operatorów, stan realizacji, priorytet, wartości kosztowe oraz powiązania z projektem, kampanią i korespondencją.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `ITimeTrack`, `IElementSlownika`, `IEmailElement`, `IDocumentHostCRM`, `IManagedRowInfoHost`, `IToDoItemHost`

- pola bazodanowe: 64
- pola kalkulowane (z klas biznesowych): 107

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActivityRecordSequence | `Soneta.Core.RecordSequence` |  |  |  |
| Adres | `Soneta.Core.Adres` |  |  |  |
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy zadanie w tym stanie jest aktywne (otwarte). |
| AllDayEvent | `bool` |  |  |  |
| Appearance | `Soneta.Business.DataAppearance` |  |  |  |
| Areas | `Soneta.Business.SubTable` |  |  |  |
| Avatar | `Soneta.Business.Conversation.Interfaces.IAvatar` |  |  |  |
| Calodzienne | `bool` |  |  |  |
| Color | `Soneta.Zadania.GoogleEventColor` | bazodanowe, enum | Kolor | Określa kolor w kalendarzu Google |
| Contractor | `string` |  |  |  |
| CzasDo | `Soneta.Types.TimeSec` | bazodanowe | Godzina zakończenia | Planowana godzina zakończenia zadania |
| CzasDo1 | `Soneta.Types.Time` |  |  |  |
| CzasDoWypozyczenia | `Soneta.Types.Time` |  |  |  |
| CzasOd | `Soneta.Types.TimeSec` | bazodanowe | Godzina rozpoczęcia | Godzina rozpoczęcia zadania |
| CzasOd1 | `Soneta.Types.Time` |  |  |  |
| CzasPlanowany | `Soneta.Types.Time` | bazodanowe | Planowany czas wykonania zadania | Planowany czas wykonania zadania |
| CzasPlanowanyZadan | `Soneta.Types.Time` |  | Czas planowany zadań | Planowany czas wykonywanych zadań |
| CzasPozostalyOffset | `Soneta.Types.Time` | bazodanowe |  | Offset czasu wykonania zadania dodany ręcznie |
| CzasPozostalyZadan | `Soneta.Types.Time` |  | Czas pozostały zadań | Pozostały czas wykonywanych zadań |
| CzasTrwaniaZadania | `Soneta.Types.Time` |  |  |  |
| CzasWykonania | `Soneta.Types.TimeSec` | bazodanowe | Czas wykonania | Czas wykonania. |
| CzasWykonaniaOPZ | `Soneta.Types.Time` |  |  |  |
| CzasWykonaniaZadan | `Soneta.Types.Time` |  | Czas wykonania zadań | Łączny czas wykonania zadań |
| CzasZamkniecia | `Soneta.Types.Time` | bazodanowe | Godzina zamknięcia | Godzina zamknięcia zadania. |
| CzyZadanieOperatora | `bool` |  |  |  |
| CzyZamykane | `bool` |  |  |  |
| Data | `Soneta.Types.Date` |  |  |  |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Planowana data zakończenia zadania |
| DataDoWypozyczenia | `Soneta.Types.Date` |  |  |  |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia zadania |
| DataSourceParent | `int?` |  |  |  |
| DataZakonczenia | `Soneta.Types.Date` | bazodanowe | Data zakończenia zadania | Rzeczywista data zakończenia zadania |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe | Data zamknięcia | Data zamknięcia zadania. |
| Definicja | `Soneta.Zadania.DefZadania` | bazodanowe |  | Definicja zadania. |
| DefinitionSymbol | `string` |  |  |  |
| DefinitionType | `System.Type` |  |  |  |
| Description | `string` |  |  |  |
| DoWykonania | `bool` | bazodanowe |  |  |
| DokCRMCzesci | `Soneta.Zadania.DokumentCRM` |  |  |  |
| DokCRMHan | `Soneta.Zadania.DokumentCRM` |  |  |  |
| DokCRMUslugi | `Soneta.Zadania.DokumentCRM` |  |  |  |
| DokHanCzesci | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| DokHanCzesciPozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| DokHanHan | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| DokHanHanPozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| DokHanUslugi | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| DokHanUslugiPozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| DokumentyCRM | `Soneta.Business.SubTable<Soneta.Zadania.DokumentCRM>` |  |  |  |
| Dzial | `string` | bazodanowe | Dział | Dział |
| ETag | `string` | bazodanowe | Etag | Umożliwia weryfikację stanu zadania podczas synchronizacji |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| End | `System.DateTime` |  |  |  |
| EntitleGuid | `System.Guid` | bazodanowe |  | Uprawnienie dla którego przypisane jest zadanie. |
| EtapProjektu | `Soneta.Zadania.EtapProjektu` | bazodanowe |  |  |
| GoogleEventID | `string` | bazodanowe | Identyfikator | Identyfikator w kalendarzu Google. |
| HistoriaZadania | `Soneta.Business.SubTable<Soneta.Zadania.HistZadania>` |  |  |  |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| IconName | `string` |  |  |  |
| IloscUrzadzen | `int` |  |  |  |
| IsCopy | `bool` |  |  |  |
| IsNotZadanieOPZ | `bool` |  |  |  |
| IsZadanieFromOPZ | `bool` |  |  |  |
| IsZadanieOPZ | `bool` |  |  |  |
| Kampania | `Soneta.Zadania.Kampania` | bazodanowe |  | Kampania, z którą powiązane jest zadanie |
| KanbanRecordSequence | `Soneta.Core.RecordSequence` |  |  |  |
| KanbanSequence | `int` |  |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| KontaktTelKom | `string` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent, którego dotyczy zadanie. |
| Korespondencja | `Soneta.Zadania.Korespondencja` | bazodanowe |  | Korespondencja, z którą powiązane jest zdarzenie |
| Koszt | `Soneta.Types.Currency` | bazodanowe | Koszt | Szacowany koszt zadania |
| KosztRach | `Soneta.Types.Currency` |  |  |  |
| Lead | `Soneta.CRM.Lead` | bazodanowe |  | Lead, do którego przyporządkowane jest zadanie. |
| Lokalizacja | `Soneta.CRM.Lokalizacja` | bazodanowe | Lokalizacja zadania | Lokalizacja zadania. |
| MailId | `string` | bazodanowe |  |  |
| MailTo | `string` |  |  |  |
| MyActivityRecordSequence | `Soneta.Core.RecordSequence` |  |  |  |
| Nadrzedne | `Soneta.Zadania.Zadanie` | bazodanowe | Zadanie nadrzędne | Zadanie główne (dla zadań grupowych) lub zadanie poprzedzające. |
| Nagrania | `Soneta.Business.SubTable<Soneta.Zadania.Cti.Models.RecordEvent>` |  |  |  |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Krótka nazwa zadania lub zdarzenia, na podstawie której będzie można go wyszukiwać |
| NieruchomosciUzyte | `Soneta.Business.SubTable` |  |  |  |
| NotificationMessage | `Soneta.Business.Notifications.Models.NotificationMessage` |  |  |  |
| NotificationParamsProvider | `Soneta.Business.Notifications.NotificationParamsProvider<Soneta.Zadania.Zadanie>` |  |  |  |
| NotificationRowParamsProvider | `Soneta.Business.Notifications.NotificationParamsProvider` |  |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerKorespondencji | `string` |  | Numer korespondencji |  |
| NumerPelny | `string` |  |  |  |
| NumerProjektu | `string` |  | Numer projektu |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest aktywność. |
| Okres | `Soneta.Types.FromTo` |  |  |  |
| Operator | `string` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis zadania | Dokładny opis zadania lub zdarzenia |
| OpisTxt | `string` |  |  |  |
| PlanowanePrzeglady | `Soneta.Business.SubTable<Soneta.Zadania.PlanowanyPrzeglad>` |  |  |  |
| PlanowanyCzasOPZ | `Soneta.Types.Time` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable<Soneta.Ksiega.PowiazanieKontaBase>` |  |  |  |
| Poziom | `int` |  |  |  |
| PozostalyCzasOPZ | `Soneta.Types.Time` |  |  |  |
| PracownikOPZ | `Soneta.Kadry.Pracownik` | bazodanowe | Pracownik OPZ | Pracownik wykonujący zadanie OPZ |
| Priority | `string` |  |  |  |
| PriorytetIdent | `int` | bazodanowe | Priorytet | Priorytet zadania. Relacja do property Ident w liście priorytetów powiązanych z definicją zadania. |
| PriorytetZadania | `Soneta.Zadania.PriorytetZadania` | bazodanowe |  | Priorytet projektu. |
| Projekt | `Soneta.Zadania.Projekt` | bazodanowe |  | Projekt, z którym powiązane jest zadanie |
| Prowadzacy | `Soneta.Business.App.Operator` | bazodanowe | Zlecający | Osoba zlecająca zadanie |
| Przedstawiciel | `Soneta.CRM.KontaktOsoba` | bazodanowe | Przedstawiciel | Osoba odpowiedzialna za wykonanie zadania ze strony kontrahenta |
| Przeglad | `Soneta.Zadania.PlanowanyPrzeglad` |  |  |  |
| Przychod | `Soneta.Types.Currency` | bazodanowe | Przychód | Szacowany przychód zadania |
| PrzychodRach | `Soneta.Types.Currency` |  |  |  |
| Przypomnienie | `Soneta.Types.Time` | bazodanowe | Przypomnienie | Czas przypomnienia o zadaniu |
| PrzypomnienieWg | `Soneta.Core.PrzypomnienieWg` | bazodanowe, enum |  |  |
| Przypomnij | `bool` |  |  |  |
| Rodzaj | `Soneta.Core.RodzajZadania` | bazodanowe, enum | Rodzaj zadania | Rodzaj zadania. Może być zadanie lub zdarzenie. Dziedziczone z definicji. |
| Role | `Soneta.Business.App.Role` |  |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  | Rola dla której przypisane jest zadanie. |
| SchedulerInterval | `Soneta.Types.Interval` |  |  |  |
| Sequence | `int` |  |  |  |
| Seria | `string` | bazodanowe | Seria | Seria aktywności. |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| StanIdent | `int` | bazodanowe | Stan | Stan zadania. Relacja do property Ident w liście stanów powiązanych z definicją zadania. |
| StanLeada | `Soneta.CRM.Config.StanLeada` | bazodanowe |  | Stan leada |
| StanTransakcji | `Soneta.CRM.Config.StanTransakcji` | bazodanowe |  | Stan transakcji |
| StanZadania | `Soneta.Zadania.StanZadania` | bazodanowe |  | Stan projektu. |
| Start | `System.DateTime` |  |  |  |
| StopperIsRunning | `string` |  |  |  |
| Synced | `bool` | bazodanowe | Zsynchronizowane | Określa czy zadanie zostało poprawnie zsynchronizowane z kalendarzem Google |
| TaskState | `string` |  |  |  |
| Text | `string` |  |  |  |
| TimeTrackList | `Soneta.Business.SubTable<Soneta.Core.TimeTrack>` |  |  |  |
| ToDoItems | `Soneta.Business.SubTable<Soneta.Core.ToDoItem>` |  |  |  |
| Transakcja | `Soneta.CRM.Transakcja` | bazodanowe |  | Transakcja, do której przyporządkowane jest zadanie. |
| TypNadrzednego | `Soneta.Core.TypZadaniaNadrzednego` | bazodanowe, enum | Typ zadania nadrzędnego | Rodzaj zadania nadrzędnego: główne (dla zadań grupowych) lub poprzedzające. |
| TypZadania | `Soneta.Zadania.TypZadania` | bazodanowe |  | Typ zadania |
| UprawnieniaNaAktywnosciach | `bool` |  |  |  |
| Uprawnienie | `Soneta.Business.App.Entitle` |  |  |  |
| UrzadzeniaUzyte | `Soneta.Business.SubTable<Soneta.Zadania.UrzadzenieUzyte>` |  |  |  |
| Urzadzenie | `Soneta.Zadania.Urzadzenie` |  |  |  |
| UsedVehicles | `Soneta.Business.SubTable` |  |  |  |
| Usluga | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Usługa |  |
| UslugiZdarzen | `Soneta.Business.SubTable` |  |  |  |
| UsunieteZKalendarzaGoogle | `bool` |  | Usunięte z kalendarza Google |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi | Uwagi dotyczące zadania wpisywane przez operatora wykonującego zadanie. |
| WartoscWyliczana | `bool` | bazodanowe | Wartość wyliczana | Zakładane wartości wyliczane na podstawie listy produktów |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Wykonujacy | `Soneta.Business.App.Operator` | bazodanowe | Operator | Osoba wykonująca zadanie |
| WykonujacyOPZ | `Soneta.Business.IWykonujacy` |  |  |  |
| ZachowanieDat | `Soneta.Core.TaskDateDependency` | bazodanowe, enum | Zachowanie dat | Określa zależności pomiędzy datami rozpoczęcia i zakończenia zadań podrzędnych względem zadania nadrzędnego |
| ZadaniaGrupowe | `Soneta.Business.View` |  |  |  |
| ZadaniaPodmiotu | `Soneta.Business.SubTable<Soneta.Zadania.Podmioty_Zadania.PodmiotZadanie>` |  |  |  |
| ZadaniaPodrzedne | `Soneta.Business.View` |  |  |  |
| ZadaniaPowiazane | `Soneta.Business.View` |  |  |  |
| ZadaniaPowiazanePodrzednego | `Soneta.Business.View` |  |  |  |
| ZadaniaWykonujacego | `Soneta.Business.SubTable<Soneta.Zadania.PracaZdalna.ZadaniaDnia.Models.ZadanieDnia>` |  |  |  |
| ZadanieDlaRoli | `bool` |  |  |  |
| ZadanieDlaUprawnienia | `bool` |  |  |  |
| ZadanieNadrzedneContext | `Soneta.Zadania.Zadanie` |  |  |  |
| ZasobyCRM | `Soneta.Business.SubTable<Soneta.Zadania.ZasobCRM>` |  |  |  |
| Zespol | `string` |  |  |  |
| dateStart | `System.DateTime` |  |  |  |
| dateStop | `System.DateTime` |  |  |  |

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
