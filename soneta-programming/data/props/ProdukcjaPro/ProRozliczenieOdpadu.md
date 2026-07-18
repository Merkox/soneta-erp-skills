# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProRozliczenieOdpadu`
Nazwa tabeli: `ProRozOdpadow`
Tytuł: Rozliczenia odpadów
Opis: Element szczegółowy rozliczenia odpadu (ProOperacjaZlecenia). Powiązuje odpad meldunku z pozycją dokumentu handlowego w celu rozliczenia. Przechowuje informacje o towarze, ilości, ilości przeliczonej oraz wartości rozliczenia odpadu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operacja` → `ProOperacjaZlecenia`

- pola bazodanowe (zapisywalne): 7
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość rozliczenia odpadu. |
| IloscPrzeliczona | `double` | bazodanowe | Ilość przeliczona | Ilość przeliczona rozliczenia odpadu. |
| OdpadMeldunku | `Soneta.ProdukcjaPro.ProOdpadMeldunku` | bazodanowe | Odpad meldunku | Odpad meldunku dla rozliczenia odpadu. |
| Operacja | `Soneta.ProdukcjaPro.ProOperacjaZlecenia` | bazodanowe, guided-parent | Operacja | Operacja rozliczenia odpadu. |
| PozycjaDokumentuHandlowego | `Soneta.Handel.PozycjaDokHandlowego` | bazodanowe | Pozycja dokumentu handlowego | Pozycja dokumentu handlowego rozliczenia odpadu. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar rozliczenia odpadu. |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość rozliczenia odpadu. |
