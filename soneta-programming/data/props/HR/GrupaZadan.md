# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Zadania.GrupaZadan`
Nazwa tabeli: `ZklKtgZadan`
Tytuł: Katalog zadań
Opis: Definiuje logiczne grupy zadań wykonywanych na stanowiskach. Służy do agregowania i analizowania obowiązków na poziomie funkcjonalnym.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Zadania | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.Zadania.ZadanieZkl>` |  |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
