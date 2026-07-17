# Pola i właściwości klasy biznesowej: `Soneta.Core.DefinicjaElementuStrukturyOrganizacyjnej`
Nazwa tabeli: `DefElStrukturOrg`
Tytuł: Definicje elementów struktur organizacyjnych
Opis: Element szczegółowy struktury organizacyjnej (StrukturaOrganizacyjna). Definiuje typ elementu w strukturze (np. dział, stanowisko) z nazwą, dozwolonymi powiązaniami, warunkami i typem obiektu źródła powiązania.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DozwolonePowiazania | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Struktura | `Soneta.Core.StrukturaOrganizacyjna` | bazodanowe |  |  |
| TypZrodlaPowiazania | `string` | bazodanowe | Typ obiektu źródła | Określa typ obiektu źródła powiązania |
| TypZrodlaPowiazaniaTypWiersza | `System.Type` |  |  |  |
| UkryjNaglowek | `bool` | bazodanowe |  |  |
| Warunek1 | `bool` | bazodanowe |  |  |
| Warunek2 | `bool` | bazodanowe |  |  |
| Warunek3 | `bool` | bazodanowe |  |  |
| Warunek4 | `bool` | bazodanowe |  |  |
| Warunek5 | `bool` | bazodanowe |  |  |
| ZrodloUprawnien | `bool` |  | Żródło uprawnień | Określa czy definicja elementu jest źródłem uprawnień |
