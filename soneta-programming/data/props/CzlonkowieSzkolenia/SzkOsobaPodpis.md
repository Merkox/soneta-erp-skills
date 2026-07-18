# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.SzkOsobaPodpis`
Nazwa tabeli: `SzkOsobyPodpisy`
Tytuł: Osoba podpisująca
Opis: Słownik osób upoważnionych do podpisywania dokumentów szkoleniowych. Przechowuje dane personalne i stanowiska osób podpisujących certyfikaty, zaświadczenia i inne dokumenty wydawane uczestnikom.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywny | `bool` | bazodanowe |  |  |
| Imie | `string` | bazodanowe |  |  |
| Nazwisko | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| Stanowisko | `string` | bazodanowe |  |  |
