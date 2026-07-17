# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaCzynnosciNaObiekcie`
Nazwa tabeli: `DefCzynnOb`
Tytuł: Definicje czynności na obiektach do planowania
Opis: Konfigurowalna definicja czynności wykonywanych na obiektach do planowania. Określa nazwę i nazwę wyświetlaną czynności, która może być przypisywana do zasobów w harmonogramach pracy.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| DefinicjaStrefy | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| NazwaWyswietlana | `string` | bazodanowe |  |  |
