# Pola i właściwości klasy biznesowej: `Soneta.Towary.KodTwrKontrahent`
Nazwa tabeli: `KodyTwrKontrah`
Tytuł: Kod towaru
Opis: Powiązanie kodu kreskowego towaru z kontrahenta. Przechowuje obce kody kreskowe towarów stosowane przez poszczególnych kontrahentów (dostawców, odbiorców), co umożliwia automatyczną identyfikację towaru na podstawie kodu kontrahenta podczas przyjmowania lub wydawania dokumentów.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Kod | `Soneta.Core.KodKreskowy` | bazodanowe | Kod kreskowy | Kod kreskowy przypisany do kontrahenta. |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe | Kontrahent | Kontrahent do którego przypisany jest kod kreskowy. |
| Towar | `Soneta.Towary.Towar` | bazodanowe | Towar | Towar do którego przypisany jest kod kreskowy. |
