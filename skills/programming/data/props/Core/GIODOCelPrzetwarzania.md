# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODOCelPrzetwarzania`
Nazwa tabeli: `GIODOCelePrzetw`
Tytuł: Cele przetwarzania
Opis: Słownik celów przetwarzania danych osobowych zgodnie z RODO. Każdy cel posiada nazwę, opis, podstawę prawną przetwarzania oraz flagę blokady. Wykorzystywany w zbiorach danych i oświadczeniach.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis celu |
| PodstawaPrawna | `string` | bazodanowe | Podstawa prawna | Podstawa prawna przetwarzania |
