# Pola i właściwości klasy biznesowej: `Soneta.Towary.Towar`
Nazwa tabeli: `Towary`
Opis: Główna kartoteka towarów i usług stanowiąca podstawę ewidencji asortymentu handlowego. Przechowuje dane identyfikacyjne (kod, nazwa, EAN, numer katalogowy), parametry podatkowe (stawki VAT sprzedaży i zakupu, PKWiU), jednostki miary, ceny bazowe (narzut, marża, cena zakupu kartotekowa), klasyfikacje celne i statystyczne (CN, CPV, BDO, SUP) oraz ustawienia magazynowe i kompletacyjne.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IElementSlownikZewnRel`, `IKodowany`, `IAdresyWWWHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresyWWW | `SubTable<Soneta.Core.AdresWWW>` | podlista |  |  |
| AktualizujCeny | `Soneta.Towary.WarunekAktualizacjiCeny` (enum) | bazodanowe |  | Określa kiedy cena danego towaru ma być aktualizowana po wprowadzeniu przychodu. |
| AlternatywneDefinicjeStawekInfo | `Soneta.Towary.AlternatywneDefinicjeStawekInfo` (subrow) | bazodanowe | Alternatywne definicje stawek VAT | Alternatywne definicje stawek VAT. |
| AlternatywneDefinicjeStawekInfo.PowodZmianyStawkiVat | `Soneta.Towary.PowodZmianyStawkiVat` (enum) | bazodanowe |  | Informacja o przyczynie zmiany stawek VAT i konieczności stosowania stawek alternatywnych. |
| AlternatywneDefinicjeStawekInfo.Sprzedaz | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe | Alternatywna definicja stawki VAT sprzedaży. | Alternatywna definicja stawki VAT (procent stawki VAT) dla operacji sprzedaży. |
| AlternatywneDefinicjeStawekInfo.WgSprzedaz | `Key` | podlista |  |  |
| AlternatywneDefinicjeStawekInfo.WgZakup | `Key` | podlista |  |  |
| AlternatywneDefinicjeStawekInfo.Zakup | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe | Alternatywna definicja stawki VAT zakupu. | Alternatywna definicja stawki VAT (procent stawki VAT) dla operacji zakupu. |
| BDO | `Soneta.Towary.KodBDO` | bazodanowe | Kod BDO |  |
| BilansOpakowań | `System.Collections.Generic.List<Soneta.Towary.BilansOpakowańOgólnyWorker.BilansOpakowaniaItem>` | podlista |  |  |
| BilansOpakowańWgKontrahentów | `System.Collections.Generic.List<Soneta.Towary.BilansOpakowańKontrahenciWorker.BilansOpakowańKontrahentaItem>` | podlista |  |  |
| Blokada | `bool` | bazodanowe |  | Określa, czy dany towar ma być widoczny na listach wyboru podczas pracy. |
| CN | `Soneta.Towary.KodCN` | bazodanowe | Kod CN |  |
| CPV | `Soneta.Towary.KodCPV` | bazodanowe | Kod CPV |  |
| CechyWgZestawow | `bool` | bazodanowe |  | Określa, czy cechy towaru będą wyświetlane według przypisanych zestawów pól. |
| CenaZakupuKartotekowa | `DoubleCy` | bazodanowe |  | Cena zakupu przechowywana na kartotece towarowej |
| Ceny | `Soneta.Towary.Towar.CenySubTable` | podlista |  |  |
| CenyIndywidualne | `SubTable<Soneta.Towary.CenaIndywidualna>` | podlista |  |  |
| CenyProgowe | `SubTable<Soneta.Towary.CenaProgowa>` | podlista |  |  |
| DefinicjaPowstaniaObowiazkuVATInfo | `Soneta.Towary.DefinicjaPowstaniaObowiazkuVATInfo` (subrow) | bazodanowe |  | Informacje o definicji powstania obowiązku VAT. |
| DefinicjaPowstaniaObowiazkuVATInfo.Sprzedaz | `Row` | bazodanowe |  | Definicja powstania obowiązku VAT dla transakcji sprzedaży. |
| DefinicjaPowstaniaObowiazkuVATInfo.WgSprzedaz | `Key` | podlista |  |  |
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT (procent stawki VAT) dla operacji sprzedaży |
| DefinicjaStawkiKaucji | `Soneta.Core.DefinicjaStawkiVat` | tylko-odczyt | Stawka VAT kaucji | Definicja stawki VAT opakowań kaucjonowanych |
| DefinicjaStawkiVatZwrotowKaucji | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe | Stawka VAT w systemie kaucyjnym. |  |
| DefinicjaStawkiZakupu | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT (procent stawki VAT) dla operacji zakupu. |
| DoWyprzedazy | `bool` | bazodanowe |  | Flaga oznaczająca, że towar jest tylko dostępny do wyprzedaży. Nie można go już kupować. |
| DoliczajKosztDodatkowy | `bool` | bazodanowe | Doliczanie kosztu dodatkowego | Doliczanie kosztu dodatkowego. |
| DomyślnyAdresWWW | `string` | tylko-odczyt | Domyślny adres WWW |  |
| Dostawca | `Soneta.CRM.Kontrahent` | bazodanowe |  | Standardowy dostawca towaru, dla którego mogą być generowane zamówienia na ten towar.. |
| Dostawcy | `SubTable<Soneta.Towary.DostawcaTowaru>` | podlista |  |  |
| EAN | `string` | bazodanowe |  | Kod kreskowy wykorzystywany do szybkiego wyszukiwania towaru za pomocą czytnika. |
| Edycja | `bool` |  |  |  |
| EdycjaNazwy | `bool` | bazodanowe |  | Określa, czy jest możliwa edycja nazwy towaru na poszczególnych pozycjach dokumentów handlowych. |
| ElementyKompletu | `LpSubTable<Soneta.Towary.ElementKompletu>` | podlista |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Gratis | `bool` | bazodanowe |  | Gratis |
| GrupaTowarowaVat | `Soneta.Core.ProceduraVAT` | bazodanowe |  |  |
| Jednostka | `Soneta.Towary.Jednostka` | bazodanowe |  | Podstawowa jednostka magazynowa towaru. Wszystkie inne jednostki muszą być przeliczane na tę jednostkę. |
| JednostkaAlternatywna | `Soneta.Towary.Jednostka` | bazodanowe |  | Jednostka alternatywna wykorzystywana przy niektórych dokumentach. |
| JednostkaReszty | `Soneta.Towary.Jednostka` | bazodanowe |  | Jednostka reszty całkowitej ilośći wyrażonej w jednostce alternatywnej. |
| JestUnijny | `bool` | tylko-odczyt |  | Wskazuje, czy towar ma powiązany kod CN |
| KSeFStawkaVat0 | `Soneta.Handel.KSeFStawkaVat0` (enum) | bazodanowe | Rodzaj stawki VAT 0% dla KSeF |  |
| KSeFStawkaVatNP | `Soneta.Handel.KSeFStawkaVatNP` (enum) | bazodanowe | Rodzaj stawki VAT NP dla KSeF |  |
| KategoriaAllegro | `Soneta.Core.SlownikZewn` |  |  |  |
| Kod | `string` | bazodanowe |  | Symbol, skrócona nazwa towaru |
| KodyKontrahenta | `SubTable<Soneta.Towary.KodTwrKontrahent>` | podlista |  |  |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| KodyObce | `object` | tylko-odczyt |  |  |
| KodyWlasne | `object` | tylko-odczyt |  |  |
| KosztDodatkowy | `bool` | bazodanowe |  | Pozycja ma być traktowana przez księgowość jako koszt dodatkowy podnoszący wartość towarów. |
| KrajPochodzenia | `string` | bazodanowe |  | Kod kraju pochodzenia towaru raportowany na dokumencie Intrastat. |
| KrajPochodzeniaNazwa | `string` | tylko-odczyt |  | Pełna nazwa kraju pochodzenia towaru raportowanego na deklaracji Intrastat. |
| LiczMagazyn | `bool` | tylko-odczyt |  | Określa, czy dla danego towaru ma być przeliczany magazyn (stany, obroty). |
| Link | `string` | bazodanowe |  |  |
| MPP | `bool` | bazodanowe | Mechanizm podzielonej płatności | Wymaga mechanizmu podzielonej płatności. |
| MagazynInfo | `Soneta.Towary.TowarMagazynInfoSubTable` | podlista |  |  |
| Marza | `Percent` | bazodanowe | Marża | Marża procentowa wykorzystywana do wyliczania ceny detalicznej |
| MasaBrutto | `Soneta.Towary.Quantity` | bazodanowe |  | Masa brutto dla jednej magazynowej jednostki towaru. |
| MasaNetto | `Soneta.Towary.Quantity` | bazodanowe |  | Masa dla jednej magazynowej jednostki towaru. |
| MinimalnaMarza | `double` | bazodanowe | Minimalna marża | Kwota minimalnej marży, którą należy osiągnąć na sprzedaży towaru. |
| MinimalnaMarzaProcent | `Percent` | bazodanowe | Procent marży minimalnej | Procent minimalnej marży, którą należy osiągnąć na sprzedaży towaru. |
| NabywcaPodatnik | `bool` | bazodanowe | Nabywca podatnik | Sprzedaż opodatkowana po stronie nabywcy |
| Najblizsze | `bool` |  |  |  |
| NajblizszeZamienniki | `System.Collections.IList` | podlista |  |  |
| Narzut | `Percent` | bazodanowe |  | Narzut procentowy wykorzystywany do wyliczania ceny hurtowej |
| Nazwa | `string` | bazodanowe |  | Nazwa, dowolny napis, który może być wykorzystywany na dokumencie handlowym. |
| NazwaIntrastat | `string` | bazodanowe |  | Nazwa o ile wypełniona wykorzystywana na deklaracji Interastat. |
| NumerKatalogowy | `string` | bazodanowe |  | Numer katalogowy towaru, dowolny napis |
| Obroty | `SubTable<Soneta.Magazyny.Obrot>` | podlista |  |  |
| Odpad | `bool` | bazodanowe |  | Określa czy towar jest odpadem. |
| Opakowanie | `bool` | bazodanowe |  | Określa czy towar jest opakowaniem. |
| OpakowaniePozycja | `bool` | bazodanowe |  | Opakowanie za pomocą pozycji. |
| OperacjeWzorProduktu | `View` | podlista |  |  |
| OperacjeWzorSurowca | `View` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Rozszerzony opis towaru, który może być wykorzystywany podczas drukowania dokumentów handlowych. |
| PKWiU | `string` |  | PKWiU | Jest to alias na property SWW |
| Partie | `SubTable<Soneta.Magazyny.Dostawy.GrupaDostaw>` | podlista |  |  |
| PelneKomplety | `bool` | bazodanowe |  | Wymusza kompletacje tylko za pomocą pełnych kompletów. Możliwa jest tylko produkcja będaca wielokrotnością ilości wynikowej. |
| PodTypKoduDlaEAN | `Soneta.Core.PodTypKodu` (enum) |  |  |  |
| Podglad | `bool` | tylko-odczyt |  |  |
| PodlegaEUDR | `bool` | bazodanowe |  | Określa, czy towar podlega procedurze EUDR. |
| PodlegaPSD | `bool` | bazodanowe |  |  |
| PodstawaZwolnienia | `string` | bazodanowe |  | Podstawa prawna do stosowania stawki ZW. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Pozycje | `SubTable<Soneta.Handel.PozycjaDokHandlowego>` | podlista |  |  |
| Precyzja | `int` | bazodanowe |  | Precyzja zaokrąglenia (wyliczania) cen towaru |
| PrefiksGTIN13 | `string` | bazodanowe |  | Prefiks kodu GTIN-13, pierwsze 7 znaków wraz z rodzajem kodu. |
| ProceduraSME | `bool` | bazodanowe | Oznaczenie na pozycji Procedury SME | Domyślnie oznacza na pozycji ProceduraSME jeśli wszystkie warunki są spełnione. |
| ProcentVAT | `Percent` | tylko-odczyt | Procent VAT | Procent stawki VAT do wyliczenia ceny/wartości brutto. |
| Produkt | `Soneta.Towary.ElementKompletu` | tylko-odczyt |  | Zawiera informacje o towarze jako produkcie. |
| ProduktInfo | `Soneta.Towary.ProduktInfo` (subrow) | bazodanowe |  | Informacje specyficzne dla towaru jako produktu. |
| ProduktInfo.CenaEwidencyjna | `Soneta.Towary.DefinicjaCeny` | bazodanowe |  | Cena ewidencyjna produktu. |
| ProduktInfo.CenaIndywidualna | `bool` | bazodanowe |  | Indywidualne ustawienia wartości produktu. |
| ProduktInfo.WgCenaEwidencyjna | `Key` | podlista |  |  |
| Przeceny | `SubTable<Soneta.Towary.PrzecenaOkresowaTowaru>` | podlista |  |  |
| PrzecenyTowaru | `SubTable` | podlista |  |  |
| PrzelicznikiTowaru | `SubTable<Soneta.Towary.PrzelicznikTowaru>` | podlista |  |  |
| RodzajKaucji | `Soneta.Towary.RodzajKaucji` (enum) | bazodanowe | Rodzaj w systemie kaucyjnym |  |
| SUP | `Soneta.Towary.KodSUP` | bazodanowe | Kod SUP |  |
| SWW | `string` | bazodanowe |  | Numer SWW lub PKWIU dla towarów o obniżonej stawce VAT sprzedaży. |
| SchematOpakPrzychDom | `Soneta.Towary.SchemOpakowan` | tylko-odczyt |  |  |
| SchematOpakRozchDom | `Soneta.Towary.SchemOpakowan` | tylko-odczyt |  |  |
| SchematTowarPozycjaPrzychDom | `Soneta.Towary.SchematTowar` | tylko-odczyt |  |  |
| SchematyTowary | `SubTable<Soneta.Towary.SchematTowar>` | podlista |  |  |
| SchematyTowaryOpakowan | `SubTable<Soneta.Towary.SchematTowar>` | podlista |  |  |
| SkładnikProduktów | `View` | podlista |  |  |
| SkładnikiProduktu | `View` | podlista |  | Składniki wchodzące w skład towaru jako produktu. |
| StawkaKGO | `DoubleCy` | bazodanowe | Stawka KGO |  |
| TechnologieWzorProduktu | `View` | podlista |  |  |
| TechnologieWzorSurowca | `View` | podlista |  |  |
| TempZamienniki | `System.Collections.IList` | podlista |  |  |
| TowarEcommerce | `Soneta.Towary.TowarEcommerce` | tylko-odczyt |  |  |
| TowaryProdukcyjne | `SubTable` | podlista |  |  |
| Typ | `Soneta.Towary.TypTowaru` (enum) | bazodanowe |  | Określa czy towar, usługa, produkt |
| VATOdMarzy | `bool` | bazodanowe |  | VAT od pozycji towaru liczony jest od marży. Na pozycji dokumentu handlowego jest NP. |
| Wariantowy | `bool` | bazodanowe |  | Określa, czy towar jest wariantowy. |
| Warianty | `SubTable<Soneta.Towary.WariantTowaru>` | podlista |  |  |
| WszystkieZamienniki | `System.Collections.IList` | podlista |  |  |
| WszystkieZamiennikiTowaru | `System.Collections.IList` | podlista |  |  |
| WyborPartiiOpcje | `Soneta.Towary.GrupyDostawOpcje` (subrow) | bazodanowe |  | Opcje wyboru partii. |
| WyborPartiiOpcje.Autonumerowanie | `Soneta.Towary.GrupyDostawAutonumerowanie` (subrow) | bazodanowe |  |  |
| WyborPartiiOpcje.Autonumerowanie.Cecha | `FeatureDefinition` | bazodanowe | Cecha | Cecha wyliczająca numer partii. |
| WyborPartiiOpcje.Autonumerowanie.Opcje | `Soneta.Handel.WyborPartiiAutonumerowanie` (enum) | bazodanowe | Autonumerowanie partii | Opcje autonumerowania partii. |
| WyborPartiiOpcje.Autonumerowanie.WgCecha | `Key` | podlista |  |  |
| WyborPartiiOpcje.Opcje | `Soneta.Handel.WyborPartiiOpcje` (enum) | bazodanowe | Wybór partii i zasobu | Opcje wyboru partii i zasobu. |
| WyborWariantu | `Soneta.Handel.WyborWariantu` (enum) | bazodanowe | Wybór wariantu | Określa sposób wyboru wariantu. |
| Wymiary | `Soneta.Handel.Wymiary` (subrow) | bazodanowe |  |  |
| Wymiary.Dlugosc | `Soneta.Towary.Quantity` | bazodanowe | Długość |  |
| Wymiary.Objetosc | `Soneta.Towary.Quantity` | bazodanowe | Objętość |  |
| Wymiary.Szerokosc | `Soneta.Towary.Quantity` | bazodanowe | Szerokość |  |
| Wymiary.Wysokosc | `Soneta.Towary.Quantity` | bazodanowe | Wysokość |  |
| ZamiennikiTowaru | `LpSubTable<Soneta.Towary.ZamiennikTowaru>` | podlista |  |  |
| ZaokraglenieZamowienia | `Soneta.Towary.Quantity` | bazodanowe |  | Zaokrąglenie ilości zamawianego towaru w górę oraz jednostka zamówienia. |
| Zasoby | `SubTable<Soneta.Magazyny.Zasob>` | podlista |  |  |
| ZestawCechWariantu | `FeatureSetDefinition` | bazodanowe |  | Wskazanie na zestaw pól wariantowych. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PodTypKodu (`Soneta.Core.PodTypKodu`)
- `None` = 0
- `EAN13` = 1
- `PrefixEAN13` = 2 — Prefix EAN13
- `Inny` = 3

### KSeFStawkaVat0 (`Soneta.Handel.KSeFStawkaVat0`)
- `Brak` = 0
- `KR` = 1 — 0 KR
- `WDT` = 2 — 0 WDT
- `EX` = 3 — 0 EX

### KSeFStawkaVatNP (`Soneta.Handel.KSeFStawkaVatNP`)
- `Brak` = 0
- `NPI` = 1 — NP I
- `NPII` = 2 — NP II

### WyborPartiiAutonumerowanie (`Soneta.Handel.WyborPartiiAutonumerowanie`)
- `Brak` = 0
- `Standardowe` = 1
- `WgCechy` = 2

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

### WyborWariantu (`Soneta.Handel.WyborWariantu`)
- `Recznie` = 0 — Ręcznie
- `Automatycznie` = 1
- `WedlugKartyTowaru` = 2 — Według karty towaru

### PowodZmianyStawkiVat (`Soneta.Towary.PowodZmianyStawkiVat`)
- `None` = 0
- `Styczen2011` = 1 — zmiana ustawy o VAT (od 2011-01-01)

### RodzajKaucji (`Soneta.Towary.RodzajKaucji`)
- `Brak` = 0
- `Razem` = 1
- `Metal` = 2
- `Plastik` = 3
- `Szkło` = 4
- `MetalPlastikSzkło` = 5 — Metal+Plastik+Szkło

### TypTowaru (`Soneta.Towary.TypTowaru`)
- `Towar` = 1 — Towar
- `Usługa` = 2
- `Produkt` = 4
- `Receptura` = 8

### WarunekAktualizacjiCeny (`Soneta.Towary.WarunekAktualizacjiCeny`)
- `Zawsze` = 0 — Zawsze
- `Nigdy` = 1
- `TylkoWzwyż` = 2
