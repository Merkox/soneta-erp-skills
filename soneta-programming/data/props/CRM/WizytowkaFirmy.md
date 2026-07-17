# Pola i właściwości klasy biznesowej: `Soneta.CRM.Wizytowki.WizytowkaFirmy`
Nazwa tabeli: `WizytowkiFirm`
Tytuł: Wizytówki firm
Opis: Wizytówka firmy powiązana z osobą kontaktową. Przechowuje dane firmy (nazwa, NIP, REGON, adres, kontakty), gdy osoba kontaktowa nie jest jeszcze powiązana z kontrahentem, umożliwiając szybkie rejestrowanie nowych kontaktów biznesowych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IAdresHost`, `IRegonHost`, `IDaneKontaktoweHost`, `IEmailElement`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.Adres` |  |  |  |
| DataZakonczeniaDzialalnosci | `Soneta.Types.Date` | bazodanowe | Data zakończenia działalności |  |
| EMAIL | `string` | bazodanowe | Adres e-mail firmy | Określa adres e-mail firmy. |
| KRS | `string` | bazodanowe |  |  |
| Kod | `string` |  |  |  |
| Kontakt | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Kontakt.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Kontakt.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Kontakt.Skype | `string` |  |  |  |
| Kontakt.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Kontakt.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| MailTo | `string` |  |  |  |
| NIP | `string` | bazodanowe | NIP firmy | Określa NIP firmy. |
| Nazwa | `string` |  |  |  |
| NazwaFirmy | `string` | bazodanowe | Nazwa firmy | Określa nazwę firmy. |
| Osoba | `Soneta.CRM.KontaktOsoba` | bazodanowe | Osoba | Osoba, której przyporządkowana jest wizytówka firmy. |
| REGON | `string` | bazodanowe | Regon | Rejestr Gospodarki Narodowej |
| TelefonKomorkowy | `string` | bazodanowe | Numer telefonu komórkowego firmy | Określa numer telefonu komórkowego firmy. |
| WWW | `string` | bazodanowe | Adres internetowy firmy | Określa adres internetowy firmy. |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |
