# Pola i właściwości klasy biznesowej: `Soneta.Place.WypElement`
Nazwa tabeli: `WypElementy`
Tytuł: Elementy wypłaty
Opis: Element szczegółowy wypłaty (Wyplata). Reprezentuje pojedynczy naliczony składnik wynagrodzenia z wartością, podatkami, składkami ZUS i okresem, za który został naliczony.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 106
- pola kalkulowane (z klas biznesowych): 165

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Alimenty | `Soneta.Place.PodstawyZajęciaKomorniczego` | enum |  |  |
| BazaZrodla | `Soneta.Place.IBazaZrodlaWyplaty` | bazodanowe, iface-ref |  |  |
| CentrumKosztow | `Soneta.Core.CentrumKosztow` |  |  |  |
| Czas | `Soneta.Types.Time` |  |  | Suma czasów znajdujących się w składnikach wypłaty. Zwraca rzeczywisty czas pracy użyty do wyliczenia wartości elementu wypłaty. |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataKursu | `Soneta.Types.Date` |  |  |  |
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` |  |  |  |
| Dni | `int` |  |  | Suma dni znajdujących się w składnikach wypłaty. Zwraca rzeczywistą ilość dni użytą do wyliczenia wartości elementu wypłaty. |
| DoOpodatkowania | `decimal` |  |  |  |
| DoOpodatkowania_2021 | `decimal` |  |  |  |
| DoWypłaty | `decimal` |  |  |  |
| Elementy | `Soneta.Place.WypElement.ItElementy` |  |  |  |
| InnePowiązania | `Soneta.Place.IPowiązanieWypłaty[]` |  |  |  |
| KodRSA | `Soneta.Place.KodRSA` |  |  |  |
| Komornik | `Soneta.Place.PodstawyZajęciaKomorniczego` | enum |  |  |
| Korekta | `bool` | bazodanowe | Wartość | Określa, czy element wypłaty jest zmodyfikowany ręcznie przez operatora. |
| KorektaWgZasadZUS | `bool` |  |  |  |
| KorektaWyrokTK | `bool` | bazodanowe | Korekta TK | Korekta wynagrodzenia lub zasiłku z tytułu wyroku Trybunału Konstytucyjnego z dnia 24 czerwca 2008 r., sygn. akt SK 16/06 (Dz. U. nr 119, poz. 771). |
| Korygowany | `bool` |  |  |  |
| Koryguj | `bool` |  |  |  |
| Korygujący | `bool` |  |  |  |
| KosztyUzyskaniaPrzychodu | `Soneta.Place.KosztyUzyskaniaPrzychoduFirma` | bazodanowe |  |  |
| KosztyUzyskaniaPrzychodu.Kategoria | `Soneta.Place.KsięgowanieListyWorker.Kategoria` | enum |  |  |
| KosztyUzyskaniaPrzychodu.Narzuty | `decimal` |  |  |  |
| KosztyUzyskaniaPrzychodu.StanowiPodstawęKUP | `bool` |  |  |  |
| KosztyUzyskaniaPrzychodu.WNaturze | `decimal` |  |  |  |
| KosztyUzyskaniaPrzychodu.WartośćKUP | `decimal` |  |  |  |
| KosztyUzyskaniaPrzychodu.WartośćNKUP | `decimal` |  |  |  |
| MiesiacDeklaracji | `Soneta.Types.YearMonth` |  |  |  |
| MiesiacZUS | `Soneta.Types.YearMonth` |  | Miesiąc ZUS |  |
| MiesiacZUSDzien | `Soneta.Types.Date` | bazodanowe | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| NaliczKorekte | `Soneta.Place.NaliczKorektęElementu` | bazodanowe, enum | Nalicz korektę | Określa, czy należy dla elementu naliczać element korygujący. |
| NaliczaćPodatekRyczałtowy | `bool` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Netto | `decimal` |  |  |  |
| NettoOpodat | `decimal` |  | Netto (opodatkowane) |  |
| NiePodlegaOpodatkowaniu | `decimal` |  |  |  |
| NiePodlegaOpodatkowaniuBezPPK | `decimal` |  |  |  |
| NiePodlegaOpodatkowaniuBezPPK_2021 | `decimal` |  |  |  |
| NiePodlegaOpodatkowaniu_2021 | `decimal` |  |  |  |
| Niestorno | `bool` |  |  |  |
| Odbiorca | `Soneta.Kasa.IPodmiotKasowy` | iface-ref |  |  |
| OdchyłkiRazem | `decimal` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OkresListy | `Soneta.Types.FromTo` | bazodanowe |  |  |
| OpisPrzelewu | `string` |  |  |  |
| Pierwotny | `Soneta.Place.WypElement` |  |  |  |
| Pit26 | `bool` |  |  |  |
| Pit26DoUkończenia26Roku | `bool` |  |  |  |
| PitUlgaEmeryt | `bool` |  |  |  |
| Podatek | `bool` |  |  | Podatek rozliczany na PIT8AR lub na PIT8C |
| Podatki | `Soneta.Place.Podatki` | bazodanowe |  |  |
| Podatki.Brutto50 | `decimal` | bazodanowe |  |  |
| Podatki.BudzetTyUb | `Soneta.Kadry.TytulUbezpieczenia` | bazodanowe |  |  |
| Podatki.BudżetZUS | `decimal` |  |  |  |
| Podatki.Chorobowa | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.ChorobowaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.Emerytalna | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.Emerytalna.Firma | `decimal` | bazodanowe |  |  |
| Podatki.Emerytalna.JestMinus | `bool` |  |  | Informuje, czy składka pracownika lub firmy jest ujemna. |
| Podatki.Emerytalna.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.Emerytalna.Prac | `decimal` | bazodanowe |  |  |
| Podatki.Emerytalna.Składka | `decimal` |  |  |  |
| Podatki.EmerytalnaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.EmerytalnaBudzet.JestMinus | `bool` |  |  | Informuje, czy składka jest ujemna. |
| Podatki.EmerytalnaBudzet.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.EmerytalnaBudzet.Skladka | `decimal` | bazodanowe |  |  |
| Podatki.FEP | `Soneta.Place.SkladkaZUSFirma` | bazodanowe |  |  |
| Podatki.FGSP | `Soneta.Place.SkladkaZUSFirma` | bazodanowe |  |  |
| Podatki.FP | `Soneta.Place.SkladkaZUSFirma` | bazodanowe |  |  |
| Podatki.FP.JestMinus | `bool` |  |  | Informuje, czy składka jest ujemna. |
| Podatki.FP.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.FP.Skladka | `decimal` | bazodanowe |  |  |
| Podatki.FirmaZUS | `decimal` |  |  |  |
| Podatki.JestMinus | `bool` |  |  | Informuje, że są podatki lub składki o wartości ujemnej. |
| Podatki.Korekta | `bool` | bazodanowe |  |  |
| Podatki.Koszty | `decimal` | bazodanowe |  |  |
| Podatki.Koszty50 | `decimal` | bazodanowe |  |  |
| Podatki.KosztyPIT | `decimal` |  |  |  |
| Podatki.KosztyRazem | `decimal` |  |  |  |
| Podatki.KosztyZUS | `decimal` |  |  |  |
| Podatki.KosztyZUS26 | `decimal` |  |  |  |
| Podatki.KosztyZUSNieodlicz | `decimal` | bazodanowe |  | Suma składek ZUS niepomniejszających podstawy opodatkowania |
| Podatki.KosztyZUSPomn | `decimal` | bazodanowe |  |  |
| Podatki.KosztyZUSPomnKosztow | `decimal` |  |  |  |
| Podatki.KosztyZdrow26 | `decimal` |  |  |  |
| Podatki.KosztyZdrowPomn | `decimal` |  |  |  |
| Podatki.NalFIS | `decimal` | bazodanowe |  |  |
| Podatki.Narzuty | `decimal` |  |  |  |
| Podatki.OdliczoneZdrowotne | `decimal` |  |  |  |
| Podatki.OrgTyUb | `Soneta.Kadry.TytulUbezpieczenia` | bazodanowe |  |  |
| Podatki.PPK | `Soneta.Place.SkładkaPPK` | bazodanowe |  |  |
| Podatki.PPK.DodPracodawcy | `decimal` | bazodanowe |  |  |
| Podatki.PPK.DodPracownika | `decimal` | bazodanowe |  |  |
| Podatki.PPK.JestMinus | `bool` |  |  | Informuje, czy składka pracownika lub firmy jest ujemna. |
| Podatki.PPK.PodstPracodawcy | `decimal` | bazodanowe |  |  |
| Podatki.PPK.PodstPracownika | `decimal` | bazodanowe |  |  |
| Podatki.PPK.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.PPK.Pracodawcy | `decimal` |  |  |  |
| Podatki.PPK.PracodawcyDoPodatku | `decimal` | bazodanowe |  |  |
| Podatki.PPK.Pracownika | `decimal` |  |  |  |
| Podatki.PPK.Składka | `decimal` |  |  |  |
| Podatki.PakietMobilności | `bool` |  |  |  |
| Podatki.PakietMobilnościPomniejszenieFIS | `decimal` |  |  |  |
| Podatki.PakietMobilnościPomniejszenieZUS | `decimal` |  |  |  |
| Podatki.PakietMobilnościWartośćDiet | `decimal` |  |  |  |
| Podatki.PodstawaFIS | `decimal` | bazodanowe |  |  |
| Podatki.PodstawaZUS | `decimal` | bazodanowe |  |  |
| Podatki.PomnKosztyZUS | `decimal` |  |  |  |
| Podatki.PomnKosztyZUSPomn | `decimal` |  |  |  |
| Podatki.PomniejszenieFIS | `decimal` | bazodanowe |  |  |
| Podatki.PomniejszeniePodstawyFIS | `bool` |  |  |  |
| Podatki.PomniejszenieZUS | `decimal` | bazodanowe |  |  |
| Podatki.ProcentFIS | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki.Przychod26 | `decimal` | bazodanowe |  |  |
| Podatki.Przychod26BezPPK | `decimal` |  |  |  |
| Podatki.Przychod26Ulgi | `decimal` |  |  |  |
| Podatki.Przychod50 | `decimal` | bazodanowe |  |  |
| Podatki.Rentowa | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.RentowaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.TyUb | `Soneta.Kadry.TytulUbezpieczenia` | bazodanowe |  |  |
| Podatki.TypKosztowUzyskaniaPrzychodu | `Soneta.Place.TypKosztowUzyskaniaPrzychodu` | enum |  |  |
| Podatki.TypPomniejszeniaFIS | `Soneta.Place.TypPomniejszeniaFIS` | enum |  | Sposób pomniejszania zaliczki podatku od zdrowotnego z uzwględnieniem ryczałtu. |
| Podatki.UjemneKwoty | `string` |  |  |  |
| Podatki.Ulga | `decimal` | bazodanowe |  |  |
| Podatki.UlgaDuzaRodzina | `decimal` | bazodanowe |  |  |
| Podatki.UlgaEmeryt | `decimal` | bazodanowe |  |  |
| Podatki.UlgaKlasaSrednia | `decimal` | bazodanowe |  |  |
| Podatki.UlgaZagranica | `decimal` | bazodanowe |  |  |
| Podatki.VAT | `Soneta.Place.PodatekVAT` | bazodanowe |  |  |
| Podatki.VAT.DefinicjaStawki | `Soneta.Core.DefinicjaStawkiVat` | bazodanowe |  | Definicja stawki VAT opisująca rodzaj stawki 22%, 7%, itp |
| Podatki.VAT.Podatek | `decimal` | bazodanowe |  |  |
| Podatki.VAT.Podstawa | `decimal` | bazodanowe |  |  |
| Podatki.VAT.Stawka | `Soneta.Core.StawkaVat` | bazodanowe |  | Typ stawki VAT |
| Podatki.VAT.Stawka.Kraj | `Soneta.Core.KrajTbl` | bazodanowe |  |  |
| Podatki.VAT.Stawka.Obnizona | `bool` | bazodanowe |  |  |
| Podatki.VAT.Stawka.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki.VAT.Stawka.Status | `Soneta.Core.StatusStawkiVat` | bazodanowe, enum |  |  |
| Podatki.VAT.Stawka.WgKraj | `Soneta.Business.Key` |  |  |  |
| Podatki.VAT.Stawka.WymagaSWW | `bool` |  |  |  |
| Podatki.VAT.Stawka.Zrodlowa | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki.VAT.WgDefinicjaStawki | `Soneta.Business.Key` |  |  |  |
| Podatki.WyliczonyPrzychód50 | `decimal` |  |  |  |
| Podatki.Wypadkowa | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.WypadkowaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.ZUS | `decimal` |  |  |  |
| Podatki.ZalFIS | `decimal` | bazodanowe |  |  |
| Podatki.ZalFISDoplata | `decimal` | bazodanowe |  |  |
| Podatki.ZalFISKorekta | `decimal` | bazodanowe |  |  |
| Podatki.ZalFISPL | `decimal` | bazodanowe |  |  |
| Podatki.Zaniechanie | `decimal` | bazodanowe |  |  |
| Podatki.Zdrowotna | `Soneta.Place.SkladkaZUS` | bazodanowe |  |  |
| Podatki.ZdrowotnaBudzet | `Soneta.Place.SkladkaZUSBudżet` | bazodanowe |  |  |
| Podatki.ZdrowotneDoOdliczenia | `decimal` | bazodanowe |  | Składka na NFZ do odliczenia od zaliczki podatku |
| Podatki.ZdrowotneDoOdliczenia26 | `decimal` | bazodanowe |  | Składka 26 latka na NFZ do odliczenia od zaliczki podatku |
| Podatki.ZdrowotneFaktycznieOdliczone | `decimal` |  | Zdrowotne odliczone | Składka na NFZ faktycznie odliczenia od zaliczki podatku |
| Podatki.ZdrowotneNieodliczane | `decimal` |  |  | Składka na NFZ nieodliczana od zaliczki podatku |
| Podatki2021 | `Soneta.Place.Podatki2021` | bazodanowe |  |  |
| Podatki2021.Brutto50 | `decimal` | bazodanowe |  |  |
| Podatki2021.BudzetTyUb | `Soneta.Kadry.TytulUbezpieczenia` |  |  |  |
| Podatki2021.BudżetZUS | `decimal` |  |  |  |
| Podatki2021.Chorobowa | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.ChorobowaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.Emerytalna | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.EmerytalnaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.FEP | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.FGSP | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.FP | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.FirmaZUS | `decimal` |  |  |  |
| Podatki2021.Koszty | `decimal` | bazodanowe |  |  |
| Podatki2021.Koszty50 | `decimal` | bazodanowe |  |  |
| Podatki2021.KosztyPIT | `decimal` |  |  |  |
| Podatki2021.KosztyRazem | `decimal` |  |  |  |
| Podatki2021.KosztyZUS | `decimal` | bazodanowe |  |  |
| Podatki2021.KosztyZUS26 | `decimal` |  |  |  |
| Podatki2021.KosztyZUSNieodlicz | `decimal` | bazodanowe |  |  |
| Podatki2021.KosztyZUSPomn | `decimal` | bazodanowe |  |  |
| Podatki2021.KosztyZUSPomnKosztow | `decimal` |  |  |  |
| Podatki2021.KosztyZdrow26 | `decimal` |  |  |  |
| Podatki2021.NalFIS | `decimal` | bazodanowe |  |  |
| Podatki2021.Narzuty | `decimal` |  |  |  |
| Podatki2021.OdliczoneZdrowotne | `decimal` |  |  |  |
| Podatki2021.OrgTyUb | `Soneta.Kadry.TytulUbezpieczenia` |  |  |  |
| Podatki2021.PPK | `Soneta.Place.ISkładkaPPK` |  |  |  |
| Podatki2021.PakietMobilnościPomniejszenieFIS | `decimal` |  |  |  |
| Podatki2021.PakietMobilnościPomniejszenieZUS | `decimal` |  |  |  |
| Podatki2021.PakietMobilnościWartośćDiet | `decimal` |  |  |  |
| Podatki2021.PodstawaFIS | `decimal` | bazodanowe |  |  |
| Podatki2021.PodstawaZUS | `decimal` |  |  |  |
| Podatki2021.PomnKosztyZUS | `decimal` |  |  |  |
| Podatki2021.PomnKosztyZUSPomn | `decimal` |  |  |  |
| Podatki2021.PomniejszenieFIS | `decimal` | bazodanowe |  |  |
| Podatki2021.PomniejszeniePodstawyFIS | `bool` |  |  |  |
| Podatki2021.PomniejszenieZUS | `decimal` |  |  |  |
| Podatki2021.ProcentFIS | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki2021.Przychod26 | `decimal` | bazodanowe |  |  |
| Podatki2021.Przychod26BezPPK | `decimal` |  |  |  |
| Podatki2021.Przychod26Ulgi | `decimal` |  |  |  |
| Podatki2021.Przychod50 | `decimal` | bazodanowe |  |  |
| Podatki2021.Puste | `bool` |  |  |  |
| Podatki2021.Rentowa | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.RentowaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.TyUb | `Soneta.Kadry.TytulUbezpieczenia` |  |  |  |
| Podatki2021.TypKosztowUzyskaniaPrzychodu | `Soneta.Place.TypKosztowUzyskaniaPrzychodu` | enum |  |  |
| Podatki2021.TypPomniejszeniaFIS | `Soneta.Place.TypPomniejszeniaFIS` | enum |  | Sposób pomniejszania zaliczki podatku od zdrowotnego z uzwględnieniem ryczałtu. |
| Podatki2021.Ulga | `decimal` | bazodanowe |  |  |
| Podatki2021.UlgaDuzaRodzina | `decimal` |  |  |  |
| Podatki2021.UlgaEmeryt | `decimal` |  |  |  |
| Podatki2021.UlgaKlasaSrednia | `decimal` |  |  |  |
| Podatki2021.UlgaZagranica | `decimal` |  |  |  |
| Podatki2021.VAT | `Soneta.Place.PodatekVAT` |  |  |  |
| Podatki2021.WyliczonyPrzychód50 | `decimal` |  |  |  |
| Podatki2021.Wypadkowa | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.WypadkowaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.ZUS | `decimal` |  |  |  |
| Podatki2021.ZalFIS | `decimal` | bazodanowe |  |  |
| Podatki2021.ZalFISDoplata | `decimal` |  |  |  |
| Podatki2021.ZalFISKorekta | `decimal` |  |  |  |
| Podatki2021.ZalFISPL | `decimal` |  |  |  |
| Podatki2021.Zaniechanie | `decimal` | bazodanowe |  |  |
| Podatki2021.Zdrowotna | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.ZdrowotnaBudzet | `Soneta.Place.ISkładka` |  |  |  |
| Podatki2021.ZdrowotneDoOdliczenia | `decimal` | bazodanowe |  |  |
| Podatki2021.ZdrowotneDoOdliczenia26 | `decimal` | bazodanowe |  |  |
| Podatki2021.ZdrowotneFaktycznieOdliczone | `decimal` |  | Zdrowotne odliczone | Składka na NFZ faktycznie odliczenia od zaliczki podatku |
| Podatki2021.ZdrowotneNieodliczane | `decimal` |  |  | Składka na NFZ nieodliczana od zaliczki podatku |
| PodlegaKorekcie | `bool` |  |  |  |
| PodlegaVAT | `bool` |  |  |  |
| PodstawaFIS | `bool` |  |  |  |
| PodstawaZUS | `bool` |  |  |  |
| PodstawaZdrow | `bool` |  |  |  |
| PomniejszeniePodstawyFIS | `bool` |  |  |  |
| Powiązanie | `Soneta.Place.IPowiązanieWypłaty` | iface-ref |  |  |
| Pozostałe | `Soneta.Place.PodstawyZajęciaKomorniczego` | enum |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| PriorytetŹródła | `int` |  |  |  |
| Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| RachunekOdbiorcy | `Soneta.Kasa.RachunekBankowyPodmiotu` |  |  |  |
| RodzajSkladki | `Soneta.Place.RodzajSkladki` | bazodanowe, enum | Rodzaj składki |  |
| RodzajSkładkiInfo | `string` |  | Rodzaj składki |  |
| RodzajZrodla | `Soneta.Place.RodzajŹródłaWypłaty` | bazodanowe, enum |  |  |
| RozliczenieStorna | `bool` |  |  |  |
| Seria | `string` |  |  |  |
| Skladniki | `Soneta.Business.SubTable<Soneta.Place.WypSkladnik>` |  |  |  |
| SkładnikGłówny | `Soneta.Place.WypSkladnikGłówny` |  |  |  |
| SkładnikiKorygowane | `System.Collections.Generic.IEnumerable<Soneta.Place.WypSkladnik>` |  |  |  |
| SkładnikiKorygujące | `System.Collections.Generic.IEnumerable<Soneta.Place.WypSkladnik>` |  |  |  |
| SkładnikiPowiązane | `System.Collections.Generic.IEnumerable<Soneta.Place.WypSkladnik>` |  |  |  |
| StanStorna | `Soneta.Place.StanStornaElementu` | bazodanowe, enum |  |  |
| StanStornaEx | `Soneta.Place.StanStornaElementu` | enum |  |  |
| Storno | `Soneta.Place.StornoElementu` |  |  |  |
| Stornowane | `Soneta.Business.SubTable<Soneta.Place.StornoElementu>` |  |  |  |
| Stornujące | `Soneta.Business.SubTable<Soneta.Place.StornoElementu>` |  |  |  |
| TypKosztowUzyskaniaPrzychodu | `Soneta.Place.TypKosztowUzyskaniaPrzychodu` | enum |  | Sposób naliczania kosztów uzyskania z uzwględnieniem ryczałtu. |
| TypPomniejszeniaFIS | `Soneta.Place.TypPomniejszeniaFIS` | enum |  | Sposób pomniejszania zaliczki podatku od zdrowotnego z uzwględnieniem ryczałtu. |
| Wartosc | `decimal` | bazodanowe | Wartość |  |
| WartośćNominalna | `decimal` |  |  |  |
| WorkerKosztyUzyskaniaPrzychodu | `Soneta.Place.KosztyUzyskaniaPrzychoduWorker` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wyplata | `Soneta.Place.Wyplata` | bazodanowe |  |  |
| Wystornowany | `bool` | bazodanowe |  | Do elementu naliczono element stornujący. Mógł on zostać już usunięty. |
| ZaliczkaLubPodatek | `bool` |  |  |  |
| ZaliczkaPodatku | `bool` |  |  | Zaliczka podatku rozliczana na PIT4R |
| ZapisObliczen | `Soneta.Business.MemoText` | bazodanowe |  |  |
| ZasiłekBudżet | `bool` |  |  |  |
| ZasiłekRSA | `bool` |  |  |  |
| ZasiłekZus | `bool` |  |  |  |
| Zatwierdzony | `bool` |  |  |  |
| _KodRSA | `Soneta.Place.KodRSA` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| BazaZrodla | `IBazaZrodlaWyplaty` | `Akord`, `Deklaracja`, `Dodatek`, `DodatekAutomatyczny`, `FundPozyczkowy`, `KorektaZajęciaKomorniczego`, `NagrodaKara`, `Nieobecnosc`, `Pozyczka`, `Pracownik`, `RataPozyczki`, `SwiadczSocjalne`, `Umowa`, `WniosekOSzkolenie`, `ZajęcieKomornicze`, `Zaliczka`, `ZbiegPracyIRodzicielstwa`, `ZmianaWkładuFunduszuPozyczkowego` |
| Odbiorca | `IPodmiotKasowy` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy`, `ZUS` |
| Powiązanie | `IPowiązanieWypłaty` | `FundPozyczkowy`, `NagrodaKara`, `Pozyczka`, `SwiadczSocjalne`, `Umowa`, `Zaliczka` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusStawkiVat (`Soneta.Core.StatusStawkiVat`)
- `Opodatkowana` = 0 — Opodatkowana
- `Zaniżona` = 1
- `Zwolniona` = 2
- `NiePodlega` = 3
- `Brak` = 4

### Kategoria (`Soneta.Place.KsięgowanieListyWorker.Kategoria`)
- `Zasadnicze` = 0 — Zasadnicze
- `Umowy` = 1
- `Inne` = 2
- `Zasiłek` = 3
- `DodatkiNetto` = 4
- `PotrąceniaNetto` = 5

### NaliczKorektęElementu (`Soneta.Place.NaliczKorektęElementu`)
- `Domyślnie` = 0
- `Naliczaj` = 1
- `NieNaliczaj` = 2

### PodstawyZajęciaKomorniczego (`Soneta.Place.PodstawyZajęciaKomorniczego`)
- `Domyślnie` = 0
- `NiePodlegaZajęciu` = 1
- `DoLimitu` = 2
- `DoLimituZasiłki` = 3
- `WPełnejWysokości` = 4 — W pełnej wysokości
- `TylkoPodatkiISkładki` = 5

### RodzajSkladki (`Soneta.Place.RodzajSkladki`)
- `Emerytalna` = 1 — Emerytalna
- `Rentowa` = 2
- `Chorobowa` = 4
- `Wypadkowa` = 8
- `Zdrowotna` = 16
- `FP` = 32
- `FGŚP` = 64
- `FEP` = 128
- `EmerytalnaBudzet` = 256
- `RentowaBudzet` = 512
- `ZdrowotnaBudzet` = 1024
- `ChorobowaBudzet` = 4096
- `WypadkowaBudzet` = 8192
- `PPK` = 2048
- `Waloryzacja` = 32768
- `Podatek` = 65536
- `Pit26` = 131072
- `PakietMobilności` = 262144
- `PomniejszenieFIS` = 524288
- `UlgaDuzaRodzina` = 1048576
- `UlgaEmeryt` = 2097152
- `UlgaZagranica` = 4194304
- `Podatki2021` = 8388608
- `SkładkiZUS` = 31
- `SkładkiBudżet` = 14080
- `Składki` = 14111
- `Narzuty` = 2272
- `Pit26UlgiBezFIS` = 7471104
- `Pit26Ulgi` = 7995392
- `Flagi` = 7569408
- `FlagiZUS` = 14335

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

### StanStornaElementu (`Soneta.Place.StanStornaElementu`)
- `NieDotyczy` = 0 — Nie dotyczy
- `DoStornowania` = 1
- `Wystornowany` = 2
- `Stornujący` = 3
- `WycofaneStorno` = 10

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

### TypPomniejszeniaFIS (`Soneta.Place.TypPomniejszeniaFIS`)
- `NiePomniejsza` = 0
- `Pomniejsza` = 1
- `PomniejszaDoFIS` = 2 — Pomniejsza do FIS
- `PomniejszaWarunkowo` = 3 — Pomniejsza warunkowo do FIS
- `PomniejszaWarunkowoBezFis` = 4 — Pomniejsza warunkowo
