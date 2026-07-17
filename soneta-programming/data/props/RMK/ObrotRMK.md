# Pola i właściwości klasy biznesowej: `Soneta.RMK.ObrotRMK`
Nazwa tabeli: `ObrotyRMK`
Tytuł: Obroty RMK
Opis: Obrót (rata) rozliczenia międzyokresowego kosztu. Reprezentuje pojedynczy odpis naliczony dla danego kosztu RMK w określonym okresie, z wartością bilansową i podatkową. Powiązany jest z dokumentem RMK i ewidencją źródłową, umożliwiając śledzenie harmonogramu rozliczeń.
Tabela konfiguracyjna: Nie
Implementuje interfejsy: `IZrodloOpisuAnalitycznego`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CentrumKosztow | `Soneta.Core.CentrumKosztow` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data obrotu |
| DataDo | `Soneta.Types.Date` | bazodanowe |  | Data zakończenia wyliczania obrotu |
| Dokument | `Soneta.RMK.DokumentRMK` | bazodanowe |  | Dokumentu RMK obrotu |
| Ewidencja | `Soneta.Core.DokEwidencji` | bazodanowe |  | Ewidencja dokumentu obrotu |
| GrupaKosztow | `string` |  |  |  |
| IloscDni | `int` |  |  |  |
| Koszt | `Soneta.RMK.KosztRMK` | bazodanowe |  | Koszt obrotu |
| Opis | `string` | bazodanowe |  | Opis obrotu |
| OpisAnalityczny | `Soneta.Business.SubTable` |  |  |  |
| OpisAnalitycznyBufor | `bool` |  |  |  |
| PageVisible | `bool` |  |  |  |
| StatusObrotu | `Soneta.RMK.StatusObrotuRMK` | bazodanowe, enum |  | Status obrotu |
| StawkaDziennaBilansowa | `double` |  |  |  |
| StawkaDziennaPodatkowa | `double` |  |  |  |
| Typ | `Soneta.RMK.TypObrotuRMK` | bazodanowe, enum |  | Typ obrotu |
| WartoscBilansowa | `decimal` | bazodanowe |  | Wartość bilansowa obrotu |
| WartoscNKUP | `decimal` |  |  | Wartość niestanowiąca kosztów uzyskania przychodu |
| WartoscPodatkowa | `decimal` | bazodanowe |  | Wartość podatkowa obrotu |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusObrotuRMK (`Soneta.RMK.StatusObrotuRMK`)
- `Reczny` = 0 — Ręczny
- `Automatyczny` = 1

### TypObrotuRMK (`Soneta.RMK.TypObrotuRMK`)
- `Wartosc` = 0 — Wartość
- `Rozliczenie` = 1
