# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZgloszeniePlatnik`
Nazwa tabeli: `ZgloszeniaPlat`
Tytuł: Płatnicy
Opis: Płatnicy powiązani ze zgłoszeniem uczestnika na szkolenie. Umożliwia wskazanie kontrahentów (firm, instytucji) pokrywających koszty szkolenia danego uczestnika wraz z kwotami.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe | Data dodania | Data dodania. |
| Platnik | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| Wartosc | `Currency` | bazodanowe |  |  |
| ZgloszenieUczestnik | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |
