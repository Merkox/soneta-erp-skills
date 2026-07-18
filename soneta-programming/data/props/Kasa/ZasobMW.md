# Pola i właściwości klasy biznesowej: `Soneta.Kasa.ZasobMW`
Nazwa tabeli: `ZasobyMW`
Tytuł: Zasoby
Opis: Zasób (partia) w magazynie walut reprezentujący stan środków walutowych z konkretnej wpłaty. Przechowuje kurs nabycia waluty, datę i wartość partii, umożliwiając wycenę rozchodu metodą FIFO i wyliczanie różnic kursowych przy wypłatach.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DokEwidencji | `Soneta.Core.DokEwidencji` | bazodanowe, tylko-odczyt |  |  |
| Ewidencja | `Soneta.Kasa.EwidencjaSP` | bazodanowe, tylko-odczyt |  |  |
| Kierunek | `Soneta.Core.KierunekPlatnosci` (enum) | bazodanowe, tylko-odczyt |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| Okres | `Soneta.Kasa.OkresMW` | bazodanowe, tylko-odczyt |  | Okres magazynu walut, do którego został naliczony zasób. |
| Partia | `Soneta.Kasa.PartiaMW` (subrow) | bazodanowe |  |  |
| Partia.Czas | `Time` | bazodanowe, tylko-odczyt |  |  |
| Partia.Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Partia.Kurs | `double` | bazodanowe |  |  |
| Partia.Kwota | `Currency` | tylko-odczyt |  |  |
| Partia.Wartosc | `decimal` | bazodanowe | Wartość |  |
| Partia.Zapłata | `Soneta.Kasa.Zaplata` | tylko-odczyt |  |  |
| Przychod | `Soneta.Kasa.PartiaMW` | tylko-odczyt |  |  |
| Rozchod | `Soneta.Kasa.PartiaMW` | tylko-odczyt |  |  |
| Wpłata | `Currency` | tylko-odczyt |  |  |
| Wypłata | `Currency` | tylko-odczyt |  |  |
| Zaplata | `Soneta.Kasa.Zaplata` | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekPlatnosci (`Soneta.Core.KierunekPlatnosci`)
- `Brak` = 0
- `Przychod` = 1 — Przychód
- `Rozchod` = 2 — Rozchód
