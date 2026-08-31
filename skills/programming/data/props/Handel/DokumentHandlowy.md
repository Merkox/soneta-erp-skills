# Pola i właściwości klasy biznesowej: `Soneta.Handel.DokumentHandlowy`
Nazwa tabeli: `DokHandlowe`
Tytuł: Dokumenty handlowe
Opis: Główna tabela dokumentów handlowych (faktury, paragony, zamówienia, korekty, umowy itp.). Zawiera dane nagłówkowe: kontrahenta, magazyn, daty, wartości, walutę, VAT, płatności oraz powiązania z definicją dokumentu.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentPlatny`, `IDokumentKsiegowalny`, `IDokumentKasowy`, `IDaneKontrahentaHost`, `IDokumentCRM`, `IKodowany`, `IExportImportXmlHost`, `IElementSlownika`, `IKomunikatEDIHost`, `IEmailElement`, `IProceduraVATHost`, `IZrodloOpisuAnalitycznego`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywneRelacje | `Soneta.Handel.DefRelacjiHandlowej[]` | podlista |  |  |
| AktywneRelacje2 | `Soneta.Handel.DefRelacjiHandlowej[]` | podlista |  |  |
| Anulowany | `bool` | tylko-odczyt |  | Określa, czy dokument został anulowany. |
| BezKopiowania | `bool` |  |  |  |
| BruttoCy | `Currency` | bazodanowe | Kwota płatności | Kwota płatności dokumentu wyrażona w walucie. |
| Bufor | `bool` | tylko-odczyt |  | Określa, czy dokument jest jeszcze w buforze. |
| BuforNumer | `string` | tylko-odczyt |  | Pole informujące czy dokument jest w buforze wykorzystywane do numeracji dokumentów. |
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Określa stan opisów analitycznych przypiętych do dokumentu. |
| CechaPodzialuKosztuDodatkowego | `FeatureDefinition` | bazodanowe | Współczynnik podziału kosztu | Cecha licząca wspólczynnik podziału kosztu. |
| CenaNaPodrzedny | `bool` | bazodanowe |  | Określa, czy nadrzędny dokument ma narzucać cenę na rozliczający go podrzędny dokument. |
| Ceny | `Soneta.Handel.DokumentHandlowy.CenyDokumentu` | podlista |  | Kolekcja informacji o wartościach liczonych względem wskazanych cen. |
| Czas | `Time` | bazodanowe |  | Godzina wystawienia dokumentu. |
| CzestotliwoscRozliczania | `Soneta.Handel.CzestotliwoscRozliczania` (enum) | bazodanowe |  |  |
| DaneEParagonu | `Soneta.Handel.DaneEParagonu` | tylko-odczyt |  |  |
| DaneEwidencji | `Soneta.Handel.Interop.Ewidencja.IDaneEwidencji` | tylko-odczyt |  |  |
| DaneKontrahenta | `Soneta.Core.DaneKontrahenta` | tylko-odczyt |  |  |
| DaneOdbiorcy | `Soneta.Core.DaneKontrahenta` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  | Data wystawienia dokumentu. |
| DataKursu | `Date` | bazodanowe |  | Data, według której przeliczane są kursy walut. |
| DataOgłoszeniaKursu | `Date` |  |  |  |
| DataOperacji | `Date` | bazodanowe |  | Faktyczna data czynności (sprzedaży, zakupu, itp). |
| DataOtrzymania | `Date` |  |  |  |
| DataWystawieniaDokumentu | `Date` | tylko-odczyt |  |  |
| DataZasobu | `Date` | tylko-odczyt |  | Data wykonania operacji magazynowego, dla korekt przyjęcia to data pierwszego dokumentu korygowanego. |
| Definicja | `Soneta.Handel.DefDokHandlowego` | bazodanowe |  | Definicja dokumentu, określająca zachowanie się dokumentu w programie. |
| DefinicjaEwidencji | `Soneta.Core.DefinicjaDokumentu` | bazodanowe, tylko-odczyt | Definicja ewidencji | Informacja o miejscu umieszczenia dokumentu w ewidencji księgowej (sposobie księgowania). |
| Description | `string` | tylko-odczyt |  |  |
| DokumentHandlowyData | `Date` | tylko-odczyt |  | Data dokumentu handlowego (faktury), ale tylko wtedy gdy jest jedna taka sama dla wszystkich. |
| DokumentHandlowyNumer | `string` | tylko-odczyt |  | Numer dokumentu handlowego (faktury), ale tylko wtedy gdy jest jeden dokument handlowy. |
| DokumentKaucji | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Pierwszy dokument odpowiadający wydaniu lub przyjęciu kaucji. |
| DokumentKorygowany | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Dokument korygowany przez aktualny dokument. |
| DokumentKorygowanyPierwszy | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Pierwszy dokument korygowany przez aktualny dokument. Jeżeli jest wiele korekt, to jest to faktura. |
| DokumentKorygujący | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Dokument korygujący aktualny dokument. |
| DokumentKorygującyOstatni | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Ostani z 'listy' dokument korygujący aktualny dokument. |
| DokumentMagazynowyData | `Date` | tylko-odczyt |  | Data dokumentu magazynowego, ale tylko wtedy gdy jest jedna taka sama dla wszystkich. |
| DokumentMagazynowyGłówny | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Główny dokument magazynowy przypisany do dokumentu handlowego. |
| DokumentMagazynowyNumer | `string` | tylko-odczyt |  | Numer dokumentu magazynowego, ale tylko wtedy gdy jest jeden dokument magazynowy. |
| DokumentRezerwujący | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Dokument rezerwujący, który na podstawie którego została wygenerowana ta rezerwacja. |
| DokumentZaliczkowyOstatni | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| DokumentyHandlowe | `Soneta.Handel.DokumentHandlowy[]` | podlista |  | Dokument handlowy odpowiadający dokumentowi magazynowemu, zamówieniu lub ofercie. |
| DokumentyKaucji | `Soneta.Handel.DokumentHandlowy[]` | podlista |  | W przypadku odwróconego obiegu zwraca listę dokumentów kaucji powiązanych z dokumentami magazynowymi.W przypadku zwykłego obiegu zwraca dokument z właściwości DokumentKaucji. |
| DokumentyKorygowane | `System.Collections.Generic.IEnumerable<Soneta.Handel.DokumentHandlowy>` | podlista |  | Wszystkie dokumenty korygowane przez ten dokument korygujący. |
| DokumentyKorygowaneBezposrednio | `System.Collections.Generic.IEnumerable<Soneta.Handel.DokumentHandlowy>` | podlista |  | Dokumenty korygowane przez aktualny dokument (sąsiednie). |
| DokumentyKorygowanePierwsze | `System.Collections.Generic.IEnumerable<Soneta.Handel.DokumentHandlowy>` | podlista |  |  |
| DokumentyKorygujące | `System.Collections.Generic.IEnumerable<Soneta.Handel.DokumentHandlowy>` | podlista |  | Wszystkie dokumenty korygujące ten dokument. |
| DokumentyMagazynowe | `Soneta.Handel.DokumentHandlowy[]` | podlista |  | Dokumenty magazynowe odpowiadające dokumentowi handlowemu. |
| DokumentyZaliczkowe | `Soneta.Handel.DokumentHandlowy[]` | podlista |  | Lista dokumentów nadrzędnych, zaliczkowych, których sposób liczenia VAT jest proporcjonalny. |
| Dostawa | `Soneta.Handel.DokumentDostawa` (subrow) | bazodanowe |  | Inforamacja o dostawie towaru. |
| Dostawa.Cykl | `Soneta.Core.DefinicjaCyklu` (subrow) | bazodanowe |  | Określa cykl/częstotliwość terminu dostawy. |
| Dostawa.Odpowiedzialny | `string` | bazodanowe |  | Określa osobę odpowiedzialną za realizację dostawy. |
| Dostawa.Sposob | `string` | bazodanowe |  | Określa sposób dostarczenia towaru. |
| Dostawa.Termin | `Date` | bazodanowe |  | Termin realizacji dostawy. |
| EDokumentInfo | `Soneta.Handel.EDokument` (subrow) | bazodanowe |  |  |
| EDokumentInfo.Archiwum | `Soneta.Handel.EDokumentArchiwum` (enum) | bazodanowe | Rodzaj archiwum | Określa rodzaj archiwum, do którego wysłano dokument. |
| EDokumentInfo.Podpisany | `bool` | bazodanowe |  | Określa, czy dokument został podpisany podpisem elektronicznym. |
| EDokumentInfo.Rodzaj | `Soneta.Handel.EDokumentRodzaj` (enum) | bazodanowe | Rodzaj e-dokumentu | Określa rodzaj e-dokumentu. |
| EDokumentInfo.Status | `Soneta.Handel.EDokumentStatus` (enum) | bazodanowe |  | Określa status e-dokumentu (etap przetwarzania). |
| EDokumentInfo.StatusData | `Date` | bazodanowe | Data zmiany statusu | Określa datę zmiany statusu. |
| EParagon | `bool` | bazodanowe | e-paragon | e-paragon |
| EParagonAdresEmail | `string` | bazodanowe | e-paragon adres e-mail | Asres e-mail, na który zostanie wysłany e-paragon. |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| EliminujPlatnosc | `bool` | tylko-odczyt |  |  |
| EmailInfo | `Soneta.CRM.EmailInfo` | tylko-odczyt |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| EwidencjaZbiorcza | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| FiltrZasobow | `string` | bazodanowe |  | Filtr zawężający listę zasobów do pobrania. |
| Flags | `Soneta.Handel.Helpers.Flags` (enum) | bazodanowe |  | Flagi dodatkowe. |
| GrupyTowaroweVat | `System.Collections.Generic.IEnumerable<Soneta.Core.ProceduraVAT>` | podlista |  |  |
| ImportExportKSeF | `Soneta.Core.ImportExportXml` | tylko-odczyt |  |  |
| ImportExportXmls | `System.Collections.Generic.IEnumerable<Soneta.Core.ImportExportXml>` | podlista |  |  |
| InnePlatnosci | `SubTable<Soneta.Handel.RelacjaInnaPlat>` | podlista |  |  |
| InnyPłatnik | `bool` | tylko-odczyt |  |  |
| InwentaryzacjaInfo | `Soneta.Handel.InwentaryzacjaInfo` (subrow) | bazodanowe | Reguły dotyczące inwentaryzacji. | Ustawienie sposobu obsługi inwentaryzacji. |
| InwentaryzacjaInfo.BlokowanieTowarow | `bool` | bazodanowe | Blokada inwentaryzowanych towarów | Wskazuje na to, czy użycie inwentaryzowanych towarów na dokumentach magazynowych będzie blokowane? |
| IsRachunekBankowy | `bool` | tylko-odczyt |  |  |
| IsRachunekBankowy2 | `bool` | tylko-odczyt |  |  |
| JestFiltrZasobow | `bool` | tylko-odczyt |  |  |
| JestKorektaRabatowa | `bool` | tylko-odczyt |  |  |
| JestRabat | `bool` | tylko-odczyt |  |  |
| JestSWW | `bool` | tylko-odczyt |  |  |
| JestUnijny | `bool` | tylko-odczyt |  | Określa, czy dokument jest unijny, wymagający wprowadzenia dodatkowych informacji dla deklaracji Intrastat. |
| JestWskazaniePartiiPrzyZatwierdzaniu | `bool` | tylko-odczyt |  |  |
| JestZagraniczny | `bool` | tylko-odczyt |  | Określa, czy dokument jest zagraniczny z możliwością zastosowania stawki 0% (nie krajowy). |
| KSeFKomunikat | `Soneta.Core.KSeFKomunikat` | bazodanowe | Komunikat KSeF | Komunikat KSeF |
| KSeFPlik | `Soneta.Core.KSeFPlik` | tylko-odczyt |  |  |
| Kategoria | `Soneta.Handel.KategoriaHandlowa` (enum) | bazodanowe, tylko-odczyt |  | Kategoria dokumentów grupująca dokumenty na liście. |
| KierunekMagazynu | `Soneta.Magazyny.KierunekPartii` (enum) | bazodanowe, tylko-odczyt |  | Określa kierunek operacji magazynowej. |
| KodDoEParagonu | `string` | bazodanowe | Kod do e-paragonu | Kod do e-paragonu |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` | tylko-odczyt |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  | Kontrahent, któremu przyporządkowany jest dokument. |
| Korekta | `bool` | bazodanowe |  | Określa, czy dokument stanowi korektę innego dokumentu. |
| KorektaDanychNabywcy | `bool` | tylko-odczyt |  |  |
| KorektaDanychOdbiorcy | `bool` | tylko-odczyt |  |  |
| KorektaPlatnosci | `bool` | tylko-odczyt |  |  |
| KorektaRabatowa | `bool` | tylko-odczyt |  |  |
| KorektaVAT | `bool` | bazodanowe |  | Określa, czy sumy VAT zostały zmienione ręcznie i nie zależą od pozycji dokumentu. |
| KosztFakturowy | `decimal` |  |  | Koszt faktrurowy PLN towaru raportowany na deklarcji Intrastat. |
| KosztMagazynowy | `decimal` |  |  | Koszt magazynowy PLN towaru, która może być przenoszony do dokumentu magazynowego. |
| KosztStatystyczny | `decimal` |  |  | Koszt statystyczny PLN towaru raportowany na deklarcji Intrastat. |
| KosztyDodatkowe | `SubTable<Soneta.Handel.DokumentHandlowyKoszt>` | podlista |  |  |
| KrajPochodzenia | `string` |  |  | Kod kraju pochodzenia towaru |
| KrajPochodzeniaNazwa | `string` | tylko-odczyt |  | Pełna nazwa kraju pochodzenia towaru |
| KrajPodatkuVat | `Soneta.Core.KrajTbl` | bazodanowe, tylko-odczyt |  | Informacja o kraju, którego stawki VAT zostały zastosowane, czyli o kraju, w którym podatek jest należny. |
| KrajPrzeznaczenia | `string` |  |  | Kod kraju przeznaczenia przesyłki raportowany na dokumencie Intrastat. |
| KrajPrzeznaczeniaNazwa | `string` | tylko-odczyt |  | Pełna nazwa kraju przeznaczenia towaru raportowanego na deklaracji Intrastat. |
| KrajWydania | `Soneta.Core.KrajTbl` | tylko-odczyt |  |  |
| KursWaluty | `double` | bazodanowe |  | Wartość kursu waluty płatności. |
| KursWalutyEtykieta | `string` | tylko-odczyt |  | Tekstowa etykieta informująca walutach w kursie. |
| KursWartościInfo | `string` | tylko-odczyt |  | Zawiera informację o kursie waluty wartości dokumentu. |
| KursyWalut | `System.Collections.IEnumerable` | tylko-odczyt |  |  |
| KwotaRabatu | `Currency` |  |  | Suma rabatów wszystkich pozycji na dokumencie lub wartość pusta jeżeli są różne waluty. |
| LiczonaOd | `Soneta.Handel.SposobLiczeniaVAT` (enum) | bazodanowe |  | Sposób liczenia wartości dokumentu: od ceny netto lub brutto. |
| MPP | `bool` | bazodanowe, tylko-odczyt | Mechanizm podzielonej płatności | Wymaga mechanizmu podzielonej płatności. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe |  | Magazyn, na który wpływa dokument. |
| MagazynDo | `Soneta.Magazyny.Magazyn` |  |  | Magazyn docelowy, do którego jest realizowane przesunięcie magazynowe. |
| MagazynZ | `Soneta.Magazyny.Magazyn` | bazodanowe | Magazyn źródłowy | Magazyn źródłowy. |
| MailTo | `string` | tylko-odczyt |  |  |
| MaxIdent | `int` | bazodanowe |  |  |
| MiejsceSwiadczenia | `string` | bazodanowe |  | Miejsce świadczenia (kraj) dostawy towaru, usługi determinujący miejsce opodatkowania. |
| MiejsceSwiadczeniaNazwa | `string` | tylko-odczyt |  | Pełna nazwa kraju miejsca świadczenia dostawy towaru, usługi. |
| NadrzednePozycje | `SubTable<Soneta.Handel.PozycjaRelacjiHandlowej>` | podlista |  |  |
| NadrzedneRelacje | `SubTable<Soneta.Handel.RelacjaHandlowa>` | podlista |  |  |
| NadrzedneWithRights | `System.Collections.Generic.IEnumerable<Soneta.Handel.DokumentHandlowy>` | podlista |  |  |
| NadrzednyWithRights | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  |  |
| Nadrzędne | `Soneta.Handel.DokumentHandlowy.DokumentySubTable.Nadrzędne` | podlista |  | Kolekcja informacji o dokumentach podrzędnych i relacjach do nich. |
| NadrzędneSumyVAT | `System.Collections.IList` | podlista |  |  |
| NieruchomosciUzyte | `SubTable` | podlista |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  | Informacje o numerze dokumentu (numeracja). |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerPelnyZapisany | `string` | bazodanowe |  | Numer dokumentu, wykorzystywany do zapisania numeru dokumentu. |
| NumerRachunkuBankowego | `string` | tylko-odczyt |  |  |
| Obcy | `Soneta.Handel.DokumentObcy` (subrow) | bazodanowe |  | Inforamacja o dokumencie obcym, pochodzącym od kontrahenta. |
| Obcy.DataOtrzymania | `Date` | bazodanowe | Data obcego | Data otrzymania dokumentu obcego od kontrahenta. |
| Obcy.Dokument | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  |  |
| Obcy.Numer | `string` | bazodanowe | Numer obcy | Numer dokumentu obcego nadany przez kontrahenta. |
| Obcy.WgNumer | `Key` | podlista |  |  |
| Obroty | `SubTable` | podlista |  | Obroty związane bezpośrednio z dokumentem. |
| ObrotyWszystkie | `ListWithView` | podlista |  | Wszystkie obroty związane z dokumentem, łącznie z obrotami dokumentów zależnych (bez storno zasobu). |
| ObrotyWszystkiePozycji | `ListWithView` | podlista |  | Wszystkie obroty związane z pozycjami dokumentu, łącznie z obrotami pozycji zależnych (bez storn zasobu). |
| ObrotyWszystkieWgPartiiPierwotnej | `ListWithView` | podlista |  | Wszystkie obroty związane z dokumentem, łącznie z obrotami dokumentów zależnych i korygujących (bez storno zasobu). |
| OdBrutto | `bool` | tylko-odczyt |  |  |
| Odbiorca | `Soneta.CRM.Kontrahent` | bazodanowe |  | Odbiorca towarów z dokumentu. |
| OdbiorcaMiejsceDostawy | `Soneta.CRM.Lokalizacja` | bazodanowe | Miejsce dostawy | Lokalizacja odbiorcy będąca miejscem docelowym dostawy. |
| Okres | `FromTo` | bazodanowe, podlista | Okres | Okres |
| OkresIntrastat | `Date` | bazodanowe |  | Data decydująca o miesiącu, w którym dokument zostanie uwzględniony na deklaracji Intrastat. |
| OkresObrachunkowy | `FromTo` | podlista |  |  |
| OkresyZawieszenia | `LpSubTable` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis dokumentu umiejscowiony na wydruku. |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| OpisyAnalityczne | `ListWithView` | podlista |  |  |
| Osoba | `string` | bazodanowe |  | Osoba podpisująca dokument (fakturę) w imieniu kontrahenta. |
| OsobaKontrahenta | `Soneta.CRM.KontaktOsoba` | bazodanowe |  | Osoba koordynująca dostawę po stronie kontrahenta. |
| OstatniOkresZawieszenia | `FromTo` | podlista |  |  |
| Paczki | `SubTable<Soneta.Handel.Paczka>` | podlista |  |  |
| ParagonZostałWydrukowany | `bool` | tylko-odczyt |  |  |
| ParametryRezerwacjiProxy | `Soneta.Magazyny.ParametryRezerwacjiProxy` | tylko-odczyt |  |  |
| ParametryRezerwacjiProxyInicjalizacjaPozycji | `Soneta.Magazyny.ParametryRezerwacjiProxy` | tylko-odczyt |  |  |
| PierwszaPrzesylka | `Soneta.Handel.PrzesylkaSpedyt` | tylko-odczyt |  |  |
| Platnosci | `SubTable<Soneta.Kasa.Platnosc>` | podlista |  |  |
| PodlegaKSeF | `bool` | tylko-odczyt | Podlega wysyłce KSeF |  |
| PodrzednePozycje | `SubTable<Soneta.Handel.PozycjaRelacjiHandlowej>` | podlista |  |  |
| PodrzedneRelacje | `SubTable<Soneta.Handel.RelacjaHandlowa>` | podlista |  |  |
| PodrzedneWithRights | `System.Collections.Generic.IEnumerable<Soneta.Handel.DokumentHandlowy>` | podlista |  |  |
| Podrzędne | `Soneta.Handel.DokumentHandlowy.DokumentySubTable.Podrzędne` | podlista |  | Kolekcja informacji o dokumentach nadrzędnych i relacjach do nich. |
| PodrzędneInfo | `string` | tylko-odczyt | Podrzędne | Informacja o rozliczeniu relacji do dokumentów podrzędnych. |
| PodzialKosztuDodatkowego | `Soneta.Handel.PodzialKosztuDodatkowego` (enum) | bazodanowe | Sposób podziału kosztu | Sposób podziału kosztu dodatkowego. |
| Poprawiajacy | `App.Operator` | bazodanowe | Poprawiający | Operator, który jest w trakcie poprawiania dokuentu, będącego podstawowym dla tej rezerwacji. |
| PosiadaKSeF | `bool` | tylko-odczyt |  |  |
| PosiadaObrotyMagazynowe | `bool` | tylko-odczyt |  | Informuje, czy dokument w swoim aktualnym stanie może posiadać obroty w magazynie. |
| Potwierdzenie | `Soneta.Handel.PotwierdzenieDokumentuHandlowego` (enum) | bazodanowe |  | Określa stan potwierdzenia dokumentu handlowego, który można zmieniać również dla dokumentu zatwierdzonego. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Pozycje | `LpSubTable<Soneta.Handel.PozycjaDokHandlowego>` | podlista |  |  |
| PozycjeEwidencji | `SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` | podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  | Pracownik, który utworzył dokument, wykorzystywany przy numeracji dokumentu. |
| PrecyzjaCeny | `Soneta.Towary.PrecyzjaCeny` (subrow) | bazodanowe |  | Konfiguracja określania precyzji ceny na pozycji dokumentu handlowego. |
| PrecyzjaCeny.Precyzja | `int` | bazodanowe |  | Precyzja zaokrąglenia (wyliczania) cen towaru |
| PrecyzjaCeny.Wymuszaj | `bool` | bazodanowe |  | Wskazuje na to, że precyzja ceny ustalona na definicji ma pierwszeńśtwo przed precyzją ceny na kartotece towaru |
| ProcedurySprzedazVat | `System.Collections.Generic.IEnumerable<Soneta.Core.RelProceduraVAT>` | podlista |  |  |
| ProceduryVAT | `SubTable<Soneta.Core.RelProceduraVAT>` | podlista |  |  |
| ProceduryZakupVat | `System.Collections.Generic.IEnumerable<Soneta.Core.RelProceduraVAT>` | podlista |  |  |
| ProdukcjaInfo | `Soneta.Handel.ProdukcjaInfo` (subrow) | bazodanowe |  |  |
| ProdukcjaInfo.IdentyfikatorElementuPowiazanego | `System.Guid` | bazodanowe | Identyfikator elementu powiązanego | Dla pozycji GUID pozycji technologii (dla ZP i PWP - produkt, dla RWP - surowiec). |
| ProdukcjaInfo.PozycjaTechnologii | `Soneta.Produkcja.PozycjaTechn` | tylko-odczyt |  |  |
| ProdukcjaInfo.Technologia | `Soneta.Produkcja.Technologia` |  |  |  |
| ProdukcjaInfo.WgIdentyfikatorElementuPowiazanego | `Key` | podlista |  |  |
| PrzesylkiDokRelacje | `SubTable<Soneta.Handel.PrzesylkaDokRel>` | podlista |  |  |
| PrzesylkiSpedytor | `SubTable<Soneta.Handel.PrzesylkaSpedyt>` | podlista |  |  |
| QRCodeLink | `string` | tylko-odczyt |  |  |
| Rabat | `Percent` | bazodanowe |  | Proponowany rabat, który jest przepisywany do pozycji dokumentu. |
| RabatZaTerminPlatnosci | `Soneta.Handel.RabatZaTerminPlatnosci` (subrow) | bazodanowe | Rabat za wcześniejszy termin płatności |  |
| RabatZaTerminPlatnosci.Rabat | `Percent` | bazodanowe, tylko-odczyt | Rabat za wcześniejszą płatność |  |
| RabatZaTerminPlatnosci.Rodzaj | `Soneta.CRM.RodzajRabatuZaTerminPlatnosci` (enum) | bazodanowe, tylko-odczyt | Rodzaj rabatu |  |
| RabatZaTerminPlatnosci.Termin | `Date` | bazodanowe | Termin płatności |  |
| RachunekBankowy | `Soneta.Kasa.EwidencjaSP` | tylko-odczyt |  |  |
| RachunekBankowy2 | `Soneta.Kasa.EwidencjaSP` | tylko-odczyt |  |  |
| Realizacja | `Soneta.Handel.Realizacja` (subrow) | bazodanowe |  | Stan, wynik realizacji |
| Realizacja.Niezgodnosc | `Soneta.Handel.NiezgodnoscRealizacji` (enum) | tylko-odczyt |  |  |
| Realizacja.Stan | `Soneta.Handel.StanRealizacji` (enum) | bazodanowe | Stan realizacji |  |
| Realizacja.Wynik | `Soneta.Handel.WynikRealizacji` (enum) | bazodanowe, tylko-odczyt | Wynik realizacji |  |
| RecznyRodzajKorekty | `bool` |  |  |  |
| Rezerwacja | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Dokument rezerwacji, który rezerwuje towary dla tego dokumentu handlowego. |
| RezerwacjaIlosciowa | `bool` | tylko-odczyt | Rezerwacja ilościowa |  |
| RezerwacjaWSesji | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Dokument rezerwacji, który rezerwuje towary dla tego dokumentu handlowego zawsze w aktualnej sesji. |
| RodzajKorekty | `string` |  |  |  |
| RodzajKorektyAuto | `int` | bazodanowe |  |  |
| RodzajKorektyOpis | `MemoText` | bazodanowe, podlista |  |  |
| RodzajPlatnosciKaucji | `Soneta.CRM.RodzajPlatnosciKaucji` (enum) | bazodanowe |  | Określa sposób naliczania płatności na dokumecie kaucji. |
| RodzajTransakcji | `Soneta.Handel.KodRodzajuTransakcji` (enum) | bazodanowe |  | Rodzaj transakcji wykazywany w deklaracji Intrastat. |
| RodzajTransportu | `Soneta.Handel.KodRodzajuTransportu` (enum) | bazodanowe |  | Kod rodzaju transportu w deklaracji Intrastat. |
| RolaOdbiorcyPodmiotu3KSeF | `Soneta.Core.KSeFPodmiot3` | tylko-odczyt |  |  |
| RozliczoneZaliczki | `System.Collections.ICollection` | podlista |  |  |
| Seria | `string` | bazodanowe |  | Seria dokumentu, wykorzystywana do numeracji dokumentu. |
| SeriaZapisana | `string` | bazodanowe |  | Seria dokumentu, wykorzystywana do zapisania serii dokumentu. |
| SposobPrzenoszeniaZaliczki | `Soneta.Handel.SposobPrzenoszeniaZaliczki` (enum) | bazodanowe |  | Określa sposób, w jaki faktura zaliczkowa jest rozliczana przez dokument końcowy. |
| SposobRozliczaniaNadrzednego | `Soneta.Handel.SposobRozliczaniaNadrzednego` (enum) | bazodanowe |  | Określa, czy zmiany na tym dokumencie będą powodowały zmiany w rozliczeniu, które ten dokument powoduje względem dokumentu nadrzędnego. |
| Stan | `Soneta.Handel.StanDokumentuHandlowego` (enum) | bazodanowe |  | Określa stan dokumentu handlowego (w buforze, zatwierdzony, zablokowany, anulowany). |
| StanRealizacji | `Soneta.Handel.StanRealizacji` (enum) |  |  | Stan realizacji zlecenia produkcyjnego. |
| StatusKSeF | `Soneta.Core.KSeF.KSeFState` (enum) | tylko-odczyt | Status KSeF |  |
| StatusUmowy | `Soneta.Handel.StatusUmowy` (enum) | tylko-odczyt |  |  |
| StatusZewn | `Soneta.Core.SysZewnStatus` | bazodanowe | Status zewnętrzny | Status w systemie zewnętrznym |
| StatusZewnętrznyKod | `string` | tylko-odczyt | Status zewnętrzny - kod |  |
| StatusZewnętrznyNazwa | `string` | tylko-odczyt | Status zewnętrzny - nazwa |  |
| Suma | `Soneta.Handel.BruttoNetto` (subrow) | bazodanowe |  | Podsumowana wartość dokumentu. |
| Suma.Brutto | `decimal` | bazodanowe |  | Wartość brutto. |
| Suma.BruttoCy | `Currency` | tylko-odczyt |  | Wartość brutto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.JestZero | `bool` | tylko-odczyt |  |  |
| Suma.Netto | `decimal` | bazodanowe |  | Wartość netto. |
| Suma.NettoCy | `Currency` | tylko-odczyt |  | Wartość netto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.VAT | `decimal` | bazodanowe |  | Kwota podatku VAT. |
| Suma.VATCy | `Currency` | tylko-odczyt |  | Wartość podatku VAT wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| SumaBezDup | `Soneta.Handel.DokumentHandlowy.BruttoNettoPozycji` | tylko-odczyt |  | Podsumowana wartość dokumentu, która dla dokumentu będącego duplikatem jest zerem. |
| SumaPoKorekcie | `Soneta.Handel.DokumentHandlowy.SumaKorektyDokumentu` | tylko-odczyt |  |  |
| SumaPozycji | `Soneta.Handel.DokumentHandlowy.BruttoNettoPozycji` | tylko-odczyt |  | Wyliczana suma wartości pozycji dokumentu. |
| SumaPozycjiTowProd | `Soneta.Handel.DokumentHandlowy.BruttoNettoPozycji` | tylko-odczyt |  | Wyliczana suma wartości pozycji towarowych i produktowych dokumentu. |
| SumaPrzedKorektą | `Soneta.Handel.DokumentHandlowy.SumaPrzedKorektąDokumentu` | tylko-odczyt |  |  |
| SumaWgTowarów | `System.Collections.Generic.IDictionary<Soneta.Towary.Towar, Soneta.Towary.Quantity>` | podlista |  |  |
| SumyVAT | `SubTable<Soneta.Handel.SumaVAT>` | podlista |  |  |
| SymbolAneksu | `string` | tylko-odczyt |  | Symbol dokumentu korygowanego uzupełniony z przodu o literę A. |
| SymbolKasy | `string` | bazodanowe |  | Symbol drukarki fiskalnej, na której wykonano fiskalizację. |
| SymbolKorekty | `string` | tylko-odczyt |  | Symbol dokumentu korygowanego uzupełniony z przodu o literę K. |
| SzablonPolOpcjonalnychInfo | `Soneta.KSeF.KSeFSzablonPolOpcjonalnychInfo` | tylko-odczyt |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  | Tabela kursowa, wg której przeliczane są kwoty w walucie. |
| TechnologiaRow | `Soneta.Produkcja.Technologia` | tylko-odczyt |  |  |
| Technologie | `SubTable<Soneta.Produkcja.Technologia>` | podlista |  |  |
| TerminDoPrzeslaniaFakturyOffline | `Date` | tylko-odczyt | Termin do przesłania faktury offline |  |
| TerminRozliczeniaKaucji | `Date` | bazodanowe |  | Termin rozliczenia kaucji, na podstawie ustawień kontrahenta. |
| Transakcja | `Soneta.CRM.Transakcja` | bazodanowe |  | Transakcja, do której przyporządkowany jest dokument. |
| TypPartii | `Soneta.Magazyny.TypPartii` (enum) | bazodanowe, tylko-odczyt |  | Określa jakiego typu partia towaru będzie generowana na magazyn. |
| TypTerminuRozliczenia | `Soneta.Handel.TypTerminuRozliczenia` (enum) | bazodanowe |  |  |
| UmowaInfo | `Soneta.Handel.UmowaInfo` (subrow) | bazodanowe |  | Dane właściwe dla umowy. |
| UmowaInfo.Aneks | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Ostatni aneks do umowy. |
| UmowaInfo.Cykl | `Soneta.Core.DefinicjaCyklu` (subrow) | bazodanowe |  | Określa cykl/częstotliwość fakturowania umowy. |
| UmowaInfo.Cykl.AlgorytmCykluInstance | `Soneta.Core.IAlgorytmCyklu` | tylko-odczyt |  | Instancja skompilowanego kalkulatora. |
| UmowaInfo.Cykl.Czas | `Time` | bazodanowe |  | Określa czas wystąpienia cyklu. |
| UmowaInfo.Cykl.Czerwiec | `bool` |  |  | Czerwiec - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Czwartek | `bool` |  |  | Czwartek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.DataKoniecCyklu | `bool` | bazodanowe |  | Data wystąpienia w ostatnim miesiącu/roku okresu |
| UmowaInfo.Cykl.Dzien | `Date` |  |  | Data rozpoczęcia wykonywania cyklu. |
| UmowaInfo.Cykl.DzienCzas | `System.DateTime` | tylko-odczyt |  |  |
| UmowaInfo.Cykl.DzienMiesiaca | `int` |  |  | Dzień w miesiącu wystąpienia cyklu miesięcznego lub rocznego. |
| UmowaInfo.Cykl.DzienTygodnia | `Soneta.Core.DefinicjaCykluDzienTygodnia` |  |  | W zaawansowanej wersji dzień tygodnia. |
| UmowaInfo.Cykl.Godzina | `int` |  |  | Godzina wystąpienia cyklu. |
| UmowaInfo.Cykl.Godziny | `string[]` | podlista |  | Wybrane godziny w trybie godzinowym. |
| UmowaInfo.Cykl.Grudzien | `bool` |  |  | Grudzień - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Interwal | `int` | bazodanowe |  |  |
| UmowaInfo.Cykl.IsAdvanced | `bool` | tylko-odczyt |  |  |
| UmowaInfo.Cykl.IsMultiSelect | `bool` | tylko-odczyt |  |  |
| UmowaInfo.Cykl.IsSingleSelect | `bool` | tylko-odczyt |  |  |
| UmowaInfo.Cykl.JestAlgorytm | `bool` | tylko-odczyt |  |  |
| UmowaInfo.Cykl.JestOpcjaZaawansowana | `bool` | tylko-odczyt |  |  |
| UmowaInfo.Cykl.JestTermin | `bool` | tylko-odczyt |  |  |
| UmowaInfo.Cykl.KodAlgorytmu | `string` |  |  | Kod algorytmu wyliczania wystąpień cyklu. |
| UmowaInfo.Cykl.Krotnosc | `int` | bazodanowe |  | Określa ile razy cykl będzie powtórzony. |
| UmowaInfo.Cykl.Kwiecien | `bool` |  |  | Kwiecień - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Lipiec | `bool` |  |  | Lipiec - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Listopad | `bool` |  |  | Listopad - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Luty | `bool` |  |  | Luty - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Maj | `bool` |  |  | Maj - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Marzec | `bool` |  |  | Marzec - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.MiesiacRoku | `Soneta.Core.DefinicjaCykluMiesiacRoku` (enum) |  |  | W zaawansowanej wersji miesiąc w roku. |
| UmowaInfo.Cykl.MinutaGodziny | `int` |  |  | Minuta w godzinie wystąpienia cyklu godzinowego. |
| UmowaInfo.Cykl.Niedziela | `bool` |  |  | Niedziela - dzień tygodnia wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.OkresCyklu | `Soneta.Core.DefinicjaCykluOkresCyklu` (enum) | bazodanowe |  | Określa okres, w którym oczekiwane jest wystąpienie cyklu. |
| UmowaInfo.Cykl.Options | `Soneta.Core.DefinicjaCykluOptions` (enum) | tylko-odczyt |  |  |
| UmowaInfo.Cykl.Pazdziernik | `bool` |  |  | Październik - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Piatek | `bool` |  |  | Piątek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Podglad | `Soneta.Core.ElementCyklu` | tylko-odczyt |  |  |
| UmowaInfo.Cykl.Poniedzialek | `bool` |  |  | Poniedziałek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.PozycjaDnia | `Soneta.Core.DefinicjaCykluPozycjaDnia` (enum) | bazodanowe |  | Określa pozycję dnia w okresie, w którym oczekiwane jest wystąpienie cyklu. |
| UmowaInfo.Cykl.PozycjaDniaZaawansowana | `Soneta.Core.DefinicjaCykluPozycjaDniaZaawansowana` (enum) | bazodanowe |  | Określa pozycję dnia w miesiącu, w którym oczekiwane jest wystąpienie cyklu. |
| UmowaInfo.Cykl.RodzajTerminu | `Soneta.Core.DefinicjaCykluRodzajTerminu` (enum) | bazodanowe |  | Wskazuje na to, czy określono termin cyklu lub termin wynika z opisu cyklu. |
| UmowaInfo.Cykl.Sierpien | `bool` |  |  | Sierpień - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Sobota | `bool` |  |  | Sobota - dzień tygodnia wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.SposobNaDniWolne | `Soneta.Core.DefinicjaCykluSposobNaDniWolne` (enum) | bazodanowe |  | Określa sposób zachowania, kiedy cykl wystąpi w dniu wolnym. |
| UmowaInfo.Cykl.Sroda | `bool` |  |  | Środa - dzień tygodnia wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Styczen | `bool` |  |  | Styczeń - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Termin | `int` | bazodanowe |  | Określa termin wystąpienia cyklu. Wartość w polu nie jest czytelna dla użytkownika. |
| UmowaInfo.Cykl.Termin2 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (godziny). Wartość w polu nie jest czytelna dla użytkownika. |
| UmowaInfo.Cykl.Termin3 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (minuty w godzinie). Wartość w polu nie jest czytelna dla użytkownika. |
| UmowaInfo.Cykl.Termin4 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (dni w miesiącu/roku w kolejności). Wartość w polu nie jest czytelna dla użytkownika. |
| UmowaInfo.Cykl.Termin5 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (miesiące w roku w kolejności). Wartość w polu nie jest czytelna dla użytkownika. |
| UmowaInfo.Cykl.Typ | `Soneta.Core.DefinicjaCykluTyp` (enum) | bazodanowe |  | Określa rodzaj cyklu za pomocą jednostki interwału czasu. |
| UmowaInfo.Cykl.Wrzesien | `bool` |  |  | Wrzesień - miesiąc wystąpienia cyklu tygodniowego. |
| UmowaInfo.Cykl.Wtorek | `bool` |  |  | Wtorek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| UmowaInfo.DataOkresuRozliczeniowego | `Date` | bazodanowe |  | Określa datę początkową pierwszego okresu rozliczeniowego umowy. |
| UmowaInfo.Dokumenty | `ListWithView` | podlista |  |  |
| UmowaInfo.DomyslnyPodrzedny | `Soneta.Handel.DefDokHandlowego` | bazodanowe |  | Domyślna definicja dokumentu, który powstanie w procesie masowego fakturowania. |
| UmowaInfo.WgDomyslnyPodrzedny | `Key` | podlista |  |  |
| UmowaInfo.WgZuzycia | `bool` | bazodanowe |  |  |
| UrzadzeniaUzyte | `SubTable` | podlista |  |  |
| UsedVehicles | `SubTable` | podlista |  |  |
| UslugiDodatkowe | `SubTable<Soneta.Handel.UslDodPrzesyl>` | podlista |  |  |
| WalutaKontrahenta | `Soneta.Waluty.Waluta` | tylko-odczyt |  |  |
| WartośćFakturowa | `decimal` |  |  | Wartość faktrurowa PLN dokumentu raportowana na deklarcji Intrastat wyliczna przy pomocy kosztu fakturowego. |
| WartośćMagazynowa | `decimal` |  |  | Wartość magazynowa PLN dokumentu, która może być przenoszona do dokumentu magazynowego wyliczna przy pomocy kosztu magazynowego. |
| WartośćStatystyczna | `decimal` |  |  | Wartość statystyczna PLN dokumentu raportowana na deklarcji Intrastat wyliczna przy pomocy kosztu statystycznego. |
| WartośćWCenieZakupu | `decimal` | tylko-odczyt |  | Wartość w cenie zakupu. Dla korekt zmiana wartości zakupu. |
| WartośćWCenieZakupuBufor | `decimal` | tylko-odczyt |  | Wartość w cenie zakupu również dla niezatwierdzonych. Dla korekt zmiana wartości zakupu. |
| WartośćWCenieZakupuBuforKorygowana | `decimal` | tylko-odczyt |  | Wartość przyjęcia towaru wydawanego rozchodem, a dla korekt rozchodu różnica kosztu WartośćWCenieZakupuNarastająco z poprzedzającego wydania lub korekty i danego dokumentu. |
| WartośćWCenieZakupuKorygowana | `decimal` | tylko-odczyt |  | Wartość przyjęcia towaru wydawanego rozchodem, a dla korekt rozchodu różnica kosztu WartośćWCenieZakupuNarastająco z poprzedzającego wydania lub korekty i danego dokumentu. |
| WartośćWCenieZakupuNarastająco | `decimal` | tylko-odczyt |  | Bieżąca dla danego dokumentu wartość kosztu całkowitego, uwzględniająca poprzedzające dokument korekty kosztu KWPZ (bez późniejszych KWPZ i innych późniejszych zmian w transakcji). |
| WarunkiDostawy | `Soneta.Handel.WarunkiDostawy` (enum) | bazodanowe |  | Kod warunków dostawy towaru w deklaracji Intrastat. |
| Wersjonowanie | `Soneta.Handel.Wersjonowanie` (subrow) | bazodanowe | Wersjowanowanie dokumentu |  |
| Wersjonowanie.Ostatni | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  |  |
| Wersjonowanie.WaznaDo | `Date` | bazodanowe | Ważna do | Termin ważności oferty |
| Wersjonowanie.Wersja | `int` | bazodanowe | Wersja | Numer wersji oferty |
| Wersjonowanie.Zrodlowy | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Dokument źródłowy oferty |
| Wewnetrzny | `bool` | tylko-odczyt |  |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |
| Wydruk | `Soneta.Handel.WydrukDokumentu` | tylko-odczyt |  | Obiekt zawierający różnego rodzaju informację wykorzystywaną na wydruku dokumentu. |
| WygenerowanyDoKSeFWTrybieOffline | `bool` | tylko-odczyt |  |  |
| WymagalnoscKwotyVAT | `Soneta.Core.WymagalnoscKwotyVAT` (enum) | bazodanowe | Mechanizm podzielonej płatności |  |
| WysylajNipWPodmiocieTrzecimKSeFRoliOdbiorcy | `bool` | bazodanowe | Czy wysyłać NIP w podmiocie trzecim dla roli odbiorcy. | Czy wysyłać NIP w podmiocie trzecim dla roli odbiorcy. |
| ZadaniaCRM | `SubTable` | podlista |  |  |
| Zaliczki | `SubTable<Soneta.Handel.RelacjaZaliczki>` | podlista |  |  |
| ZaliczkiRelacje | `SubTable` | podlista |  |  |
| Zaplaty | `SubTable<Soneta.Kasa.Zaplata>` | podlista |  |  |
| ZapłataCałkowita | `Currency` | tylko-odczyt |  |  |
| Zasoby | `SubTable` | podlista |  | Zasoby na stanie magazynowym związane bezpośrednio z dokumentem. |
| ZasobyWgKategoriiDokumentu | `System.Collections.IList` | podlista |  |  |
| ZasobyWszystkie | `ListWithView` | podlista |  | Wszystkie zasoby na stanie magazynowym związane z dokumentem, łącznie z zasobami dokumentów zależnych. |
| ZasobyWszystkieWgPartiiPierwotnej | `ListWithView` | podlista |  | Wszystkie zasoby na stanie magazynowym związane z dokumentem, łącznie z zasobami dokumentów zależnych. |
| ZastosujRole5Podmiotu3KSeF | `bool` |  |  |  |
| ZastosujRole7Podmiotu3KSeF | `bool` |  |  |  |
| ZastosujRole9Podmiotu3KSeF | `bool` |  |  |  |
| ZastosujRoleOdbiorcyPodmiotu3KSeF | `bool` |  |  |  |
| Zatwierdzony | `bool` | tylko-odczyt |  | Określa, czy dokument został zatwierdzony lub zaksięgowany. |
| ZmianaParametrowZasobuInfo | `Soneta.Handel.ZmianaParametrowZasobuInfo` (subrow) | bazodanowe | Reguły doboru walut. | Ustawienia sposobu doboru walut dla: wartości pozycji, wartości dokumentu lub płatności. |
| ZmianaParametrowZasobuInfo.Cena | `DoubleCy` | tylko-odczyt | Org.Cena | Cena zasobu przed zmianą parametrów zasobu. |
| ZmianaParametrowZasobuInfo.Ilosc | `Soneta.Towary.Quantity` | bazodanowe, tylko-odczyt | Org.Ilość | Ilość zasobu przed zmianą parametrów zasobu. |
| ZmianaParametrowZasobuInfo.Netto | `decimal` | tylko-odczyt | Wartość netto | Wartość netto zasobu po zmianie. |
| ZmianaParametrowZasobuInfo.Wartosc | `decimal` | tylko-odczyt | Org.Wartość | Wartość zasobu przed zmianą parametrów zasobu. |
| ZmianaParametrowZasobuInfo.WartoscCy | `Currency` | bazodanowe, tylko-odczyt | Org.Wartość | Wartość zasobu przed zmianą parametrów zasobu. |
| ZmianaParametrowZasobuInfo.ZmianaNetto | `decimal` | tylko-odczyt | Zmiana netto | Zmiana wartości netto zasobu. |
| ZmianaParametrowZasobuInfo.ZmianaParametrowZasobu | `bool` | bazodanowe, tylko-odczyt | Zmiana parametrów zasobu | Określa, czy dokument umożliwia zmianę wartości (bez ilości) lub ilości (bez wartości) zasobu. |
| ext | `Soneta.Handel.ExternalInformation` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajPlatnosciKaucji (`Soneta.CRM.RodzajPlatnosciKaucji`)
- `Naliczaj` = 0 — Naliczaj dla wszystkich
- `NieNaliczaj` = 1 — Nie naliczaj dla wszystkich
- `NaliczajDlaOpakowan` = 2 — Naliczaj dla opakowań
- `NaliczajDlaSystemuKaucyjnego` = 3 — Naliczaj dla systemu kaucyjnego

### RodzajRabatuZaTerminPlatnosci (`Soneta.CRM.RodzajRabatuZaTerminPlatnosci`)
- `Brak` = 0
- `Dokument` = 1 — Udzielany na dokumencie
- `Wydruk` = 2 — Prezentowany na wydruku (skonto)

### DefinicjaCykluMiesiacRoku (`Soneta.Core.DefinicjaCykluMiesiacRoku`)
- `styczen` = 0 — styczniu
- `luty` = 1 — lutym
- `marzec` = 2 — marcu
- `kwiecien` = 3 — kwietniu
- `maj` = 4 — maju
- `czerwiec` = 5 — czerwcu
- `lipiec` = 6 — lipcu
- `sierpien` = 7 — sierpniu
- `wrzesien` = 8 — wrześniu
- `pazdziernik` = 9 — październiku
- `listopad` = 10 — listopadzie
- `grudzien` = 11 — grudniu

### DefinicjaCykluOkresCyklu (`Soneta.Core.DefinicjaCykluOkresCyklu`)
- `Poprzedni` = -1 — w poprzednim okresie
- `Biezacy` = 0 — w okresie fakturowanym
- `Nastepny` = 1 — w następnym okresie

### DefinicjaCykluOptions (`Soneta.Core.DefinicjaCykluOptions`)
- `None` = 0
- `IsRequired` = 1
- `HideOnce` = 256
- `HideDaily` = 512
- `HideWeekly` = 1024
- `HideMonthly` = 2048
- `HideYearly` = 4096
- `OnceOnly` = 466432
- `MultiSelect` = 8192
- `IsAdvanced` = 16384
- `HideMinutly` = 65536
- `HideHourly` = 131072
- `HideAlgorithm` = 262144

### DefinicjaCykluPozycjaDnia (`Soneta.Core.DefinicjaCykluPozycjaDnia`)
- `Pierwszy` = 0 — pierwszy
- `Ostatni` = 100 — ostatni

### DefinicjaCykluPozycjaDniaZaawansowana (`Soneta.Core.DefinicjaCykluPozycjaDniaZaawansowana`)
- `Pierwszy` = 0 — pierwszy(a)
- `Drugi` = 1 — drugi(a)
- `Trzeci` = 2 — trzeci(a)
- `Czwarty` = 3 — czwarty(a)
- `Ostatni` = 4 — ostatni(a)

### DefinicjaCykluRodzajTerminu (`Soneta.Core.DefinicjaCykluRodzajTerminu`)
- `Wskazany` = 0 — Wskazany
- `WgOpisu` = 1
- `OpcjaZaawansowana` = 2

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

### KSeFState (`Soneta.Core.KSeF.KSeFState`)
- `NieDotyczy` = 1 — Nie dotyczy
- `Brak` = 2
- `DoWyslania` = 4 — Do wysłania
- `Wyslany` = 8 — Wysłany
- `Przyjety` = 16 — Przyjęty
- `Odrzucony` = 32
- `Robocze` = 14
- `Razem` = 31

### WymagalnoscKwotyVAT (`Soneta.Core.WymagalnoscKwotyVAT`)
- `Brak` = 0
- `WgPozycjiMPP` = 16 — Wg pozycji MPP dokumentu
- `VATCalkowity` = 32 — Całkowita kwota VAT dokumentu

### CzestotliwoscRozliczania (`Soneta.Handel.CzestotliwoscRozliczania`)
- `Nieokreślona` = 0
- `Jednorazowa` = 1
- `Dzienna` = 2
- `Tygodniowa` = 3
- `Dwutygodniowa` = 4
- `Miesięczna` = 5
- `Kwartalna` = 6
- `Roczna` = 7
- `MiesięcznaNaDzień` = 8 — Miesięczna na dzień
- `Półroczna` = 9

### EDokumentArchiwum (`Soneta.Handel.EDokumentArchiwum`)
- `Brak` = 0 — Brak
- `GreenMail24` = 1 — GreenMail24
- `PEF` = 2 — PEF

### EDokumentRodzaj (`Soneta.Handel.EDokumentRodzaj`)
- `NieDotyczy` = 0 — Nie dotyczy
- `EFaktura` = 10 — e-Faktura
- `Obraz` = 20 — Obraz

### EDokumentStatus (`Soneta.Handel.EDokumentStatus`)
- `Brak` = 0 — Brak
- `Utworzony` = 10
- `Wychodzący` = 20
- `Wysłany` = 30
- `Niedostarczony` = 40
- `Dostarczony` = 50
- `Błąd` = 60
- `Odczytany` = 70

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

### NiezgodnoscRealizacji (`Soneta.Handel.NiezgodnoscRealizacji`)
- `Brak` = 0
- `Nierozliczona` = 1
- `Rozliczona` = 2
- `NiePodlega` = 3
- `Razem` = 999

### PodzialKosztuDodatkowego (`Soneta.Handel.PodzialKosztuDodatkowego`)
- `Wartosc` = 0 — Wartość
- `Masa` = 1
- `Cecha` = 2

### PotwierdzenieDokumentuHandlowego (`Soneta.Handel.PotwierdzenieDokumentuHandlowego`)
- `Niepotwierdzony` = 0
- `Potwierdzony` = 1
- `Zaakceptowany` = 2
- `Odrzucony` = 3

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

### StanDokumentuHandlowego (`Soneta.Handel.StanDokumentuHandlowego`)
- `Bufor` = 0
- `Zatwierdzony` = 1
- `Zablokowany` = 2
- `Anulowany` = 3

### StanRealizacji (`Soneta.Handel.StanRealizacji`)
- `Brak` = 0
- `Planowana` = 10
- `Rozpoczęta` = 20
- `Wstrzymana` = 30
- `Wznowiona` = 40
- `Zakończona` = 50
- `Anulowana` = 60
- `Wszystkie` = 999

### StatusUmowy (`Soneta.Handel.StatusUmowy`)
- `Aktywna` = 0 — Aktywna
- `Zawieszona` = 1
- `Zakończona` = 2

### TypTerminuRozliczenia (`Soneta.Handel.TypTerminuRozliczenia`)
- `PoczątekOkresu` = 0 — Początek okresu
- `KoniecOkresu` = 1 — Koniec okresu
- `PoczątekNastępnegoOkresu` = 2 — Początek następnego okresu
- `KoniecMiesiąca` = 3 — Koniec miesiąca

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

### WynikRealizacji (`Soneta.Handel.WynikRealizacji`)
- `Brak` = 0
- `Zgodna` = 10 — Zgodny
- `Niezgodna` = 20 — Niezgodny
- `Uzgodniona` = 30 — Uzgodniony
- `Wszystkie` = 999

### KierunekPartii (`Soneta.Magazyny.KierunekPartii`)
- `Rozchód` = -1 — Rozchód
- `Brak` = 0 — Brak
- `Przychód` = 1 — Przychód

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
