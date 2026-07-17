# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.Team`
Nazwa tabeli: `Teams`
Tytuł: Zespół
Opis: Kartoteka zespołów obsługi zgłoszeń serwisowych w module ServiceDesk. Grupuje operatorów wsparcia w jednostki organizacyjne odpowiedzialne za realizację zgłoszeń, z możliwością przypisania danych kontaktowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDaneKontaktoweHost`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Contact | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Contact.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Contact.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Contact.Skype | `string` |  |  |  |
| Contact.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Contact.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| DomyslnyAdres | `Soneta.Core.AdresExt` |  |  |  |
| Email | `string` |  |  |  |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| Name | `string` | bazodanowe | Nazwa |  |
| OperatorToTeam | `Soneta.Business.SubTable<Soneta.Support.Support.OperatorToTeam>` |  |  |  |
| ReceiverId | `int` |  |  |  |
| ReceiverType | `string` |  |  |  |
