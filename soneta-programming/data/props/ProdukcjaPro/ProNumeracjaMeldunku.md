# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProNumeracjaMeldunku`
Nazwa tabeli: `ProNumeracjeMeld`
Tytuł: Numeracje meldunków
Opis: Element szczegółowy wydziału produkcyjnego (ProWydzial). Konfiguruje schemat numeracji meldunków produkcyjnych dla danego wydziału, określając definicję numeracji i symbol używany przy generowaniu numerów meldunków.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wydzial` → `ProWydzial`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  | Definicja numeracji meldunku. |
| Definicja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Definicja.PodczasZapisu | `bool` |  |  |  |
| Definicja.Separator | `string` | bazodanowe |  |  |
| Definicja.Wzor | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  | Symbol numeracji meldunku. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe, guided-parent | Wydział | Wydział numeracji meldunku. |
