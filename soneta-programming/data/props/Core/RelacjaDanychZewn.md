# Pola i właściwości klasy biznesowej: `Soneta.Core.RelacjaDanychZewn`
Nazwa tabeli: `RelacjeDanychZ`
Tytuł: Relacje danych z systemów zewnętrznych
Opis: Powiązanie danych z systemu zewnętrznego z obiektami wewnętrznymi programu. ŝączy rekord danych zewnętrznych z konkretnym obiektem (GUID i tabela) w systemie.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 3
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DaneZewn | `Soneta.Core.DaneZewn` | bazodanowe | Dane zewnętrzne | Wskazanie na dane zewnętrzne |
| Zapis | `System.Guid` | bazodanowe | Identyfikator obiektu programu | Wskazanie na obiekt programu |
| ZapisTabela | `string` | bazodanowe | Typ obiektu programu | Typ obiektu programu |
