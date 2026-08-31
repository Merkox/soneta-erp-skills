# Pola i właściwości klasy biznesowej: `Soneta.Core.HistoriaPodzielnika`
Nazwa tabeli: `HistPodzielnikow`
Tytuł: Podzielniki kosztów
Opis: Element szczegółowy podzielnika kosztów (PodzielnikKosztow). Przechowuje historyczną wersję podzielnika z okresem obowiązywania (aktualność) i wartością bazową do kalkulacji współczynników podziału.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Podzielnik` → `PodzielnikKosztow`
Historia: Tak — zapis historyczny tabeli `PodzielnikKosztow`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista |  |  |
| CzyZDokumentu | `bool` |  |  |  |
| Elementy | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Parent | `Row` | tylko-odczyt |  |  |
| Podstawa | `decimal` | bazodanowe, tylko-odczyt |  |  |
| Podzielnik | `Soneta.Core.PodzielnikKosztow` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Pusty | `bool` | tylko-odczyt |  |  |
