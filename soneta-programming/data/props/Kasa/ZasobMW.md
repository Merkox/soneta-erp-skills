# Pola i właściwości klasy biznesowej: `Soneta.Kasa.ZasobMW`
Nazwa tabeli: `ZasobyMW`
Tytuł: Zasoby
Opis: Zasób (partia) w magazynie walut reprezentujący stan środków walutowych z konkretnej wpłaty. Przechowuje kurs nabycia waluty, datę i wartość partii, umożliwiając wycenę rozchodu metodą FIFO i wyliczanie różnic kursowych przy wypłatach.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokEwidencji | `Soneta.Core.DokEwidencji` | bazodanowe |  |  |
| Ewidencja | `Soneta.Kasa.EwidencjaSP` | bazodanowe |  |  |
| Kierunek | `Soneta.Core.KierunekPlatnosci` | bazodanowe, enum |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Okres | `Soneta.Kasa.OkresMW` | bazodanowe |  | Okres magazynu walut, do którego został naliczony zasób. |
| Partia | `Soneta.Kasa.PartiaMW` | bazodanowe |  |  |
| Partia.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Partia.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Partia.Kurs | `double` | bazodanowe |  |  |
| Partia.Kwota | `Soneta.Types.Currency` |  |  |  |
| Partia.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Partia.Zapłata | `Soneta.Kasa.Zaplata` |  |  |  |
| Przychod | `Soneta.Kasa.PartiaMW` |  |  |  |
| Rozchod | `Soneta.Kasa.PartiaMW` |  |  |  |
| Wpłata | `Soneta.Types.Currency` |  |  |  |
| Wypłata | `Soneta.Types.Currency` |  |  |  |
| Zaplata | `Soneta.Kasa.Zaplata` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekPlatnosci (`Soneta.Core.KierunekPlatnosci`)
- `Brak` = 0
- `Przychod` = 1 — Przychód
- `Rozchod` = 2 — Rozchód
