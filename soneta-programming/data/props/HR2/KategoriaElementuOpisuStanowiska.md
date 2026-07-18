# Pola i właściwości klasy biznesowej: `Soneta.HR2.KategoriaElementuOpisuStanowiska`
Nazwa tabeli: `KatElOpisuStanow`
Tytuł: Kategorie elementów opisu stanowisk
Opis: Słownik kategorii elementów opisu stanowiska (np. wymagania, obowiązki, warunki pracy). Służy do klasyfikacji treści na kartach opisu stanowisk w logiczne sekcje.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Definicje | `SubTable<Soneta.HR2.DefinicjaElementuOpisuStanowiska>` | podlista |  |  |
| Nazwa | `string` | bazodanowe |  |  |
