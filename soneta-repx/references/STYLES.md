# Arkusze stylów `.repss`

Referencja uzupełniająca [../SKILL.md](../SKILL.md). Dotyczy platformy Soneta (enova365, Triva).
Arkusz `.repss` to **osobny plik XML z nazwanymi stylami** (DevExpress StyleSheet). Raport nie
duplikuje formatowania w każdej kontrolce — kontrolki wskazują styl **po nazwie** (`StyleName`),
a definicja stylu (czcionka, obramowanie, tło, wyrównanie) mieszka centralnie w `.repss`. Zmiana
wyglądu wszystkich wydruków = edycja jednego arkusza.

## Minimalny plik `.repss`

```xml
<?xml version="1.0" encoding="utf-8"?>
<StyleSheetSerializer SerializerVersion="20.2.7.0" FileName="">
  <Styles>
    <Item1 Name="StandardowyStyl" BorderStyle="Inset" Font="Calibri, 9pt, charSet=238"
           StringFormat="Near;Near;0;None;Character;Default" />
    <Item2 Name="ListaNaglowekStyl" BorderStyle="Inset" Padding="5,5,0,0,254"
           Font="Calibri, 8.25pt, style=Bold, charSet=238" BorderColor="Silver" Sides="All"
           StringFormat="Center;Center;0;None;Character;Default" TextAlignment="MiddleCenter" />
    <Item3 Name="ListaGrupowanieStyl" BorderStyle="Inset" Padding="5,5,0,0,254"
           Font="Calibri, 8.25pt, style=Bold, charSet=238" BackColor="LightGray" BorderColor="Silver"
           Sides="Left, Right, Bottom" StringFormat="Near;Center;0;None;Character;Default" TextAlignment="MiddleLeft" />
  </Styles>
</StyleSheetSerializer>
```

## 3 rzeczy, które musisz wiedzieć

1. **Korzeń to `StyleSheetSerializer`**, nie `XtraReportsLayoutSerializer`. Zawiera jedną sekcję
   `<Styles>`; każdy styl to `ItemN` z **`Name`** (klucz odwołania) i zestawem właściwości wyglądu.
   Style **nie** mają `Ref` — wiązanie jest po `Name`, nie przez `#Ref-N`.
2. **Potrójne wpięcie w raport** (w praktyce wszystkie trzy naraz):
   - `StyleSheetPath="standardowy"` na `<XtraReportsLayoutSerializer>` — logiczna nazwa arkusza,
   - `StylesSource="standardowy"` na komponencie `BusinessContext` w `ComponentStorage`,
   - `StyleName="StandardowyStyl"` na **każdej** kontrolce/paśmie, która ma brać wygląd ze stylu.
   `"standardowy"` to nazwa logiczna arkusza w konfiguracji (nie nazwa pliku) — zob.
   [SUBREPORTS.md](SUBREPORTS.md) → mechanizm luźnego wiązania.
3. **`StylePriority Use*="false"` na kontrolce = „bierz tę właściwość ze stylu”.** Bez tego lokalna
   wartość (`Font`, `Borders`…) nadpisuje styl. Zob. [CONTROLS.md](CONTROLS.md) → `StylePriority`.

## Właściwości stylu

| Atrybut | Format / znaczenie |
|---|---|
| `Name` | **Klucz stylu** — na tę wartość wskazuje `StyleName` kontrolki. |
| `Font` | `nazwa, rozmiarpt[, style=Bold/Italic][, charSet=238]`. `charSet=238` = Europa Środkowa (polskie znaki). |
| `BorderStyle` | Styl krawędzi, produkcyjnie `Inset`. |
| `Sides` | Które krawędzie rysować: `None`, `All`, lub lista `Left, Right, Bottom` (dowolna kombinacja). |
| `BorderColor` | Kolor krawędzi (nazwa .NET Color, np. `Silver`, `LightGray`). |
| `BackColor` | Tło (np. `LightGray`, `WhiteSmoke`, `Gainsboro`). |
| `Padding` | `lewy,prawy,górny,dolny,dpi` (ostatnia liczba = DPI odniesienia, `254`). |
| `TextAlignment` | `MiddleLeft`, `MiddleCenter`, `MiddleRight`, `TopRight`… |
| `StringFormat` | Zaawansowane wyrównanie/łamanie tekstu — patrz niżej. |

### `StringFormat` — składnia pozycyjna

Sześć pól rozdzielonych `;`: `Alignment;LineAlignment;Trimming;FormatFlags;HotkeyPrefix;DigitSubstitution`.
Typowe wartości:

| Wartość | Znaczenie |
|---|---|
| `Near;Near;0;None;Character;Default` | Do lewej / do góry — domyślny tekst. |
| `Center;Center;0;None;Character;Default` | Wyśrodkowany w pionie i poziomie (nagłówki kolumn). |
| `Near;Center;0;None;Character;Default` | Do lewej, wyśrodkowany pionowo (wiersze list). |
| `Far;Near;0;None;Character;Default` | Do prawej (numer strony, kwoty). |

## Katalog nazwanych stylów (słownik `StyleName`)

Standardowy arkusz definiuje stały zestaw nazw — używaj ich w `StyleName`, zamiast wymyślać własne
(spójność z wydrukami systemowymi i z nagłówkami/stopkami):

| Grupa | Style |
|---|---|
| **Listy** | `ListaNaglowekStyl` (nagłówek kolumn), `ListaWierszParzysteStyl` / `ListaWierszNieparzysteStyl` (naprzemienne wiersze), `ListaGrupowanieStyl` (nagłówek grupy, tło), `ListaStopkaStyl` (podsumowanie), `ListaWyroznienieStyl`, `ListaTylkoKrawedzieBoczneStyl`, `ListaStylAutomatyczny` (styl „pusty” — kontener bez własnego formatowania). |
| **Nagłówki** | `NaglowekTytulStyl`, `NaglowekWyroznienieStyl`, `NaglowekPieczatkaStyl`, `NaglowekSzczegolyStyl`. |
| **Stopki** | `StopkaSzczegolyStyl`, `StopkaSzczegolyWyroznioneStyl`, `StopkaDodatkoweStyl`, `StopkaPodpisStyl`, `NumerStronyStyl`. |
| **Tekst / dokumenty** | `TekstPodstawowyStyl` (+ `…WyroznienieStyl`), `TekstTytulStyl`, `TekstPomocniczyStyl` (+ `…WyroznienieStyl`), `TekstPrzypisStyl`, `TekstPouczenieStyl`, `TekstNumerowaniePoziom1Styl` / `…2Styl` / `…3Styl` (wcięcia przez rosnący `Padding`). |

## Warianty arkusza — `standardowy`, `standardowy2`, `standardowy3`

Ten sam zestaw **nazw** stylów występuje w kilku wariantach różniących się wyłącznie wyglądem
(kolor tła grupowania, obecność bocznych krawędzi w liście). Dzięki jednakowym nazwom raport można
przełączyć między wariantami zmieniając samo `StylesSource`/`StyleSheetPath` — bez ruszania kontrolek.
Różnice dotyczą m.in.: `ListaGrupowanieStyl` (`LightGray` ↔ `WhiteSmoke` ↔ `Gainsboro`), `Sides`
wierszy listy (`Left, Right, Bottom` ↔ samo `Bottom`), krawędzi `StopkaPodpisStyl`/`ListaNaglowekStyl`.

## Checklista arkusza `.repss`

- [ ] Korzeń `StyleSheetSerializer` z jedną sekcją `<Styles>`; style jako `Item1..ItemN`.
- [ ] Każdy styl ma unikalną `Name` (bez `Ref` — wiązanie po nazwie).
- [ ] `Font` z `charSet=238`, gdy tekst zawiera polskie znaki.
- [ ] Kontrolki w raporcie odwołują się do istniejących nazw przez `StyleName` + `StylePriority Use*="false"`.
- [ ] Raport ma `StyleSheetPath` i/lub `BusinessContext StylesSource` wskazujące ten arkusz.
- [ ] Plik `.repss` leży w katalogu `Repx/` dodatku (osadzany automatycznie) → [REGISTRATION.md](REGISTRATION.md).

## Powiązane

- [SUBREPORTS.md](SUBREPORTS.md) — nagłówki/stopki intensywnie używają tych stylów; mechanizm nazw logicznych.
- [CONTROLS.md](CONTROLS.md) — `StyleName`, `StylePriority` na kontrolce.
- [STRUCTURE-BANDS.md](STRUCTURE-BANDS.md) — `StyleName` na paśmie, atrybut `StyleSheetPath` raportu.
- [REGISTRATION.md](REGISTRATION.md) — osadzanie `.repss`, centralne zarządzanie stylami w bazie.
