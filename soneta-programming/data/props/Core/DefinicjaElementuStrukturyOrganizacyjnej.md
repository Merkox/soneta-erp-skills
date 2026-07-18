# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaElementuStrukturyOrganizacyjnej`
Nazwa tabeli: `DefElStrukturOrg`
Tytuł: Definicje elementów struktur organizacyjnych
Opis: Element szczegółowy struktury organizacyjnej (StrukturaOrganizacyjna). Definiuje typ elementu w strukturze (np. dział, stanowisko) z nazwą, dozwolonymi powiązaniami, warunkami i typem obiektu źródła powiązania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 0
- subrowy: 0
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DozwolonePowiazania | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Struktura | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe, tylko-odczyt |  |  |
| TypZrodlaPowiazania | `string` | bazodanowe | Typ obiektu źródła | Określa typ obiektu źródła powiązania |
| TypZrodlaPowiazaniaTypWiersza | `System.Type` | tylko-odczyt |  |  |
| UkryjNaglowek | `bool` | bazodanowe |  |  |
| Warunek1 | `bool` | bazodanowe |  |  |
| Warunek2 | `bool` | bazodanowe |  |  |
| Warunek3 | `bool` | bazodanowe |  |  |
| Warunek4 | `bool` | bazodanowe |  |  |
| Warunek5 | `bool` | bazodanowe |  |  |
| ZrodloUprawnien | `bool` | tylko-odczyt | Żródło uprawnień | Określa czy definicja elementu jest źródłem uprawnień |
