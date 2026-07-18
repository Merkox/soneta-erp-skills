# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.SrodekTrwalyBase`
Nazwa tabeli: `SrodkiTrwale`
Tytuł: Ewidencja środków trwałych oraz wartości niematerialnych i prawnych
Opis: Główna kartoteka środków trwałych oraz wartości niematerialnych i prawnych. Przechowuje dane identyfikacyjne, wartości bilansowe i podatkowe, parametry amortyzacji, bilans otwarcia oraz informacje o stanie i leasingu. Stanowi centralny punkt ewidencji majątku trwałego firmy.
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `SrodekTrwalyBaseHistoria`
Implementuje interfejsy: `IInwentarz`, `IElementSlownika`, `IZasobCRM`, `IKodowany`, `IZrodloPodzielnikaKosztow`

- pola bazodanowe (zapisywalne): 46
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 20
- podlisty: 17
- subrowy: 0
- razem: 85

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyZaktualizowaneWartosciBO | `bool` | bazodanowe |  | Czy zaktualizowane wartości bilansu otwarcia |
| DataBO | `Date` | bazodanowe |  | Data bilansu otwarcia środka trwałego |
| DataBO01 | `Date` | tylko-odczyt |  |  |
| DataBOMSR | `Date` | bazodanowe |  | Data bilansu otwarcia wartości MSR |
| DataLikwidacji | `Date` | bazodanowe, tylko-odczyt |  | Data likwidacji środka trwałego (likwidacji, sprzedaży, darowizny ...) |
| DataRejestracji | `Date` | bazodanowe, tylko-odczyt |  | Data rejestracji środka trwałego (według OT) |
| DataRozpoczeciaAmortyzacji | `Date` | bazodanowe, tylko-odczyt |  | Data rozpoczęcia amortyzacji bilansowej środka trwałego (według OT) |
| DataRozpoczeciaAmortyzacjiBO | `Date` | bazodanowe |  | Data rozpoczęcia amortyzacji BO |
| DataRozpoczeciaAmortyzacjiPodatkowa | `Date` | bazodanowe, tylko-odczyt |  | Data rozpoczęcia amortyzacji podatkowej środka trwałego  (według OT) |
| DataRozpoczeciaUzytkowania | `Date` | bazodanowe |  | Data rozpoczęcia użytkowania środka trwałego |
| DataRozpoczeciaUzytkowaniaBO | `Date` | bazodanowe |  | Data rozpoczęcia użytkowania BO |
| DataZakonczeniaAmortyzacji | `Date` | bazodanowe, tylko-odczyt | Data zakończenia amortyzacji | Data zakończenia amortyzacji |
| Dokumenty | `SubTable<Soneta.SrodkiTrwale.DokumentST>` | podlista |  |  |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Historia | `HistorySubTable<Soneta.SrodkiTrwale.SrodekTrwalyBaseHistoria>` | podlista |  |  |
| HistoriaPropAmo | `SubTable<Soneta.SrodkiTrwale.ProporcjaAmortyzacji>` | podlista |  |  |
| KRST | `Soneta.SrodkiTrwale.RodzajST` | tylko-odczyt |  | Rodzaj środka wg KRŚT |
| Kategoria | `Soneta.SrodkiTrwale.KategoriaST` | bazodanowe |  |  |
| KategoriaWNiPF03 | `Soneta.SrodkiTrwale.KategoriaF03_WNiP` (enum) | bazodanowe | Kategoria WNiP F-03 |  |
| Kod | `string` | tylko-odczyt |  |  |
| KodZasobu | `string` | tylko-odczyt |  |  |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| LT | `Soneta.SrodkiTrwale.DokumentST` | tylko-odczyt |  |  |
| Last | `Soneta.SrodkiTrwale.SrodekTrwalyBaseHistoria` | tylko-odczyt |  |  |
| LeasingHist | `FromToSubTable<Soneta.SrodkiTrwale.SrodekTrwalyLeasing>` | podlista |  |  |
| Leasingowany | `bool` | bazodanowe | Leasingowany |  |
| Lokalizacja | `Soneta.SrodkiTrwale.LokalizacjaNier` | tylko-odczyt |  | Lokalizacja nieruchomości |
| MetodaBOMSR | `Soneta.SrodkiTrwale.MetodaObliczeniaWartosciMSR` (enum) | bazodanowe |  | Metoda obliczenia wartości MSR |
| MiejsceUzytkowania | `Soneta.SrodkiTrwale.MiejsceUzytkowania` | bazodanowe |  |  |
| MiesiacNaliczeniaPodatku | `YearMonth` | bazodanowe |  | Miesiac naliczenia podatku od nieruchomości |
| Nazwa | `string` | bazodanowe |  | Nazwa środka trwałego |
| NazwaZasobu | `string` | tylko-odczyt |  |  |
| NumerDokumentuOT | `string` | bazodanowe |  | Numer dokumentu OT |
| NumerFabryczny | `string` | bazodanowe |  | Numer fabryczny środka trwałego |
| NumerInwentarzowy | `string` | bazodanowe |  | Numer inwentarzowy środka trwałego |
| OT | `Soneta.SrodkiTrwale.DokumentST` | tylko-odczyt |  |  |
| ObrotLT | `Soneta.SrodkiTrwale.ObrotLT` | tylko-odczyt |  |  |
| ObrotOT | `Soneta.SrodkiTrwale.ObrotOT` | tylko-odczyt |  |  |
| Obroty | `SubTable<Soneta.SrodkiTrwale.ObrotST>` | podlista |  |  |
| ObrotyOT | `System.Collections.Generic.List<Soneta.SrodkiTrwale.ObrotOT>` | podlista |  |  |
| ObrotyTable | `Soneta.SrodkiTrwale.ObrotyST` | podlista |  |  |
| OdpisyAktualizujaceBilansoweBO | `Currency` | bazodanowe |  | Odpisy aktualizujące bilansowe do dnia bilansu otwarcia |
| OdpisyAktualizujacePodatkoweBO | `Currency` | bazodanowe |  | Odpisy aktualizujące podatkowe do dnia bilansu otwarcia |
| OdpisyBilansoweBO | `Currency` | bazodanowe |  | Odpisy bilansowe do dnia bilansu otwarcia |
| OdpisyBilansoweBO01 | `Currency` | bazodanowe |  | Odpisy bilansowe do 01.01 roku bilansu otwarcia |
| OdpisyPodatkoweBO | `Currency` | bazodanowe |  | Odpisy podatkowe do dnia bilansu otwarcia |
| OdpisyPodatkoweBO01 | `Currency` | bazodanowe |  | Odpisy podatkowe na 01.01 roku bilansu otwarcia |
| Opis | `string` | bazodanowe |  | Opis środka trwałego |
| PlanAmortyzacji | `SubTable<Soneta.SrodkiTrwale.ElemPlanuAmortyzacji>` | podlista |  |  |
| Podzielniki | `SubTable<Soneta.Core.PodzielnikKosztow>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| PozyskanieData | `Date` | bazodanowe | Data pozyskania |  |
| PozyskanieDokIdent | `System.Guid` | bazodanowe |  |  |
| PozyskanieDokument | `Soneta.Core.DokEwidencji` |  |  |  |
| PozyskanieNrDokumentu | `string` | bazodanowe | Nr dokumentu pozyskania |  |
| RataHist | `SubTable<Soneta.SrodkiTrwale.RataLeasingST>` | podlista |  |  |
| RodzajDokumentuOT | `Soneta.SrodkiTrwale.TytulDokumentuST` | bazodanowe |  | Rodzaj dokumentu OT |
| RodzajNieruchomosci | `Soneta.SrodkiTrwale.TypNieruchomosci` (enum) | bazodanowe |  | Rodzaj nieruchomości do podatku od nieruchomości |
| RozpoczecieAmortyzacji | `bool` | bazodanowe |  | Rozpoczęcie amortyzacji bilansowej 1 dnia miesiąca rozpoczęcia użytkowania lub następnego. |
| RozpoczecieAmortyzacjiPodatkowa | `bool` | bazodanowe |  | Rozpoczęcie amortyzacji podatkowej 1 dnia miesiąca rozpoczęcia użytkowania lub następnego. |
| Segment | `string` | tylko-odczyt |  |  |
| Stan | `Soneta.SrodkiTrwale.StanSrodkaTrwalego` (enum) | bazodanowe, tylko-odczyt |  | Stan środka trwałego |
| StawkaVAT | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka VAT |
| Terminarz | `SubTable<Soneta.SrodkiTrwale.PozycjaTerminarzaInw>` | podlista |  |  |
| Typ | `Soneta.SrodkiTrwale.TypSrodkaTrwalego` (enum) | bazodanowe, tylko-odczyt |  | Typ środka trwałego |
| TypZasobu | `string` | tylko-odczyt |  |  |
| WartoscBOMSR | `Currency` | bazodanowe |  | Wartość bilansu otwarcia MSR |
| WartoscBilansowaBO | `Currency` | bazodanowe |  | Wartość bilansowa na dzień bilansu otwarcia |
| WartoscBilansowaBO01 | `Currency` | bazodanowe |  | Wartość bilansowa na 01.01 roku bilansu otwarcia |
| WartoscPoczatkowaBilansowaBO | `Currency` | bazodanowe |  | Wartość początkowa bilansowa bilansu otwarcia |
| WartoscPoczatkowaPodatkowaBO | `Currency` | bazodanowe |  | Wartość początkowa podatkowa bilansu otwarcia |
| WartoscPodatkowaBO | `Currency` | bazodanowe |  | Wartość podatkowa na dzień  bilansu otwarcia |
| WartoscPodatkowaBO01 | `Currency` | bazodanowe |  | Wartość podatkowa na 01.01 roku bilansu otwarcia |
| WspolczynnikBOMSR | `Percent` | bazodanowe |  | Wartość współczynnika obliczenia wartości MSR |
| ZaktualizowanaWartoscOdpisowBilansowaBO | `Currency` | bazodanowe |  | Zaktualizowana wartość początkowa podatkowa bilansu otwarcia |
| ZaktualizowanaWartoscOdpisowPodatkowaBO | `Currency` | bazodanowe |  | Zaktualizowana wartość odpisów podatkowa bilansu otwarcia |
| ZaktualizowanaWartoscPoczatkowaBilansowaBO | `Currency` | bazodanowe |  | Zaktualizowana wartość początkowa bilansowa bilansu otwarcia |
| ZaktualizowanaWartoscPoczatkowaPodatkowaBO | `Currency` | bazodanowe |  | Zaktualizowana wartość odpisów bilansowa bilansu otwarcia |
| ZasobyCRM | `SubTable` | podlista |  |  |
| ZbycieData | `Date` | bazodanowe | Data zbycia |  |
| ZbycieDokIdent | `System.Guid` | bazodanowe |  |  |
| ZbycieDokument | `Soneta.Core.DokEwidencji` |  |  |  |
| ZbycieNrDokumentu | `string` | bazodanowe | Nr dokumentu zbycia |  |
| ZrodlaFinansowania | `Soneta.Core.ZrodloFinansowania[]` | podlista |  |  |
| ZrodlaFinansowaniaDotychczasowe | `Soneta.Core.ZrodloFinansowania[]` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategoriaF03_WNiP (`Soneta.SrodkiTrwale.KategoriaF03_WNiP`)
- `Brak` = 0
- `AutorskiePrawaMajatkowe` = 1 — Autorskie prawa majątkowe
- `DokumentacjaIProjektyZagospodarowaniaZloz` = 2 — Dokumentacja i projekty zagospodarowania złóż
- `DokumentacjaOcenyEksploatacjiZloz` = 3 — Dokumenty oceny eksploatacji złóż
- `Koncesja` = 4 — Koncesja
- `Licencja` = 5 — Licencja
- `OprogramowanieKomputerowe` = 6 — Oprogramowanie komputerowe
- `PrawaDoPatentow` = 7 — Prawa do patentów
- `PrawaDoWynalazkow` = 8 — Prawa do wynalazków
- `PrawaDoZnakowTowarowych` = 9 — Prawa do znaków towarowych, użytkowych oraz zdobniczych
- `PrawaEksploatacjiGruntuZwiazanegoZeZlozami` = 10 — Prawa eksploatacji gruntu związanego ze złożami
- `PrawaPokrewne` = 11 — Prawa pokrewne

### MetodaObliczeniaWartosciMSR (`Soneta.SrodkiTrwale.MetodaObliczeniaWartosciMSR`)
- `Brak` = 0
- `WgWartościRynkowej` = 1
- `WgWspółczynnikaPrzeszacowania` = 2 — Wg współczynnika
- `Dowolna` = 3

### StanSrodkaTrwalego (`Soneta.SrodkiTrwale.StanSrodkaTrwalego`)
- `Wpisany` = 0
- `Zarejestrowany` = 1
- `Zlikwidowany` = 2

### TypNieruchomosci (`Soneta.SrodkiTrwale.TypNieruchomosci`)
- `Grunt` = 0
- `Budynek` = 1
- `Budowla` = 2
- `Brak` = 3

### TypSrodkaTrwalego (`Soneta.SrodkiTrwale.TypSrodkaTrwalego`)
- `Brak` = 0
- `ŚrodekTrwały` = 1
- `WartośćNiematerialnaIPrawna` = 2
- `Wyposażenie` = 3
