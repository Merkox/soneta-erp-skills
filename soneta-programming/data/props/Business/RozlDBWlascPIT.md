# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RozlDBWlascPIT`
Nazwa tabeli: `RozlDBWlascPITy`
Tytuł: Rozliczenia podatkowe bazy danych - PIT Właściciela
Opis: Rozliczenie zaliczki PIT właściciela firmy za okres rozliczeniowy. Zawiera przychody, koszty, dochód, kwoty do zapłaty i termin płatności.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 15
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyRyczalt | `bool` | bazodanowe | Czy Ryczalt |  |
| DoZaplaty | `Soneta.Types.Currency` | bazodanowe | Do zapłaty |  |
| Dochod | `Soneta.Types.Currency` | bazodanowe | Dochód/Strata |  |
| Koszty | `Soneta.Types.Currency` | bazodanowe | Koszty |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe | Kwota |  |
| KwotaPlatnosci | `Soneta.Types.Currency` | bazodanowe | Kwota płatności |  |
| MikrorachunekPodatkowy | `string` | bazodanowe | Mikrorachunek podatkowy |  |
| PITType | `string` | bazodanowe | Rodzaj zaliczki |  |
| Przychody | `Soneta.Types.Currency` | bazodanowe | Przychód |  |
| Rozliczenie | `Soneta.Business.Db.RozliczenieDB` | bazodanowe |  |  |
| SkladkaSpolecznaOplacona | `Soneta.Types.Currency` | bazodanowe | Składka społeczna opłacona |  |
| StatusInfo | `string` | bazodanowe | Status |  |
| TerminPlatnosci | `Soneta.Types.Date` | bazodanowe | Termin płatności PIT |  |
| Wlasciciel | `string` | bazodanowe | Właściciel |  |
| ZaMiesiac | `Soneta.Types.YearMonth` | bazodanowe | Za miesiąc |  |
