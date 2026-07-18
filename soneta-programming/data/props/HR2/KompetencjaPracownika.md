# Pola i właściwości klasy biznesowej: `Soneta.HR2.KompetencjaPracownika`
Nazwa tabeli: `KompetencjePrac`
Tytuł: Kompetencje
Opis: Element szczegółowy karty kompetencji pracownika (KartaKompetencjiPracownika). Przechowuje ocenę poziomu pojedynczej kompetencji pracownika według zdefiniowanej skali wartości.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Karta` → `KartaKompetencjiPracownika`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 1
- razem: 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Karta | `Soneta.HR2.KartaKompetencjiPracownika` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Wartosc | `Soneta.Oceny.WartośćElementuOceny` (subrow) | bazodanowe |  |  |
| Wartosc.Host | `Soneta.Oceny.IWartośćOcenyHost` | tylko-odczyt |  |  |
| Wartosc.Ocena | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe |  |  |
| Wartosc.Punktacja | `decimal` | bazodanowe | Punktacja |  |
| Wartosc.Uzasadnienie | `MemoText` | bazodanowe, podlista |  |  |
| Wartosc.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Wartosc.Wartosc2 | `decimal` |  |  |  |
| Wartosc.WartoscInt | `int` |  |  |  |
| Wartosc.WgOcena | `Key` | podlista |  |  |
| Wartosc.Wykonanie | `decimal` | bazodanowe | Wykonanie |  |
| Wartosc.WykonanieInt | `int` |  | Wykonanie |  |
| Wartosc.Wypełniona | `bool` | tylko-odczyt |  |  |
