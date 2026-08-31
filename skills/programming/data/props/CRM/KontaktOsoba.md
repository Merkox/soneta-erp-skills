# Pola i właściwości klasy biznesowej: `Soneta.CRM.KontaktOsoba`
Nazwa tabeli: `KontaktyOsoby`
Tytuł: Osoby
Opis: Kartoteka osób kontaktowych powiązanych z kontrahentami. Przechowuje dane personalne, stanowisko, informacje kontaktowe i adresowe osób reprezentujących kontrahentów, umożliwiając prowadzenie komunikacji biznesowej i rejestrację wizytówek.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`, `IKodowany`, `IWebOperator`, `IDaneKontaktoweHost`, `ITowaryUlubioneHost`, `IGIODOZgodnyHost`, `IGIODOWymianaDanychHost`, `IGIODOOświadczenieHost`, `IGIODOUprawnienieHost`, `IOceniający`, `IOdpowiedzialnyZaOcenę`, `IEmailElement`, `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `ITaskUser`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| BasicDocuments | `SubTable` | podlista |  |  |
| ButtonCaption | `string` | tylko-odczyt |  |  |
| DuplicateGroupCaption | `string` | tylko-odczyt |  |  |
| EMAIL | `string` |  |  |  |
| EtapyRekrutacji | `SubTable` | podlista |  |  |
| GIODOOświadczenia | `SubTable<Soneta.Core.GIODOOświadczenie>` | podlista |  |  |
| GIODOUdostępnienia | `SubTable<Soneta.Core.GIODOWymianaDanych>` | podlista |  |  |
| GIODOUprawnienia | `SubTable<Soneta.Core.GIODOUprawnienie>` | podlista |  |  |
| Imie | `string` | bazodanowe |  |  |
| IsAllowed | `bool` | tylko-odczyt |  |  |
| JestWizytowkaFirmy | `bool` | tylko-odczyt |  |  |
| Kod | `string` | tylko-odczyt |  |  |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| Kontakt | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| KontrahentKontekstowy | `Soneta.Core.IKontrahent` | iface-ref |  |  |
| KontrolaAktywna | `bool` | tylko-odczyt |  |  |
| Leady | `SubTable<Soneta.CRM.Lead>` | podlista |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Nazwisko | `string` | bazodanowe |  |  |
| Nieaktualny | `bool` | bazodanowe |  |  |
| Oceniający | `SubTable` | podlista |  |  |
| OfertyPracy | `SubTable` | podlista |  |  |
| OstatniKontaktWaznaData | `Soneta.CRM.Osoba_Kontrahent.KontaktWazneDaty` | tylko-odczyt |  |  |
| PotwierdzeniaGIODO | `SubTable<Soneta.Core.GIODOZgodny>` | podlista |  |  |
| PowiazaniKontrahenci | `SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` | podlista |  |  |
| PowiązaniaStrOrg | `SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` | podlista |  |  |
| PoświadczeniaOdbioru | `SubTable<Soneta.Core.PoświadczenieOdbioru>` | podlista |  |  |
| Projekty | `SubTable` | podlista |  |  |
| Rekrutacje | `SubTable` | podlista |  |  |
| Stanowisko | `string` | bazodanowe |  |  |
| TaskList | `SubTable` | podlista |  |  |
| TowaryUlubione | `SubTable` | podlista |  |  |
| Transakcje | `SubTable<Soneta.CRM.Transakcja>` | podlista |  |  |
| TransakcjeOsoby | `SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| Wakaty | `SubTable` | podlista |  |  |
| WazneDaty | `System.Collections.Generic.IEnumerable<Soneta.CRM.Osoba_Kontrahent.KontaktWazneDaty>` | podlista |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Wizytowka | `bool` | bazodanowe, tylko-odczyt | Wizytówka | Określa czy dane osoby są wizytówką. |
| WizytowkaFirmy | `Soneta.CRM.Wizytowki.WizytowkaFirmy` | tylko-odczyt |  |  |
| Wizytowki | `SubTable<Soneta.CRM.Wizytowki.WizytowkaFirmy>` | podlista |  |  |
| Zadania | `SubTable` | podlista |  |  |
| ZadaniaOsoby | `SubTable` | podlista |  |  |
| ZgloszSygnalisty | `SubTable` | podlista |  |  |
| ZgodnoscGIODOPotwierdzona | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| KontrahentKontekstowy | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
