# Pola i właściwości klasy biznesowej: `Soneta.Core.RelacjaZewn`
Nazwa tabeli: `RelacjeZewn`
Tytuł: Powiązania obiektów programu z obiektami z systemów zewnętrznych
Opis: Tabela relacji mapująca obiekty wewnętrzne programu na obiekty w systemach zewnętrznych. Przechowuje identyfikator obiektu programu (GUID), typ tabeli, identyfikator zewnętrzny, system zewnętrzny, datę i dodatkowe informacje.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `System.DateTime` | bazodanowe | Data | Data |
| Info | `string` | bazodanowe | Info | Dodatkowe informacje |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe | System zewnętrzny | Wskazanie na system zewnętrzny |
| Zapis | `System.Guid` | bazodanowe | Identyfikator obiektu programu | Wskazanie na obiekt programu |
| ZapisTabela | `string` | bazodanowe | Typ obiektu programu | Typ obiektu programu |
| ZapisZewn | `string` | bazodanowe | Obiekt z systemu zewnętrznego | Wskazanie na obiekt z systemu zewnętrzenego |
| ZapisZewnTyp | `string` | bazodanowe | Rodzaj typu zewnętrznego |  |
