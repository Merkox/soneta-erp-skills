# Moduł `CzlonkowieSzkolenia` — tabele biznesowe

- Opis: Moduł zarządzania członkami i szkoleniami organizacji. Zawiera kartotekę członków, kursy szkoleniowe, zapisy, certyfikaty oraz harmonogramy szkoleń.
- Tabel: **43**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DefRodzajSzkol | Definicje rodzajów szkoleń | `DefRodzajeSzkol` | konfig | root |  |  |  | [DefRodzajSzkol.md](DefRodzajSzkol.md) |
| DefSkladki | Definicje składek | `DefSkladek` | konfig | root |  | IRightsSource |  | [DefSkladki.md](DefSkladki.md) |
| DefWyroznienia | Definicje wyróżnień | `DefWyroznien` | konfig | root |  |  |  | [DefWyroznienia.md](DefWyroznienia.md) |
| DefZgloszenia | Definicje zgłoszeń | `DefZgloszen` | konfig | root |  | IRightsSource |  | [DefZgloszenia.md](DefZgloszenia.md) |
| GrupaMaterial | Materiały | `GrupyMaterialy` |  |  |  |  |  | [GrupaMaterial.md](GrupaMaterial.md) |
| GrupaSzkol | Grupy szkoleniowe | `GrupySzkol` |  | root |  | IElementSlownika, IZrodloHarmWplaty, IEmailElement, IOceniany, IŹródłoOceny |  | [GrupaSzkol.md](GrupaSzkol.md) |
| HarmonogramWplat | Harmonogramy wpłat | `HarmWplat` |  |  |  |  |  | [HarmonogramWplat.md](HarmonogramWplat.md) |
| Klub |  | `Kluby` | konfig | root |  |  |  | [Klub.md](Klub.md) |
| KlubUcz | Kluby/koła uczestników | `KlubyUcz` |  | child: UczestnikBase→UczestnikBase |  |  |  | [KlubUcz.md](KlubUcz.md) |
| KlubUczHist | Przynależność do klubów | `KlubyUczHist` |  |  |  |  |  | [KlubUczHist.md](KlubUczHist.md) |
| ModulSzkol | Moduły szkoleniowe. | `ModulySzkol` |  |  |  |  |  | [ModulSzkol.md](ModulSzkol.md) |
| Odczyt |  | `Odczyty` |  | root |  |  |  | [Odczyt.md](Odczyt.md) |
| OdczytCzlonek | Odczyty członków | `OdczytyCzlonkow` |  |  |  |  |  | [OdczytCzlonek.md](OdczytCzlonek.md) |
| PrzedmiotSzkol | Przedmioty | `PrzedmiotySzkol` |  | root |  |  |  | [PrzedmiotSzkol.md](PrzedmiotSzkol.md) |
| RejestrUDZ | Rejestr ustawicznego doskonalenia zawodowego | `RejestryUDZ` |  | root |  |  |  | [RejestrUDZ.md](RejestrUDZ.md) |
| RodzajSzkol | Rodzaje szkoleń | `RodzajeSzkol` |  | root |  | IElementSlownika | RodzajSzkolenia (2) | [RodzajSzkol.md](RodzajSzkol.md) |
| RodzajSzkolPrzedmiot | Przedmioty | `RdzSzPrzedmioty` |  |  |  |  |  | [RodzajSzkolPrzedmiot.md](RodzajSzkolPrzedmiot.md) |
| RodzajSzkolUprawnienie | Uprawnienie wydawane w ramach szkolenia. | `RdzSzkUpraw` |  | root |  |  |  | [RodzajSzkolUprawnienie.md](RodzajSzkolUprawnienie.md) |
| RodzajSzkolWyroznienie | Wyrożnienia wydawane w ramach szkolenia. | `RdzSzkWyroz` |  |  |  |  |  | [RodzajSzkolWyroznienie.md](RodzajSzkolWyroznienie.md) |
| SalaSzkol | Sale szkoleniowe | `SaleSzkol` |  | root |  |  |  | [SalaSzkol.md](SalaSzkol.md) |
| Skladka | Składki | `Skladki` |  | root |  | IDokumentPlatny, IDokumentKsiegowalny |  | [Skladka.md](Skladka.md) |
| SzkOsobaPodpis | Osoba podpisująca | `SzkOsobyPodpisy` | konfig | root |  |  |  | [SzkOsobaPodpis.md](SzkOsobaPodpis.md) |
| TrybZajec | Tryby zajęć | `TrybyZajec` | konfig |  |  |  |  | [TrybZajec.md](TrybZajec.md) |
| TypDzialalUcz | Typy działalności uczestników | `TypyDzialalUcz` |  | child: UczestnikBase→UczestnikBase |  |  |  | [TypDzialalUcz.md](TypDzialalUcz.md) |
| TypDzialalnosci | Typy działalności | `TypyDzialalnosci` | konfig | root |  |  |  | [TypDzialalnosci.md](TypDzialalnosci.md) |
| TytulZawodUcz | Tytuły zawodowe uczestników | `TytulyZawodUcz` |  | child: UczestnikBase→UczestnikBase |  |  |  | [TytulZawodUcz.md](TytulZawodUcz.md) |
| UczFunkcja | Funkcje z wyboru | `UczFunkcje` |  | root |  |  |  | [UczFunkcja.md](UczFunkcja.md) |
| UczTytulZawod | Tytuły zawodowe | `UczTytulyZawod` | konfig | root |  |  |  | [UczTytulZawod.md](UczTytulZawod.md) |
| UczestnikBase | Uczestnicy, członkowie | `Uczestnicy` |  | root |  | IPeselHost, INipHost, IPlecHost, IGIODOZgodnyHost, IGIODOWymianaDanychHost, IGIODOOświadczenieHost, IEmailElement, IOceniany | TypUczestnika (3) | [UczestnikBase.md](UczestnikBase.md) |
| UczestnikHist | Historia uczestników, członków | `UczestnicyHist` |  |  |  |  |  | [UczestnikHist.md](UczestnikHist.md) |
| UprawnienieZgloszenia | Uprawnienie zgłoszenia | `UprawZglosz` |  |  |  |  |  | [UprawnienieZgloszenia.md](UprawnienieZgloszenia.md) |
| WykladowcaSzkol | Wykładowcy | `WykladowcySzkol` |  | root |  | IOceniający, ITaskUser |  | [WykladowcaSzkol.md](WykladowcaSzkol.md) |
| Wyroznienie | Certyfikaty, odznaczenia | `Wyroznienia` |  | root |  |  |  | [Wyroznienie.md](Wyroznienie.md) |
| ZajecieSala |  | `ZajeciaSale` |  |  |  |  |  | [ZajecieSala.md](ZajecieSala.md) |
| ZajecieSzkolBase | Zajęcia | `ZajeciaSzkol` |  | root |  | IŹródłoOceny | TypZajeciaSzkol (4) | [ZajecieSzkolBase.md](ZajecieSzkolBase.md) |
| ZajecieUczestnik | Zgłoszenia na zajęcia | `ZajeciaUcz` |  |  |  |  |  | [ZajecieUczestnik.md](ZajecieUczestnik.md) |
| ZajecieWykladowca | Wykładowcy | `ZajeciaWykl` |  |  |  |  |  | [ZajecieWykladowca.md](ZajecieWykladowca.md) |
| ZespolSzkol | Zespoły | `ZespolySzkol` |  |  |  |  |  | [ZespolSzkol.md](ZespolSzkol.md) |
| Zgloszenie | Zgłoszenia | `Zgloszenia` |  | root |  |  |  | [Zgloszenie.md](Zgloszenie.md) |
| ZgloszeniePlatnik | Płatnicy | `ZgloszeniaPlat` |  |  |  |  |  | [ZgloszeniePlatnik.md](ZgloszeniePlatnik.md) |
| ZgloszeniePozDok |  | `ZgloszeniaPozDok` |  |  |  |  |  | [ZgloszeniePozDok.md](ZgloszeniePozDok.md) |
| ZgloszenieUczGrupa | Zgłoszenia na grupę. | `ZgloszeniaUczGrp` |  |  |  |  |  | [ZgloszenieUczGrupa.md](ZgloszenieUczGrupa.md) |
| ZgloszenieUczestnik | Uczestnicy | `ZgloszeniaUczest` |  |  |  | IZrodloHarmWplaty, IEmailElement |  | [ZgloszenieUczestnik.md](ZgloszenieUczestnik.md) |

