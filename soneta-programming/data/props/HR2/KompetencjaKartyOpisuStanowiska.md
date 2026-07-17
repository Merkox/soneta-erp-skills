# Pola i właściwości klasy biznesowej: `Soneta.HR2.KompetencjaKartyOpisuStanowiska`
Nazwa tabeli: `KompetencjeKOS`
Tytuł: Kompetencje KOS
Opis: Element szczegółowy karty opisu stanowiska (KartaOpisuStanowiskaBase). Określa wymaganą i oczekiwaną wartość kompetencji na danym stanowisku, definiując profil kwalifikacyjny roli.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Karta` → `KartaOpisuStanowiskaBase`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Karta | `Soneta.HR2.KartaOpisuStanowiskaBase` | bazodanowe, guided-parent |  |  |
| Oczekiwana | `Soneta.Oceny.WartośćElementuOceny` | bazodanowe |  |  |
| Wymagana | `Soneta.Oceny.WartośćElementuOceny` | bazodanowe |  |  |
| Wymagana.Host | `Soneta.Oceny.IWartośćOcenyHost` |  |  |  |
| Wymagana.Ocena | `Soneta.Oceny.ElementSkaliOcen` | bazodanowe |  |  |
| Wymagana.Punktacja | `decimal` | bazodanowe | Punktacja |  |
| Wymagana.Uzasadnienie | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Wymagana.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Wymagana.Wartosc2 | `decimal` |  |  |  |
| Wymagana.WartoscInt | `int` |  |  |  |
| Wymagana.WgOcena | `Soneta.Business.Key` |  |  |  |
| Wymagana.Wykonanie | `decimal` | bazodanowe | Wykonanie |  |
| Wymagana.WykonanieInt | `int` |  | Wykonanie |  |
| Wymagana.Wypełniona | `bool` |  |  |  |
