# Pola i właściwości klasy biznesowej: `Soneta.Kadry.PracHistoria`
Nazwa tabeli: `PracHistorie`
Tytuł: Historia pracownika
Opis: Element szczegółowy pracownika (Pracownik). Główny zapis historyczny pracownika zawierający dane osobowe, etatowe, podatkowe, ubezpieczeniowe, zaszeregowanie, kalendarz, bilansy otwarcia nieobecności, ustawienia PPK oraz dane GUS – wersjonowany z zachowaniem okresu aktualności.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`
Implementuje interfejsy: `IAdresHost`, `IDaneKontaktoweHost`

- pola bazodanowe: 356
- pola kalkulowane (z klas biznesowych): 182

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| AdresDoKorespondencji | `Soneta.Core.Adres` |  |  |  |
| AdresNaPrzelewach | `Soneta.Kadry.AdresPracownikaNaPrzelewach` | bazodanowe, enum |  |  |
| AdresZameldowania | `Soneta.Core.Adres` |  |  |  |
| AdresZamieszkania | `Soneta.Core.Adres` |  |  |  |
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| ChorobowyBO | `Soneta.Kadry.ChorobowyBO` | bazodanowe |  |  |
| ChorobowyBO.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| ChorobowyBO.DniWynagrodzenia | `int` | bazodanowe |  | Liczba dni zwolnienia chorobowego finansowanego ze środków pracodawcy |
| ChorobowyBO.DniZasilkowe | `int` | bazodanowe |  | Liczba dni zwolnienia wliczana do aktualnego okresu zasiłkowego |
| ChorobowyBO.DniZwolnienia | `int` | bazodanowe |  | Liczba dni nieprzerwanego (ciągłego) dobrowolnego zwolnienia chorobowego |
| ChorobowyBO.MiesiacPodstawy | `Soneta.Types.YearMonth` | bazodanowe | Miesiąc podstawy |  |
| ChorobowyBO.Podstawa | `decimal` | bazodanowe |  |  |
| ChorobowyBO.PrzedluzenieOZ | `bool` | bazodanowe |  | Okres zasiłkowy został przedłużony o 3 miesiące |
| ChorobowyBO.ZasilekIloscDni | `int` |  |  |  |
| ChorobowyBO.ZasilekOdDnia | `Soneta.Types.Date` | bazodanowe |  |  |
| DefinicjaRCP | `Soneta.Kadry.IDefinicjaRCP` | bazodanowe |  |  |
| DodSwiadczeniaZUS | `Soneta.Kadry.DodatkoweŚwiadczeniaZUS` |  | Dodatkowe świadczenia ZUS |  |
| DodatkowyBO | `Soneta.Kadry.DodatkowyBO` | bazodanowe |  |  |
| DodatkowyBO.BezPierwszego | `bool` | bazodanowe |  | Prawo do urlopu w pierwszym miesiącu zatrudnienia pracownik nabył u poprzedniego pracodawcy |
| DodatkowyBO.Data | `Soneta.Types.Date` |  |  |  |
| DodatkowyBO.UPoprzednich | `decimal` | bazodanowe |  | Limit urlopu dodatkowego wykorzystanego u poprzednich pracodawców (dni) |
| DodatkowyBO.Wykorzystany | `Soneta.Types.Time` | bazodanowe |  | Limit urlopu dodatkowego wykorzystanego u poprzednich pracodawców przypadający na bieżące zatrudnienie (godz.) |
| Dokument | `Soneta.Kadry.DokumentOsoby` |  |  |  |
| EmeryturaMundurowa | `Soneta.Kadry.EmeryturaMundurowa` |  |  |  |
| Etat | `Soneta.Kadry.Etat` | bazodanowe |  |  |
| Etat.BezCieciaOkresu | `bool` | bazodanowe |  |  |
| Etat.CięcieOkresu | `bool` |  |  |  |
| Etat.ConfigPoczątekDobyNiedzieledIŚwięta | `Soneta.Types.Time` |  |  |  |
| Etat.DataPrzejeciaPracownika | `Soneta.Types.Date` | bazodanowe | Data przejęcia | Data przejęcia pracownika w trybie art. 23' K.P. |
| Etat.DataPrzejeciaPracownikaPIT | `Soneta.Types.Date` |  |  |  |
| Etat.DataPrzejeciaPracownikaUI | `Soneta.Types.Date` |  |  |  |
| Etat.DataRozpPracy | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.DataZawarcia | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.Definicja | `Soneta.HR.DefinicjaStanowiska` | bazodanowe |  |  |
| Etat.DefinicjaFunkcji | `Soneta.HR.DefinicjaFunkcji` | bazodanowe |  |  |
| Etat.DefinicjaFunkcjiInt | `Soneta.HR.DefinicjaFunkcji` |  |  |  |
| Etat.DefinicjaInt | `Soneta.HR.DefinicjaStanowiska` |  |  |  |
| Etat.DefinicjaStanowiskaHistoria | `Soneta.HR.DefinicjaStanowiskaHist` |  |  |  |
| Etat.EdycjaKategoriiPracownika | `bool` | bazodanowe |  |  |
| Etat.EfektywnyOkres | `Soneta.Types.FromTo` |  |  |  |
| Etat.EfektywnyOkresNaliczania | `Soneta.Types.FromTo` |  |  |  |
| Etat.FormaOrganizacjiPracy | `Soneta.Kadry.FormaOrganizacjiPracy` | bazodanowe |  |  |
| Etat.Funkcja | `string` | bazodanowe |  |  |
| Etat.FunkcjaPełna | `string` |  |  |  |
| Etat.GodzinyPonadwymiarowe | `Soneta.Types.Time` | bazodanowe |  |  |
| Etat.Grupa | `Soneta.Kadry.GrupaZaszeregowania` | bazodanowe |  |  |
| Etat.GrupaInt | `Soneta.Kadry.GrupaZaszeregowania` |  |  |  |
| Etat.InnyPracodawca | `bool` |  |  |  |
| Etat.InterpretacjaKalendarza | `Soneta.Kadry.InterpretacjaKalendarza` | bazodanowe, enum |  |  |
| Etat.InterpretacjaKalendarzaPozaOkrZatr | `Soneta.Kadry.InterpretacjaKalendarzaPozaOkrZatr` | bazodanowe, enum |  |  |
| Etat.Kalendarz | `Soneta.Kalend.Kalendarz` | bazodanowe |  |  |
| Etat.KategoriaPracownika | `Soneta.HR.KategoriaPracownika` | bazodanowe |  |  |
| Etat.KodWykonywanegoZawodu | `int` | bazodanowe |  |  |
| Etat.KodWykonywanegoZawoduLnk | `Soneta.Kadry.KodWykonywanegoZawodu` |  |  |  |
| Etat.LimitNadgodzin | `int` | bazodanowe |  |  |
| Etat.MagazynNadgodzin | `Soneta.Types.YearMonth` | bazodanowe |  |  |
| Etat.MiejscaPracyOpis | `string` | bazodanowe |  |  |
| Etat.MiejscePracy | `string` | bazodanowe |  | Miejsce wykonywania pracy |
| Etat.NormaDobowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Etat.NormaDobowaTygodniowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Etat.NormaTygodniowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Etat.NumerUmowy | `int` |  |  |  |
| Etat.ObnizenieEtatu | `Soneta.Kadry.ObniżenieWymiaruEtatu` |  |  |  |
| Etat.OddelegowanyDo | `Soneta.Kadry.IKrajDelegacji` | bazodanowe, iface-ref |  |  |
| Etat.Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  |  |
| Etat.OgraniczeniePrzerwy | `Soneta.Kadry.OgraniczeniePrzerwyCovid` | bazodanowe, enum |  |  |
| Etat.Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Etat.OkresProbny | `Soneta.Kadry.OkresProbny` | bazodanowe |  |  |
| Etat.OkresProbny.DataZakonczenia | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.OkresProbny.DniUsprawiedliwione | `int` |  |  |  |
| Etat.OkresProbny.JestOkresProbny | `bool` |  |  |  |
| Etat.OkresProbny.PlanowanyOkres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Etat.OkresProbny.Przedluzenie | `Soneta.Kadry.OkresPróbnyPodlegaPrzedłużeniu` | bazodanowe, enum |  |  |
| Etat.OkresProbny.PrzedluzenieUmowy | `bool` |  |  |  |
| Etat.OkresPrzechowywania | `int` | bazodanowe |  |  |
| Etat.OkresUmowy | `Soneta.Types.FromTo` |  |  |  |
| Etat.OkresWypowiedzenia | `Soneta.Kadry.OkresWypowiedzenia` | bazodanowe |  |  |
| Etat.OkresWypowiedzenia.DataRozwiązaniaUmowy | `Soneta.Types.Date` |  |  |  |
| Etat.OkresWypowiedzenia.DataZlozenia | `Soneta.Types.Date` | bazodanowe | Data złożenia | Data złożenia wypowiedzenia |
| Etat.OkresWypowiedzenia.Dni | `int` | bazodanowe | Dni | Okres wypowiedzenia - dni |
| Etat.OkresWypowiedzenia.Miesiace | `int` | bazodanowe | Miesiące | Okres wypowiedzenia - miesiące |
| Etat.OkresWypowiedzenia.Skrocony | `bool` | bazodanowe | Skrócony | Skrócony okres wypowiedzenia |
| Etat.OkresWypowiedzenia.Tygodnie | `int` | bazodanowe | Tygodnie | Okres wypowiedzenia - tygodnie |
| Etat.OkresWypowiedzenia.Uplywa | `Soneta.Types.Date` | bazodanowe | Upływa | Data upływu ukresu wypowiedzenia |
| Etat.OkresWypowiedzenia.ZwolnionyZObowiazkuPracyOd | `Soneta.Types.Date` | bazodanowe | Data zwolnienia z obowiązku pracy | Data zwolnienia z obowiązku pracy |
| Etat.OkresZatrudnienia | `Soneta.Types.FromTo` |  |  |  |
| Etat.OkresZatrudnieniaEtat | `Soneta.Types.FromTo` |  |  |  |
| Etat.OkresZatrudnieniaTymczasowy | `Soneta.Types.FromTo` |  |  |  |
| Etat.PakietMobilnosci | `bool` | bazodanowe |  |  |
| Etat.PodatekZaGranica | `bool` | bazodanowe |  |  |
| Etat.Podstawa | `Soneta.Kadry.StosPracyNaPodstawie` | bazodanowe, enum |  |  |
| Etat.PoprzedniPracodawca | `string` | bazodanowe |  |  |
| Etat.PoprzedniPracodawcaUI | `string` |  |  |  |
| Etat.Postojowe | `Soneta.Kadry.WynagrodzeniePostojowe` | bazodanowe |  |  |
| Etat.Postojowe.Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Etat.Postojowe.Standardowe | `bool` |  |  |  |
| Etat.PowiązanyOkresZatrudnienia | `Soneta.Types.FromTo` |  |  |  |
| Etat.PracownikNiepelnosprawnyZgodaNaPrace8h | `bool` | bazodanowe |  |  |
| Etat.PracownikNiepelnosprawnyZgodaNaPraceNadgodziny | `bool` | bazodanowe |  |  |
| Etat.PracownikNiepelnosprawnyZgodaNaPraceWPorzeNocnej | `bool` | bazodanowe |  |  |
| Etat.PracownikTymczasowy | `bool` |  |  |  |
| Etat.PracownikZaGranicą | `bool` |  |  |  |
| Etat.PracownikZwolniony | `bool` | bazodanowe |  |  |
| Etat.ProcentMinimalnego | `Soneta.Types.Percent` | bazodanowe |  |  |
| Etat.ProcentMinimalnegoDoDnia | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.Przedłużenia | `Soneta.Types.Periods` |  |  |  |
| Etat.PrzejetyPrzezInnego | `bool` | bazodanowe | Przekazany | Pracownik przejęty przez innego pracodawcę w trybie art. 23' K.P. |
| Etat.PrzeliczeniePodstawyZasilku | `bool` | bazodanowe |  |  |
| Etat.PrzerwaDodatkowaNiep | `bool` | bazodanowe |  |  |
| Etat.PrzerwaNiewliczana | `bool` | bazodanowe |  |  |
| Etat.PrzyczynaRozwUmowy | `string` |  |  |  |
| Etat.PrzyczynaZawUmowy | `string` |  |  |  |
| Etat.RodzajPracy | `string` | bazodanowe |  | Rodzaj wykonywanej pracy |
| Etat.RodzajPrzejecia | `Soneta.Kadry.RodzajePrzejęciaPrzedsiębiorstwa` | enum | Rodzaj przejęcia |  |
| Etat.RodzajPrzejeciaUI | `Soneta.Kadry.RodzajePrzejęciaPrzedsiębiorstwa` | enum |  |  |
| Etat.RodzajZatrudnienia | `Soneta.Kadry.RodzajZatrudnienia` | bazodanowe, enum |  |  |
| Etat.RozwiazanieUmowy | `Soneta.Kadry.RozwiazanieUmowy` | bazodanowe |  |  |
| Etat.RozwiazanieUmowy.Inicjatywa | `Soneta.Kadry.KodInicjatywyZwolnienia` | bazodanowe, enum |  |  |
| Etat.RozwiazanieUmowy.KodZwolnienia | `Soneta.Kadry.KodZwolnienia` | bazodanowe, enum |  |  |
| Etat.RozwiazanieUmowy.PodstawaPrawna | `Soneta.Kadry.KodPodstawyPrawnejZwolnienia` | bazodanowe, enum |  |  |
| Etat.RozwiazanieUmowy.PrzyczynaRozwUmowy | `Soneta.Kadry.PrzyczynaRozwUmowy` | bazodanowe |  |  |
| Etat.RozwiazanieUmowy.PrzyczynaRozwUmowyOpis | `string` | bazodanowe |  |  |
| Etat.RozwiazanieUmowy.WgPrzyczynaRozwUmowy | `Soneta.Business.Key` |  |  |  |
| Etat.RozwiazanieUmowy.ZaOdszkodowaniem | `bool` | bazodanowe |  |  |
| Etat.Seria | `string` | bazodanowe |  |  |
| Etat.Specjalosc | `string` | bazodanowe |  |  |
| Etat.Stanowisko | `string` | bazodanowe |  |  |
| Etat.StanowiskoPełne | `string` |  |  |  |
| Etat.StanowiskoZMonitorem | `bool` | bazodanowe |  |  |
| Etat.StdLimitNadgodzin | `bool` |  |  |  |
| Etat.StdNorma | `bool` |  |  |  |
| Etat.StdProcentMinimalnego | `bool` |  |  |  |
| Etat.StdWspolczynnikLimitu | `bool` |  |  |  |
| Etat.SystemCzasuPracy | `Soneta.Kadry.SystemCzasuPracy` | bazodanowe, enum |  |  |
| Etat.TerminPrzechowywania | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` | bazodanowe, enum |  |  |
| Etat.TypUmowy | `Soneta.Kadry.TypUmowyOPrace` | bazodanowe, enum |  |  |
| Etat.Ubezpieczenia | `Soneta.Kadry.Ubezpieczenia` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Chorobowe | `Soneta.Kadry.Spoleczne` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Emerytalne | `Soneta.Kadry.Spoleczne` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Emerytalne.Do | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Emerytalne.Dobrowolne | `bool` |  |  |  |
| Etat.Ubezpieczenia.Emerytalne.DobrowolneOd | `Soneta.Types.Date` |  |  |  |
| Etat.Ubezpieczenia.Emerytalne.KodPrzyczyny | `Soneta.Kadry.PrzyczynaWyrejestrowania` | enum |  |  |
| Etat.Ubezpieczenia.Emerytalne.Obowiazkowe | `bool` |  |  |  |
| Etat.Ubezpieczenia.Emerytalne.ObowiazkoweOd | `Soneta.Types.Date` |  |  |  |
| Etat.Ubezpieczenia.Emerytalne.ObowiązujeOd | `Soneta.Types.Date` |  |  |  |
| Etat.Ubezpieczenia.Emerytalne.Od | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Emerytalne.Okres | `Soneta.Types.FromTo` |  |  |  |
| Etat.Ubezpieczenia.Emerytalne.Przyczyna | `Soneta.Kadry.Wyrejestrowanie` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Emerytalne.Typ | `Soneta.Kadry.TypUbezpieczenia` | bazodanowe, enum |  |  |
| Etat.Ubezpieczenia.Emerytalne.UbezpieczenieOd | `Soneta.Types.Date` |  |  |  |
| Etat.Ubezpieczenia.Emerytalne.Ubezpieczony | `bool` |  |  |  |
| Etat.Ubezpieczenia.Emerytalne.Wyrejestrowany | `bool` |  |  |  |
| Etat.Ubezpieczenia.Historia | `Soneta.Kadry.PracHistoria` |  |  |  |
| Etat.Ubezpieczenia.Host | `Soneta.Kadry.IUbezpieczenieHost` |  |  |  |
| Etat.Ubezpieczenia.Kontynuacja | `Soneta.Kadry.KontynuacjaUbezpieczenia` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Kontynuacja.OdDnia | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Kontynuacja.Tyub | `int` |  |  |  |
| Etat.Ubezpieczenia.Kontynuacja.Tyub4 | `Soneta.Kadry.TytulUbezpieczenia4` | bazodanowe | Tytuł ubezpieczenia |  |
| Etat.Ubezpieczenia.Kontynuacja.WgTyub4 | `Soneta.Business.Key` |  |  |  |
| Etat.Ubezpieczenia.ObowiazkoweOd | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.Ubezpieczenia.PrawoEmRent | `int` |  |  |  |
| Etat.Ubezpieczenia.Rentowe | `Soneta.Kadry.Spoleczne` | bazodanowe |  |  |
| Etat.Ubezpieczenia.StopienNiepelnosp | `int` |  |  |  |
| Etat.Ubezpieczenia.Tyub | `Soneta.Kadry.TytulUbezpieczenia` |  |  |  |
| Etat.Ubezpieczenia.Tyub4 | `Soneta.Kadry.TytulUbezpieczenia4` | bazodanowe | Tytuł ubezpieczenia |  |
| Etat.Ubezpieczenia.Ubezpieczony | `bool` |  |  |  |
| Etat.Ubezpieczenia.WgTyub4 | `Soneta.Business.Key` |  |  |  |
| Etat.Ubezpieczenia.Wypadkowe | `Soneta.Kadry.Spoleczne` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Zdrowotne | `Soneta.Kadry.Zdrowotne` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Do | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Dobrowolne | `bool` |  |  |  |
| Etat.Ubezpieczenia.Zdrowotne.DobrowolneOd | `Soneta.Types.Date` |  |  |  |
| Etat.Ubezpieczenia.Zdrowotne.KodPrzyczyny | `Soneta.Kadry.PrzyczynaWyrejestrowania` | enum |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Obowiazkowe | `bool` |  |  |  |
| Etat.Ubezpieczenia.Zdrowotne.ObowiazkoweOd | `Soneta.Types.Date` |  |  |  |
| Etat.Ubezpieczenia.Zdrowotne.ObowiązujeOd | `Soneta.Types.Date` |  |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Od | `Soneta.Types.Date` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Okres | `Soneta.Types.FromTo` |  |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Przyczyna | `Soneta.Kadry.Wyrejestrowanie` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Skladka | `decimal` | bazodanowe |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Typ | `Soneta.Kadry.TypUbezpieczenia` | bazodanowe, enum |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Ubezpieczony | `bool` |  |  |  |
| Etat.Ubezpieczenia.Zdrowotne.Wyrejestrowany | `bool` |  |  |  |
| Etat.UmowaNaCzasOkreślony | `bool` |  |  |  |
| Etat.UmowaOPrace | `Soneta.Kadry.UmowaOPrace` | bazodanowe |  |  |
| Etat.UmowaOPrace.OkresWypowiedzenia | `int` | bazodanowe |  |  |
| Etat.UmowyIPrzedłużenia | `Soneta.Types.Periods` |  |  |  |
| Etat.WgDefinicja | `Soneta.Business.Key` |  |  |  |
| Etat.WgDefinicjaFunkcji | `Soneta.Business.Key` |  |  |  |
| Etat.WgFormaOrganizacjiPracy | `Soneta.Business.Key` |  |  |  |
| Etat.WgGrupa | `Soneta.Business.Key` |  |  |  |
| Etat.WgKalendarz | `Soneta.Business.Key` |  |  |  |
| Etat.WgKategoriaPracownika | `Soneta.Business.Key` |  |  |  |
| Etat.WgOddelegowanyDo | `Soneta.Business.Key` |  |  |  |
| Etat.WgOddzial | `Soneta.Business.Key` |  |  |  |
| Etat.WgWydzial | `Soneta.Business.Key` |  |  |  |
| Etat.WgZastepstwoZa | `Soneta.Business.Key` |  |  |  |
| Etat.WieleMiejscPracy | `bool` | bazodanowe |  |  |
| Etat.WspolczynnikLimitu | `double` | bazodanowe |  |  |
| Etat.Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Etat.WymNormaDobowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Etat.WymNormaDobowaTygodniowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Etat.WymNormaTygodniowa | `Soneta.Types.Time` | bazodanowe |  |  |
| Etat.WymStdNorma | `bool` |  |  |  |
| Etat.Wymiar | `Soneta.Types.Fraction` |  |  |  |
| Etat.WynagrodzenieAkordowe | `bool` | bazodanowe |  |  |
| Etat.Wynajmujący | `Soneta.CRM.Kontrahent` |  |  |  |
| Etat.ZastepstwoNieobecnyDo | `Soneta.Types.Date` |  |  |  |
| Etat.ZastepstwoZa | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Etat.Zaszeregowanie | `Soneta.Kadry.Zaszeregowanie` | bazodanowe |  |  |
| Etat.Zaszeregowanie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Etat.Zaszeregowanie.Godzinowe | `bool` |  |  |  |
| Etat.Zaszeregowanie.Miesięczne | `bool` |  |  |  |
| Etat.Zaszeregowanie.RodzajStawki | `Soneta.Kadry.RodzajStawkiZaszeregowania` | bazodanowe, enum |  |  |
| Etat.Zaszeregowanie.Stawka | `Soneta.Types.Currency` | bazodanowe |  |  |
| Etat.Zaszeregowanie.TypStawki | `Soneta.Kadry.TypStawkiZaszeregowania` | enum |  |  |
| Etat.Zaszeregowanie.WgElement | `Soneta.Business.Key` |  |  |  |
| Etat.Zaszeregowanie.WskaznikKrotnosc | `double` | bazodanowe |  |  |
| Etat.Zaszeregowanie.WskaznikNazwa | `string` | bazodanowe |  |  |
| Etat.Zaszeregowanie.Wymiar | `Soneta.Types.Fraction` | bazodanowe |  |  |
| Etat.Zatrudnienie | `Soneta.Kadry.PracHistoria` |  |  |  |
| Etat.ZawarcieUmowy | `Soneta.Kadry.ZawarcieUmowy` | bazodanowe |  |  |
| Etat.ZawarcieUmowy.PrzyczynaZawUmowy | `Soneta.Kadry.PrzyczynaZawUmowy` | bazodanowe |  |  |
| Etat.ZawarcieUmowy.PrzyczynaZawUmowyOpis | `string` | bazodanowe |  |  |
| Etat.ZawarcieUmowy.WgPrzyczynaZawUmowy | `Soneta.Business.Key` |  |  |  |
| Etat.ZbiorowyUkladPracy | `bool` | bazodanowe |  | Pracownik objęty układem zbiorowym pracy |
| Etat.Zwolnienie | `Soneta.Kadry.PracHistoria` |  |  |  |
| EuVAT | `string` | bazodanowe | EU VAT |  |
| GUS | `Soneta.Kadry.StatystykaGUS` | bazodanowe |  |  |
| GUS.GlowneMiejscePracy | `bool` | bazodanowe |  |  |
| GUS.KodWyksztalcenia | `Soneta.Kadry.KodWykształceniaGUS` | bazodanowe, enum |  |  |
| GUS.PierwszaPraca | `bool` | bazodanowe |  |  |
| GUS.PopMiejsceZatrudnienia | `Soneta.Kadry.PopMiejsceZatrudnienia` | bazodanowe, enum |  |  |
| GUS.PracaWNocy | `bool` | bazodanowe |  |  |
| GUS.PraceInterwencyjne | `bool` | bazodanowe |  |  |
| GUS.RodzajZatrudnienia | `Soneta.Kadry.RodzajZatrudnieniaGUS` | bazodanowe, enum |  |  |
| GUS.SezonowyDorywczy | `bool` | bazodanowe |  |  |
| GUS.StRobotnicze | `bool` | bazodanowe |  |  |
| GUS.SymbolSystemuCzasuPracyGUS | `Soneta.Kadry.SymbolSystemuCzasuPracy` | bazodanowe, enum |  |  |
| Identyfikator | `Soneta.Kadry.PracHistoria.IdentyfikatorZUS` |  |  |  |
| IdentyfikatorPodatkowy | `Soneta.Kadry.IdentyfikatorPodatkowyPracownika` | bazodanowe, enum |  |  |
| IloscDzialalnosci | `int` | bazodanowe | Ilość działalności |  |
| Imie | `string` | bazodanowe |  |  |
| ImieDrugie | `string` | bazodanowe |  |  |
| ImieMatki | `string` | bazodanowe |  |  |
| ImieOjca | `string` | bazodanowe |  |  |
| InneDane | `Soneta.Kadry.InneDaneHistoryczne` |  |  |  |
| KasaChorych | `Soneta.Kadry.KasaChorych` | bazodanowe |  |  |
| KasaChorych.Kod | `string` | bazodanowe |  |  |
| KasaChorych.Nazwa | `string` |  |  |  |
| KasaChorych.OdDnia | `Soneta.Types.Date` | bazodanowe |  |  |
| KombatanckiBO | `Soneta.Kadry.KombatanckiBO` | bazodanowe |  |  |
| KombatanckiBO.BezPierwszego | `bool` |  |  |  |
| KombatanckiBO.Data | `Soneta.Types.Date` |  |  |  |
| KombatanckiBO.PrawoDoUrlopu | `bool` | bazodanowe |  | Prawo do urlopu kombatanckiego |
| KombatanckiBO.UPoprzednich | `decimal` | bazodanowe |  | Limit urlopu kombatanckiego wykorzystanego u poprzednich pracodawców (dni) |
| KombatanckiBO.Wykorzystany | `Soneta.Types.Time` | bazodanowe |  | Limit urlopu kombatanckiego wykorzystanego u poprzednich pracodawców przypadający na bieżące zatrudnienie (godz.) |
| Kontakt | `Soneta.Core.Kontakt` |  |  |  |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| KontrolaAktywna | `bool` |  |  |  |
| NIP | `string` | bazodanowe |  |  |
| Następny | `Soneta.Kadry.PracHistoria` |  |  |  |
| Nazwisko | `string` | bazodanowe |  |  |
| NazwiskoRodowe | `string` | bazodanowe |  |  |
| NazwiskoRodoweMatki | `string` | bazodanowe |  |  |
| NiePowiekszajWymiaruSkladkiZdrowotnej | `bool` |  | Nie powiększaj podstawy wymiaru składki zdrowotnej, jeżeli remanent końcowy jest wyższy od remanentu początkowego w 2022 r. |  |
| Nieobecnosci | `Soneta.Kadry.RozliczanieNieobecnosci` | bazodanowe |  |  |
| Nieobecnosci.OkresZasilkowy | `Soneta.Kadry.OkresZasilkowy` | bazodanowe, enum |  |  |
| Nieobecnosci.PodstawaUrlopu | `int` | bazodanowe |  |  |
| Nieobecnosci.PodstawaUrlopuZmienne | `int` | bazodanowe |  |  |
| Nieobecnosci.PodstawaZasilku | `int` | bazodanowe |  |  |
| Nieobecnosci.StdPodstawaUrlopu | `bool` |  |  |  |
| Nieobecnosci.StdPodstawaZasilku | `bool` |  |  |  |
| NumerAkt | `string` | bazodanowe |  |  |
| Obywatelstwo | `Soneta.Kadry.Obywatelstwo` |  |  |  |
| OddzialNFZ | `Soneta.Kadry.OddzialNFZ` | bazodanowe |  |  |
| OddzialNFZ.Kod | `string` |  |  |  |
| OddzialNFZ.KodGminy | `string` | bazodanowe |  |  |
| OddzialNFZ.Nazwa | `string` |  |  |  |
| OddzialNFZ.OdDnia | `Soneta.Types.Date` |  |  |  |
| OddzialNFZ.Oddział | `Soneta.Kadry.OddzialNFZ.OddziałNFZ` |  |  |  |
| OdpisOPP | `Soneta.Kadry.OdpisOPP` | bazodanowe |  |  |
| OdpisOPP.Koncowka | `decimal` | bazodanowe |  |  |
| OdpisOPP.Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| OdpisOPP.Naliczanie | `Soneta.Kadry.NaliczanieOdpisuOPP` | bazodanowe, enum |  |  |
| OdpisOPP.OpisPrzelewu | `string` | bazodanowe |  |  |
| OdpisOPP.Organizacja | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| OdpisOPP.WgOrganizacja | `Soneta.Business.Key` |  |  |  |
| OdpisPPK | `Soneta.Kadry.OdpisPPK` | bazodanowe |  |  |
| OdpisPPK.BlokadaWplatSklData | `Soneta.Types.Date` | bazodanowe |  |  |
| OdpisPPK.DataRezygnacji | `Soneta.Types.Date` | bazodanowe |  |  |
| OdpisPPK.DataWznowienia | `Soneta.Types.Date` | bazodanowe |  |  |
| OdpisPPK.DataZgloszenia | `Soneta.Types.Date` | bazodanowe |  |  |
| OdpisPPK.DodPracodawcy | `Soneta.Types.Percent` | bazodanowe |  |  |
| OdpisPPK.DodPracownika | `Soneta.Types.Percent` | bazodanowe |  |  |
| OdpisPPK.EMailDomyslny | `bool` | bazodanowe |  |  |
| OdpisPPK.Email | `string` |  |  |  |
| OdpisPPK.ID_KADRY | `string` | bazodanowe |  |  |
| OdpisPPK.Identyfikator | `string` | bazodanowe |  |  |
| OdpisPPK.Naliczanie | `bool` |  |  |  |
| OdpisPPK.NumerRachunku | `string` | bazodanowe |  |  |
| OdpisPPK.OkresNaliczania | `Soneta.Types.FromTo` |  |  |  |
| OdpisPPK.PodstPracownika | `Soneta.Types.Percent` | bazodanowe |  |  |
| OdpisPPK.PracownikaZaOkresZawieszenia | `bool` |  |  |  |
| OdpisPPK.RodzajSkladki | `Soneta.Kadry.RodzajeSkładekPPK` | bazodanowe, enum |  |  |
| OdpisPPK.RodzajWznowienia | `Soneta.Kadry.RodzajWznowieniaPPK` | bazodanowe, enum |  |  |
| OdpisPPK.RodzajZgloszenia | `Soneta.Kadry.RodzajZgloszeniaPPK` | bazodanowe, enum |  |  |
| OdpisPPK.StdDodPracodawcy | `bool` | bazodanowe |  |  |
| OdpisPPK.StdPodstPracownika | `bool` | bazodanowe |  |  |
| OdpisPPK.TelefonDomyslny | `bool` | bazodanowe |  |  |
| OdpisPPK.TelefonKomorkowy | `string` |  |  |  |
| OdpisPPK.WydziałPPK | `Soneta.Kadry.Wydzial` |  |  |  |
| OdpisPPK.ZgodaEMail | `bool` | bazodanowe |  |  |
| OdpisPPK.ZgodaTelefon | `bool` | bazodanowe |  |  |
| OdpisPPK.Zgłoszony | `bool` |  |  |  |
| OjcowskiBO | `Soneta.Kadry.OjcowskiBO` | bazodanowe |  |  |
| OjcowskiBO.Data | `Soneta.Types.Date` |  |  |  |
| OjcowskiBO.Dziecko | `Soneta.Kadry.CzlonekRodziny` | bazodanowe |  |  |
| OjcowskiBO.UPoprzednich | `int` | bazodanowe |  | Limit urlopu ojcowskiego wykorzystanego u poprzednich pracodawców (dni) |
| OjcowskiBO.UPoprzednichTygodnie | `int` |  |  |  |
| OjcowskiBO.WgDziecko | `Soneta.Business.Key` |  |  |  |
| Opiekunczy188BO | `Soneta.Kadry.Opiekunczy188BO` | bazodanowe |  |  |
| Opiekunczy188BO.Data | `Soneta.Types.Date` |  |  |  |
| Opiekunczy188BO.DataWniosku | `Soneta.Types.Date` | bazodanowe |  | Data złożenia wniosku |
| Opiekunczy188BO.RodzajLimitu | `Soneta.Kadry.RodzajLimituOp188` | bazodanowe, enum |  | Wniosek o urlop na dni/godziny |
| Opiekunczy188BO.UPoprzednich | `int` | bazodanowe |  | Limit urlopu dodatkowego wykorzystanego u poprzednich pracodawców (dni) |
| Opiekunczy188BO.UPoprzednichGodz | `Soneta.Types.Time` | bazodanowe |  | Limit urlopu dodatkowego wykorzystanego u poprzednich pracodawców (godz.) |
| OpiekunczyBO | `Soneta.Kadry.OpiekunczyBO` | bazodanowe |  |  |
| OpiekunczyBO.Data | `Soneta.Types.Date` |  |  |  |
| OpiekunczyBO.Dorosly | `int` | bazodanowe |  | Liczba dni wykorzystanego urlopu opiekuńczego – opieka nad innym członkiem rodziny (maksymalnie 14 dni w roku kalendarzowym) |
| OpiekunczyBO.Dziecko | `int` | bazodanowe |  | Liczba dni wykorzystanego urlopu opiekuńczego – opieka nad dzieckiem (maksymalnie 60 dni w roku kalendarzowym) |
| OpiekunczyBO.DzieckoNiepelnosp | `int` | bazodanowe |  | Liczba dni wykorzystanego urlopu opiekuńczego – opieka nad dzieckiem niepełnosprawnym w wieku od 8/14 lat do ukończenia 18 lat (maksymalnie 30 dni w roku) |
| OpiekunczyBO.InformacjeZaRok | `int` | bazodanowe |  | Informacje aktualne w roku kalendarzowym |
| OpiekunczyNieplatnyBO | `Soneta.Kadry.OpiekunczyNieplatnyBO` | bazodanowe |  |  |
| OpiekunczyNieplatnyBO.Data | `Soneta.Types.Date` |  |  |  |
| OpiekunczyNieplatnyBO.UPoprzednich | `int` | bazodanowe |  | Limit urlopu opiekuńczego bezpłatnego wykorzystanego u poprzednich pracodawców (dni) |
| OpisAktualizacji | `Soneta.Business.MemoText` | bazodanowe | Opis aktualizacji | Opis aktualizacji zapisu |
| OpisStanowiskaZeSkierowaniaNaBad | `string` | bazodanowe |  |  |
| Oswiata | `Soneta.Kadry.PracownikOświaty` |  |  |  |
| PESEL | `string` | bazodanowe |  |  |
| PFRON | `Soneta.Kadry.DanePFRON` |  |  |  |
| PIT40 | `Soneta.Kadry.DaneDodatkowePIT40` |  |  |  |
| PIT5BO | `Soneta.Kadry.BilansOtwarciaPIT5` |  |  |  |
| PIT5Inne | `Soneta.Kadry.PIT5DochodyInneBazy` |  |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| Plec | `Soneta.Kadry.PłećOsoby` | bazodanowe, enum |  |  |
| Podatki | `Soneta.Kadry.PodatkiInfo` | bazodanowe |  |  |
| Podatki.Koszty50Limit | `decimal` | bazodanowe |  |  |
| Podatki.Koszty50NieNaliczajOd | `Soneta.Types.YearMonth` | bazodanowe |  |  |
| Podatki.Koszty50NieNaliczajOdDnia | `Soneta.Types.Date` | bazodanowe |  |  |
| Podatki.Koszty50Procent | `Soneta.Types.Percent` | bazodanowe |  |  |
| Podatki.KosztyMnoznik | `decimal` | bazodanowe |  |  |
| Podatki.KosztyRodzaj | `Soneta.Kadry.RodzajKosztowUzyskania` | bazodanowe, enum |  |  |
| Podatki.NaPITAdresZameldowania | `bool` | bazodanowe |  |  |
| Podatki.Pit26 | `Soneta.Kadry.NaliczajPit26` | bazodanowe, enum |  |  |
| Podatki.PodwProg2019 | `bool` | bazodanowe |  | Podwyższona zaliczka podatku za okres od października do grudnia 2019 |
| Podatki.ProgiPodatkowe | `Soneta.Business.SubTable` |  |  |  |
| Podatki.RezygnacjaRozp070122 | `bool` | bazodanowe |  |  |
| Podatki.RezygnacjaRozp070122Umowa | `bool` | bazodanowe |  |  |
| Podatki.TypProgow | `Soneta.Kadry.TypProgowPodatkowych` | bazodanowe, enum |  |  |
| Podatki.UlgaCzesc | `Soneta.Kadry.UlgaPodatkowaCzesc` | bazodanowe, enum |  |  |
| Podatki.UlgaDuzaRodzina | `bool` | bazodanowe |  |  |
| Podatki.UlgaEmeryt | `bool` | bazodanowe |  |  |
| Podatki.UlgaKlasaSrednia | `bool` | bazodanowe |  |  |
| Podatki.UlgaLimit | `bool` | bazodanowe |  |  |
| Podatki.UlgaMnoznik | `decimal` | bazodanowe |  |  |
| Podatki.UlgaZagranica | `bool` | bazodanowe |  |  |
| Podatki.UlgaZagranicaDo | `int` | bazodanowe |  |  |
| Podatki.UlgaZagranicaOd | `int` | bazodanowe |  |  |
| Podatki.UmowaKwotaWolna | `bool` | bazodanowe |  |  |
| Podatki.UrzadSkarbowy | `Soneta.Core.IPodmiotUI` | bazodanowe |  |  |
| Podatki.UrzadSkarbowyEx | `Soneta.CRM.UrzadSkarbowy` |  |  |  |
| Podatki.WgUrzadSkarbowy | `Soneta.Business.Key` |  |  |  |
| PodatkiBO | `Soneta.Kadry.PodatkiBO` | bazodanowe |  |  |
| PodatkiBO.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| PodatkiBO.PrzychodKoszty50 | `decimal` | bazodanowe |  |  |
| PodatkiBO.PrzychodOpodatkowany | `decimal` | bazodanowe |  |  |
| PodatkiBO.PrzychodZwolniony | `decimal` | bazodanowe |  |  |
| PodstawaFGSP | `Soneta.Kadry.PodstawaFGSP` | bazodanowe |  |  |
| PodstawaFGSP.Naliczaj | `Soneta.Kadry.TypNaliczaniaFGŚP` | bazodanowe, enum |  |  |
| PodstawaFP | `Soneta.Kadry.PodstawaFP` | bazodanowe |  |  |
| PodstawaFP.InneDochody | `Soneta.Business.SubTable` |  |  |  |
| PodstawaFP.Naliczaj | `Soneta.Kadry.TypNaliczaniaFP` | bazodanowe, enum |  |  |
| PodstawaFP.PozostawalWEwidencjiPup | `bool` | bazodanowe |  |  |
| PodstawaFP.PozostawalWEwidencjiPupDo30 | `bool` | bazodanowe |  |  |
| Poprzedni | `Soneta.Kadry.PracHistoria` |  |  |  |
| Powiadomic | `Soneta.Core.Osoba` |  |  |  |
| PowiekszajWymiarSkladkiZdrowotnej | `bool` | bazodanowe |  |  |
| PowodAktualizacji | `string` | bazodanowe | Powód aktualizacji | Opis powodu aktualizacji zapisu |
| PracaGornicza | `Soneta.Kadry.PracaGornicza` | bazodanowe |  |  |
| PracaGornicza.Kod | `int` | bazodanowe |  |  |
| PracaGornicza.Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PracaWSzczWarunkach | `Soneta.Kadry.PracaWSzczWarunkach` | bazodanowe |  |  |
| PracaWSzczWarunkach.Kod | `int` | bazodanowe |  |  |
| PracaWSzczWarunkach.KodStr | `string` |  |  |  |
| PracaWSzczWarunkach.Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PracaWSzczWarunkach.OkresExt | `Soneta.Types.FromTo` |  |  |  |
| PracaWSzczWarunkach.Opis | `string` | bazodanowe |  |  |
| PracaWSzczWarunkach2009 | `Soneta.Kadry.PracaWSzczWarunkach2009` | bazodanowe |  |  |
| PracaWSzczWarunkach2009.DataWniosku | `Soneta.Types.Date` | bazodanowe | Data wniosku | Data złożenia wniosku o przyznanie emerytury pomostowej |
| PracaWSzczWarunkach2009.Kod | `Soneta.Kadry.KodPracyWSzególnychWarunkachCharakterze` | bazodanowe |  |  |
| PracaWSzczWarunkach2009.Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| PracaWSzczWarunkach2009.WgKod | `Soneta.Business.Key` |  |  |  |
| PracaZdalna | `Soneta.Kadry.PracZdalna` | bazodanowe |  |  |
| PracaZdalna.IndywidualnyLimitPZ | `bool` | bazodanowe |  |  |
| PracaZdalna.LimitPZ | `int` | bazodanowe |  |  |
| PracaZdalna.ModelPracy | `Soneta.Kadry.ModelPracy` | bazodanowe, enum |  | Model pracy |
| PracaZdalna.OswiadczenieWarunki | `bool` | bazodanowe |  | Spełnia warunki lokalowe i techniczne do wykonywania pracy zdalnej |
| PracaZdalna.TypLimituPZ | `Soneta.Kalend.TypLimituPracyZdalnej` | bazodanowe, enum |  |  |
| PracaZdalnaBO | `Soneta.Kadry.PracaZdalnaBO` | bazodanowe |  |  |
| PracaZdalnaBO.Data | `Soneta.Types.Date` |  |  |  |
| PracaZdalnaBO.OkazjonalnaUPoprzednich | `int` | bazodanowe |  | Ilość dni pracy zdalnej okazjonalnej wykorzystanej u poprzedniego pracodawcy |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| PrawoEmRent | `Soneta.Kadry.PrawoEmRent` | bazodanowe |  |  |
| PrawoEmRent.DataWniosku | `Soneta.Types.Date` | bazodanowe |  |  |
| PrawoEmRent.EmeryturaOd | `Soneta.Types.Date` | bazodanowe |  |  |
| PrawoEmRent.EmeryturaOkres | `Soneta.Types.FromTo` |  |  |  |
| PrawoEmRent.Kod | `Soneta.Kadry.KodPrawaEmRent` | bazodanowe, enum |  |  |
| PrawoEmRent.Numer | `string` | bazodanowe |  | Numer emerytury lub renty |
| PrawoEmRent.OkresExt | `Soneta.Types.FromTo` |  |  |  |
| PrawoEmRent.RentaOkres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| ProgiPodatkowe | `Soneta.Business.SubTable<Soneta.Kadry.ProgPodatkowy>` |  |  |  |
| PrzekrPodstSkladek | `Soneta.Kadry.PrzekrPodstSkladek` | bazodanowe |  |  |
| PrzekrPodstSkladek.Data | `Soneta.Types.Date` | bazodanowe | Data |  |
| PrzekrPodstSkladek.InneDochody | `decimal` | bazodanowe |  |  |
| PrzekrPodstSkladek.Kwota | `decimal` | bazodanowe |  |  |
| PrzekrPodstSkladek.Przekazal | `Soneta.Kadry.KodPrzekrPodstSkladek` | bazodanowe, enum |  |  |
| PrzekrPodstSkladek.TypKwoty | `Soneta.Kadry.TypPrzekrPodstSkladek` | bazodanowe, enum |  |  |
| PrzekrPodstSkladek.ZaRok | `int` | bazodanowe | Za rok |  |
| RGA | `Soneta.Kadry.DaneDlaRGA` | bazodanowe |  |  |
| RGA.KodDniowek | `Soneta.Kadry.KodDniowekZjazdowRGA` | bazodanowe, enum |  |  |
| RGA.KodDruzynyRatowniczej | `Soneta.Kadry.KodDruzynyRatowniczejRGA` | bazodanowe, enum |  |  |
| RGA.KodOkresu | `Soneta.Kadry.KodOkresuRGA` | bazodanowe, enum |  |  |
| RGA.Umieszczaj | `bool` | bazodanowe |  |  |
| RodzicielskiBO | `Soneta.Kadry.RodzicielskiBO` | bazodanowe |  |  |
| RodzicielskiBO.Data | `Soneta.Types.Date` |  |  |  |
| RodzicielskiBO.UPoprzednich | `int` | bazodanowe |  | Limit urlopu rodzicielskiego wykorzystanego u poprzednich pracodawców (dni) |
| RodzicielskiBO.UPoprzednichTygodnie | `int` |  |  |  |
| SilaWyzszaBO | `Soneta.Kadry.SilaWyzszaBO` | bazodanowe |  |  |
| SilaWyzszaBO.Data | `Soneta.Types.Date` |  |  |  |
| SilaWyzszaBO.UPoprzednich | `int` | bazodanowe |  | Limit zwolnienia z pracy z powodu działania siły wyższej wykorzystanego u poprzednich pracodawców (dni) |
| SilaWyzszaBO.UPoprzednichGodz | `Soneta.Types.Time` | bazodanowe |  | Limit zwolnienia z pracy z powodu działania siły wyższej wykorzystanego u poprzednich pracodawców (godz.) |
| StNiezdolnDoPracy | `Soneta.Kadry.StNiezdolnDoPracy` | bazodanowe |  |  |
| StNiezdolnDoPracy.Kod | `Soneta.Kadry.KodStNiezdolnDoPracy` | bazodanowe, enum |  |  |
| StNiezdolnDoPracy.Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| StPokrewienstwa | `Soneta.Kadry.KodStPokrewienstwa` | bazodanowe, enum |  |  |
| StanRodzinny | `Soneta.Kadry.StanRodzinny` |  |  |  |
| StatusStudenta | `Soneta.Kadry.StatusStudenta` | bazodanowe |  |  |
| StatusStudenta.AktualnieStudiuje | `bool` | bazodanowe | Aktualnie studiuje |  |
| StatusStudenta.NumerLegitymacjiStudenckiej | `string` | bazodanowe | Numer legitymacji studenckiej |  |
| StatusStudenta.OkresStudiow | `Soneta.Types.FromTo` | bazodanowe | Okres studiów |  |
| StopienNiepelnosp | `Soneta.Kadry.StopienNiepelnosp` | bazodanowe |  |  |
| StopienNiepelnosp.DataWniosku | `Soneta.Types.Date` | bazodanowe |  |  |
| StopienNiepelnosp.DataZaswiadczenia | `Soneta.Types.Date` | bazodanowe |  |  |
| StopienNiepelnosp.Kod | `Soneta.Kadry.KodStNiepelnosprawnosci` | bazodanowe, enum |  |  |
| StopienNiepelnosp.Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| StopienNiepelnosp.OkresEpd | `Soneta.Types.FromTo` |  |  |  |
| StopienNiepelnosp.OkresExt | `Soneta.Types.FromTo` |  |  |  |
| StopienNiepelnosp.OkresExtOld | `Soneta.Types.FromTo` |  |  |  |
| StopienNiepelnosp.Orzeczenie | `Soneta.Kadry.OrzeczenieStopienNiepelnosp` | bazodanowe, enum |  |  |
| StopienNiepelnosp.Stopien | `Soneta.Kadry.StNiepełnosprawności` | bazodanowe, enum |  |  |
| TabelaKursowa | `Soneta.Waluty.TabelaKursowa` | bazodanowe |  |  |
| Udzialy | `Soneta.Types.Fraction` | bazodanowe |  |  |
| UmowaUlgi | `Soneta.Kadry.UmowaUlgiInfo` | bazodanowe |  |  |
| UmowaUlgi.Pit26 | `Soneta.Kadry.NaliczajPit26` | bazodanowe, enum |  |  |
| UmowaUlgi.UlgaCzesc | `Soneta.Kadry.UlgaPodatkowaCzesc` | bazodanowe, enum |  |  |
| UmowaUlgi.UlgaDuzaRodzina | `bool` | bazodanowe |  |  |
| UmowaUlgi.UlgaEmeryt | `bool` | bazodanowe |  |  |
| UmowaUlgi.UlgaMnoznik | `decimal` | bazodanowe |  |  |
| UmowaUlgi.UlgaZagranica | `bool` | bazodanowe |  |  |
| UmowaUlgi.UlgaZagranicaDo | `int` | bazodanowe |  |  |
| UmowaUlgi.UlgaZagranicaOd | `int` | bazodanowe |  |  |
| UmowaUlgi.UmowaKwotaWolna | `bool` | bazodanowe |  |  |
| UmowyDobrowolneChorobowe | `bool` | bazodanowe |  |  |
| UmowyOskladkowane | `bool` | bazodanowe |  |  |
| UmowyOskładkowane | `Soneta.Kadry.PracHistoria.UbezpieczenieZleceniobiorcy` | enum |  |  |
| UmowyTylkoZdrow | `bool` | bazodanowe |  |  |
| Urodzony | `Soneta.Kadry.Urodzony` | bazodanowe |  |  |
| Urodzony.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Urodzony.Miejsce | `string` | bazodanowe |  |  |
| WarunkiZagrozenia | `bool` | bazodanowe |  | Pracownik zatrudniony w warunkach zagrożenia (dla deklaracji ZUS IWA) |
| WeteranBO | `Soneta.Kadry.WeteranBO` | bazodanowe |  |  |
| WeteranBO.BezPierwszego | `bool` |  |  |  |
| WeteranBO.Data | `Soneta.Types.Date` |  |  |  |
| WeteranBO.NaliczajUrlopWeteranaOd | `Soneta.Types.Date` | bazodanowe |  |  |
| WeteranBO.StatusWeterana | `bool` | bazodanowe |  | Pracownik posiada status weterana lub weterana poszkodowanego |
| WeteranBO.UPoprzednich | `decimal` | bazodanowe |  | Limit urlopu weterana wykorzystanego u poprzednich pracodawców (dni) |
| WeteranBO.Wykorzystany | `Soneta.Types.Time` |  |  |  |
| Wlasciciel | `Soneta.Kadry.WlascicielInfo` | bazodanowe |  |  |
| Wlasciciel.DeklaracjaOplacaniaSkladek | `bool` | bazodanowe |  |  |
| Wlasciciel.DochodPoprzedniRok | `decimal` | bazodanowe |  |  |
| Wlasciciel.DodatkowaDzialalnosc | `bool` |  |  |  |
| Wlasciciel.DzialalnoscPoprzedniRok | `int` | bazodanowe |  |  |
| Wlasciciel.FormaOpodatkowania | `Soneta.Kadry.RodzajeFormyOpodatkowania` | bazodanowe, enum |  |  |
| Wlasciciel.IloscDzialalnosci | `int` |  |  |  |
| Wlasciciel.IndywidualnaDRA | `bool` |  |  |  |
| Wlasciciel.LiczPlatnosciPIT5 | `bool` | bazodanowe |  |  |
| Wlasciciel.LimitDochoduPoprzedniRok | `decimal` |  |  |  |
| Wlasciciel.LimitPrzychoduPoprzedniRok | `decimal` |  |  |  |
| Wlasciciel.LiniowyPIT5L | `bool` | bazodanowe |  |  |
| Wlasciciel.NaDRAUmieszczajREGON | `bool` |  |  |  |
| Wlasciciel.NiePowiekszajWymiaruSkladkiZdrowotnej | `bool` |  |  |  |
| Wlasciciel.NumerRachunkuUS | `Soneta.Core.NumerRachunkuUS` |  |  |  |
| Wlasciciel.NumerRachunkuZUS | `Soneta.Core.NumerRachunkuZUS` |  |  |  |
| Wlasciciel.ObnizonaPodstawaZUS | `bool` | bazodanowe |  |  |
| Wlasciciel.PIT5BO | `Soneta.Kadry.BilansOtwarciaPIT5` |  |  |  |
| Wlasciciel.PIT5Inne | `Soneta.Kadry.PIT5DochodyInneBazy` |  |  |  |
| Wlasciciel.PozostaleFormyDzialalnosci | `bool` | bazodanowe |  |  |
| Wlasciciel.ProcentWyp | `Soneta.Types.Percent` | bazodanowe |  |  |
| Wlasciciel.PrzychodPoprzedniRok | `decimal` | bazodanowe |  |  |
| Wlasciciel.PrzychodRyczaltBiezacyRok | `Soneta.Kadry.PrzychodRyczalt` |  |  |  |
| Wlasciciel.PrzychodZDzialnosciPoprzedniRok | `Soneta.Kadry.PrzychodZDzialnosci` |  |  |  |
| Wlasciciel.RodzajObnizeniaPodstawyZUS | `Soneta.Kadry.RodzajeObnizeniaPodstawZUS` | bazodanowe, enum |  |  |
| Wlasciciel.StdProcentWyp | `bool` |  |  |  |
| Wlasciciel.Udzialy | `Soneta.Types.Fraction` |  |  |  |
| Wlasciciel.WakacjeSkladkowe | `bool` | bazodanowe |  |  |
| Wlasciciel.ZUSOdPrzychodu | `bool` | bazodanowe |  |  |
| Wlasciciel.ZmiaForOpodLip2022 | `bool` | bazodanowe |  |  |
| Wlasciciel.ZmiaForOpodSty2022 | `bool` | bazodanowe |  |  |
| Wlasciciel.ZwolnienieSkladkaZdrowotna | `bool` | bazodanowe |  |  |
| Wojsko | `Soneta.Kadry.Wojsko` |  |  |  |
| WspolneGospDomowe | `bool` | bazodanowe |  |  |
| WybranyAdresNaPrzelewach | `Soneta.Core.Adres` |  |  |  |
| Wyksztalcenie | `Soneta.Kadry.Wyksztalcenie` |  |  |  |
| WypoczynkowyBO | `Soneta.Kadry.WypoczynkowyBO` | bazodanowe |  |  |
| WypoczynkowyBO.BezPierwszego | `bool` | bazodanowe |  | Prawo do urlopu w pierwszym miesiącu zatrudnienia pracownik nabył u poprzedniego pracodawcy |
| WypoczynkowyBO.Data | `Soneta.Types.Date` |  |  |  |
| WypoczynkowyBO.NaZadanie | `int` | bazodanowe |  | Liczba dni wykorzystanego urlopu wypoczynkowego 'na żądanie' (maksymalnie 4 dni w roku kalendarzowym) |
| WypoczynkowyBO.UPoprzednich | `decimal` | bazodanowe |  | Limit urlopu wypoczynkowego wykorzystanego u poprzednich pracodawców (dni) |
| WypoczynkowyBO.Wykorzystany | `Soneta.Types.Time` | bazodanowe |  | Limit urlopu wypoczynkowego wykorzystanego u poprzednich pracodawców przypadający na bieżące zatrudnienie (godz.) |
| ZUS | `Soneta.Kadry.DaneZUS` |  |  |  |
| Zadania | `Soneta.Business.SubTable` |  |  |  |
| ZajecieWynagrodzenia | `Soneta.Kadry.ZajęcieWynagrodzeniaInfo` | bazodanowe |  |  |
| ZajecieWynagrodzenia.UprawnDoPodwyzszeniaKwotyWolnej | `int` | bazodanowe |  |  |
| ZgodnoscGIODOPotwierdzona | `bool` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Etat.OddelegowanyDo | `IKrajDelegacji` | `KrajDelegacji` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AdresPracownikaNaPrzelewach (`Soneta.Kadry.AdresPracownikaNaPrzelewach`)
- `Domyślny` = 0 — Zamieszkania lub zameldowania
- `Zameldowania` = 1
- `Zamieszkania` = 2
- `DoKorespondencji` = 3

### IdentyfikatorPodatkowyPracownika (`Soneta.Kadry.IdentyfikatorPodatkowyPracownika`)
- `PESEL` = 1 — Numer PESEL
- `NIP` = 2 — Identyfikator podatkowy NIP

### InterpretacjaKalendarza (`Soneta.Kadry.InterpretacjaKalendarza`)
- `WgPlanu` = 0
- `WgObecnosci` = 1 — Wg obecności
- `WgZestawien` = 2 — Wg zestawień

### InterpretacjaKalendarzaPozaOkrZatr (`Soneta.Kadry.InterpretacjaKalendarzaPozaOkrZatr`)
- `Domyślnie` = 0
- `WgPlanu` = 1
- `WgObecnosci` = 2 — Wg obecności

### KodDniowekZjazdowRGA (`Soneta.Kadry.KodDniowekZjazdowRGA`)
- `Brak` = 0
- `_1` = 1
- `_2` = 2
- `_3` = 3
- `_4` = 4
- `_5` = 5
- `_6` = 6

### KodDruzynyRatowniczejRGA (`Soneta.Kadry.KodDruzynyRatowniczejRGA`)
- `Brak` = 0
- `_1` = 1
- `_2` = 2

### KodInicjatywyZwolnienia (`Soneta.Kadry.KodInicjatywyZwolnienia`)
- `NieDotyczy` = 0
- `Pracownik` = 1
- `Pracodawca` = 2

### KodOkresuRGA (`Soneta.Kadry.KodOkresuRGA`)
- `Brak` = 0
- `_01` = 1
- `_02` = 2
- `_03` = 3
- `_04` = 4
- `_05` = 5
- `_06` = 6
- `_07` = 7

### KodPodstawyPrawnejZwolnienia (`Soneta.Kadry.KodPodstawyPrawnejZwolnienia`)
- `NieDotyczy` = 0
- `_400` = 400 — 400 - art. 23¹ § 4 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy
- `_401` = 401 — 401 - art. 23¹ § 5 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy
- `_402` = 402 — 402 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy
- `_403` = 403 — 403 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_404` = 404 — 404 - art. 30 § 1 pkt 3 w związku z art. 52 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_405` = 405 — 405 - art. 30 § 1 pkt 3 w związku z art. 52 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_406` = 406 — 406 - art. 30 § 1 pkt 3 w związku z art. 52 § 1 pkt 3 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_407` = 407 — 407 - art. 30 § 1 pkt 4 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_408` = 408 — 408 - art. 30 § 1 pkt 5 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w brzmieniu obowiązującym do dnia 21 lutego 2016 r.
- `_409` = 409 — 409 - art. 36¹ § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_410` = 410 — 410 - art. 48 § 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_411` = 411 — 411 - art. 30 § 1 pkt 3 w związku z art. 53 § 1 pkt 1 lit. a ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_412` = 412 — 412 - art. 30 § 1 pkt 3 w związku z art. 53 § 1 pkt 1 lit. b ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_413` = 413 — 413 - art. 30 § 1 pkt 3 w związku z art. 53 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_414` = 414 — 414 - art. 30 § 1 pkt 3 w związku z art. 55 § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_415` = 415 — 415 - art. 30 § 1 pkt 3 w związku z art. 55 § 1¹ ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_416` = 416 — 416 - art. 68³ ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_417` = 417 — 417 - art. 70 § 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_418` = 418 — 418 - art. 70 § 3 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_419` = 419 — 419 - art. 73 § 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_420` = 420 — 420 - art. 201 § 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_421` = 421 — 421 - art. 30 § 1 pkt 2 w związku z art. 1 ust. 1 ustawy z dnia 13 marca 2003 r. o szczególnych zasadach rozwiązywania z pracownikami stosunków pracy z przyczyn niedotyczących pracowników
- `_422` = 422 — 422 - art. 30 § 1 pkt 2 w związku z art. 10 ust. 1 ustawy z dnia 13 marca 2003 r. o szczególnych zasadach rozwiązywania z pracownikami stosunków pracy z przyczyn niedotyczących pracowników
- `_423` = 423 — 423 - art. 74 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_424` = 424 — 424 - art. 63¹ § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_425` = 425 — 425 - art. 63² § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_426` = 426 — 426 - art.66 § 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy
- `_427` = 427 — 427 - art. 63 ustawy z dnia 26 czerwca 1974 r. – Kodeks pracy w związku z art. 189 ust. 2 ustawy z dnia 11 marca 2022 r. o obronie Ojczyzny
- `_428` = 428 — 428 - art. 63 ustawy z dnia 26 czerwca 1974 r. – Kodeks pracy w związku z art. 315 ust. 1 ustawy z dnia 11 marca 2022 r. o obronie Ojczyzny
- `_429` = 429 — 429 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy w związku z art. 2 pkt 38 lit. a ustawy z dnia 20 marca 2025 r. o rynku pracy i służbach zatrudnienia
- `_430` = 430 — 430 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy w związku z art. 2 pkt 38 lit. a ustawy z dnia 20 marca 2025 r. o rynku pracy i służbach zatrudnienia
- `_431` = 431 — 431 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy w związku z art. 2 pkt 38 lit. b ustawy z dnia 20 marca 2025 r. o rynku pracy i służbach zatrudnienia
- `_432` = 432 — 432 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r. - Kodeks pracy w związku z art. 2 pkt 38 lit. b ustawy z dnia 20 marca 2025 r. o rynku pracy i służbach zatrudnienia
- `_433` = 433 — 433 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 3 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_434` = 434 — 434 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 3 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_435` = 435 — 435 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 4 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_436` = 436 — 436 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 4 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_437` = 437 — 437 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 5 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_438` = 438 — 438 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 5 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_439` = 439 — 439 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 6 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_440` = 440 — 440 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 6 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_441` = 441 — 441 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 8 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_442` = 442 — 442 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 8 ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_443` = 443 — 443 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 8a ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_444` = 444 — 444 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 8a ustawy z dnia 13 lipca 2006 r. o ochronie roszczeń pracowniczych w razie niewypłacalności pracodawcy
- `_445` = 445 — 445 - art. 27 ust. 1 pkt 2 ustawy z dnia 27 lipca 2001 r. o kuratorach sądowych
- `_446` = 446 — 446 - art. 62 ust. 1 pkt 2 ustawy z dnia 13 kwietnia 2007 r. o Państwowej Inspekcji Pracy
- `_447` = 447 — 447 - art.71 ust. 1 pkt 4 ustawy z dnia 21 listopada 2008 r. o służbie cywilnej
- `_448` = 448 — 448 - art. 13 ust. 1 pkt 2 ustawy z dnia 16 września 1982 r. o pracownikach urzędów państwowych
- `_449` = 449 — 449 - art. 170 ust. 1 pkt 1 ustawy z dnia 16 listopada 2016 r. Przepisy wprowadzające ustawę o Krajowej Administracji Skarbowej
- `_450` = 450 — 450 - art. 97 ust. 3 ustawy z dnia 16 grudnia 2016 r. Przepisy wprowadzające ustawę o zasadach zarządzania mieniem państwowym
- `_451` = 451 — 451 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 20 ust. 1 pkt 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_452` = 452 — 452 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 20 ust. 1 pkt 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_453` = 453 — 453 - art. 30 § 1 pkt 1 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 20 ust. 1 pkt 2 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_454` = 454 — 454 - art. 30 § 1 pkt 2 ustawy z dnia 26 czerwca 1974 r.- Kodeks pracy w związku z art. 20 ust. 1 pkt 2 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_455` = 455 — 455 - art. 20 ust. 5c ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_456` = 456 — 456 - art. 20 ust. 6 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_457` = 457 — 457 - art. 20 ust. 7 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_458` = 458 — 458 - art. 23 ust. 1 pkt 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_459` = 459 — 459 - art. 23 ust. 4 pkt 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_460` = 460 — 460 - art. 27 ust. 1 ustawy z dnia 26 stycznia 1982 r. - Karta Nauczyciela
- `_461` = 461 — 461 - art. 225 ust. 1, 6 i 10 ustawy z dnia 14 grudnia 2016 r. - Przepisy wprowadzające ustawę - Prawo oświatowe
- `_462` = 462 — 462 - art. 225 ust. 7 pkt 1 ustawy z dnia 14 grudnia 2016 r. - Przepisy wprowadzające ustawę - Prawo oświatowe
- `_463` = 463 — 463 - art. 226 ust. 1 ustawy z dnia 14 grudnia 2016 r. - Przepisy wprowadzające ustawę - Prawo oświatowe
- `_550` = 550 — 550 – inna niż określona w kodach od 400 do 463 - podstawa prawna rozwiązania lub wygaśnięcia stosunku pracy lub stosunku służbowego

### KodPrawaEmRent (`Soneta.Kadry.KodPrawaEmRent`)
- `Brak` = 0 — Brak
- `PrawoDoEmerytury` = 1
- `PrawoDoRenty` = 2

### KodPrzekrPodstSkladek (`Soneta.Kadry.KodPrzekrPodstSkladek`)
- `Brak` = 0
- `Ubezpieczony` = 1
- `Platnik` = 2 — Płatnik
- `ZUS` = 3

### KodStNiepelnosprawnosci (`Soneta.Kadry.KodStNiepelnosprawnosci`)
- `Brak` = 0
- `Lekki` = 1
- `Umiarkowany` = 2
- `Znaczny` = 3
- `OsobaDo16Roku` = 4 — Osoba niepełnosprawna do 16 roku życia

### KodStNiezdolnDoPracy (`Soneta.Kadry.KodStNiezdolnDoPracy`)
- `Brak` = 1
- `Czesciowo` = 11 — Częściowo
- `CzesciowoCzasOkresl` = 12 — Częściowo/czas określony
- `Calkowicie` = 13 — Całkowicie
- `CalkowicieCzasOkresl` = 14 — Całkowicie/czas określony
- `CalkowicieEgzyst` = 15 — Niez.do sam.egzystencji
- `CalkowicieEgzystCzasOkresl` = 16 — Niez.do sam.egzystencji/czas określ.
- `Przekwalifikowanie` = 20
- `GrupaInw3` = 31 — III gr.inwalidzka
- `GrupaInw3CzasOkresl` = 32 — III gr.inwalidzka/czas określony
- `GrupaInw2` = 33 — II gr.inwalidzka
- `GrupaInw2CzasOkresl` = 34 — II gr.inwalidzka/czas określony
- `GrupaInw1` = 35 — I gr.inwalidzka
- `GrupaInw1CzasOkresl` = 36 — I gr.inwalidzka/czas określony
- `NiezdRolnaZasilek` = 40 — Niez.do pracy na roli/zasiłek
- `NiezdRolnaBzezZas` = 41 — Niez.do pracy na roli/bez zasiłku

### KodStPokrewienstwa (`Soneta.Kadry.KodStPokrewienstwa`)
- `Brak` = 0
- `Malzonek` = 1 — Małżonek
- `Dziecko` = 11
- `Wnuk` = 21
- `Matka` = 30
- `Ojciec` = 31
- `Macocha` = 32
- `Ojczym` = 33
- `Babka` = 40
- `Dziadek` = 41
- `OsobaPrzyspasabiajaca` = 50 — Osoba przysposabiająca
- `InniKrewni` = 60

### KodWykształceniaGUS (`Soneta.Kadry.KodWykształceniaGUS`)
- `Nieokreślone` = 0
- `Wyższe` = 1 — Wyższe z tytułem magistra, lekarza lub równorzędnym
- `WyższeZawodowe` = 2 — Wyższe z tytułem inżyniera, licencjata, dyplomowanego ekonomisty lub równorzędnym
- `Policealne` = 3
- `ŚrednieZawodowe` = 4
- `ŚrednieOgólnokształcące` = 5
- `ZasadniczeZawodowe` = 6
- `Gimnazjalne` = 7
- `PodstawoweINiepełnePodstawowe` = 8
- `WyższeZeStopiemNaukowym` = 9 — Wyższe ze stopniem naukowym co najmniej doktora

### KodZwolnienia (`Soneta.Kadry.KodZwolnienia`)
- `NieDotyczy` = 0
- `_20R` = 20 — 20R - bez wypowiedzenia, przez pracownika w związku przejściem zakładu pracy lub jego części na innego pracodawcę
- `_21R` = 21 — 21R - w wyniku nieuzgodnienia nowych warunków pracy i płacy, zaproponowanych przez pracodawcę z dniem przejęcia zakładu pracy lub jego części
- `_22R` = 22 — 22R - na mocy porozumienia stron
- `_23R` = 23 — 23R - wypowiedzenie przez pracodawcę
- `_24R` = 24 — 24R - wypowiedzenie przez pracownika
- `_25R` = 25 — 25R - bez wypowiedzenia przez pracodawcę, naruszenie obowiązków pracowniczych
- `_26R` = 26 — 26R - bez wypowiedzenia przez pracodawcę, popełnienie przestępstwa
- `_27R` = 27 — 27R - bez wypowiedzenia przez pracodawcę, utrata koniecznych uprawnień
- `_28R` = 28 — 28R - z upływem czasu, na który była zawarta umowa o pracę
- `_29R` = 29 — 29R - z dniem ukończenia pracy, dla której wykonania była zawarta umowa
- `_30R` = 30 — 30R - ze skróconym okresem wypowiedzenia, z przyczyn niedotyczących pracowników
- `_31R` = 31 — 31R - przywrócenie do pracy i zatrudnienie u innego pracodawcy
- `_32R` = 32 — 32R - bez wypowiedzenia przez pracodawcę, niezdolność do pracy dłuższa niż 3 mies.
- `_33R` = 33 — 33R - bez wypowiedzenia przez pracodawcę, wyczerpanie okresu zasiłkowego, pobierania świadczenia rehabilitacyjnego
- `_34R` = 34 — 34R - bez wypowiedzenia przez pracodawcę, usprawiedliwiona nieobecność dłuższa niż 1 mies.
- `_35R` = 35 — 35R - bez wypowiedzenia przez pracownika, orzeczenie o szkodliwym wpływie wykonywanej pracy na zdrowie
- `_36R` = 36 — 36R - bez wypowiedzenia przez pracownika, naruszenie obowiązków przez pracodawcę
- `_37R` = 37 — 37R - w przypadkach określonych w przepisach szczególnych, innych niż określone w części XVI
- `_38R` = 38 — 38R - powołanie u innego pracodawcy
- `_39R` = 39 — 39R - odwołanie
- `_40R` = 40 — 40R - odwołanie bez wypowiedzenia
- `_41R` = 41 — 41R - wygaśnięcie mandatu
- `_42R` = 42 — 42R - pracownikiem młodocianym w związku z orzeczeniem lekarskim o pracy zagrażającej zdrowiu
- `_43R` = 43 — 43R - z przyczyn niedotyczących pracownika, grupowe zwolnienie- porozumienie stron
- `_44R` = 44 — 44R - z przyczyn niedotyczących pracownika, grupowe zwolnienie - wypowiedzenie
- `_45R` = 45 — 45R - z przyczyn niedotyczących pracownika, indywidualne zwolnienie - wypowiedzenie
- `_46R` = 46 — 46R - z przyczyn niedotyczących pracownika, indywidualne zwolnienie – porozumienie stron
- `_47W` = 47 — 47W - brak powrotu do pracy po zakończeniu stosunku pracy z wyboru
- `_48W` = 48 — 48W - śmierć pracownika
- `_49W` = 49 — 49W - śmierć pracodawcy
- `_50W` = 50 — 50W - tymczasowe aresztowanie
- `_51W` = 51 — 51W - powołanie do zawodowej służby wojskowej
- `_52W` = 52 — 52W - brak powrotu do pracy po zwolnieniu z czynnej służby wojskowej
- `_53W` = 53 — 53W - w przypadkach określonych w przepisach szczególnych, innych niż określone w części XVI

### ModelPracy (`Soneta.Kadry.ModelPracy`)
- `NieDotyczy` = 0 — Nie dotyczy
- `PracaStacjonarna` = 1
- `PracaHybrydowa` = 2
- `PracaZdalna` = 3

### NaliczajPit26 (`Soneta.Kadry.NaliczajPit26`)
- `Warunkowo2020` = 0 — Warunkowo od 1 stycznia 2020
- `Warunkowo2019` = 1 — Warunkowo od 1 sierpnia 2019
- `NieNaliczaj` = 2

### NaliczanieOdpisuOPP (`Soneta.Kadry.NaliczanieOdpisuOPP`)
- `Narastająco` = 0 — Narastająco
- `PierwszaWypłata` = 1
- `KażdaWypłata` = 2

### OgraniczeniePrzerwyCovid (`Soneta.Kadry.OgraniczeniePrzerwyCovid`)
- `Domyślnie` = 0
- `Tak` = 1

### OkresPróbnyPodlegaPrzedłużeniu (`Soneta.Kadry.OkresPróbnyPodlegaPrzedłużeniu`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Podlega` = 1 — Podlega

### OkresZasilkowy (`Soneta.Kadry.OkresZasilkowy`)
- `Standardowy_6_9` = 0 — Standardowy (6/9 mies)
- `Przedłużony_12` = 1 — Przedłużony (12 mies)

### OrzeczenieStopienNiepelnosp (`Soneta.Kadry.OrzeczenieStopienNiepelnosp`)
- `NieDotyczy` = 0
- `PFRON` = 1
- `ZUS` = 2
- `PowiatowyZespolDoSprawOrzekaniaONiepelnosprawnosci` = 3 — Powiatowy Zespół do Spraw Orzekania o Niepełnosprawności
- `MiejsckiZespolDoSprawOrzekaniaONiepelnosprawnosci` = 4 — Miejski Zespół do Spraw Orzekania o Niepełnosprawności
- `WojewodzkiZespolDoSprawOrzekaniaONiepelnosprawnosci` = 5 — Wojewódzki Zespół do Spraw Orzekania o Niepełnosprawności

### PopMiejsceZatrudnienia (`Soneta.Kadry.PopMiejsceZatrudnienia`)
- `NieDotyczy` = 0
- `AbsolwentSzkołyWyższej` = 1
- `AbsolwentSzkołyPolicealnej` = 2
- `AbsolwentLiceumOgólnokształcącego` = 3
- `AbsolwentSzkołyŚredniejZawodowej` = 4
- `AbsolwentSzkołyZasadniczej` = 5
- `AbsolwentGimnazjum` = 6
- `ZatrudnionyPoRazPierwszy` = 7
- `ZatrudnionyWSektorzePublicznym` = 8
- `ZatrudnionyWSektorzePrywatnym` = 9
- `ZatrudnionyWRolnictwieIndywidualnym` = 10
- `BezrobotnyZarejestrowanyWUrzędziePracy` = 11
- `BezrobotnyZPrawemDoZasiłku` = 12
- `UczniowiePracownicyMłodociani` = 13 — Uczniowie, pracownicy młodociani

### UbezpieczenieZleceniobiorcy (`Soneta.Kadry.PracHistoria.UbezpieczenieZleceniobiorcy`)
- `NiePodlega` = 0 — Nie podlega
- `Podlega` = 1
- `DobrowolneChorobowe` = 2
- `TylkoZdrowotne` = 3

### PrzyczynaWyrejestrowania (`Soneta.Kadry.PrzyczynaWyrejestrowania`)
- `NieDotyczy` = 0
- `_100` = 100 — 100 - ustanie tytułu do ubezpieczeń/ubezpieczenia
- `_101` = 101 — 101 – rozwiązanie lub zakończenie umowy o pracy w celu przygotowania zawodowego
- `_102` = 102 — 102 – rozwiązanie lub zakończenie pracy osoby przyuczanej do wykonywania określonej pracy
- `_110` = 110 — 110 - rozwiązanie lub wygaśnięcie umowy o pracę nakładczą
- `_120` = 120 — 120 - rozwiązanie lub wygaśnięcie umowy agencyjnej lub umowy zlecenia
- `_121` = 121 — 121 - zakończenie współpracy przy wykonywaniu umowy agencyjnej lub umowy zlecenia
- `_130` = 130 — 130 - wygaśnięcie obowiązku wykonywania pracy na rzecz rolniczej spółdzielni produkcyjnej
- `_131` = 131 — 131 - wygaśnięcie obowiązku wykonywania pracy na rzecz spółdzielni kółek rolniczych
- `_140` = 140 — 140 - zaprzestanie prowadzenia pozarolniczej działalności gospodarczej
- `_141` = 141 — 141 - zaprzestanie wykonywania działalności twórczej lub artystycznej
- `_142` = 142 — 142 - zaprzestanie wykonywania wolnego zawodu
- `_143` = 143 — 143 - zakończenie współpracy przy prowadzeniu pozarolniczej działalności gospodarczej
- `_144` = 144 — 144 - zakończenie współpracy przy wykonywaniu działalności twórczej lub artystycznej
- `_145` = 145 — 145 - zakończenie współpracy przy wykonywaniu wolnego zawodu
- `_150` = 150 — 150 - utrata prawa do uposażenia poselskiego lub senatorskiego
- `_160` = 160 — 160 - zaprzestanie spełniania warunków do pobierania stypendium sportowego
- `_170` = 170 — 170 - zakończenie wykonywania odpłatnej pracy w czasie odbywania kary pozbawienia wolności lub tymczasowego aresztowania
- `_180` = 180 — 180 - utrata prawa do zasiłku dla bezrobotnych
- `_181` = 181 — 181 - utrata prawa do stypendium z tytułu skierowania przez powiatowy urząd pracy na szkolenie lub odbycie stażu
- `_182` = 182 — 182 - utrata prawa do pobierania zasiłku lub świadczenia przedemerytalnego z powiatowego urzędu pracy
- `_190` = 190 — 190 - wystąpienie ze stanu duchownego
- `_200` = 200 — 200 - zakończenie odbywania służby czynnej przez żołnierz niezawodowych
- `_201` = 201 — 201 - zakończenie odbywania zastępczej formy służby wojskowej
- `_202` = 202 — 202 - zakończenie odbywania nadterminowej zasadniczej służby wojskowej
- `_203` = 203 — 203 - zakończenie odbywania okresowej zasadniczej służby wojskowej
- `_210` = 210 — 210 - zakończenie służby żołnierza zawodowego
- `_220` = 220 — 220 - zakończenie służby funkcjonariusza Policji
- `_221` = 221 — 221 - zakończenie służby funkcjonariusza UOP
- `_222` = 222 — 222 - zakończenie służby funkcjonariusza Straży Granicznej
- `_223` = 223 — 223 - zakończenie służby funkcjonariusza Państwowej Straży Pożarnej
- `_224` = 224 — 224 - zakończenie służby funkcjonariusza Służby Więziennej
- `_230` = 230 — 230 - zaprzestanie spełniania warunków do objęcia ubezpieczeniem obowiązkowym osób przebywających na urlopie wychowawczym
- `_231` = 231 — 231 - zaprzestanie spełniania warunków do objęcia ubezpieczeniem obowiązkowym osób przebywających na zasiłku macierzyńskim
- `_240` = 240 — 240 - utrata prawa do pobierania świadczenia socjalnego na podstawie odrębnych przepisów lub układów zbiorowych pracy
- `_241` = 241 — 241 - utrata prawa do pobierania zasiłku socjalnego na czas przekwalifikowania zawodowego i poszukiwania nowego zatrudnienia na podstawie odrębnych przepisów lub układów zbiorowych pracy
- `_250` = 250 — 250 – wydanie decyzji o zaprzestaniu opłacania składki za osobę pobierającą zasiłek stały z pomocy społecznej
- `_251` = 251 — 251 - wydanie decyzji o zaprzestaniu opłacania składki za osobę pobierającą gwarantowany zasiłek okresowy z pomocy społecznej
- `_252` = 252 — 252 - utrata prawa do pobierania renty socjalnej z pomocy społecznej
- `_253` = 253 — 253 - utrata prawa do pobierania zasiłku stałego wyrównawczego z pomocy społecznej
- `_300` = 300 — 300 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków do tych ubezpieczeń z tytułu bycia małżonkiem pracownika skierowanego do pracy w przedstawicielstwie dyplomatycznym,
- `_301` = 301 — 301 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków do tych ubezpieczeń z tytułu bycia osobą, która z powodu stanu zdrowia członka rodziny wymagającego stałej opieki oraz pielęgnacji lub pomocy w czynnościach samoobsługowych nie podlega ubezpieczeniom społecznym z innych tytułów
- `_310` = 310 — 310 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków do tych ubezpieczeń przez obywatela polskiego wykonującego pracę u podmiotu zagranicznego
- `_311` = 311 — 311 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków do tych ubezpieczeń przez obywatela polskiego z tytułu wykonywania pracy u podmiotu zagranicznego na terytorium RP, jeżeli podmioty te nie posiadają w Polsce swojej siedziby ani przedstawicielstwa
- `_320` = 320 — 320 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków z tytułu bycia studentem lub uczestnikiem dziennych studiów doktoranckich
- `_321` = 321 — 321 - rezygnacja z dobrowolnych ubezpieczeń społecznych lub zaprzestanie spełniania warunków z tytułu bycia uczestnikiem innych niż dzienne studia doktoranckie
- `_322` = 322 — 322 - rezygnacja z ubezpieczeń społecznych lub zaprzestanie spełniania warunków z tytułu bycia słuchaczem Krajowej Szkoły Administracji Publicznej
- `_330` = 330 — 330 - rezygnacja z kontynuowania ubezpieczeń społecznych
- `_340` = 340 — 340 - utrata prawa do wykonywania zawodu sędziego
- `_341` = 341 — 341 - utrata prawa do wykonywania zawodu prokuratora
- `_342` = 342 — 342 - utrata prawa do wykonywania zawodu adwokata
- `_350` = 350 — 350 - utrata prawa do ubezpieczenia zdrowotnego z tytułu pozostawania na wyłącznym utrzymaniu ubezpieczonego
- `_351` = 351 — 351 - utrata prawa do ubezpieczenia zdrowotnego dziecka, ucznia, słuchacza zakładów lub nauczycieli, którzy nie pozostają na wyłącznym utrzymaniu ubezpieczonego
- `_360` = 360 — 360 - utrata prawa do ubezpieczenia zdrowotnego z tytułu bycia kombatantem nie podlegającym ubezpieczeniom społecznym w RP lub nie pobierającym emerytury bądź renty
- `_370` = 370 — 370 - ustanie prawa do ubezpieczenia zdrowotnego cudzoziemca, który przebywa na terytorium RP na podstawie karty stałego pobytu
- `_371` = 371 — 371 - ustanie prawa do ubezpieczenia zdrowotnego cudzoziemca, który przebywa na terytorium RP na podstawie karty czasowego pobytu wydanej w związku z udzieleniem statusu uchodźcy
- `_372` = 372 — 372 - ustanie prawa do ubezpieczenia zdrowotnego cudzoziemca, który jest zatrudniony w obcych przedstawicielstwach dyplomatycznych, urzędach konsularnych, misjach lub międzynarodowych instytucjach
- `_373` = 373 — 373 - ustanie prawa do ubezpieczenia zdrowotnego cudzoziemca, który przebywa w RP na podstawie innych umów międzynarodowych
- `_400` = 400 — 400 - rezygnacja z dobrowolnego ubezpieczenia zdrowotnego osoby nie objętej obowiązkowym ubezpieczeniem zdrowotnym
- `_500` = 500 — 500 - zgon osoby ubezpieczonej
- `_600` = 600 — 600 - inne przyczyny wyrejestrowania z ubezpieczeń
- `_601` = 601 — 601 – nabycie prawa do emerytury lub renty
- `_602` = 602 — 602 – powstanie zbiegu ubezpieczeń społecznych powodującego możliwość wyrejestrowania z tytułu dotychczasowego ubezpieczenia
- `_603` = 603 — 603 – porzucenie pracy lub zerwanie umowy, z tytułu której osoba podlegała ubezpieczeniom
- `_700` = 700 — 700 - zawieszenie wykonywania pozarolniczej działalności gospodarczej na podstawie przepisów o swobodzie działalności gospodarczej
- `_750` = 750 — 750 - zawieszenie statusu marynarza
- `_800` = 800 — 800 – wyrejestrowanie pracownika w związku z przejściem zakładu pracy lub jego części na innego pracodawcę w trybie art. 231 ustawy z dnia 26 czerwca 1974 r. – Kodeks pracy (Dz. U. z 2016 r. poz. 1666, 2138 i 2255 oraz z 2017 r. poz. 60)

### PłećOsoby (`Soneta.Kadry.PłećOsoby`)
- `Kobieta` = 0
- `Mężczyzna` = 1

### RodzajKosztowUzyskania (`Soneta.Kadry.RodzajKosztowUzyskania`)
- `JedenStosPracy` = 0 — Jednego stosunku pracy
- `JedenStos25` = 1 — Jednego stosunku pracy podwyższone o 25%
- `WiecejStosPracy` = 2 — Z więcej niż jednego stosunku pracy
- `WiecejStos25` = 3 — Z więcej niż jednego stosunku pracy podwyższone o 25%

### RodzajLimituOp188 (`Soneta.Kadry.RodzajLimituOp188`)
- `NieDotyczy` = 0 — Nie dotyczy
- `NaDni` = 1
- `NaGodziny` = 2

### RodzajStawkiZaszeregowania (`Soneta.Kadry.RodzajStawkiZaszeregowania`)
- `Godzinowa` = 0 — Za godzinę
- `Miesieczna` = 1 — Miesięcznie
- `DochodDeklarowany` = 2 — Dochód deklarowany

### RodzajWznowieniaPPK (`Soneta.Kadry.RodzajWznowieniaPPK`)
- `NieDotyczy` = 0
- `NaWniosek` = 1
- `Automatycznie` = 2

### RodzajZatrudnienia (`Soneta.Kadry.RodzajZatrudnienia`)
- `NieDotyczy` = 0
- `Uczeń1Klasy` = 1 — Uczeń I klasy
- `Uczeń2Klasy` = 2 — Uczeń II klasy
- `Uczeń3Klasy` = 3 — Uczeń III klasy
- `MłodocianyPrzyuczany` = 4
- `PracownikZaGranicą` = 5
- `CzłonekRSP` = 6 — Członek RSP
- `CzłonekSKR` = 7 — Członek SKR
- `Chałupnik` = 8
- `Student` = 9
- `Absolwent` = 10
- `Właściciel` = 11
- `OsobaWspółpracująca` = 12
- `PracownikTymczasowy` = 13
- `PracownikTymczasowyZaGranicą` = 14
- `StanSpoczynku` = 15
- `UposażenieRodzinne` = 16
- `WięzieńLubAresztowany` = 17

### RodzajZatrudnieniaGUS (`Soneta.Kadry.RodzajZatrudnieniaGUS`)
- `Pozostali` = 0 — Pozostali 
- `OsobyZajmująceWyższeStanowiskaWSłużbieCywilnej` = 1
- `PozostaliCzłonkowieKorpusuSłużbyCywilnej` = 2
- `ŻołnierzeIFunkcjonariusze` = 3

### RodzajZgloszeniaPPK (`Soneta.Kadry.RodzajZgloszeniaPPK`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Obowiązkowe` = 1 — Obowiązkowe
- `Dobrowolne` = 2 — Dobrowolne

### RodzajeFormyOpodatkowania (`Soneta.Kadry.RodzajeFormyOpodatkowania`)
- `Brak` = 0
- `ZasadyOgólnePodatekWedługSkali` = 1 — Zasady ogólne - podatek według skali
- `ZasadyOgólnePodatekLiniowy` = 2 — Zasady ogólne - podatek liniowy
- `KartaPodatkowa` = 3 — Karta podatkowa
- `RyczałtOdPrzychodówEwidencjonowanych` = 4 — Ryczałt od przychodów ewidencjonowanych

### RodzajeObnizeniaPodstawZUS (`Soneta.Kadry.RodzajeObnizeniaPodstawZUS`)
- `Brak` = 0
- `SkładkiObniżone` = 1 — Składki obniżone (24 mies.)
- `SkładkiZawieszone` = 2 — Składki zawieszone (6 mies.)

### RodzajePrzejęciaPrzedsiębiorstwa (`Soneta.Kadry.RodzajePrzejęciaPrzedsiębiorstwa`)
- `NieDotyczy` = 0 — Nie dotyczy
- `PrzejęcieZakładuPracy` = 1
- `PrzejęcieCzęściZakładuPracy` = 2

### RodzajeSkładekPPK (`Soneta.Kadry.RodzajeSkładekPPK`)
- `Domyślne` = 0
- `PracownikaZaOkresZawieszenia` = 1

### StNiepełnosprawności (`Soneta.Kadry.StNiepełnosprawności`)
- `Brak` = 0
- `Lekki` = 1
- `Umiarkowany` = 2
- `Znaczny` = 3

### StosPracyNaPodstawie (`Soneta.Kadry.StosPracyNaPodstawie`)
- `Brak` = 0
- `UmowyOPrace` = 1 — Umowy o pracę
- `Powołania` = 2
- `Wyboru` = 3
- `Mianowania` = 4
- `SpoldzielczejUmowyOPrace` = 5 — Spółdzielczej umowy o pracę
- `UmowyOPracęNakładczą` = 6
- `Oddelegowania` = 7
- `StanSpoczynku` = 8
- `UposażenieRodzinne` = 9
- `SkierowaniaDoPracy` = 10

### SymbolSystemuCzasuPracy (`Soneta.Kadry.SymbolSystemuCzasuPracy`)
- `Podstawowy` = 10 — 10 – podstawowy
- `Rownowazny12` = 21 — 21 – równoważny – wersja podstawowa (w wymiarze do 12 godz.)
- `Rownowazny16` = 22 — 22 – równoważny – wersja szczególna (w wymiarze do 16 godz.)
- `Rownowazny24` = 23 — 23 – równoważny – wersja szczególna (w wymiarze do 24 godz.)
- `Przerywany` = 30 — 30 – przerywany
- `Zadaniowy` = 40 — 40 – zadaniowy
- `SkroconyTydzien` = 50 — 50 – praca w skróconym tygodniu pracy
- `RuchCiagly` = 60 — 60 – praca w ruchu ciągłym

### SystemCzasuPracy (`Soneta.Kadry.SystemCzasuPracy`)
- `NieDotyczy` = 0 — Nie dotyczy
- `Zmianowy` = 1
- `Równoważny` = 2
- `Mieszany` = 3

### TypNaliczaniaFGŚP (`Soneta.Kadry.TypNaliczaniaFGŚP`)
- `NieNaliczaj` = 0
- `Zawsze` = 2

### TypNaliczaniaFP (`Soneta.Kadry.TypNaliczaniaFP`)
- `NieNaliczaj` = 0
- `Warunkowo` = 1
- `Zawsze` = 2

### TypProgowPodatkowych (`Soneta.Kadry.TypProgowPodatkowych`)
- `Standardowe` = 0
- `WspolneOpodatkowanie` = 1 — Wspólne opodatkowanie (Ulga x2)
- `Indywidualne` = 2
- `Liniowy` = 3
- `WspolneOpodatkowaniePojedyncze` = 4 — Wspólne opodatkowanie (Ulga x1)

### TypPrzekrPodstSkladek (`Soneta.Kadry.TypPrzekrPodstSkladek`)
- `PodstawaSkladki` = 0 — Podstawa składki
- `PrzekroczeniePodstawy` = 1

### TypStawkiZaszeregowania (`Soneta.Kadry.TypStawkiZaszeregowania`)
- `Dowolna` = 0 — Dowolna
- `Minimalna` = 1
- `ZZakresu` = 2
- `WgWskaźnika` = 3
- `Nieokreślona` = 10

### TypUbezpieczenia (`Soneta.Kadry.TypUbezpieczenia`)
- `Brak` = 0
- `Obowiazkowe` = 1
- `Dobrowolne` = 2

### TypUmowyOPrace (`Soneta.Kadry.TypUmowyOPrace`)
- `Brak` = 0 — Nie dotyczy
- `NaCzasNieokreślony` = 1
- `NaOkresPróbny` = 2
- `NaCzasOkreślony` = 3
- `NaCzasWykonywniaPracy` = 4 — Na czas wykonywania pracy
- `NaOkresZastępstwa` = 5 — Na czas określony (zastępstwo)
- `NaOkresTrwaniaMandatu` = 6
- `NaCzasPełnieniaFunkcji` = 7
- `DoDniaPorodu` = 8 — Na czas określony (do dnia porodu)
- `NaCzasOkreślonyDorywczySezonowy` = 9 — Na czas określony (dorywczy, sezonowy)
- `NaOkresPróbnyDoDniaPorodu` = 10 — Na okres próbny (do dnia porodu)

### UlgaPodatkowaCzesc (`Soneta.Kadry.UlgaPodatkowaCzesc`)
- `Ulga112` = 0 — 1/12 kwoty zmniejszającej podatek
- `Ulga124` = 1 — 1/24 kwoty zmniejszającej podatek
- `Ulga136` = 2 — 1/36 kwoty zmniejszającej podatek

### TypLimituPracyZdalnej (`Soneta.Kalend.TypLimituPracyZdalnej`)
- `Roczny` = 0
- `Miesieczny` = 1 — Miesięczny
- `Tygodniowy` = 2
- `Kwartalny` = 3
- `Półroczny` = 4
