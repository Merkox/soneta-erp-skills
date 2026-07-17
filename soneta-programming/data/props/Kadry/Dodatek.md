# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Dodatek`
Nazwa tabeli: `Dodatki`
Opis: Dodatek do wynagrodzenia pracownika (np. premia regulaminowa, dodatek funkcyjny). Zawiera nazwę dodatku, datę zakończenia wypłaty, przyczynę zakończenia i opcjonalne powiązanie ze źródłem (etatem lub umową).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` |  |  |  |
| DataZakonczeniaWyplaty | `Soneta.Types.Date` | bazodanowe | Data zakończenia wypłaty |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` |  | Aktywne elementy wynagrodzenia |  |
| Historia | `Soneta.Business.HistorySubTable<Soneta.Kadry.DodHistoria>` |  |  |  |
| Last | `Soneta.Kadry.DodHistoria` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Powiazanie | `Soneta.Kadry.IPowiązanieDodatku` | bazodanowe, iface-ref |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| PrzyczynaZakonczenia | `Soneta.Kadry.PrzyczynaZakonczeniaDodatku` | bazodanowe, enum | Przyczyna zakończenia |  |
| Rodzina | `Soneta.Kadry.CzlonekRodziny` |  |  |  |
| SąAktywneElementy | `bool` |  |  |  |
| Umowa | `Soneta.Kadry.Umowa` |  |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Powiazanie | `IPowiązanieDodatku` | `CzlonekRodziny`, `Umowa` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PrzyczynaZakonczeniaDodatku (`Soneta.Kadry.PrzyczynaZakonczeniaDodatku`)
- `NieDotyczy` = 0
- `Inna` = 1
- `COVID19` = 2 — COVID-19
