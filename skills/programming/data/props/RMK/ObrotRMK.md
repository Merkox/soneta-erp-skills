# Pola i właściwości klasy biznesowej: `Soneta.RMK.ObrotRMK`
Nazwa tabeli: `ObrotyRMK`
Tytuł: Obroty RMK
Opis: Obrót (rata) rozliczenia międzyokresowego kosztu. Reprezentuje pojedynczy odpis naliczony dla danego kosztu RMK w określonym okresie, z wartością bilansową i podatkową. Powiązany jest z dokumentem RMK i ewidencją źródłową, umożliwiając śledzenie harmonogramu rozliczeń.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`
Selektor: pole `Typ` (`Soneta.RMK.TypObrotuRMK`) — wiele typów w jednej tabeli, podtypów: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CentrumKosztow | `Soneta.Core.CentrumKosztow` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe |  | Data obrotu |
| DataDo | `Date` | bazodanowe |  | Data zakończenia wyliczania obrotu |
| Dokument | `Soneta.RMK.DokumentRMK` | bazodanowe, tylko-odczyt |  | Dokumentu RMK obrotu |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe |  | Ewidencja dokumentu obrotu |
| GrupaKosztow | `string` | tylko-odczyt |  |  |
| IloscDni | `int` | tylko-odczyt |  |  |
| Koszt | `Soneta.RMK.KosztRMK` | bazodanowe, tylko-odczyt |  | Koszt obrotu |
| Opis | `string` | bazodanowe |  | Opis obrotu |
| OpisAnalityczny | `SubTable` | podlista |  |  |
| OpisAnalitycznyBufor | `bool` | tylko-odczyt |  |  |
| PageVisible | `bool` | tylko-odczyt |  |  |
| StatusObrotu | `Soneta.RMK.StatusObrotuRMK` (enum) | bazodanowe |  | Status obrotu |
| StawkaDziennaBilansowa | `double` | tylko-odczyt |  |  |
| StawkaDziennaPodatkowa | `double` | tylko-odczyt |  |  |
| Typ | `Soneta.RMK.TypObrotuRMK` (enum) | bazodanowe, tylko-odczyt, selektor |  | Typ obrotu |
| WartoscBilansowa | `decimal` | bazodanowe |  | Wartość bilansowa obrotu |
| WartoscNKUP | `decimal` | tylko-odczyt |  | Wartość niestanowiąca kosztów uzyskania przychodu |
| WartoscPodatkowa | `decimal` | bazodanowe |  | Wartość podatkowa obrotu |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Wartosc` | 0 | `Soneta.RMK.WartoscRMK` |  |
| `Rozliczenie` | 1 | `Soneta.RMK.RozliczenieRMK` |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusObrotuRMK (`Soneta.RMK.StatusObrotuRMK`)
- `Reczny` = 0 — Ręczny
- `Automatyczny` = 1

### TypObrotuRMK (`Soneta.RMK.TypObrotuRMK`)
- `Wartosc` = 0 — Wartość
- `Rozliczenie` = 1
