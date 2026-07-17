# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.SrodekTrwalyBase`
Nazwa tabeli: `SrodkiTrwale`
Tytuł: Ewidencja środków trwałych oraz wartości niematerialnych i prawnych
Opis: Główna kartoteka środków trwałych oraz wartości niematerialnych i prawnych. Przechowuje dane identyfikacyjne, wartości bilansowe i podatkowe, parametry amortyzacji, bilans otwarcia oraz informacje o stanie i leasingu. Stanowi centralny punkt ewidencji majątku trwałego firmy.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IInwentarz`, `IElementSlownika`, `IZasobCRM`, `IKodowany`, `IZrodloPodzielnikaKosztow`

- pola bazodanowe: 53
- pola kalkulowane (z klas biznesowych): 33

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyZaktualizowaneWartosciBO | `bool` | bazodanowe |  | Czy zaktualizowane wartości bilansu otwarcia |
| DataBO | `Soneta.Types.Date` | bazodanowe |  | Data bilansu otwarcia środka trwałego |
| DataBO01 | `Soneta.Types.Date` |  |  |  |
| DataBOMSR | `Soneta.Types.Date` | bazodanowe |  | Data bilansu otwarcia wartości MSR |
| DataLikwidacji | `Soneta.Types.Date` | bazodanowe |  | Data likwidacji środka trwałego (likwidacji, sprzedaży, darowizny ...) |
| DataRejestracji | `Soneta.Types.Date` | bazodanowe |  | Data rejestracji środka trwałego (według OT) |
| DataRozpoczeciaAmortyzacji | `Soneta.Types.Date` | bazodanowe |  | Data rozpoczęcia amortyzacji bilansowej środka trwałego (według OT) |
| DataRozpoczeciaAmortyzacjiBO | `Soneta.Types.Date` | bazodanowe |  | Data rozpoczęcia amortyzacji BO |
| DataRozpoczeciaAmortyzacjiPodatkowa | `Soneta.Types.Date` | bazodanowe |  | Data rozpoczęcia amortyzacji podatkowej środka trwałego  (według OT) |
| DataRozpoczeciaUzytkowania | `Soneta.Types.Date` | bazodanowe |  | Data rozpoczęcia użytkowania środka trwałego |
| DataRozpoczeciaUzytkowaniaBO | `Soneta.Types.Date` | bazodanowe |  | Data rozpoczęcia użytkowania BO |
| DataZakonczeniaAmortyzacji | `Soneta.Types.Date` | bazodanowe | Data zakończenia amortyzacji | Data zakończenia amortyzacji |
| Definicja | `Soneta.Core.DefinicjaDokumentu` |  |  |  |
| Dokumenty | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.DokumentST>` |  |  |  |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.SrodkiTrwale.SrodekTrwalyBaseHistoria>` |  |  |  |
| HistoriaPropAmo | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.ProporcjaAmortyzacji>` |  |  |  |
| KRST | `Soneta.SrodkiTrwale.RodzajST` |  |  | Rodzaj środka wg KRŚT |
| Kategoria | `Soneta.SrodkiTrwale.KategoriaST` | bazodanowe |  |  |
| KategoriaWNiPF03 | `Soneta.SrodkiTrwale.KategoriaF03_WNiP` | bazodanowe, enum | Kategoria WNiP F-03 |  |
| Kod | `string` |  |  |  |
| KodZasobu | `string` |  |  |  |
| KodyKreskowe | `Soneta.Business.SubTable<Soneta.Core.KodKreskowy>` |  |  |  |
| LT | `Soneta.SrodkiTrwale.DokumentST` |  |  |  |
| Last | `Soneta.SrodkiTrwale.SrodekTrwalyBaseHistoria` |  |  |  |
| LeasingHist | `Soneta.Business.FromToSubTable<Soneta.SrodkiTrwale.SrodekTrwalyLeasing>` |  |  |  |
| Leasingowany | `bool` | bazodanowe | Leasingowany |  |
| Lokalizacja | `Soneta.SrodkiTrwale.LokalizacjaNier` |  |  | Lokalizacja nieruchomości |
| MetodaBOMSR | `Soneta.SrodkiTrwale.MetodaObliczeniaWartosciMSR` | bazodanowe, enum |  | Metoda obliczenia wartości MSR |
| MiejsceUzytkowania | `Soneta.SrodkiTrwale.MiejsceUzytkowania` | bazodanowe |  |  |
| MiesiacNaliczeniaPodatku | `Soneta.Types.YearMonth` | bazodanowe |  | Miesiac naliczenia podatku od nieruchomości |
| Nazwa | `string` | bazodanowe |  | Nazwa środka trwałego |
| NazwaZasobu | `string` |  |  |  |
| NumerDokumentuOT | `string` | bazodanowe |  | Numer dokumentu OT |
| NumerFabryczny | `string` | bazodanowe |  | Numer fabryczny środka trwałego |
| NumerInwentarzowy | `string` | bazodanowe |  | Numer inwentarzowy środka trwałego |
| OT | `Soneta.SrodkiTrwale.DokumentST` |  |  |  |
| ObrotLT | `Soneta.SrodkiTrwale.ObrotLT` |  |  |  |
| ObrotOT | `Soneta.SrodkiTrwale.ObrotOT` |  |  |  |
| Obroty | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.ObrotST>` |  |  |  |
| ObrotyOT | `System.Collections.Generic.List<Soneta.SrodkiTrwale.ObrotOT>` |  |  |  |
| ObrotyTable | `Soneta.SrodkiTrwale.ObrotyST` |  |  |  |
| OdpisyAktualizujaceBilansoweBO | `Soneta.Types.Currency` | bazodanowe |  | Odpisy aktualizujące bilansowe do dnia bilansu otwarcia |
| OdpisyAktualizujacePodatkoweBO | `Soneta.Types.Currency` | bazodanowe |  | Odpisy aktualizujące podatkowe do dnia bilansu otwarcia |
| OdpisyBilansoweBO | `Soneta.Types.Currency` | bazodanowe |  | Odpisy bilansowe do dnia bilansu otwarcia |
| OdpisyBilansoweBO01 | `Soneta.Types.Currency` | bazodanowe |  | Odpisy bilansowe do 01.01 roku bilansu otwarcia |
| OdpisyPodatkoweBO | `Soneta.Types.Currency` | bazodanowe |  | Odpisy podatkowe do dnia bilansu otwarcia |
| OdpisyPodatkoweBO01 | `Soneta.Types.Currency` | bazodanowe |  | Odpisy podatkowe na 01.01 roku bilansu otwarcia |
| Opis | `string` | bazodanowe |  | Opis środka trwałego |
| PlanAmortyzacji | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.ElemPlanuAmortyzacji>` |  |  |  |
| Podzielniki | `Soneta.Business.SubTable<Soneta.Core.PodzielnikKosztow>` |  |  |  |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| PozyskanieData | `Soneta.Types.Date` | bazodanowe | Data pozyskania |  |
| PozyskanieDokIdent | `System.Guid` | bazodanowe |  |  |
| PozyskanieDokument | `Soneta.Core.DokEwidencji` |  |  |  |
| PozyskanieNrDokumentu | `string` | bazodanowe | Nr dokumentu pozyskania |  |
| RataHist | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.RataLeasingST>` |  |  |  |
| RodzajDokumentuOT | `Soneta.SrodkiTrwale.TytulDokumentuST` | bazodanowe |  | Rodzaj dokumentu OT |
| RodzajNieruchomosci | `Soneta.SrodkiTrwale.TypNieruchomosci` | bazodanowe, enum |  | Rodzaj nieruchomości do podatku od nieruchomości |
| RozpoczecieAmortyzacji | `bool` | bazodanowe |  | Rozpoczęcie amortyzacji bilansowej 1 dnia miesiąca rozpoczęcia użytkowania lub następnego. |
| RozpoczecieAmortyzacjiPodatkowa | `bool` | bazodanowe |  | Rozpoczęcie amortyzacji podatkowej 1 dnia miesiąca rozpoczęcia użytkowania lub następnego. |
| Segment | `string` |  |  |  |
| Stan | `Soneta.SrodkiTrwale.StanSrodkaTrwalego` | bazodanowe, enum |  | Stan środka trwałego |
| StawkaVAT | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Stawka VAT |
| Terminarz | `Soneta.Business.SubTable<Soneta.SrodkiTrwale.PozycjaTerminarzaInw>` |  |  |  |
| Typ | `Soneta.SrodkiTrwale.TypSrodkaTrwalego` | bazodanowe, enum |  | Typ środka trwałego |
| TypZasobu | `string` |  |  |  |
| WartoscBOMSR | `Soneta.Types.Currency` | bazodanowe |  | Wartość bilansu otwarcia MSR |
| WartoscBilansowaBO | `Soneta.Types.Currency` | bazodanowe |  | Wartość bilansowa na dzień bilansu otwarcia |
| WartoscBilansowaBO01 | `Soneta.Types.Currency` | bazodanowe |  | Wartość bilansowa na 01.01 roku bilansu otwarcia |
| WartoscPoczatkowaBilansowaBO | `Soneta.Types.Currency` | bazodanowe |  | Wartość początkowa bilansowa bilansu otwarcia |
| WartoscPoczatkowaPodatkowaBO | `Soneta.Types.Currency` | bazodanowe |  | Wartość początkowa podatkowa bilansu otwarcia |
| WartoscPodatkowaBO | `Soneta.Types.Currency` | bazodanowe |  | Wartość podatkowa na dzień  bilansu otwarcia |
| WartoscPodatkowaBO01 | `Soneta.Types.Currency` | bazodanowe |  | Wartość podatkowa na 01.01 roku bilansu otwarcia |
| WspolczynnikBOMSR | `Soneta.Types.Percent` | bazodanowe |  | Wartość współczynnika obliczenia wartości MSR |
| ZaktualizowanaWartoscOdpisowBilansowaBO | `Soneta.Types.Currency` | bazodanowe |  | Zaktualizowana wartość początkowa podatkowa bilansu otwarcia |
| ZaktualizowanaWartoscOdpisowPodatkowaBO | `Soneta.Types.Currency` | bazodanowe |  | Zaktualizowana wartość odpisów podatkowa bilansu otwarcia |
| ZaktualizowanaWartoscPoczatkowaBilansowaBO | `Soneta.Types.Currency` | bazodanowe |  | Zaktualizowana wartość początkowa bilansowa bilansu otwarcia |
| ZaktualizowanaWartoscPoczatkowaPodatkowaBO | `Soneta.Types.Currency` | bazodanowe |  | Zaktualizowana wartość odpisów bilansowa bilansu otwarcia |
| ZasobyCRM | `Soneta.Business.SubTable` |  |  |  |
| ZbycieData | `Soneta.Types.Date` | bazodanowe | Data zbycia |  |
| ZbycieDokIdent | `System.Guid` | bazodanowe |  |  |
| ZbycieDokument | `Soneta.Core.DokEwidencji` |  |  |  |
| ZbycieNrDokumentu | `string` | bazodanowe | Nr dokumentu zbycia |  |
| ZrodlaFinansowania | `Soneta.Core.ZrodloFinansowania[]` |  |  |  |
| ZrodlaFinansowaniaDotychczasowe | `Soneta.Core.ZrodloFinansowania[]` |  |  |  |

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
