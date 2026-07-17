# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.DBItemPKBROkRoz`
Nazwa tabeli: `DBItemPKBROkRozs`
Tytuł: Status okresów rozliczeniowych PKBR
Opis: Status okresu rozliczeniowego na potrzeby użytkowników PKBR. Zawiera aktualny status okresu rozliczeniowego powiązany z konkretnym kontrahentem, wraz z datami zmian statusu. Rejestruje historię zmian statusów w powiązanej tabeli historii.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DBItem | `Soneta.Business.Db.DBItem` | bazodanowe | Baza danych | Bazy danych |
| DataPonownegoOtwarcia | `System.DateTime` | bazodanowe | Data ponownego otwarcia okresu | Data ponownego otwarcia okresu |
| DataZamkniecia | `System.DateTime` | bazodanowe | Data zamknięcia okresu | Data zamknięcia okresu |
| HistoriaOkresu | `Soneta.Business.SubTable<Soneta.Ksiega.DBIPKBRHist>` |  |  |  |
| OkresRozliczenia | `Soneta.Types.YearMonth` | bazodanowe | Okres rozliczenia | Okres rozliczenia |
| StatusOkresu | `Soneta.Ksiega.TaxMonthStatus` | bazodanowe, enum | Status | Status |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TaxMonthStatus (`Soneta.Ksiega.TaxMonthStatus`)
- `Otwarty` = 1 — Otwarty
- `Zamkniety` = 2 — Zamknięty
- `OtwartyPonownie` = 3 — Otwarty ponownie
