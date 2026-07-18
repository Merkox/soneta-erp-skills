# Pola i właściwości klasy biznesowej: `Soneta.HR.DostawcaSzkoleń`
Nazwa tabeli: `DostawcySzkolen`
Tytuł: Dostawcy szkoleń
Opis: Rejestr zewnętrznych firm szkoleniowych powiązanych z kontrahentami. Przechowuje dane kontaktowe dostawcy i osobę odpowiedzialną, umożliwiając zarządzanie relacjami z podmiotami realizującymi szkolenia.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` | tylko-odczyt |  |  |
| EuVAT | `string` | bazodanowe, tylko-odczyt |  |  |
| Kod | `string` | bazodanowe, tylko-odczyt |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe, tylko-odczyt |  |  |
| NIP | `string` | bazodanowe, tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe, tylko-odczyt |  |  |
| NazwaFormatowana | `string` | tylko-odczyt |  |  |
| NazwaPierwszaLinia | `string` | tylko-odczyt |  |  |
| Oferty | `SubTable<Soneta.HR.OfertaSzkolenia>` | podlista |  |  |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
