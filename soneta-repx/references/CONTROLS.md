# Kontrolki raportu (Controls)

Referencja uzupełniająca [../SKILL.md](../SKILL.md). Dotyczy platformy Soneta (enova365, Triva).
Kontrolki umieszcza się w sekcji `<Controls>` pasma. Każda ma `Ref`, `ControlType`, `Name`,
`SizeF`, `LocationFloat`.

## Zasada nadrzędna: preferuj układ tabelaryczny

W praktyce produkcyjnej dominuje `XRTable` (dziesiątki tysięcy komórek vs pojedyncze etykiety).
Luźnych `XRLabel` używaj do tytułów i pojedynczych pól nagłówka; listy i wiersze danych buduj
tabelą. Kwoty zawsze przez `AmountLabel` (kontrolka Soneta), nie `XRLabel`.

## Kontrolki standardowe DevExpress (`XR*`)

| ControlType | Do czego |
|---|---|
| `XRTable` → `XRTableRow` → `XRTableCell` | Tabela — podstawowy budulec list i wierszy. |
| `XRLabel` | Pojedyncza etykieta / tytuł / pole. |
| `XRRichText` | Tekst sformatowany RTF (atrybut `SerializableRtfString`, base64). |
| `XRLine` | Linia (rozdzielacz). |
| `XRPictureBox` | Obraz inline (`ImageSource="img,<base64>"`). |
| `XRBarCode` | Kod kreskowy (`Symbology`, `Module`). |
| `XRCharacterComb` | Siatka pojedynczych znaków — NIP/PESEL/rachunek na deklaracjach (`CellWidth`, `CellHeight`). |
| `XRPageBreak` | Wymuszony podział strony. |
| `XRPageInfo` | Numer strony / data / „strona X z Y". |
| `XRPanel` | Kontener grupujący kontrolki. |
| `XRShape` | Kształt geometryczny. |

## Kontrolki własne Soneta

Osadzane tak samo jak `XR*`, ale z pełnym `ControlType` `Nazwa, Soneta.Business.UI.DxReports`.
**Stanowią większość kontrolek w raportach produkcyjnych.**

| Kontrolka (skrót typu) | Zastępuje | Do czego / kluczowe atrybuty |
|---|---|---|
| `Controls.AmountLabel` | XRLabel | **Kwoty.** `SpacingForComma` (wyrównanie części dziesiętnej), obsługa formatu kwot. |
| `Controls.ShrinkableLabel` | XRLabel | Tekst zmniejszający czcionkę, by się zmieścić. `MaxLenght`, `Multiline`. |
| `Controls.CrossCheckBox` | XRCheckBox | Pole wyboru krzyżykiem (deklaracje). |
| `Controls.ResourcePictureBox` | XRPictureBox | Obraz z zasobu osadzonego (`ImageResourceName="Assembly\ścieżka.jpg"`, `Sizing`). |
| `Controls.Header` | podraport | Szablonowy nagłówek strony: `ReportSourceName`, `Title`, `FiltersDescription`. |
| `Controls.Footer` | podraport | Szablonowa stopka strony: `ReportSourceName`, `RunningBand`. |
| `Controls.DatabaseSubReport` | XRSubreport | Podraport zdefiniowany w bazie: `ReportSourceName`. |

> Soneta **nie** używa `XRSubreport`, `XRCheckBox` ani `XRZipCode` — zastępują je powyższe
> kontrolki oraz zagnieżdżone `DetailReportBand` (master-detail, patrz [STRUCTURE-BANDS.md](STRUCTURE-BANDS.md)).

### Nagłówek / stopka jako podraport szablonowy

Zamiast rysować nagłówek ręcznie, wstawia się kontrolkę `Header`/`Footer` wskazującą nazwany
szablon w bazie (`ReportSourceName`), np. `"nagłówek - lista"`, `"stopka"`:

```xml
<Item1 Ref="28" ControlType="Soneta.Business.UI.DxReports.Controls.Header, Soneta.Business.UI.DxReports"
       Name="naglowekStrony" ReportSourceName="nagłówek - lista" Title="Rotacja towarów"
       SizeF="1701.8,50" LocationFloat="0,0" Dpi="254" />

<Item1 Ref="30" ControlType="Soneta.Business.UI.DxReports.Controls.Footer, Soneta.Business.UI.DxReports"
       Name="stopkaStrony" ReportSourceName="stopka" RunningBand="GroupHeader1"
       SizeF="1700,52" LocationFloat="0,0" Dpi="254" />
```

Typowo umieszcza się je w `GroupHeaderBand`/`GroupFooterBand` z `RepeatEveryPage="true"`.
`Title` to tytuł drukowany w nagłówku; `FiltersDescription` opisuje filtry (widoczne w nagłówku).

## `XRLabel` / `AmountLabel` — atrybuty

```xml
<Item1 Ref="3" ControlType="XRLabel" Name="tytul" Text="Kontrahenci"
       SizeF="3968,556" LocationFloat="0,343" Font="Times New Roman, 26pt"
       TextAlignment="MiddleLeft" Dpi="254" Padding="20,20,0,0,254">
  <StylePriority Ref="4" UseFont="false" />
</Item1>

<Item2 Ref="5" ControlType="Soneta.Business.UI.DxReports.Controls.AmountLabel, Soneta.Business.UI.DxReports"
       Name="kwota" SpacingForComma="4" CanGrow="false" Text="[D.KwotaPodatku]"
       TextAlignment="MiddleRight" SizeF="2524,202" LocationFloat="4915,18862"
       Font="Arial, 12pt, style=Bold" ForeColor="DarkBlue" Dpi="254" Padding="20,20,0,0,254" />
```

| Atrybut | Format / znaczenie |
|---|---|
| `SizeF` | `szerokość,wysokość` w jednostkach `ReportUnit`. |
| `LocationFloat` | `x,y` — lewy-górny róg względem pasma. |
| `Padding` | `lewy,prawy,górny,dolny,dpi` — ostatnia liczba to DPI odniesienia. |
| `Font` | `nazwa, rozmiarpt[, style=Bold/Italic]`. |
| `TextAlignment` | `MiddleLeft`, `MiddleCenter`, `MiddleRight` (kwoty!), `TopLeft`, … |
| `Multiline` | `true` → tekst wielolinijkowy. |
| `CanGrow` | `true` → wysokość rośnie do zawartości. |
| `WordWrap` | Zawijanie słów. |
| `Angle` | Obrót tekstu w stopniach. |
| `ForeColor` / `BackColor` | Kolory (nazwy .NET Color lub `#RRGGBB`). |
| `Text` | Tekst statyczny **lub** wyrażenie inline `[Pole]`. |

`StylePriority` z `Use*="false"` = „nie nadpisuj tej właściwości, bierz ze stylu nazwanego"
(`StyleName`). Dzięki temu formatowanie jest centralne (arkusz `.repss`), a nie duplikowane.
Nazwane style i ich katalog → [STYLES.md](STYLES.md).

## Atrybuty rozmieszczenia, obramowania i zachowania

Występują na większości kontrolek i komórek tabeli (obok `SizeF`/`LocationFloat`):

| Atrybut | Znaczenie |
|---|---|
| `CanShrink` | `true` → kontrolka/wiersz kurczy wysokość, gdy treść krótsza (częste w nagłówkach). |
| `CanGrow` | `true` → rośnie do treści. |
| `ProcessNullValues` | `SuppressAndShrink` → ukryj i zwiń, gdy wartość pusta (chowanie pustych wierszy dokumentu). |
| `Visible` | `false` → element niedrukowany (bandy, wiersze, kontrolki); często przełączany w snippecie. |
| `AnchorHorizontal` | `Left` / `Right` / `Both` — zakotwiczenie przy zmianie szerokości strony. |
| `AnchorVertical` | `Top` / `Bottom` / `Both` — zakotwiczenie pionowe (np. w `XRPanel`). |
| `Borders` | Które krawędzie rysować: `None`, `All`, lista `Right, Bottom` / `Left, Bottom`. |
| `BorderColor` / `BorderWidth` | Kolor / grubość krawędzi (gdy nie ze stylu). |
| `AutoWidth` | `true` → szerokość etykiety dopasowana do tekstu. |
| `WordWrap` | `false` → tekst bez zawijania. |
| `RightToLeft` | `No` / `Yes` — kierunek tekstu. |
| `KeepTogether` | `true` na wierszu/komórce → nie dziel między strony. |

## Kod kreskowy, tekst RTF, linia

```xml
<!-- XRBarCode: typ kodu w podelemencie <Symbology>, dane przez DataBindings/ExpressionBindings -->
<Item Ref="18" ControlType="XRBarCode" Name="barCode" Module="5" AutoModule="true" ShowText="false"
      SizeF="762,87" LocationFloat="5,5" Dpi="254">
  <Symbology Ref="19" Name="Code128" />
  <DataBindings>
    <Item Ref="20" PropertyName="Text" DataMember="Numer" />
  </DataBindings>
</Item>

<!-- XRRichText: treść RTF w SerializableRtfString (base64) LUB wiązana do właściwości Rtf -->
<Item Ref="26" ControlType="XRRichText" Name="richText1" SerializableRtfString="ewBc...(base64)"
      SizeF="824,64" LocationFloat="4,0" Dpi="254" StyleName="NaglowekTytulStyl" Font="Times New Roman, 9.75pt">
  <DataBindings>
    <Item Ref="27" PropertyName="Rtf" DataMember="ReportContext.Title" />
  </DataBindings>
</Item>

<!-- XRLine: linia (np. miejsce na podpis) -->
<Item Ref="34" ControlType="XRLine" Name="line1" LineStyle="Dot" SizeF="339,5" LocationFloat="484,21" Dpi="254" />
```

- **`XRBarCode`**: `Symbology Name` = symbolika (`Code128`, `Code39`, `QRCode`, `DataMatrix`);
  `Module`/`AutoModule` = szerokość kreski, `ShowText="false"` = bez podpisu. Symbolikę można też
  ustawić w snippecie (`barCode.Symbology = new …Generator()`).
- **`XRRichText`**: statyczny RTF trzymany jako base64 w `SerializableRtfString`; treść dynamiczna —
  wiązanie `PropertyName="Rtf"` (np. do `ReportContext.*`, zob. [SUBREPORTS.md](SUBREPORTS.md)).
- **`XRLine`**: `LineStyle` = `Solid`/`Dot`/`Dash`.

Kontrolki `Header`/`Footer`/`DatabaseSubReport` (nagłówek/stopka/podraport szablonowy) — poniżej;
**budowa** samych plików nagłówka/stopki/podraportu → [SUBREPORTS.md](SUBREPORTS.md).

## `XRTable` — struktura i szerokości

Hierarchia `XRTable` → `<Rows>` → `XRTableRow` → `<Cells>` → `XRTableCell`. Szerokości kolumn
i wysokości wierszy ustawia się **względnie** atrybutem `Weight`.

```xml
<Item1 Ref="9" ControlType="XRTable" Name="tabela" AnchorHorizontal="Both"
       SizeF="1701.8,60" LocationFloat="0,0" Dpi="254">
  <Rows>
    <Item1 Ref="10" ControlType="XRTableRow" Name="wiersz1" Weight="1" Dpi="254">
      <Cells>
        <Item1 Ref="11" ControlType="XRTableCell" Name="cLp" Weight="0.05"
               Text="Lp." TextAlignment="MiddleRight" Dpi="254">
          <Summary Ref="12" Running="Report" Func="RecordNumber" />
        </Item1>
        <Item2 Ref="13" ControlType="XRTableCell" Name="cKod" Weight="0.20"
               Text="[Kod]" TextAlignment="MiddleLeft" Dpi="254" />
        <Item3 Ref="14" ControlType="XRTableCell" Name="cWartosc" Weight="0.25"
               Text="[Wartosc]" TextAlignment="MiddleRight" TextFormatString="{0:n2}" Dpi="254" />
      </Cells>
    </Item1>
  </Rows>
</Item1>
```

Zasady:
- Szerokość kolumny = `Weight` komórki ÷ suma `Weight` w wierszu × szerokość tabeli (`SizeF.x`).
  Wartości `Weight` są proporcjonalne (mogą być ułamkowe).
- Wysokość wiersza analogicznie z `Weight` na `XRTableRow`.
- Dane wiąże się **na poziomie komórki** — inline `Text="[Pole]"` + `TextFormatString`, albo
  `ExpressionBindings` (patrz [DATA.md](DATA.md)).
- `AnchorHorizontal="Both"` rozciąga tabelę przy zmianie szerokości strony.
- Numerację Lp. daje `<Summary Func="RecordNumber" Running="Report/Group" />`.

## `XRCharacterComb` — pola znakowe deklaracji

Siatka komórek na pojedyncze znaki (NIP, PESEL, numer rachunku) — typowe w wydrukach deklaracji
nakładanych na wzór urzędowy:

```xml
<Item1 Ref="20" ControlType="XRCharacterComb" Name="nip" CellWidth="63.5" CellHeight="63.5"
       Borders="None" Multiline="true" Text="[Firma.NIP]" SizeF="630,57" LocationFloat="217,159"
       Dpi="254" Font="Arial, 9.3pt, style=Bold" ForeColor="DarkBlue" />
```

Tłem takich deklaracji bywa `ResourcePictureBox` z zeskanowanym wzorem formularza
(`ImageResourceName`, `Sizing="StretchImage"`), a wartości nakłada się kontrolkami pozycjonowanymi
bezwzględnie.

## Formaty `TextFormatString` / `FormatString`

W komórce tabeli i inline format podaje się przez `TextFormatString`; w `DataBindings` przez
`FormatString`. Najczęstsze (kultura PL):

| Format | Efekt |
|---|---|
| `{0:n}` | Liczba, separator tysięcy, 2 miejsca. |
| `{0:n2}` / `{0:n0}` | Liczba z dokładnie 2 / 0 miejscami. |
| `{0:d}` | Data krótka. |
| `{0:dd.MM.yyyy}` / `{0:ddMMyyyy}` | Data w jawnym formacie. |
| `{0:yyyy}` / `{0:MM}` / `{0:dd}` | Fragment daty. |
| `{0:0%}` | Procent. |
| `{0:c}` | Waluta. |
| `{0:n2} PLN` / `{0:n2} %` | Liczba z doklejoną jednostką. |
| `{0:#,###0.00;-#,###0.00;""}` | Format z sekcją dla wartości ujemnej i pustą dla zera. |
