# Pola i właściwości klasy biznesowej: `Soneta.Towary.TowarEcommerce`
Nazwa tabeli: `TowaryEcommerce`
Tytuł: Dane Ecommerce
Opis: Element szczegółowy towaru (Towar). Przechowuje dane specyficzne dla sprzedaży internetowej, w tym informacje GPSR (producent odpowiedzialny, importer, osoba odpowiedzialna, informacja o bezpieczeństwie). Umożliwia rozszerzenie kartoteki towarowej o atrybuty wymagane przez platformy e-commerce.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Importer | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| InformacjaOBezpeczenstwie | `string` | bazodanowe |  |  |
| OsobaOdpowiedzialna | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| ProducentOdpowiedzialny | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| Towar | `Soneta.Towary.Towar` | bazodanowe, tylko-odczyt | Towar | Towar, do którego przypisane są dane E-commerce. |
| WprowadzenieGPSR | `bool` | bazodanowe | Wprowadzony do obrotu przed obowiązkiem GPSR |  |
