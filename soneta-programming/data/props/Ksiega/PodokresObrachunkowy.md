# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PodokresObrachunkowy`
Nazwa tabeli: `PodokresyObrach`
Tytuł: Podokresy obrachunkowe
Opis: Element szczegółowy okresu obrachunkowego (OkresObrachunkowy). Pozwala zdefiniować odrębne podokresy obrachunkowe dla poszczególnych firm (oddziałów) w ramach jednego głównego okresu. Umożliwia indywidualne ustawienie dat zamknięcia, dozwolonych okresów księgowania i parametrów JPK.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `OkresKs` → `OkresObrachunkowy`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AktywnaNumeracjaPozabilansowa | `bool` | bazodanowe |  | Włącz odrębną numeracje dekretów oraz zapisów księgowych dla kont pozabilansowych  |
| DataZamkniecia | `Soneta.Types.Date` | bazodanowe |  | Data zamknięcia zapisów |
| DozwolonyOkres | `Soneta.Types.FromTo` | bazodanowe |  | Dozwolony okres księgowania |
| DozwolonyOkresRozliczenKs | `Soneta.Types.FromTo` | bazodanowe |  | Dozwolony okres rozliczeń księgowych |
| Firma | `Soneta.Core.OddzialFirmy` | bazodanowe | Firma | Firma, dla której definiowany jest podokres. |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Otwarcie i zamkniecie okresu obrachunkowego. |
| OkresKs | `Soneta.Ksiega.OkresObrachunkowy` | bazodanowe, guided-parent |  | Okresu obrachunkowy |
| OkresPodatkowyJPK | `Soneta.Types.FromTo` | bazodanowe |  | Okres podatkowy JPK |
| Opis | `string` | bazodanowe |  |  |
