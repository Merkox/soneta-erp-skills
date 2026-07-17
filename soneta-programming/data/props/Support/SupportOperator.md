# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.SupportOperator`
Nazwa tabeli: `SupportOperators`
Tytuł: Operatorzy wsparcia
Opis: Element szczegółowy operatora (Operator). Rozszerza standardowego operatora systemu o dane kontaktowe specyficzne dla modułu wsparcia technicznego, umożliwiając konfigurację powiadomień i komunikacji w ramach obsługi zgłoszeń.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operator` → `Operator`
Implementuje interfejsy: `IDaneKontaktoweHost`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Contact | `Soneta.Core.Kontakt` | bazodanowe |  |  |
| Contact.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Contact.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Contact.Skype | `string` |  |  |  |
| Contact.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Contact.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `Soneta.Business.SubTable<Soneta.Core.DaneKontaktowe>` |  |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe, guided-parent |  |  |
