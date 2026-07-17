# Pola i właściwości klasy biznesowej: `Soneta.Kadry.ZmianaWkładuFunduszuPozyczkowego`
Nazwa tabeli: `ZmianaWklFundPoz`
Tytuł: Zmiany wkładów do funduszy pożyczkowych
Opis: Operacja zmiany wkładu w funduszu pożyczkowym pracownika (dopłata lub wypłata). Rejestruje kierunek operacji, datę, kwotę, element płacowy rozliczenia oraz opis operacji.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  | Data wykonania operacji |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| Fundusz | `Soneta.Kadry.FundPozyczkowy` | bazodanowe |  |  |
| Kierunek | `Soneta.Kadry.KierunekZmianyWkładuFunduszuPożyczkowego` | bazodanowe, enum |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  | Kwota dopłaty/wypłaty |
| KwotaDopłaty | `Soneta.Types.Currency` |  |  |  |
| KwotaWycofania | `Soneta.Types.Currency` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis informacji o zmianie wkładu funduszu pożyczkowego |
| Rozliczone | `bool` |  |  |  |
| Spłacona | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekZmianyWkładuFunduszuPożyczkowego (`Soneta.Kadry.KierunekZmianyWkładuFunduszuPożyczkowego`)
- `WycofanieWkładu` = -1
- `Dopłata` = 1
