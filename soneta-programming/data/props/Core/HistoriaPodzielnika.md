# Pola i właściwości klasy biznesowej: `Soneta.Core.HistoriaPodzielnika`
Nazwa tabeli: `HistPodzielnikow`
Tytuł: Podzielniki kosztów
Opis: Element szczegółowy podzielnika kosztów (PodzielnikKosztow). Przechowuje historyczną wersję podzielnika z okresem obowiązywania (aktualność) i wartością bazową do kalkulacji współczynników podziału.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Podzielnik` → `PodzielnikKosztow`
Historia: Tak — zapis historyczny tabeli `PodzielnikKosztow`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 2
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| CzyZDokumentu | `bool` |  |  |  |
| Elementy | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| Podstawa | `decimal` | bazodanowe, tylko-odczyt |  |  |
| Podzielnik | `Soneta.Core.PodzielnikKosztow` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Pusty | `bool` | tylko-odczyt |  |  |
