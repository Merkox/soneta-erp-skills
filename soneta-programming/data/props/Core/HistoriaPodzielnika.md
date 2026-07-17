# Pola i właściwości klasy biznesowej: `Soneta.Core.HistoriaPodzielnika`
Nazwa tabeli: `HistPodzielnikow`
Tytuł: Podzielniki kosztów
Opis: Element szczegółowy podzielnika kosztów (PodzielnikKosztow). Przechowuje historyczną wersję podzielnika z okresem obowiązywania (aktualność) i wartością bazową do kalkulacji współczynników podziału.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Podzielnik` → `PodzielnikKosztow`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe |  |  |
| CzyZDokumentu | `bool` |  |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Parent | `Soneta.Business.Row` |  |  |  |
| Podstawa | `decimal` | bazodanowe |  |  |
| Podzielnik | `Soneta.Core.PodzielnikKosztow` | bazodanowe, guided-parent |  |  |
| Pusty | `bool` |  |  |  |
