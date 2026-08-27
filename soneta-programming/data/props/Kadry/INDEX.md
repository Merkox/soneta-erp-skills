# Moduł `Kadry` — tabele biznesowe

- Opis: Moduł kadrowy obsługujący dane pracowników. Zawiera kartoteki pracowników, umowy o pracę, historię zatrudnienia, nieobecności, badania lekarskie, szkolenia BHP oraz dane ubezpieczeniowe.
- Tabel: **88**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| Akord |  | `Akordy` |  | root | historyczna → AkordHistoria | IBazaZrodlaWyplaty | TypAkordu (2) | [Akord.md](Akord.md) |
| AkordHistoria | Historia akordu | `AkordHistorie` |  | child: Akord→Akord | historia → Akord | IAkord | TypAkordu (2) | [AkordHistoria.md](AkordHistoria.md) |
| AlgorytmRatyPożyczki | Algorytmy rat pożyczek | `AlgRatPozyczek` | konfig | root |  |  |  | [AlgorytmRatyPożyczki.md](AlgorytmRatyPożyczki.md) |
| BadanieLekarskie | Badania lekarskie | `BadaniaLekarskie` |  | root |  | IManagedRowInfoHost |  | [BadanieLekarskie.md](BadanieLekarskie.md) |
| BlokadaPracownika | Blokady pracowników | `BlokadyPrac` |  |  |  |  |  | [BlokadaPracownika.md](BlokadaPracownika.md) |
| BoRIAOświata | Okresy wykonywania pracy nauczycieskiej | `BosRIAOswiata` |  | root |  |  |  | [BoRIAOświata.md](BoRIAOświata.md) |
| BoRIAWarunkiSzczególne | Okresy pracy w szczególnych warunkach lub w szczególnym charakterze | `BosRIAWarSzczeg` |  | root |  |  |  | [BoRIAWarunkiSzczególne.md](BoRIAWarunkiSzczególne.md) |
| BoRIAWynagrodzenia | Bilansy otwarcia RIA - wynagrodzenia | `BosRIAWynagrodz` |  | root |  |  |  | [BoRIAWynagrodzenia.md](BoRIAWynagrodzenia.md) |
| CzlonekRodziny | Członek rodziny | `Rodzina` |  | root |  | IZrodloDeklaracji, IAdresHost, IPowiązanieDodatku |  | [CzlonekRodziny.md](CzlonekRodziny.md) |
| CzynnikSzkodliwyPracownika | Czynniki szkodliwe pracownika | `CzynnSzkodPrac` |  | root |  |  |  | [CzynnikSzkodliwyPracownika.md](CzynnikSzkodliwyPracownika.md) |
| DefPodstawyStazu | Def. podstaw stażu pracy | `DefPodstawStazu` | konfig | root |  |  |  | [DefPodstawyStazu.md](DefPodstawyStazu.md) |
| DefinicjaAkordu | Definicje akordów | `DefinicjeAkordow` | konfig | root |  | IAkord | TypAkordu (2) | [DefinicjaAkordu.md](DefinicjaAkordu.md) |
| DefinicjaBadaniaLekarskiego | Definicje badań lekarskich | `DefBadanLek` | konfig | root |  | IManagedRowDefinion |  | [DefinicjaBadaniaLekarskiego.md](DefinicjaBadaniaLekarskiego.md) |
| DefinicjaCzynnikowSzkodliwych | Definicje czynników szkodliwych | `DefCzynnSzkod` | konfig | root |  | IZklPozycjaSlownika |  | [DefinicjaCzynnikowSzkodliwych.md](DefinicjaCzynnikowSzkodliwych.md) |
| DefinicjaFunduszuPozyczkowego | Definicje funduszy pożyczkowych | `DefFundPozycz` | konfig | root |  | IRightsSource, IZakresDefinicji |  | [DefinicjaFunduszuPozyczkowego.md](DefinicjaFunduszuPozyczkowego.md) |
| DefinicjaJęzykaObcego | Definicje języków obcych | `DefJezykowObcych` | konfig | root |  | IZklPozycjaSlownika |  | [DefinicjaJęzykaObcego.md](DefinicjaJęzykaObcego.md) |
| DefinicjaNagrodyKary | Definicje nagród lub kar | `DefNagrodKar` | konfig | root |  |  | TypNagrodyKary (2) | [DefinicjaNagrodyKary.md](DefinicjaNagrodyKary.md) |
| DefinicjaOświadczenia | Definicje oświadczeń | `DefOswiadczen` | konfig | root |  |  |  | [DefinicjaOświadczenia.md](DefinicjaOświadczenia.md) |
| DefinicjaStopiaZnajomościJęzykaObcego | Definicje stopni znajomości języków obcych | `DefStZnJObcych` | konfig | root |  | IZklPozycjaSlownika |  | [DefinicjaStopiaZnajomościJęzykaObcego.md](DefinicjaStopiaZnajomościJęzykaObcego.md) |
| DefinicjaSzkoleniaBHP | Definicje szkoleń BHP | `DefSzkolenBHP` | konfig | root |  | IManagedRowDefinion, IZklPozycjaSlownika, IPozycjaKonfiguratora |  | [DefinicjaSzkoleniaBHP.md](DefinicjaSzkoleniaBHP.md) |
| DefinicjaWydziału | Kategorie jednostek organizacyjnych | `DefWydzialow` | konfig | root |  |  |  | [DefinicjaWydziału.md](DefinicjaWydziału.md) |
| DefinicjaŚwiadczeniaSocjalnego | Definicje świadczeń socjalnych | `DefSwiadczSocjal` | konfig | root |  |  |  | [DefinicjaŚwiadczeniaSocjalnego.md](DefinicjaŚwiadczeniaSocjalnego.md) |
| DodHistoria | Historie dodatków | `DodHistorie` |  | child: Dodatek→Dodatek | historia → Dodatek |  |  | [DodHistoria.md](DodHistoria.md) |
| Dodatek |  | `Dodatki` |  | root | historyczna → DodHistoria | IBazaZrodlaWyplaty |  | [Dodatek.md](Dodatek.md) |
| ElementZestawuDodatków | Elementy zestawów | `ElementyZestDod` | konfig | child: Zestaw→ZestawDodatków |  |  |  | [ElementZestawuDodatków.md](ElementZestawuDodatków.md) |
| FormaOrganizacjiPracy | Formy organizacji pracy | `FormyOrgPracy` | konfig | root |  |  |  | [FormaOrganizacjiPracy.md](FormaOrganizacjiPracy.md) |
| FundPozyczkowy | Fundusze pożyczkowe | `FundPozyczkowe` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty |  | [FundPozyczkowy.md](FundPozyczkowy.md) |
| GrupaZaszeregowania | Grupy zaszeregowania | `GrupyZaszer` | konfig | root |  |  |  | [GrupaZaszeregowania.md](GrupaZaszeregowania.md) |
| HistoriaDanychWydziału | Historia danych jednostek organizacyjnych | `HstDanychWydzial` | konfig | child: Wydzial→Wydzial |  | IMetrykaWydziałuHost |  | [HistoriaDanychWydziału.md](HistoriaDanychWydziału.md) |
| HistoriaZatrudnieniaBase | Historia zatrudnienia | `HistZatrudnien` |  | root |  | IManagedRowInfoHost | TypHistoriiZatrudnienia (2) | [HistoriaZatrudnieniaBase.md](HistoriaZatrudnieniaBase.md) |
| InformacjaDoRozliczenia |  | `InformacjeDoRozl` |  | root | historyczna → InformacjeDoRozliczeniaHistoria |  |  | [InformacjaDoRozliczenia.md](InformacjaDoRozliczenia.md) |
| InformacjeDoRozliczeniaHistoria | Historie elementów rozliczenia | `InfoDoRozliHist` |  | child: InformacjaDoRozliczenia→InformacjaDoRozliczenia | historia → InformacjaDoRozliczenia |  |  | [InformacjeDoRozliczeniaHistoria.md](InformacjeDoRozliczeniaHistoria.md) |
| InnyDochod | Inne dochody | `InneDochody` |  | child: Pracownik→Pracownik |  |  |  | [InnyDochod.md](InnyDochod.md) |
| KanalZgloszeniaSygnalisty | Kanały zgłoszeń sygnalisty | `KanalyZglSygnal` | konfig | root |  |  |  | [KanalZgloszeniaSygnalisty.md](KanalZgloszeniaSygnalisty.md) |
| KartaRCP | Karty RCP | `KartyRCP` |  | root |  |  |  | [KartaRCP.md](KartaRCP.md) |
| KategoriaCzynnikowSzkodliwych | Kategorie czynników szkodliwych | `KatCzynnSzkod` | konfig | root |  | IZklPozycjaSlownika |  | [KategoriaCzynnikowSzkodliwych.md](KategoriaCzynnikowSzkodliwych.md) |
| KategoriaZgloszeniaSygnalisty | Kategorie zgłoszeń sygnalisty | `KatZglSygnal` | konfig | root |  |  |  | [KategoriaZgloszeniaSygnalisty.md](KategoriaZgloszeniaSygnalisty.md) |
| KodPracyWSzególnychWarunkachCharakterze | Kody pracy w szczególnych warunkach lub o szczególnym charakterze | `KodyPracySzWaCha` | konfig | root |  |  |  | [KodPracyWSzególnychWarunkachCharakterze.md](KodPracyWSzególnychWarunkachCharakterze.md) |
| KodWykonywanegoZawodu | Kody GUS zawodów | `KodyWykZawodow` | konfig | root |  |  |  | [KodWykonywanegoZawodu.md](KodWykonywanegoZawodu.md) |
| KorektaZajęciaKomorniczego | Korekty zajęć komorniczych | `KorektyZajKomor` |  | root |  | IBazaZrodlaWyplaty | RodzajeKorektZajęćKomorniczych (3) | [KorektaZajęciaKomorniczego.md](KorektaZajęciaKomorniczego.md) |
| LokalizacjaPracyZdalnej | Lokalizacja pracy zdalnej | `LokPracZdalnej` |  | root |  |  |  | [LokalizacjaPracyZdalnej.md](LokalizacjaPracyZdalnej.md) |
| MetrykaWydziału | Wpisy do metryki jednostek organizacyjnych | `MetrykiWydzialow` | konfig | child: Wydzial→Wydzial |  |  |  | [MetrykaWydziału.md](MetrykaWydziału.md) |
| NagrodaKara |  | `NagrodyKary` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty | TypNagrodyKary (2) | [NagrodaKara.md](NagrodaKara.md) |
| OkresNiewliczany | Okresy niewliczane do stażu pracy | `OkrNiewliczane` |  | child: Zatrudnienie→HistoriaZatrudnieniaBase |  |  |  | [OkresNiewliczany.md](OkresNiewliczany.md) |
| OkresWakacjiSkladki | Wakacje składkowe | `OkresyWakacjiSkladki` |  | child: Pracownik→Pracownik |  |  |  | [OkresWakacjiSkladki.md](OkresWakacjiSkladki.md) |
| OkresWykonywaniaPracyTymczasowej | Okresy wykonywania pracy tymczasowej | `OkresyPracyTymcz` |  | child: Zatrudnienie→HistoriaZatrudnieniaBase |  |  |  | [OkresWykonywaniaPracyTymczasowej.md](OkresWykonywaniaPracyTymczasowej.md) |
| OświadczeniePracownika | Oświadczenia pracowników | `OswiadczeniaPrac` |  | root |  |  |  | [OświadczeniePracownika.md](OświadczeniePracownika.md) |
| PodstawaStazu | Podstawy stażu pracy | `PodstawyStazow` |  | root |  |  |  | [PodstawaStazu.md](PodstawaStazu.md) |
| Pozyczka | Pożyczki | `Pozyczki` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty, IRozliczenieWynagrodzeniaHost, IBilansOtwarcia |  | [Pozyczka.md](Pozyczka.md) |
| PracDbTupleDefinitionExt | Rozszerzenia definicji krotek dla tabeli Pracownicy | `PracTupleDefExts` | konfig | child: DbTupleDefinition→DbTupleDefinition |  |  |  | [PracDbTupleDefinitionExt.md](PracDbTupleDefinitionExt.md) |
| PracHistoria | Historia pracownika | `PracHistorie` |  | child: Pracownik→Pracownik | historia → Pracownik | IAdresHost, IDaneKontaktoweHost |  | [PracHistoria.md](PracHistoria.md) |
| PracHistoria2 | Historia pracownika (pozostałe) | `PracHistorie2` |  | child: Host→PracHistoria |  |  |  | [PracHistoria2.md](PracHistoria2.md) |
| Pracownik | Pracownicy | `Pracownicy` |  | root | historyczna → PracHistoria | IZrodloNieobecnosci, IZrodloWnioskuONieobecnosc, IBazaZrodlaWyplaty, IPodmiot, IPodmiotKasowy, IKontrahent, IZrodloPodzielnikaKosztow, IElementSlownika, IZasobCRM, ITaskUser, IŹródłoPowiązaniaStrukturyOrganizacyjnej, IWebOperator, IGIODOZgodnyHost, IOceniany, IOceniający, IOdpowiedzialnyZaOcenę, IŹródłoKartyOpisuStanowiska, IGIODOWymianaDanychHost, IGIODOOświadczenieHost, IGIODOUprawnienieHost, IEmailElement, IRozliczenieWynagrodzeniaHost, IZestawienieDietZagrHost, IZestawienieDietPakietMobilHost, IAdresHost, IZrodloPlanu, IDostepnoscHost | TypPracownika (3) | [Pracownik.md](Pracownik.md) |
| PracownikWArchiwum | Pracownicy w archiwum | `PracWArchiwum` |  | child: Pracownik→Pracownik |  |  |  | [PracownikWArchiwum.md](PracownikWArchiwum.md) |
| ProgAkordu | Progi akordów | `ProgiAkordow` |  | child: Akord→IAkord |  |  |  | [ProgAkordu.md](ProgAkordu.md) |
| ProgPodatkowy |  | `ProgiPodatkowe` |  | child: Historia→PracHistoria |  |  |  | [ProgPodatkowy.md](ProgPodatkowy.md) |
| PrzetwarzanieZgloszeniaSygnalisty | Przetwarzanie naruszeń | `PrzetwarzZglSyg` |  | root |  |  |  | [PrzetwarzanieZgloszeniaSygnalisty.md](PrzetwarzanieZgloszeniaSygnalisty.md) |
| PrzychodRyczalt | Przychody dla zryczałtowanych form opodatkowania | `PrzychodyRyczalt` |  | child: Pracownik→Pracownik |  |  |  | [PrzychodRyczalt.md](PrzychodRyczalt.md) |
| PrzychodZDzialnosci | Przychody oraz dochody dla form opodatkowania | `PrzychodyZDzial` |  | child: Pracownik→Pracownik |  |  |  | [PrzychodZDzialnosci.md](PrzychodZDzialnosci.md) |
| PrzyczynaRozwUmowy | Przyczyna rozwiązania umów o pracę | `PrzyczRozwUmow` | konfig | root |  |  |  | [PrzyczynaRozwUmowy.md](PrzyczynaRozwUmowy.md) |
| PrzyczynaZawUmowy | Przyczyna zawarcia umów o pracę | `PrzyczZawUmow` | konfig | root |  |  |  | [PrzyczynaZawUmowy.md](PrzyczynaZawUmowy.md) |
| RataPozyczki | Raty pożyczek | `RatyPozyczek` |  | root |  | IBazaZrodlaWyplaty |  | [RataPozyczki.md](RataPozyczki.md) |
| RelacjaWykonPrac | Powiązanie Wykonujący Pracownik | `RelacjeWykonPrac` |  | child: Pracownik→Pracownik |  |  |  | [RelacjaWykonPrac.md](RelacjaWykonPrac.md) |
| Schorzenie |  | `Schorzenia` |  | root |  |  |  | [Schorzenie.md](Schorzenie.md) |
| SwiadczSocjalne | Świadczenia socjalne | `SwiadczeniaSoc` |  | root |  | IBazaZrodlaWyplaty, IPowiązanieWypłaty |  | [SwiadczSocjalne.md](SwiadczSocjalne.md) |
| SzkolenieBHP | Szkolenia BHP | `SzkoleniaBHP` |  | root |  |  |  | [SzkolenieBHP.md](SzkolenieBHP.md) |
| TreśćOświadczenia | Treści oświadczeń | `TresciOswiadczen` | konfig | child: Definicja→DefinicjaOświadczenia |  |  |  | [TreśćOświadczenia.md](TreśćOświadczenia.md) |
| TytulUbezpieczenia4 | Tytuły ubezpieczenia | `TytulyUbezpiecz4` | konfig | root |  |  |  | [TytulUbezpieczenia4.md](TytulUbezpieczenia4.md) |
| UlgaInnowacyjna | Ulga innowacyjna | `UlgiInnowacyjne` |  | child: Pracownik→Pracownik |  |  |  | [UlgaInnowacyjna.md](UlgaInnowacyjna.md) |
| Umowa | Umowy | `Umowy` |  | root | historyczna → UmowaHistoria | IBazaZrodlaWyplaty, IPowiązanieWypłaty, IZrodloDeklaracji, IZrodloPodzielnikaKosztow, IPowiązanieDodatku, IRozliczenieWynagrodzeniaHost, IZestawienieDietZagrHost, IZestawienieDietPakietMobilHost, IUmowaZKalendarzem, IBilansOtwarcia, IKwotaSplacanaBO, IZrodloPlanu, IDostepnoscHost, IZrodloNieobecnosci, IZrodloWnioskuONieobecnosc |  | [Umowa.md](Umowa.md) |
| UmowaHistoria | Umowy | `UmowaHistorie` |  | child: Umowa→Umowa | historia → Umowa |  |  | [UmowaHistoria.md](UmowaHistoria.md) |
| UmowaZewnetrzna | Umowy zewnętrzne | `UmowyZewnetrzne` |  | root | historyczna → UmowaZewnetrznaHistoria | IZrodloPodzielnikaKosztow, IUmowaZKalendarzem, IZrodloPlanu, IDostepnoscHost, IZrodloNieobecnosci, IZrodloWnioskuONieobecnosc | TypUmowyZewnetrznej (2) | [UmowaZewnetrzna.md](UmowaZewnetrzna.md) |
| UmowaZewnetrznaHistoria | UmowyZewnetrzne | `UmowyZewnHist` |  | child: Umowa→UmowaZewnetrzna | historia → UmowaZewnetrzna |  | TypUmowyZewnetrznej (2) | [UmowaZewnetrznaHistoria.md](UmowaZewnetrznaHistoria.md) |
| WniosekUrlopowy | Wnioski o urlopy, delegacje | `WnioskiUrlopowe` |  | root |  | IDokumentAktualizacjiKalendarza |  | [WniosekUrlopowy.md](WniosekUrlopowy.md) |
| WniosekZwrotOplSkl | Wniosek o zwrot nienależnie opłaconych składek | `WniosZwrotOplSkl` |  | root |  | IDokument |  | [WniosekZwrotOplSkl.md](WniosekZwrotOplSkl.md) |
| Wydzial | Jednostki organizacyjne | `Wydzialy` | konfig | root |  | IRightsSource, IElementStrukturyFirmy, IElementSlownika |  | [Wydzial.md](Wydzial.md) |
| WydzialRef | Zmiana jednostek nadrzędnych | `WydzialyRef` | konfig | child: Wydzial→Wydzial |  | IMetrykaWydziałuHost |  | [WydzialRef.md](WydzialRef.md) |
| WydziałDefFundPozy | Jednostki organizacyjne definicji funduszu pożyczkowego | `WydDefFundPozy` | konfig | child: DefinicjaFunduszuPozyczkowego→DefinicjaFunduszuPozyczkowego |  |  |  | [WydziałDefFundPozy.md](WydziałDefFundPozy.md) |
| Wypadek | Karty wypadków | `Wypadki` |  | root |  |  |  | [Wypadek.md](Wypadek.md) |
| ZajęcieKomornicze | Zajęcia wynagrodzeń | `ZajKomornicze` |  | root | historyczna → ZajęcieKomorniczeHistoria | IBazaZrodlaWyplaty |  | [ZajęcieKomornicze.md](ZajęcieKomornicze.md) |
| ZajęcieKomorniczeHistoria | Zajęcia wynagrodzeń | `ZajKomorniczeHis` |  | child: Zajecie→ZajęcieKomornicze | historia → ZajęcieKomornicze |  |  | [ZajęcieKomorniczeHistoria.md](ZajęcieKomorniczeHistoria.md) |
| ZbiegUbezpieczenia | Zbiegi ubezpieczeń | `ZbiegiUbezpiecz` |  | child: Pracownik→Pracownik |  |  |  | [ZbiegUbezpieczenia.md](ZbiegUbezpieczenia.md) |
| ZestawDodatków | Zestawy dodatków | `ZestawyDodatkow` | konfig | root |  |  |  | [ZestawDodatków.md](ZestawDodatków.md) |
| ZgloszenieSygnalisty | Naruszenie | `ZgloszSygnalisty` |  | root |  | IDokument |  | [ZgloszenieSygnalisty.md](ZgloszenieSygnalisty.md) |
| ZgodaNaEdycję | Zgody na edycję danych | `ZgodyNaEdycje` |  | root |  |  |  | [ZgodaNaEdycję.md](ZgodaNaEdycję.md) |
| ZmianaWkładuFunduszuPozyczkowego | Zmiany wkładów do funduszy pożyczkowych | `ZmianaWklFundPoz` |  | root |  | IBazaZrodlaWyplaty | KierunekZmianyWkładuFunduszuPożyczkowego (2) | [ZmianaWkładuFunduszuPozyczkowego.md](ZmianaWkładuFunduszuPozyczkowego.md) |
| ZnajomośćJęzykaObcego | Znajomość języków obcych | `ZnJezykowObcych` |  | child: Pracownik→Pracownik |  |  |  | [ZnajomośćJęzykaObcego.md](ZnajomośćJęzykaObcego.md) |
| ŻyrantPożyczki | Żyranci | `ZyranciPozyczek` |  | child: Pozyczka→Pozyczka |  |  |  | [ŻyrantPożyczki.md](ŻyrantPożyczki.md) |

