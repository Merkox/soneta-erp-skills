# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RozlDBWlascRycz`
Nazwa tabeli: `RozlDBWlascRyczy`
Tytuł: Rozliczenia podatkowe bazy danych - Ryczałt Właściciela
Opis: Rozliczenie ryczałtu od przychodów ewidencjonowanych właściciela firmy. Zawiera kwoty płatności, termin i numer mikrorachunku podatkowego.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzyRyczalt | `bool` | bazodanowe | Czy Ryczalt |  |
| KwotaPlatnosci | `Currency` | bazodanowe | Kwota płatności |  |
| MikrorachunekPodatkowy | `string` | bazodanowe | Mikrorachunek podatkowy |  |
| PITType | `string` | bazodanowe | Rodzaj zaliczki |  |
| Rozliczenie | `Db.RozliczenieDB` | bazodanowe |  |  |
| StatusInfo | `string` | bazodanowe | Status |  |
| TerminPlatnosci | `Date` | bazodanowe | Termin płatności PIT |  |
| Wlasciciel | `string` | bazodanowe | Właściciel |  |
