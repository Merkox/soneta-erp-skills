# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Projekt`
Nazwa tabeli: `Projekty`
Tytuł: Projekty CRM
Opis: Projekt CRM realizowany w ramach kampanii marketingowej. Zawiera harmonogram, etapy, stany realizacji, wartości planowane, kontrahenta, budżet oraz osoby odpowiedzialne.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBudzetowany`, `IEmailElement`, `IElementSlownika`, `IProjekt`, `IDocumentHostCRM`

- pola bazodanowe: 28
- pola kalkulowane (z klas biznesowych): 49

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe | Aktywny | Wskazuje, czy projekt w tym stanie jest aktywny (otwarty). |
| AllDayEvent | `bool` |  |  |  |
| BudzetPodstawowy | `Soneta.Zadania.Budzetowanie.BudzetProjektu` |  |  |  |
| Budzety | `Soneta.Business.SubTable<Soneta.Zadania.Budzetowanie.BudzetProjektu>` |  |  |  |
| Cel | `Soneta.Business.MemoText` | bazodanowe | Cel | Opis celu prowadzenia projektu |
| CzyProjektOperatora | `bool` |  |  |  |
| Data | `Soneta.Types.Date` |  |  |  |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Planowana data zakończenia projektu |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia projektu |
| Definicja | `Soneta.Zadania.DefProjektu` | bazodanowe |  | Definicja projektu. |
| DefinicjaBudzetuPodstawowegoSymbol | `string` |  |  |  |
| Definition | `Soneta.Business.IWizardReferenceHost` | iface-ref |  |  |
| Description | `string` |  |  |  |
| DokCRMUslugi | `Soneta.Zadania.DokumentCRM` |  |  |  |
| DokHanUslugi | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| DokHanUslugiPozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| DokumentyCRM | `Soneta.Business.SubTable<Soneta.Zadania.DokumentCRM>` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| End | `System.DateTime` |  |  |  |
| EntitleGuid | `System.Guid` | bazodanowe |  | Uprawnienie dla którego przypisany jest projekt. |
| Etap | `Soneta.Zadania.EtapProjektu` |  |  |  |
| EtapBudzetu | `Soneta.Core.IEtapBudzetu` |  |  |  |
| EtapIdent | `int` | bazodanowe | Etap | Etap na jakim znajduje się projekt. Relacja do property Ident w liście etapów powiązanych z projektu. |
| EtapyProjektu | `Soneta.Business.LpSubTable<Soneta.Zadania.EtapProjektu>` |  |  |  |
| Host | `Soneta.Business.ISysNotificationHost` | iface-ref |  |  |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| IsCopy | `bool` |  |  |  |
| Kampania | `Soneta.Zadania.Kampania` | bazodanowe |  | Kampania, z którą powiązany jest projekt |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent, któremu przyporządkowany jest projekt. |
| Koszt | `Soneta.Types.Currency` | bazodanowe | Koszt | Zakładane koszty prowadzenia projektu. |
| KosztPlan | `Soneta.Types.Currency` |  |  |  |
| KosztRach | `Soneta.Types.Currency` |  |  |  |
| Leady | `Soneta.Business.SubTable<Soneta.CRM.Lead>` |  |  |  |
| MailTo | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa projektu | Krótka nazwa projektu, na podstawie której będzie można go wyszukiwać |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisany jest projekt. |
| OkresBudzetu | `Soneta.Types.FromTo` |  |  |  |
| OkresProjektu | `Soneta.Types.FromTo` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis projektu |
| PowiazaniaKontElementu | `Soneta.Business.SubTable<Soneta.Ksiega.PowiazanieKontaBase>` |  |  |  |
| ProjektNadrzedneContext | `Soneta.Zadania.Projekt` |  |  |  |
| Projekty | `Soneta.Business.SubTable<Soneta.Zadania.ProjektWykonujacy>` |  |  |  |
| Prowadzacy | `Soneta.Business.App.Operator` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie projektu |
| Przedstawiciel | `Soneta.CRM.KontaktOsoba` | bazodanowe | Przedstawiciel | Osoba odpowiedzialna za prowadzenie projektu ze strony kontrahenta |
| Przychod | `Soneta.Types.Currency` | bazodanowe | Sprzedaż | Zakładana wartość sprzedaży. |
| PrzychodPlan | `Soneta.Types.Currency` |  |  |  |
| PrzychodRach | `Soneta.Types.Currency` |  |  |  |
| RachunekBankowy | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Rachunek bankowy | Rachunek bankowy do rozliczania projektu. |
| Realizacja | `Soneta.Types.Percent` | bazodanowe | Realizacja | Procent realizacji projektu |
| Seria | `string` | bazodanowe | Seria | Seria projektu. |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| StageOverlap | `bool` | bazodanowe | Nachodzenie etapów |  |
| StanIdent | `int` | bazodanowe | Stan | Stan projektu. Relacja do property Ident w liście stanów powiązanych z definicją projektu. |
| StanProjektu | `Soneta.Zadania.StanProjektu` | bazodanowe |  | Stan projektu. |
| Start | `System.DateTime` |  |  |  |
| Symbol | `string` |  |  |  |
| Text | `string` |  |  |  |
| Transakcje | `Soneta.Business.SubTable<Soneta.CRM.Transakcja>` |  |  |  |
| UprawnieniaNaAktywnosciach | `bool` |  |  |  |
| Uprawnienie | `Soneta.Business.App.Entitle` |  |  |  |
| WartoscWyliczana | `bool` | bazodanowe | Wartość wyliczana | Zakładane wartości wyliczane na podstawie listy produktów |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| WykonujacyProjekt | `System.Collections.Generic.IEnumerable<Soneta.Business.App.Operator>` |  |  |  |
| Zadania | `Soneta.Business.SubTable<Soneta.Zadania.Zadanie>` |  |  |  |
| ZadaniaGlowneProjektu | `Soneta.Business.View` |  |  |  |
| ZadaniaProj | `Soneta.Business.View` |  |  |  |
| ZadanieDlaUprawnienia | `bool` |  |  |  |
| Zamkniecie | `Soneta.Business.MemoText` | bazodanowe | Powód zamknięcia | Opis przyczyny zamknięcia projektu. |
| ZasobyCRM | `Soneta.Business.SubTable<Soneta.Zadania.ZasobCRM>` |  |  |  |
| ZasobyPowiazane | `Soneta.Business.View` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IWizardReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition`, `WFDefinition` |
| Host | `ISysNotificationHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition` |
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
