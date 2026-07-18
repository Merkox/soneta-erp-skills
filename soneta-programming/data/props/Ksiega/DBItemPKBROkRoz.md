# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DBItemPKBROkRoz`
Nazwa tabeli: `DBItemPKBROkRozs`
Tytuł: Status okresów rozliczeniowych PKBR
Opis: Status okresu rozliczeniowego na potrzeby użytkowników PKBR. Zawiera aktualny status okresu rozliczeniowego powiązany z konkretnym kontrahentem, wraz z datami zmian statusu. Rejestruje historię zmian statusów w powiązanej tabeli historii.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBItem | `Db.DBItem` | bazodanowe | Baza danych | Bazy danych |
| DataPonownegoOtwarcia | `System.DateTime` | bazodanowe | Data ponownego otwarcia okresu | Data ponownego otwarcia okresu |
| DataZamkniecia | `System.DateTime` | bazodanowe | Data zamknięcia okresu | Data zamknięcia okresu |
| HistoriaOkresu | `SubTable<Soneta.Ksiega.DBIPKBRHist>` | podlista |  |  |
| OkresRozliczenia | `YearMonth` | bazodanowe | Okres rozliczenia | Okres rozliczenia |
| StatusOkresu | `Soneta.Ksiega.TaxMonthStatus` (enum) | bazodanowe | Status | Status |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TaxMonthStatus (`Soneta.Ksiega.TaxMonthStatus`)
- `Otwarty` = 1 — Otwarty
- `Zamkniety` = 2 — Zamknięty
- `OtwartyPonownie` = 3 — Otwarty ponownie
