# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Projekt`
Nazwa tabeli: `Projekty`
Tytuł: Projekty CRM
Opis: Projekt CRM realizowany w ramach kampanii marketingowej. Zawiera harmonogram, etapy, stany realizacji, wartości planowane, kontrahenta, budżet oraz osoby odpowiedzialne.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBudzetowany`, `IEmailElement`, `IElementSlownika`, `IProjekt`, `IDocumentHostCRM`

- pola bazodanowe (zapisywalne): 21
- pola kalkulowane (zapisywalne): 11
- pola tylko-odczyt: 22
- podlisty: 22
- subrowy: 1
- razem: 77

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe, tylko-odczyt | Aktywny | Wskazuje, czy projekt w tym stanie jest aktywny (otwarty). |
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| BudzetPodstawowy | `Soneta.Zadania.Budzetowanie.BudzetProjektu` | tylko-odczyt |  |  |
| Budzety | `SubTable<Soneta.Zadania.Budzetowanie.BudzetProjektu>` | podlista |  |  |
| Cel | `MemoText` | bazodanowe, podlista | Cel | Opis celu prowadzenia projektu |
| CzyProjektOperatora | `bool` | tylko-odczyt |  |  |
| Data | `Date` | tylko-odczyt |  |  |
| DataDo | `Date` | bazodanowe | Data zakończenia | Planowana data zakończenia projektu |
| DataOd | `Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia projektu |
| Definicja | `Soneta.Zadania.DefProjektu` | bazodanowe |  | Definicja projektu. |
| DefinicjaBudzetuPodstawowegoSymbol | `string` |  |  |  |
| Definition | `IWizardReferenceHost` | tylko-odczyt, iface-ref |  |  |
| Description | `string` | tylko-odczyt |  |  |
| DokCRMUslugi | `Soneta.Zadania.DokumentCRM` | tylko-odczyt |  |  |
| DokHanUslugi | `Soneta.Handel.DokumentHandlowy` |  |  |  |
| DokHanUslugiPozycja | `Soneta.Handel.PozycjaDokHandlowego` |  |  |  |
| DokumentyCRM | `SubTable<Soneta.Zadania.DokumentCRM>` | podlista |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| End | `System.DateTime` | tylko-odczyt |  |  |
| EntitleGuid | `System.Guid` | bazodanowe |  | Uprawnienie dla którego przypisany jest projekt. |
| Etap | `Soneta.Zadania.EtapProjektu` |  |  |  |
| EtapBudzetu | `Soneta.Core.IEtapBudzetu` |  |  |  |
| EtapIdent | `int` | bazodanowe | Etap | Etap na jakim znajduje się projekt. Relacja do property Ident w liście etapów powiązanych z projektu. |
| EtapyProjektu | `LpSubTable<Soneta.Zadania.EtapProjektu>` | podlista |  |  |
| Host | `ISysNotificationHost` | tylko-odczyt, iface-ref |  |  |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| IsCopy | `bool` |  |  |  |
| Kampania | `Soneta.Zadania.Kampania` | bazodanowe |  | Kampania, z którą powiązany jest projekt |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  | Kontrahent, któremu przyporządkowany jest projekt. |
| Koszt | `Currency` | bazodanowe | Koszt | Zakładane koszty prowadzenia projektu. |
| KosztPlan | `Currency` | tylko-odczyt |  |  |
| KosztRach | `Currency` | tylko-odczyt |  |  |
| Leady | `SubTable<Soneta.CRM.Lead>` | podlista |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa projektu | Krótka nazwa projektu, na podstawie której będzie można go wyszukiwać |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisany jest projekt. |
| OkresBudzetu | `FromTo` | podlista |  |  |
| OkresProjektu | `FromTo` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis projektu |
| PowiazaniaKontElementu | `SubTable<Soneta.Ksiega.PowiazanieKontaBase>` | podlista |  |  |
| ProjektNadrzedneContext | `Soneta.Zadania.Projekt` |  |  |  |
| Projekty | `SubTable<Soneta.Zadania.ProjektWykonujacy>` | podlista |  |  |
| Prowadzacy | `App.Operator` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie projektu |
| Przedstawiciel | `Soneta.CRM.KontaktOsoba` | bazodanowe | Przedstawiciel | Osoba odpowiedzialna za prowadzenie projektu ze strony kontrahenta |
| Przychod | `Currency` | bazodanowe | Sprzedaż | Zakładana wartość sprzedaży. |
| PrzychodPlan | `Currency` | tylko-odczyt |  |  |
| PrzychodRach | `Currency` | tylko-odczyt |  |  |
| RachunekBankowy | `Soneta.Kasa.EwidencjaSP` | bazodanowe | Rachunek bankowy | Rachunek bankowy do rozliczania projektu. |
| Realizacja | `Percent` | bazodanowe | Realizacja | Procent realizacji projektu |
| Seria | `string` | bazodanowe | Seria | Seria projektu. |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| StageOverlap | `bool` | bazodanowe, tylko-odczyt | Nachodzenie etapów |  |
| StanIdent | `int` | bazodanowe | Stan | Stan projektu. Relacja do property Ident w liście stanów powiązanych z definicją projektu. |
| StanProjektu | `Soneta.Zadania.StanProjektu` | bazodanowe |  | Stan projektu. |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Symbol | `string` | tylko-odczyt |  |  |
| Text | `string` |  |  |  |
| Transakcje | `SubTable<Soneta.CRM.Transakcja>` | podlista |  |  |
| UprawnieniaNaAktywnosciach | `bool` | tylko-odczyt |  |  |
| Uprawnienie | `App.Entitle` |  |  |  |
| WartoscWyliczana | `bool` | bazodanowe | Wartość wyliczana | Zakładane wartości wyliczane na podstawie listy produktów |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| WykonujacyProjekt | `System.Collections.Generic.IEnumerable<App.Operator>` | podlista |  |  |
| Zadania | `SubTable<Soneta.Zadania.Zadanie>` | podlista |  |  |
| ZadaniaGlowneProjektu | `View` | podlista |  |  |
| ZadaniaProj | `View` | podlista |  |  |
| ZadanieDlaUprawnienia | `bool` |  |  |  |
| Zamkniecie | `MemoText` | bazodanowe, podlista | Powód zamknięcia | Opis przyczyny zamknięcia projektu. |
| ZasobyCRM | `SubTable<Soneta.Zadania.ZasobCRM>` | podlista |  |  |
| ZasobyPowiazane | `View` | podlista |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IWizardReferenceHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition`, `WFDefinition` |
| Host | `ISysNotificationHost` | `DbTupleDefinition`, `DefLeada`, `DefProjektu`, `DefTransakcja`, `DefZadania`, `TaskDefinition` |
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
