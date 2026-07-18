# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RozlDBWlascZUS`
Nazwa tabeli: `RozlDBWlascZUSy`
Tytuł: Rozliczenia podatkowe bazy danych - ZUS Właściciela
Opis: Rozliczenie składek ZUS właściciela firmy za okres rozliczeniowy. Zawiera składki społeczne, zdrowotne, FP/FGŚP, FEP oraz łączną kwotę do zapłaty.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 5
- podlisty: 0
- subrowy: 0
- razem: 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FEP | `decimal` | tylko-odczyt | FEP |  |
| FEPKwota | `Currency` | bazodanowe | FEP kwota |  |
| Fundusze | `decimal` | tylko-odczyt | FP i FGŚP |  |
| FunduszeKwota | `Currency` | bazodanowe | FP i FGŚP kwota |  |
| Ident | `string` | bazodanowe | Identyfikator |  |
| IndywidualnyRachunekZUS | `string` | bazodanowe | Indywidualny rachunek ZUS |  |
| RazemDoZaplatyKwota | `Currency` | bazodanowe | Razem do zapłaty kwota |  |
| RazemDoZapłaty | `decimal` | tylko-odczyt | Razem do zapłaty |  |
| RokMiesiac | `YearMonth` | bazodanowe | Za miesiąc |  |
| Rozliczenie | `Db.RozliczenieDB` | bazodanowe |  |  |
| SpoleczneKwota | `Currency` | bazodanowe | Społeczne kwota |  |
| Społeczne | `decimal` | tylko-odczyt | Społeczne |  |
| StatusInfo | `string` | bazodanowe | Status |  |
| TerminPlatnosci | `Date` | bazodanowe | Termin płatności DRA |  |
| Wlasciciel | `string` | bazodanowe | Właściciel |  |
| Zdrowotne | `decimal` | tylko-odczyt | Zdrowotne |  |
| ZdrowotneKwota | `Currency` | bazodanowe | Zdrowotne kwota |  |
