# Pola i właściwości klasy biznesowej: `Soneta.Handel.PozycjaDokHandlowego`
Nazwa tabeli: `PozycjeDokHan`
Tytuł: Pozycje dokumentów
Opis: Element szczegółowy dokumentu handlowego (DokumentHandlowy). Pozycja towarowa dokumentu zawierająca informacje o towarze, ilości, cenie, rabacie, wartości, stawce VAT, kosztach oraz danych Intrastat.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentHandlowy`
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BezRabatu | `bool` | bazodanowe |  | Określa czy dla pozycji ma być zastosowany rabat. |
| BruttoCy | `Currency` |  | Wartość/B | Wartość brutto pozycji bez względu na to, czy obliczenia są od wartości netto, czy brutto. |
| Cena | `DoubleCy` | bazodanowe |  | Cena pozycji może być wyrażona w walucie i może być netto lub brutto. |
| CenaBruttoPoRabacie | `DoubleCy` |  |  | Cena brutto po rabacie wyliczona z wartości. |
| CenaJednostkowa | `DoubleCy` | tylko-odczyt | Cena jednostkowa | Cena w jednostce ilości na pozycji. |
| CenaJednostkowaPoRabacie | `DoubleCy` | tylko-odczyt | Cena jednostkowa po rabacie | Cena w jednostce ilości na pozycji po rabacie. |
| CenaNettoPoRabacie | `DoubleCy` |  |  | Cena netto po rabacie wyliczona z wartości. |
| CenaPoRabacie | `DoubleCy` |  |  | Cena wyliczona przez podzielenie wartości pozycji przez ilość. |
| Ceny | `Soneta.Handel.PozycjaDokHandlowego.CenyPozycji` | podlista |  | Kolekcja informacji o cenach liczonych względem tej pozycji dokumentu. |
| Czas | `Time` | bazodanowe, tylko-odczyt |  | Czas powstania pozycji dokumentu, odczytywany z czasu dokumentu. |
| Data | `Date` | bazodanowe, tylko-odczyt |  | Data powstania pozycji dokumentu, odczytywany z daty dokumentu. |
| DataPrzecenOkresowych | `Date` | bazodanowe |  | Data jaką należy zastosować dla przeceny okresowej na dokumencie rozliczającym umowę. |
| DataRealizacjiElementuRozliczenia | `Date` |  |  |  |
| DefinicjaCeny | `Soneta.Towary.DefinicjaCeny` | tylko-odczyt |  | Definicja ceny wg def. dokumentu lub indywidualna produktu. |
| DefinicjaPowstaniaObowiazkuVAT | `Row` | bazodanowe |  | Definicja powstania obowiązku VAT dla pozycji. |
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT naliczonej do tej pozycji dokumentu. |
| DodanaAutomatycznie | `bool` | bazodanowe, tylko-odczyt | Pozycja dodana automatycznie | Pozycja dodana automatycznie np. przez schematy opakowań. |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt, guided-parent |  | Dokument, do którego należy ta pozycja |
| DokumentDostawaPozycja | `Soneta.Handel.DokumentDostawa` (subrow) | bazodanowe |  | Informacje o dostawie związane z pozycją dokumentu handlowego. |
| DokumentDostawaPozycja.Cykl | `Soneta.Core.DefinicjaCyklu` (subrow) | bazodanowe |  | Określa cykl/częstotliwość terminu dostawy. |
| DokumentDostawaPozycja.Cykl.AlgorytmCykluInstance | `Soneta.Core.IAlgorytmCyklu` | tylko-odczyt |  | Instancja skompilowanego kalkulatora. |
| DokumentDostawaPozycja.Cykl.Czas | `Time` | bazodanowe |  | Określa czas wystąpienia cyklu. |
| DokumentDostawaPozycja.Cykl.Czerwiec | `bool` |  |  | Czerwiec - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Czwartek | `bool` |  |  | Czwartek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.DataKoniecCyklu | `bool` | bazodanowe |  | Data wystąpienia w ostatnim miesiącu/roku okresu |
| DokumentDostawaPozycja.Cykl.Dzien | `Date` |  |  | Data rozpoczęcia wykonywania cyklu. |
| DokumentDostawaPozycja.Cykl.DzienCzas | `System.DateTime` | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.DzienMiesiaca | `int` |  |  | Dzień w miesiącu wystąpienia cyklu miesięcznego lub rocznego. |
| DokumentDostawaPozycja.Cykl.DzienTygodnia | `Soneta.Core.DefinicjaCykluDzienTygodnia` |  |  | W zaawansowanej wersji dzień tygodnia. |
| DokumentDostawaPozycja.Cykl.Godzina | `int` |  |  | Godzina wystąpienia cyklu. |
| DokumentDostawaPozycja.Cykl.Godziny | `string[]` | podlista |  | Wybrane godziny w trybie godzinowym. |
| DokumentDostawaPozycja.Cykl.Grudzien | `bool` |  |  | Grudzień - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Interwal | `int` | bazodanowe |  |  |
| DokumentDostawaPozycja.Cykl.IsAdvanced | `bool` | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.IsMultiSelect | `bool` | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.IsSingleSelect | `bool` | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.JestAlgorytm | `bool` | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.JestOpcjaZaawansowana | `bool` | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.JestTermin | `bool` | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.KodAlgorytmu | `string` |  |  | Kod algorytmu wyliczania wystąpień cyklu. |
| DokumentDostawaPozycja.Cykl.Krotnosc | `int` | bazodanowe |  | Określa ile razy cykl będzie powtórzony. |
| DokumentDostawaPozycja.Cykl.Kwiecien | `bool` |  |  | Kwiecień - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Lipiec | `bool` |  |  | Lipiec - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Listopad | `bool` |  |  | Listopad - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Luty | `bool` |  |  | Luty - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Maj | `bool` |  |  | Maj - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Marzec | `bool` |  |  | Marzec - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.MiesiacRoku | `Soneta.Core.DefinicjaCykluMiesiacRoku` (enum) |  |  | W zaawansowanej wersji miesiąc w roku. |
| DokumentDostawaPozycja.Cykl.MinutaGodziny | `int` |  |  | Minuta w godzinie wystąpienia cyklu godzinowego. |
| DokumentDostawaPozycja.Cykl.Niedziela | `bool` |  |  | Niedziela - dzień tygodnia wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.OkresCyklu | `Soneta.Core.DefinicjaCykluOkresCyklu` (enum) | bazodanowe |  | Określa okres, w którym oczekiwane jest wystąpienie cyklu. |
| DokumentDostawaPozycja.Cykl.Options | `Soneta.Core.DefinicjaCykluOptions` (enum) | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.Pazdziernik | `bool` |  |  | Październik - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Piatek | `bool` |  |  | Piątek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Podglad | `Soneta.Core.ElementCyklu` | tylko-odczyt |  |  |
| DokumentDostawaPozycja.Cykl.Poniedzialek | `bool` |  |  | Poniedziałek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.PozycjaDnia | `Soneta.Core.DefinicjaCykluPozycjaDnia` (enum) | bazodanowe |  | Określa pozycję dnia w okresie, w którym oczekiwane jest wystąpienie cyklu. |
| DokumentDostawaPozycja.Cykl.PozycjaDniaZaawansowana | `Soneta.Core.DefinicjaCykluPozycjaDniaZaawansowana` (enum) | bazodanowe |  | Określa pozycję dnia w miesiącu, w którym oczekiwane jest wystąpienie cyklu. |
| DokumentDostawaPozycja.Cykl.RodzajTerminu | `Soneta.Core.DefinicjaCykluRodzajTerminu` (enum) | bazodanowe |  | Wskazuje na to, czy określono termin cyklu lub termin wynika z opisu cyklu. |
| DokumentDostawaPozycja.Cykl.Sierpien | `bool` |  |  | Sierpień - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Sobota | `bool` |  |  | Sobota - dzień tygodnia wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.SposobNaDniWolne | `Soneta.Core.DefinicjaCykluSposobNaDniWolne` (enum) | bazodanowe |  | Określa sposób zachowania, kiedy cykl wystąpi w dniu wolnym. |
| DokumentDostawaPozycja.Cykl.Sroda | `bool` |  |  | Środa - dzień tygodnia wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Styczen | `bool` |  |  | Styczeń - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Termin | `int` | bazodanowe |  | Określa termin wystąpienia cyklu. Wartość w polu nie jest czytelna dla użytkownika. |
| DokumentDostawaPozycja.Cykl.Termin2 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (godziny). Wartość w polu nie jest czytelna dla użytkownika. |
| DokumentDostawaPozycja.Cykl.Termin3 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (minuty w godzinie). Wartość w polu nie jest czytelna dla użytkownika. |
| DokumentDostawaPozycja.Cykl.Termin4 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (dni w miesiącu/roku w kolejności). Wartość w polu nie jest czytelna dla użytkownika. |
| DokumentDostawaPozycja.Cykl.Termin5 | `int` | bazodanowe |  | Określa termin wystąpienia cyklu (miesiące w roku w kolejności). Wartość w polu nie jest czytelna dla użytkownika. |
| DokumentDostawaPozycja.Cykl.Typ | `Soneta.Core.DefinicjaCykluTyp` (enum) | bazodanowe |  | Określa rodzaj cyklu za pomocą jednostki interwału czasu. |
| DokumentDostawaPozycja.Cykl.Wrzesien | `bool` |  |  | Wrzesień - miesiąc wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Cykl.Wtorek | `bool` |  |  | Wtorek - dzień tygodnia wystąpienia cyklu tygodniowego. |
| DokumentDostawaPozycja.Odpowiedzialny | `string` | bazodanowe |  | Określa osobę odpowiedzialną za realizację dostawy. |
| DokumentDostawaPozycja.Sposob | `string` | bazodanowe |  | Określa sposób dostarczenia towaru. |
| DokumentDostawaPozycja.Termin | `Date` | bazodanowe |  | Termin realizacji dostawy. |
| DokumentKorygowany | `string` | tylko-odczyt |  |  |
| DoliczajKosztDodatkowy | `bool` | bazodanowe | Doliczanie kosztu dodatkowego | Doliczanie kosztu dodatkowego. |
| Dostawa | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja dostawy dla danego rozchodu magazynowego. |
| DostawaPierwotna | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe |  | Pozycja dostawy pierwotnej dla danego rozchodu magazynowego. |
| Dostawy | `SubTable<Soneta.Handel.PozycjaDokHandlowego>` | podlista |  |  |
| Dzien | `Soneta.Handel.UmowaDzien` (enum) | bazodanowe |  |  |
| ElemyRozliczenia | `SubTable<Soneta.Handel.ElemRozliczenia>` | podlista |  |  |
| ExtInfo | `Soneta.Handel.ExternalInformation` | tylko-odczyt |  |  |
| Flags | `Soneta.Handel.Helpers.Flags` (enum) | bazodanowe |  | Flagi dodatkowe. |
| GTIN13 | `string` | bazodanowe |  | Kod GTIN-13 (GS1) pozycji towarowej. |
| Gratis | `bool` | bazodanowe | Gratis | Gratis. |
| GrupaPKD | `Soneta.Handel.GrupaPKD` (enum) | tylko-odczyt | Grupa PKD |  |
| GrupaTowarowaVat | `Soneta.Core.ProceduraVAT` | bazodanowe |  |  |
| Ident | `int` | bazodanowe, tylko-odczyt |  | Identyfikator pozycji na dokumencie handlowym. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Podstawowa ilość towaru wprowadzana przez użytkownika, która może być wyrażona w jednostce innej niż podstawowa. |
| IloscBiezacaZasobu | `Soneta.Towary.Quantity` | tylko-odczyt | Ilość bieżąca zasobu | Suma ilości zasobów pozycji, w wartość bezwzględnej. |
| IloscMagazynu | `Soneta.Towary.Quantity` | bazodanowe | Ilość magazynowa | Jest to ilość towaru przeliczona na jednostkę magazynową, która powiększa stan magazynu z tytułu tej pozycji. Ilość jest pomniejszona o ilości z relacji do pozycji podrzędnych. |
| IloscNaObrotach | `Soneta.Towary.Quantity` | tylko-odczyt | Ilość zarezerwowana | Zsumowana ilość danej pozycji na obrotach magazynowych. |
| IloscRezerwowana | `Soneta.Towary.Quantity` | bazodanowe | Rezerwacja | Jest to ilość towaru, która jest wykorzystywana podczas rezerwacji towaru na zasobie magazynowym. |
| IloscUzupelniajaca | `Soneta.Towary.Quantity` | bazodanowe | Ilość uzupełniająca | Ilość towaru wyrażona w jednostce uzupełniającej raportowana na deklarcji Intrastat. |
| IloscZasobuRezerwowanaValue | `double` | bazodanowe |  |  |
| IloscZasobuValue | `double` | bazodanowe |  |  |
| IloscZrealizowana | `Soneta.Towary.Quantity` | bazodanowe | Ilość zrealizowana |  |
| IlośćAlternatywna | `Soneta.Towary.Quantity` |  |  | Ilość wyrażona w jednostce alternatywnej towaru, o ile jednostka wpisana. |
| IlośćTekst | `string` | tylko-odczyt | Ilość | Ilość towaru wyrażona w postaci tekstu z uwzględnieniem jednostki reszty. |
| IlośćWartość | `Soneta.Handel.IlośćWartość` |  |  |  |
| IlośćWartośćMagazynu | `Soneta.Handel.IlośćWartość` | tylko-odczyt |  |  |
| IlośćWartośćStatystyczna | `Soneta.Handel.IlośćWartość` | tylko-odczyt |  |  |
| IlośćWartośćZasobu | `Soneta.Handel.IlośćWartość` | tylko-odczyt |  |  |
| IlośćZasobu | `Soneta.Towary.Quantity` | tylko-odczyt |  | Ilość zasobu przeniesiona do magazynu z uwzględnieniem pozycji podrzędnych. |
| IlośćŁącznaTowaru | `Soneta.Towary.Quantity` | tylko-odczyt | Ilość łączna | Zsumowana ilość danego towaru znajdująca się na tym dokumencie wyrażona w jednostkach magazynowych. |
| IlośćŁącznaTowaruNaKorygowanym | `Soneta.Towary.Quantity` | tylko-odczyt | Ilość łączna na dokumencie korygowanym | Zsumowana ilość danego towaru znajdująca się na dokumencie korygowanym wyrażona w jednostkach magazynowych. |
| Intrastat | `bool` | bazodanowe |  | Określa, czy pozycja dokumentu ma być uwzględniana w deklaracji Intrastat. |
| JestOpis | `bool` | bazodanowe |  |  |
| JestPrzecenaPrzychodu | `bool` | tylko-odczyt |  | Określa, czy dana pozycja dokumentu może przeceniać towar. |
| JestUnijny | `bool` | tylko-odczyt |  | Wskazuje, czy towarem można handlować z kontrahentami unijnymi. |
| JestUprawnienieDoZmianyCeny | `bool` | tylko-odczyt |  |  |
| KierunekMagazynu | `Soneta.Magazyny.KierunekPartii` (enum) | bazodanowe, tylko-odczyt |  | Określa kierunek wprowadzania partii towaru na magazyn. |
| Kod | `string` | tylko-odczyt |  |  |
| KodCN | `string` | bazodanowe | Kod CN | Kod towaru wg Scalonej Nomenklatury Towarowej Handlu Zagranicznego CN. Wymagany dla towarów, którymi handlujemy z kontrahentami z UE. |
| KodIndywidualny | `string` | tylko-odczyt |  | Indywidualny kod towaru dla kontrahenta lub kod z karty towaru. |
| KompletacjaInfo | `Soneta.Handel.KompletacjaInfo` (subrow) | bazodanowe |  | Dane właściwe dla kompletacji. |
| KompletacjaInfo.Dodatkowa | `bool` | bazodanowe, tylko-odczyt |  | Dodatkowa. |
| KompletacjaInfo.IloscKartotekowa | `Soneta.Towary.Quantity` | tylko-odczyt | Ilość kartotekowa |  |
| KompletacjaInfo.ProporcjaWartosci | `bool` | bazodanowe |  | Określa, że wartość składników ma być rozdzielona proporcjonalnie na produkty. |
| KompletacjaInfo.Przychod | `Soneta.Handel.Kompletacje.PozycjaKompletacjaWorker` | tylko-odczyt |  |  |
| KompletacjaInfo.Rozchod | `Soneta.Handel.Kompletacje.PozycjaKompletacjaWorker` | tylko-odczyt |  |  |
| KompletacjaInfo.Wartosc | `Currency` | bazodanowe |  |  |
| KompletacjaInfo.WspolczynnikDen | `double` | bazodanowe |  | Współczynnik kompletacji. |
| KompletacjaInfo.WspolczynnikNum | `double` | bazodanowe |  | Współczynnik kompletacji. |
| KonfiguracjaElementuOpisuAnalitycznego | `Soneta.Core.KonfiguracjaElementuOpisuAnalitycznego` | tylko-odczyt |  |  |
| Korekta | `bool` | tylko-odczyt |  | Określa, czy dana pozycja koryguje inną pozycję. |
| KorektaCeny | `bool` | bazodanowe |  | Określa czy cena pozycji została ręcznie zmieniona i nie powinna się już przeliczać. |
| KorektaRabatu | `bool` | bazodanowe |  | Określa czy rabat pozycji został ręcznie zmieniony i nie powinien się już przeliczać. |
| Korygowana | `bool` | tylko-odczyt |  | Sprawdza, czy pozycja dokumentu korygującego wprowadza jakieś zmiany w dokumencie korygowanym. |
| KosztDodatkowy | `bool` | bazodanowe |  | Pozycja ma być traktowana przez księgowość jako koszt dodatkowy podnoszący wartość towarów. |
| KosztFakturowy | `decimal` | bazodanowe |  | Dodatkowy koszt doliczany do wartości pozycji raportowany na deklaracji Intrastat. |
| KosztMagazynowy | `decimal` | bazodanowe |  | Dodatkowy koszt doliczany do wartości pozycji mogący podnosić watość dokumentów magazynowych. |
| KosztStatystyczny | `decimal` | bazodanowe |  | Dodatkowy koszt doliczany do wartości pozycji w celu wyliczenia wartości statystycznej raportowany na deklaracji Intrastat. |
| KrajPochodzenia | `string` | bazodanowe |  | Kod kraju pochodzenia towarów wykazywany w deklaracji Intrastat. |
| KrajPochodzeniaNazwa | `string` | tylko-odczyt |  | Pełna nazwa kraju pochodzenia towaru |
| KrajPrzeznaczenia | `string` | bazodanowe | Kraj wys./przezn. | Kod kraju przeznaczenia przesyłki raportowany na dokumencie Intrastat. |
| KrajPrzeznaczeniaNazwa | `string` | tylko-odczyt |  | Pełna nazwa kraju przeznaczenia towaru wykazywana w deklaracji Intrastat. |
| KrajowaStawkaVAT | `bool` | bazodanowe | Krajowa stawka VAT | Określa czy zastosowana zostanie krajowa stawka VAT. Dotyczy tylko dokumentów unijnych. |
| Krotnosc | `Soneta.Handel.UmowaKrotnosc` (enum) | bazodanowe |  |  |
| KwotaRabatu | `Currency` | tylko-odczyt |  | Kwota udzielonego rabatu na pozycji. |
| LiczMagazyn | `bool` | tylko-odczyt |  | Określa, czy ma być przeliczany ruch parii w magazynie. |
| LiczWgDostawy | `bool` | tylko-odczyt |  | Określa, czy dla tej pozycji musi być określana dostawa partii towaru. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa pozycji na dokumencie handlowym. |
| Lpx | `int` |  |  |  |
| MPP | `bool` | bazodanowe | Mechanizm podzielonej płatności | Wymaga mechanizmu podzielonej płatności. |
| MasaBrutto | `Soneta.Towary.Quantity` | bazodanowe |  | Masa brutto towaru w kg |
| MasaJednostkowaNetto | `Soneta.Towary.Quantity` | tylko-odczyt |  |  |
| MasaNetto | `Soneta.Towary.Quantity` | bazodanowe |  | Masa netto towaru w kg, wykazywana w deklaracji Intrastat. |
| NabywcaPodatnik | `bool` | bazodanowe | Nabywca podatnik | Sprzedaż opodatkowana po stronie nabywcy. |
| Nadrzędne | `Soneta.Handel.PozycjaDokHandlowego.PozycjeSubTable.Podrzędne` | podlista |  |  |
| NadrzędneRelacje | `SubTable` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaIndywidualna | `string` | tylko-odczyt |  | Indywidualny nazwa towar dla kontrahenta lub nazwa z karty towaru. |
| NazwaObieLinie | `string` | tylko-odczyt |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| NazwaResztaLinii | `string` | tylko-odczyt |  |  |
| NettoCy | `Currency` |  | Wartość/N | Wartość netto pozycji bez względu na to, czy obliczenia są od wartości netto, czy brutto. |
| NumerArkusza | `string` | bazodanowe |  | Numer arkusza inwentaryzacyjnego, w którym została zinwentaryzowana dana pozycja. |
| NumerWArkuszu | `int` | bazodanowe |  | Numer w arkuszu inwentaryzacyjnym, w którym została zinwentaryzowana dana pozycja. |
| Obroty | `SubTable` | podlista |  | Obroty związane bezpośrednio z pozycją dokumentu. |
| ObrotyWszystkie | `ListWithView` | podlista |  | Wszystkie obroty związane z pozycją dokumentu, łącznie z obrotami dokumentów zależnych (bez storno zasobu). |
| ObrotyWszystkieWgPartiiPierwotnej | `ListWithView` | podlista |  | Wszystkie obroty związane z pozycją dokumentu, łącznie z obrotami dokumentów zależnych i korygujących (bez storno zasobu). |
| OkresRozliczony | `FromTo` | bazodanowe, podlista |  | Okres jaki rozlicza pozycja. |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| OstatniElement | `Soneta.Handel.ElemRozliczenia` | tylko-odczyt |  |  |
| OstatniElementPlanowania | `Soneta.Handel.ElemRozliczenia` | tylko-odczyt |  |  |
| OstatniElementRealizacji | `Soneta.Handel.ElemRozliczenia` | tylko-odczyt |  |  |
| OstatniElementRozliczenia | `Soneta.Handel.ElemRozliczenia` | tylko-odczyt |  |  |
| OstatniElementZawieszenia | `Soneta.Handel.ElemRozliczenia` | tylko-odczyt |  |  |
| ParametryRezerwacji | `Soneta.Magazyny.ParametryRezerwacji` (subrow) | bazodanowe | Parametry rezerwacji zasobu | Parametry rezerwacji zasóbu (w przypadku zamówień algorytmicznych). |
| ParametryRezerwacji.CzasDo | `Time` | bazodanowe | Czas końca rezerwacji. |  |
| ParametryRezerwacji.CzasOd | `Time` | bazodanowe | Czas początku rezerwacji. |  |
| ParametryRezerwacji.DataDo | `Date` | bazodanowe | Data końca rezerwacji. |  |
| ParametryRezerwacji.DataOd | `Date` | bazodanowe | Data początku rezerwacji. |  |
| ParametryRezerwacji.JestUsluga | `bool` | tylko-odczyt |  |  |
| ParametryRezerwacji.Priorytet | `Soneta.Core.SlownikElem` | bazodanowe | Priorytet rezerwacji. |  |
| ParametryRezerwacji.WgPriorytet | `Key` | podlista |  |  |
| PełnaNazwa | `string` |  |  |  |
| Podrzędne | `Soneta.Handel.PozycjaDokHandlowego.PozycjeSubTable.Nadrzędne` | podlista |  |  |
| PodrzędneRelacje | `SubTable` | podlista |  |  |
| PodstawaZwolnienia | `string` | bazodanowe |  | Podstawa prawna dla zastosowania stawki ZW. |
| PozycjaKSeF | `Soneta.Handel.KSeFPozycjaDokHan` | tylko-odczyt |  |  |
| PozycjaKorygowana | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  | Pozycja korygowanego dokumentu handlowego przez tę pozycję korekty. |
| PozycjaKorygowanaPierwsza | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  | Pozycja pierwszego korygowanego dokumentu handlowego przez tę pozycję korekty. |
| PozycjaKorygująca | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  | Pozycja korygująca tę pozycję dokumentu handlowego. |
| PozycjaKorygującaOstatnia | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  | Pozycja ostatniego korygującego tę pozycję dokumentu handlowego. |
| ProceduraSME | `bool` | bazodanowe | Podlega procedurze SME |  |
| ProdukcjaInfo | `Soneta.Handel.ProdukcjaInfo` (subrow) | bazodanowe |  |  |
| ProdukcjaInfo.IdentyfikatorElementuPowiazanego | `System.Guid` | bazodanowe | Identyfikator elementu powiązanego | Dla pozycji GUID pozycji technologii (dla ZP i PWP - produkt, dla RWP - surowiec). |
| ProdukcjaInfo.PozycjaTechnologii | `Soneta.Produkcja.PozycjaTechn` | tylko-odczyt |  |  |
| ProdukcjaInfo.Technologia | `Soneta.Produkcja.Technologia` |  |  |  |
| ProdukcjaInfo.WgIdentyfikatorElementuPowiazanego | `Key` | podlista |  |  |
| PrzeterminowaneRozliczenieKaucji | `bool` | tylko-odczyt |  |  |
| Rabat | `Percent` | bazodanowe |  | Procent rabatu naliczony do ceny lub wartości pozycji. |
| RabatCeny | `DoubleCy` | bazodanowe |  | Rabat pomniejszający kwotę ceny w walucie. |
| RelacjePartii | `SubTable<Soneta.Handel.Dostawy.RelacjaGrupyDostaw>` | podlista |  |  |
| Rezerwacja | `Soneta.Handel.PozycjaDokHandlowego` | tylko-odczyt |  | Pozycja dokumentu rezerwacji, który rezerwuje towary dla tej pozycji dokumentu handlowego. |
| RodzajKorekty | `Soneta.Handel.RodzajKorektyPozycji` (enum) | tylko-odczyt |  | Określa jaka wartość pozycji dokumentu została skorygowana. |
| RodzajKorektyOpis | `string` | tylko-odczyt |  | Określa jaka wartość pozycji dokumentu została skorygowana uzupełniając informację o zmianę ceny netto po rabacie. |
| RodzajKorektyOpisEnglish | `string` | tylko-odczyt |  |  |
| RodzajTransakcji | `Soneta.Handel.KodRodzajuTransakcji` (enum) | bazodanowe |  | Rodzaj transakcji raportowany na dokumencie Intrastat. |
| RodzajUmowy | `Soneta.Handel.RodzajUmowy` (enum) | bazodanowe | Rodzaj umowy | Określa rodzaj umowy. |
| RodzajZamówieniaNaPozycji | `Soneta.Handel.RodzajZamowieniaNaPozycji` (enum) |  |  |  |
| RoznicaDlaBlokadyZasobu | `Soneta.Towary.Quantity` | tylko-odczyt |  |  |
| RoznicaWartośćFakturowa | `decimal` | tylko-odczyt |  | Różnica wartości fakturowej pozycji korygowanej. |
| RoznicaWartośćMagazynowa | `decimal` | tylko-odczyt |  | Różnica wartości magazynowej pozycji korygowanej. |
| RoznicaWartośćStatystyczna | `decimal` | tylko-odczyt |  | Różnica wartości statystyczej pozycji korygowanej. |
| SWW | `string` | bazodanowe |  | Numer SWW/PKWiU dla pozycji naliczonej dla obniżonej stawki VAT inicjowany z karty towaru. |
| SchematGratisow | `Soneta.Towary.SchemOpakowan` | bazodanowe, tylko-odczyt | Schemat gratisów | Schemat gratisów. |
| SchematOpakowan | `Soneta.Towary.SchemOpakowan` | bazodanowe |  | Schemat opakowań obsługiwany relacją kaucji. |
| SchematOpakowanObslugiwanyPozycja | `Soneta.Towary.SchemOpakowan` | bazodanowe |  | Schemat opakowań obsługiwany dodatkową pozycją. |
| SekcjaDokumentu | `Soneta.Handel.SekcjaDokumentu` (enum) | tylko-odczyt |  | Określa sekcję na wydruku, w której znajduje się dana pozycja. |
| StanPoczatkowy | `Soneta.Towary.Quantity` | bazodanowe |  | Stan początkowy pozycji umowy dostawy towarów. |
| StanPoczątkowyElementuRozliczenia | `Soneta.Towary.Quantity` |  |  |  |
| StanRozliczonyElementuRozliczenia | `Soneta.Towary.Quantity` | tylko-odczyt |  |  |
| StanZrealizowanyElementuRozliczenia | `Soneta.Towary.Quantity` |  |  |  |
| StatusPozycji | `Soneta.Handel.StatusPozycji` (enum) | bazodanowe |  | Określa status pozycji dokumentu handlowego. |
| Stawka | `Soneta.Core.StawkaVat` (subrow) | bazodanowe |  | Rodzaj stawki VAT, która została naliczona do tej pozycji dokumentu. |
| Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Stawka.Procent | `Percent` | bazodanowe |  |  |
| Stawka.Status | `Soneta.Core.StatusStawkiVat` (enum) | bazodanowe |  |  |
| Stawka.WgKraj | `Key` | podlista |  |  |
| Stawka.WymagaSWW | `bool` | tylko-odczyt |  |  |
| Stawka.Zrodlowa | `Percent` | bazodanowe |  |  |
| StawkaKGO | `DoubleCy` | bazodanowe | Stawka KGO |  |
| Suma | `Soneta.Handel.BruttoNetto` (subrow) | bazodanowe |  | Przeliczone na PLN i odpowiednio policzone wartości Netto, Brutto i VAT |
| Suma.Brutto | `decimal` | bazodanowe |  | Wartość brutto. |
| Suma.BruttoCy | `Currency` | tylko-odczyt |  | Wartość brutto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.JestZero | `bool` | tylko-odczyt |  |  |
| Suma.Netto | `decimal` | bazodanowe |  | Wartość netto. |
| Suma.NettoCy | `Currency` | tylko-odczyt |  | Wartość netto wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Suma.VAT | `decimal` | bazodanowe |  | Kwota podatku VAT. |
| Suma.VATCy | `Currency` | tylko-odczyt |  | Wartość podatku VAT wyrażona w walucie. Zawsze PLN poza dokumentami 0%. |
| Symbol | `string` | tylko-odczyt |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar (karta towarowa), do którego odnosi się pozycja dokumentu. |
| UmowaInfo | `Soneta.Handel.UmowaInfo` (subrow) | bazodanowe |  | Dane właściwe dla umowy. |
| UmowaInfo.Aneks | `Soneta.Handel.DokumentHandlowy` | tylko-odczyt |  | Ostatni aneks do umowy. |
| UmowaInfo.Cykl | `Soneta.Core.DefinicjaCyklu` (subrow) | bazodanowe |  | Określa cykl/częstotliwość fakturowania umowy. |
| UmowaInfo.DataOkresuRozliczeniowego | `Date` | bazodanowe |  | Określa datę początkową pierwszego okresu rozliczeniowego umowy. |
| UmowaInfo.Dokumenty | `ListWithView` | podlista |  |  |
| UmowaInfo.DomyslnyPodrzedny | `Soneta.Handel.DefDokHandlowego` | bazodanowe |  | Domyślna definicja dokumentu, który powstanie w procesie masowego fakturowania. |
| UmowaInfo.WgDomyslnyPodrzedny | `Key` | podlista |  |  |
| UmowaInfo.WgZuzycia | `bool` | bazodanowe |  |  |
| UmowaKontrolujLimitDlaCyklu | `bool` | bazodanowe | Kontroluj limit dla cyklu |  |
| UmowaLimit | `Soneta.Handel.PozycjaDokHandlowegoLimit` | bazodanowe | Limit dla umowy cyklicznej |  |
| Urzadzenie | `Soneta.Handel.UrzadzenieUz` | bazodanowe |  | Urządzenie zawierające tą pozycję |
| VATOdMarzy | `bool` | bazodanowe, tylko-odczyt |  | VAT od pozycji towaru liczony jest od marży. Na pozycji dokumentu handlowego jest NP. |
| WOkresie | `Soneta.Handel.UmowaWOkresie` (enum) | bazodanowe |  |  |
| WartoscCy | `Currency` | bazodanowe | Wartość | Ostateczna wartość pozycji wyrażona w walucie zależnej od wpisanej waluty ceny. |
| WartoscKGO | `DoubleCy` | tylko-odczyt | Wartość KGO |  |
| Wartość | `decimal` | tylko-odczyt |  | Wartość pozycji w walucie systemowej. |
| WartośćFakturowa | `decimal` |  |  | Wartość faktrurowa PLN towaru raportowana na deklarcji Intrastat wyliczna przy pomocy kosztu fakturowego. |
| WartośćMagazynowa | `decimal` |  |  | Wartość magazynowa PLN towaru, która może być przenoszona do dokumentu magazynowego wyliczna przy pomocy kosztu magazynowego. |
| WartośćPrzedRabatem | `Currency` | tylko-odczyt |  | Wartość pozycji przed pomniejszeniem o kwotę rabatu. |
| WartośćStatystyczna | `decimal` |  |  | Wartość statystyczna PLN towaru raportowana na deklarcji Intrastat wyliczna przy pomocy kosztu statystycznego. |
| WartośćWCenieZakupu | `decimal` | tylko-odczyt |  | Wartość w cenie zakupu. Dla korekt zmiana wartości zakupu. |
| WartośćWCenieZakupuBufor | `decimal` | tylko-odczyt |  | Wartość w cenie zakupu również dla niezatwierdzonych dokumentów. Dla korekt zmiana wartości zakupu. |
| WartośćWCenieZakupuBuforKorygowana | `decimal` | tylko-odczyt |  | Wartość przyjęcia towaru wydawanego rozchodem, a dla korekt rozchodu różnica kosztu WartośćWCenieZakupuNarastająco z poprzedzającego wydania lub korekty i danego dokumentu. |
| WartośćWCenieZakupuKorygowana | `decimal` | tylko-odczyt |  | Wartość przyjęcia towaru wydawanego rozchodem, a dla korekt rozchodu różnica kosztu WartośćWCenieZakupuNarastająco z poprzedzającego wydania lub korekty i danego dokumentu. |
| WartośćWCenieZakupuNarastająco | `decimal` | tylko-odczyt |  | Bieżąca dla danego dokumentu wartość kosztu całkowitego, uwzględniająca poprzedzające dokument korekty kosztu KWPZ (bez późniejszych KWPZ i innych późniejszych zmian w transakcji). |
| WartośćŁącznaTowaru | `Currency` | tylko-odczyt |  | Wartość łączna towaru na dokumencie. |
| WidoczneRoznice | `bool` | tylko-odczyt |  |  |
| Wspolczynnik | `Fraction` | bazodanowe | Współczynnik | Współczynnik wyliczania jednostki wyliczanej: Wyliczna=Bazowa*Wspolczynnik. |
| WspolczynnikWzor | `string` | tylko-odczyt |  |  |
| ZaliczkaInfo | `Soneta.Handel.ZaliczkaInfo` (subrow) | bazodanowe |  |  |
| ZaliczkaInfo.Brutto | `decimal` | tylko-odczyt | Zaliczka bieżąca (PLN) | Zaliczka bieżąca (PLN) |
| ZaliczkaInfo.BruttoCy | `Currency` | bazodanowe, tylko-odczyt | Zaliczka bieżąca | Kwota brutto tej części zaliczki, która przypada na bieżącą pozycję dokumentu (z kompensacją zaokrągleń). |
| ZaliczkaInfo.BruttoCyNarastajaco | `Currency` | tylko-odczyt | Zaliczka bieżąca łącznie | Łączna kwota dotychczasowych zaliczek brutto, która przypada na bieżącą pozycję dokumentu (z kompensacją zaokrągleń). |
| ZaliczkaInfo.NettoCy | `Currency` | tylko-odczyt | Zaliczka bieżąca /N | Kwota netto tej części zaliczki, która przypada na bieżącą pozycję dokumentu (z kompensacją zaokrągleń). |
| ZaliczkaInfo.NettoCyNarastajaco | `Currency` | tylko-odczyt | Zaliczka bieżąca /N łącznie | Łączna kwota dotychczasowych zaliczek netto, która przypada na bieżącą pozycję dokumentu (z kompensacją zaokrągleń). |
| Zasoby | `SubTable` | podlista |  | Zasoby na stanie magazynowym związane bezpośrednio z pozycją dokumentu. |
| ZasobyWszystkie | `ListWithView` | podlista |  | Wszystkie zasoby na stanie magazynowym związane z pozycją dokumentu, łącznie z zasobami pozycji dokumentów zależnych. |
| ZasobyWszystkieWgPartiiPierwotnej | `ListWithView` | podlista |  | Wszystkie zasoby na stanie magazynowym związane z pozycją dokumentu, łącznie z zasobami pozycji dokumentów zależnych. |
| Zmiana | `Soneta.Handel.IlośćWartość` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę ilości i wartości pozycji, ale pozostałych ilość i wartość pozycji towaru. |
| ZmianaBrutto | `decimal` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę wartości brutto pozycji, ale pozostałych wartość brutto pozycji towaru. |
| ZmianaCeny | `DoubleCy` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę ceny pozycji. |
| ZmianaCenyNettoPoRabacie | `DoubleCy` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę ceny netto po rabacie pozycji. |
| ZmianaIlości | `Soneta.Towary.Quantity` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę ilości pozycji, ale pozostałych ilość towaru. |
| ZmianaIlościMagazynu | `Soneta.Towary.Quantity` | tylko-odczyt |  | Ilość (w jednostkach magazynowych) zmieniana przez tą pozycję. |
| ZmianaIlościTekst | `string` | tylko-odczyt | Zmiana ilości | Zmiana ilości (właściwość ZmianaIlości) towaru wyrażona w postaci tekstu z uwzględnieniem jednostki reszty. |
| ZmianaKwotyRabatu | `Currency` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę kwoty rabatu pozycji, dla pozostałych kwotę rabatu. |
| ZmianaMagazynu | `Soneta.Handel.IlośćWartość` | tylko-odczyt |  | Ilość (w jednostkach magazynowych) i wartość magazynu zmieniana przez tą pozycję. |
| ZmianaNetto | `decimal` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę wartości netto pozycji, ale pozostałych wartość netto pozycji towaru. |
| ZmianaParametrowZasobuInfo | `Soneta.Handel.ZmianaParametrowZasobuInfo` (subrow) | bazodanowe | Reguły doboru walut. | Ustawienia sposobu doboru walut dla: wartości pozycji, wartości dokumentu lub płatności. |
| ZmianaParametrowZasobuInfo.Cena | `DoubleCy` | tylko-odczyt | Org.Cena | Cena zasobu przed zmianą parametrów zasobu. |
| ZmianaParametrowZasobuInfo.Ilosc | `Soneta.Towary.Quantity` | bazodanowe, tylko-odczyt | Org.Ilość | Ilość zasobu przed zmianą parametrów zasobu. |
| ZmianaParametrowZasobuInfo.Netto | `decimal` | tylko-odczyt | Wartość netto | Wartość netto zasobu po zmianie. |
| ZmianaParametrowZasobuInfo.Wartosc | `decimal` | tylko-odczyt | Org.Wartość | Wartość zasobu przed zmianą parametrów zasobu. |
| ZmianaParametrowZasobuInfo.WartoscCy | `Currency` | bazodanowe, tylko-odczyt | Org.Wartość | Wartość zasobu przed zmianą parametrów zasobu. |
| ZmianaParametrowZasobuInfo.ZmianaNetto | `decimal` | tylko-odczyt | Zmiana netto | Zmiana wartości netto zasobu. |
| ZmianaParametrowZasobuInfo.ZmianaParametrowZasobu | `bool` | bazodanowe, tylko-odczyt | Zmiana parametrów zasobu | Określa, czy dokument umożliwia zmianę wartości (bez ilości) lub ilości (bez wartości) zasobu. |
| ZmianaVAT | `decimal` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę podatku VAT pozycji, ale pozostałych podatku VAT pozycji towaru. |
| ZmianaWartości | `decimal` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę wartości pozycji, ale pozostałych wartość pozycji towaru. |
| ZmianaWartościCy | `Currency` | tylko-odczyt |  | Dla dokumentu korygowanego zwraca korektę wartości w walucie pozycji, ale pozostałych wartość pozycji towaru. |
| ZmianaWartościCy2 | `Currency` | tylko-odczyt |  | Wartość naliczana tylko dla raportu pozycje dokumentów.aspx Dla dokumentu korygowanego zwraca korektę wartości w walucie pozycji, ale pozostałych wartość pozycji towaru. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

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

### StatusStawkiVat (`Soneta.Core.StatusStawkiVat`)
- `Opodatkowana` = 0 — Opodatkowana
- `Zaniżona` = 1
- `Zwolniona` = 2
- `NiePodlega` = 3
- `Brak` = 4

### GrupaPKD (`Soneta.Handel.GrupaPKD`)
- `Podstawowa` = 0
- `Pozostala` = 1 — Pozostała

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

### RodzajKorektyPozycji (`Soneta.Handel.RodzajKorektyPozycji`)
- `Brak` = 0
- `Ceny` = 1 — Cena
- `Ilości` = 2 — Ilość
- `Zwrot` = 4 — Zwrot
- `StawkiVAT` = 8 — St.VAT
- `Wartości` = 64 — Wartość
- `Nowa` = 16 — Nowa
- `Reczny` = 32
- `IlościICeny` = 3 — Cena Ilość
- `ZwrotICeny` = 5 — Cena Zwrot
- `StVatICeny` = 9 — Cena St.VAT
- `IlościIStawkiVat` = 10 — Ilość St.VAT
- `ZwrotIStawkiVat` = 12 — Zwrot St.VAT
- `IlościCenyStVat` = 11 — Cena Ilość St.VAT
- `ZwrotCenyStVat` = 13 — Cena Zwrot St.VAT

### RodzajUmowy (`Soneta.Handel.RodzajUmowy`)
- `NieDotyczy` = 0 — Nie dotyczy
- `CyklicznaUsługa` = 1 — Cykliczna usługa
- `Dostawa` = 2 — Dostawa

### RodzajZamowieniaNaPozycji (`Soneta.Handel.RodzajZamowieniaNaPozycji`)
- `Zwykłe` = 0 — Zwykłe
- `Algorytmiczne` = 1 — Z rezerwacją ilości (algorytmiczne)
- `ZSubzasobami` = 2 — Z rezerwacją zasobu (subzasób)
- `ZObrotami` = 3 — Z obrotami
- `WgPozycjiKorygowanej` = 4 — Wg pozycji korygowanej

### SekcjaDokumentu (`Soneta.Handel.SekcjaDokumentu`)
- `PozycjeDokumentu` = 0
- `PoKorekcie` = 1
- `PrzedKorektą` = 2
- `Korekta` = 3

### StatusPozycji (`Soneta.Handel.StatusPozycji`)
- `Domyślny` = 0
- `Anulowana` = 1

### UmowaDzien (`Soneta.Handel.UmowaDzien`)
- `Nieokreślony` = 0
- `Poniedziałek` = 1
- `Wtorek` = 2
- `Środa` = 3
- `Czwartek` = 4
- `Piątek` = 5
- `Sobota` = 6
- `Niedziela` = 7

### UmowaKrotnosc (`Soneta.Handel.UmowaKrotnosc`)
- `Jednokrotnie` = 0
- `Dwukrotnie` = 1
- `WDniu` = 2 — W dniu

### UmowaWOkresie (`Soneta.Handel.UmowaWOkresie`)
- `Dzień` = 0
- `Tydzień` = 1
- `Dekada` = 2
- `DwaTygodnie` = 3 — Dwa tygodnie
- `Miesiąc` = 4
- `PolRoku` = 7 — Pół roku
- `Kwartał` = 5
- `Rok` = 6
- `TylkoWgZużycia` = 100 — Tylko wg zużycia

### KierunekPartii (`Soneta.Magazyny.KierunekPartii`)
- `Rozchód` = -1 — Rozchód
- `Brak` = 0 — Brak
- `Przychód` = 1 — Przychód
