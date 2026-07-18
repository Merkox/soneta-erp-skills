# Pola i właściwości klasy biznesowej: `Soneta.Core.ParametrRozlicz`
Nazwa tabeli: `ParametryRozlicz`
Tytuł: Parametry rozliczeń
Opis: Parametry rozliczeń VAT (prewspółczynnik i współczynnik sprzedaży). Przechowuje nazwę, symbol, powiązanego kontrahenta, historyczne wartości prewspółczynników i współczynników sprzedaży (bieżących i rzeczywistych) oraz flagę blokady.
Tabela konfiguracyjna: Tak

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 4
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kontrahent | `Soneta.Core.IKontrahent` | bazodanowe, iface-ref |  |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
| Prewspolczynnik | `HistoryValuePercent` | tylko-odczyt | Prewspółczynnik |  |
| PrewspolczynnikHist | `MemoText` | bazodanowe, podlista |  | Pole do przechowywania historii prewspółczynnika. |
| PrewspolczynnikRzeczywisty | `HistoryValuePercent` | tylko-odczyt | Prewspółczynnik rzeczywisty |  |
| PrewspolczynnikRzeczywistyHist | `MemoText` | bazodanowe, podlista |  | Pole do przechowywania historii rzeczywistego prewspółczynnika. |
| Symbol | `string` | bazodanowe | Symbol |  |
| WspolczynnikSprzedazy | `HistoryValuePercent` | tylko-odczyt | Współczynnik sprzedaży |  |
| WspolczynnikSprzedazyHist | `MemoText` | bazodanowe, podlista |  | Pole do przechowywania historii współczynnika sprzedaży. |
| WspolczynnikSprzedazyRzeczywisty | `HistoryValuePercent` | tylko-odczyt | Współczynnik sprzedaży rzeczywisty |  |
| WspolczynnikSprzedazyRzeczywistyHist | `MemoText` | bazodanowe, podlista |  | Pole do przechowywania historii rzeczywistego współczynnika sprzedaży. |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Kontrahent | `IKontrahent` | `Bank`, `InstytucjaFinansowaPPK`, `Kontrahent`, `Pracownik`, `UrzadCelny`, `UrzadSkarbowy` |
