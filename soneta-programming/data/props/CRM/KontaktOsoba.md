# Pola i właściwości klasy biznesowej: `Soneta.CRM.KontaktOsoba`
Nazwa tabeli: `KontaktyOsoby`
Tytuł: Osoby
Opis: Kartoteka osób kontaktowych powiązanych z kontrahentami. Przechowuje dane personalne, stanowisko, informacje kontaktowe i adresowe osób reprezentujących kontrahentów, umożliwiając prowadzenie komunikacji biznesowej i rejestrację wizytówek.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`, `IKodowany`, `IWebOperator`, `IDaneKontaktoweHost`, `ITowaryUlubioneHost`, `IGIODOZgodnyHost`, `IGIODOWymianaDanychHost`, `IGIODOOświadczenieHost`, `IGIODOUprawnienieHost`, `IOceniający`, `IOdpowiedzialnyZaOcenę`, `IEmailElement`, `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `ITaskUser`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 42

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| BasicDocuments | `Soneta.Business.SubTable` |  |  |  |
| ButtonCaption | `string` |  |  |  |
| DuplicateGroupCaption | `string` |  |  |  |
| EMAIL | `string` |  |  |  |
| EtapyRekrutacji | `Soneta.Business.SubTable` |  |  |  |
| GIODOOświadczenia | `Soneta.Business.SubTable<Soneta.Core.GIODOOświadczenie>` |  |  |  |
| GIODOUdostępnienia | `Soneta.Business.SubTable<Soneta.Core.GIODOWymianaDanych>` |  |  |  |
| GIODOUprawnienia | `Soneta.Business.SubTable<Soneta.Core.GIODOUprawnienie>` |  |  |  |
| Imie | `string` | bazodanowe |  |  |
| IsAllowed | `bool` |  |  |  |
| JestWizytowkaFirmy | `bool` |  |  |  |
| Kod | `string` |  |  |  |
| KodyKreskowe | `Soneta.Business.SubTable<Soneta.Core.KodKreskowy>` |  |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| KontrahentKontekstowy | `Soneta.Core.IKontrahent` | iface-ref |  |  |
| KontrolaAktywna | `bool` |  |  |  |
| Leady | `Soneta.Business.SubTable<Soneta.CRM.Lead>` |  |  |  |
| MailTo | `string` |  |  |  |
| Nazwa | `string` |  |  |  |
| Nazwisko | `string` | bazodanowe |  |  |
| Nieaktualny | `bool` | bazodanowe |  |  |
| Oceniający | `Soneta.Business.SubTable` |  |  |  |
| OfertyPracy | `Soneta.Business.SubTable` |  |  |  |
| OstatniKontaktWaznaData | `Soneta.CRM.Osoba_Kontrahent.KontaktWazneDaty` |  |  |  |
| PotwierdzeniaGIODO | `Soneta.Business.SubTable<Soneta.Core.GIODOZgodny>` |  |  |  |
| PowiazaniKontrahenci | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` |  |  |  |
| PowiązaniaStrOrg | `Soneta.Business.SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` |  |  |  |
| PoświadczeniaOdbioru | `Soneta.Business.SubTable<Soneta.Core.PoświadczenieOdbioru>` |  |  |  |
| Projekty | `Soneta.Business.SubTable` |  |  |  |
| Rekrutacje | `Soneta.Business.SubTable` |  |  |  |
| Stanowisko | `string` | bazodanowe |  |  |
| TaskList | `Soneta.Business.SubTable` |  |  |  |
| TowaryUlubione | `Soneta.Business.SubTable` |  |  |  |
| Transakcje | `Soneta.Business.SubTable<Soneta.CRM.Transakcja>` |  |  |  |
| TransakcjeOsoby | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Wakaty | `Soneta.Business.SubTable` |  |  |  |
| WazneDaty | `System.Collections.Generic.IEnumerable<Soneta.CRM.Osoba_Kontrahent.KontaktWazneDaty>` |  |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Wizytowka | `bool` | bazodanowe | Wizytówka | Określa czy dane osoby są wizytówką. |
| WizytowkaFirmy | `Soneta.CRM.Wizytowki.WizytowkaFirmy` |  |  |  |
| Wizytowki | `Soneta.Business.SubTable<Soneta.CRM.Wizytowki.WizytowkaFirmy>` |  |  |  |
| Zadania | `Soneta.Business.SubTable` |  |  |  |
| ZadaniaOsoby | `Soneta.Business.SubTable` |  |  |  |
| ZgloszSygnalisty | `Soneta.Business.SubTable` |  |  |  |
| ZgodnoscGIODOPotwierdzona | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
| KontrahentKontekstowy | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
