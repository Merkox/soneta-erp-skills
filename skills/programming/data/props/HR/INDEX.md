# Moduł `HR` — tabele biznesowe

- Opis: Moduł zarządzania zasobami ludzkimi (HR). Zawiera strukturę organizacyjną, stanowiska, kompetencje, oceny pracownicze, szkolenia, rekrutację oraz planowanie kariery.
- Tabel: **114**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| AspektKompetencjiMerytorycznej | Aspekty kompetencji merytorycznych | `ZklAspKmpMery` | konfig | root |  |  |  | [AspektKompetencjiMerytorycznej.md](AspektKompetencjiMerytorycznej.md) |
| AspektKompetencjiUniwersalnej | Aspekty kompetencji uniwersalnych | `ZklAspKmpUniw` | konfig | root |  |  |  | [AspektKompetencjiUniwersalnej.md](AspektKompetencjiUniwersalnej.md) |
| AspektPoziomKompetencjiMerytorycznej |  | `ZklAspPozMery` | konfig |  |  |  |  | [AspektPoziomKompetencjiMerytorycznej.md](AspektPoziomKompetencjiMerytorycznej.md) |
| AspektPoziomKompetencjiUniwersalnej |  | `ZklAspPozUniw` | konfig |  |  |  |  | [AspektPoziomKompetencjiUniwersalnej.md](AspektPoziomKompetencjiUniwersalnej.md) |
| BadaniaLekarskieDefinicjiStanowiska | Badania lekarskie defincji stanowisk | `BadLekDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  |  | [BadaniaLekarskieDefinicjiStanowiska.md](BadaniaLekarskieDefinicjiStanowiska.md) |
| Benefit | Benefity | `ZklBenefity` | konfig | root |  | IZklPozycjaSlownika |  | [Benefit.md](Benefit.md) |
| BudżetSzkoleń | Budżety szkoleń | `BudzetySzkolen` |  | root |  |  |  | [BudżetSzkoleń.md](BudżetSzkoleń.md) |
| CzynnikSzkodliwyDefinicjiStanowiska | Czynniki szkodliwe defincji stanowisk | `CzynSzkodDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  |  | [CzynnikSzkodliwyDefinicjiStanowiska.md](CzynnikSzkodliwyDefinicjiStanowiska.md) |
| CzynnoscZadania | Czynności zadań | `ZklCzynnZadan` | konfig | root |  |  |  | [CzynnoscZadania.md](CzynnoscZadania.md) |
| DefElementuOcenyPracownika | Definicje kryteriów ocen | `DefElemOcenPrac` | konfig | root |  |  |  | [DefElementuOcenyPracownika.md](DefElementuOcenyPracownika.md) |
| DefinicjaEtapuRekrutacji | Etapy rekrutacji | `DefEtaRekrutacji` | konfig | root |  |  |  | [DefinicjaEtapuRekrutacji.md](DefinicjaEtapuRekrutacji.md) |
| DefinicjaFunkcji | Definicje funkcji | `DefinicjeFunkcji` | konfig | root |  |  |  | [DefinicjaFunkcji.md](DefinicjaFunkcji.md) |
| DefinicjaPlanowaniaZasobow | Definicje planowania zasobów | `DefPlanZasob` | konfig | root |  |  |  | [DefinicjaPlanowaniaZasobow.md](DefinicjaPlanowaniaZasobow.md) |
| DefinicjaStanowiska | Definicje stanowisk | `DefStanowisk` | konfig | root | historyczna → DefinicjaStanowiskaHist | IŹródłoKartyOpisuStanowiska |  | [DefinicjaStanowiska.md](DefinicjaStanowiska.md) |
| DefinicjaStanowiskaHist | Definicje stanowisk historia | `DefStanowiskHist` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska | historia → DefinicjaStanowiska |  |  | [DefinicjaStanowiskaHist.md](DefinicjaStanowiskaHist.md) |
| DefinicjaStanowiskaHistZkl | Dane ZKL historii definicji stanowisk | `ZklDefStanHist` | konfig | child: DefinicjaStanowiskaHist→DefinicjaStanowiskaHist |  |  |  | [DefinicjaStanowiskaHistZkl.md](DefinicjaStanowiskaHistZkl.md) |
| DefinicjaSzkolenia | Definicje szkoleń | `DefinicjeSzkolen` |  | root |  | IZklPozycjaSlownika, IPozycjaKonfiguratora |  | [DefinicjaSzkolenia.md](DefinicjaSzkolenia.md) |
| DefinicjaUprawnienia | Definicje uprawnień | `DefUprawnien` |  | root |  | IManagedRowDefinion, IZklPozycjaSlownika, IPozycjaKonfiguratora |  | [DefinicjaUprawnienia.md](DefinicjaUprawnienia.md) |
| DodatkowaKwalifikacjaZawodowa | Dodatkowe kwalifikacje zawodowe | `ZklDodKwalZwd` | konfig | root |  | IZklPozycjaSlownika |  | [DodatkowaKwalifikacjaZawodowa.md](DodatkowaKwalifikacjaZawodowa.md) |
| DokumentDefinicjiStanowiska | Dokumenty defincji stanowisk | `DokumentyDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  |  | [DokumentDefinicjiStanowiska.md](DokumentDefinicjiStanowiska.md) |
| DokumentPlanowaniaZasobow | Dokumenty planowania zasobów | `DokPlanZasob` |  | root |  |  |  | [DokumentPlanowaniaZasobow.md](DokumentPlanowaniaZasobow.md) |
| DokumentProcedura | Dokumenty i procedury | `ZklDokProc` | konfig | root |  | IZklPozycjaSlownika |  | [DokumentProcedura.md](DokumentProcedura.md) |
| DostawcaSzkoleń | Dostawcy szkoleń | `DostawcySzkolen` |  | root |  |  |  | [DostawcaSzkoleń.md](DostawcaSzkoleń.md) |
| DostepDoSystemow | Dostępy do systemów | `ZklDostSys` | konfig | root |  | IZklPozycjaSlownika |  | [DostepDoSystemow.md](DostepDoSystemow.md) |
| ElementOcenyPracownika | Kryteria | `ElementyOcenPrac` |  | child: Ocena→IOcenaPracownika |  |  |  | [ElementOcenyPracownika.md](ElementOcenyPracownika.md) |
| ElementWzoruOcenyPracownika | Kryteria | `ElemWzorowOcPrac` | konfig | child: Wzor→WzorOcenyPracownika |  |  |  | [ElementWzoruOcenyPracownika.md](ElementWzoruOcenyPracownika.md) |
| EtapRealizacjiSzkolenia | Etapy realizacji szkoleń | `EtapRealizSzkol` | konfig | root |  |  |  | [EtapRealizacjiSzkolenia.md](EtapRealizacjiSzkolenia.md) |
| EtapRekrutacji | Etapy rekrutacji | `EtapyRekrutacji` |  | root |  | IOcenaPracownika |  | [EtapRekrutacji.md](EtapRekrutacji.md) |
| FormularzWartosciowania | Formularze wartościowania | `ZklFormularzWart` |  |  |  |  |  | [FormularzWartosciowania.md](FormularzWartosciowania.md) |
| GrupaKompetencjiMerytorycznych | Katalog kompetencji merytorycznych | `ZklKtgKmpMery` | konfig | root |  | IZklPozycjaSlownika |  | [GrupaKompetencjiMerytorycznych.md](GrupaKompetencjiMerytorycznych.md) |
| GrupaKompetencjiUniwersalnych | Katalog kompetencji uniwersalnych | `ZklKtgKmpUniw` | konfig | root |  | IZklPozycjaSlownika |  | [GrupaKompetencjiUniwersalnych.md](GrupaKompetencjiUniwersalnych.md) |
| GrupaStanowisk | Grupy stanowisk | `GrupaStanow` | konfig | root |  | IZklPozycjaSlownika |  | [GrupaStanowisk.md](GrupaStanowisk.md) |
| GrupaSzkolenIUprawnien | Grupy szkoleń i uprawnień | `ZklGrSzkolUpr` | konfig | root |  | IZklPozycjaSlownika |  | [GrupaSzkolenIUprawnien.md](GrupaSzkolenIUprawnien.md) |
| GrupaZadan | Katalog zadań | `ZklKtgZadan` | konfig | root |  | IZklPozycjaSlownika |  | [GrupaZadan.md](GrupaZadan.md) |
| GrupaZaszeregowaniaDefinicjiStanowiska | Grupy zaszeregowania defincji stanowisk | `GrupZasDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  |  | [GrupaZaszeregowaniaDefinicjiStanowiska.md](GrupaZaszeregowaniaDefinicjiStanowiska.md) |
| KategoriaGrupyStanowisk | Kategorie grup stanowisk | `KatGrupyStan` | konfig | root |  | IZklPozycjaSlownika |  | [KategoriaGrupyStanowisk.md](KategoriaGrupyStanowisk.md) |
| KategoriaPracownika | Kategorie pracowników | `KatPrac` | konfig | root |  |  |  | [KategoriaPracownika.md](KategoriaPracownika.md) |
| KategoriaSzkolenia | Kategorie szkoleń | `KategorieSzkolen` | konfig | root |  |  |  | [KategoriaSzkolenia.md](KategoriaSzkolenia.md) |
| KategoriaUprawnienia | Kategorie uprawnień | `KatUprawnien` | konfig | root |  |  |  | [KategoriaUprawnienia.md](KategoriaUprawnienia.md) |
| KategoriePracownikow | Kategorie pracowników | `ZklKatPrac` | konfig | root |  | IZklPozycjaSlownika |  | [KategoriePracownikow.md](KategoriePracownikow.md) |
| KierunekKsztalceniaSzkolySrednie | Kierunki kształcenia szkoły średnie | `ZklKierKszSre` | konfig | root |  | IZklPozycjaSlownika |  | [KierunekKsztalceniaSzkolySrednie.md](KierunekKsztalceniaSzkolySrednie.md) |
| KierunekKsztalceniaSzkolyWyzsze | Kierunki kształcenia szkoły wyższe | `ZklKierKszWyz` | konfig | root |  | IZklPozycjaSlownika |  | [KierunekKsztalceniaSzkolyWyzsze.md](KierunekKsztalceniaSzkolyWyzsze.md) |
| KierunekKsztalceniaSzkolyZawodowe | Kierunki kształcenia szkoły zawodowe | `ZklKierKszZwd` | konfig | root |  | IZklPozycjaSlownika |  | [KierunekKsztalceniaSzkolyZawodowe.md](KierunekKsztalceniaSzkolyZawodowe.md) |
| KompetencjaMerytoryczna | Kompetencje merytoryczne | `ZklKmpMery` | konfig | root |  | IZklPozycjaSlownika, IPozycjaKonfiguratora |  | [KompetencjaMerytoryczna.md](KompetencjaMerytoryczna.md) |
| KompetencjaUniwersalna | Kompetencje uniwersalne | `ZklKmpUniw` | konfig | root |  | IZklPozycjaSlownika, IPozycjaKonfiguratora |  | [KompetencjaUniwersalna.md](KompetencjaUniwersalna.md) |
| KryteriumAnalityczne | Kryteria analityczne | `ZklKrytAnality` | konfig | root |  |  |  | [KryteriumAnalityczne.md](KryteriumAnalityczne.md) |
| KryteriumSyntetyczne | Kryteria syntetyczne | `ZklKrytSynt` | konfig | root |  |  |  | [KryteriumSyntetyczne.md](KryteriumSyntetyczne.md) |
| KsuDefinicjaInfo | Informacje pozycji KSU | `ZklKsuDefInfo` | konfig | root |  |  |  | [KsuDefinicjaInfo.md](KsuDefinicjaInfo.md) |
| KsuGrupaStanowisk | Powiązania informacji KSU z grupami stanowisk | `ZklKsuGrStan` | konfig | root |  |  |  | [KsuGrupaStanowisk.md](KsuGrupaStanowisk.md) |
| KsuObszarFunkcjonalny | Powiązania informacji KSU z obszarami funkcjonalnymi | `ZklKsuObszFun` | konfig | root |  |  |  | [KsuObszarFunkcjonalny.md](KsuObszarFunkcjonalny.md) |
| KsuSzkoleniePoprzedzajace | Powiązania informacji KSU ze szkoleniami poprzedzającymi | `ZklKsuSzkPop` | konfig | root |  |  |  | [KsuSzkoleniePoprzedzajace.md](KsuSzkoleniePoprzedzajace.md) |
| KsuUprawnieniePoprzedzajace | Powiązania informacji KSU z uprawnieniami poprzedzającymi | `ZklKsuUprPop` | konfig | root |  |  |  | [KsuUprawnieniePoprzedzajace.md](KsuUprawnieniePoprzedzajace.md) |
| KwalifikacjePracownikaZkl | Kwalifikacje pracownika | `ZKLKwalPrac` |  | child: Pracownik→Pracownik |  |  | TypKwalifikacjiPracownika (3) | [KwalifikacjePracownikaZkl.md](KwalifikacjePracownikaZkl.md) |
| MacierzWartosciowania | Macierze kryteriów wartościowania | `ZklWrtMacierz` |  |  |  |  |  | [MacierzWartosciowania.md](MacierzWartosciowania.md) |
| MnoznikMacierzyWartosciowania | Mnożniki macierzy kryteriów wartościowania | `ZklWrtMxMnozniki` |  |  |  |  |  | [MnoznikMacierzyWartosciowania.md](MnoznikMacierzyWartosciowania.md) |
| ObslugaMaszynIUrzadzen | Obsługa maszyn i urządzeń | `ZklObsMaszUrz` | konfig | root |  | IZklPozycjaSlownika |  | [ObslugaMaszynIUrzadzen.md](ObslugaMaszynIUrzadzen.md) |
| ObszarFunkcjonalny | Obszary funkcjonalne | `ZklObszrFunk` | konfig | root |  | IZklPozycjaSlownika |  | [ObszarFunkcjonalny.md](ObszarFunkcjonalny.md) |
| ObszarOdpowiedzialnosciPracownikaZkl | Obszary odpowiedzialności pracownika | `ZklObszOdpPrac` |  | child: Pracownik→Pracownik |  |  |  | [ObszarOdpowiedzialnosciPracownikaZkl.md](ObszarOdpowiedzialnosciPracownikaZkl.md) |
| ObszarOdpowiedzialnosciStanowiska | Obszary odpowiedzialności stanowiska | `ZklObszOdp` | konfig | child: Stanowisko→DefinicjaStanowiska |  |  |  | [ObszarOdpowiedzialnosciStanowiska.md](ObszarOdpowiedzialnosciStanowiska.md) |
| OcenaPracownika | Oceny pracowników | `OcenyPracownikow` |  | root |  | IOcenaPracownika |  | [OcenaPracownika.md](OcenaPracownika.md) |
| Odpowiedzialnosc | Katalog odpowiedzialności | `ZklKtgOdp` | konfig | root |  | IZklPozycjaSlownika, IPozycjaKonfiguratora |  | [Odpowiedzialnosc.md](Odpowiedzialnosc.md) |
| OfertaSzkolenia | Oferty szkoleń | `OfertySzkolen` |  | root |  | IAdresHost | TypOfertySzkolenia (2) | [OfertaSzkolenia.md](OfertaSzkolenia.md) |
| OkresDoswiadczeniaZawodowego | Okresy doświadczenia zawodowego | `ZklOkrDosZwd` | konfig | root |  | IZklPozycjaSlownika |  | [OkresDoswiadczeniaZawodowego.md](OkresDoswiadczeniaZawodowego.md) |
| PowiazanieDefStanSlownikiZkl | Powiązania stanowisk z pozycjami słowników ZKL | `PowDefStZklSlw` | konfig | root |  |  | TypPowiazaniaSlownikaZkl (5) | [PowiazanieDefStanSlownikiZkl.md](PowiazanieDefStanSlownikiZkl.md) |
| PowiazanieDefinicjiStanowisk | Powiązania definicji stanowisk | `PowDefStan` | konfig | root |  |  | TypPowiazaniaStanowisk (3) | [PowiazanieDefinicjiStanowisk.md](PowiazanieDefinicjiStanowisk.md) |
| PoziomRozwojuKompetencjiMerytorycznych | Poziomy rozwoju kompetencji merytorycznych | `ZklPozRozKomMer` | konfig | root |  | IZklPozycjaSlownika |  | [PoziomRozwojuKompetencjiMerytorycznych.md](PoziomRozwojuKompetencjiMerytorycznych.md) |
| PoziomRozwojuKompetencjiUniwersalnych | Poziomy rozwoju kompetencji uniwersalnych | `ZklPozRozKomUni` | konfig | root |  | IZklPozycjaSlownika |  | [PoziomRozwojuKompetencjiUniwersalnych.md](PoziomRozwojuKompetencjiUniwersalnych.md) |
| PoziomUmiejetnosci | Poziomy umiejętności | `ZklPozUmiejet` | konfig | root |  | IZklPozycjaSlownika |  | [PoziomUmiejetnosci.md](PoziomUmiejetnosci.md) |
| PoziomWyksztalcenia | Poziomy wykształcenia | `ZklPozWykszt` | konfig | root |  | IZklPozycjaSlownika |  | [PoziomWyksztalcenia.md](PoziomWyksztalcenia.md) |
| PozycjaDokumentuPlanowaniaZasobow | Pozycje dokumentów planowania zasobów | `PozDokPlanZasob` |  | child: Dokument→DokumentPlanowaniaZasobow |  |  |  | [PozycjaDokumentuPlanowaniaZasobow.md](PozycjaDokumentuPlanowaniaZasobow.md) |
| PozycjaDoswiadczeniaProfiluGrupa | Pozycje doświadczenia w grupie stanowisk profilu | `ZklPozKwalDosGr` | konfig | root |  |  |  | [PozycjaDoswiadczeniaProfiluGrupa.md](PozycjaDoswiadczeniaProfiluGrupa.md) |
| PozycjaDoswiadczeniaProfiluObszar | Pozycje doświadczenia w obszarze funkcjonalnym profilu | `ZklPozKwalDosOb` | konfig | root |  |  |  | [PozycjaDoswiadczeniaProfiluObszar.md](PozycjaDoswiadczeniaProfiluObszar.md) |
| PozycjaJezykaProfiluTypPotwier | Typy potwierdzeń języka obcego | `ZklPozKwalJezTP` | konfig | root |  |  |  | [PozycjaJezykaProfiluTypPotwier.md](PozycjaJezykaProfiluTypPotwier.md) |
| PozycjaJezykowObcychProfilu | Pozycje języków obcych profilu | `ZklPozKwalJezyki` | konfig | root |  |  | RodzajWymagania (2) | [PozycjaJezykowObcychProfilu.md](PozycjaJezykowObcychProfilu.md) |
| PozycjaKwalifikacjiProfiluTypPotwier | Typy potwierdzeń kwalifikacji | `ZklPozKwalKwalTP` | konfig | root |  |  |  | [PozycjaKwalifikacjiProfiluTypPotwier.md](PozycjaKwalifikacjiProfiluTypPotwier.md) |
| PozycjaKwalifikacjiZawodowychProfilu | Pozycje kwalifikacji zawodowych profilu | `ZklPozKwalKwal` | konfig | root |  |  | RodzajWymagania (2) | [PozycjaKwalifikacjiZawodowychProfilu.md](PozycjaKwalifikacjiZawodowychProfilu.md) |
| PozycjaMaszynIUrzadzenProfilu | Pozycje maszyn i urządzeń profilu | `ZklPozKwalMaszyn` | konfig | root |  |  | RodzajWymagania (2) | [PozycjaMaszynIUrzadzenProfilu.md](PozycjaMaszynIUrzadzenProfilu.md) |
| PozycjaMaszynyProfiluTypPotwier | Typy potwierdzeń maszyny | `ZklPozKwalMszTP` | konfig | root |  |  |  | [PozycjaMaszynyProfiluTypPotwier.md](PozycjaMaszynyProfiluTypPotwier.md) |
| PozycjaProfiluKompetencjiMerytorycznych | Pozycje profilu kompetencji merytorycznych | `ZklPozProfilKKM` | konfig | root |  |  | RodzajWymagania (2) | [PozycjaProfiluKompetencjiMerytorycznych.md](PozycjaProfiluKompetencjiMerytorycznych.md) |
| PozycjaProfiluKompetencjiUniwersalnych | Pozycje profilu kompetencji uniwersalnych | `ZklPozProfilKKU` | konfig | root |  |  | RodzajWymagania (2) | [PozycjaProfiluKompetencjiUniwersalnych.md](PozycjaProfiluKompetencjiUniwersalnych.md) |
| PozycjaProfiluZadaniowego | Pozycje profilu zadaniowego | `ZklPozProfilZdn` | konfig | root |  |  |  | [PozycjaProfiluZadaniowego.md](PozycjaProfiluZadaniowego.md) |
| PozycjaSystemowITProfilu | Pozycje systemów IT profilu | `ZklPozKwalIT` | konfig | root |  |  | RodzajWymagania (2) | [PozycjaSystemowITProfilu.md](PozycjaSystemowITProfilu.md) |
| PozycjaSystemuITProfiluTypPotwier | Typy potwierdzeń systemu IT | `ZklPozKwalITTP` | konfig | root |  |  |  | [PozycjaSystemuITProfiluTypPotwier.md](PozycjaSystemuITProfiluTypPotwier.md) |
| PozycjaSzkolenIUprawnienProfilu | Pozycje szkoleń i uprawnień profilu | `ZklPozSzkUpr` | konfig | root |  |  |  | [PozycjaSzkolenIUprawnienProfilu.md](PozycjaSzkolenIUprawnienProfilu.md) |
| PozycjaWyksztalceniaProfilu | Pozycje wykształcenia profilu | `ZklPozKwalWykszt` | konfig | root |  |  | WyksztalcenieProfiluSelektor (6) | [PozycjaWyksztalceniaProfilu.md](PozycjaWyksztalceniaProfilu.md) |
| PozycjaWyszukania | Kryteria | `PozycjeWyszukan` |  | child: Wyszukanie→Wyszukanie |  |  |  | [PozycjaWyszukania.md](PozycjaWyszukania.md) |
| ProfilKompetencjiMerytorycznych | Profile kompetencji merytorycznych | `ZklProfilKKM` | konfig | root |  |  |  | [ProfilKompetencjiMerytorycznych.md](ProfilKompetencjiMerytorycznych.md) |
| ProfilKompetencjiUniwersalnych | Profile kompetencji uniwersalnych | `ZklProfilKKU` | konfig | root |  |  |  | [ProfilKompetencjiUniwersalnych.md](ProfilKompetencjiUniwersalnych.md) |
| ProfilKwalifikacyjny | Profile kwalifikacji | `ZklProfilKwal` | konfig | root |  |  |  | [ProfilKwalifikacyjny.md](ProfilKwalifikacyjny.md) |
| ProfilSzkolenIUprawnien | Profile szkoleń i uprawnień | `ZklProfilSzkUpr` | konfig | root |  |  |  | [ProfilSzkolenIUprawnien.md](ProfilSzkolenIUprawnien.md) |
| ProfilZadaniowy | Profile zadań | `ZklProfilZdn` | konfig | root |  |  |  | [ProfilZadaniowy.md](ProfilZadaniowy.md) |
| PunktyMacierzyWartosciowania | Punkty macierzy kryteriów wartościowania | `ZklWrtMxPunkty` |  |  |  |  |  | [PunktyMacierzyWartosciowania.md](PunktyMacierzyWartosciowania.md) |
| RealizacjaSzkolenia | Szkolenia | `RealizSzkolen` |  | root |  | IAdresHost, IOceniany, IŹródłoOceny |  | [RealizacjaSzkolenia.md](RealizacjaSzkolenia.md) |
| Rekrutacja |  | `Rekrutacje` |  | root |  | IŹródłoKartyCharakterystykiPracownika |  | [Rekrutacja.md](Rekrutacja.md) |
| StopienOdpowiedzialnosci | Stopnie odpowiedzialności | `ZklStopOdp` | konfig | root |  | IZklPozycjaSlownika |  | [StopienOdpowiedzialnosci.md](StopienOdpowiedzialnosci.md) |
| SystemITJezykProgramowania | Systemy IT i języki programowania | `ZklSystITProg` | konfig | root |  | IZklPozycjaSlownika |  | [SystemITJezykProgramowania.md](SystemITJezykProgramowania.md) |
| SzkolenieBHPDefinicjiStanowiska | Szkolenia BHP defincji stanowisk | `SzkolBHPDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  |  | [SzkolenieBHPDefinicjiStanowiska.md](SzkolenieBHPDefinicjiStanowiska.md) |
| TypPotwierdzenia | Typy potwierdzeń | `ZklTypPotwier` | konfig | root |  | IZklPozycjaSlownika |  | [TypPotwierdzenia.md](TypPotwierdzenia.md) |
| TytulZawodowyStopienNaukowy | Tytuły zawodowe i stopnie naukowe | `ZklTytZwdStNauk` | konfig | root |  | IZklPozycjaSlownika |  | [TytulZawodowyStopienNaukowy.md](TytulZawodowyStopienNaukowy.md) |
| UkończoneSzkolenie | Ukończone szkolenia | `UkonczSzkolenia` |  | root |  | IOcenaPracownika |  | [UkończoneSzkolenie.md](UkończoneSzkolenie.md) |
| UprawnienieDefinicjiStanowiska | Uprawnienia defincji stanowisk | `UprawnDefStan` |  | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  |  | [UprawnienieDefinicjiStanowiska.md](UprawnienieDefinicjiStanowiska.md) |
| UprawnienieDefinicjiSzkolenia | Uprawnienia | `UprawnDefSzkol` |  | child: DefinicjaSzkolenia→DefinicjaSzkolenia |  |  |  | [UprawnienieDefinicjiSzkolenia.md](UprawnienieDefinicjiSzkolenia.md) |
| UprawnieniePracownika | Uprawnienia | `UprawnieniaPrac` |  | root |  |  |  | [UprawnieniePracownika.md](UprawnieniePracownika.md) |
| WartosciowanieStanowiska | Wartościowania stanowisk | `ZklWartStanow` |  |  |  |  |  | [WartosciowanieStanowiska.md](WartosciowanieStanowiska.md) |
| WartośćElementuOcenyPracownika | Wartości elementu oceny | `WartElemOcenPrac` | konfig | child: Definicja→DefElementuOcenyPracownika |  |  |  | [WartośćElementuOcenyPracownika.md](WartośćElementuOcenyPracownika.md) |
| WniosekOSzkolenie | Wnioski o szkolenia | `WnioskiOSzkol` |  | root |  | IŹródłoUzyskaniaUprawnienia, IOcenaPracownika, IBazaZrodlaWyplaty |  | [WniosekOSzkolenie.md](WniosekOSzkolenie.md) |
| WspolpracaWewnetrznaJednostkiDefStan | Współpraca wewnętrzna definicji stanowisk z jednostkami organizacyjnymi | `WspWeJnDefSt` | konfig | root |  |  |  | [WspolpracaWewnetrznaJednostkiDefStan.md](WspolpracaWewnetrznaJednostkiDefStan.md) |
| WydziałDefinicjiStanowiska | Jednostki organizacyjne defincji stanowisk | `WydzialyDefStan` | konfig | child: DefinicjaStanowiska→DefinicjaStanowiska |  |  |  | [WydziałDefinicjiStanowiska.md](WydziałDefinicjiStanowiska.md) |
| WynikPozycjiWartosciowania | Wyniki pozycji wartościowania | `ZklWynikPozWart` |  |  |  |  |  | [WynikPozycjiWartosciowania.md](WynikPozycjiWartosciowania.md) |
| WyposazenieStanowiska | Wyposażenie stanowiska | `ZklWypStanow` | konfig | root |  | IZklPozycjaSlownika |  | [WyposazenieStanowiska.md](WyposazenieStanowiska.md) |
| Wysilek | Wysiłek | `ZklWysilek` | konfig | root |  | IZklPozycjaSlownika |  | [Wysilek.md](Wysilek.md) |
| Wyszukanie | Wyszukania | `Wyszukania` |  | root |  |  |  | [Wyszukanie.md](Wyszukanie.md) |
| WzorOcenyPracownika | Wzory ocen | `WzoryOcenPrac` | konfig | root |  |  |  | [WzorOcenyPracownika.md](WzorOcenyPracownika.md) |
| ZadanieZkl | Zadania | `ZklZadania` | konfig | root |  | IZklPozycjaSlownika |  | [ZadanieZkl.md](ZadanieZkl.md) |

