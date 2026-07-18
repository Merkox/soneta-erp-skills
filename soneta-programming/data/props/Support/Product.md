# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.Product`
Nazwa tabeli: `ProductsSupport`
Tytuł: Produkty
Opis: Słownik produktów obsługiwanych w module wsparcia technicznego. Umożliwia klasyfikację zgłoszeń serwisowych według produktu, którego dotyczą, z możliwością kontroli widoczności dla klientów zewnętrznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `string` | bazodanowe | Kod |  |
| Description | `string` | bazodanowe | Opis |  |
| Name | `string` | bazodanowe | Nazwa |  |
| VisibleForClient | `bool` | bazodanowe | Widoczny dla klienta |  |
