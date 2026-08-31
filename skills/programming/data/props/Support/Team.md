# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.Team`
Nazwa tabeli: `Teams`
Tytuł: Zespół
Opis: Kartoteka zespołów obsługi zgłoszeń serwisowych w module ServiceDesk. Grupuje operatorów wsparcia w jednostki organizacyjne odpowiedzialne za realizację zgłoszeń, z możliwością przypisania danych kontaktowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDaneKontaktoweHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Contact | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Contact.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Contact.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Contact.Skype | `string` |  |  |  |
| Contact.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Contact.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| DomyslnyAdres | `Soneta.Core.AdresExt` | tylko-odczyt |  |  |
| Email | `string` |  |  |  |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| OperatorToTeam | `SubTable<Soneta.Support.Support.OperatorToTeam>` | podlista |  |  |
| ReceiverId | `int` | tylko-odczyt |  |  |
| ReceiverType | `string` | tylko-odczyt |  |  |
