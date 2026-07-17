# Pola i właściwości klasy biznesowej: `Soneta.HR2.KompetencjaPracownika`
Nazwa tabeli: `KompetencjePrac`
Tytuł: Kompetencje
Opis: Element szczegółowy karty kompetencji pracownika (KartaKompetencjiPracownika). Przechowuje ocenę poziomu pojedynczej kompetencji pracownika według zdefiniowanej skali wartości.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Karta` → `KartaKompetencjiPracownika`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Karta | `Soneta.HR2.KartaKompetencjiPracownika` | bazodanowe, guided-parent |  |  |
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
