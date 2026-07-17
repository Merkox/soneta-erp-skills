# Pola i właściwości klasy biznesowej: `Soneta.Business.FeatureSetDefinitionItem`
Nazwa tabeli: `FSDefItems`
Tytuł: Pola danych zestawów pól
Opis: Pojedynczy element (pole) w definicji zestawu pól. Określa ścieżkę do danych, etykietę, kategorię i parametry wizualne pola na formularzu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefaultLabel | `string` |  |  |  |
| FeatureDefinition | `Soneta.Business.FeatureDefinition` |  |  |  |
| FeatureSetDefinition | `Soneta.Business.FeatureSetDefinition` | bazodanowe | Definicja zestawu pól | Definicja zestawu pól |
| IsFeatureItem | `bool` |  |  |  |
| ItemCategory | `string` | bazodanowe | Kategoria | Karegoria/grupa, w której umieszczane jest pole (wartość pusta oznacza standardową) |
| ItemHeight | `int` | bazodanowe | Wysokość | Wysokość pola wyrażona w znakach (wartość 0 oznacza standardową) |
| ItemLabel | `string` | bazodanowe | Etykieta | Etykieta wyświetlana przed polem (wartość pusta oznacza standardową) |
| ItemLabelWidth | `int` | bazodanowe | Szerokość etykiety | Szerokość etykiety pola wyrażona w znakach (wartość 0 oznacza standardową) |
| ItemLabelWithDefault | `string` |  |  |  |
| ItemWidth | `int` | bazodanowe | Szerokość | Szerokość pola wyrażona w znakach (wartość 0 oznacza standardową) |
| Lp | `int` | bazodanowe |  | Liczba porządkowa elementu w zestawie cech |
| NextToPrevious | `bool` | bazodanowe | Obok | Umieszcza pole obok poprzedniego |
| Path | `string` | bazodanowe | Ścieżka do pola | Określa ścieżkę do danych prezentowanych na formularzu |
