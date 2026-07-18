# Pola i właściwości klasy biznesowej: `Soneta.Place.DefinicjaElementu`
Nazwa tabeli: `DefElementow`
Tytuł: Definicje elementów wynagrodzenia
Opis: Główna definicja składnika wynagrodzenia (np. wynagrodzenie zasadnicze, premia, potrącenie). Zawiera pełną konfigurację algorytmu naliczania, zasad podatkowych, składek ZUS, deklaracji i zaokrągleń.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 178
- pola kalkulowane (zapisywalne): 45
- pola tylko-odczyt: 49
- podlisty: 18
- subrowy: 37
- razem: 327

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualizacja | `bool` | bazodanowe |  | Aktualizacja zapisu po wyplacie (dotyczy tylko dodatkow) |
| Algorytm | `Soneta.Place.AlgorytmDefElementu` (subrow) | bazodanowe |  |  |
| Algorytm.Aktualny | `Soneta.Place.IDefinicjaAlgorytmu` | tylko-odczyt |  |  |
| Algorytm.Czas | `Time` | bazodanowe |  |  |
| Algorytm.Dni | `int` | bazodanowe |  |  |
| Algorytm.DodCzas | `string` | bazodanowe |  |  |
| Algorytm.DodDni | `string` | bazodanowe |  |  |
| Algorytm.DodPodstawa | `string` | bazodanowe |  |  |
| Algorytm.DodProcent | `string` | bazodanowe |  |  |
| Algorytm.DodUlamek | `string` | bazodanowe |  |  |
| Algorytm.DodWspolczynnik | `string` | bazodanowe |  |  |
| Algorytm.Edytor | `Soneta.Place.EdytorAlgorytmu` (subrow) | bazodanowe |  |  |
| Algorytm.Edytor.Korekta | `Soneta.Place.KorektaDefElementu` | tylko-odczyt |  |  |
| Algorytm.Edytor.PodstawaZa | `Soneta.Place.PodstawaAlgorytmuZa` (enum) |  |  |  |
| Algorytm.Edytor.Tekst | `string` |  |  |  |
| Algorytm.Edytor.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.ElCzas | `string` | bazodanowe |  |  |
| Algorytm.ElDni | `string` | bazodanowe |  |  |
| Algorytm.ElIlosc | `string` | bazodanowe |  |  |
| Algorytm.ElPodglad | `bool` | bazodanowe |  |  |
| Algorytm.ElPodstawa1 | `string` | bazodanowe |  |  |
| Algorytm.ElPodstawa2 | `string` | bazodanowe |  |  |
| Algorytm.ElPodstawa3 | `string` | bazodanowe |  |  |
| Algorytm.ElPodstawa4 | `string` | bazodanowe |  |  |
| Algorytm.ElPodstawa5 | `string` | bazodanowe |  |  |
| Algorytm.ElPodstawaOkres | `string` | bazodanowe |  |  |
| Algorytm.ElProcent | `string` | bazodanowe |  |  |
| Algorytm.ElRazemCzas | `string` | bazodanowe |  |  |
| Algorytm.ElRazemDni | `string` | bazodanowe |  |  |
| Algorytm.ElUlamek | `string` | bazodanowe |  |  |
| Algorytm.ElWspolczynnik | `string` | bazodanowe |  |  |
| Algorytm.JakChorobowe | `Soneta.Place.JakChorobowe` (subrow) | bazodanowe |  |  |
| Algorytm.JakChorobowe.Algorytm | `Soneta.Place.AlgorytmDefElementu` | tylko-odczyt |  |  |
| Algorytm.JakChorobowe.OkresPodstawy | `int` |  |  |  |
| Algorytm.JakChorobowe.Procent | `Percent` |  |  |  |
| Algorytm.JakChorobowe.StdOkresPodstawy | `bool` |  |  |  |
| Algorytm.JakChorobowe.Tekst | `string` |  |  |  |
| Algorytm.JakChorobowe.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.JakChorobowe.Zatrudnienie | `Soneta.Place.ChorobowyZatrudnienie` (enum) | bazodanowe |  |  |
| Algorytm.JakEkwiwalent | `bool` | bazodanowe |  |  |
| Algorytm.JakEkwiwalentZaUrlop | `Soneta.Place.JakEkwiwalentZaUrlop` (subrow) | bazodanowe |  |  |
| Algorytm.JakEkwiwalentZaUrlop.Algorytm | `Soneta.Place.AlgorytmDefElementu` | tylko-odczyt |  |  |
| Algorytm.JakEkwiwalentZaUrlop.DefinicjaLimitu | `Soneta.Kalend.DefinicjaLimitu` | bazodanowe |  |  |
| Algorytm.JakEkwiwalentZaUrlop.Dni | `int` |  |  |  |
| Algorytm.JakEkwiwalentZaUrlop.OkresPodstawy | `int` |  |  |  |
| Algorytm.JakEkwiwalentZaUrlop.StdOkresPodstawy | `bool` |  |  |  |
| Algorytm.JakEkwiwalentZaUrlop.StdWspółczynnik | `bool` |  |  |  |
| Algorytm.JakEkwiwalentZaUrlop.Tekst | `string` |  |  |  |
| Algorytm.JakEkwiwalentZaUrlop.Ulamek | `Fraction` |  |  |  |
| Algorytm.JakEkwiwalentZaUrlop.WgDefinicjaLimitu | `Key` | podlista |  |  |
| Algorytm.JakEkwiwalentZaUrlop.WgWymiaruEtatu | `bool` | bazodanowe |  |  |
| Algorytm.JakEkwiwalentZaUrlop.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.JakUrlopOkolicznosciowy | `Soneta.Place.JakUrlopOkolicznosciowy` (subrow) | bazodanowe |  |  |
| Algorytm.JakUrlopOkolicznosciowy.Algorytm | `Soneta.Place.AlgorytmDefElementu` | tylko-odczyt |  |  |
| Algorytm.JakUrlopOkolicznosciowy.Tekst | `string` |  |  |  |
| Algorytm.JakUrlopOkolicznosciowy.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.JakUrlopWypoczynkowy | `Soneta.Place.JakUrlopWypoczynkowy` (subrow) | bazodanowe |  |  |
| Algorytm.JakUrlopWypoczynkowy.Algorytm | `Soneta.Place.AlgorytmDefElementu` | tylko-odczyt |  |  |
| Algorytm.JakUrlopWypoczynkowy.OkresPodstawy | `int` |  |  |  |
| Algorytm.JakUrlopWypoczynkowy.StdOkresPodstawy | `bool` |  |  |  |
| Algorytm.JakUrlopWypoczynkowy.Tekst | `string` |  |  |  |
| Algorytm.JakUrlopWypoczynkowy.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.Klasa | `Soneta.Place.KlasaAlgorytmu` (subrow) | bazodanowe |  |  |
| Algorytm.Klasa.Nazwa | `string` | bazodanowe |  |  |
| Algorytm.Klasa.Tekst | `string` |  |  |  |
| Algorytm.Klasa.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.Korekta | `Soneta.Place.KorektaDefElementu` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu | `Soneta.Place.KreatorAlgorytmu` (subrow) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Algorytm | `Soneta.Place.AlgorytmDefElementu` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Cecha | `string` |  |  |  |
| Algorytm.KreatorAlgorytmu.Czas | `Soneta.Place.CzasDefElementu` (subrow) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Czas.Czas | `Time` |  |  |  |
| Algorytm.KreatorAlgorytmu.Czas.Strefa | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Czas.Typ | `Soneta.Place.TypCzasuPracy` (enum) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Czas.WgStrefa | `Key` | podlista |  |  |
| Algorytm.KreatorAlgorytmu.Korekta | `Soneta.Place.KorektaDefElementu` (subrow) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.Chorobowe | `Soneta.Place.RodzajPomniejszenia` (enum) | bazodanowe |  | Korekta z tytułu zwolnień lekarskich |
| Algorytm.KreatorAlgorytmu.Korekta.LiczOdchyłkiAkord | `bool` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.LiczOdchyłkiMinus | `bool` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.LiczOdchyłkiPlus | `bool` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.LiczOdchyłkiRozliczane | `bool` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.LiczPostojowe | `bool` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.Macierzynske | `Soneta.Place.RodzajPomniejszenia` (enum) | bazodanowe |  | Korekta z tytułu urlopu macierzynskiego |
| Algorytm.KreatorAlgorytmu.Korekta.Nieusprawiedliwione | `Soneta.Place.RodzajPomniejszenia` (enum) | bazodanowe |  | Korekta z tytułu nieobecności nieusprawiedliwionych |
| Algorytm.KreatorAlgorytmu.Korekta.Odchylki | `bool` | bazodanowe |  | Określa, czy element wypłaty ma uwzględniać odchyłki +/- czasu pracy |
| Algorytm.KreatorAlgorytmu.Korekta.OdchylkiAkord | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.OdchylkiMinus | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.OdchylkiPlus | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.OdchylkiPlus100 | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.OdchylkiPlus50 | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.OdchylkiPlusPozostale | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.OdchylkiPlusSW | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.OdchylkiRozliczane | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.OgraniczeniePomniejszen | `bool` | bazodanowe |  | Określa, czy suma pomniejszeń elementu może być większa niż jego wartość po odchyłkach |
| Algorytm.KreatorAlgorytmu.Korekta.Opiekuncze | `Soneta.Place.RodzajPomniejszenia` (enum) | bazodanowe |  | Korekta z tytułu zwolnienia opiekuńczego |
| Algorytm.KreatorAlgorytmu.Korekta.Platne | `Soneta.Place.RodzajPomniejszenia` (enum) | bazodanowe |  | Korekta z tytułu urlopów i innych nieobecności usprawiedliwionych płatnych |
| Algorytm.KreatorAlgorytmu.Korekta.Postojowe | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.Rehabilitacyjne | `Soneta.Place.RodzajPomniejszenia` (enum) | bazodanowe |  | Korekta z tytułu urlopu rehabilitacyjnego |
| Algorytm.KreatorAlgorytmu.Korekta.Usprawiedliwione | `Soneta.Place.RodzajPomniejszenia` (enum) | bazodanowe |  | Korekta z tytułu pozostałych nieobecności usprawiedliwionych |
| Algorytm.KreatorAlgorytmu.Korekta.WartośćWgZasadniczego | `bool` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.WybraneOdchylki | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.WybraneOdchylkiPlus | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Korekta.Wychowawcze | `Soneta.Place.RodzajPomniejszenia` (enum) | bazodanowe |  | Korekta z tytułu urlopów wychowawczych |
| Algorytm.KreatorAlgorytmu.Korekta.ZUS | `Soneta.Place.RodzajPomniejszenia` (enum) |  |  |  |
| Algorytm.KreatorAlgorytmu.Korekta._Odchyłki | `Soneta.Place.KorektaDefElementu.KorektaOdchyłek` (enum) |  |  |  |
| Algorytm.KreatorAlgorytmu.Korekta._OdchyłkiPlus | `Soneta.Place.KorektaDefElementu.KorektaOdchyłek` (enum) |  |  |  |
| Algorytm.KreatorAlgorytmu.Podstawa | `Currency` |  |  |  |
| Algorytm.KreatorAlgorytmu.PodstawaNazwa | `string` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.PodstawaTyp | `Soneta.Place.TypPodstawyAlgorytmu` (enum) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.PodstawaZa | `Soneta.Place.PodstawaAlgorytmuZa` (enum) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.PrzeliczNa1h | `Soneta.Place.SposobyPrzeliczeniaNa1h` (enum) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.SposobProporcjonalnosci | `Soneta.Place.SposobyProporcjonalności` (enum) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Tekst | `string` |  |  |  |
| Algorytm.KreatorAlgorytmu.Wskaźniki | `string` |  |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik | `Soneta.Place.WspolczynnikDefElementu` (subrow) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.NazwaWskaznika | `string` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.PodstawaStazu | `Soneta.Kadry.DefPodstawyStazu` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.PracaNaDzien | `Soneta.Place.TypPracyNaDzień` (enum) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.PracaWFirmie | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.Procent | `Percent` |  |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.Progi | `SubTable` | podlista |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.Typ | `Soneta.Place.TypWspolczynnikaAlgorytmu` (enum) | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.Ulamek | `Fraction` |  |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.WgPodstawaStazu | `Key` | podlista |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.WgStażuPracy | `bool` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.Wskaznik | `bool` | bazodanowe |  |  |
| Algorytm.KreatorAlgorytmu.Wspolczynnik.Wspolczynnik | `decimal` |  |  |  |
| Algorytm.KreatorAlgorytmu.Wynagrodzenia | `Soneta.Place.KreatorAlgorytmu.TypWynagrodzenia` (enum) |  |  |  |
| Algorytm.KreatorAlgorytmu.Wyrażenie | `string` |  |  |  |
| Algorytm.KreatorAlgorytmu.ZaNieobecnosc | `Soneta.Place.ZaOkresNieobecnosci` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.KreatorAlgorytmu.Zasiłki | `Soneta.Place.KreatorAlgorytmu.TypZasiłku` (enum) |  |  |  |
| Algorytm.Liczba | `int` | bazodanowe |  |  |
| Algorytm.LimitPotracenia | `Soneta.Place.TypLimituPotrącenia` (enum) | bazodanowe | Limit potrącenia |  |
| Algorytm.Nazwa | `string` | tylko-odczyt |  |  |
| Algorytm.Podstawa | `Currency` | bazodanowe |  |  |
| Algorytm.PomniejszeniaIOdchylki | `Soneta.Place.PomniejszeniaIOdchyłki` (subrow) | bazodanowe |  |  |
| Algorytm.PomniejszeniaIOdchylki.Korekta | `Soneta.Place.KorektaDefElementu` | tylko-odczyt |  |  |
| Algorytm.PomniejszeniaIOdchylki.Tekst | `string` |  |  |  |
| Algorytm.PomniejszeniaIOdchylki.WgWybranaStrefa | `Key` | podlista |  |  |
| Algorytm.PomniejszeniaIOdchylki.WybranaStrefa | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Algorytm.PomniejszeniaIOdchylki.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.Potracenie | `bool` | bazodanowe | Potrącenie |  |
| Algorytm.Priorytet | `int` | bazodanowe |  |  |
| Algorytm.PriorytetPrzeliczania | `int` | tylko-odczyt |  |  |
| Algorytm.Procent | `Percent` |  |  |  |
| Algorytm.RozliczenieCzasuUmowy | `Soneta.Place.AlgorytmRozliczenieCzasuUmowy` (subrow) | bazodanowe |  |  |
| Algorytm.RozliczenieCzasuUmowy.Podstawowa | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Algorytm.RozliczenieCzasuUmowy.WgPodstawowa | `Key` | podlista |  |  |
| Algorytm.RozliczenieCzasuUmowy.WliczanyDoRozliczenia | `bool` | bazodanowe |  |  |
| Algorytm.TylkoPelnePotracenie | `bool` | bazodanowe |  |  |
| Algorytm.Typ | `Soneta.Place.TypAlgorytmuElementu` (enum) | bazodanowe |  |  |
| Algorytm.Ulamek | `Fraction` | bazodanowe |  |  |
| Algorytm.Umowa | `Soneta.Place.AlgorytmUmowy` (subrow) | bazodanowe |  |  |
| Algorytm.Umowa.MinimalnaStawkaGodz | `Soneta.Place.KontrolaMinimalnaStawkaGodz` (enum) | bazodanowe |  |  |
| Algorytm.Umowa.RodzajRozliczenia | `Soneta.Place.RodzajeRozliczeniaUmowyAlgorytm` (enum) | bazodanowe |  |  |
| Algorytm.Umowa.TypWartosci | `Soneta.Place.TypWartosciUmowyAlgorytm` (enum) | bazodanowe |  |  |
| Algorytm.Wzory | `string` | tylko-odczyt |  |  |
| Algorytm.ZaNieobecnosc | `Soneta.Place.ZaOkresNieobecnosci` (subrow) | bazodanowe |  |  |
| Algorytm.ZaNieobecnosc.Algorytm | `Soneta.Place.AlgorytmDefElementu` | tylko-odczyt |  |  |
| Algorytm.ZaNieobecnosc.Chorobowego | `bool` | bazodanowe |  |  |
| Algorytm.ZaNieobecnosc.Macierzynskiego | `bool` | bazodanowe |  |  |
| Algorytm.ZaNieobecnosc.Opiekunczego | `bool` | bazodanowe |  |  |
| Algorytm.ZaNieobecnosc.Podstawowa | `Soneta.Place.DefinicjaElementu` |  |  |  |
| Algorytm.ZaNieobecnosc.Rehabilitacyjnego | `bool` | bazodanowe |  |  |
| Algorytm.ZaNieobecnosc.Tekst | `string` |  |  |  |
| Algorytm.ZaNieobecnosc.Wychowawczego | `bool` | bazodanowe |  |  |
| Algorytm.ZaNieobecnosc.ZUS | `bool` |  |  |  |
| Algorytm.ZaNieobecnosc.ZapisObliczeń | `string` | tylko-odczyt |  |  |
| Algorytm.ZapisObliczen | `Soneta.Place.ZapisObliczeń` (subrow) | bazodanowe |  |  |
| Algorytm.ZapisObliczen.Nazwa | `string` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaListyPlac | `Soneta.Place.DefinicjaListyPlac` | bazodanowe |  |  |
| Definicje | `SubTable<Soneta.Place.DefinicjaElementu>` | podlista |  |  |
| Deklaracje | `Soneta.Place.DeklaracjeDefElementu` (subrow) | bazodanowe |  |  |
| Deklaracje.JestPodatekLubZUS | `bool` | tylko-odczyt |  |  |
| Deklaracje.KodRNA | `Soneta.Place.KodRNA` (enum) | bazodanowe |  |  |
| Deklaracje.KodRSA | `Soneta.Place.KodRSA` | bazodanowe |  |  |
| Deklaracje.Koszty | `Soneta.Place.KosztyUzyskaniaPrzychodu` (subrow) | bazodanowe |  |  |
| Deklaracje.Koszty.Procent | `Percent` | bazodanowe |  |  |
| Deklaracje.Koszty.Typ | `Soneta.Place.TypKosztowUzyskaniaPrzychodu` (enum) | bazodanowe |  |  |
| Deklaracje.Narzuty | `Soneta.Place.NarzutyNaWynagrodzenie` (subrow) | bazodanowe |  |  |
| Deklaracje.Narzuty.SkladkaFGSP | `Soneta.Place.TypSkładkiFGŚP` (enum) | bazodanowe |  |  |
| Deklaracje.Narzuty.SkladkaFP | `Soneta.Place.TypSkładkiFP` (enum) | bazodanowe |  |  |
| Deklaracje.NieRozrzucaj | `bool` | bazodanowe |  |  |
| Deklaracje.NieWliczajSOD | `bool` | bazodanowe |  |  |
| Deklaracje.NieoskladkowanyZUS | `bool` | bazodanowe |  |  |
| Deklaracje.OpisNaPIT8C | `string` | bazodanowe |  |  |
| Deklaracje.PodstawaSkladek | `Soneta.Place.PodstawaSkładekZUS` (subrow) | bazodanowe |  |  |
| Deklaracje.PodstawaSkladek.UrlopWychowawczy | `Soneta.Place.TypPodstawyZasilku` (enum) | bazodanowe |  |  |
| Deklaracje.PozycjaPIT | `Soneta.Place.PozycjaPIT` | bazodanowe |  |  |
| Deklaracje.PozycjaRCA | `Soneta.Place.PozycjaRCA` (enum) | bazodanowe |  |  |
| Deklaracje.PozycjaRP7 | `Soneta.Place.PozycjaRP7` (enum) | bazodanowe |  |  |
| Deklaracje.Priorytet | `int` | bazodanowe |  |  |
| Deklaracje.RozrzucajPodatkiISkładki | `bool` |  |  |  |
| Deklaracje.Spoleczne | `Soneta.Place.UbezpieczenieSpoleczne` (subrow) | bazodanowe |  |  |
| Deklaracje.Spoleczne.Typ | `Soneta.Place.TypUbezpieczeniaSpolecznego` (enum) | bazodanowe |  |  |
| Deklaracje.TrybPodleganiaRozpMF070122 | `Soneta.Place.TrybPodleganiaRozporzadzeniuMF070122` (enum) | bazodanowe |  |  |
| Deklaracje.Ulga | `Soneta.Place.UlgaPodatkowa` (subrow) | bazodanowe |  |  |
| Deklaracje.Ulga.Typ | `Soneta.Place.TypUlgiPodatkowej` (enum) | bazodanowe |  |  |
| Deklaracje.Umowa | `Soneta.Kadry.TypUmowyCywilnoPrawnej` (enum) | bazodanowe |  |  |
| Deklaracje.UmowaJakEtat | `bool` | bazodanowe |  |  |
| Deklaracje.UmowaTyUb | `Soneta.Kadry.TytulUbezpieczenia4` | bazodanowe |  |  |
| Deklaracje.WgKodRSA | `Key` | podlista |  |  |
| Deklaracje.WgPozycjaPIT | `Key` | podlista |  |  |
| Deklaracje.WgUmowaTyUb | `Key` | podlista |  |  |
| Deklaracje.WliczDoKosztowPlacy | `Soneta.Kadry.WliczajDoKosztowPlacyEnum` (enum) |  |  |  |
| Deklaracje.WliczajDoKosztowPlacy | `Soneta.Kadry.WliczajDoKosztowPlacyEnum` (enum) | bazodanowe |  |  |
| Deklaracje.WliczajSOD | `bool` |  |  |  |
| Deklaracje.WymaganeUbezpieczenie | `Soneta.Place.WymaganeUbezpieczenie` (enum) | tylko-odczyt |  |  |
| Deklaracje.Zaliczka | `Soneta.Place.ZaliczkaPodatku` (subrow) | bazodanowe |  |  |
| Deklaracje.Zaliczka.NaliczaniePit26 | `Soneta.Place.NaliczaniePit26` (enum) | bazodanowe |  |  |
| Deklaracje.Zaliczka.Pit26 | `bool` | tylko-odczyt |  |  |
| Deklaracje.Zaliczka.PomniejszonaZUS | `Soneta.Place.TypPomniejszeniaPodstawyFIS` (enum) | bazodanowe |  |  |
| Deklaracje.Zaliczka.Procent | `Percent` | bazodanowe |  |  |
| Deklaracje.Zaliczka.Typ | `Soneta.Place.TypZaliczkiPodatku` (enum) | bazodanowe |  |  |
| Deklaracje.Zdrowotne | `Soneta.Place.UbezpieczenieZdrowotne` (subrow) | bazodanowe |  |  |
| Deklaracje.Zdrowotne.PomniejszaFIS | `Soneta.Place.TypPomniejszeniaFIS` (enum) | bazodanowe |  |  |
| Deklaracje.Zdrowotne.PomniejszoneZUS | `bool` | bazodanowe |  |  |
| Deklaracje.Zdrowotne.Typ | `Soneta.Place.TypUbezpieczeniaZdrowotnego` (enum) | bazodanowe |  |  |
| DoDnia | `Date` | bazodanowe |  |  |
| DoWyplaty | `bool` | bazodanowe |  |  |
| Dodatkowe | `Soneta.Place.DodatkoweInformacje` (subrow) | bazodanowe |  |  |
| Dodatkowe.DodatekDoEtatu | `bool` | bazodanowe |  |  |
| Dodatkowe.LukaPlacowa | `Soneta.Place.UwzglednienieLukiPlacowe` (enum) | bazodanowe |  |  |
| Dodatkowe.Refundowany | `Soneta.Place.RodzajRefundacjiWynagrodzenia` (enum) | tylko-odczyt |  |  |
| Dodatkowe.RefundowanyInfo | `Soneta.Place.RodzajRefundacjiWynagrodzenia` (enum) | bazodanowe |  |  |
| ElementyWynagrodzen | `SubTable` | podlista |  |  |
| ElementyZestawów | `SubTable<Soneta.Kadry.ElementZestawuDodatków>` | podlista |  |  |
| GUS | `Soneta.Place.StatystykaGUSPL` (subrow) | bazodanowe |  |  |
| GUS.Kategoria | `Soneta.Place.KategoriaWynagrodzeniaGUS` (enum) | bazodanowe |  |  |
| GUS.RodzajSkladnikaWynagrodzeniaGus | `Soneta.Place.RodzajSkladnikaWynagrodzeniaGUSZ12` (enum) | bazodanowe |  |  |
| GUS.WykazujNaDeklaracjach | `bool` | tylko-odczyt |  |  |
| GUS.ZaliczajDoCzasuPracy | `bool` | bazodanowe |  |  |
| GenerujZerowy | `bool` | bazodanowe |  |  |
| Info | `Soneta.Place.DefinicjaElementu._Info` | tylko-odczyt |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kolejnosc | `int` | bazodanowe |  |  |
| Korygowany | `bool` | bazodanowe |  |  |
| MinimalneWynagrodzenie | `bool` | bazodanowe |  |  |
| Nastepny | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaPomocnicza | `string` | bazodanowe |  |  |
| Nieobecnosci | `Soneta.Place.NieobecnosciDefElementu` (subrow) | bazodanowe |  |  |
| Nieobecnosci.DefinicjaLimitu | `Soneta.Kalend.DefinicjaLimitu` | bazodanowe |  |  |
| Nieobecnosci.DoMinimalnej | `bool` | bazodanowe |  |  |
| Nieobecnosci.Ekwiwalent | `Soneta.Place.PodstawaUrlopu` (subrow) | bazodanowe |  |  |
| Nieobecnosci.OdMiesiaca | `Soneta.Place.DefinicjeMiesiecy` (enum) | bazodanowe |  |  |
| Nieobecnosci.Urlop | `Soneta.Place.PodstawaUrlopu` (subrow) | bazodanowe |  |  |
| Nieobecnosci.Urlop.Dopelnienie | `bool` | bazodanowe |  |  |
| Nieobecnosci.Urlop.Typ | `Soneta.Place.TypPodstawyUrlopu` (enum) | bazodanowe |  |  |
| Nieobecnosci.Urlop.Wskaźnik | `string` |  |  |  |
| Nieobecnosci.Urlop.WspolczynnikNazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| Nieobecnosci.Urlop.WspolczynnikTyp | `Soneta.Place.TypWspolczynnikaUrlopu` (enum) | bazodanowe |  |  |
| Nieobecnosci.Urlop.Wynagrodzenie | `string` |  |  |  |
| Nieobecnosci.Urlop.Zasiłek | `string` |  |  |  |
| Nieobecnosci.WahaniaWysokosci | `bool` | bazodanowe |  |  |
| Nieobecnosci.WgDefinicjaLimitu | `Key` | podlista |  |  |
| Nieobecnosci.WliczanieDoPodstawyChorobowego | `Soneta.Place.SposobyWliczaniaDoPodstawyChorobowego` (enum) | bazodanowe |  |  |
| Nieobecnosci.ZasilkiInni | `Soneta.Place.PodstawaZasilkow` (subrow) | bazodanowe |  |  |
| Nieobecnosci.ZasilkiPracownicy | `Soneta.Place.PodstawaZasilkow` (subrow) | bazodanowe |  |  |
| Nieobecnosci.ZasilkiPracownicy.Chorobowych | `bool` | bazodanowe |  |  |
| Nieobecnosci.ZasilkiPracownicy.GetChorobowych | `bool` | tylko-odczyt |  |  |
| Nieobecnosci.ZasilkiPracownicy.GetMacierzynskich | `bool` | tylko-odczyt |  |  |
| Nieobecnosci.ZasilkiPracownicy.GetOpiekunczych | `bool` | tylko-odczyt |  |  |
| Nieobecnosci.ZasilkiPracownicy.GetRehabilitacyjnych | `bool` | tylko-odczyt |  |  |
| Nieobecnosci.ZasilkiPracownicy.GetTyp | `Soneta.Place.TypPodstawyZasilku` (enum) | tylko-odczyt |  |  |
| Nieobecnosci.ZasilkiPracownicy.Macierzynskich | `bool` | bazodanowe |  |  |
| Nieobecnosci.ZasilkiPracownicy.Opiekunczych | `bool` | bazodanowe |  |  |
| Nieobecnosci.ZasilkiPracownicy.Rehabilitacyjnych | `bool` | bazodanowe |  |  |
| Nieobecnosci.ZasilkiPracownicy.Typ | `Soneta.Place.TypPodstawyZasilku` (enum) | bazodanowe |  |  |
| OkresNaliczania | `Soneta.Place.OkresNaliczania` (subrow) | bazodanowe |  |  |
| OkresNaliczania.DlaKazdejUmowy | `Soneta.Place.DlaKażdejUmowy` (enum) | bazodanowe |  |  |
| OkresNaliczania.Ilosc | `int` | bazodanowe |  |  |
| OkresNaliczania.IlośćMiesięcy | `int` | tylko-odczyt |  |  |
| OkresNaliczania.Naliczanie | `Soneta.Place.TypNaliczenia` (enum) | bazodanowe |  |  |
| OkresNaliczania.Opoznienie | `int` | bazodanowe |  | Opóźnienie naliczenia elementu w stosunku do rozliczanego okresu |
| OkresNaliczania.Typ | `Soneta.Place.TypOkresuNaliczania` (enum) | bazodanowe |  |  |
| OkresWażności | `FromTo` | podlista |  |  |
| Pierwszy | `Soneta.Place.DefinicjaElementu` | tylko-odczyt |  |  |
| PodlegaRozporzadzeniuMF070122 | `bool` | tylko-odczyt |  |  |
| Podstawowa | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Poprzedni | `Soneta.Place.DefinicjaElementu` | tylko-odczyt |  |  |
| PracownicyZaGranica | `Soneta.Place.PracownicyZaGranicą` (subrow) | bazodanowe |  |  |
| PracownicyZaGranica.KorektaPodstaw | `bool` | bazodanowe |  |  |
| PracownicyZaGranica.Podstawa | `Soneta.Place.PodstawyWynagrodzeniaZaGranicą` (enum) | bazodanowe |  |  |
| Progi | `SubTable<Soneta.Place.ProgStazuPracy>` | podlista |  |  |
| PulpitPracownika | `bool` | bazodanowe |  |  |
| RodzajNaliczania | `Soneta.Place.RodzajeNaliczaniaListPłac` (enum) | bazodanowe |  |  |
| RodzajZrodla | `Soneta.Place.RodzajŹródłaWypłaty` (enum) | bazodanowe, tylko-odczyt |  |  |
| Rozliczenie | `Soneta.Place.RozliczenieElementu` (subrow) | bazodanowe |  |  |
| Rozliczenie.Ewidencja | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| Rozliczenie.Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | iface-ref |  |  |
| Rozliczenie.OpisPrzelewu | `string` | bazodanowe |  |  |
| Rozliczenie.RachunekOdbiorcy | `Soneta.Kasa.RachunekBankowyPodmiotu` |  |  |  |
| Rozliczenie.WgEwidencja | `Key` | podlista |  |  |
| Rozliczenie.WspolnaPlatnosc | `bool` | bazodanowe |  | Wszystkie elementy wg danej dafinicji mają być rozliczone jedną płatnością |
| Rozliczenie.ZawszeGotowka | `bool` |  |  |  |
| Rozliczenie.ZmianaOdbiorcy | `bool` | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| Skrot | `string` | bazodanowe |  |  |
| SposobWliczaniaDoLukiPlacowej | `Soneta.Place.UwzglednienieLukiPlacowe` (enum) | tylko-odczyt |  |  |
| StanowiKUP | `Soneta.Place.ElementStanowiKUP` (enum) | bazodanowe |  |  |
| Tekst | `MemoText` | bazodanowe, podlista |  |  |
| UwzgledniajWLimicieZFSS | `bool` | bazodanowe |  |  |
| UwzgledniajZwrotSkladkiPPK | `Soneta.Place.UwzgledniajZwrotSkladkiPPK` (enum) | bazodanowe |  |  |
| WliczajDoPodstawyWynagrodzeniaZaNadgodziny | `Soneta.Place.WliczajDoPodstawyWynagrodzeniaZaNadgodziny` (enum) | bazodanowe |  |  |
| WliczajUmoweDoStazuPracy | `bool` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wzory | `string` | tylko-odczyt |  |  |
| Zajecie | `Soneta.Place.ZajęcieWynagrodzenia` (subrow) | bazodanowe |  |  |
| Zajecie.Alimenty | `Soneta.Place.PodstawyZajęciaKomorniczego` (enum) | bazodanowe |  |  |
| Zajecie.Komornik | `Soneta.Place.PodstawyZajęciaKomorniczego` (enum) | bazodanowe |  |  |
| Zajecie.Pozostale | `Soneta.Place.PodstawyZajęciaKomorniczego` (enum) | bazodanowe |  |  |
| Zajecie.UwzgledniajJakWyplatyZFSS | `bool` | bazodanowe |  |  |
| Zakres | `Soneta.Kadry.IZakresDefinicji` | bazodanowe, iface-ref |  |  |
| Zaokraglenie | `Soneta.Place.Zaokraglenie` (subrow) | bazodanowe |  |  |
| Zaokraglenie.Podstawa | `bool` | bazodanowe |  | Podstawa ma zostać zaokrąglona do 1 grosza |
| Zaokraglenie.Precyzja | `Soneta.Place.PrecyzjaZaokraglenia` (enum) | bazodanowe |  |  |
| Zaokraglenie.Sposob | `Soneta.Place.SposobZaokraglenia` (enum) | bazodanowe |  |  |
| Zatrudnienie | `Soneta.Place.TypZatrudnienia` (enum) | bazodanowe |  |  |
| ZawszeGotowka | `bool` | bazodanowe |  |  |
| Zerowanie | `bool` | bazodanowe |  | Zerowanie współczynników po wypłace (dotyczy tylko dodatkow) |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Rozliczenie.Odbiorca | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Zakres | `IZakresDefinicji` | `DefinicjaFunduszuPozyczkowego` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypUmowyCywilnoPrawnej (`Soneta.Kadry.TypUmowyCywilnoPrawnej`)
- `NieDotyczy` = 0
- `UdziałWOrganach` = 1 — Udział w organach stanowiących
- `UmowaODzieło` = 2
- `UmowaZlecenia` = 3

### WliczajDoKosztowPlacyEnum (`Soneta.Kadry.WliczajDoKosztowPlacyEnum`)
- `Domyślnie` = 0
- `Tak` = 1
- `Nie` = 2

### ChorobowyZatrudnienie (`Soneta.Place.ChorobowyZatrudnienie`)
- `Pracownik` = 1 — Pracownik
- `InnyUbezpieczony` = 2
- `JakZatrudnienie` = 3

### DefinicjeMiesiecy (`Soneta.Place.DefinicjeMiesiecy`)
- `styczen` = 0 — styczeń
- `luty` = 1 — luty
- `marzec` = 2 — marzec
- `kwiecien` = 3 — kwiecień
- `maj` = 4 — maj
- `czerwiec` = 5 — czerwiec
- `lipiec` = 6 — lipiec
- `sierpien` = 7 — sierpień
- `wrzesien` = 8 — wrzesień
- `pazdziernik` = 9 — październik
- `listopad` = 10 — listopad
- `grudzien` = 11 — grudzień

### DlaKażdejUmowy (`Soneta.Place.DlaKażdejUmowy`)
- `Nie` = 0
- `Tak` = 1
- `Domyślnie` = 2

### ElementStanowiKUP (`Soneta.Place.ElementStanowiKUP`)
- `Domyślnie` = 0
- `Wliczany` = 1
- `NieWliczany` = 2
- `PPKPracodawcy` = 3 — PPK Pracodawcy

### KategoriaWynagrodzeniaGUS (`Soneta.Place.KategoriaWynagrodzeniaGUS`)
- `WgDefinicjiElementu` = 0
- `WypłataUdziałWZysku` = 1 — Wypłata z tytułu udziału w zysku lub nadwyżce bilnasowej w spółdzielniach
- `DodatkoweWynagrodzenieRoczne` = 2 — Dodatkowe wynagrodzenie roczne dla pracowników jednostek sfery budżetowej
- `Honorarium` = 3
- `WynagrodzenieAkwizycyjnoProwizyjne` = 4 — Wynagrodzenie akwizycyjno-prowizyjne
- `WynagrodzenieOsobowe` = 5 — Wynagrodzenie osobowe
- `WynagrodzenieNadliczbowe` = 6 — Wynagrodzenie za pracę w godzinach nadliczbowych
- `WynagrodzeniePracaNakładcza` = 7 — Wynagrodzenie osób wykonujących pracę nakładczą
- `WynagrodzenieUmowa` = 8 — Wynagrodzenia z tytułu umowy-zlecenia lub umowy o dzieło
- `NagrodyIPremieUznaniowe` = 9 — Nagrody i premie uznaniowe
- `NieWykazujNaDeklaracjach` = 99

### KodRNA (`Soneta.Place.KodRNA`)
- `NieDotyczy` = 0 — Nie dotyczy
- `WynagrodzenieZasadnicze` = 11
- `GodzinyNadliczbowe` = 12
- `PremiaMiesięczna` = 21
- `PremiaKwartalna` = 22
- `SkładnikRoczny` = 31
- `SkładnikJednorazowy` = 32
- `InneSkładnikiWynagrodzenia` = 50

### KontrolaMinimalnaStawkaGodz (`Soneta.Place.KontrolaMinimalnaStawkaGodz`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Opcjonalna` = 1
- `Dotyczy` = 2

### KorektaOdchyłek (`Soneta.Place.KorektaDefElementu.KorektaOdchyłek`)
- `Nie` = 0 — Nie
- `Wszystkich` = 1
- `Wybranych` = 2

### TypWynagrodzenia (`Soneta.Place.KreatorAlgorytmu.TypWynagrodzenia`)
- `PrzeciętneMiesięczne` = 1
- `MinimalnyDochódDeklarowany` = 2
- `Najniższe` = 3
- `NajniższeUczniaIRoku` = 4
- `NajniższeUczniaIIRoku` = 5
- `NajniższeUczniaIIIRoku` = 6
- `MinimalnaPodstawaZdrowotnego` = 7
- `NajniższeMłodocianyPrzyuczany` = 8

### TypZasiłku (`Soneta.Place.KreatorAlgorytmu.TypZasiłku`)
- `Porodowy` = 1
- `Pogrzebowy` = 2
- `Pielęgnacyjny` = 3
- `RodzinnyNa1I2Dziecko` = 4
- `RodzinnyNa3Dziecko` = 5
- `RodzinnyNaKolejneDziecko` = 6
- `WychowawczyPodstawaER` = 7
- `Wychowawczy` = 8
- `WychowawczySamotni` = 9
- `Wychowawczy3INastępne` = 10
- `RodzinnyJednorazowy` = 11
- `DodRodzinnyUrodzenieDziecka` = 12
- `DodRodzinnyKształcenieDo5` = 13
- `DodRodzinnyKształceniePow5` = 14
- `DodRodzinnyRokSzkolny` = 15
- `DodRodzinyNaukaPozaZamiesz` = 16
- `DodRodzinyNaukaPozaDojazd` = 17
- `ŚwiadczeniePielęgnacyjne` = 18

### NaliczaniePit26 (`Soneta.Place.NaliczaniePit26`)
- `Warunkowo` = 0
- `Tak` = 1
- `Nie` = 2

### PodstawaAlgorytmuZa (`Soneta.Place.PodstawaAlgorytmuZa`)
- `NieZależyOdCzasu` = 0 — Nie zależy od czasu
- `Godzinę` = 1
- `Miesięcznie` = 2

### PodstawyWynagrodzeniaZaGranicą (`Soneta.Place.PodstawyWynagrodzeniaZaGranicą`)
- `NieDotyczy` = 0
- `Netto` = 1
- `Brutto` = 2

### PodstawyZajęciaKomorniczego (`Soneta.Place.PodstawyZajęciaKomorniczego`)
- `Domyślnie` = 0
- `NiePodlegaZajęciu` = 1
- `DoLimitu` = 2
- `DoLimituZasiłki` = 3
- `WPełnejWysokości` = 4 — W pełnej wysokości
- `TylkoPodatkiISkładki` = 5

### PozycjaRCA (`Soneta.Place.PozycjaRCA`)
- `NieDotyczy` = 0
- `ZasiłekRodzinny` = 1
- `DodatekRodzinny` = 2
- `ZasiłekPielęgnacyjny` = 3
- `ZasiłekWychowawczy` = 4
- `DodDoZasRodzinnego` = 5 — Dodatek do zasiłku rodzinnego
- `PodstawowaSkładkaNaPFE` = 10 — Podstawowa składka na PFE
- `ZwrotSkładkiNaPPKUczestnika` = 11 — Zwrot składki na PPK uczestnika
- `ZwrotSkładkiNaPPKPracodawcy` = 12 — Zwrot składki na PPK pracodawcy

### PozycjaRP7 (`Soneta.Place.PozycjaRP7`)
- `NieDotyczy` = 0 — Nie dotyczy
- `SkładnikiStałe` = 1
- `SkładnikiZmienne` = 2
- `Inne` = 3
- `ŚwiadczeniaWNaturze` = 4
- `ŚwiadczeniaZUbezpieczenia` = 5
- `SkłBezZUSwOkrNieob` = 6 — Skł.bez ZUS w okr.nieob.

### PrecyzjaZaokraglenia (`Soneta.Place.PrecyzjaZaokraglenia`)
- `DoPełnychSetekZłotych` = -2
- `DoPełnychPięciuDziesiątekZłotych` = -501
- `DoPełnychDziesiątekZłotych` = -1 — Do pełnych dziesiątek złotych
- `DoPełnychPięciuZłotych` = 500
- `DoPełnegoZłotego` = 0
- `DoPełnychPięciuDziesiątekGroszy` = 501
- `DoPełnychDziesiątekGroszy` = 1
- `DoPełnychPięciuGroszy` = 502
- `DoPełnegoGrosza` = 2

### RodzajPomniejszenia (`Soneta.Place.RodzajPomniejszenia`)
- `NiePomniejsza` = 0 — Nie pomniejsza
- `Proporcjonalnie` = 1
- `JednaTrzydziesta` = 2
- `JakZasadnicze` = 3
- `ZaKażdyDzień` = 4
- `ProporcjonalnieZero` = 5
- `Algorytm` = 6

### RodzajRefundacjiWynagrodzenia (`Soneta.Place.RodzajRefundacjiWynagrodzenia`)
- `Domyślny` = 0
- `NiePodlega` = 1
- `Wynagrodzenie` = 2
- `PrzestójEkonomiczny` = 3

### RodzajSkladnikaWynagrodzeniaGUSZ12 (`Soneta.Place.RodzajSkladnikaWynagrodzeniaGUSZ12`)
- `WgDefinicjiElementu` = 0
- `WyplataZTytuluUdzialuWZyskuLubNadwyzceBilansowejWSpóldzielniach` = 1 — Wypłata z tytułu udziału w zysku lub nadwyżce bilansowej w spółdzielniach
- `DodatkoweWynagrodzenieRoczneDlaPracownikowJednostekSferyBudzetowej` = 2 — Dodatkowe wynagrodzenie roczne dla pracowników jednostek sfery budżetowej
- `Honorarium` = 3 — Honorarium
- `WynagrodzenieZaCzasNominalny` = 4 — Wynagrodzenie za czas nominalny
- `WynagrodzenieZaPraceWGodzinachNadliczbowych` = 5 — Wynagrodzenie za pracę w godzinach nadliczbowych
- `NagrodyIPremieUznaniowe` = 6 — Nagrody i premie uznaniowe
- `DodatkiZaPraceZmianowa` = 7 — Dodatki za pracę zmianową
- `PremieRegulaminowe` = 8 — Premie regulaminowe
- `WynagrodzenieZasadnicze` = 9 — Wynagrodzenie zasadnicze
- `NieWykazujNaDeklaracjach` = 10 — Nie wykazuj na deklaracjach

### RodzajeNaliczaniaListPłac (`Soneta.Place.RodzajeNaliczaniaListPłac`)
- `Wszystkie` = 0 — Wszystkie
- `TylkoRzeczywiste` = 1
- `TylkoPlanowane` = 2

### RodzajeRozliczeniaUmowyAlgorytm (`Soneta.Place.RodzajeRozliczeniaUmowyAlgorytm`)
- `Dowolny` = 0
- `KwotaDoWypłaty` = 1
- `StawkaZaOkres` = 2
- `StawkaZaGodzinę` = 3

### RodzajŹródłaWypłaty (`Soneta.Place.RodzajŹródłaWypłaty`)
- `Etat` = 1
- `Nieobecność` = 2
- `Umowa` = 3
- `Akord` = 4
- `Storno` = 5
- `Dodatek` = 6
- `NadgodzinyI` = 7 — Nadgodziny I
- `NadgodzinyII` = 8 — Nadgodziny II
- `NadgodzinyŚw` = 9
- `Nocne` = 10
- `Kurs` = 11
- `Świadczenie` = 12
- `Nagroda` = 13
- `Kara` = 14
- `FundPożWpisowe` = 15
- `FundPożWycofanie` = 16
- `FundPożSkładka` = 17
- `Pożyczka` = 18
- `PożyczkaSpłata` = 19
- `Zaliczka` = 21
- `SpłataZaliczki` = 22 — Zaliczka zwrot
- `ZajęcieKomornicze` = 23
- `Odchyłki` = 24
- `DodatekAutomatyczny` = 25
- `ZbiegPracyIRodzicielstwa` = 26
- `PIT40` = 27 — PIT-40
- `ZajęcieKomorniczeZwrotNadpłaty` = 28
- `ZajęcieKomorniczeUznanieNadpłaty` = 29
- `ZajęcieKomorniczeRozliczDepozytu` = 30
- `UmowaRozliczenie` = 31
- `WyrównanieDoMinimalnej` = 32
- `ZwrotNadpłatyPPK` = 33 — Zwrot nadpłaty PPK
- `PrzychódOdSkładkiPracodawcyPPK` = 34 — Przychód od składki pracodawcy PPK

### SposobZaokraglenia (`Soneta.Place.SposobZaokraglenia`)
- `Standardowe` = 0
- `ZawszeWDół` = 1
- `ZawszeWGórę` = 2

### SposobyProporcjonalności (`Soneta.Place.SposobyProporcjonalności`)
- `NiePomniejszany` = 0 — Nie
- `Proporcjonalnie` = 1 — Prop.
- `JednaTrzydzista` = 2 — 1/30
- `DniKalendarzowe` = 3 — Kalend.

### SposobyPrzeliczeniaNa1h (`Soneta.Place.SposobyPrzeliczeniaNa1h`)
- `NiePrzeliczaj` = 0
- `WgPlanu` = 1
- `WgArt130KP` = 2 — Wg normy kodeksowej (art. 130 K.P.)
- `WgPlanuArt130KP` = 3 — Wg planu z uwzględnieniem art. 130 K.P.

### SposobyWliczaniaDoPodstawyChorobowego (`Soneta.Place.SposobyWliczaniaDoPodstawyChorobowego`)
- `Domyślnie` = 0 — Domyślnie
- `Zawsze` = 1
- `DoKońcaOkresuWypłaty` = 2
- `DoDatyZakończeniaWypłaty` = 3

### TrybPodleganiaRozporzadzeniuMF070122 (`Soneta.Place.TrybPodleganiaRozporzadzeniuMF070122`)
- `Domyślnie` = 0 — Domyślnie
- `Nie` = 1
- `Tak` = 2

### TypAlgorytmuElementu (`Soneta.Place.TypAlgorytmuElementu`)
- `KreatorAlgorytmu` = 1 — Kreator algorytmu
- `EdytorAlgorytmu` = 2
- `KlasaAlgorytmu` = 3
- `ZaOkresNieobecności` = 10
- `PomniejszeniaIOdchyłki` = 11
- `JakUrlopWypoczynkowy` = 20
- `JakUrlopOkolicznościowy` = 21
- `JakEkwiwalentZaUrlop` = 22
- `JakChorobowe` = 23

### TypCzasuPracy (`Soneta.Place.TypCzasuPracy`)
- `NieUwzględniaj` = 0
- `WpisanyCzasPracy` = 1
- `NominalnyCzasPracy` = 2
- `RzeczywistyCzasPracy` = 3
- `CzasPracyWNocy` = 4
- `CzasPracyWNiedzieleIŚwięta` = 5
- `CzasPracyWDniDodatkowoWolneOdPracy` = 6
- `CzasPracyWNiedzieleIŚwiętaOrazDniWolneOdPracy` = 7
- `LiczbaNadgodzin50` = 8
- `LiczbaNadgodzin100` = 9
- `LiczbaNadgodzinŚwięta` = 10
- `LiczbaNadgodzin100Święta` = 11 — Liczba nadgodzin 100 święta
- `LiczbaNadgodzinRazem` = 12
- `WgWybranejStrefy` = 13
- `CzasPracyWNormie` = 14
- `LiczbaNadgodzin50Okres` = 15 — Liczba nadgodzin 50 (za okres)
- `LiczbaNadgodzin100Okres` = 16 — Liczba nadgodzin 100 (za okres)
- `LiczbaNadgodzinŚwiętaOkres` = 17 — Liczba nadgodzin święta (za okres)
- `LiczbaNadgodzin100ŚwiętaOkres` = 18 — Liczba nadgodzin 100 święta (za okres)
- `LiczbaNadgodzinRazemOkres` = 19 — Liczba nadgodzin razem (za okres)
- `LiczbaNadgodzin100TylkoDoba` = 20 — Liczba nadgodzin 100 dobowe
- `LiczbaNadgodzin100TylkoOkres` = 21 — Liczba nadgodzin 100 okresowe
- `LiczbaNadgodzin100TylkoDobaOkres` = 22 — Liczba nadgodzin 100 dobowe (za okres)
- `LiczbaNadgodzin100TylkoOkresOkres` = 23 — Liczba nadgodzin 100 okresowe (za okres)
- `RzeczywistyCzasPracyUmowa` = 24 — Rzeczywisty czas pracy (umowa)

### TypKosztowUzyskaniaPrzychodu (`Soneta.Place.TypKosztowUzyskaniaPrzychodu`)
- `NieNaliczać` = 0
- `ZeStosunkuPracy` = 1
- `ZeStosunkuPracy50` = 2
- `Procentowe` = 3
- `WWysokościStosunkuPracy` = 4 — W wysokości stosunku pracy
- `Procentowe50` = 5
- `ProcentoweWarunkowo` = 6
- `WWysokościStosunkuPracyWarunkowo` = 7 — W wysokości stosunku pracy warunkowo
- `KosztyAutorskie50` = 8

### TypLimituPotrącenia (`Soneta.Place.TypLimituPotrącenia`)
- `NieDotyczy` = 0
- `Uwzględniaj` = 1
- `Standardowy` = 2
- `Alimenty` = 3
- `Minimalne80` = 10 — 80% minimalnego
- `Minimalne100` = 11 — 100% minimalnego

### TypNaliczenia (`Soneta.Place.TypNaliczenia`)
- `PłatnaZGóry` = 1 — Płatna z góry
- `PłatnaZDołu` = 2

### TypOkresuNaliczania (`Soneta.Place.TypOkresuNaliczania`)
- `Jednorazowa` = 1
- `Każda` = 2 — Każdy okres
- `CoNMiesięcy` = 3
- `CoNLat` = 4
- `CoNTygodni` = 5
- `KażdaWypłata` = 6

### TypPodstawyAlgorytmu (`Soneta.Place.TypPodstawyAlgorytmu`)
- `Kwota` = 1 — Kwota
- `Cecha` = 2
- `Wyrażenie` = 3
- `KodMetody` = 4
- `Wynagrodzenia` = 10
- `Zasiłki` = 11
- `Wskaźniki` = 12
- `NajniższeWynagrodzenie1h` = 20
- `StawkaZaszeregowania1h` = 21
- `MaksStawkaNajniższe1h` = 22
- `ZasadniczeNominalne` = 23
- `ZasadniczeRzeczywiste` = 24
- `ZasadniczeZNadgodzinami` = 25
- `Brutto` = 26
- `BruttoBezZasiłków` = 27
- `BruttoBezZasiłkówBezWynChor` = 28
- `NominalneWOkresieZatrudnienia` = 29
- `StawkaNorma1h` = 30
- `NajniższeWynagrodzenieNormatywne1h` = 31
- `StawkaZaszeregowaniaNormatywna1h` = 32
- `ZaOkresNieobecności` = 40
- `PodstawaUrlopuWypoczynkowego1h` = 50
- `PodstawaUrlopuOkolicznościowego1h` = 51
- `PodstawaEkwiwalentu1h` = 52
- `PodstawaNadgodzin1h` = 53

### TypPodstawyUrlopu (`Soneta.Place.TypPodstawyUrlopu`)
- `NieWliczać` = 0 — Nie wliczać
- `WliczaćAktualnąWartość` = 1
- `WliczaćPoPrzeliczeniu` = 2
- `Wliczać` = 3
- `WliczaćJakZasadnicze` = 4

### TypPodstawyZasilku (`Soneta.Place.TypPodstawyZasilku`)
- `NieWliczać` = 0
- `WliczaćDla` = 1
- `DopełniaćWedługGodzinDla` = 2
- `DopełniaćWedługDniDla` = 3
- `DopełniaćJakZasadniczeDla` = 4
- `WliczaćWNominalnejWysokościDla` = 5
- `DopełniaćWedług130Dla` = 6 — Dopełniać według 1/30 dla

### TypPomniejszeniaFIS (`Soneta.Place.TypPomniejszeniaFIS`)
- `NiePomniejsza` = 0
- `Pomniejsza` = 1
- `PomniejszaDoFIS` = 2 — Pomniejsza do FIS
- `PomniejszaWarunkowo` = 3 — Pomniejsza warunkowo do FIS
- `PomniejszaWarunkowoBezFis` = 4 — Pomniejsza warunkowo

### TypPomniejszeniaPodstawyFIS (`Soneta.Place.TypPomniejszeniaPodstawyFIS`)
- `False` = 0 — Nie
- `True` = 1 — Tak
- `Warunkowo` = 2

### TypPracyNaDzień (`Soneta.Place.TypPracyNaDzień`)
- `OstatniDzieńOkresu` = 0 — Ostatni dzień okresu
- `PierwszyDzieńOkresu` = 1
- `OstatniDzieńPoprzedniegoOkresu` = 2

### TypSkładkiFGŚP (`Soneta.Place.TypSkładkiFGŚP`)
- `Domyślna` = 0
- `NieNaliczać` = 1

### TypSkładkiFP (`Soneta.Place.TypSkładkiFP`)
- `Domyślna` = 0 — Domyślna
- `BezPrzyrównania` = 1
- `ZPrzyrównaniem` = 2

### TypUbezpieczeniaSpolecznego (`Soneta.Place.TypUbezpieczeniaSpolecznego`)
- `NieNaliczać` = 0 — Nie naliczać
- `Naliczać` = 1
- `NieMniejNiż` = 2

### TypUbezpieczeniaZdrowotnego (`Soneta.Place.TypUbezpieczeniaZdrowotnego`)
- `NieNaliczać` = 0
- `Naliczać` = 1
- `NieMniejNiż` = 2
- `Warunkowo` = 3

### TypUlgiPodatkowej (`Soneta.Place.TypUlgiPodatkowej`)
- `NieNaliczać` = 0
- `Naliczać` = 1

### TypWartosciUmowyAlgorytm (`Soneta.Place.TypWartosciUmowyAlgorytm`)
- `Dowolny` = 0
- `Brutto` = 1
- `Netto` = 2

### TypWspolczynnikaAlgorytmu (`Soneta.Place.TypWspolczynnikaAlgorytmu`)
- `BezWspółczynnika` = 0
- `ZależnyOdStażuPracy` = 1
- `Ułamek` = 2
- `Procent` = 3
- `Współczynnik` = 4
- `ZależnyOdStażuPracyZwyczajowego` = 5 — Zależny od stażu pracy (liczonego zwyczajowo)

### TypWspolczynnikaUrlopu (`Soneta.Place.TypWspolczynnikaUrlopu`)
- `Wynagrodzenia` = 10
- `Zasiłki` = 11
- `Wskaźniki` = 12
- `NajniższeWynagrodzenie1h` = 20
- `StawkaZaszeregowania1h` = 21
- `MaksStawkaNajniższe1h` = 22
- `ZasadniczeNominalne` = 23
- `StawkaZaszeregowania` = 24
- `WZerowejWartości` = 25 — W zerowej wartości
- `NajniższeWynagrodzenie` = 26

### TypZaliczkiPodatku (`Soneta.Place.TypZaliczkiPodatku`)
- `NieNaliczać` = 0 — Nie naliczać
- `NaliczaćWgSkaliPodatkowej` = 1
- `Procentowe` = 2
- `ProcentoweJakUmowy` = 3

### TypZatrudnienia (`Soneta.Place.TypZatrudnienia`)
- `Etat` = 1
- `Umowa` = 2
- `InnaWyplata` = 3
- `Warunkowy` = 9
- `WarunkowyLubInna` = 10

### UwzgledniajZwrotSkladkiPPK (`Soneta.Place.UwzgledniajZwrotSkladkiPPK`)
- `NieDotyczy` = 0 — Nie dotyczy
- `ZwrotPoStroniePracownika` = 1 — Zwrot po stronie pracownika
- `ZwrotPoStroniePracodawcy` = 2 — Zwrot po stronie pracodawcy

### UwzglednienieLukiPlacowe (`Soneta.Place.UwzglednienieLukiPlacowe`)
- `Domyslnie` = 0 — Domyślnie
- `NieDotyczy` = 1 — Nie dotyczy
- `Stale` = 2 — Stałe
- `Zmienne` = 3 — Zmienne

### WliczajDoPodstawyWynagrodzeniaZaNadgodziny (`Soneta.Place.WliczajDoPodstawyWynagrodzeniaZaNadgodziny`)
- `Nie` = 0 — Nie
- `WliczajZNominału` = 1 — Wliczaj z nominału
- `WliczajWypłacone` = 2 — Wliczaj wypłacone

### WymaganeUbezpieczenie (`Soneta.Place.WymaganeUbezpieczenie`)
- `NieWymaga` = 0 — Nie wymaga
- `Dowolne` = 1
- `Chorobowe` = 2
- `Wypadkowe` = 3
