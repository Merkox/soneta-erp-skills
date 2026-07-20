# Struktura pliku i pasma (Bands)

Referencja uzupełniająca [../SKILL.md](../SKILL.md). Dotyczy platformy Soneta (enova365, Triva).

## Element główny `XtraReportsLayoutSerializer`

Korzeń pliku. Każdy węzeł potomny nazywa się `Item1..ItemN`, ma `Ref="N"` (identyfikator
referencyjny) i `ControlType` (klasa .NET). Odwołania krzyżowe zapisywane są jako `#Ref-N`.

```xml
<XtraReportsLayoutSerializer SerializerVersion="20.2.7.0" Ref="1"
    ControlType="DevExpress.XtraReports.UI.XtraReport, DevExpress.XtraReports.v20.2"
    Name="RotacjaTowarow" DisplayName="Raport rotacji" SnapGridSize="25"
    ReportUnit="TenthsOfAMillimeter" Margins="198, 198, 200, 200"
    PaperKind="A4" PageWidth="2100" PageHeight="2970"
    Version="20.2" DataSource="#Ref-0" Dpi="254" Font="Calibri, 9pt">
```

| Atrybut | Znaczenie |
|---|---|
| `ControlType` | Klasa bazowa raportu. **Produkcyjnie:** `DevExpress.XtraReports.UI.XtraReport, DevExpress.XtraReports.v20.2` (czysty XtraReport, logika w osobnym snippet). Rzadziej: własna klasa `Nazwa, Assembly` (raport = klasa C#). |
| `Name` | Nazwa techniczna. |
| `DisplayName` | Nazwa prezentowana użytkownikowi na liście wydruków. |
| `PaperKind` | Rozmiar papieru — w praktyce zawsze `A4`. |
| `PageWidth` / `PageHeight` | Wymiary strony w jednostkach `ReportUnit`. |
| `Margins` | `lewy, prawy, górny, dolny` w jednostkach `ReportUnit`. |
| `ReportUnit` | Jednostka miary — patrz niżej. |
| `Dpi` | Rozdzielczość odniesienia; `254` idzie w parze z `TenthsOfAMillimeter`. |
| `Font` | Domyślna czcionka, np. `Calibri, 9pt`. |
| `Version` | Wersja formatu serializera (`20.2`) — metadana, nie zmieniaj. |
| `DataSource` | `#Ref-N` → komponent źródła danych w `ComponentStorage`. |
| `FilterString` | Filtr wierszy (składnia DevExpress) — zwykle filtruje się po stronie źródła, patrz [DATA.md](DATA.md). |
| `Landscape` | `true` = orientacja pozioma; brak = pionowa. |
| `SnapGridSize` | Skok siatki projektanta (bez wpływu na wydruk). |

### Jednostki: `ReportUnit` + `Dpi`

Zawsze trzymaj obie wartości spójnie, bo te same liczby znaczą różne rozmiary:

| Konfiguracja | Jednostka | A4 | Marginesy ~20 mm | Zastosowanie |
|---|---|---|---|---|
| `ReportUnit="TenthsOfAMillimeter"` + `Dpi="254"` | 0,1 mm | `2100×2970` | `200` | **Standard produkcyjny** — wymiary niezależne od DPI ekranu. |
| brak `ReportUnit` (domyślnie piksele) + `Dpi="96"` | 1/96 cala | `827×1169` | `76` | Proste/starsze szablony. |

`254 = 10 × 25,4` → 1 jednostka `TenthsOfAMillimeter` = 1 piksel przy 254 dpi = 0,1 mm.
Wszystkie `SizeF`, `LocationFloat`, `HeightF`, `Padding` dziedziczą tę jednostkę.

## Pasma (Bands)

Sekcja `<Bands>` zawiera pasma w kolejności `ItemN`. Rola każdego:

| ControlType | Rola | Krotność |
|---|---|---|
| `TopMarginBand` | Górny margines strony. | 1 (obowiązkowe) |
| `BottomMarginBand` | Dolny margines strony. | 1 (obowiązkowe) |
| `DetailBand` | Powtarzane raz na każdy rekord bieżącego poziomu danych. | ≥1 |
| `DetailReportBand` | Poziom master-detail: zagnieżdżony raport iterujący po kolekcji. | 0..n |
| `GroupHeaderBand` | Nagłówek grupy — przed grupą rekordów o wspólnej wartości `GroupFields`. | 0..n |
| `GroupFooterBand` | Stopka grupy — po grupie; typowe miejsce na podsumowania. | 0..n |
| `ReportHeaderBand` | Nagłówek raportu — raz na początku całości. | 0..1 |
| `ReportFooterBand` | Stopka raportu — raz na końcu całości. | 0..1 |
| `PageHeaderBand` | Nagłówek strony — na górze każdej strony. | 0..1 |
| `PageFooterBand` | Stopka strony — na dole każdej strony. | 0..1 |
| `SubBand` | Dodatkowe podpasmo dołączone do innego pasma (np. druga linia detalu). | 0..n |

### Kluczowe atrybuty pasm

| Atrybut | Znaczenie |
|---|---|
| `HeightF` | Wysokość pasma (w jednostkach `ReportUnit`). |
| `Level` | Poziom zagnieżdżenia `DetailReportBand`, np. `Level="0"`. |
| `DataSource` | `#Ref-N` — źródło danych pasma (dla `DetailReportBand`). |
| `DataMember` | Dla `DetailReportBand`: nazwa kolekcji do iteracji, np. `Pozycje`, `This`. |
| `RepeatEveryPage` | `true` → pasmo (np. nagłówek listy) powtarza się na każdej stronie. |
| `KeepTogether` | `true` → pasmo nie jest dzielone między strony. |
| `PrintAtBottom` | `true` → stopka drukowana przy dole strony. |
| `GroupUnion` | Trzymanie grupy razem: `WithFirstDetail`, `WithLastDetail`, `WholePage`. |
| `StyleName` | Nazwa stylu z arkusza (`.repss`), np. `ListaStylAutomatyczny`, `NaglowekTytulStyl`. |
| `PageBreak` | `BeforeBand` / `AfterBand` / `AfterBandExceptLastEntry` — wymuszenie podziału strony. |

## Master-detail — zagnieżdżony `DetailReportBand`

Soneta **nie** używa `XRSubreport`. Relację jeden-do-wielu buduje się przez `DetailReportBand`
z atrybutem `DataMember` wskazującym **kolekcję podrzędną** wiersza pasma nadrzędnego. Pasmo ma
własną, zagnieżdżoną sekcję `<Bands>`.

```xml
<!-- poziom nagłówka dokumentu: pola bindowane do właściwości dokumentu -->
<Item2 Ref="3" ControlType="DetailBand" Name="naglowek" HeightF="300" Dpi="254">
  <Controls>
    <Item1 Ref="4" ControlType="XRLabel" Text="[Numer.NumerPelny]" SizeF="800,60" LocationFloat="0,0" Dpi="254" />
    <Item2 Ref="5" ControlType="XRLabel" Text="[Kontrahent.Nazwa]" SizeF="800,60" LocationFloat="0,70" Dpi="254" />
  </Controls>
</Item2>

<!-- poziom pozycji: iteracja po kolekcji Pozycje bieżącego dokumentu -->
<Item3 Ref="6" ControlType="DetailReportBand" Name="pozycje" Level="0"
       DataMember="Pozycje" DataSource="#Ref-0" Dpi="254">
  <Bands>
    <Item1 Ref="7" ControlType="DetailBand" Name="pozycjaWiersz" HeightF="60" Dpi="254">
      <Controls>
        <Item1 Ref="8" ControlType="XRTableCell" Text="[Towar.Nazwa]" .../>
        <Item2 Ref="9" ControlType="XRTableCell" Text="[Ilosc]" TextFormatString="{0:n2}" .../>
      </Controls>
    </Item1>
  </Bands>
</Item3>
```

Zasady:
- `DataSource` całego raportu i `DetailReportBand` może wskazywać **ten sam** `#Ref-0`
  (`CurrentList`) — różnicuje je `DataMember` (relacja master → child po nazwie kolekcji).
- W paśmie podrzędnym pola bindujesz **względem elementu kolekcji** (`[Ilosc]`, `[Towar.Nazwa]`).
- Zagnieżdżenia mogą być wielopoziomowe: `DetailReportBand DataMember="This"` (poziom 1) →
  wewnątrz `DetailReportBand DataMember="Ceny"` (poziom 2). `DataMember="This"` oznacza „bieżący
  wiersz bez nawigacji".
- Częsty wzorzec produkcyjny: **dwa** `BusinessDataSource` — root raportu na `Context`
  (nagłówek/parametry), a `DetailReportBand` na osobnym `CurrentList` (właściwa lista). Zob.
  [DATA.md](DATA.md).

## Grupowanie

Grupę definiuje `GroupHeaderBand` z podelementem `<GroupFields>` (dziecko `Item` z `FieldName`
i opcjonalnym `SortOrder`). Sortowanie detali — `<SortFields>` na `DetailBand`.

```xml
<Item2 Ref="33" ControlType="GroupHeaderBand" Name="naglowekGrupy"
       RepeatEveryPage="true" HeightF="60" KeepTogether="true" Dpi="254" StyleName="ListaStylAutomatyczny">
  <GroupFields>
    <Item1 Ref="34" FieldName="Definicja" SortOrder="Ascending" />
  </GroupFields>
  <Controls>
    <!-- nagłówek grupy może odwołać się do pola grupującego inline w Text -->
    <Item1 Ref="35" ControlType="XRLabel" Text="Definicja: [Definicja]" SizeF="800,60" LocationFloat="0,0" Dpi="254" />
  </Controls>
</Item2>
```

`SortOrder`: `Ascending` / `Descending` / `None`. `FieldName` może nawigować po relacjach:
`Konto.Symbol`, `Dokument.Podmiot.Kod`. Podsumowania grupy umieszcza się w `GroupFooterBand`
(patrz [DATA.md](DATA.md) → Podsumowania).

## `ComponentStorage`

Kontener niewizualnych komponentów, na końcu pliku. Przechowuje instancje `BusinessDataSource`,
`BusinessContext`, `ReportSnippetComponent` — każda z `Ref="N"` (cel referencji `#Ref-N`),
`ObjectType` (pełna nazwa typu + assembly) i `Name`. Szczegóły źródeł danych → [DATA.md](DATA.md),
komponent snippet → [REGISTRATION.md](REGISTRATION.md).

```xml
<ComponentStorage>
  <Item1 Ref="49" ObjectType="Soneta.Business.UI.DxReports.Components.BusinessContext,Soneta.Business.UI.DxReports"
         Name="BusinessContext" StylesSource="standardowy" TreatStringAsValueInExport="false" />
  <Item2 Ref="5"  ObjectType="Soneta.Business.UI.DxReports.BusinessDataSource,Soneta.Business.UI.DxReports"
         Name="BusinessSource"        DataKind="CurrentList" />
  <Item3 Ref="0"  ObjectType="Soneta.Business.UI.DxReports.BusinessDataSource,Soneta.Business.UI.DxReports"
         Name="BusinessSourceContext" DataKind="Context" />
</ComponentStorage>
```
