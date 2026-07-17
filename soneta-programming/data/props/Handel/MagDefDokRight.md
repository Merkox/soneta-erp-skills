# Pola i właściwości klasy biznesowej: `Soneta.Handel.MagDefDokRight`
Nazwa tabeli: `MagDefDokRights`
Tytuł: Przypisanie definicji dokumentu do magazynu
Opis: Uprawnienie magazynu do wystawiania dokumentów określonego typu. Przypisanie definicji dokumentu handlowego do magazynu decyduje o tym, jakie rodzaje dokumentów mogą być tworzone w danym magazynie.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Magazyn` → `Magazyn`

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Handel.DefDokHandlowego` | bazodanowe |  | Przypisane do definicji magazyny. |
| Magazyn | `Soneta.Magazyny.Magazyn` | bazodanowe, guided-parent |  | Przypisane do magazynu definicje. |
