# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.DefWyroznienia`
Nazwa tabeli: `DefWyroznien`
Tytuł: Definicje wyróżnień
Opis: Słownik definicji wyróżnień, certyfikatów i odznaczeń przyznawanych uczestnikom. Określa typy wyróżnień, schematy numeracji oraz warunki ich przyznawania po ukończeniu szkoleń.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nazwa | `string` | bazodanowe | Nazwa szkolenia | Nazwa szkolenia. |
| NumerDodatkowy | `bool` | bazodanowe |  | Dodatkowy numer. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe | Schemat numeracji dla szkoleń | Schemat numeracji dla szkoleń. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| Symbol | `string` | bazodanowe | Symbol wyróżnienia | Symbol wyróżnienia. |
| Typ | `Soneta.CzlonkowieSzkolenia.TypWyroznienia` | bazodanowe, enum |  |  |
| TypWyroznienia | `Soneta.CzlonkowieSzkolenia.TypWyroznienia` | enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypWyroznienia (`Soneta.CzlonkowieSzkolenia.TypWyroznienia`)
- `Certyfikat` = 1 — Certyfikat
- `Odznaczenie` = 2
