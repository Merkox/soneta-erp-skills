# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PodokresObrachunkowy`
Nazwa tabeli: `PodokresyObrach`
Tytuł: Podokresy obrachunkowe
Opis: Element szczegółowy okresu obrachunkowego (OkresObrachunkowy). Pozwala zdefiniować odrębne podokresy obrachunkowe dla poszczególnych firm (oddziałów) w ramach jednego głównego okresu. Umożliwia indywidualne ustawienie dat zamknięcia, dozwolonych okresów księgowania i parametrów JPK.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `OkresKs` → `OkresObrachunkowy`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnaNumeracjaPozabilansowa | `bool` | bazodanowe |  | Włącz odrębną numeracje dekretów oraz zapisów księgowych dla kont pozabilansowych  |
| DataZamkniecia | `Date` | bazodanowe |  | Data zamknięcia zapisów |
| DozwolonyOkres | `FromTo` | bazodanowe, podlista |  | Dozwolony okres księgowania |
| DozwolonyOkresRozliczenKs | `FromTo` | bazodanowe, podlista |  | Dozwolony okres rozliczeń księgowych |
| Firma | `Soneta.Core.OddzialFirmy` | bazodanowe | Firma | Firma, dla której definiowany jest podokres. |
| Okres | `FromTo` | bazodanowe, podlista |  | Otwarcie i zamkniecie okresu obrachunkowego. |
| OkresKs | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe, tylko-odczyt, guided-parent |  | Okresu obrachunkowy |
| OkresPodatkowyJPK | `FromTo` | bazodanowe, podlista |  | Okres podatkowy JPK |
| Opis | `string` | bazodanowe |  |  |
