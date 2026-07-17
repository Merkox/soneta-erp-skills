# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RozlDBWlascZUS`
Nazwa tabeli: `RozlDBWlascZUSy`
Tytuł: Rozliczenia podatkowe bazy danych - ZUS Właściciela
Opis: Rozliczenie składek ZUS właściciela firmy za okres rozliczeniowy. Zawiera składki społeczne, zdrowotne, FP/FGŚP, FEP oraz łączną kwotę do zapłaty.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| FEP | `decimal` |  | FEP |  |
| FEPKwota | `Soneta.Types.Currency` | bazodanowe | FEP kwota |  |
| Fundusze | `decimal` |  | FP i FGŚP |  |
| FunduszeKwota | `Soneta.Types.Currency` | bazodanowe | FP i FGŚP kwota |  |
| Ident | `string` | bazodanowe | Identyfikator |  |
| IndywidualnyRachunekZUS | `string` | bazodanowe | Indywidualny rachunek ZUS |  |
| RazemDoZaplatyKwota | `Soneta.Types.Currency` | bazodanowe | Razem do zapłaty kwota |  |
| RazemDoZapłaty | `decimal` |  | Razem do zapłaty |  |
| RokMiesiac | `Soneta.Types.YearMonth` | bazodanowe | Za miesiąc |  |
| Rozliczenie | `Soneta.Business.Db.RozliczenieDB` | bazodanowe |  |  |
| SpoleczneKwota | `Soneta.Types.Currency` | bazodanowe | Społeczne kwota |  |
| Społeczne | `decimal` |  | Społeczne |  |
| StatusInfo | `string` | bazodanowe | Status |  |
| TerminPlatnosci | `Soneta.Types.Date` | bazodanowe | Termin płatności DRA |  |
| Wlasciciel | `string` | bazodanowe | Właściciel |  |
| Zdrowotne | `decimal` |  | Zdrowotne |  |
| ZdrowotneKwota | `Soneta.Types.Currency` | bazodanowe | Zdrowotne kwota |  |
