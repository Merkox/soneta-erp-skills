# Moduł `ProdukcjaPro` — tabele biznesowe

- Opis: Zaawansowany moduł produkcji. Zawiera zlecenia produkcyjne, operacje technologiczne, harmonogramowanie, kontrolę jakości, marszruty oraz szczegółowe rozliczanie kosztów produkcji.
- Tabel: **66**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| ProAwaria | Awarie produkcyjne | `ProAwarie` |  | root |  |  |  | [ProAwaria.md](ProAwaria.md) |
| ProCzasPracy | Czasy pracy | `ProCzasyPracy` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia |  |  |  | [ProCzasPracy.md](ProCzasPracy.md) |
| ProDefinicjaMeldunku | Definicje meldunku produkcyjnego | `ProDMeldunkow` |  | root |  |  |  | [ProDefinicjaMeldunku.md](ProDefinicjaMeldunku.md) |
| ProDefinicjaOperacji | Definicje operacji produkcyjnych | `ProDOperacji` |  | root |  |  |  | [ProDefinicjaOperacji.md](ProDefinicjaOperacji.md) |
| ProDostawaMaterialuMeldunku | Dostawy materiałów meldunków | `ProDostawyMM` |  | child: MaterialMeldunku→ProMaterialMeldunku |  |  |  | [ProDostawaMaterialuMeldunku.md](ProDostawaMaterialuMeldunku.md) |
| ProFantomMaterialu | Fantomy materiałów | `ProFanMaterialow` |  | child: RozliczenieMaterialu→ProRozliczenieMaterialu |  |  |  | [ProFantomMaterialu.md](ProFantomMaterialu.md) |
| ProFantomWyrobu | Fantomy wyrobów | `ProFanWyrobow` |  | child: RozliczenieWyrobu→ProRozliczenieWyrobu |  |  |  | [ProFantomWyrobu.md](ProFantomWyrobu.md) |
| ProKalkulacjaMeldunku | Kalkulacje meldunku | `ProKalkulacjeM` |  | child: Meldunek→ProMeldunek |  |  |  | [ProKalkulacjaMeldunku.md](ProKalkulacjaMeldunku.md) |
| ProKalkulacjaOperacjiTechnologii | Kalkulacje operacji technologii | `ProKalkulacjeOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  |  | [ProKalkulacjaOperacjiTechnologii.md](ProKalkulacjaOperacjiTechnologii.md) |
| ProKalkulacjaOperacjiZlecenia | Kalkulacje operacji zleceń | `ProKalkulacjeOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProKalkulacjaOperacjiZlecenia.md](ProKalkulacjaOperacjiZlecenia.md) |
| ProKompetencja | Właściwości produkcyjne | `ProKompetencje` |  | root |  |  |  | [ProKompetencja.md](ProKompetencja.md) |
| ProMaterialMeldunku | Materiały meldunków | `ProMaterialyM` |  | child: Meldunek→ProMeldunek |  |  |  | [ProMaterialMeldunku.md](ProMaterialMeldunku.md) |
| ProMaterialOperacjiTechnologii | Materiały operacji technologii | `ProMaterialyOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  |  | [ProMaterialOperacjiTechnologii.md](ProMaterialOperacjiTechnologii.md) |
| ProMaterialOperacjiZlecenia | Materiały operacji zleceń | `ProMaterialyOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProMaterialOperacjiZlecenia.md](ProMaterialOperacjiZlecenia.md) |
| ProMeldunek | Meldunki produkcyjne | `ProMeldunki` |  | root |  |  |  | [ProMeldunek.md](ProMeldunek.md) |
| ProNumeracjaMeldunku | Numeracje meldunków | `ProNumeracjeMeld` | konfig | child: Wydzial→ProWydzial |  |  |  | [ProNumeracjaMeldunku.md](ProNumeracjaMeldunku.md) |
| ProNumeracjaTechnologii | Numeracje technologii | `ProNumeracjeTech` | konfig | child: Wydzial→ProWydzial |  |  |  | [ProNumeracjaTechnologii.md](ProNumeracjaTechnologii.md) |
| ProNumeracjaWyrobuMeldunku | Numeracje wyrobów meldunków | `ProNrWyrobowM` |  | child: WyrobMeldunku→ProWyrobMeldunku |  |  |  | [ProNumeracjaWyrobuMeldunku.md](ProNumeracjaWyrobuMeldunku.md) |
| ProNumeracjaZlecenia | Numeracje zleceń | `ProNumeracjeZlec` | konfig | child: Wydzial→ProWydzial |  |  |  | [ProNumeracjaZlecenia.md](ProNumeracjaZlecenia.md) |
| ProOdpadMeldunku | Odpady meldunków | `ProOdpadyM` |  | child: Meldunek→ProMeldunek |  |  |  | [ProOdpadMeldunku.md](ProOdpadMeldunku.md) |
| ProOdpadOperacjiTechnologii | Odpady operacji technologii | `ProOdpadyOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  |  | [ProOdpadOperacjiTechnologii.md](ProOdpadOperacjiTechnologii.md) |
| ProOdpadOperacjiZlecenia | Odpady operacji zleceń | `ProOdpadyOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProOdpadOperacjiZlecenia.md](ProOdpadOperacjiZlecenia.md) |
| ProOperacjaTechnologii | Operacje technologii | `ProOperacjeTech` |  | child: Technologia→ProTechnologia |  |  |  | [ProOperacjaTechnologii.md](ProOperacjaTechnologii.md) |
| ProOperacjaTechnologiiPoprzedzajaca | Operacje technologii poprzedzające | `ProOperacjeTechP` |  | child: Operacja→ProOperacjaTechnologii |  |  |  | [ProOperacjaTechnologiiPoprzedzajaca.md](ProOperacjaTechnologiiPoprzedzajaca.md) |
| ProOperacjaZlecenia | Operacje zleceń | `ProOperacjeZlec` |  | child: Zlecenie→ProZlecenie |  |  |  | [ProOperacjaZlecenia.md](ProOperacjaZlecenia.md) |
| ProOperacjaZleceniaPoprzedzajaca | Operacje zleceń poprzedzające | `ProOperacjeZlecP` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProOperacjaZleceniaPoprzedzajaca.md](ProOperacjaZleceniaPoprzedzajaca.md) |
| ProOsoba | Osoby produkcyjne | `ProOsoby` |  | root |  |  |  | [ProOsoba.md](ProOsoba.md) |
| ProPlanPracy | Plany pracy | `ProPlanyPracy` |  | child: Zasob→ProZasobOperacjiZlecenia |  |  |  | [ProPlanPracy.md](ProPlanPracy.md) |
| ProPozycjaGlownaTechnologii | Główne pozycje technologii | `ProPGlownaT` |  | child: Technologia→ProTechnologia |  |  |  | [ProPozycjaGlownaTechnologii.md](ProPozycjaGlownaTechnologii.md) |
| ProPozycjaKompetencji | Pozycje właściwości | `ProPKompetencji` |  | child: Kompetencja→ProKompetencja |  |  |  | [ProPozycjaKompetencji.md](ProPozycjaKompetencji.md) |
| ProPozycjaZamowienia | Pozycje zamówień | `ProPZamowien` |  | child: Wyrob→ProWyrobOperacjiZlecenia |  |  |  | [ProPozycjaZamowienia.md](ProPozycjaZamowienia.md) |
| ProPozycjaZestawieniaMaterialow | Pozycje zestawień materiałów | `ProPZestawienM` |  | child: Zestawienie→ProZestawienieMaterialow |  |  |  | [ProPozycjaZestawieniaMaterialow.md](ProPozycjaZestawieniaMaterialow.md) |
| ProRelacjaMaterialWyrobOperacjiTechnologii | Relacje materiałów i wyrobów operacji techologii | `ProRMatWyrOT` |  | child: Material→ProMaterialOperacjiTechnologii |  |  |  | [ProRelacjaMaterialWyrobOperacjiTechnologii.md](ProRelacjaMaterialWyrobOperacjiTechnologii.md) |
| ProRelacjaMaterialWyrobOperacjiZlecenia | Relacje materiałów i wyrobów operacji zlecenia | `ProRMatWyrOZ` |  | child: Material→ProMaterialOperacjiZlecenia |  |  |  | [ProRelacjaMaterialWyrobOperacjiZlecenia.md](ProRelacjaMaterialWyrobOperacjiZlecenia.md) |
| ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji | Relacje zasobów operacji technologii i pozycji właściwości | `ProRZasobOTPKomp` |  | child: ZasobOperacjiTechnologii→ProZasobOperacjiTechnologii |  |  |  | [ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji.md](ProRelacjaZasobOperacjiTechnologiiPozycjaKompetencji.md) |
| ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji | Relacje zasobów operacji zleceń i pozycji właściwości | `ProRZasobOZPKomp` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia |  |  |  | [ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji.md](ProRelacjaZasobOperacjiZleceniaPozycjaKompetencji.md) |
| ProRelacjaZasobPozycjaKompetencji | Relacje zasobów i pozycji właściwości | `ProRZasobPKomp` |  | child: Zasob→ProZasob |  |  |  | [ProRelacjaZasobPozycjaKompetencji.md](ProRelacjaZasobPozycjaKompetencji.md) |
| ProRelacjaZasobUrzadzenie | Relacje zasobów i urządzeń | `ProRZasobUrz` |  | child: Zasob→ProZasob |  |  |  | [ProRelacjaZasobUrzadzenie.md](ProRelacjaZasobUrzadzenie.md) |
| ProRozliczenieMaterialu | Rozliczenia materiałów | `ProRozMaterialow` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProRozliczenieMaterialu.md](ProRozliczenieMaterialu.md) |
| ProRozliczenieOdpadu | Rozliczenia odpadów | `ProRozOdpadow` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProRozliczenieOdpadu.md](ProRozliczenieOdpadu.md) |
| ProRozliczenieWyrobu | Rozliczenia wyrobów | `ProRozWyrobow` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProRozliczenieWyrobu.md](ProRozliczenieWyrobu.md) |
| ProRozliczenieZapotrzebowania | Rozliczenia zapotrzebowań | `ProRozZapot` |  | child: MaterialOperacjiZlecenia→ProMaterialOperacjiZlecenia |  |  |  | [ProRozliczenieZapotrzebowania.md](ProRozliczenieZapotrzebowania.md) |
| ProStawka | Stawki produkcyjne | `ProStawki` |  | root |  |  |  | [ProStawka.md](ProStawka.md) |
| ProTechnologia | Technologie produkcyjne | `ProTechnologie` |  | root |  |  |  | [ProTechnologia.md](ProTechnologia.md) |
| ProTechnologiaMaterialuOperacjiTechnologii | Technologie materiałów operacji technologii | `ProTechMatOT` |  | child: Material→ProMaterialOperacjiTechnologii |  |  |  | [ProTechnologiaMaterialuOperacjiTechnologii.md](ProTechnologiaMaterialuOperacjiTechnologii.md) |
| ProTechnologiaMaterialuOperacjiZlecenia | Technologie materiałów operacji zleceń | `ProTechMatOZ` |  | child: Material→ProMaterialOperacjiZlecenia |  |  |  | [ProTechnologiaMaterialuOperacjiZlecenia.md](ProTechnologiaMaterialuOperacjiZlecenia.md) |
| ProTowar | Towary produkcyjne | `ProTowary` |  | child: Towar→Towar |  |  |  | [ProTowar.md](ProTowar.md) |
| ProTowarMeldowanyOperacjiTechnologii | Towary meldowane operacji technologii | `ProTowaryMeldOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  |  | [ProTowarMeldowanyOperacjiTechnologii.md](ProTowarMeldowanyOperacjiTechnologii.md) |
| ProTowarMeldowanyOperacjiZlecenia | Towary meldowane operacji zleceń | `ProTowaryMeldOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProTowarMeldowanyOperacjiZlecenia.md](ProTowarMeldowanyOperacjiZlecenia.md) |
| ProUslugaMeldunku | Usługi meldunków | `ProUslugiM` |  | child: Meldunek→ProMeldunek |  |  |  | [ProUslugaMeldunku.md](ProUslugaMeldunku.md) |
| ProUslugaOperacjiTechnologii | Usługi operacji technologii | `ProUslugiOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  |  | [ProUslugaOperacjiTechnologii.md](ProUslugaOperacjiTechnologii.md) |
| ProUslugaOperacjiZlecenia | Usługi operacji zleceń | `ProUslugiOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProUslugaOperacjiZlecenia.md](ProUslugaOperacjiZlecenia.md) |
| ProUzytkownikPaneluMeldunkowego | Użytkownicy paneli meldunkowych | `ProUzytkownicyPM` | konfig | root |  | IWebOperator, ITaskUser |  | [ProUzytkownikPaneluMeldunkowego.md](ProUzytkownikPaneluMeldunkowego.md) |
| ProWariantowoscZasobu | Wariantowość zasobów produkcyjnych | `ProWarZasobow` |  | child: Zasob→ProZasob |  |  |  | [ProWariantowoscZasobu.md](ProWariantowoscZasobu.md) |
| ProWariantowoscZasobuOperacjiTechnologii | Wariantowość zasobów operacji technologii | `ProWarZasobowOT` |  | child: ZasobOperacjiTechnologii→ProZasobOperacjiTechnologii |  |  |  | [ProWariantowoscZasobuOperacjiTechnologii.md](ProWariantowoscZasobuOperacjiTechnologii.md) |
| ProWariantowoscZasobuOperacjiZlecenia | Wariantowość zasobów operacji zlecenia | `ProWarZasobowOZ` |  | child: ZasobOperacjiZlecenia→ProZasobOperacjiZlecenia |  |  |  | [ProWariantowoscZasobuOperacjiZlecenia.md](ProWariantowoscZasobuOperacjiZlecenia.md) |
| ProWydzial | Wydziały produkcyjne | `ProWydzialy` | konfig | root |  | IRightsSource, IElementSlownika |  | [ProWydzial.md](ProWydzial.md) |
| ProWyrobMeldunku | Wyroby meldunków | `ProWyrobyM` |  | child: Meldunek→ProMeldunek |  |  |  | [ProWyrobMeldunku.md](ProWyrobMeldunku.md) |
| ProWyrobOperacjiTechnologii | Wyroby operacji technologii | `ProWyrobyOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  |  | [ProWyrobOperacjiTechnologii.md](ProWyrobOperacjiTechnologii.md) |
| ProWyrobOperacjiZlecenia | Wyroby operacji zleceń | `ProWyrobyOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProWyrobOperacjiZlecenia.md](ProWyrobOperacjiZlecenia.md) |
| ProZasob | Zasoby produkcyjne | `ProZasoby` |  | root |  | IElementSlownika |  | [ProZasob.md](ProZasob.md) |
| ProZasobMeldunku | Zasoby meldunków | `ProZasobyM` |  | child: Meldunek→ProMeldunek |  |  |  | [ProZasobMeldunku.md](ProZasobMeldunku.md) |
| ProZasobOperacjiTechnologii | Zasoby operacji technologii | `ProZasobyOT` |  | child: Operacja→IProOperacjaWzorcowa |  |  |  | [ProZasobOperacjiTechnologii.md](ProZasobOperacjiTechnologii.md) |
| ProZasobOperacjiZlecenia | Zasoby operacji zleceń | `ProZasobyOZ` |  | child: Operacja→ProOperacjaZlecenia |  |  |  | [ProZasobOperacjiZlecenia.md](ProZasobOperacjiZlecenia.md) |
| ProZestawienieMaterialow | Zestawienia materiałów | `ProZestawieniaM` |  | root |  |  |  | [ProZestawienieMaterialow.md](ProZestawienieMaterialow.md) |
| ProZlecenie | Zlecenia produkcyjne | `ProZlecenia` |  | root |  | IElementSlownika |  | [ProZlecenie.md](ProZlecenie.md) |

