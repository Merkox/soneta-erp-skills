# Moduł `EwidencjaVat` — tabele biznesowe

- Opis: Moduł ewidencji VAT. Zawiera rejestry VAT zakupu i sprzedaży, deklaracje VAT, pliki JPK oraz mechanizmy kontroli i raportowania podatku VAT.
- Tabel: **5**

Kolumna `Historia`: `historyczna → H` (obiekt wersjonowany, historia w tabeli H) albo
`historia → P` (rekord historyczny obiektu P). Kolumna `Selektor`: `TypEnum (N)` gdy tabela
przechowuje N podtypów rozróżnianych selektorem (szczegóły w sekcji `## Selektor` pliku tabeli).
Pozostałe moduły: [../INDEX.md](../INDEX.md) · interfejsy: [../Interfaces.md](../Interfaces.md).

| RowType | Tytuł | Tabela | Konfig | Guided | Historia | Interfaces | Selektor | Plik |
|---------|-------|--------|--------|--------|----------|------------|----------|------|
| DefinicjaPowstaniaObowiazkuVAT | Definicje powstania obowiązku VAT | `DefinicjePOVAT` | konfig | root |  |  | TypTytułuObowiązkuVAT (4) | [DefinicjaPowstaniaObowiazkuVAT.md](DefinicjaPowstaniaObowiazkuVAT.md) |
| ElemEwidencjiVATAkcyzy | Elementy ewidencji VAT | `EleEwidencjiVATT` |  | child: Naglowek→NagEwidencjiVATAkcyzy |  | IZrodloOpisuAnalitycznego | TypEwidencjiVAT (4) | [ElemEwidencjiVATAkcyzy.md](ElemEwidencjiVATAkcyzy.md) |
| ElemRozliczeniaVATAkcyzy | Elementy rozliczen VAT | `EleRozliczenVATT` |  | child: Naglowek→NagRozliczeniaVATAkcyzy |  |  | TypEwidencjiVAT (4) | [ElemRozliczeniaVATAkcyzy.md](ElemRozliczeniaVATAkcyzy.md) |
| NagEwidencjiVATAkcyzy | Nagłóweki ewidencji VAT | `NagEwidencjiVATT` |  | child: Ewidencja→DokEwidencji |  |  | TypEwidencjiVAT (4) | [NagEwidencjiVATAkcyzy.md](NagEwidencjiVATAkcyzy.md) |
| NagRozliczeniaVATAkcyzy | Nagłówki rozliczeń VAT | `NagRozliczenVATT` |  | child: Naglowek→NagEwidencjiVATAkcyzy |  |  | TypRozliczeniaVAT (4) | [NagRozliczeniaVATAkcyzy.md](NagRozliczeniaVATAkcyzy.md) |

