# Moduł `Produkcja` — tabele biznesowe

- Opis: Moduł produkcyjny obsługujący planowanie i realizację procesów wytwórczych. Definiuje technologie produkcyjne z operacjami, pozycjami surowcowymi i produktowymi, czasami operacji oraz zasobami (maszynami, osobami). Wspiera rejestrację przebiegu produkcji, kalkulację kosztów wytworzenia, rezerwację surowców, raportowanie braków i awarii oraz rozliczenie akordowe.
- Tabel: **23**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| CzasTechn | Czasy operacji | `CzasyTechn` |  | root |  |  |  | [CzasTechn.md](CzasTechn.md) |
| KosztTechn | Koszty technologii | `KosztyTechn` |  | root |  |  |  | [KosztTechn.md](KosztTechn.md) |
| Operacja | Operacja produkcyjna | `Operacje` |  | root |  | IKosztTechnHost, IProdHistoriaZapis, IZasobTechHost, IKodowany |  | [Operacja.md](Operacja.md) |
| OperacjaPoprzedzajaca | Operacje poprzedzające, od których zależy możliwość wykonanania operacji | `OperacjePoprzed` |  |  |  |  |  | [OperacjaPoprzedzajaca.md](OperacjaPoprzedzajaca.md) |
| PozycjaTechn | Pozycje technologii | `PozycjeTechn` |  | root |  |  |  | [PozycjaTechn.md](PozycjaTechn.md) |
| ProdAwaria | Awarie produkcyjne | `ProdAwarie` |  | root |  |  |  | [ProdAwaria.md](ProdAwaria.md) |
| ProdHistoria | Rejestracja czasu operacji | `ProdHistorie` |  |  |  |  |  | [ProdHistoria.md](ProdHistoria.md) |
| ProdKompetencja | Słownik kompetencji osob produkcyjnych | `ProdKompetencje` |  |  |  |  |  | [ProdKompetencja.md](ProdKompetencja.md) |
| ProdMeldunekBraku | Meldunki braków | `ProdMeldBrakow` |  | root |  |  |  | [ProdMeldunekBraku.md](ProdMeldunekBraku.md) |
| ProdOsoba | Osoby wykonujące operacje produkcyjne | `ProdOsobyR` |  | root |  | IProdOsoba, IProdZasob |  | [ProdOsoba.md](ProdOsoba.md) |
| ProdOsobaKompetencja | Powiązanie osoby produkcyjnej z kompetancjami | `ProdOsobaKom` |  |  |  |  |  | [ProdOsobaKompetencja.md](ProdOsobaKompetencja.md) |
| ProdOsobaWzorcowa | Wzorce osób wykonujących operacje produkcyjne | `ProdOsobyWz` |  |  |  | IProdOsoba, IProdZasob |  | [ProdOsobaWzorcowa.md](ProdOsobaWzorcowa.md) |
| ProdPozSlownika | Pozycje słowników | `ProdPozSlownikow` | konfig | child: Slownik→ProdSlownik |  |  |  | [ProdPozSlownika.md](ProdPozSlownika.md) |
| ProdProdukt | Parametry towarów | `ProdProdukty` | konfig | root |  |  |  | [ProdProdukt.md](ProdProdukt.md) |
| ProdSlownik | Słowniki | `ProdSlowniki` | konfig | root |  |  |  | [ProdSlownik.md](ProdSlownik.md) |
| ProdZasob | Produkcyjne zasoby rzeczywiste | `ProdZasobyR` |  | root |  | IProdZasob |  | [ProdZasob.md](ProdZasob.md) |
| ProdZasobRelacja | Relacje zasobów produkcyjnych | `ProdZasobyRel` |  |  |  |  |  | [ProdZasobRelacja.md](ProdZasobRelacja.md) |
| ProdZasobWzorcowy | Produkcyjne zasoby wzorcowe | `ProdZasobyW` |  |  |  | IProdZasob |  | [ProdZasobWzorcowy.md](ProdZasobWzorcowy.md) |
| RelacjaProdZasobCRM | Relacje zasobow produkcujnych z zasobami CRM | `RelProdZasobCRM` |  |  |  |  |  | [RelacjaProdZasobCRM.md](RelacjaProdZasobCRM.md) |
| RezerwacjaSurowca | Rezerwacje surowca | `RezerwacjeSur` |  |  |  |  |  | [RezerwacjaSurowca.md](RezerwacjaSurowca.md) |
| Technologia | Technologie produkcyjne | `Technologie` |  | root |  | IKosztTechnHost, IZasobTechHost |  | [Technologia.md](Technologia.md) |
| WzorcowyCzasOper | Wzorcowe czasy operacji | `WzorcoweCzasOper` | konfig |  |  |  |  | [WzorcowyCzasOper.md](WzorcowyCzasOper.md) |
| ZasobTechn | Zasoby wzorcowe lub rzeczywiste przypisane do obiektów produkcyjnych | `ZasobyTechn` |  |  |  |  | TypZasobuTechn (4) | [ZasobTechn.md](ZasobTechn.md) |

