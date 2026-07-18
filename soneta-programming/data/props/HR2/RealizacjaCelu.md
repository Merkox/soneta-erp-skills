# Pola i właściwości klasy biznesowej: `Soneta.HR2.RealizacjaCelu`
Nazwa tabeli: `RealizacjeCelPrc`
Tytuł: Realizacje celu pracowników
Opis: Element szczegółowy karty realizacji celu (KartaRealizacjiCelu). Dokumentuje stopień realizacji konkretnego celu okresowego pracownika z przypisaną wartością osiągnięcia i opisem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Karta` → `KartaRealizacjiCelu`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 5
- podlisty: 3
- subrowy: 1
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `Soneta.HR2.CelOkresowyPracownika` | bazodanowe, tylko-odczyt |  |  |
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe, tylko-odczyt |  |  |
| Karta | `Soneta.HR2.KartaRealizacjiCelu` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
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
