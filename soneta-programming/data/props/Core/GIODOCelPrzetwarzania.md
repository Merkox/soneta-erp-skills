# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOCelPrzetwarzania`
Nazwa tabeli: `GIODOCelePrzetw`
Tytuł: Cele przetwarzania
Opis: Słownik celów przetwarzania danych osobowych zgodnie z RODO. Każdy cel posiada nazwę, opis, podstawę prawną przetwarzania oraz flagę blokady. Wykorzystywany w zbiorach danych i oświadczeniach.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis celu |
| PodstawaPrawna | `string` | bazodanowe | Podstawa prawna | Podstawa prawna przetwarzania |
