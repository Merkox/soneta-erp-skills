# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZmianaWkładuFunduszuPozyczkowego`
Nazwa tabeli: `ZmianaWklFundPoz`
Tytuł: Zmiany wkładów do funduszy pożyczkowych
Opis: Operacja zmiany wkładu w funduszu pożyczkowym pracownika (dopłata lub wypłata). Rejestruje kierunek operacji, datę, kwotę, element płacowy rozliczenia oraz opis operacji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 2
- subrowy: 0
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  | Data wykonania operacji |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| Fundusz | `Soneta.Kadry.FundPozyczkowy` | bazodanowe, tylko-odczyt |  |  |
| Kierunek | `Soneta.Kadry.KierunekZmianyWkładuFunduszuPożyczkowego` (enum) | bazodanowe, tylko-odczyt |  |  |
| Kwota | `Currency` | bazodanowe |  | Kwota dopłaty/wypłaty |
| KwotaDopłaty | `Currency` | tylko-odczyt |  |  |
| KwotaWycofania | `Currency` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis informacji o zmianie wkładu funduszu pożyczkowego |
| Rozliczone | `bool` | tylko-odczyt |  |  |
| Spłacona | `bool` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekZmianyWkładuFunduszuPożyczkowego (`Soneta.Kadry.KierunekZmianyWkładuFunduszuPożyczkowego`)
- `WycofanieWkładu` = -1
- `Dopłata` = 1
