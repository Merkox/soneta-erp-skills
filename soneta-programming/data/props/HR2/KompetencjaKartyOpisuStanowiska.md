# Pola i właściwości klasy biznesowej: `Soneta.HR2.KompetencjaKartyOpisuStanowiska`
Nazwa tabeli: `KompetencjeKOS`
Tytuł: Kompetencje KOS
Opis: Element szczegółowy karty opisu stanowiska (KartaOpisuStanowiskaBase). Określa wymaganą i oczekiwaną wartość kompetencji na danym stanowisku, definiując profil kwalifikacyjny roli.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Karta` → `KartaOpisuStanowiskaBase`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 3
- podlisty: 2
- subrowy: 2
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Karta | `Soneta.HR2.KartaOpisuStanowiskaBase` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Oczekiwana | `Soneta.Oceny.WartośćElementuOceny` (subrow) | bazodanowe |  |  |
| Wymagana | `Soneta.Oceny.WartośćElementuOceny` (subrow) | bazodanowe |  |  |
| Wymagana.Host | `Soneta.Oceny.IWartośćOcenyHost` | tylko-odczyt |  |  |
| Wymagana.Ocena | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe |  |  |
| Wymagana.Punktacja | `decimal` | bazodanowe | Punktacja |  |
| Wymagana.Uzasadnienie | `MemoText` | bazodanowe, podlista |  |  |
| Wymagana.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Wymagana.Wartosc2 | `decimal` |  |  |  |
| Wymagana.WartoscInt | `int` |  |  |  |
| Wymagana.WgOcena | `Key` | podlista |  |  |
| Wymagana.Wykonanie | `decimal` | bazodanowe | Wykonanie |  |
| Wymagana.WykonanieInt | `int` |  | Wykonanie |  |
| Wymagana.Wypełniona | `bool` | tylko-odczyt |  |  |
