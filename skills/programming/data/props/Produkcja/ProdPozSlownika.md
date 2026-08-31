# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdPozSlownika`
Nazwa tabeli: `ProdPozSlownikow`
Tytuł: Pozycje słowników
Opis: Element szczegółowy słownika produkcyjnego (ProdSlownik). Przechowuje pojedynczą pozycję słownika z wartością alfanumeryczną lub numeryczną i opisem, uporządkowaną liczbą porządkową. Pozycje tworzą zamknięty zbiór dopuszczalnych wartości słownikowych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Slownik` → `ProdSlownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `string` | tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa pozycji słownika. |
| Nazwa | `string` | tylko-odczyt |  |  |
| Opis | `string` | bazodanowe | Opis pozycji | Opis pozycji słownika. |
| Slownik | `Soneta.Produkcja.ProdSlownik` | bazodanowe, tylko-odczyt, guided-parent |  | Określa słownik dla pozycji słownika. |
| WartoscAlfanumeryczna | `string` | bazodanowe | Wartość alfanumeryczna | Wartość alfanumeryczna pozycji słownika. |
| WartoscNumeryczna | `double` | bazodanowe | Wartość numeryczna | Wartość numeryczna pozycji słownika. |
