# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.SupportOperator`
Nazwa tabeli: `SupportOperators`
Tytuł: Operatorzy wsparcia
Opis: Element szczegółowy operatora (Operator). Rozszerza standardowego operatora systemu o dane kontaktowe specyficzne dla modułu wsparcia technicznego, umożliwiając konfigurację powiadomień i komunikacji w ramach obsługi zgłoszeń.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Operator` → `Operator`
Implementuje interfejsy: `IDaneKontaktoweHost`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 1
- razem: 8

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Contact | `Soneta.Core.Kontakt` (subrow) | bazodanowe |  |  |
| Contact.EMAIL | `string` | bazodanowe |  | Adres poczty elektronicznej |
| Contact.SkrytkaPocztowa | `string` | bazodanowe |  | Skrytka pocztowa |
| Contact.Skype | `string` |  |  |  |
| Contact.TelefonKomorkowy | `string` | bazodanowe |  | Numer telefonu komórkowego |
| Contact.WWW | `string` | bazodanowe |  | Adres strony internetowej |
| Kontakty | `SubTable<Soneta.Core.DaneKontaktowe>` | podlista |  |  |
| Operator | `App.Operator` | bazodanowe, guided-parent |  |  |
