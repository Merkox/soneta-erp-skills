# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFAwaria`
Nazwa tabeli: `KSeFAwarie`
Tytuł: Awarie i przerwy w działaniu KSeF
Opis: Tabela przechowuje informacje o awariach i przerwach w działaniu Krajowego Systemu e-Faktur (KSeF). Rejestruje zdarzenia z identyfikatorem, rodzajem awarii, datami rozpoczęcia i zakończenia w UTC oraz flagą aktywności.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 6
- pola tylko-odczyt: 6
- podlisty: 1
- subrowy: 0
- razem: 21

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywna | `bool` | bazodanowe | Aktywna | Aktywna |
| CzasNaDoslanieFaktury | `int` | bazodanowe | Czas na dosłanie faktury wystawionej w trybie offline | Czas na dosłanie faktury wystawionej w trybie offline |
| CzasNaDoslanieFakturySufiks | `string` | tylko-odczyt |  |  |
| DataRozpoczecia | `DateShortTime` |  |  |  |
| DataRozpoczeciaDate | `Date` |  |  |  |
| DataRozpoczeciaDateTimeUtc | `System.DateTime` | bazodanowe | Data i godzina rozpoczęcia awarii w UTC | Data i godzina rozpoczęcia awarii w UTC |
| DataRozpoczeciaOffset | `string` | bazodanowe |  |  |
| DataRozpoczeciaTime | `Time` |  |  |  |
| DataRozpoczeciaUtc | `System.DateTime` | tylko-odczyt |  |  |
| DataZakonczenia | `DateShortTime` |  |  |  |
| DataZakonczeniaDate | `Date` |  |  |  |
| DataZakonczeniaDateTimeUtc | `System.DateTime` | bazodanowe | Data i godzina zakończenia awarii w UTC | Data i godzina zakończenia awarii w UTC |
| DataZakonczeniaOffset | `string` | bazodanowe |  |  |
| DataZakonczeniaTime | `Time` |  |  |  |
| DataZakonczeniaUtc | `System.DateTime` | tylko-odczyt |  |  |
| IdZdarzenia | `int` | bazodanowe | Id zdarzenia | Id zdarzenia |
| KomunikatyLatarni | `SubTable<Soneta.Core.KSeFAwariaKomunikatLatarni>` | podlista |  |  |
| Opis | `string` | tylko-odczyt |  |  |
| PodstawaPrawna | `string` | tylko-odczyt |  |  |
| Rodzaj | `Soneta.Core.Enums.RodzajAwariiKSeF` (enum) | bazodanowe | Typ | Typ |
| TrescKomunikatu | `string` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajAwariiKSeF (`Soneta.Core.Enums.RodzajAwariiKSeF`)
- `Brak` = 0
- `Offline24` = 1 — Offline24
- `PrzerwaSerwisowa` = 2 — Przerwa serwisowa
- `AwariaZwykla` = 3 — Awaria zwykła
- `AwariaCalkowita` = 4 — Awaria całkowita
