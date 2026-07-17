# Pola i właściwości klasy biznesowej: `Soneta.CRM.Transakcja`
Nazwa tabeli: `Transakcje`
Tytuł: Transakcja
Opis: Transakcja sprzedażowa CRM prowadzona z kontrahentami. Śledzi cały cykl sprzedaży od otwarcia do zamknięcia, rejestrując stan, przychody, koszty, marżę, priorytety oraz powiązania z leadami, projektami i osobami kontaktowymi.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`, `IElementSlownika`

- pola bazodanowe: 24
- pola kalkulowane (z klas biznesowych): 30

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Appearance | `Soneta.Business.DataAppearance` |  |  |  |
| Avatar | `Soneta.Business.Conversation.Interfaces.IAvatar` |  |  |  |
| Contractor | `string` |  |  |  |
| Data | `Soneta.Types.Date` |  |  |  |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Planowana data zakończenia transakcji. |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia transakcji. |
| DataSourceParent | `int?` |  |  |  |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe | Data zamknięcia | Data faktycznego zamknięcia |
| Definicja | `Soneta.CRM.Config.DefTransakcja` | bazodanowe |  | Definicja transakcji |
| Definition | `Soneta.Business.IWizardReferenceHost` | iface-ref |  |  |
| DefinitionSymbol | `string` |  |  |  |
| DefinitionType | `System.Type` |  |  |  |
| DokumentyHandlowe | `Soneta.Business.SubTable` |  |  |  |
| DuplicateGroupCaption | `string` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Host | `Soneta.Business.ISysNotificationHost` | iface-ref |  |  |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| KanbanRecordSequence | `Soneta.Core.RecordSequence` |  |  |  |
| KanbanSequence | `int` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent podpięty do transakcji. |
| Koszt | `Soneta.Types.Currency` | bazodanowe | Koszt | Zakładany koszt. |
| Lead | `Soneta.CRM.Lead` | bazodanowe |  | Lead podpięty do transakcji. |
| MailTo | `string` |  |  |  |
| Marza | `Soneta.Types.Percent` | bazodanowe | Marża | Marża podawana w procentach wykorzystywana do wyliczania kosztu. |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa transakcji |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Operator | `string` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis transakcji. |
| PotencjalnyZysk | `Soneta.Types.Currency` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Priority | `string` |  |  |  |
| Priorytet | `Soneta.CRM.Config.PriorytetTransakcja` | bazodanowe |  | Priorytet transakcji. |
| Projekt | `Soneta.Core.IProjekt` | bazodanowe, iface-ref |  | Projekt, z którym powiązana jest transakcja. |
| Prowadzacy | `Soneta.Business.App.Operator` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie transakcji. |
| Przedstawiciel | `Soneta.CRM.KontaktOsoba` | bazodanowe | Przedstawiciel | Osoba kontaktowa ze strony kontrahenta. |
| Przychod | `Soneta.Types.Currency` | bazodanowe | Przychód | Zakładany przychód. |
| Sequence | `int` |  |  |  |
| Stan | `Soneta.CRM.Config.StanTransakcji` | bazodanowe | Stan transakcji | Stan transakcji |
| StanData | `Soneta.Types.Date` | bazodanowe |  | Data zmiany stanu. |
| TaskState | `string` |  |  |  |
| Temperatura | `Soneta.CRM.Config.TemperaturaTransakcji` | bazodanowe |  | Temperatura transakcji. |
| TransakcjaZrodlowa | `Soneta.CRM.Transakcja` |  |  |  |
| TransakcjePodmiotu | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` |  |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Zadania | `Soneta.Business.SubTable` |  |  |  |
| Zrodlo | `Soneta.CRM.Config.ZrodloKontaktu` | bazodanowe |  | Źródło kontaktu. |
| Zysk | `Soneta.Types.Currency` | bazodanowe | Zysk | Zysk |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IWizardReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition`, `WFDefinition` |
| Host | `ISysNotificationHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition` |
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| Projekt | `IProjekt` | `Projekt` |
