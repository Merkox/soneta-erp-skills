# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.RozliczenieDB`
Nazwa tabeli: `RozliczeniaDB`
Tytuł: Rozliczenia podatkowe bazy danych
Opis: Zbiorcze rozliczenie podatkowe bazy danych klienta za dany okres. Zawiera kwoty VAT, CIT, PIT, ZUS oraz terminy płatności i numery rachunków.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 19
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 20

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DeklaracjaDRAFEP | `Currency` | bazodanowe |  |  |
| DeklaracjaDRAFundusze | `Currency` | bazodanowe |  |  |
| DeklaracjaDRARazemDoZaplaty | `Currency` | bazodanowe |  |  |
| DeklaracjaDRASpoleczne | `Currency` | bazodanowe |  |  |
| DeklaracjaDRATerminPlatnosci | `Date` | bazodanowe |  |  |
| DeklaracjaDRAZdrowotne | `Currency` | bazodanowe |  |  |
| DeklaracjaPIT4RKwota | `Currency` | bazodanowe |  |  |
| DeklaracjaPIT4RTerminPlatnosci | `Date` | bazodanowe |  |  |
| DeklaracjaPIT8ARKwota | `Currency` | bazodanowe |  |  |
| DeklaracjaPIT8ARTerminPlatnosci | `Date` | bazodanowe |  |  |
| DeklaracjaVATKwota | `Currency` | bazodanowe |  |  |
| DeklaracjaVATKwotaDoPrzeniesienia | `Currency` | bazodanowe |  |  |
| DeklaracjaVATKwotaZwrotu | `Currency` | bazodanowe |  |  |
| DeklaracjaVATTerminPlatnosci | `Date` | bazodanowe |  |  |
| DeklaracjaVATTerminZwrotu | `Date` | bazodanowe |  |  |
| IndywidualnyRachunekZUS | `string` | bazodanowe |  |  |
| MikrorachunekPodatkowy | `string` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres |  |
| ZaliczkaCITKwota | `Currency` | bazodanowe |  |  |
| ZaliczkaCITTerminPlatnosci | `Date` | bazodanowe |  |  |
