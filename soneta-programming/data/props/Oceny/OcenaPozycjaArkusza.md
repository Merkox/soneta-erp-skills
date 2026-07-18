# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaPozycjaArkusza`
Nazwa tabeli: `OcenyPozArkuszy`
Tytuł: Pozycje arkuszy ocen
Opis: Element szczegółowy arkusza oceny (OcenaPozycjaArkusza). Reprezentuje ocenę jednego kryterium (kompetencji, zadania) w arkuszu, przechowując wartość, wagę, wynik znormalizowany i informację o wymagalności.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 4
- pola tylko-odczyt: 11
- podlisty: 4
- subrowy: 1
- razem: 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusz | `Soneta.Oceny.OcenaArkusz` | bazodanowe, tylko-odczyt |  |  |
| ArkuszeOdp | `SubTable<Soneta.Oceny.ArkuszOdpowiedz>` | podlista |  |  |
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe, tylko-odczyt |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wypłaty na planownej liście płac. |
| Max | `decimal` | bazodanowe, tylko-odczyt |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` (enum) | bazodanowe, tylko-odczyt |  |  |
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

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
