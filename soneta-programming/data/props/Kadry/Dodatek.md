# Pola i właściwości klasy biznesowej: `Soneta.Kadry.Dodatek`
Nazwa tabeli: `Dodatki`
Opis: Dodatek do wynagrodzenia pracownika (np. premia regulaminowa, dodatek funkcyjny). Zawiera nazwę dodatku, datę zakończenia wypłaty, przyczynę zakończenia i opcjonalne powiązanie ze źródłem (etatem lub umową).
Tabela konfiguracyjna: Nie
Guided: root
Historyczna: Tak — wersje (historia) w tabeli `DodHistoria`
Implementuje interfejsy: `IBazaZrodlaWyplaty`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | tylko-odczyt |  |  |
| DataZakonczeniaWyplaty | `Date` | bazodanowe | Data zakończenia wypłaty |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| ElementyAktywne | `System.Collections.Generic.ICollection<Soneta.Place.WypElement>` | podlista | Aktywne elementy wynagrodzenia |  |
| Historia | `HistorySubTable<Soneta.Kadry.DodHistoria>` | podlista |  |  |
| Last | `Soneta.Kadry.DodHistoria` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Powiazanie | `Soneta.Kadry.IPowiązanieDodatku` | bazodanowe, iface-ref |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| PrzyczynaZakonczenia | `Soneta.Kadry.PrzyczynaZakonczeniaDodatku` (enum) | bazodanowe | Przyczyna zakończenia |  |
| Rodzina | `Soneta.Kadry.CzlonekRodziny` | tylko-odczyt |  |  |
| SąAktywneElementy | `bool` | tylko-odczyt |  |  |
| Umowa | `Soneta.Kadry.Umowa` | tylko-odczyt |  |  |

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
