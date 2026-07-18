# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Pracownik`
Nazwa tabeli: `Pracownicy`
Tytuł: Pracownicy
Opis: Kartoteka pracowników zawierająca dane identyfikacyjne (kod, nazwisko, imię, PESEL, NIP), typ pracownika, powiązanie z jednostką organizacyjną oraz ustawienia wieloetatowości. Stanowi centralny punkt powiązań z umowami, historią zatrudnienia, nieobecnościami i rozliczeniami.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `PracHistoria`
Implementuje interfejsy: `IZrodloNieobecnosci`, `IZrodloWnioskuONieobecnosc`, `IBazaZrodlaWyplaty`, `IPodmiot`, `IPodmiotKasowy`, `IKontrahent`, `IZrodloPodzielnikaKosztow`, `IElementSlownika`, `IZasobCRM`, `ITaskUser`, `IŹródłoPowiązaniaStrukturyOrganizacyjnej`, `IWebOperator`, `IGIODOZgodnyHost`, `IOceniany`, `IOceniający`, `IOdpowiedzialnyZaOcenę`, `IŹródłoKartyOpisuStanowiska`, `IGIODOWymianaDanychHost`, `IGIODOOświadczenieHost`, `IGIODOUprawnienieHost`, `IEmailElement`, `IRozliczenieWynagrodzeniaHost`, `IZestawienieDietZagrHost`, `IZestawienieDietPakietMobilHost`, `IAdresHost`, `IZrodloPlanu`, `IDostepnoscHost`

- pola bazodanowe (zapisywalne): 24
- pola kalkulowane (zapisywalne): 12
- pola tylko-odczyt: 39
- podlisty: 150
- subrowy: 3
- razem: 228

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| Akordy | `SubTable<Soneta.Kadry.Akord>` | podlista |  |  |
| AktualizacjaPrzyImporcie | `bool` | tylko-odczyt |  |  |
| Aplikacje | `SubTable<Soneta.HR2.RekrutacjaAplikacja>` | podlista |  |  |
| Archiwum | `Soneta.Kadry.Pracownik.ArchiwumManager` | tylko-odczyt |  |  |
| ArchiwumInfo | `Soneta.Kadry.InformacjeOArchiwum` (enum) | bazodanowe, tylko-odczyt |  |  |
| Badania | `Soneta.Kadry.Pracownik.BadaniaLekarskieManager` | tylko-odczyt |  |  |
| BadaniaLekarskie | `SubTable<Soneta.Kadry.BadanieLekarskie>` | podlista |  |  |
| BasicDocuments | `SubTable` | podlista |  |  |
| BilansyOtwarciaPIT | `SubTable<Soneta.Place.BilansOtwarciaPIT>` | podlista |  |  |
| BoRIAOświata | `SubTable<Soneta.Kadry.BoRIAOświata>` | podlista |  |  |
| BoRIAWarunkiSzczególne | `SubTable<Soneta.Kadry.BoRIAWarunkiSzczególne>` | podlista |  |  |
| BoRIAWynagrodzenia | `SubTable<Soneta.Kadry.BoRIAWynagrodzenia>` | podlista |  |  |
| CeleOkresowe | `SubTable<Soneta.HR2.CelOkresowyPracownika>` | podlista |  |  |
| Czasy | `Soneta.Kalend.KalkulatorPracownika` | tylko-odczyt |  |  |
| DefinicjeCzynnikowSzkodliwych | `SubTable<Soneta.Kadry.CzynnikSzkodliwyPracownika>` | podlista |  |  |
| DeklaracjePodmiotu | `SubTable` | podlista |  |  |
| DniPlanu | `DateSubTable` | podlista |  |  |
| DniPlanuKopia | `DateSubTable` | podlista |  |  |
| DniPracy | `DateSubTable<Soneta.Kalend.DzienPracy>` | podlista |  |  |
| DniPracyKopia | `DateSubTable` | podlista |  |  |
| DniRCP | `DateSubTable<Soneta.Kalend.DzienRCP>` | podlista |  |  |
| Dodatki | `SubTable<Soneta.Kadry.Dodatek>` | podlista |  |  |
| DodatkiAutomatyczne | `SubTable<Soneta.Place.DodatekAutomatyczny>` | podlista |  |  |
| DodatkowaDzialalnosc | `bool` | bazodanowe |  |  |
| Dokumenty | `Soneta.Kadry.Pracownik.DokumentyPracownikaManager` | tylko-odczyt |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| DokumentyPreliminarza | `SubTable<Soneta.Kasa.PreliminarzDokument>` | podlista |  |  |
| DokumentyRozliczeniowe | `SubTable<Soneta.Kasa.DokRozliczBase>` | podlista |  |  |
| DomyslnyRachunek | `Soneta.Kasa.RachunekBankowyPodmiotu` | tylko-odczyt |  |  |
| EMAIL | `string` |  |  |  |
| Elementy | `Soneta.Kadry.Pracownik.ItElementy` | tylko-odczyt |  |  |
| ElementyEtatu | `SubTable` | podlista | Elementy wynagrodzenia |  |
| ElementyOceny | `SubTable<Soneta.HR.ElementOcenyPracownika>` | podlista |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| ElementyPrzeszeregowania | `SubTable` | podlista |  |  |
| ElementyRozlPrac | `SubTable<Soneta.Place.DokumentRozliczeniaPracownika>` | podlista |  |  |
| ElementyRozliczenia | `SubTable<Soneta.Place.ElementRozliczeniaPracownika>` | podlista |  |  |
| ElementyRozliczeniaCzasuPracy | `SubTable<Soneta.Kalend.ElementRozliczeniaCzasuPracy>` | podlista |  |  |
| EtapyRekrutacji | `SubTable<Soneta.HR.EtapRekrutacji>` | podlista |  |  |
| EtatGłówny | `Soneta.Kadry.Pracownik` | tylko-odczyt |  |  |
| EwidencjaWyposazeniaHistoria | `SubTable` | podlista |  |  |
| FunduszePozyczkowe | `SubTable<Soneta.Kadry.FundPozyczkowy>` | podlista |  |  |
| GIODOOświadczenia | `SubTable<Soneta.Core.GIODOOświadczenie>` | podlista |  |  |
| GIODOUdostępnienia | `SubTable<Soneta.Core.GIODOWymianaDanych>` | podlista |  |  |
| GIODOUprawnienia | `SubTable<Soneta.Core.GIODOUprawnienie>` | podlista |  |  |
| Grafiki | `SubTable<Soneta.Kalend.GrafikPracownika>` | podlista |  |  |
| HistZatrWgGlownego | `bool` | bazodanowe |  |  |
| Historia | `HistorySubTable<Soneta.Kadry.PracHistoria>` | podlista |  |  |
| HistoriaZatrudnienia | `SubTable` | podlista |  |  |
| Identyfikacje | `SubTable<Soneta.Kasa.IdentyfikacjaPlatnika>` | podlista |  |  |
| IdentyfikatorKartotekiCentralnej | `string` | bazodanowe |  |  |
| Imie | `string` | bazodanowe, tylko-odczyt |  |  |
| ImięNazwisko | `string` | tylko-odczyt | Imię i nazwisko |  |
| IndywidualnaDRA | `bool` | bazodanowe |  |  |
| InformacjeOArchiwum | `FromToSubTable<Soneta.Kadry.PracownikWArchiwum>` | podlista |  |  |
| InneDochody | `SubTable` | podlista |  |  |
| InneDochodyWgGlownego | `bool` | bazodanowe |  |  |
| JęzykiObce | `SubTable<Soneta.Kadry.ZnajomośćJęzykaObcego>` | podlista |  |  |
| Kalendarze | `SubTable<Soneta.Kalend.KalendarzBase>` | podlista |  |  |
| Kandydatury | `SubTable<Soneta.HR.Rekrutacja>` | podlista |  |  |
| KartyKompetencji | `SubTable<Soneta.HR2.KartaKompetencjiPracownika>` | podlista |  |  |
| KartyOpisuStanowiska | `SubTable<Soneta.HR2.KartaOpisuStanowiskaBase>` | podlista |  |  |
| KartyRCP | `SubTable<Soneta.Kadry.KartaRCP>` | podlista |  |  |
| KartyRealizacjiCelu | `SubTable<Soneta.HR2.KartaRealizacjiCelu>` | podlista |  |  |
| Kod | `string` | bazodanowe |  |  |
| KodZasobu | `string` | tylko-odczyt |  |  |
| Kontakt | `Soneta.Core.Kontakt` | tylko-odczyt |  |  |
| KontrolaAktywna | `bool` | tylko-odczyt |  |  |
| KosztyAutorskie | `SubTable<Soneta.Place.KosztAutorski>` | podlista |  |  |
| KwalifikacjeZkl | `SubTable<Soneta.HR.ZKL.ZKLPracownik.Kwalifikacje.KwalifikacjePracownikaZkl>` | podlista |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| Last | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Leady | `SubTable<Soneta.CRM.Lead>` | podlista |  |  |
| LimitNieograniczony | `bool` | tylko-odczyt |  |  |
| Limity | `SubTable<Soneta.Kalend.LimitNieobecnosci>` | podlista |  |  |
| Lokalizacje | `SubTable<Soneta.CRM.Lokalizacja>` | podlista |  |  |
| LokalizacjePracyZdalnej | `SubTable<Soneta.Kadry.LokalizacjaPracyZdalnej>` | podlista |  |  |
| MailTo | `string` | tylko-odczyt |  |  |
| MatrycePodmiotu | `SubTable` | podlista |  |  |
| NaDRAUmieszczajREGON | `bool` | bazodanowe |  |  |
| Nadrzedny | `Soneta.Core.IPodmiotInternal` | tylko-odczyt |  |  |
| NagrodyKary | `SubTable<Soneta.Kadry.NagrodaKara>` | podlista |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| NazwaFormatowana | `string` | tylko-odczyt |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| NazwaZasobu | `string` | tylko-odczyt |  |  |
| Nazwisko | `string` | bazodanowe, tylko-odczyt |  |  |
| NazwiskoImię | `string` | tylko-odczyt | Nazwisko i imię |  |
| Net | `Soneta.Kadry.PracownikNet` (subrow) | bazodanowe |  |  |
| Net.AutoZatwWniosku | `bool` | bazodanowe |  | Automatyczne zatwierdzanie wniosku urlopowego |
| Net.PodwladniNizszegoPoziomu | `bool` | bazodanowe |  | Określa czy wyświetlać w Net, dane podwładnych z niższych poziomów podległości. |
| Net.WidocznyWNet | `bool` | bazodanowe |  | Czy pracownik jest widoczny na listach programu Net |
| Nieobecnosci | `FromToSubTable<Soneta.Kalend.Nieobecnosc>` | podlista |  |  |
| NieobecnosciERP7 | `SubTable<Soneta.Kalend.NieobecnoscERP7>` | podlista |  |  |
| NumerRachunkuUS | `Soneta.Core.NumerRachunkuUS` (subrow) | bazodanowe |  |  |
| NumerRachunkuUS.CS | `string` |  |  |  |
| NumerRachunkuUS.Kierunek | `string` |  |  |  |
| NumerRachunkuUS.Kraj | `string` |  |  |  |
| NumerRachunkuUS.Numer | `string` |  |  |  |
| NumerRachunkuUS.Rachunek | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| NumerRachunkuUS.SWIFT | `string` |  |  |  |
| NumerRachunkuUS.WgRachunek | `Key` | podlista |  |  |
| NumerRachunkuZUS | `Soneta.Core.NumerRachunkuZUS` (subrow) | bazodanowe |  |  |
| NumerRachunkuZUS.CS | `string` |  |  |  |
| NumerRachunkuZUS.Kierunek | `string` |  |  |  |
| NumerRachunkuZUS.Kraj | `string` |  |  |  |
| NumerRachunkuZUS.Numer | `string` |  |  |  |
| NumerRachunkuZUS.Rachunek | `Soneta.Core.IRachunekBankowyPodmiotu` | bazodanowe |  |  |
| NumerRachunkuZUS.SWIFT | `string` |  |  |  |
| NumerRachunkuZUS.WgRachunek | `Key` | podlista |  |  |
| ObszaryOdpowiedzialnosci | `SubTable<Soneta.HR.ZKL.OpisStanowiska.Odpowiedzialnosci.ObszarOdpowiedzialnosciPracownikaZkl>` | podlista |  |  |
| Oceniający | `SubTable<Soneta.Oceny.OcenaOceniający>` | podlista |  |  |
| Oceniani | `SubTable<Soneta.Oceny.OcenaOceniany>` | podlista |  |  |
| Oceny | `SubTable<Soneta.HR.OcenaPracownika>` | podlista |  |  |
| OddzialZWydzialu | `Soneta.Core.OddzialFirmy` | tylko-odczyt |  |  |
| OfertyPracy | `SubTable<Soneta.HR2.OfertaPracy>` | podlista |  |  |
| OkresyWakacjiSkladki | `SubTable<Soneta.Kadry.OkresWakacjiSkladki>` | podlista |  |  |
| OpiekaPracownika | `DateSubTable<Soneta.Place.OświadczenieZusOpieka>` | podlista |  |  |
| Opis | `string` | bazodanowe |  |  |
| Osoby | `SubTable<Soneta.CRM.KontaktOsoba>` | podlista |  |  |
| OsobyKontaktowe | `SubTable<Soneta.CRM.Osoba_Kontrahent.OsobaKontrahent>` | podlista |  |  |
| OsobyZOsobyKontrahent | `View` | podlista |  |  |
| Oświadczenia | `SubTable<Soneta.Kadry.OświadczeniePracownika>` | podlista |  |  |
| PESEL | `string` | bazodanowe, tylko-odczyt |  |  |
| PlanowaneElementy | `SubTable<Soneta.Place.PlanowanyElementWypłaty>` | podlista |  |  |
| PlanowaneNieobecności | `FromToSubTable<Soneta.Kalend.PlanowanaNieobecność>` | podlista |  |  |
| PlanowaneWypłaty | `SubTable<Soneta.Place.PlanowanaWypłata>` | podlista |  |  |
| Platnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| PodmiotPowiazany | `bool` | tylko-odczyt |  |  |
| Podrzedni | `SubTable<Soneta.CRM.RelacjaPodmiotu>` | podlista |  |  |
| PodstawyNieobecności | `SubTable<Soneta.Place.PodstawaNieobecnosci>` | podlista |  |  |
| PodstawyNieobecnościOkresowe | `SubTable<Soneta.Place.PodstawaNieobecnosciOkresowa>` | podlista |  |  |
| Podzielniki | `SubTable<Soneta.Core.PodzielnikKosztow>` | podlista |  |  |
| Pojazdy | `SubTable` | podlista |  |  |
| PotwierdzeniaGIODO | `SubTable<Soneta.Core.GIODOZgodny>` | podlista |  |  |
| PowiazaniWłaściciele | `System.Collections.Generic.IEnumerable<Soneta.Kadry.Pracownik>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| PowiazanyKontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| PowiązaniaStrOrg | `SubTable<Soneta.Core.PowiązanieStrukturyOrganizacyjnej>` | podlista |  |  |
| PoświadczeniaOdbioru | `SubTable<Soneta.Core.PoświadczenieOdbioru>` | podlista |  |  |
| PracaWPolsce | `Periods` | tylko-odczyt |  |  |
| PracaZaGranicą | `Periods` | tylko-odczyt |  |  |
| Pracownicy | `SubTable<Soneta.Kadry.Pracownik>` | podlista |  |  |
| PracownicyKartotekaCentralnaIWieloetatowosc | `Soneta.Kadry.Pracownik[]` | podlista |  |  |
| PracownicyPowiązani | `Soneta.Kadry.Pracownik[]` | podlista |  |  |
| PracownikTymczasowy | `Soneta.Kadry.Pracownik.PracownikTymczasowyManager` | tylko-odczyt |  |  |
| Procent | `Percent` | bazodanowe |  |  |
| Projekty | `SubTable` | podlista |  |  |
| Przelewy | `SubTable<Soneta.Kasa.PrzelewBase>` | podlista |  |  |
| PrzeterminowanieNieograniczone | `bool` | tylko-odczyt |  |  |
| PrzychodyRyczalty | `SubTable<Soneta.Kadry.PrzychodRyczalt>` | podlista |  |  |
| PrzychodyZDzialnosci | `SubTable<Soneta.Kadry.PrzychodZDzialnosci>` | podlista |  |  |
| Rachunki | `SubTable<Soneta.Kasa.RachunekBankowyPodmiotu>` | podlista |  |  |
| RachunkiWirtualne | `SubTable<Soneta.Kasa.RachunekWirtualny>` | podlista |  |  |
| RegulyDostepnosci | `SubTable<Soneta.Kalend.RegulaDostepnosci>` | podlista |  |  |
| Rekrutacje | `SubTable<Soneta.HR.Rekrutacja>` | podlista |  |  |
| Rodzaj | `Soneta.Kadry.RodzajPracownika` (enum) | bazodanowe |  |  |
| RodzajePodmiotu | `SubTable<Soneta.Core.RodzajPodmiot>` | podlista |  |  |
| Rodzina | `SubTable<Soneta.Kadry.CzlonekRodziny>` | podlista |  |  |
| Rozliczenia | `System.Collections.Generic.IEnumerable<Soneta.Place.RozliczenieWynagrodzenia>` | podlista |  |  |
| RozliczeniaCzasuPracy | `SubTable<Soneta.Kalend.RozliczenieCzasuPracy>` | podlista |  |  |
| RozliczeniaWynagrodzenia | `LpSubTable<Soneta.Place.RozliczenieWynagrodzenia>` | podlista |  |  |
| Rozliczenie | `Soneta.Place.RozliczenieWynagrodzenia` | tylko-odczyt |  |  |
| Rozrachunki | `SubTable<Soneta.Kasa.RozrachunekIdx>` | podlista |  |  |
| Schorzenia | `SubTable<Soneta.Kadry.Schorzenie>` | podlista |  |  |
| SplacaneRaty | `SubTable<Soneta.Kadry.RataPozyczki>` | podlista |  |  |
| SposobZaplaty | `Soneta.Kasa.FormaPlatnosci` | bazodanowe |  |  |
| Sprawy | `SubTable` | podlista |  |  |
| SrodkiTrwaleHistoria | `SubTable` | podlista |  |  |
| StażPracyInfo | `Soneta.Kadry.Pracownik.StażPracyManager` | tylko-odczyt |  |  |
| StornaElementow | `SubTable<Soneta.Place.StornoElementu>` | podlista |  |  |
| StrukturaOraganizacyjna | `Soneta.Kadry.Pracownik.StrukturaOraganizacyjnaManager` | tylko-odczyt |  |  |
| Swiadczenia | `SubTable<Soneta.Kadry.SwiadczSocjalne>` | podlista |  |  |
| SzkoleniaBHP | `SubTable<Soneta.Kadry.SzkolenieBHP>` | podlista |  |  |
| Transakcje | `SubTable<Soneta.CRM.Transakcja>` | podlista |  |  |
| TransakcjeKontrahenta | `SubTable<Soneta.CRM.Osoba_Kontrahent.PodmiotTransakcja>` | podlista |  |  |
| Typ | `Soneta.Kadry.TypPracownika` (enum) | bazodanowe, tylko-odczyt |  |  |
| TypZasobu | `string` | tylko-odczyt |  |  |
| UkończoneSzkolenia | `SubTable<Soneta.HR.UkończoneSzkolenie>` | podlista |  |  |
| UlgaWgGlownego | `bool` | bazodanowe |  |  |
| UlgiInnowacyjne | `SubTable<Soneta.Kadry.UlgaInnowacyjna>` | podlista |  |  |
| Umowy | `SubTable<Soneta.Kadry.Umowa>` | podlista |  |  |
| UmowyZewnetrzne | `SubTable<Soneta.Kadry.UmowaZewnetrzna>` | podlista |  |  |
| Uprawnienia | `SubTable<Soneta.HR.UprawnieniePracownika>` | podlista |  |  |
| Urzadzenia | `SubTable` | podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |
| Wakaty | `SubTable<Soneta.HR2.RekrutacjaWakat>` | podlista |  |  |
| WeWyI | `SubTable<Soneta.Kalend.WejscieWyjscieI>` | podlista |  |  |
| WeWyO | `SubTable<Soneta.Kalend.WejscieWyjscieO>` | podlista |  |  |
| WebUserDescription | `string` | tylko-odczyt |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Wieloetatowosc | `Soneta.Kadry.TypyWieloetatowosci` (enum) | bazodanowe, tylko-odczyt |  |  |
| WieloetatowoscImportujNBPUE | `bool` | bazodanowe |  |  |
| Wlasciciel | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| WnioskiKierownika | `SubTable<Soneta.Kadry.WniosekUrlopowy>` | podlista |  |  |
| WnioskiOSzkolenia | `SubTable<Soneta.HR.WniosekOSzkolenie>` | podlista |  |  |
| WnioskiOZwrotNienalOpłSkł | `SubTable<Soneta.Kadry.WniosekZwrotOplSkl>` | podlista |  |  |
| WnioskiPracyZdalnej | `SubTable<Soneta.Kalend.WniosekPracyZdalnej>` | podlista |  |  |
| WnioskiPracyZdalnejKierownika | `SubTable<Soneta.Kalend.WniosekPracyZdalnej>` | podlista |  |  |
| WnioskiUrlopowe | `SubTable<Soneta.Kadry.WniosekUrlopowy>` | podlista |  |  |
| WnioskiZastępcy | `SubTable<Soneta.Kadry.WniosekUrlopowy>` | podlista |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| WykonujacyPracownika | `SubTable<Soneta.Kadry.RelacjaWykonPrac>` | podlista |  |  |
| WynagrodzeniaERP7 | `SubTable<Soneta.Kalend.WynagrodzenieERP7>` | podlista |  |  |
| Wypadki | `SubTable<Soneta.Kadry.Wypadek>` | podlista |  |  |
| Wyplaty | `SubTable<Soneta.Place.Wyplata>` | podlista |  |  |
| Zadania | `SubTable` | podlista |  |  |
| ZadaniaKontrahenta | `SubTable` | podlista |  |  |
| ZajeciaWynagrWgGlownego | `bool` | bazodanowe |  |  |
| ZajęciaKomornicze | `SubTable<Soneta.Kadry.ZajęcieKomornicze>` | podlista |  |  |
| Zaliczki | `SubTable<Soneta.Place.Zaliczka>` | podlista |  |  |
| ZaniechaniaPodatkowe | `DateSubTable<Soneta.Place.ZaniechaniePodatkowe>` | podlista |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.Zaplata>` | podlista |  |  |
| ZasInnyPłatnik | `SubTable<Soneta.Place.ZasiłekInnyPłatnik>` | podlista |  |  |
| ZasobyCRM | `SubTable` | podlista |  |  |
| ZasobyRN | `SubTable<Soneta.Kalend.ZasobRN>` | podlista |  |  |
| ZbiegUbespWgGlownego | `bool` | bazodanowe |  |  |
| ZbiegiPracyIRodzicielstwa | `FromToSubTable<Soneta.Kalend.ZbiegPracyIRodzicielstwa>` | podlista |  |  |
| ZbiegiUbezpieczen | `SubTable` | podlista |  |  |
| Zdarzenia | `SubTable<Soneta.CRM.DokumentZdarzenia>` | podlista |  |  |
| ZestDietPakietMobil | `SubTable<Soneta.Kalend.ZestDietPakietMobil>` | podlista |  |  |
| Zestawienia | `FromToSubTable<Soneta.Kalend.ZestawieniePracy>` | podlista |  |  |
| ZestawieniaDiet | `FromToSubTable<Soneta.Kalend.ZestawienieDietZagr>` | podlista |  |  |
| ZgloszSygnalisty | `SubTable<Soneta.Kadry.ZgloszenieSygnalisty>` | podlista |  |  |
| ZgodnoscGIODOPotwierdzona | `bool` |  |  |  |
| ZyrowaneRaty | `SubTable<Soneta.Kadry.RataPozyczki>` | podlista |  |  |
| ŻyrowanePożyczki | `SubTable<Soneta.Kadry.ŻyrantPożyczki>` | podlista |  |  |

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
