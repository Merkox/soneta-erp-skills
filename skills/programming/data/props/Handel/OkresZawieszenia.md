# Pola i właściwości klasy biznesowej: `Soneta.Handel.OkresZawieszenia`
Nazwa tabeli: `OkresyZawiesz`
Tytuł: Okresy zawieszenia
Opis: Element szczegółowy dokumentu handlowego (DokumentHandlowy). Przechowuje okres (data od-do), w którym dokument (np. umowa) był zawieszony.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dokument` → `DokumentHandlowy`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Do | `Date` |  |  |  |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt, guided-parent |  | Dokument, który zawieszono w tym okresie. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa okresu zawieszenia na dokumencie handlowym. |
| Od | `Date` |  |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  | Okres zawieszenia dokumentu handlowego. |
