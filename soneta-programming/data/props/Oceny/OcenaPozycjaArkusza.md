# Pola i właściwości klasy biznesowej: `Soneta.Oceny.OcenaPozycjaArkusza`
Nazwa tabeli: `OcenyPozArkuszy`
Tytuł: Pozycje arkuszy ocen
Opis: Element szczegółowy arkusza oceny (OcenaPozycjaArkusza). Reprezentuje ocenę jednego kryterium (kompetencji, zadania) w arkuszu, przechowując wartość, wagę, wynik znormalizowany i informację o wymagalności.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 16
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Arkusz | `Soneta.Oceny.OcenaArkusz` | bazodanowe |  |  |
| ArkuszeOdp | `Soneta.Business.SubTable<Soneta.Oceny.ArkuszOdpowiedz>` |  |  |  |
| Definicja | `Soneta.Oceny.DefinicjaElementuOceny` | bazodanowe |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wypłaty na planownej liście płac. |
| Max | `decimal` | bazodanowe |  |  |
| TypOceny | `Soneta.Oceny.TypOceny` | bazodanowe, enum |  |  |
| UzasadnienieOceny | `Soneta.Oceny.UzasadnienieOceny[]` |  |  |  |
| Waga | `decimal` | bazodanowe |  |  |
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
| WartoscOcenaStr | `string` |  |  |  |
| Wyliczana | `bool` | bazodanowe |  |  |
| Wymagana | `bool` | bazodanowe |  |  |
| Znormalizowana | `Soneta.Types.Percent` | bazodanowe |  |  |
| ZnormalizowanaWgWagi | `Soneta.Types.Percent` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypOceny (`Soneta.Oceny.TypOceny`)
- `Ocena` = 1
- `Ankieta` = 2
