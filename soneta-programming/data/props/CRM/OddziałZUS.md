# Pola i właściwości klasy biznesowej: `Soneta.CRM.OddziałZUS`
Nazwa tabeli: `OddzialyZUS`
Tytuł: Oddziały ZUS
Opis: Słownik oddziałów Zakładu Ubezpieczeń Społecznych. Służy do ewidencji danych adresowych i kontaktowych poszczególnych oddziałów ZUS, wykorzystywanych przy obsłudze dokumentów zgłoszeniowych i rozliczeniowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| Kod | `string` | bazodanowe |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaFormatowana | `string` |  |  |  |
| NazwaPierwszaLinia | `string` |  |  |  |
| Osoba | `Soneta.Core.Osoba` | bazodanowe |  |  |
| Osoba.Adres | `string` | bazodanowe |  |  |
| Osoba.Osoba | `string` | bazodanowe |  |  |
| Osoba.Telefon | `string` | bazodanowe |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |
