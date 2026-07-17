# Pola i właściwości klasy biznesowej: `Soneta.Core.KSeFAwaria`
Nazwa tabeli: `KSeFAwarie`
Tytuł: Awarie i przerwy w działaniu KSeF
Opis: Tabela przechowuje informacje o awariach i przerwach w działaniu Krajowego Systemu e-Faktur (KSeF). Rejestruje zdarzenia z identyfikatorem, rodzajem awarii, datami rozpoczęcia i zakończenia w UTC oraz flagą aktywności.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywna | `bool` | bazodanowe | Aktywna | Aktywna |
| CzasNaDoslanieFaktury | `int` | bazodanowe | Czas na dosłanie faktury wystawionej w trybie offline | Czas na dosłanie faktury wystawionej w trybie offline |
| CzasNaDoslanieFakturySufiks | `string` |  |  |  |
| DataRozpoczecia | `Soneta.Types.DateShortTime` |  |  |  |
| DataRozpoczeciaDate | `Soneta.Types.Date` |  |  |  |
| DataRozpoczeciaDateTimeUtc | `System.DateTime` | bazodanowe | Data i godzina rozpoczęcia awarii w UTC | Data i godzina rozpoczęcia awarii w UTC |
| DataRozpoczeciaOffset | `string` | bazodanowe |  |  |
| DataRozpoczeciaTime | `Soneta.Types.Time` |  |  |  |
| DataRozpoczeciaUtc | `System.DateTime` |  |  |  |
| DataZakonczenia | `Soneta.Types.DateShortTime` |  |  |  |
| DataZakonczeniaDate | `Soneta.Types.Date` |  |  |  |
| DataZakonczeniaDateTimeUtc | `System.DateTime` | bazodanowe | Data i godzina zakończenia awarii w UTC | Data i godzina zakończenia awarii w UTC |
| DataZakonczeniaOffset | `string` | bazodanowe |  |  |
| DataZakonczeniaTime | `Soneta.Types.Time` |  |  |  |
| DataZakonczeniaUtc | `System.DateTime` |  |  |  |
| IdZdarzenia | `int` | bazodanowe | Id zdarzenia | Id zdarzenia |
| KomunikatyLatarni | `Soneta.Business.SubTable<Soneta.Core.KSeFAwariaKomunikatLatarni>` |  |  |  |
| Opis | `string` |  |  |  |
| PodstawaPrawna | `string` |  |  |  |
| Rodzaj | `Soneta.Core.Enums.RodzajAwariiKSeF` | bazodanowe, enum | Typ | Typ |
| TrescKomunikatu | `string` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajAwariiKSeF (`Soneta.Core.Enums.RodzajAwariiKSeF`)
- `Brak` = 0
- `Offline24` = 1 — Offline24
- `PrzerwaSerwisowa` = 2 — Przerwa serwisowa
- `AwariaZwykla` = 3 — Awaria zwykła
- `AwariaCalkowita` = 4 — Awaria całkowita
