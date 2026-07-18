# Pola i właściwości klasy biznesowej: `Soneta.Handel.DefDokHandlowego`
Nazwa tabeli: `DefDokHandlowych`
Tytuł: Definicje dokumentów handlowych
Opis: Konfigurowalna definicja (szablon) dokumentu handlowego. Określa jego symbol, nazwę, kategorię, ustawienia wydruku, drukowania, VAT, numeracji i inne parametry wpływające na zachowanie dokumentów.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`, `IDefinicjaKomunikatuEDIHost`, `IWarningHost`, `IDefinicjaDokumentuOA`

- pola bazodanowe (zapisywalne): 236
- pola kalkulowane (zapisywalne): 22
- pola tylko-odczyt: 36
- podlisty: 19
- subrowy: 15
- razem: 328

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktualizujCeny | `Soneta.Handel.SposobAktualizacjiCen` (enum) | bazodanowe |  | Określa sposób aktualizowania cennika podczas zatwierdzania dokumentu. |
| Anulowany | `bool` | bazodanowe |  | Określa czy dokument może być anulowany. |
| Bazowa | `System.Guid` | bazodanowe |  |  |
| BazowaDefinicja | `Soneta.Handel.DefDokHandlowego` | tylko-odczyt | Definicja bazowa | Bazowa definicja dokumentu, na podstawie której powstała aktualna definicja. |
| Blokada | `bool` | bazodanowe |  | Zablokowane definicje dokumentów nie będą wyświetlane w liście wyboru. |
| BlokadaCeny | `bool` | bazodanowe |  | Blokuje możliwość edycji ceny na pozycji dokumentu. |
| BlokadaEdycjiDaty | `bool` | bazodanowe |  | Uniemożliwia edycję daty głównej (pole data na zakładce ogólne) |
| BlokadaEdycjiDatyOperacji | `bool` | bazodanowe |  | Uniemożliwia edycję daty operacji przez operatora |
| BlokadaEdycjiDatyOtrzymania | `bool` | bazodanowe |  | Uniemożliwia edycję daty otrzymania. |
| BlokadaEdycjiMagazynu | `bool` | bazodanowe |  | Uniemożliwia edycję magazynu z poziomu dokumentu (pole Magazyn na zakładce ogólne) |
| BlokadaZasobuMagazynowego | `bool` | bazodanowe | Blokada zasobu magazynowego | Blokada zasobu magazynowego. |
| Buforowanie | `Soneta.Handel.SposobBuforowania` (enum) | bazodanowe | Buforowanie | Określa sposób działania stanu dokumentu w buforze. |
| CechaNazwaTowaru | `FeatureDefinition` | bazodanowe | Cecha wyliczająca nazwę towaru na wydruku | Określa cechę pozycji dokumentu (typu tekst), która wyznaczy nazwę towaru na wydruku. |
| CechaPodzialuKosztuDodatkowego | `FeatureDefinition` | bazodanowe | Współczynnik podziału kosztu dodatkowego na pozycje | Określa cechę do pozycji dokumentu (algorytmiczną, typu wartość), liczącą współczynnik podziału kosztu. |
| CechaProcedura | `string` |  | Cecha wyliczająca nazwę procedury na fakturze | Określa cechę do dokumentu handlowego (typu tekst), która wyznaczy nazwę procedury. |
| CechyPozycjiWymagane | `MemoText` | bazodanowe, podlista |  | Lista cech wymaganych na pozycjach dokumentów. |
| CechyWymagane | `MemoText` | bazodanowe, podlista |  | Lista cech wymaganych na dokumentach. |
| Cena | `Soneta.Towary.DefinicjaCeny` | bazodanowe |  | Określa rodzaj ceny stosowanej w pozycjach dokumentu. |
| Cena2 | `Soneta.Towary.DefinicjaCeny` |  |  | Do użytku wewnętrznego. |
| CenaKosztuUslugi | `Soneta.Towary.DefinicjaCeny` | bazodanowe |  | Określa rodzaj ceny dla kosztu usługi składnika kompletacji. |
| CenaPoRabacieLiczonaOdWartosci | `bool` | bazodanowe |  | Włącza przeliczanie ceny po rabacie po zmianie wartości pozycji. |
| CenaWartosc0 | `bool` | bazodanowe | Zerowa wartość pozycji | Określa, czy pozycje dokumentu mają zerową cenę i wartość. |
| CyklFakturowaniaSposobNaDniWolne | `Soneta.Core.DefinicjaCykluSposobNaDniWolne` (enum) | bazodanowe |  | Określa domyślny sposób obsługi, gdy dzień faktuorowania wypada na dzień wolny. |
| CyklFakturowaniaUmowy | `Soneta.Core.DefinicjaCykluTyp` (enum) | bazodanowe | Cykl fakturowania | Określa domyślny cykl fakturowania umowy. |
| DaneKontaktoweKontrahenta | `bool` | bazodanowe |  | Określa czy istnieje możliwość wprowadzania danych kontaktowych kontrahenta. |
| DaneKontaktoweOdbiorcy | `bool` | bazodanowe |  | Określa czy istnieje możliwość wprowadzania danych kontaktowych odbiorcy. |
| DataKursu | `Soneta.Handel.DefDataKursu` (enum) | bazodanowe |  | Określa datę kursu waluty użytego na dokumencie. |
| DataOkresIntrastat | `Soneta.Handel.DataOkresIntrastat` (enum) | bazodanowe |  | Data wejścia do deklaracji Intrastat |
| DataZobowiazanNaleznosci | `Soneta.Handel.DataZobowiazanNaleznosci` (enum) | bazodanowe | Data zobowiązań/należności |  |
| DefNaglowek1Xml | `MemoText` | bazodanowe, podlista |  | Parametr przechowujący definicję pierwszego definiowalnego nagłówka |
| DefNaglowek2Xml | `MemoText` | bazodanowe, podlista |  | Parametr przechowujący definicję drugiego definiowalnego nagłówka |
| DefNaglowekPXml | `MemoText` | bazodanowe, podlista |  | Parametr przechowujący definicję definiowalnego nagłówka dla pozycji |
| DefPodsumowanieXml | `MemoText` | bazodanowe, podlista |  | Parametr przechowujący definicję definiowalnego podsumowania |
| DefinicjaEwidencji | `Soneta.Core.DefinicjaDokumentu` | bazodanowe |  | Określa ewidencję księgoweą, do której trafi dokument (sposób księgowania). |
| DefinicjaEwidencjiCecha | `string` | bazodanowe | Cecha wyliczająca definicję ewidencji | Określa cechę dokumentu (algorytmiczną i referencyjną do tabeli DefDokumentow), która dostarczy definicję ewidencji. |
| DefinicjaEwidencjiFeatureDefinition | `FeatureDefinition` |  |  | Wskazuje cechę dokumentu (algorytmiczną i referencyjną do tabeli DefDokumentow), która dostarczy definicję ewidencji. |
| DefinicjaEwidencjiZrodlo | `Soneta.Handel.ZrodloEwidencji` (enum) | bazodanowe | Źródło definicji ewidencji | Określa źródło pozyskania definicji ewidencji. |
| DefinicjaKorekty | `bool` | tylko-odczyt |  |  |
| DodajTransportNaZatwierdzeniu | `bool` | bazodanowe | Transport | Podczas zatwierdzania utwórz obiekt przesyłki kurierskiej |
| Dodawanie | `Soneta.Handel.SposobDodawaniaHandlowego` (enum) | bazodanowe |  | Określa tryb dodawania dokumentu. |
| DodawanieTylkoUslug | `bool` | tylko-odczyt |  | Wskazuje na to, czy do dokumentu "z ręki" mogą być dodane tylko usługi. |
| DokumentKoncowyInfo | `Soneta.Handel.DokumentKoncowyInfo` (subrow) | bazodanowe |  |  |
| DokumentKoncowyInfo.DokumentKoncowy | `bool` | bazodanowe | Dokument końcowy | Określa, czy dokument ma być traktowany jako końcowy dokument w relacjach do innych dokumentów nadrzędnych. |
| DostawcaOdbiorca | `string` | tylko-odczyt |  | Opis kontrahenta operującego partiami towaru magazynowego: Dostawca/Odbiorca/Kontrahent. |
| DozwolonyIncydentalny | `bool` | bazodanowe | Dozwolony kontrahent incydentalny | Określa, czy kontrahent incydentalny jest dozwolony. |
| DrugiKontrahent | `Soneta.Handel.DostawcaOdbiorca` (enum) | bazodanowe | Drugi kontrahent |  |
| DrugiSymbol | `string` | bazodanowe |  | Drugi symbol dokumentu, wykorzystywany do alternatywnej numeracji dokumentów handlowych. |
| DrukowanieCenyIRabatu | `bool` | bazodanowe |  | Określa, czy będzie drukowana cena przed rabatem i rabat procentowy. |
| DrukowanieNumerowNadrzednych | `bool` | bazodanowe |  | Określa, czy będą drukowane numery dokumentów nadrzędnych. |
| DrukowanieNumerowNadrzednychTylkoNajblizsze | `bool` | bazodanowe |  | Drukowane będą tylko numery dokumentów bezpośrednio w relacji |
| DrukowanieNumerowPodrzednych | `bool` | bazodanowe |  | Określa, czy będą drukowane numery dokumentów nadrzędnych. |
| DrukowanieNumerowPodrzednychTylkoNajblizsze | `bool` | bazodanowe |  | Drukowane będą tylko numery dokumentów bezpośrednio w relacji |
| DrukowanieZawszeOryginal | `bool` | bazodanowe |  | Okno parametrów wydruku domyślnie będzie podpowiadać Oryginał. |
| DrukowanieZestawieniaMagazynowych | `bool` | bazodanowe |  | Określa, czy drukowane będą informacje o powiązanych dokumentach magazynowych. |
| DrukujAdresDostawyJesliRozny | `bool` | bazodanowe | Drukuj miejsce dostawy, gdy jest ten sam kontrahent i odbiorca, ale z różnymi danymi adresowymi |  |
| DrukujDateDostawy | `bool` | bazodanowe |  | Określa, czy będzie drukowana data dostawy. |
| DrukujDateOperacji | `bool` | bazodanowe |  | Określa, czy będzie drukowana data operacji. |
| DrukujDateOtrzymania | `bool` | bazodanowe |  | Określa, czy będzie drukowana data otrzymania. |
| DrukujDokKSeFBezNr | `Soneta.Handel.ZezwalajNaDrukowanieDokBezNrKSef` (enum) | bazodanowe |  | Drukowanie faktur przeznaczonych do KSeF bez numeru KSeF. |
| DrukujDrugiRachunek | `bool` | bazodanowe |  | Określa czy będzie drukowany drugi numer rachunku. |
| DrukujKgo | `bool` | bazodanowe | Drukuj KGO |  |
| DrukujNipZgodnyZKrajemVat | `bool` | bazodanowe |  | Drukuj NIP sprzedawcy zgodny z krajem zastosowanej stawki VAT |
| DrukujNumerEX | `bool` | bazodanowe | Drukuj numer EX |  |
| DrukujNumerKSeF | `bool` | bazodanowe |  | Drukuj numer oraz kod QR KSeF. |
| DrukujNumeryPoprzednichKorekt | `bool` | bazodanowe |  | Określa, czy będą drukowane numery poprzednich korekt. |
| DrukujOrygKopia | `bool` | bazodanowe | Drukuj napis oryginał/kopia | Drukowanie napisu oryginał/kopia na dokumentach wystawionych po roku 2012. |
| DrukujPlatnosci | `bool` | bazodanowe |  | Określa, czy będzie drukowana lista nierozliczonych płatności. |
| DrukujSWIFTZawsze | `bool` | bazodanowe |  | Określa czy będzie drukowany numer SWIFT zawsze, gdy kontrahent nie jest krajowy |
| DrukujTabVATWWaluciePLN | `bool` | bazodanowe | Drukuj dodatkową tabelę VAT w walucie PLN | Widoczna gdy dokument posiada podstawową tabele VAT w walucie obcej oraz gdy kwota VAT jest równa 0,00. |
| DrukujTabeleZOpakowaniami | `Soneta.Handel.OpcjeDrukowaniaTabelOpakowan` (enum) | bazodanowe | Drukuj tabele z opakowaniami/kaucjami. |  |
| DrukujTabeleZRodzajamiOpakowan | `Soneta.Handel.OpcjeDrukowaniaTabelOpakowan` (enum) | bazodanowe | Drukuj tabelę z rodzajem opakowań w systemie kaucyjnym. |  |
| DrukujTylkoRoznicePoKorekcie | `bool` | bazodanowe |  | Określa, czy na korekcie będą drukowane tylko pozycje korygowane (zmienione) |
| DrukujTylkoRoznicePrzedKorekta | `bool` | bazodanowe |  | Określa, czy na korekcie będa drukowane tylko pozycje korygowane (zmienione) |
| DuplikatWartosci | `bool` | bazodanowe | Duplikat wartości | Określa, czy dokument duplikuje wartość innego dokumentu i nie powinien być uwzgledniany w sumowaniu. |
| EdycjaDatyDostawy | `Soneta.Handel.EdycjaDatyDostawy` (enum) | bazodanowe | Edycja daty dostawy | Określa tryb edycji daty dostawy |
| EdycjaDatyDostawyPozycji | `Soneta.Handel.EdycjaDatyDostawy` (enum) | bazodanowe | Edycja daty dostawy pozycji | Włącza edycję daty dostawy na pozycji dokumentu. |
| EdycjaIlosciZrealizowanej | `Soneta.Handel.EdycjaIlosciZrealizowanej` (enum) | bazodanowe | Edycja ilości zrealizowanej | Włącza edycję ilości zrealizowanej w pozycji zatwierdzonego dokumentu. |
| EdycjaKosztuDodatkowego | `bool` | bazodanowe | Edycja kosztu dodatkowego | Włącza dodawanie/edycję kosztu dodatkowego. |
| EdycjaStanuRealizacji | `Soneta.Handel.EdycjaStanuRealizacji` (enum) | bazodanowe | Edycja stanu realizacji | Włącza edycję stanu realizacji w zatwierdzonym dokumencie. |
| EdycjaStawkiVAT | `bool` | bazodanowe |  | Określa, czy w pozycjach dokumentu jest możliwa zmiana stawki VAT. |
| EdycjaTerminuPlatnosci | `Soneta.Handel.EdycjaTerminuPlatnosci` (enum) | bazodanowe | Edycja terminu płatności | Edycja terminu płatności. |
| EdycjaWTrybieKoszyka | `Soneta.Handel.EdycjaWTrybieKoszyka` (enum) | bazodanowe |  | Określa, czy dokument może być wystawiany jako koszyk. |
| EdycjaWartosci | `Soneta.Handel.EdycjaWartosciDokumentu` (enum) | bazodanowe |  | Określa sposób edycji wartości dokumentu (np w celu zmiany waluty). |
| EwidencjaZKorekty | `bool` | bazodanowe | Ewidencja z korygowanego | Określa użycie definicji ewidencji księgowej takiej, jak na dokumencie korygowanym. |
| FiltrKontrahenta | `string` | bazodanowe | Filtr kontrahentów | Filtr listy kontrahentów, wprowadzanych do dokumentu. |
| FiltrKontrahentaCondition | `RowCondition` | tylko-odczyt |  |  |
| FiltrKontrahentaStosowanie | `Soneta.Handel.FiltrKontrahentaStosowanie` (enum) | bazodanowe | Pozwalaj na wykluczonego kontrahenta | Określa sposób stosowania filtra kontrahentów podczas wprowadzania kontrahenta na dokument. |
| FiltrStanuTowaru | `Soneta.Towary.FiltrStanuTowaru` (enum) | bazodanowe |  | Określa filtrowanie towaru wg stanu w magazynie. |
| FiltrTowaru | `string` | bazodanowe |  | Filtr listy towarów, wyświetlanej podczas dodawania pozycji na dokument. |
| FiltrTowaruCondition | `RowCondition` | tylko-odczyt |  |  |
| FiltrZasobow | `string` | bazodanowe |  | Filtr zawężający listę zasobów do pobrania. |
| Fiskalizowany | `bool` | bazodanowe |  | Określa, czy dokument jest fiskalizowany czyli drukowany jest na drukarce fiskalnej. |
| Flags | `Soneta.Handel.Helpers.Flags` (enum) | bazodanowe |  | Flagi dodatkowe. |
| FormNET | `bool` | bazodanowe | Określa czy istnieje zakładka użytkownika w Pulpicie kontrahenta. |  |
| GrupyTowaroweVat | `bool` | bazodanowe |  |  |
| IloscKopii | `int` | bazodanowe |  | Określa drukowaną ilość kopii dokumentu. |
| IloscPozycji | `Soneta.Handel.IloscPozycjiDokumentuHandlowego` (enum) | bazodanowe | Ilość pozycji | Określa dozwoloną ilość pozycji na zatwierdzonym dokumencie. |
| IloscTowaruKopiowana | `Soneta.Handel.IloscTowaruKopiowana` (enum) | bazodanowe |  | Ilość towaru kopiowana do dokumentu podrzędnego. |
| InformacjeKRS | `bool` | bazodanowe |  | Określa, czy będą drukowane informacje z KRS. |
| InicjalizacjaDatyDostawy | `Soneta.Handel.InicjalizacjaDatyDostawy` (enum) | bazodanowe | Inicjowanie daty dostawy | Określa sposób inicjowania daty dostawy |
| InicjalizacjaDatyDostawyCecha | `string` | bazodanowe | Cecha daty dostawy | Określa cechę dokumentu (algorytmiczną typu Data), która wyliczy datę dostawy. |
| InicjalizacjaDatyDostawyFeatureDefinition | `FeatureDefinition` |  |  | Wskazuje cechę dokumentu (typu Data), która dostarczy datę dostawy. |
| InicjalizatorWalutyInfo | `Soneta.Handel.InicjalizatorWalutyInfo` (subrow) | bazodanowe | Reguły doboru walut. | Ustawienia sposobu doboru walut dla: pozycji, wartości dokumentu lub płatności. |
| InicjalizatorWalutyInfo.KursWaluty | `Soneta.Handel.ZrodloKursuWaluty` (enum) | bazodanowe |  | Określa źródło pozyskania kursu waluty. |
| InicjalizatorWalutyInfo.WalutaPlatnosci | `Soneta.Handel.ZrodloWaluty` (enum) | bazodanowe |  | Określa źródło pozyskania waluty dla podsumowania/płatności dokumentu podrzędnego. |
| InicjalizatorWalutyInfo.WalutaPozycji | `Soneta.Handel.ZrodloWaluty` (enum) | bazodanowe |  | Określa na źródło pozyskania waluty dla wartości pozycji dokumentu podrzędnego. |
| Intrastat | `Soneta.Handel.RodzajIntrastat` (enum) | bazodanowe |  | Sposób uwzględniania dokumentu w deklaracji Intrastat. |
| InwentaryzacjaInfo | `Soneta.Handel.InwentaryzacjaInfo` (subrow) | bazodanowe | Reguły dotyczące inwentaryzacji. | Ustawienie sposobu obsługi inwentaryzacji. |
| InwentaryzacjaInfo.BlokowanieTowarow | `bool` | bazodanowe | Blokada inwentaryzowanych towarów | Wskazuje na to, czy użycie inwentaryzowanych towarów na dokumentach magazynowych będzie blokowane? |
| IsParagon | `bool` | tylko-odczyt |  | Wskazuje, czy dana definicja jest paragonem. |
| JednostkaAlternatywna | `bool` | bazodanowe |  | Ilość pozycji wyrażona w alternatywnej jednostce towaru. |
| JestDefinicjaEwidencji | `bool` | tylko-odczyt |  | Informuje, czy jest określona definicja ewidencji księgowej dla tej definicji dokumentu handlowego. |
| JestFiltrKontrahenta | `bool` | tylko-odczyt |  |  |
| JestFiltrTowaru | `bool` | tylko-odczyt |  |  |
| JestFiltrZasobow | `bool` | tylko-odczyt |  |  |
| JestIndywidulanaNazwa | `bool` | tylko-odczyt |  |  |
| JestKWPZ | `bool` | bazodanowe | JestKWPZ |  |
| KasaZbiorcza | `bool` | bazodanowe | Zbiorcze księgowanie zapłat | Określa, że księgowanie płatności będzie odbywać się zbiorczo. |
| Kasowany | `bool` | bazodanowe |  | Określa czy dokument może być kasowany przez operatora programu. |
| Kategoria | `Soneta.Handel.KategoriaHandlowa` (enum) | bazodanowe |  | Kategoria dokumentów grupująca dokumenty na liście. |
| KierunekMagazynu | `Soneta.Magazyny.KierunekPartii` (enum) | bazodanowe | Kierunek magazynu | Określa kierunek operacji magazynowych. |
| KierunekPlatnosci | `Soneta.Core.KierunekPlatnosci` (enum) | bazodanowe |  | Określa sposób generowania płatności do dokumentu i czy w ogólóle płatnosć ma się generować. |
| KierunekZaliczki | `Soneta.Core.KierunekPlatnosci` (enum) | bazodanowe |  | Określa sposób dołączania zaliczki (wpłaty) do dokumentu i czy w ogóle można dołączać zaliczkę. |
| Klawisz | `string` | bazodanowe |  | Klawisz do szybkiego dodawania dokumentu. |
| KodKreskowyZNumeremDok | `Soneta.Handel.KodKreskowyZNumeremDok` (enum) | bazodanowe |  | Drukowanie kodu kreskowego pod numerem dokumentu |
| KonfiguracjaOpisuAnalitycznego | `Soneta.Core.KonfiguracjaOpisuAnalitycznego` | tylko-odczyt |  |  |
| KontrahentWymagany | `Soneta.Handel.WymaganieKontrahenta` (enum) | bazodanowe | Kontrahent | Określa sposób wprowadzania kontrahenta do dokumentu handlowego. |
| KontrolaLimituKredytowego | `bool` | bazodanowe | Kontrola limitu kredytowego | Określa, czy podczas wystawiania dokumentu stosowana będzie kontrola limitu kredytowego. |
| KontrolerRelacjiInfo | `Soneta.Handel.KontrolerRelacjiInfo` (subrow) | bazodanowe |  | Kontroler relacji. |
| KontrolerRelacjiInfo.Disabled | `bool` | bazodanowe |  | Określa, czy kontroler relacji jest włączony. |
| KontrolerRelacjiInfo.PrzeliczajPozycjeRelacji | `bool` | bazodanowe |  | Określa, czy kontroler relacji powinien przeliczać pozycje relacji handlwych. |
| KopiujCechyDostawy | `bool` | bazodanowe | Kopiuj cechy z dostawy. | Określa, czy cechy z dostawy zostaną przeniesione na pozycję dokumentu rozchodowego. |
| KrajPrzeznaczeniaEtykieta | `string` | tylko-odczyt |  | Określa etykietę pola 'Kraj przeznaczenia'. |
| KreatorDokumentu | `Soneta.Handel.KreatorDokumentu` (subrow) | bazodanowe |  | Ustawienia kreatora dokumentu handlowego. |
| KreatorDokumentu.DomyslnaPodlistaTowaru | `Soneta.Handel.SzybkaTransakcjaTowarPodlista` (enum) | bazodanowe |  | Określa, która z dodatkowych podlist przy wyborze towaru będzie domyślna. |
| KreatorDokumentu.JestWlaczony | `bool` | bazodanowe |  | Określa, czy używać mechanizmu szybkiego wprowadzania pozycji dokumentu. |
| KreatorDokumentu.Towary | `Soneta.Handel.KreatorDokumentuStrona` (subrow) | bazodanowe |  | Ustawienia indywidualne listy towarów. |
| KreatorDokumentu.Towary.Podsumowanie | `Soneta.Handel.KreatorDokumentuStronaIndywidualna` (subrow) | bazodanowe |  | Ustawienia podsumowania indywidualnego. |
| KreatorDokumentu.Towary.Podsumowanie.Visible | `bool` | bazodanowe |  | Określa, czy na formularzu będzie widoczne sekcja indywidualna użytkownika. |
| KreatorDokumentu.Towary.Podsumowanie.Xml | `MemoText` | podlista |  |  |
| KreatorDokumentuTowaryPodsumowanieXml | `MemoText` | bazodanowe, podlista |  | Definicja indywidualnego podsumowania listy towarów. |
| KursWgDaty | `Soneta.Handel.KursWgDaty` (enum) | bazodanowe |  | Określa, według której daty ma być pobierany kurs. |
| LiczonaOd | `Soneta.Handel.SposobLiczeniaVAT` (enum) | bazodanowe |  | Określa sposób liczenia wartości dokumentu i rodzaj stosowanych cen: od brutto lub od netto. |
| LimitWartosciInfo | `Soneta.Handel.LimitWartosciInfo` (subrow) | bazodanowe |  |  |
| LimitWartosciInfo.ReakcjaZatwierdzanie | `Soneta.Handel.LimitWartosciReakcjaZatwierdzanie` (enum) | bazodanowe | Zatwierdzanie | Określa, czy zatwierdzanie jest dozwolone wtedy, kiedy limit wartości został przekroczony. |
| LimityWartosci | `SubTable<Soneta.Handel.LimitWartosci>` | podlista |  |  |
| LinieParagonu | `Soneta.Handel.LinieParagonu` (enum) | bazodanowe | Sposób wydruku paragonu fiskalnego | Określa sposób tworzenia linii paragonu fiskalnego, mogą to być pozycje dokumentu, albo jego tabela VAT |
| LogoWydruk | `Soneta.Core.Enums.LogoWydruk` (enum) | bazodanowe |  | Logo w nagłówku dokumentu. |
| LogoWydrukNazwa | `string` | bazodanowe |  | Nazwa logo w nagłówku dokumentu. |
| MagazynInfo | `string` | tylko-odczyt |  |  |
| MomentMagazynu | `Soneta.Magazyny.MomentMagazynu` (enum) | bazodanowe |  | Określa moment, w którym będzie wykonana operacja magazynowa. |
| MozliwosciEdycjiPozycji | `Soneta.Handel.MozliwosciEdycji` (subrow) | bazodanowe |  |  |
| MozliwosciEdycjiPozycji.Dodawanie | `Soneta.Handel.MozliwosciEdycji.OpcjeDodawania` (enum) | bazodanowe |  |  |
| MozliwosciEdycjiPozycji.Edycja | `Soneta.Handel.MozliwosciEdycji.OpcjeEdycji` (enum) | bazodanowe |  |  |
| MozliwosciEdycjiPozycji.EdycjaPozycjiGratisowych | `Soneta.Handel.MozliwosciEdycji.OpcjeEdycji` (enum) | bazodanowe |  |  |
| MozliwosciEdycjiPozycji.Kasowanie | `bool` | bazodanowe |  |  |
| NadrzedneDefinicje | `SubTable<Soneta.Handel.RelacjeDokumentow.DefDokPodrzednego>` | podlista |  |  |
| NadrzędneDefinicjeInfo | `string` | tylko-odczyt |  |  |
| Naglowek | `string` | bazodanowe |  | Określa widok pierwszego nagłówka dokumentu. |
| Naglowek2 | `string` | bazodanowe |  | Określa widok drugiego nagłówka dokumentu. |
| NaglowekP | `string` | bazodanowe |  | Określa widok nagłówka pozycji dokumentu. |
| Nazwa | `string` | bazodanowe |  | Pełna nazwa definicji dokumentu, wykorzystywana do wyszukiwania deifnicji. |
| NazwaDaty | `string` | bazodanowe |  | Określa nazwę pola 'Data' wyświetlanego na formularzu dokumentu. |
| NazwaDatyDostawy | `string` | bazodanowe |  | Określa nazwę pola 'Dostawa.Termin' wyświetlanego na formularzu dokumentu. |
| NazwaDatyDostawyEtykietaShort | `string` | tylko-odczyt |  |  |
| NazwaDatyEtykieta | `string` | tylko-odczyt |  |  |
| NazwaDatyEtykietaShort | `string` | tylko-odczyt |  |  |
| NazwaDatyOperacji | `string` | bazodanowe |  | Określa nazwę pola 'DataOperacji' wyświetlanego na formularzu dokumentu. |
| NazwaDatyOperacjiEtykieta | `string` | tylko-odczyt |  |  |
| NazwaDatyOperacjiEtykietaShort | `string` | tylko-odczyt |  |  |
| NazwaStanuRealizacji | `string` | tylko-odczyt |  |  |
| NazwaTowaru | `Soneta.Handel.NazwaTowaruNaPozycji` (enum) | bazodanowe |  | Określa sposób tworzenia nazwy towaru w pozycjach dokumentu. |
| NieWplywaNaOstatniaCeneZakupu | `bool` | bazodanowe | Nie wpływa na ostatnią cenę zakupu | Określa, czy dokument ma wpływ na ostatnią cenę zakupu. |
| NieWymagajCech | `bool` | bazodanowe |  | Wyłącza wymagalność cech dokumentu i pozycji. |
| NiezgodnoscWartosci | `bool` | bazodanowe |  | Umożliwia pojawienie się pewnych niezgodności w wyliczeniu wartości pozycji, ponieważ po zmianie wartości i przeliczeniu innego elementu pozycji wartość nie będzie ponownie naliczana. |
| NumerEwidencji | `Soneta.Handel.NumerEwidencji` (enum) | bazodanowe |  | Określa sposób nadawania numeru dokumentu ewidencji. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  | Ustawienia określające sposób numeracji dokumentów. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| ObslugaAukcji | `bool` | bazodanowe | Obsługa aukcji | Określa, czy dokument obsługuje aukcję |
| ObslugaCRU | `bool` | bazodanowe | Obsługa CRU dla definicji dokumentu handlowego |  |
| ObslugaSLA | `bool` | bazodanowe | Obsługa parametrów SLA | Obsługa parametrów SLA ServiceDesk |
| OgraniczDoStanu | `bool` | tylko-odczyt |  |  |
| OkrDostawcaOdbiorca | `Soneta.Handel.OkreslenieKontrahenta` (enum) | bazodanowe |  | Określenie drugiego kontrahenta. |
| OkreslenieDatyWplaty | `Soneta.Handel.OkreslenieDatyZaplaty` (enum) | bazodanowe |  | Określa sposób ustalania daty zapłaty (wpłaty) tworzonej podczas zatwierdzania dokumentu. |
| OkreslenieDatyWyplaty | `Soneta.Handel.OkreslenieDatyZaplaty` (enum) | bazodanowe |  | Określa sposób ustalania daty zapłaty (wypłaty) tworzonej podczas zatwierdzania dokumentu. |
| OpakJakoPozycje | `bool` | bazodanowe | Obsługa opakowań za pomocą pozycji | Obsługa opakowań za pomocą pozycji. |
| OpisEwidencji | `Soneta.Handel.TworzenieOpisuEwidencji` (enum) | bazodanowe | Tworzenie opisu ewidencji | Określa sposób tworzenia opisu ewidencji. |
| OpisEwidencjiCecha | `FeatureDefinition` | bazodanowe | Cecha do dokumentu tworząca opis ewidencji. | Określa cechę dokumentu (algorytmiczną typu tekst), która utworzy opis w dokumencie ewidencji. |
| OpisWydruku | `MemoText` | bazodanowe, podlista |  | Opis umieszczany na wydruku dokumentu. |
| OpisWydrukuCecha | `string` |  | Cecha tworząca opis wydruku | Określa cechę do dokumentu handlowego (typu tekst), która utworzy opis na wydruku. |
| OstrzezenieDlaEdycji | `Soneta.Handel.OstrzezenieDlaEdycji` (subrow) | bazodanowe |  |  |
| OstrzezenieDlaEdycji.Message | `string` | tylko-odczyt |  |  |
| OstrzezenieDlaEdycji.Pokaz | `bool` | bazodanowe |  |  |
| OstrzezenieDlaEdycji.ShowMessage | `bool` | tylko-odczyt |  |  |
| OznaczJakoEParagon | `Soneta.Handel.OznaczJakoEParagon` (enum) | bazodanowe | Oznacz jako e-paragon. | Oznacz jako e-paragon |
| PlanSplat | `bool` | bazodanowe |  | Określa, czy płatności mają być tylko propozycją spłat (nie podlegają rozliczeniu). |
| PlatnoscKaucji | `bool` | bazodanowe |  | Określa, czy na dokumencie jest stosowana płatność kaucji. |
| PodgladZalacznika | `Soneta.Core.AttachmentPreviewDisplayMode` (enum) | bazodanowe | Podgląd dokumentów KSeF oraz załączników na zakładce 'Ogólne' |  |
| Podrzedne | `SubTable<Soneta.Handel.DefRelacjiHandlowej>` | podlista |  |  |
| PodrzedneDefinicje | `SubTable<Soneta.Handel.RelacjeDokumentow.DefDokPodrzednego>` | podlista |  |  |
| PodrzędneDefinicjeInfo | `string` | tylko-odczyt |  |  |
| Podsumowanie | `string` | bazodanowe |  | Określa widok podsumowania dokumentu. |
| PodzialKosztuDodatkowego | `Soneta.Handel.PodzialKosztuDodatkowego` (enum) | bazodanowe | Sposób podziału kosztu dodatkowego | Sposób podziału kosztu dodatkowego na pozycje dokumentu. |
| PodzialOkresuProporcja | `Soneta.Handel.UmowaPodzialOkresuProporcja` (enum) | bazodanowe | Podział okresu proporcją | Podział okresu proporcją. |
| PokazKomunikat | `bool` | bazodanowe |  | Decyduje o pokazywaniu komunikatu o kontrahencie po jego wybraaniu w dokumencie. |
| PokazNieZeroweWykluczone | `bool` |  |  | Dodatkowo pokazuje na liście towarów takie niezerowe towary, które są wykluczone przez filtr na magazynie. |
| PokazParametryWydruku | `Soneta.Handel.ParametryWydrukuMonit` (enum) | bazodanowe |  | Określa, czy okno z parametrami wydruku dla wydruku domyślnego będzie wyświetlane. |
| PoleSortowania | `string` | bazodanowe |  | Określa pole, po którym zostaną przesortowane pozycjie dokumentu po jego zapisaniu. |
| PostfixSerii | `string` | bazodanowe |  | Postfix identyfikujący serię w słowniku |
| PozwalajIlosc0 | `bool` | bazodanowe |  | Określa, czy można zatwierdzać dokumenty, które mają pozycje z zerową ilością. |
| PozwalajMagazynBezPraw | `Soneta.Handel.PozwalajMagazynBezPraw` (enum) | bazodanowe | Pozwalaj na nieuprawniony magazyn | Pozwala na wybranie magazynu docelowego, do którego operator nie ma praw. |
| PozwalajWartosc0 | `bool` | bazodanowe |  | Określa, czy można zatwierdzać dokumenty, które mają pozycje z zerową wartością. |
| PozwalajWartosc0Gratisu | `bool` | bazodanowe |  | Określa, czy można zatwierdzać dokumenty, które mają pozycje gratisowe z zerową wartością. |
| PozwalajWielowalutowy | `bool` | bazodanowe |  | Określa, czy dopuszczalne są płatności w różnych walutach. |
| PrawaDoDefinicji | `SubTable<Soneta.Handel.MagDefDokRight>` | podlista |  |  |
| PrecyzjaCeny | `Soneta.Towary.PrecyzjaCeny` (subrow) | bazodanowe |  | Określa ilość miejsc dziesiętynych dla ceny. |
| PrecyzjaCeny.Precyzja | `int` | bazodanowe |  | Precyzja zaokrąglenia (wyliczania) cen towaru |
| PrecyzjaCeny.Wymuszaj | `bool` | bazodanowe |  | Wskazuje na to, że precyzja ceny ustalona na definicji ma pierwszeńśtwo przed precyzją ceny na kartotece towaru |
| Procedura | `string` | bazodanowe | Nazwa procedury na fakturze | Nazwa procedury na fakturze (pod tytułem). |
| ProceduryVat | `bool` | bazodanowe |  |  |
| ProdukcjaInfo | `Soneta.Handel.ProdukcjaShortInfo` (subrow) | bazodanowe |  |  |
| ProdukcjaInfo.ObslugaTechnologii | `bool` | bazodanowe | Obsługa technologii | Określa, czy dokument obsługuje technologię. |
| RelacjaCykliczna | `Soneta.Handel.DefDokHandlowego` |  |  | Definicja dokumentu powstającego w wyniku rozliczenia cyklicznego dokumentu. |
| RelacjaCyklicznaDefinicja | `Soneta.Handel.DefRelacjiHandlowej` | tylko-odczyt |  | Definicja relacji, zawierająca szczegóły działania naliczania cyklicznego. |
| RelacjaKaucji | `Soneta.Handel.DefDokHandlowego` |  |  | Definicja dokumentu powstającego w wyniku rozliczenia opakowań dla towarów z dokumentu. |
| RelacjaKaucji2 | `Soneta.Handel.DefDokHandlowego` |  |  | Definicja dokumentu powstającego w wyniku rozliczenia opakowań dla towarów z dokumentu. |
| RelacjaKaucji3 | `Soneta.Handel.DefDokHandlowego` |  |  | Definicja dokumentu powstającego w wyniku rozliczenia opakowań dla towarów z dokumentu. |
| RelacjaKaucjiDefinicja | `Soneta.Handel.DefRelacjiHandlowej` | tylko-odczyt |  | Definicja relacji, zawierająca szczegóły działania naliczania opakowań. |
| RelacjaKopiowania | `Soneta.Handel.DefDokHandlowego` |  |  | Definicja dokumentu powstającego w wyniku kopiowania dokumentu. |
| RelacjaKopiowania2 | `Soneta.Handel.DefDokHandlowego` |  |  | Druga definicja dokumentu powstającego w wyniku kopiowania dokumentu. |
| RelacjaKopiowania3 | `Soneta.Handel.DefDokHandlowego` |  |  | Trzecia definicja dokumentu powstającego w wyniku kopiowania dokumentu. |
| RelacjaKopiowania4 | `Soneta.Handel.DefDokHandlowego` |  |  | Czwarta definicja dokumentu powstającego w wyniku kopiowania dokumentu. |
| RelacjaKopiowaniaB | `Soneta.Handel.DefDokHandlowego` |  |  | Definicja dokumentu powstającego w wyniku drugiego kopiowania dokumentu. |
| RelacjaKopiowaniaB2 | `Soneta.Handel.DefDokHandlowego` |  |  | Druga definicja dokumentu powstającego w wyniku drugiego kopiowania dokumentu. |
| RelacjaKopiowaniaB3 | `Soneta.Handel.DefDokHandlowego` |  |  | Trzecia definicja dokumentu powstającego w wyniku drugiego kopiowania dokumentu. |
| RelacjaKopiowaniaB4 | `Soneta.Handel.DefDokHandlowego` |  |  | Czwarta definicja dokumentu powstającego w wyniku drugiego kopiowania dokumentu. |
| RelacjaKopiowaniaBDefinicja | `Soneta.Handel.DefRelacjiHandlowej` | tylko-odczyt |  | Definicja relacji, zawierająca szczegóły działania drugiego kopiowania. |
| RelacjaKopiowaniaDefinicja | `Soneta.Handel.DefRelacjiHandlowej` | tylko-odczyt |  | Definicja relacji, zawierająca szczegóły działania kopiowania. |
| RelacjaKorekty | `Soneta.Handel.DefDokHandlowego` |  |  | Definicja dokumentu powstającego w wyniku tworzenia korekty. |
| RelacjaKorektyDefinicja | `Soneta.Handel.DefRelacjiHandlowej` | tylko-odczyt |  | Definicja relacji, zawierająca szczegóły działania korekty. |
| RelacjaMagazynowa | `Soneta.Handel.DefDokHandlowego` |  |  | Definicja dokumentu magazynowego. |
| RelacjaMagazynowaDefinicja | `Soneta.Handel.DefRelacjiHandlowej` | tylko-odczyt |  | Definicja relacji, zawierająca szczegóły działania relacji magazynowej. |
| RezerwacjaDo | `Soneta.Magazyny.TypDatyRezerwacji` (enum) | bazodanowe | Koniec okresu rezerwacji | Data, od której wyliczana będzie końcowa data rezerwacji ilościowej. |
| RezerwacjaDoDni | `int` | bazodanowe |  |  |
| RezerwacjaOd | `Soneta.Magazyny.TypDatyRezerwacji` (enum) | bazodanowe | Początek okresu rezerwacji | Data, od której wyliczana będzie podczątkowa data rezerwacji ilościowej. |
| RezerwacjaOdDni | `int` | bazodanowe |  |  |
| RezerwowacTowar | `bool` | bazodanowe |  | Określa, czy dokument rezerwuje ilościowo (bez wskazania zasobów) towar w magazynie. |
| RodzajLokDlaDostawy | `Soneta.Core.SlownikElem` | bazodanowe | Rodzaj lokalizacji | Rodzaj lokalizacji dla miejsca dostawy. |
| RodzajTransakcji | `Soneta.Handel.KodRodzajuTransakcji` (enum) | bazodanowe |  | Rodzaj transakcji dla deklaracji Intrastat. |
| RodzajTransportu | `Soneta.Handel.KodRodzajuTransportu` (enum) | bazodanowe |  | Kod rodzaju transportu dla deklaracji Intrastat. |
| RodzajUmowy | `Soneta.Handel.RodzajUmowy` (enum) | bazodanowe | Domyślny rodzaj umowy | Określa domyślny rodzaj umowy. |
| RodzajWydruku | `Soneta.Handel.RodzajWydruku` (enum) | bazodanowe |  | Rodzaj wydruku (pełny lub uproszczony). |
| RodzajWydrukuFiskalnego | `Soneta.Handel.RodzajWydrukuFiskalnego` (enum) | bazodanowe |  | Rodzaj wydruku fiskalnego dla drukarek fiskalnych nowego typu. |
| RodzajZamowieniaNaPozycji | `Soneta.Handel.RodzajZamowieniaNaPozycji` (enum) | bazodanowe | Domyślny rodzaj zamówienia na pozycji |  |
| RodzajeKomunikatow | `LpSubTable<Soneta.Core.RodzajKomunikatuHost>` | podlista |  |  |
| RozchodBezMarzy | `bool` |  |  | Określa, czy rozchód ma być liczony bez marży. |
| RozliczajAutomatycznieBlokadeZasobu | `bool` | bazodanowe | Rozliczaj automatycznie blokadę zasobu | Rozliczaj automatycznie blokadę zasobu. |
| RozliczajBlokadeKorektaPrzyjecia | `bool` | bazodanowe | Rozliczaj blokadę korektą przyjęcia | Rozliczaj blokadę korektą przyjęcia. |
| RozliczajZasobIlosciaZrealizowana | `bool` | bazodanowe | Rozliczaj zasób ilością zrealizowaną | Rozliczaj zasób ilością zrealizowaną. |
| RozneWalutyPozycjiIPodsumowania | `bool` | bazodanowe | Dopuszczaj ceny na pozycjach w innej walucie niż wartość dokumentu | Dopuszczaj ceny na pozycjach w innej walucie niż wartość dokumentu |
| SeriaCategory | `string` | tylko-odczyt |  |  |
| SeriaDictionaryList | `View` | podlista |  |  |
| SeriaOperatora | `bool` | bazodanowe |  | Włącza uzupełnienie pola 'Seria' w dokumencie kodem aktualnie pracującego operatora. |
| SlownikSerii | `bool` | bazodanowe |  | Umożliwia wprowadzenie serii bazującej na słowniku. |
| SposobEdycjiKompletacji | `Soneta.Handel.SposobEdycjiKompletacji` (enum) | bazodanowe |  | Określa sposób przeliczenia składników/produktów po zmianie ilości w pozycji kompletacji. |
| SposobPrzenoszeniaZaliczki | `Soneta.Handel.SposobPrzenoszeniaZaliczki` (enum) | bazodanowe |  | Określa sposób, w jaki faktura zaliczkowa jest rozliczana przez dokument końcowy. |
| SposobRozliczaniaNadrzednego | `Soneta.Handel.SposobRozliczaniaNadrzednego` (enum) | bazodanowe |  | Określa, czy zmiany na dokumencie będą powodowały zmiany w rozliczeniu, które dokument powoduje względem dokumentu sobie nadrzędnego. |
| SposobZaplaty | `Soneta.Kasa.SposobZaplaty` | bazodanowe |  | Określa sposób zapłaty stosowany w dokumencie. |
| SprzedazPonizejCenyMinimalnej | `Soneta.Handel.SprzedazPonizejCenyMinimalnej` (enum) | bazodanowe |  |  |
| SprzedazPonizejCenyZakupu | `Soneta.Handel.SprzedazPonizejCenyMinimalnej` (enum) | bazodanowe |  |  |
| SprzedazPonizejMarzyMinimalnej | `Soneta.Handel.SprzedazPonizejCenyMinimalnej` (enum) | bazodanowe |  |  |
| StatusPozycjiObsluga | `bool` | bazodanowe | Obsługa statusu pozycji |  |
| SumyVAT | `Soneta.Handel.SposobLiczeniaSumVAT` (enum) | bazodanowe |  | Określa sposób liczenia tabeli VAT oraz czy możliwa jest jej edycja. |
| Symbol | `string` | bazodanowe |  | Skrótowa nazwa definicji dokumentu, wykorzystywana do wyszukiwania definicji oraz numeracji dokumentów handlowych. |
| SzablonPolOpcjonalnychEksportKSeF | `Soneta.Core.KSeFSzablonPolOpcjonalnych` | bazodanowe |  | Szablon pól opcjonalnych KSeF - eksport |
| TerminPlatnosciLiczonyOd | `Soneta.Handel.TerminPłatnościLiczonyOd` (enum) | bazodanowe | Termin płatności liczony od daty | Określa datę, od której ma być obliczany termin płatności. |
| TerminWaznosciWersjonowania | `bool` | bazodanowe |  | Daje możliwość wersjonowania dokumentów. |
| TowarWgDostawcy | `Soneta.Handel.TowarWgDostawcy` (enum) | bazodanowe |  | Wymusza filtrowanie wyszukiwanie towaru wg dostawcy, którym jest kontrahent z dokument. |
| Transport | `bool` | bazodanowe | Transport | Określa, czy dokument obsługuje spedycje. |
| TylkoPodglad | `bool` | bazodanowe |  | Uniemożliwia edycję dokumentu przez operatora programu. |
| TypFiltruTowaru | `Soneta.Towary.TypFiltruTowaru` (enum) | bazodanowe |  | Określa filtrowanie towaru wg typu. |
| TypPartiiMagazynowej | `Soneta.Magazyny.TypPartii` (enum) | bazodanowe | Typ partii magazynowej | Określa typ zapisu dotyczącego operacji magazynowych. |
| TytulWydruku | `string` | bazodanowe |  | Tytuł umieszczany na wydruku w nagłówku dokumentu. |
| TytulWydruku2 | `string` | bazodanowe |  | Tytuł w języku obcym, umieszczany na wydruku w nagłówku dokumentu. |
| Umowa | `Soneta.Handel.TypUmowy` (enum) | bazodanowe |  |  |
| UstawianiePriorytetu | `Soneta.Handel.UstawianiePriorytetu` (enum) | bazodanowe | Ustawianie priorytetu |  |
| UstawianiePriorytetuCecha | `FeatureDefinition` | bazodanowe | Wybór definicji cechy algorytmicznej. |  |
| UstawieniaWskazaniePartii | `Soneta.Handel.UstawieniaWskazaniePartii` (subrow) | bazodanowe |  | Ustawienia dotyczące wskazania partii i zasobów. |
| UstawieniaWskazaniePartii.DoZamowien | `bool` | bazodanowe |  | Określa, czy możliwe jest wskazanie partii do zasobów zamówionych. |
| UstawieniaWskazaniePartii.Flags | `Soneta.Handel.Helpers.Flags` (enum) | bazodanowe |  | Flagi dodatkowe. |
| UstawieniaWskazaniePartii.Opcje | `Soneta.Handel.WyborPartiiOpcje` (enum) | bazodanowe | Wybór partii i zasobu | Opcje mechanizmu wyboru partii. |
| UstawieniaWskazaniePartii.Przedmiot | `Soneta.Handel.WyborPartiiPrzedmiot` (enum) | bazodanowe | Dotyczy | Przedmiot mechanizmu wyboru partii. |
| UstawieniaWskazaniePartii.WydanieZeWskazanejDostawy | `bool` | bazodanowe | Wydanie ze wskazanej dostawy | Dla zamówień odbiorcy z subzasobami wydania magazynowe realizowane wyłącznie ze wskazanych dostaw. |
| UstawieniaWskazaniePartii.ZasobyPodrzedne | `bool` | bazodanowe |  | Określa, czy rezerwowanie partii będzie realizowane za pomocą zasobów podrzędnych. |
| UsuwanieZerowychPozycjiKorekty | `bool` | bazodanowe | Usuwaj niekorygowane pozycje | Dotyczy tylko i wyłącznie korekt i powoduje usuwanie pozycji niekorygowanych podczas zatwierdzania dokumentów i ich odtwarzanie podczas cofania do bufora. |
| WalutaPlatnosci | `Soneta.Waluty.Waluta` | bazodanowe | Waluta płatności | Waluta, w której będzie wyliczona płatność dokumentu. |
| Warnings | `SubTable<Soneta.Core.WarningDefRel>` | podlista |  |  |
| WartosciTylkoZeSlownika | `bool` | bazodanowe |  | Określa, czy operator może wprowadzić wartość spoza słownika |
| WarunkiDostawy | `Soneta.Handel.WarunkiDostawy` (enum) | bazodanowe |  | Kod warunków dostawy towaru dla deklaracji Intrastat. |
| WaznaDo | `Soneta.Magazyny.TypDatyRezerwacji` (enum) | bazodanowe | Koniec okresu rezerwacji | Data, od której wyliczana będzie końcowa data ważności wersji. |
| WaznaDoDni | `int` | bazodanowe |  |  |
| WersjonowanieDokumentu | `bool` | bazodanowe |  | Możliwość wersjonowania dokumentów. |
| WersjonowanieWydruk | `Soneta.Handel.WersjonowanieWydruk` (enum) | bazodanowe |  |  |
| WeryfikacjaZmianyDanych | `bool` | bazodanowe | Weryfikacja zmiany danych | Weryfikuj na korektach zmiany w danych nabywcy i odbiorcy. |
| WeryfikujRezerwacje | `bool` | bazodanowe |  | Określa, czy dokument ma uwzględniać rezerwacje iloścowe, czyli korzystać z ilości dostępnej, a nie stanu towaru. |
| Wewnetrzny | `bool` | bazodanowe |  | Określa, czy dokument magazynowy ma być w grupie wewnętrznych. |
| WpisBDO | `Soneta.Handel.WpisBDO` (enum) | bazodanowe | Rodzaj wpisu BDO | Określa rodzaj wpisu BDO. |
| WszystkieNadrzędne | `System.Collections.Generic.IEnumerable<Soneta.Handel.DefRelacjiHandlowej>` | podlista |  |  |
| WyborStawkiVAT | `Soneta.Handel.WyborStawkiVAT` (enum) | bazodanowe |  | Określa, w jaki sposób będzie inicjowana stawka VAT podczas dodawania pozycji dokumentu. |
| WyborStawkiVATWgDaty | `Soneta.Handel.RodzajDaty` (enum) | bazodanowe |  | Określa datę, według której będzie inicjowana stawka VAT podczas dodawania pozycji dokumentu. |
| WyborWariantu | `Soneta.Handel.WyborWariantu` (enum) | bazodanowe | Wybór wariantu | Określa sposób wyboru wariantu. |
| WydrukDomyslny | `bool` | bazodanowe |  | Określa, czy podczas zatwierdzania formularza z dokumentem ma być drukowany domyślny wydruk. |
| WymaganyDrugiMagazyn | `bool` | tylko-odczyt |  | Informuje, czy dany dokument potrzebuje wprowadzenia drugiego magazynu. |
| WzorzecOpisuPlatnosci | `string` | bazodanowe | Wzorzec opisu płatności | Określa niestandardowy sposób tworzenia opisu w płatności dokumentu. |
| WzórVAT | `string` | tylko-odczyt |  | Wzór opisujący sposób liczenia podatku VAT. |
| XmlNET | `MemoText` | bazodanowe, podlista | Definicja zakładki użytkownika w Pulpicie kontrahenta. |  |
| ZablokujEdycjeKursu | `bool` | bazodanowe |  | Uniemożliwia edycję daty i wartości kursu waluty. |
| ZachowaniePoLimicie | `Soneta.Handel.ZachowaniePoPrzekroczeniuLimituKredytowego` (enum) | bazodanowe | Zachowanie dokumentu po przekroczeniu limitu kredytowego | Określa zachowanie dokumentu po przekroczeniu limitu kredytowego. |
| ZaplataPrzyZatwierdzaniu | `Soneta.Handel.DostepnoscMenadzeraRozliczen` (enum) | bazodanowe | Zapłata przy zatwierdzaniu | Określa, czy podczas zatwierdzania dokumentu powstanie zapłata. |
| ZeWskazaniemPartii | `bool` | tylko-odczyt |  | Określa, czy dokument jest ze wskazaniem partii towaru. |
| ZmianaMarzy | `Soneta.Magazyny.ZmianaMarzy` (enum) | bazodanowe |  | Określa sposób wpływania dokumentów przychodowych na marżę dokumentu rozchodowego. |
| ZmianaParametrowZasobuInfo | `Soneta.Handel.ZmianaParametrowZasobuShortInfo` (subrow) | bazodanowe |  |  |
| ZmianaParametrowZasobuInfo.ZmianaParametrowZasobu | `bool` | bazodanowe | Zmiana parametrów zasobu | Określa, czy dokument umożliwia zmianę wartości (bez ilości) lub ilości (bez wartości) zasobu. |
| ZmianaWartosciPozycji | `Soneta.Handel.ZmianaWartosciPozycji` (enum) | bazodanowe |  | Określa zachowanie dokumentu po zmianie wartości pozycji dokumentu. |
| bi_disabled | `bool` | bazodanowe |  | Wyłącza mechanizm Business Integrity kontrolujący spójność zapisów dotyczących operacji magazynowych. Mechanizm działa na MSSQL. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AttachmentPreviewDisplayMode (`Soneta.Core.AttachmentPreviewDisplayMode`)
- `Never` = 0 — Nigdy
- `Always` = 1 — Zawsze
- `StanBufor` = 2 — Gdy stan Bufor
- `StanNiezweryfikowany` = 3 — Gdy stan Niezweryfikowany

### DefinicjaCykluSposobNaDniWolne (`Soneta.Core.DefinicjaCykluSposobNaDniWolne`)
- `None` = 0 — Jak w dniu roboczym
- `Pomin` = 1 — Pomiń cykl
- `Zastap` = 2
- `ZastapNastepnymWBiezacym` = 69890 — Zastąp następnym dniem roboczym w fakturowanym okresie
- `ZastapPoprzednimWBiezacym` = 70146 — Zastąp poprzednim dniem roboczym w fakturowanym okresie
- `ZastapNastepnymWPrzyszlym` = 135426 — Zastąp następnym dniem roboczym w następnym okresie
- `ZastapPoprzednimWPoprzednim` = 266754 — Zastąp poprzednim dniem roboczym w poprzednim okresie
- `NastepnyDzien` = 256
- `PoprzedniDzien` = 512
- `DzienRoboczy` = 4096
- `BiezacyOkres` = 65536
- `NastepnyOkres` = 131072
- `PoprzedniOkres` = 262144

### DefinicjaCykluTyp (`Soneta.Core.DefinicjaCykluTyp`)
- `Brak` = 0 — Brak
- `Jednorazowy` = 1
- `Minutowy` = 300
- `Godzinowy` = 400
- `Dzienny` = 500
- `Tygodniowy` = 600
- `Miesieczny` = 700
- `Roczny` = 800
- `Algorytm` = 999999

### LogoWydruk (`Soneta.Core.Enums.LogoWydruk`)
- `Brak` = 0
- `PoLewej` = 1 — Po lewej
- `PoSrodku` = 2 — W środku
- `PoPrawej` = 3 — Po prawej

### KierunekPlatnosci (`Soneta.Core.KierunekPlatnosci`)
- `Brak` = 0
- `Przychod` = 1 — Przychód
- `Rozchod` = 2 — Rozchód

### DataOkresIntrastat (`Soneta.Handel.DataOkresIntrastat`)
- `Data` = 0
- `DataOperacji` = 1 — DataOperacji
- `ObcyDataOtrzymania` = 2 — Obcy.DataOtrzymania
- `DostawaTermin` = 3 — Dostawa.Termin

### DataZobowiazanNaleznosci (`Soneta.Handel.DataZobowiazanNaleznosci`)
- `WgKonfiguracjiSP` = 0 — Wg konfiguracji ŚP
- `WgDatyOperacji` = 1 — Wg daty operacji
- `WgDatyWystawienia` = 2 — Wg daty wystawienia

### DefDataKursu (`Soneta.Handel.DefDataKursu`)
- `Data` = 0
- `DataOperacji` = 1
- `DataObcy` = 2 — Data otrzymania
- `DataOperacjiLubData` = 3 — Data operacji albo data, jeśli wcześniejsza.
- `DataDostawyLubData` = 4 — Data dostawy albo data, jeśli wcześniejsza.

### DostawcaOdbiorca (`Soneta.Handel.DostawcaOdbiorca`)
- `Dowolny` = 0
- `ListaPowiazanych` = 1 — Z listy powiązanych

### DostepnoscMenadzeraRozliczen (`Soneta.Handel.DostepnoscMenadzeraRozliczen`)
- `Nigdy` = 0 — Nigdy
- `Zawsze` = 1
- `GdyNieodroczona` = 2

### EdycjaDatyDostawy (`Soneta.Handel.EdycjaDatyDostawy`)
- `Brak` = 0 — Brak
- `Standardowa` = 1
- `NaZatwierdzonym` = 2

### EdycjaIlosciZrealizowanej (`Soneta.Handel.EdycjaIlosciZrealizowanej`)
- `Brak` = 0 — Brak edycji
- `NaZatwierdzonym` = 1 — Edycja na zatwierdzonym

### EdycjaStanuRealizacji (`Soneta.Handel.EdycjaStanuRealizacji`)
- `Brak` = 0 — Brak edycji
- `NaZatwierdzonym` = 1 — Edycja na zatwierdzonym
- `WgOperacji` = 2 — Wyliczany według operacji

### EdycjaTerminuPlatnosci (`Soneta.Handel.EdycjaTerminuPlatnosci`)
- `Zawsze` = 0
- `Nigdy` = 1
- `WgUprawnienia` = 2

### EdycjaWTrybieKoszyka (`Soneta.Handel.EdycjaWTrybieKoszyka`)
- `Brak` = 0
- `BezEdycjiIlosc` = 1 — Bez edycji ilości
- `ZEdycjaIlosci` = 2 — Z edycją ilości

### EdycjaWartosciDokumentu (`Soneta.Handel.EdycjaWartosciDokumentu`)
- `ZakazZmiany` = 0
- `SprawdzajKwotęPLN` = 1 — Pozwalaj na edycję
- `PozwalajNaMniejsząKwotę` = 2
- `PozwalajNaZmianeWaluty` = 3 — Pozwalaj na zmianę waluty

### FiltrKontrahentaStosowanie (`Soneta.Handel.FiltrKontrahentaStosowanie`)
- `Ignoruj` = 0 — Pozwalaj
- `Ostrzegaj` = 1
- `Ograniczaj` = 2 — Zabraniaj

### Flags (`Soneta.Handel.Helpers.Flags`)
- `None` = 0
- `KWPZAgregowanieWgDokumentow` = 1
- `KWPZAgregowanieGroup` = 1
- `KursWalutyZmieniony` = 2
- `KursWalutyGroup` = 2
- `ZmianaZatwierdzonegoDokumentu` = 4
- `ZmianaZatwierdzonegoDokumentuGroup` = 4
- `ZmianaParametrowZasobuZmianaIlosci` = 16
- `ZmianaParametrowZasobuZmianaWartosc` = 32
- `ZmianaParametrowZasobuGroup` = 48
- `DodatkoweStornoZasobuWZamknietymOkresie` = 256

### IloscPozycjiDokumentuHandlowego (`Soneta.Handel.IloscPozycjiDokumentuHandlowego`)
- `Niezerowa` = 0
- `Dowolna` = 1
- `TylkoJedna` = 2

### IloscTowaruKopiowana (`Soneta.Handel.IloscTowaruKopiowana`)
- `Dowolna` = 0
- `DoIlościStanu` = 1
- `DowolnaLubBrak` = 2 — Dowolna lub brakująca

### InicjalizacjaDatyDostawy (`Soneta.Handel.InicjalizacjaDatyDostawy`)
- `Brak` = 0
- `Standardowa` = 1
- `WgCechy` = 2

### KategoriaHandlowa (`Soneta.Handel.KategoriaHandlowa`)
- `Brak` = 0 — Brak
- `HandelPierwszy` = 1
- `Sprzedaż` = 2
- `KorektaSprzedaży` = 3
- `Zakup` = 4
- `KorektaZakupu` = 5
- `FakturaWewnętrzna` = 6
- `HandelOstatni` = 100
- `MagazynPierwszy` = 101
- `PrzyjęcieMagazynowe` = 102
- `KorektaPrzyjęciaMagazynowego` = 103
- `WydanieMagazynowe` = 104
- `KorektaWydaniaMagazynowego` = 105
- `PrzesunięcieMagazynowe` = 106
- `Inwentaryzacja` = 107
- `Kompletacja` = 108
- `WewnętrzneMagazynowe` = 109
- `PrzyjęcieOpakowań` = 110
- `KorektaPrzyjęciaOpakowań` = 111
- `WydanieOpakowań` = 112
- `KorektaWydaniaOpakowań` = 113
- `PrzyjęcieOdpadów` = 114
- `KorektaPrzyjęciaOdpadów` = 115
- `WydanieOdpadów` = 116
- `KorektaWydaniaOdpadów` = 117
- `BlokadaZasobu` = 118
- `MagazynOstatni` = 200
- `PozostałePierwszy` = 301
- `ZamówienieOdbiorcy` = 302
- `ZamówienieDostawcy` = 303
- `Wewnętrzny` = 304
- `Pozostałe` = 305
- `OfertaOdbiorcy` = 306
- `OfertaDostawcy` = 307
- `Umowa` = 308
- `AneksDoUmowy` = 309
- `ZapytanieOfertoweOdbiorcy` = 310
- `ZapytanieOfertoweDostawcy` = 311
- `ZamówienieWewnętrzne` = 312
- `Pomocniczy` = 313
- `PozostałeOstatni` = 400
- `ProdukcjaPierwszy` = 500
- `ZlecenieProdukcyjne` = 501
- `ProdukcjaOstatni` = 599
- `BrakOstatnia` = 1000

### KodKreskowyZNumeremDok (`Soneta.Handel.KodKreskowyZNumeremDok`)
- `Brak` = 0
- `CODE_128` = 16 — CODE_128
- `CODE_39` = 4 — CODE_39
- `QR_CODE` = 2048 — QR_CODE
- `DATA_MATRIX` = 32 — DATA_MATRIX

### KodRodzajuTransakcji (`Soneta.Handel.KodRodzajuTransakcji`)
- `Brak` = 0
- `Różne` = 1 — Różne rodzaje transkacji
- `_11` = 11 — 11 - Kupno/sprzedaż za zapłatą
- `_12` = 12 — 12 - Dostawy z zamiarem sprzedaży po akceptacji...
- `_13` = 13 — 13 - Transakcje powodujące zapłatę w naturze...
- `_14` = 14 — 14 - Zakup przez podróżnego towarów do użytku osobistego
- `_15` = 15 — 15 - Leasing finansowy
- `_21` = 21 — 21 - Zwrot towarów
- `_22` = 22 — 22 - Rekompensata za zwrócone towary
- `_23` = 23 — 23 - Rekompensata za towary, które nie podlegają zwrotowi...
- `_31` = 31 — 31 - Dostawy towarów w ramach programów pomocy...
- `_32` = 32 — 32 - Inne dostawy towarów w ramach pomocy rządowej
- `_33` = 33 — 33 - Inne dostawy towarów w ramach pomocy...
- `_34` = 34 — 34 - Inne transakcje dotyczące dostaw bezpłatnych
- `_41` = 41 — 41 - Dostawa towarów w celu uszlachetniania lub przetwarzania...
- `_42` = 42 — 42 - Dostawy towarów w celu naprawy i konserwacji za zapłatą
- `_43` = 43 — 43 - Dostawy towarów w celu naprawy i konserwacji bez zapłaty
- `_51` = 51 — 51 - Dostawa towarów po uszlachetnianiu lub przetworzeniu...
- `_52` = 52 — 52 - Dostawy towarów po naprawie lub konserwacji za zapłatą
- `_53` = 53 — 53 - Dostawy towarów po naprawie lub konserwacji bez zapłaty
- `_61` = 61 — 61 - Dzierżawa, pożyczka, leasing operacyjny
- `_62` = 62 — 62 - Inne czasowe użytkowanie
- `_70` = 70 — 70 - Wysyłki towarów w ramach wspólnych programów obronnych...
- `_80` = 80 — 80 - Dostawy materiałów budowlanych, wyposażenia i sprzętu...
- `_90` = 90 — 90 - Inne rodzaje transakcji
- `_1011` = 1011 — 11 - Bezwarunkowa sprzedaż/kupno z wył. handlu bezpośredniego z prywatnymi konsumentami/przez prywatnych konsumentów
- `_1012` = 1012 — 12 - Handel bezpośredni z prywatnymi konsumentami/przez prywatnych konsumentów (w tym sprzedaż na odległość)
- `_1013` = 1013 — 13 - Handel barterowy (wynagrodzenie w naturze)
- `_1014` = 1014 — 14 - Leasing finansowy (kupno/sprzedaż na raty)
- `_1019` = 1019 — 19 - Inne
- `_1021` = 1021 — 21 - Zwrot towarów
- `_1022` = 1022 — 22 - Wymiana zwróconych towarów
- `_1023` = 1023 — 23 - Wymiana towarów, które nie zostały zwrócone
- `_1029` = 1029 — 29 - Inne
- `_1030` = 1030 — 30 - Transakcje, z którymi związane jest przeniesienie prawa własności bez rekompensaty finansowej
- `_1031` = 1031 — 31 - Przemieszczenia do/z magazynu
- `_1032` = 1032 — 32 - Dostawy z zamiarem sprzedaży po zatwierdzeniu lub wypróbowaniu
- `_1033` = 1033 — 33 - Leasing finansowy
- `_1034` = 1034 — 34 - Transakcje obejmujące przeniesienie własności bez rekompensaty finansowej
- `_1041` = 1041 — 41 - Towary, które mają wrócić do początkowego państwa członkowskiego/kraju wywozu
- `_1042` = 1042 — 42 - Towary, które nie mają wrócić do początkowego państwa członkowskiego/kraju wywozu
- `_1051` = 1051 — 51 - Towary powracające do początkowego państwa członkowskiego/kraju wywozu
- `_1052` = 1052 — 52 - Towary niepowracające do początkowego państwa członkowskiego/kraju wywozu
- `_1061` = 1061 — 61 - Nabycie wewnątrzunijne biokomponentów
- `_1062` = 1062 — 62 - Nabycie wewnątrzunijne biomas
- `_1063` = 1063 — 63 - Nabycie wewnątrzunijne biopaliw
- `_1070` = 1070 — 70 - Dostawy w ramach wspólnych programów obronnych lub innych...
- `_1071` = 1071 — 71 - Dopuszczenie towarów do obrotu w państwie członkowskim z późniejszym wywozem do innego państwa członkowskiego
- `_1072` = 1072 — 72 - Transport towarów z jednego państwa członkowskiego do innego w celu objęcia ich procedurą wywozu
- `_1080` = 1080 — 80 - Dostawa materiałów budowlanych i wyposażenia technicznego w ramach umowy budowlanej o generalne wykonawstwo...
- `_1091` = 1091 — 91 - Wynajem, wypożyczenie i leasing operacyjny dłuższy niż 24 miesiące
- `_1099` = 1099 — 99 - Inne

### KodRodzajuTransportu (`Soneta.Handel.KodRodzajuTransportu`)
- `Brak` = 0
- `_1` = 1 — 1 - Transport morski
- `_2` = 2 — 2 - Transport kolejowy
- `_3` = 3 — 3 - Transport drogowy
- `_4` = 4 — 4 - Transport lotniczy
- `_5` = 5 — 5 - Przesyłki pocztowe
- `_7` = 7 — 7 - Stałe instalacje przesyłowe...
- `_8` = 8 — 8 - Żegluga śródlądowa
- `_9` = 9 — 9 - Własny napęd

### KursWgDaty (`Soneta.Handel.KursWgDaty`)
- `Obowiązywania` = 0 — Obowiązywania
- `Ogłoszenia` = 1

### LimitWartosciReakcjaZatwierdzanie (`Soneta.Handel.LimitWartosciReakcjaZatwierdzanie`)
- `Dozwolone` = 0 — Dozwolone
- `Zabronione` = 1
- `WgPrawaOperatora` = 2

### LinieParagonu (`Soneta.Handel.LinieParagonu`)
- `PozycjeLubTabelaVAT` = 0 — Pozycje lub tabela VAT
- `Pozycje` = 1 — Pozycje
- `TabelaVAT` = 2 — Tabela VAT

### OpcjeDodawania (`Soneta.Handel.MozliwosciEdycji.OpcjeDodawania`)
- `Zakaz` = 0 — Brak
- `Dowolnie` = 1 — Bez ograniczeń
- `Uslugi` = 2 — Tylko usługi
- `Opakowania` = 3 — Tylko opakowania

### OpcjeEdycji (`Soneta.Handel.MozliwosciEdycji.OpcjeEdycji`)
- `Zakaz` = 0 — Brak
- `Dowolnie` = 1 — Bez ograniczeń
- `Cena` = 2 — Cena i wartość
- `Ilosc` = 3 — Ilość, cena i wartość
- `NazwaOpis` = 4 — Brak (tylko nazwa i opis)

### NazwaTowaruNaPozycji (`Soneta.Handel.NazwaTowaruNaPozycji`)
- `ZKartyTowaru` = 0 — Z karty towaru
- `KodINazwaZKartyTowaru` = 1 — Kod-Nazwa z karty towaru
- `OstatniZKarty` = 9
- `TylkoNazwa` = 10
- `TylkoOpis` = 11
- `NazwaIOpis` = 12
- `NazwaIndywidualna` = 13
- `NazwaIndywidualnaIOpis` = 14
- `KodINazwa` = 15 — Kod-Nazwa
- `KodINazwaOpis` = 16 — Kod-Nazwa Opis
- `KodIOpis` = 20 — Kod Opis
- `KodINazwaIndywidualna` = 17 — Kod-Nazwa indywidualna
- `KodIndywidualnyINazwa` = 18 — Kod indywidualny - Nazwa
- `KodIndywidualnyINazwaIndywidualna` = 19 — Kod indywidualny - Nazwa indywidualna
- `Cecha` = 21 — Na podstawie cechy

### NumerEwidencji (`Soneta.Handel.NumerEwidencji`)
- `Automatycznie` = 0
- `NumerWlasny` = 1 — Numer własny
- `NumerObcy` = 2 — Numer obcy

### OkreslenieDatyZaplaty (`Soneta.Handel.OkreslenieDatyZaplaty`)
- `WgDatyWystawienia` = 0
- `WgDatyOtrzymania` = 1
- `WgDatyOperacji` = 2
- `WgDatyBiezacej` = 3 — Wg daty bieżącej

### OkreslenieKontrahenta (`Soneta.Handel.OkreslenieKontrahenta`)
- `Odbiorca` = -1
- `Kontrahent` = 0
- `Dostawca` = 1

### OpcjeDrukowaniaTabelOpakowan (`Soneta.Handel.OpcjeDrukowaniaTabelOpakowan`)
- `Nie` = 0
- `WgOpakowanZaPomocaPozycji` = 1 — Na podstawie obsługi opakowań za pomocą pozycji
- `WgOpakowanZaPomocaRelacji` = 2 — Na podstawie obsługi opakowań w relacji kaucji
- `Razem` = 3
- `WgOpakowanZaPomocaRelacjiTylkoOpakowania` = 4 — Na podstawie obsługi opakowań w relacji kaucji (tylko Opakowania)
- `WgOpakowanZaPomocaRelacjiTylkoKaucje` = 5 — Na podstawie obsługi opakowań w relacji kaucji (tylko Kaucje)

### OznaczJakoEParagon (`Soneta.Handel.OznaczJakoEParagon`)
- `Nigdy` = 0
- `Zawsze` = 1
- `WgKontrahenta` = 2

### ParametryWydrukuMonit (`Soneta.Handel.ParametryWydrukuMonit`)
- `Pokaz` = 20 — Pokaż
- `NiePokazuj` = 30

### PodzialKosztuDodatkowego (`Soneta.Handel.PodzialKosztuDodatkowego`)
- `Wartosc` = 0 — Wartość
- `Masa` = 1
- `Cecha` = 2

### PozwalajMagazynBezPraw (`Soneta.Handel.PozwalajMagazynBezPraw`)
- `NiePozwalaj` = 0
- `ZapisDoBufora` = 1
- `PozwolWybrac` = 2 — Pozwól wybrać
- `Zatwierdzanie` = 10

### RodzajDaty (`Soneta.Handel.RodzajDaty`)
- `Dokument` = 0 — Wystawienia
- `Dzisiaj` = 1 — Dzisiejszej
- `Operacja` = 3 — Operacji
- `KoniecOkresuRozliczonego` = 4
- `OkresRozliczeniowy` = 5 — Okresu rozliczeniowego

### RodzajIntrastat (`Soneta.Handel.RodzajIntrastat`)
- `NieUwzględniaj` = 0 — Nie uwzględniaj
- `PrzywózWPodrzędnym` = 1
- `WywózWPodrzędnym` = 2
- `Przywóz` = 257
- `Wywóz` = 258
- `IntrastatKorekta` = 512
- `Uwzględniaj` = 1024

### RodzajUmowy (`Soneta.Handel.RodzajUmowy`)
- `NieDotyczy` = 0 — Nie dotyczy
- `CyklicznaUsługa` = 1 — Cykliczna usługa
- `Dostawa` = 2 — Dostawa

### RodzajWydruku (`Soneta.Handel.RodzajWydruku`)
- `Pelny` = 0 — Pełny
- `Uproszczony` = 2
- `UproszczonyLimitWartosci` = 3 — Uproszczony, gdy wartość poniżej limitu

### RodzajWydrukuFiskalnego (`Soneta.Handel.RodzajWydrukuFiskalnego`)
- `Paragon` = 0
- `Faktura` = 1

### RodzajZamowieniaNaPozycji (`Soneta.Handel.RodzajZamowieniaNaPozycji`)
- `Zwykłe` = 0 — Zwykłe
- `Algorytmiczne` = 1 — Z rezerwacją ilości (algorytmiczne)
- `ZSubzasobami` = 2 — Z rezerwacją zasobu (subzasób)
- `ZObrotami` = 3 — Z obrotami
- `WgPozycjiKorygowanej` = 4 — Wg pozycji korygowanej

### SposobAktualizacjiCen (`Soneta.Handel.SposobAktualizacjiCen`)
- `Brak` = 0 — Brak
- `ZawszeAutomatycznie` = 1
- `ZaproponujNaZatwierdzenie` = 2
- `PotwierdzajNaZatwierdzenie` = 3
- `ZawszeProponuj` = 4 — Zawsze proponuj

### SposobBuforowania (`Soneta.Handel.SposobBuforowania`)
- `PrzenoszonyDoBufora` = 0
- `TylkoZatwierdzanie` = 1
- `BuforNiedozwolony` = 2
- `WgPrawa` = 4
- `TylkoBufor` = 5

### SposobDodawaniaHandlowego (`Soneta.Handel.SposobDodawaniaHandlowego`)
- `Dodawany` = 0 — Dodawany
- `DodawanyDomyślnie` = 1
- `Niedodawany` = 2

### SposobEdycjiKompletacji (`Soneta.Handel.SposobEdycjiKompletacji`)
- `None` = 0 — Brak
- `SkladnikiWgWspolczynnikaKompletacji` = 1
- `ProduktyWgWspolczynnikaKompletacji` = 2
- `SkladnikiWgKartoteki` = 16
- `ProduktyWgKartoteki` = 32
- `SkladnikiNowePozostaw` = 256
- `ProduktyNowePozostaw` = 512
- `SkladnikiNoweKasuj` = 4096
- `ProduktyNoweKasuj` = 8192
- `NowePozostaw` = 768
- `NoweKasuj` = 12288
- `WgWspolczynnikaKompletacji` = 771 — Pozwól na edycję składników i produktów
- `WgKartotekiPozostawNowe` = 816 — Przelicz składniki i produkty wg kartoteki
- `WgKartotekiKasujNowe` = 12336 — Odtwórz składniki i produkty wg kartoteki

### SposobLiczeniaSumVAT (`Soneta.Handel.SposobLiczeniaSumVAT`)
- `NieLiczyć` = 0
- `Liczyć` = 1
- `MożliwośćKorekty` = 2 — Korygowany
- `ZDokumentówNadrzędych` = 3 — Z dokumentów nadrzędnych
- `LiczyćProporcjonalnie` = 4
- `KorygowanyProporcjonalnie` = 5
- `KorygowanaZaliczka` = 6

### SposobLiczeniaVAT (`Soneta.Handel.SposobLiczeniaVAT`)
- `OdNetto` = 1
- `OdBrutto` = 2
- `OdBruttoMinusNetto` = 3
- `ZależyOdKontrahenta` = 4

### SposobPrzenoszeniaZaliczki (`Soneta.Handel.SposobPrzenoszeniaZaliczki`)
- `NieDotyczy` = 0
- `NaDokument` = 1 — W częściach na dok. końcowy
- `NaPozycje` = 2 — Poprzez pozycje

### SposobRozliczaniaNadrzednego (`Soneta.Handel.SposobRozliczaniaNadrzednego`)
- `Brak` = 0 — Brak
- `Dynamicznie` = 1

### SprzedazPonizejCenyMinimalnej (`Soneta.Handel.SprzedazPonizejCenyMinimalnej`)
- `WgSimpleRight` = 0 — Wg uprawnienia
- `Pozwalaj` = 10 — Zawsze
- `Ostrzegaj` = 20 — Ostrzegaj
- `Zabraniaj` = 30 — Nigdy

### SzybkaTransakcjaTowarPodlista (`Soneta.Handel.SzybkaTransakcjaTowarPodlista`)
- `Brak` = 0
- `Magazyny` = 100
- `Zasoby` = 200
- `Zamienniki` = 300

### TerminPłatnościLiczonyOd (`Soneta.Handel.TerminPłatnościLiczonyOd`)
- `DatyWystawienia` = 0 — Daty wystawienia
- `DatyOperacji` = 1 — Daty operacji
- `DataOtrzymania` = 2 — Daty otrzymania

### TowarWgDostawcy (`Soneta.Handel.TowarWgDostawcy`)
- `False` = 0 — Nie
- `True` = 1 — Z kartoteki
- `ZDokumentu` = 2 — Z dokumentu

### TworzenieOpisuEwidencji (`Soneta.Handel.TworzenieOpisuEwidencji`)
- `Domyslnie` = 0 — Domyślnie
- `Cecha` = 1 — Według cechy

### TypUmowy (`Soneta.Handel.TypUmowy`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Jednorazowa` = 1
- `Wielokrotna` = 2

### UmowaPodzialOkresuProporcja (`Soneta.Handel.UmowaPodzialOkresuProporcja`)
- `ProporcjaMiesięczna` = 0 — Proporcja miesięczna
- `ProporcjaStandardowa` = 1 — Proporcja standardowa

### UstawianiePriorytetu (`Soneta.Handel.UstawianiePriorytetu`)
- `Standardowo` = 0
- `WgCechy` = 1 — Wg cechy

### WarunkiDostawy (`Soneta.Handel.WarunkiDostawy`)
- `Brak` = 0
- `EXW` = 1 — EXW - z zakładu...
- `FCA` = 2 — FCA - franco przewoźnik...
- `FAS` = 3 — FAS - franco wzdłuż burty statku...
- `FOB` = 4 — FOB - franco statek...
- `CFR` = 5 — CFR - koszt i fracht...
- `CIF` = 6 — CIF - koszt, ubezpieczenie i fracht...
- `CPT` = 7 — CPT - przewoźne opłacone do...
- `CIP` = 8 — CIP - przewoźne i ubezpieczenie opłacone do...
- `DAF` = 9 — DAF - dostarczone na granicę...
- `DES` = 10 — DES - dostarczone statek...
- `DEQ` = 11 — DEQ - dostarczone nabrzeże...
- `DDU` = 12 — DDU - dostarczone (cło nieopłacone)...
- `DDP` = 13 — DDP - dostarczone (cło opłacone)...
- `DPU` = 14 — DPU - dostarczone do określonego miejsca z rozładunkiem
- `DAP` = 15 — DAP - dostarczone do określonego miejsca

### WersjonowanieWydruk (`Soneta.Handel.WersjonowanieWydruk`)
- `Brak` = 0
- `WazneDo` = 1 — Ważne do
- `Wersja` = 2 — Wersja
- `WazneDoIWersja` = 3 — Ważne do i wersja

### WpisBDO (`Soneta.Handel.WpisBDO`)
- `None` = 0
- `Wytworzone` = 1
- `Wydobyte` = 2
- `Przyjęte` = 3
- `Przetwarzane` = 4
- `Przekazane` = 5

### WyborPartiiOpcje (`Soneta.Handel.WyborPartiiOpcje`)
- `Zabroniony` = 0
- `_Zabroniony` = 196608
- `Dozwolony` = 1
- `_Dozwolony` = 196609
- `Automatyczny` = 2
- `_Automatyczny` = 196610
- `Wymuszony` = 4
- `_Wymuszony` = 131076
- `WymuszonyDodawanie` = 260 — Wymuszony przy dodawaniu pozycji
- `_WymuszonyDodawanie` = 65796
- `WymuszonyZatwierdzanie` = 516 — Wymuszony przy zatwierdzaniu
- `_WymuszonyZatwierdzanie` = 66052
- `WgTowaru` = 8 — Według karty towaru
- `_WgTowaru` = 65544
- `_MomentDodawaniePozycji` = 256
- `_MomentZatwierdzanie` = 512
- `_DefDokHandlowego` = 65536
- `_Towar` = 131072
- `_Ignorables` = 196608

### WyborPartiiPrzedmiot (`Soneta.Handel.WyborPartiiPrzedmiot`)
- `_Default` = 0 — Zasobu
- `Zasob` = 1 — Zasobu
- `GrupaDostaw` = 2 — Partii
- `ZasobGrupaDostaw` = 3 — Partii i zasobu

### WyborStawkiVAT (`Soneta.Handel.WyborStawkiVAT`)
- `Sprzedaży` = 0
- `Zakupu` = 1
- `Zero` = 2 — 0%
- `SprzedażyLubZero` = 3 — Sprzedaży / 0% / NP / -
- `SprzedażyWgKrajuLubZero` = 7 — Sprzedaży dla kraju / 0% / NP / -
- `ZakupuLubZero` = 4 — Zakupu / 0% / NP/ -
- `ZakupuWgKraju` = 8 — Zakupu dla kraju
- `Kaucji` = 5
- `Złom` = 6 —  - 

### WyborWariantu (`Soneta.Handel.WyborWariantu`)
- `Recznie` = 0 — Ręcznie
- `Automatycznie` = 1
- `WedlugKartyTowaru` = 2 — Według karty towaru

### WymaganieKontrahenta (`Soneta.Handel.WymaganieKontrahenta`)
- `Opcjonalny` = 0 — Opcjonalny
- `Wymagany` = 1
- `WymaganyWBuforze` = 2
- `Niewprowadzany` = 3
- `Incydentalny` = 4

### ZachowaniePoPrzekroczeniuLimituKredytowego (`Soneta.Handel.ZachowaniePoPrzekroczeniuLimituKredytowego`)
- `Dozwolone` = 0 — Dozwolone
- `Zabronione` = 1
- `WedługPrawaOperatora` = 2

### ZezwalajNaDrukowanieDokBezNrKSef (`Soneta.Handel.ZezwalajNaDrukowanieDokBezNrKSef`)
- `Ostrzegaj` = 0
- `Zawsze` = 1
- `Nigdy` = 2

### ZmianaWartosciPozycji (`Soneta.Handel.ZmianaWartosciPozycji`)
- `ZakazZmiany` = 0 — Zakaz zmiany
- `PrzeliczyćRabat` = 1
- `PrzeliczyćIlość` = 2
- `PrzeliczyćCenę` = 3
- `PrzeliczyćRabatCeny` = 4

### ZrodloEwidencji (`Soneta.Handel.ZrodloEwidencji`)
- `Default` = 0 — Domyślne
- `Definicja` = 1 — Z definicji
- `Korekta` = 2 — Z dokumentu korygowanego
- `CechaDokumentu` = 3 — Z cechy dokumentu
- `CechaDokumentuDefinicja` = 4 — Z cechy dokumentu lub z definicji

### ZrodloKursuWaluty (`Soneta.Handel.ZrodloKursuWaluty`)
- `WgDatyKursu` = 0
- `ZNadrzednego` = 1 — Z nadrzędnego

### ZrodloWaluty (`Soneta.Handel.ZrodloWaluty`)
- `None` = 0
- `ZNadrzednego` = 1 — Z nadrzędnego
- `ZKartyKontrahenta` = 2 — Z karty kontrahenta
- `ZDefinicjiPodrzednego` = 4 — Z definicji podrzędnego
- `ZDefinicji` = 8 — Z definicji dokumentu
- `ZCennika` = 16 — Z cennika
- `ZrodloWalutyWRelacjiPlatnosc` = 7
- `ZrodloWalutyWRelacjiPozycja` = 7
- `ZrodloWalutyPlatnosc` = 10
- `ZrodloWalutyPozycja` = 26

### KierunekPartii (`Soneta.Magazyny.KierunekPartii`)
- `Rozchód` = -1 — Rozchód
- `Brak` = 0 — Brak
- `Przychód` = 1 — Przychód

### MomentMagazynu (`Soneta.Magazyny.MomentMagazynu`)
- `PodczasZatwierdzania` = 0
- `PodczasZapisu` = 1 — Zapis do bufora
- `ZaPomocąRezerwacji` = 2
- `TylkoRezerwacja` = 3
- `WBuforze` = 4 — Na bieżąco, gdy dokument w buforze

### TypDatyRezerwacji (`Soneta.Magazyny.TypDatyRezerwacji`)
- `BezTerminu` = 0 — Bez terminu
- `DataWystawienia` = 1
- `TerminDostawy` = 2

### TypPartii (`Soneta.Magazyny.TypPartii`)
- `Brak` = 0 — Brak
- `Magazynowy` = 1
- `Zarezerwowany` = 2
- `Zamówiony` = 4
- `ZarezerwowanyZamówienie` = 16
- `TylkoZasób` = 65280
- `ZamówionyZasóbMagazynowy` = 260
- `ZamówionyZasób` = 264
- `Produkcyjny` = 271

### ZmianaMarzy (`Soneta.Magazyny.ZmianaMarzy`)
- `Dozwolona` = 0 — Dozwolona
- `Zerowa` = 1
- `Zabroniona` = 2
- `NiezmiennaKwota` = 3

### FiltrStanuTowaru (`Soneta.Towary.FiltrStanuTowaru`)
- `Dowolny` = 0
- `Dodatni` = 1
- `DodatniIUsługi` = 2
- `Zerowy` = 3
- `NieZerowy` = 4 — Niezerowy
- `Ujemny` = 5
- `ZerowyIUjemny` = 6
- `DodatniGratisów` = 7
- `UkryjNieZeroweWykluczone` = 256

### TypFiltruTowaru (`Soneta.Towary.TypFiltruTowaru`)
- `Razem` = 0
- `Towary` = 1
- `Usługi` = 2
- `Produkty` = 4
- `Wariantowe` = 5
- `Receptury` = 8
- `ProduktyIReceptury` = 12
- `NieUsługi` = 4096
- `TowaryUE` = 8192 — Towary UE
- `TowaryUEUslugi` = 8194 — Towary UE i usługi
- `TowaryNieUE` = 12288 — Towary nie UE
- `Opakowania` = 16384
- `NieOpakowania` = 20480
- `NabywcaPodatnik` = 32768
- `Odpady` = 65536
- `Gratis` = 73728
- `RazemZRecepturami` = 131072
- `TowaryKGO` = 262144 — Towary z KGO
