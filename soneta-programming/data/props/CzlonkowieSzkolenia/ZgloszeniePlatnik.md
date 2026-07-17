# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.ZgloszeniePlatnik`
Nazwa tabeli: `ZgloszeniaPlat`
Tytuł: Płatnicy
Opis: Płatnicy powiązani ze zgłoszeniem uczestnika na szkolenie. Umożliwia wskazanie kontrahentów (firm, instytucji) pokrywających koszty szkolenia danego uczestnika wraz z kwotami.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe | Data dodania | Data dodania. |
| Platnik | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe |  |  |
| ZgloszenieUczestnik | `Soneta.CzlonkowieSzkolenia.ZgloszenieUczestnik` | bazodanowe |  |  |
