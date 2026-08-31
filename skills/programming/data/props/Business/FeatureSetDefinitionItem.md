# Pola i właściwości klasy biznesowej: `Soneta.Business.FeatureSetDefinitionItem`
Nazwa tabeli: `FSDefItems`
Tytuł: Pola danych zestawów pól
Opis: Pojedynczy element (pole) w definicji zestawu pól. Określa ścieżkę do danych, etykietę, kategorię i parametry wizualne pola na formularzu.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DefaultLabel | `string` | tylko-odczyt |  |  |
| FeatureDefinition | `FeatureDefinition` | tylko-odczyt |  |  |
| FeatureSetDefinition | `FeatureSetDefinition` | bazodanowe, tylko-odczyt | Definicja zestawu pól | Definicja zestawu pól |
| IsFeatureItem | `bool` | tylko-odczyt |  |  |
| ItemCategory | `string` | bazodanowe | Kategoria | Karegoria/grupa, w której umieszczane jest pole (wartość pusta oznacza standardową) |
| ItemHeight | `int` | bazodanowe | Wysokość | Wysokość pola wyrażona w znakach (wartość 0 oznacza standardową) |
| ItemLabel | `string` | bazodanowe | Etykieta | Etykieta wyświetlana przed polem (wartość pusta oznacza standardową) |
| ItemLabelWidth | `int` | bazodanowe | Szerokość etykiety | Szerokość etykiety pola wyrażona w znakach (wartość 0 oznacza standardową) |
| ItemLabelWithDefault | `string` |  |  |  |
| ItemWidth | `int` | bazodanowe | Szerokość | Szerokość pola wyrażona w znakach (wartość 0 oznacza standardową) |
| Lp | `int` | bazodanowe |  | Liczba porządkowa elementu w zestawie cech |
| NextToPrevious | `bool` | bazodanowe | Obok | Umieszcza pole obok poprzedniego |
| Path | `string` | bazodanowe, tylko-odczyt | Ścieżka do pola | Określa ścieżkę do danych prezentowanych na formularzu |
