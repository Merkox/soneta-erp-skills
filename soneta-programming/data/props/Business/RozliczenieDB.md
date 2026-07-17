# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RozliczenieDB`
Nazwa tabeli: `RozliczeniaDB`
Tytuł: Rozliczenia podatkowe bazy danych
Opis: Zbiorcze rozliczenie podatkowe bazy danych klienta za dany okres. Zawiera kwoty VAT, CIT, PIT, ZUS oraz terminy płatności i numery rachunków.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 20
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DeklaracjaDRAFEP | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaDRAFundusze | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaDRARazemDoZaplaty | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaDRASpoleczne | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaDRATerminPlatnosci | `Soneta.Types.Date` | bazodanowe |  |  |
| DeklaracjaDRAZdrowotne | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaPIT4RKwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaPIT4RTerminPlatnosci | `Soneta.Types.Date` | bazodanowe |  |  |
| DeklaracjaPIT8ARKwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaPIT8ARTerminPlatnosci | `Soneta.Types.Date` | bazodanowe |  |  |
| DeklaracjaVATKwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaVATKwotaDoPrzeniesienia | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaVATKwotaZwrotu | `Soneta.Types.Currency` | bazodanowe |  |  |
| DeklaracjaVATTerminPlatnosci | `Soneta.Types.Date` | bazodanowe |  |  |
| DeklaracjaVATTerminZwrotu | `Soneta.Types.Date` | bazodanowe |  |  |
| IndywidualnyRachunekZUS | `string` | bazodanowe |  |  |
| MikrorachunekPodatkowy | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres |  |
| ZaliczkaCITKwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| ZaliczkaCITTerminPlatnosci | `Soneta.Types.Date` | bazodanowe |  |  |
