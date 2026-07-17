# Pola i właściwości klasy biznesowej: `Soneta.HR.DostawcaSzkoleń`
Nazwa tabeli: `DostawcySzkolen`
Tytuł: Dostawcy szkoleń
Opis: Rejestr zewnętrznych firm szkoleniowych powiązanych z kontrahentami. Przechowuje dane kontaktowe dostawcy i osobę odpowiedzialną, umożliwiając zarządzanie relacjami z podmiotami realizującymi szkolenia.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| EuVAT | `string` | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| NIP | `string` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
| Oferty | `Soneta.Business.SubTable<Soneta.HR.OfertaSzkolenia>` |  |  |  |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
