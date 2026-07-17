# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProNumeracjaTechnologii`
Nazwa tabeli: `ProNumeracjeTech`
Tytuł: Numeracje technologii
Opis: Element szczegółowy wydziału produkcyjnego (ProWydzial). Konfiguruje schemat numeracji dokumentów technologii dla danego wydziału, określając definicję numeracji i symbol używany przy generowaniu numerów technologii.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Wydzial` → `ProWydzial`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  | Definicja numeracji technologii. |
| Definicja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Definicja.PodczasZapisu | `bool` |  |  |  |
| Definicja.Separator | `string` | bazodanowe |  |  |
| Definicja.Wzor | `string` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  | Symbol numeracji technologii. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe, guided-parent | Wydział | Wydział numeracji technologii. |
