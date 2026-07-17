# Pola i właściwości klasy biznesowej: `Soneta.HR2.RealizacjaCelu`
Nazwa tabeli: `RealizacjeCelPrc`
Tytuł: Realizacje celu pracowników
Opis: Element szczegółowy karty realizacji celu (KartaRealizacjiCelu). Dokumentuje stopień realizacji konkretnego celu okresowego pracownika z przypisaną wartością osiągnięcia i opisem.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Karta` → `KartaRealizacjiCelu`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `Soneta.HR2.CelOkresowyPracownika` | bazodanowe |  |  |
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Karta | `Soneta.HR2.KartaRealizacjiCelu` | bazodanowe, guided-parent |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Wartosc | `Soneta.Oceny.WartośćElementuOceny` | bazodanowe |  |  |
| Wartosc.Host | `Soneta.Oceny.IWartośćOcenyHost` |  |  |  |
| Wartosc.Ocena | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe |  |  |
| Wartosc.Punktacja | `decimal` | bazodanowe | Punktacja |  |
| Wartosc.Uzasadnienie | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Wartosc.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Wartosc.Wartosc2 | `decimal` |  |  |  |
| Wartosc.WartoscInt | `int` |  |  |  |
| Wartosc.WgOcena | `Soneta.Business.Key` |  |  |  |
| Wartosc.Wykonanie | `decimal` | bazodanowe | Wykonanie |  |
| Wartosc.WykonanieInt | `int` |  | Wykonanie |  |
| Wartosc.Wypełniona | `bool` |  |  |  |
