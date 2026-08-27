# Pola i właściwości klasy biznesowej: `Soneta.Kasa.ObrotMW`
Nazwa tabeli: `ObrotyMW`
Tytuł: Obroty
Opis: Obrót w magazynie walut wiążący wpłatę z wypłatą walutową. Rejestruje kurs przychodu i rozchodu waluty, umożliwiając wyliczenie różnicy kursowej między kursem nabycia a kursem rozchodu środków w ewidencji walutowej.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokEwidencji | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  |  |
| Ewidencja | `Soneta.Kasa.EwidencjaSP` | bazodanowe, tylko-odczyt |  |  |
| Ksiegowanie | `Soneta.Kasa.TypKsiegowaniaObrotuMW` (enum) | bazodanowe, tylko-odczyt |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| ObrotWedlug | `Soneta.Kasa.ObrótMWWedług` (enum) | bazodanowe, tylko-odczyt |  |  |
| Okres | `Soneta.Kasa.OkresMW` | bazodanowe, tylko-odczyt |  | Okres magazynu walut, do którego został naliczony obrót. |
| Przychod | `Soneta.Kasa.PartiaMW` (subrow) | bazodanowe |  |  |
| Przychod.Czas | `Time` | bazodanowe, tylko-odczyt |  |  |
| Przychod.Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Przychod.Kurs | `double` | bazodanowe |  |  |
| Przychod.Kwota | `Currency` | tylko-odczyt |  |  |
| Przychod.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Przychod.Zapłata | `Soneta.Kasa.Zaplata` | tylko-odczyt |  |  |
| Rozchod | `Soneta.Kasa.PartiaMW` (subrow) | bazodanowe |  |  |
| RozchodWgKursu | `Soneta.Kasa.PartiaMW` (subrow) | bazodanowe |  |  |
| RóżnicaKursowa | `decimal` | tylko-odczyt |  |  |
| Strata | `decimal` | tylko-odczyt |  |  |
| TypRK | `Soneta.Kasa.TypRoznicyKursowej` (enum) | tylko-odczyt | Typ różnicy kursowej |  |
| Wartość | `decimal` | tylko-odczyt |  |  |
| Wplata | `Soneta.Kasa.Wplata` | bazodanowe, tylko-odczyt |  |  |
| Wyplata | `Soneta.Kasa.Wyplata` | bazodanowe, tylko-odczyt |  |  |
| Zysk | `decimal` | tylko-odczyt |  |  |

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
