# Pola i właściwości klasy biznesowej: `Soneta.HR2.KategoriaElementuOpisuStanowiska`
Nazwa tabeli: `KatElOpisuStanow`
Tytuł: Kategorie elementów opisu stanowisk
Opis: Słownik kategorii elementów opisu stanowiska (np. wymagania, obowiązki, warunki pracy). Służy do klasyfikacji treści na kartach opisu stanowisk w logiczne sekcje.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 2
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicje | `Soneta.Business.SubTable<Soneta.HR2.DefinicjaElementuOpisuStanowiska>` |  |  |  |
| Nazwa | `string` | bazodanowe |  |  |
