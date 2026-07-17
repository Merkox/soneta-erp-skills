# Pola i właściwości klasy biznesowej: `Soneta.Support.Support.Product`
Nazwa tabeli: `ProductsSupport`
Tytuł: Produkty
Opis: Słownik produktów obsługiwanych w module wsparcia technicznego. Umożliwia klasyfikację zgłoszeń serwisowych według produktu, którego dotyczą, z możliwością kontroli widoczności dla klientów zewnętrznych.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Code | `string` | bazodanowe | Kod |  |
| Description | `string` | bazodanowe | Opis |  |
| Name | `string` | bazodanowe | Nazwa |  |
| VisibleForClient | `bool` | bazodanowe | Widoczny dla klienta |  |
