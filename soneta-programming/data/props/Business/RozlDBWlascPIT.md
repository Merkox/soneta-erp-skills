# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RozlDBWlascPIT`
Nazwa tabeli: `RozlDBWlascPITy`
Tytuł: Rozliczenia podatkowe bazy danych - PIT Właściciela
Opis: Rozliczenie zaliczki PIT właściciela firmy za okres rozliczeniowy. Zawiera przychody, koszty, dochód, kwoty do zapłaty i termin płatności.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 15
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyRyczalt | `bool` | bazodanowe | Czy Ryczalt |  |
| DoZaplaty | `Currency` | bazodanowe | Do zapłaty |  |
| Dochod | `Currency` | bazodanowe | Dochód/Strata |  |
| Koszty | `Currency` | bazodanowe | Koszty |  |
| Kwota | `Currency` | bazodanowe | Kwota |  |
| KwotaPlatnosci | `Currency` | bazodanowe | Kwota płatności |  |
| MikrorachunekPodatkowy | `string` | bazodanowe | Mikrorachunek podatkowy |  |
| PITType | `string` | bazodanowe | Rodzaj zaliczki |  |
| Przychody | `Currency` | bazodanowe | Przychód |  |
| Rozliczenie | `Db.RozliczenieDB` | bazodanowe |  |  |
| SkladkaSpolecznaOplacona | `Currency` | bazodanowe | Składka społeczna opłacona |  |
| StatusInfo | `string` | bazodanowe | Status |  |
| TerminPlatnosci | `Date` | bazodanowe | Termin płatności PIT |  |
| Wlasciciel | `string` | bazodanowe | Właściciel |  |
| ZaMiesiac | `YearMonth` | bazodanowe | Za miesiąc |  |
