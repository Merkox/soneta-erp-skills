# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Zadania.GrupaZadan`
Nazwa tabeli: `ZklKtgZadan`
Tytuł: Katalog zadań
Opis: Definiuje logiczne grupy zadań wykonywanych na stanowiskach. Służy do agregowania i analizowania obowiązków na poziomie funkcjonalnym.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Zadania | `SubTable<Soneta.HR.ZKL.Slowniki.Zadania.ZadanieZkl>` | podlista |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
