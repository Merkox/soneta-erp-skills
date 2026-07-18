# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProNumeracjaZlecenia`
Nazwa tabeli: `ProNumeracjeZlec`
Tytuł: Numeracje zleceń
Opis: Element szczegółowy wydziału produkcyjnego (ProWydzial). Konfiguruje schemat numeracji zleceń produkcyjnych dla danego wydziału, określając definicję numeracji i symbol używany przy generowaniu numerów zleceń.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wydzial` → `ProWydzial`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  | Definicja numeracji zlecenia. |
| Definicja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Definicja.PodczasZapisu | `bool` |  |  |  |
| Definicja.Separator | `string` | bazodanowe |  |  |
| Definicja.Wzor | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  | Symbol numeracji zlecenia. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe, guided-parent | Wydział | Wydział numeracji zlecenia. |
