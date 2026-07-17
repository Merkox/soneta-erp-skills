# Pola i właściwości klasy biznesowej: `Soneta.Core.ParametrRozlicz`
Nazwa tabeli: `ParametryRozlicz`
Tytuł: Parametry rozliczeń
Opis: Parametry rozliczeń VAT (prewspółczynnik i współczynnik sprzedaży). Przechowuje nazwę, symbol, powiązanego kontrahenta, historyczne wartości prewspółczynników i współczynników sprzedaży (bieżących i rzeczywistych) oraz flagę blokady.
Tabela konfiguracyjna: Tak

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
| Prewspolczynnik | `Soneta.Business.HistoryValuePercent` |  | Prewspółczynnik |  |
| PrewspolczynnikHist | `Soneta.Business.MemoText` | bazodanowe |  | Pole do przechowywania historii prewspółczynnika. |
| PrewspolczynnikRzeczywisty | `Soneta.Business.HistoryValuePercent` |  | Prewspółczynnik rzeczywisty |  |
| PrewspolczynnikRzeczywistyHist | `Soneta.Business.MemoText` | bazodanowe |  | Pole do przechowywania historii rzeczywistego prewspółczynnika. |
| Symbol | `string` | bazodanowe | Symbol |  |
| WspolczynnikSprzedazy | `Soneta.Business.HistoryValuePercent` |  | Współczynnik sprzedaży |  |
| WspolczynnikSprzedazyHist | `Soneta.Business.MemoText` | bazodanowe |  | Pole do przechowywania historii współczynnika sprzedaży. |
| WspolczynnikSprzedazyRzeczywisty | `Soneta.Business.HistoryValuePercent` |  | Współczynnik sprzedaży rzeczywisty |  |
| WspolczynnikSprzedazyRzeczywistyHist | `Soneta.Business.MemoText` | bazodanowe |  | Pole do przechowywania historii rzeczywistego współczynnika sprzedaży. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
