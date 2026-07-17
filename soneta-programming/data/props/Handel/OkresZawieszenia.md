# Pola i właściwości klasy biznesowej: `Soneta.Handel.OkresZawieszenia`
Nazwa tabeli: `OkresyZawiesz`
Tytuł: Okresy zawieszenia
Opis: Element szczegółowy dokumentu handlowego (DokumentHandlowy). Przechowuje okres (data od-do), w którym dokument (np. umowa) był zawieszony.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentHandlowy`

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Do | `Soneta.Types.Date` |  |  |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, guided-parent |  | Dokument, który zawieszono w tym okresie. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa okresu zawieszenia na dokumencie handlowym. |
| Od | `Soneta.Types.Date` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Okres zawieszenia dokumentu handlowego. |
