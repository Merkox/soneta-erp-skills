# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaPozycjaArkusza`
Nazwa tabeli: `OcenyPozArkuszy`
Tytuł: Pozycje arkuszy ocen
Opis: Element szczegółowy arkusza oceny (OcenaPozycjaArkusza). Reprezentuje ocenę jednego kryterium (kompetencji, zadania) w arkuszu, przechowując wartość, wagę, wynik znormalizowany i informację o wymagalności.
Tabela konfiguracyjna: Nie
Guided: root
Selektor: pole `TypOceny` (`Soneta.Oceny.TypOceny`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusz | `Soneta.Oceny.OcenaArkusz` | bazodanowe, tylko-odczyt |  |  |
| ArkuszeOdp | `SubTable<Soneta.Oceny.ArkuszOdpowiedz>` | podlista |  |  |
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe, tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wypłaty na planownej liście płac. |
| Max | `decimal` | bazodanowe, tylko-odczyt |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| UzasadnienieOceny | `Soneta.Oceny.UzasadnienieOceny[]` | podlista |  |  |
| Waga | `decimal` | bazodanowe, tylko-odczyt |  |  |
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
| WartoscOcenaStr | `string` |  |  |  |
| Wyliczana | `bool` | bazodanowe, tylko-odczyt |  |  |
| Wymagana | `bool` | bazodanowe, tylko-odczyt |  |  |
| Znormalizowana | `Percent` | bazodanowe, tylko-odczyt |  |  |
| ZnormalizowanaWgWagi | `Percent` | bazodanowe, tylko-odczyt |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `TypOceny`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Ocena` | 1 | `Soneta.Oceny.OcenaPozycjaArkusza` |  |
| `Ankieta` | 2 | `Soneta.Ankiety.AnkietaPozycjaArkusza` | Pozycja arkusza ankiety |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
