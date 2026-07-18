# Pola i właściwości klasy biznesowej: `Soneta.CRM.Transakcja`
Nazwa tabeli: `Transakcje`
Tytuł: Transakcja
Opis: Transakcja sprzedażowa CRM prowadzona z kontrahentami. Śledzi cały cykl sprzedaży od otwarcia do zamknięcia, rejestrując stan, przychody, koszty, marżę, priorytety oraz powiązania z leadami, projektami i osobami kontaktowymi.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`, `IElementSlownika`

- pola bazodanowe (zapisywalne): 20
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 22
- podlisty: 9
- subrowy: 1
- razem: 54

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Appearance | `DataAppearance` | tylko-odczyt |  |  |
| Avatar | `Conversation.Interfaces.IAvatar` | tylko-odczyt |  |  |
| Contractor | `string` | tylko-odczyt |  |  |
| Data | `Date` | tylko-odczyt |  |  |
| DataDo | `Date` | bazodanowe | Data zakończenia | Planowana data zakończenia transakcji. |
| DataOd | `Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia transakcji. |
| DataSourceParent | `int?` | tylko-odczyt |  |  |
| DataZamkniecia | `Date` | bazodanowe | Data zamknięcia | Data faktycznego zamknięcia |
| Definicja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe |  | Definicja transakcji |
| Definition | `IWizardReferenceHost` | tylko-odczyt, iface-ref |  |  |
| DefinitionSymbol | `string` | tylko-odczyt |  |  |
| DefinitionType | `System.Type` | tylko-odczyt |  |  |
| DokumentyHandlowe | `SubTable` | podlista |  |  |
| DuplicateGroupCaption | `string` | tylko-odczyt |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Host | `ISysNotificationHost` | tylko-odczyt, iface-ref |  |  |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| KanbanRecordSequence | `Soneta.Core.RecordSequence` | tylko-odczyt |  |  |
| KanbanSequence | `int` | tylko-odczyt |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent podpięty do transakcji. |
| Koszt | `Currency` | bazodanowe | Koszt | Zakładany koszt. |
| Lead | `Soneta.CRM.Lead` | bazodanowe |  | Lead podpięty do transakcji. |
| MailTo | `string` | tylko-odczyt |  |  |
| Marza | `Percent` | bazodanowe | Marża | Marża podawana w procentach wykorzystywana do wyliczania kosztu. |
| Name | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa transakcji |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Operator | `string` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis transakcji. |
| PotencjalnyZysk | `Currency` | tylko-odczyt |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Priority | `string` | tylko-odczyt |  |  |
| Priorytet | `Soneta.CRM.Config.PriorytetTransakcja` | bazodanowe |  | Priorytet transakcji. |
| Projekt | `Soneta.Core.IProjekt` | bazodanowe, iface-ref |  | Projekt, z którym powiązana jest transakcja. |
| Prowadzacy | `App.Operator` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie transakcji. |
| Przedstawiciel | `Soneta.CRM.KontaktOsoba` | bazodanowe | Przedstawiciel | Osoba kontaktowa ze strony kontrahenta. |
| Przychod | `Currency` | bazodanowe | Przychód | Zakładany przychód. |
| Sequence | `int` | tylko-odczyt |  |  |
| Stan | `Soneta.CRM.Config.StanTransakcji` | bazodanowe | Stan transakcji | Stan transakcji |
| StanData | `Date` | bazodanowe, tylko-odczyt |  | Data zmiany stanu. |
| TaskState | `string` | tylko-odczyt |  |  |
| Temperatura | `Soneta.CRM.Config.TemperaturaTransakcji` | bazodanowe |  | Temperatura transakcji. |
| TransakcjaZrodlowa | `Soneta.CRM.Transakcja` |  |  |  |
| TransakcjePodmiotu | `SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` | podlista |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Zadania | `SubTable` | podlista |  |  |
| Zrodlo | `Soneta.CRM.Config.ZrodloKontaktu` | bazodanowe |  | Źródło kontaktu. |
| Zysk | `Currency` | bazodanowe | Zysk | Zysk |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IWizardReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition`, `WFDefinition` |
| Host | `ISysNotificationHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition` |
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| Projekt | `IProjekt` | `Projekt` |
