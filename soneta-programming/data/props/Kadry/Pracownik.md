# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Pracownik`
Nazwa tabeli: `Pracownicy`
Tytuł: Pracownicy
Opis: Kartoteka pracowników zawierająca dane identyfikacyjne (kod, nazwisko, imię, PESEL, NIP), typ pracownika, powiązanie z jednostką organizacyjną oraz ustawienia wieloetatowości. Stanowi centralny punkt powiązań z umowami, historią zatrudnienia, nieobecnościami i rozliczeniami.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IZrodloNieobecnosci`, `IZrodloWnioskuONieobecnosc`, `IBazaZrodlaWyplaty`, `IPodmiot`, `IPodmiotKasowy`, `IKontrahent`, `IZrodloPodzielnikaKosztow`, `IElementSlownika`, `IZasobCRM`, `ITaskUser`, `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `IWebOperator`, `IGIODOZgodnyHost`, `IOceniany`, `IOceniający`, `IOdpowiedzialnyZaOcenę`, `IŹródłoKartyOpisuStanowiska`, `IGIODOWymianaDanychHost`, `IGIODOOświadczenieHost`, `IGIODOUprawnienieHost`, `IEmailElement`, `IRozliczenieWynagrodzeniaHost`, `IZestawienieDietZagrHost`, `IZestawienieDietPakietMobilHost`, `IAdresHost`, `IZrodloPlanu`, `IDostepnoscHost`

- pola bazodanowe: 34
- pola kalkulowane (z klas biznesowych): 195

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| Akordy | `Soneta.Business.SubTable<Soneta.Kadry.Akord>` |  |  |  |
| AktualizacjaPrzyImporcie | `bool` |  |  |  |
| Aplikacje | `Soneta.Business.SubTable<Soneta.HR2.RekrutacjaAplikacja>` |  |  |  |
| Archiwum | `Soneta.Kadry.Pracownik.ArchiwumManager` |  |  |  |
| ArchiwumInfo | `Soneta.Kadry.InformacjeOArchiwum` | bazodanowe, enum |  |  |
| Badania | `Soneta.Kadry.Pracownik.BadaniaLekarskieManager` |  |  |  |
| BadaniaLekarskie | `Soneta.Business.SubTable<Soneta.Kadry.BadanieLekarskie>` |  |  |  |
| BasicDocuments | `Soneta.Business.SubTable` |  |  |  |
| BilansyOtwarciaPIT | `Soneta.Business.SubTable<Soneta.Place.BilansOtwarciaPIT>` |  |  |  |
| BoRIAOświata | `Soneta.Business.SubTable<Soneta.Kadry.BoRIAOświata>` |  |  |  |
| BoRIAWarunkiSzczególne | `Soneta.Business.SubTable<Soneta.Kadry.BoRIAWarunkiSzczególne>` |  |  |  |
| BoRIAWynagrodzenia | `Soneta.Business.SubTable<Soneta.Kadry.BoRIAWynagrodzenia>` |  |  |  |
| CeleOkresowe | `Soneta.Business.SubTable<Soneta.HR2.CelOkresowyPracownika>` |  |  |  |
| Czasy | `Soneta.Kalend.KalkulatorPracownika` |  |  |  |
| DefinicjeCzynnikowSzkodliwych | `Soneta.Business.SubTable<Soneta.Kadry.CzynnikSzkodliwyPracownika>` |  |  |  |
| DeklaracjePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| DniPlanu | `Soneta.Business.DateSubTable` |  |  |  |
| DniPlanuKopia | `Soneta.Business.DateSubTable` |  |  |  |
| DniPracy | `Soneta.Business.DateSubTable<Soneta.Kalend.DzienPracy>` |  |  |  |
| DniPracyKopia | `Soneta.Business.DateSubTable` |  |  |  |
| DniRCP | `Soneta.Business.DateSubTable<Soneta.Kalend.DzienRCP>` |  |  |  |
| Dodatki | `Soneta.Business.SubTable<Soneta.Kadry.Dodatek>` |  |  |  |
| DodatkiAutomatyczne | `Soneta.Business.SubTable<Soneta.Place.DodatekAutomatyczny>` |  |  |  |
| DodatkowaDzialalnosc | `bool` | bazodanowe |  |  |
| Dokumenty | `Soneta.Kadry.Pracownik.DokumentyPracownikaManager` |  |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| DokumentyPreliminarza | `Soneta.Business.SubTable<Soneta.Kasa.PreliminarzDokument>` |  |  |  |
| DokumentyRozliczeniowe | `Soneta.Business.SubTable<Soneta.Kasa.DokRozliczBase>` |  |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` |  |  |  |
| EMAIL | `string` |  |  |  |
| Elementy | `Soneta.Kadry.Pracownik.ItElementy` |  |  |  |
| ElementyEtatu | `Soneta.Business.SubTable` |  | Elementy wynagrodzenia |  |
| ElementyOceny | `Soneta.Business.SubTable<Soneta.HR.ElementOcenyPracownika>` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| ElementyPrzeszeregowania | `Soneta.Business.SubTable` |  |  |  |
| ElementyRozlPrac | `Soneta.Business.SubTable<Soneta.Place.DokumentRozliczeniaPracownika>` |  |  |  |
| ElementyRozliczenia | `Soneta.Business.SubTable<Soneta.Place.ElementRozliczeniaPracownika>` |  |  |  |
| ElementyRozliczeniaCzasuPracy | `Soneta.Business.SubTable<Soneta.Kalend.ElementRozliczeniaCzasuPracy>` |  |  |  |
| EtapyRekrutacji | `Soneta.Business.SubTable<Soneta.HR.EtapRekrutacji>` |  |  |  |
| EtatGłówny | `Soneta.Kadry.Pracownik` |  |  |  |
| EwidencjaWyposazeniaHistoria | `Soneta.Business.SubTable` |  |  |  |
| FunduszePozyczkowe | `Soneta.Business.SubTable<Soneta.Kadry.FundPozyczkowy>` |  |  |  |
| GIODOOświadczenia | `Soneta.Business.SubTable<Soneta.Core.GIODOOświadczenie>` |  |  |  |
| GIODOUdostępnienia | `Soneta.Business.SubTable<Soneta.Core.GIODOWymianaDanych>` |  |  |  |
| GIODOUprawnienia | `Soneta.Business.SubTable<Soneta.Core.GIODOUprawnienie>` |  |  |  |
| Grafiki | `Soneta.Business.SubTable<Soneta.Kalend.GrafikPracownika>` |  |  |  |
| HistZatrWgGlownego | `bool` | bazodanowe |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Kadry.PracHistoria>` |  |  |  |
| HistoriaZatrudnienia | `Soneta.Business.SubTable` |  |  |  |
| Identyfikacje | `Soneta.Business.SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` |  |  |  |
| IdentyfikatorKartotekiCentralnej | `string` | bazodanowe |  |  |
| Imie | `string` | bazodanowe |  |  |
| ImięNazwisko | `string` |  | Imię i nazwisko |  |
| IndywidualnaDRA | `bool` | bazodanowe |  |  |
| InformacjeOArchiwum | `Soneta.Business.FromToSubTable<Soneta.Kadry.PracownikWArchiwum>` |  |  |  |
| InneDochody | `Soneta.Business.SubTable` |  |  |  |
| InneDochodyWgGlownego | `bool` | bazodanowe |  |  |
| JęzykiObce | `Soneta.Business.SubTable<Soneta.Kadry.ZnajomośćJęzykaObcego>` |  |  |  |
| Kalendarze | `Soneta.Business.SubTable<Soneta.Kalend.KalendarzBase>` |  |  |  |
| Kandydatury | `Soneta.Business.SubTable<Soneta.HR.Rekrutacja>` |  |  |  |
| KartyKompetencji | `Soneta.Business.SubTable<Soneta.HR2.KartaKompetencjiPracownika>` |  |  |  |
| KartyOpisuStanowiska | `Soneta.Business.SubTable<Soneta.HR2.KartaOpisuStanowiskaBase>` |  |  |  |
| KartyRCP | `Soneta.Business.SubTable<Soneta.Kadry.KartaRCP>` |  |  |  |
| KartyRealizacjiCelu | `Soneta.Business.SubTable<Soneta.HR2.KartaRealizacjiCelu>` |  |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodZasobu | `string` |  |  |  |
| Kontakt | `Soneta.Core.Kontakt` |  |  |  |
| KontrolaAktywna | `bool` |  |  |  |
| KosztyAutorskie | `Soneta.Business.SubTable<Soneta.Place.KosztAutorski>` |  |  |  |
| KwalifikacjeZkl | `Soneta.Business.SubTable<Soneta.HR.ZKL.ZKLPracownik.Kwalifikacje.KwalifikacjePracownikaZkl>` |  |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Last | `Soneta.Kadry.PracHistoria` |  |  |  |
| Leady | `Soneta.Business.SubTable<Soneta.CRM.Lead>` |  |  |  |
| LimitNieograniczony | `bool` |  |  |  |
| Limity | `Soneta.Business.SubTable<Soneta.Kalend.LimitNieobecnosci>` |  |  |  |
| Lokalizacje | `Soneta.Business.SubTable<Soneta.CRM.Lokalizacja>` |  |  |  |
| LokalizacjePracyZdalnej | `Soneta.Business.SubTable<Soneta.Kadry.LokalizacjaPracyZdalnej>` |  |  |  |
| MailTo | `string` |  |  |  |
| MatrycePodmiotu | `Soneta.Business.SubTable` |  |  |  |
| NaDRAUmieszczajREGON | `bool` | bazodanowe |  |  |
| Nadrzedny | `Soneta.Core.IPodmiotInternal` |  |  |  |
| NagrodyKary | `Soneta.Business.SubTable<Soneta.Kadry.NagrodaKara>` |  |  |  |
| Nazwa | `string` |  |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
| NazwaZasobu | `string` |  |  |  |
| Nazwisko | `string` | bazodanowe |  |  |
| NazwiskoImię | `string` |  | Nazwisko i imię |  |
| Net | `Soneta.Kadry.PracownikNet` | bazodanowe |  |  |
| Net.AutoZatwWniosku | `bool` | bazodanowe |  | Automatyczne zatwierdzanie wniosku urlopowego |
| Net.PodwladniNizszegoPoziomu | `bool` | bazodanowe |  | Określa czy wyświetlać w Net, dane podwładnych z niższych poziomów podległości. |
| Net.WidocznyWNet | `bool` | bazodanowe |  | Czy pracownik jest widoczny na listach programu Net |
| Nieobecnosci | `Soneta.Business.FromToSubTable<Soneta.Kalend.Nieobecnosc>` |  |  |  |
| NieobecnosciERP7 | `Soneta.Business.SubTable<Soneta.Kalend.NieobecnoscERP7>` |  |  |  |
| NumerRachunkuUS | `Soneta.Core.NumerRachunkuUS` | bazodanowe |  |  |
| NumerRachunkuUS.CS | `string` |  |  |  |
| NumerRachunkuUS.Kierunek | `string` |  |  |  |
| NumerRachunkuUS.Kraj | `string` |  |  |  |
| NumerRachunkuUS.Numer | `string` |  |  |  |
| NumerRachunkuUS.Rachunek | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| NumerRachunkuUS.SWIFT | `string` |  |  |  |
| NumerRachunkuUS.WgRachunek | `Soneta.Business.Key` |  |  |  |
| NumerRachunkuZUS | `Soneta.Core.NumerRachunkuZUS` | bazodanowe |  |  |
| NumerRachunkuZUS.CS | `string` |  |  |  |
| NumerRachunkuZUS.Kierunek | `string` |  |  |  |
| NumerRachunkuZUS.Kraj | `string` |  |  |  |
| NumerRachunkuZUS.Numer | `string` |  |  |  |
| NumerRachunkuZUS.Rachunek | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| NumerRachunkuZUS.SWIFT | `string` |  |  |  |
| NumerRachunkuZUS.WgRachunek | `Soneta.Business.Key` |  |  |  |
| ObszaryOdpowiedzialnosci | `Soneta.Business.SubTable<Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciPracownikaZkl>` |  |  |  |
| Oceniający | `Soneta.Business.SubTable<Soneta.Oceny.OcenaOceniający>` |  |  |  |
| Oceniani | `Soneta.Business.SubTable<Soneta.Oceny.OcenaOceniany>` |  |  |  |
| Oceny | `Soneta.Business.SubTable<Soneta.HR.OcenaPracownika>` |  |  |  |
| OddzialZWydzialu | `Soneta.Core.OddzialFirmy` |  |  |  |
| OfertyPracy | `Soneta.Business.SubTable<Soneta.HR2.OfertaPracy>` |  |  |  |
| OkresyWakacjiSkladki | `Soneta.Business.SubTable<Soneta.Kadry.OkresWakacjiSkladki>` |  |  |  |
| OpiekaPracownika | `Soneta.Business.DateSubTable<Soneta.Place.OświadczenieZusOpieka>` |  |  |  |
| Opis | `string` | bazodanowe |  |  |
| Osoby | `Soneta.Business.SubTable<Soneta.CRM.KontaktOsoba>` |  |  |  |
| OsobyKontaktowe | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` |  |  |  |
| OsobyZOsobyKontrahent | `Soneta.Business.View` |  |  |  |
| Oświadczenia | `Soneta.Business.SubTable<Soneta.Kadry.OświadczeniePracownika>` |  |  |  |
| PESEL | `string` | bazodanowe |  |  |
| PlanowaneElementy | `Soneta.Business.SubTable<Soneta.Place.PlanowanyElementWypłaty>` |  |  |  |
| PlanowaneNieobecności | `Soneta.Business.FromToSubTable<Soneta.Kalend.PlanowanaNieobecność>` |  |  |  |
| PlanowaneWypłaty | `Soneta.Business.SubTable<Soneta.Place.PlanowanaWypłata>` |  |  |  |
| Platnosci | `Soneta.Business.SubTable<Soneta.Kasa.Platnosc>` |  |  |  |
| PodmiotPowiazany | `bool` |  |  |  |
| Podrzedni | `Soneta.Business.SubTable<Soneta.CRM.RelacjaPodmiotu>` |  |  |  |
| PodstawyNieobecności | `Soneta.Business.SubTable<Soneta.Place.PodstawaNieobecnosci>` |  |  |  |
| PodstawyNieobecnościOkresowe | `Soneta.Business.SubTable<Soneta.Place.PodstawaNieobecnosciOkresowa>` |  |  |  |
| Podzielniki | `Soneta.Business.SubTable<Soneta.Core.PodzielnikKosztow>` |  |  |  |
| Pojazdy | `Soneta.Business.SubTable` |  |  |  |
| PotwierdzeniaGIODO | `Soneta.Business.SubTable<Soneta.Core.GIODOZgodny>` |  |  |  |
| PowiazaniWłaściciele | `System.Collections.Generic.IEnumerable<Soneta.Kadry.Pracownik>` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| PowiazanyKontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| PowiązaniaStrOrg | `Soneta.Business.SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` |  |  |  |
| PoświadczeniaOdbioru | `Soneta.Business.SubTable<Soneta.Core.PoświadczenieOdbioru>` |  |  |  |
| PracaWPolsce | `Soneta.Types.Periods` |  |  |  |
| PracaZaGranicą | `Soneta.Types.Periods` |  |  |  |
| Pracownicy | `Soneta.Business.SubTable<Soneta.Kadry.Pracownik>` |  |  |  |
| PracownicyKartotekaCentralnaIWieloetatowosc | `Soneta.Kadry.Pracownik[]` |  |  |  |
| PracownicyPowiązani | `Soneta.Kadry.Pracownik[]` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` |  |  |  |
| PracownikTymczasowy | `Soneta.Kadry.Pracownik.PracownikTymczasowyManager` |  |  |  |
| Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Projekty | `Soneta.Business.SubTable` |  |  |  |
| Przelewy | `Soneta.Business.SubTable<Soneta.Kasa.PrzelewBase>` |  |  |  |
| PrzeterminowanieNieograniczone | `bool` |  |  |  |
| PrzychodyRyczalty | `Soneta.Business.SubTable<Soneta.Kadry.PrzychodRyczalt>` |  |  |  |
| PrzychodyZDzialnosci | `Soneta.Business.SubTable<Soneta.Kadry.PrzychodZDzialnosci>` |  |  |  |
| Rachunki | `Soneta.Business.SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` |  |  |  |
| RachunkiWirtualne | `Soneta.Business.SubTable<Soneta.Kasa.RachunekWirtualny>` |  |  |  |
| RegulyDostepnosci | `Soneta.Business.SubTable<Soneta.Kalend.RegulaDostepnosci>` |  |  |  |
| Rekrutacje | `Soneta.Business.SubTable<Soneta.HR.Rekrutacja>` |  |  |  |
| Rodzaj | `Soneta.Kadry.RodzajPracownika` | bazodanowe, enum |  |  |
| RodzajePodmiotu | `Soneta.Business.SubTable<Soneta.Core.RodzajPodmiot>` |  |  |  |
| Rodzina | `Soneta.Business.SubTable<Soneta.Kadry.CzlonekRodziny>` |  |  |  |
| Rozliczenia | `System.Collections.Generic.IEnumerable<Soneta.Place.RozliczenieWynagrodzenia>` |  |  |  |
| RozliczeniaCzasuPracy | `Soneta.Business.SubTable<Soneta.Kalend.RozliczenieCzasuPracy>` |  |  |  |
| RozliczeniaWynagrodzenia | `Soneta.Business.LpSubTable<Soneta.Place.RozliczenieWynagrodzenia>` |  |  |  |
| Rozliczenie | `Soneta.Place.RozliczenieWynagrodzenia` |  |  |  |
| Rozrachunki | `Soneta.Business.SubTable<Soneta.Kasa.RozrachunekIdx>` |  |  |  |
| Schorzenia | `Soneta.Business.SubTable<Soneta.Kadry.Schorzenie>` |  |  |  |
| SplacaneRaty | `Soneta.Business.SubTable<Soneta.Kadry.RataPozyczki>` |  |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `Soneta.Business.SubTable` |  |  |  |
| SrodkiTrwaleHistoria | `Soneta.Business.SubTable` |  |  |  |
| StażPracyInfo | `Soneta.Kadry.Pracownik.StażPracyManager` |  |  |  |
| StornaElementow | `Soneta.Business.SubTable<Soneta.Place.StornoElementu>` |  |  |  |
| StrukturaOraganizacyjna | `Soneta.Kadry.Pracownik.StrukturaOraganizacyjnaManager` |  |  |  |
| Swiadczenia | `Soneta.Business.SubTable<Soneta.Kadry.SwiadczSocjalne>` |  |  |  |
| SzkoleniaBHP | `Soneta.Business.SubTable<Soneta.Kadry.SzkolenieBHP>` |  |  |  |
| Transakcje | `Soneta.Business.SubTable<Soneta.CRM.Transakcja>` |  |  |  |
| TransakcjeKontrahenta | `Soneta.Business.SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` |  |  |  |
| Typ | `Soneta.Kadry.TypPracownika` | bazodanowe, enum |  |  |
| TypZasobu | `string` |  |  |  |
| UkończoneSzkolenia | `Soneta.Business.SubTable<Soneta.HR.UkończoneSzkolenie>` |  |  |  |
| UlgaWgGlownego | `bool` | bazodanowe |  |  |
| UlgiInnowacyjne | `Soneta.Business.SubTable<Soneta.Kadry.UlgaInnowacyjna>` |  |  |  |
| Umowy | `Soneta.Business.SubTable<Soneta.Kadry.Umowa>` |  |  |  |
| UmowyZewnetrzne | `Soneta.Business.SubTable<Soneta.Kadry.UmowaZewnetrzna>` |  |  |  |
| Uprawnienia | `Soneta.Business.SubTable<Soneta.HR.UprawnieniePracownika>` |  |  |  |
| Urzadzenia | `Soneta.Business.SubTable` |  |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Wakaty | `Soneta.Business.SubTable<Soneta.HR2.RekrutacjaWakat>` |  |  |  |
| WeWyI | `Soneta.Business.SubTable<Soneta.Kalend.WejscieWyjscieI>` |  |  |  |
| WeWyO | `Soneta.Business.SubTable<Soneta.Kalend.WejscieWyjscieO>` |  |  |  |
| WebUserDescription | `string` |  |  |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
| Wieloetatowosc | `Soneta.Kadry.TypyWieloetatowosci` | bazodanowe, enum |  |  |
| WieloetatowoscImportujNBPUE | `bool` | bazodanowe |  |  |
| Wlasciciel | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| WnioskiKierownika | `Soneta.Business.SubTable<Soneta.Kadry.WniosekUrlopowy>` |  |  |  |
| WnioskiOSzkolenia | `Soneta.Business.SubTable<Soneta.HR.WniosekOSzkolenie>` |  |  |  |
| WnioskiOZwrotNienalOpłSkł | `Soneta.Business.SubTable<Soneta.Kadry.WniosekZwrotOplSkl>` |  |  |  |
| WnioskiPracyZdalnej | `Soneta.Business.SubTable<Soneta.Kalend.WniosekPracyZdalnej>` |  |  |  |
| WnioskiPracyZdalnejKierownika | `Soneta.Business.SubTable<Soneta.Kalend.WniosekPracyZdalnej>` |  |  |  |
| WnioskiUrlopowe | `Soneta.Business.SubTable<Soneta.Kadry.WniosekUrlopowy>` |  |  |  |
| WnioskiZastępcy | `Soneta.Business.SubTable<Soneta.Kadry.WniosekUrlopowy>` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| WykonujacyPracownika | `Soneta.Business.SubTable<Soneta.Kadry.RelacjaWykonPrac>` |  |  |  |
| WynagrodzeniaERP7 | `Soneta.Business.SubTable<Soneta.Kalend.WynagrodzenieERP7>` |  |  |  |
| Wypadki | `Soneta.Business.SubTable<Soneta.Kadry.Wypadek>` |  |  |  |
| Wyplaty | `Soneta.Business.SubTable<Soneta.Place.Wyplata>` |  |  |  |
| Zadania | `Soneta.Business.SubTable` |  |  |  |
| ZadaniaKontrahenta | `Soneta.Business.SubTable` |  |  |  |
| ZajeciaWynagrWgGlownego | `bool` | bazodanowe |  |  |
| ZajęciaKomornicze | `Soneta.Business.SubTable<Soneta.Kadry.ZajęcieKomornicze>` |  |  |  |
| Zaliczki | `Soneta.Business.SubTable<Soneta.Place.Zaliczka>` |  |  |  |
| ZaniechaniaPodatkowe | `Soneta.Business.DateSubTable<Soneta.Place.ZaniechaniePodatkowe>` |  |  |  |
| Zaplaty | `Soneta.Business.SubTable<Soneta.Kasa.Zaplata>` |  |  |  |
| ZasInnyPłatnik | `Soneta.Business.SubTable<Soneta.Place.ZasiłekInnyPłatnik>` |  |  |  |
| ZasobyCRM | `Soneta.Business.SubTable` |  |  |  |
| ZasobyRN | `Soneta.Business.SubTable<Soneta.Kalend.ZasobRN>` |  |  |  |
| ZbiegUbespWgGlownego | `bool` | bazodanowe |  |  |
| ZbiegiPracyIRodzicielstwa | `Soneta.Business.FromToSubTable<Soneta.Kalend.ZbiegPracyIRodzicielstwa>` |  |  |  |
| ZbiegiUbezpieczen | `Soneta.Business.SubTable` |  |  |  |
| Zdarzenia | `Soneta.Business.SubTable<Soneta.CRM.DokumentZdarzenia>` |  |  |  |
| ZestDietPakietMobil | `Soneta.Business.SubTable<Soneta.Kalend.ZestDietPakietMobil>` |  |  |  |
| Zestawienia | `Soneta.Business.FromToSubTable<Soneta.Kalend.ZestawieniePracy>` |  |  |  |
| ZestawieniaDiet | `Soneta.Business.FromToSubTable<Soneta.Kalend.ZestawienieDietZagr>` |  |  |  |
| ZgloszSygnalisty | `Soneta.Business.SubTable<Soneta.Kadry.ZgloszenieSygnalisty>` |  |  |  |
| ZgodnoscGIODOPotwierdzona | `bool` |  |  |  |
| ZyrowaneRaty | `Soneta.Business.SubTable<Soneta.Kadry.RataPozyczki>` |  |  |  |
| ŻyrowanePożyczki | `Soneta.Business.SubTable<Soneta.Kadry.ŻyrantPożyczki>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### InformacjeOArchiwum (`Soneta.Kadry.InformacjeOArchiwum`)
- `NieDotyczy` = 0 — Nie dotyczy
- `WArchiwum` = 1
- `Przywrócony` = 2

### RodzajPracownika (`Soneta.Kadry.RodzajPracownika`)
- `Etat` = 0
- `Zlecenie` = 1
- `B2B` = 2
- `PracownikAPT` = 3 — Pracownik APT

### TypPracownika (`Soneta.Kadry.TypPracownika`)
- `Pracownik` = 1
- `Właściciel` = 2
- `OsobaWspółpracująca` = 3

### TypyWieloetatowosci (`Soneta.Kadry.TypyWieloetatowosci`)
- `NieDotyczy` = 0 — Nie dotyczy
- `EtatGłówny` = 1
- `EtatDodatkowy` = 2
