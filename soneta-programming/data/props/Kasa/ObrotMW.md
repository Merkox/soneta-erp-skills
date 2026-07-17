# Pola i właściwości klasy biznesowej: `Soneta.Kasa.ObrotMW`
Nazwa tabeli: `ObrotyMW`
Tytuł: Obroty
Opis: Obrót w magazynie walut wiążący wpłatę z wypłatą walutową. Rejestruje kurs przychodu i rozchodu waluty, umożliwiając wyliczenie różnicy kursowej między kursem nabycia a kursem rozchodu środków w ewidencji walutowej.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokEwidencji | `Soneta.Core.DokEwidencji` | bazodanowe |  |  |
| Ewidencja | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| Ksiegowanie | `Soneta.Kasa.TypKsiegowaniaObrotuMW` | bazodanowe, enum |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| ObrotWedlug | `Soneta.Kasa.ObrótMWWedług` | bazodanowe, enum |  |  |
| Okres | `Soneta.Kasa.OkresMW` | bazodanowe |  | Okres magazynu walut, do którego został naliczony obrót. |
| Przychod | `Soneta.Kasa.PartiaMW` | bazodanowe |  |  |
| Przychod.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Przychod.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Przychod.Kurs | `double` | bazodanowe |  |  |
| Przychod.Kwota | `Soneta.Types.Currency` |  |  |  |
| Przychod.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Przychod.Zapłata | `Soneta.Kasa.Zaplata` |  |  |  |
| Rozchod | `Soneta.Kasa.PartiaMW` | bazodanowe |  |  |
| RozchodWgKursu | `Soneta.Kasa.PartiaMW` | bazodanowe |  |  |
| RóżnicaKursowa | `decimal` |  |  |  |
| Strata | `decimal` |  |  |  |
| TypRK | `Soneta.Kasa.TypRoznicyKursowej` | enum | Typ różnicy kursowej |  |
| Wartość | `decimal` |  |  |  |
| Wplata | `Soneta.Kasa.Wplata` | bazodanowe |  |  |
| Wyplata | `Soneta.Kasa.Wyplata` | bazodanowe |  |  |
| Zysk | `decimal` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ObrótMWWedług (`Soneta.Kasa.ObrótMWWedług`)
- `WgKursu` = 0 — Wg kursu
- `WgPrzychodu` = 1
- `WgPrzychoduZaksięgowane` = 2

### TypKsiegowaniaObrotuMW (`Soneta.Kasa.TypKsiegowaniaObrotuMW`)
- `NieZaskięgowany` = 0 — Nie zaskięgowany
- `RóżnicaKursowa` = 1
- `KorektaRóżnicy` = 2

### TypRoznicyKursowej (`Soneta.Kasa.TypRoznicyKursowej`)
- `Brak` = 0
- `Zysk` = 1
- `Strata` = 2
