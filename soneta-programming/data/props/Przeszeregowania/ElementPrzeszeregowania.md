# Pola i właściwości klasy biznesowej: `Soneta.Przeszeregowania.ElementPrzeszeregowania`
Nazwa tabeli: `ElementyPrzeszer`
Tytuł: Elementy przeszeregowań
Opis: Element szczegółowy przeszeregowania (Przeszeregowanie). Określa zmianę warunków dla konkretnego pracownika: nową kwotę, procent, grupę zaszeregowania lub krotność składnika wynagrodzenia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Przeszeregowanie` → `Przeszeregowanie`

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 4
- podlisty: 0
- subrowy: 0
- razem: 18

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataKwoty | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Grupa | `Soneta.Kadry.GrupaZaszeregowania` | bazodanowe |  |  |
| Krotnosc | `double` | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| KwotaPrecyzja | `Soneta.Place.PrecyzjaZaokraglenia` (enum) | bazodanowe |  |  |
| KwotaSposob | `Soneta.Place.SposobZaokraglenia` (enum) | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Procent | `Percent` | bazodanowe |  |  |
| ProcentowaZmianaKwoty | `Percent` | bazodanowe |  |  |
| Przeszeregowanie | `Soneta.Przeszeregowania.Przeszeregowanie` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| RodzajPrzeszergowania | `Soneta.Przeszeregowania.RodzajPrzeszergowania` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wskaznik | `string` | bazodanowe |  |  |
| ZmianaKrotnosci | `double` | bazodanowe |  |  |
| ZmianaKwoty | `Currency` | bazodanowe |  |  |
| ZmianaProcentu | `Percent` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PrecyzjaZaokraglenia (`Soneta.Place.PrecyzjaZaokraglenia`)
- `DoPełnychSetekZłotych` = -2
- `DoPełnychPięciuDziesiątekZłotych` = -501
- `DoPełnychDziesiątekZłotych` = -1 — Do pełnych dziesiątek złotych
- `DoPełnychPięciuZłotych` = 500
- `DoPełnegoZłotego` = 0
- `DoPełnychPięciuDziesiątekGroszy` = 501
- `DoPełnychDziesiątekGroszy` = 1
- `DoPełnychPięciuGroszy` = 502
- `DoPełnegoGrosza` = 2

### SposobZaokraglenia (`Soneta.Place.SposobZaokraglenia`)
- `Standardowe` = 0
- `ZawszeWDół` = 1
- `ZawszeWGórę` = 2

### RodzajPrzeszergowania (`Soneta.Przeszeregowania.RodzajPrzeszergowania`)
- `ZmianaStawki` = 1 — Zmiana stawki
- `NowyDodatek` = 2
- `ZakończDodatek` = 3
- `ZmianaDodatku` = 4
- `DodajNagrodę` = 5
- `DodanieLubZmianaDodatku` = 6
