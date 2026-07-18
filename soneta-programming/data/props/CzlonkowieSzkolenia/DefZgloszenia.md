# Pola i właściwości klasy biznesowej: `Soneta.CzlonkowieSzkolenia.DefZgloszenia`
Nazwa tabeli: `DefZgloszen`
Tytuł: Definicje zgłoszeń
Opis: Słownik definicji zgłoszeń na szkolenia określający parametry dokumentów zgłoszeniowych. Definiuje schemat numeracji, typ zgłoszenia (indywidualne lub zbiorcze) oraz oddział firmy.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 1
- razem: 11

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Zablokowane | Określa zablokowanie definicji. |
| DrugiSymbol | `string` | bazodanowe | Alternatywny symbol zgłoszenia | Alternatywny symbol zgłoszenia. |
| Nazwa | `string` | bazodanowe | Nazwa zgłoszenia | Nazwa zgłoszenia. |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe | Schemat numeracji dla zgłoszeń | Schemat numeracji dla zgłoszeń. |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy. |
| Symbol | `string` | bazodanowe | Symbol zgłoszenia | Symbol zgłoszenia. |
| Zbiorcze | `bool` | bazodanowe | Zgłoszenie zbiorcze | Zgłoszenie zbiorcze. |
