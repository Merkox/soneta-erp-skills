# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DefinicjaAnalityki`
Nazwa tabeli: `DefAnalityk`
Tytuł: Definicje analityk
Opis: Element szczegółowy konta księgowego (KontoBase). Definiuje strukturę analityki konta, w tym wzór segmentu, długość segmentu, powiązanie ze słownikiem oraz warunki użycia. Umożliwia automatyczne generowanie kont analitycznych i kontrolę poziomów księgowania.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Konto` → `KontoBase`

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 6
- podlisty: 1
- subrowy: 0
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefinicjaSlownika | `Soneta.Ksiega.DefinicjaSlownika` | bazodanowe | Def. słownika | Definicja słownika |
| DlugoscSegmentu | `int` | bazodanowe | Długość segmentu | Długośc segmentu |
| GenerujAnalityke | `bool` | bazodanowe |  | Generuj analitykę przy tworzeniu w nowym okresie obrachunkowym |
| IsVisibleWyjatki | `bool` | tylko-odczyt |  |  |
| Konto | `Soneta.Ksiega.KontoBase` | bazodanowe, tylko-odczyt, guided-parent |  | Konto definicji analityki |
| Lp | `int` | bazodanowe |  | Liczba porządkowa definicji analityki konta |
| Nadrzedna | `Soneta.Ksiega.DefinicjaAnalityki` | tylko-odczyt |  |  |
| NadrzednaLp | `int` | bazodanowe, tylko-odczyt |  | Lp nadrzędnej definicji analityki |
| Nazwa | `string` | bazodanowe |  | Składnia nazwy analityki |
| Poziom | `int` | tylko-odczyt |  |  |
| RelacjaOpisAnal | `Soneta.Ksiega.RelacjaOpisAnal` | bazodanowe |  | Relacja do opisu analitycznego |
| TworzenieWgUprawnien | `bool` | bazodanowe |  | Analityka jest dodawana od strony wzorcowego planu kont |
| Typ | `Soneta.Ksiega.TypDefinicjiAnalityki` (enum) | bazodanowe | Typ | Typ definicji analityki |
| TypAnalityki | `Soneta.Ksiega.TypAnalityki` (enum) | bazodanowe |  | Typ analityki |
| TypWzoruSegmentu | `Soneta.Ksiega.TypWzoruPorownania` (enum) | bazodanowe |  | Typ wzoru segmentu |
| Warunek | `string` | bazodanowe |  | Warunek użycia definicji analityki |
| WarunekTxt | `string` |  |  |  |
| Wyjatki | `SubTable<Soneta.Ksiega.DefinicjaAnalityki>` | podlista |  |  |
| WyjatkiViewInfo | `ViewInfo` | tylko-odczyt |  |  |
| WzorSegmentu | `string` | bazodanowe | Wzór segmentu | Wzór segmentu |
| ZabronioneKsiegowanie | `bool` | bazodanowe |  | Nie pozwala księgować na tym poziomie analityki |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypAnalityki (`Soneta.Ksiega.TypAnalityki`)
- `Konta` = 0
- `OpisyAnalityczne` = 1 — Opisy analityczne

### TypDefinicjiAnalityki (`Soneta.Ksiega.TypDefinicjiAnalityki`)
- `Standardowa` = 0
- `Wyjatek` = 1

### TypWzoruPorownania (`Soneta.Ksiega.TypWzoruPorownania`)
- `Brak` = 0
- `RegEx` = 1 — Wyrażenie regularne
- `Like` = 2 — Podobny *?
- `SQLLike` = 3 — Podobny SQL %_
- `Księgowy` = 4 — Księgowy X9?*
