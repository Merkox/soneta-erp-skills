# Pola i właściwości klasy biznesowej: `Soneta.Core.CelKontaktu`
Nazwa tabeli: `CeleKontaktow`
Tytuł: Cele kontaktów
Opis: Powiązanie danych kontaktowych z celami kontaktu ze słownika. Umożliwia przypisanie kontaktowi (np. numerowi telefonu) celu biznesowego, takiego jak zamówienia, reklamacje czy faktury.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Cel | `Soneta.Core.SlownikElem` | bazodanowe | Cel | Cel kontaktu |
| DaneKontaktowe | `Soneta.Core.DaneKontaktowe` | bazodanowe | Dane kontaktowe | Dane kontaktowe |
