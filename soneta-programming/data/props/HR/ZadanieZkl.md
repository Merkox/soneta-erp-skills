# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Zadania.ZadanieZkl`
Nazwa tabeli: `ZklZadania`
Tytuł: Zadania
Opis: Tabela zawiera definicje zadań w ZKL. Wykorzystywany w profilu zadań stanowi  podstawę do opisu obowiązków.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 2
- podlisty: 1
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Czynnosci | `SubTable<Soneta.HR.ZKL.Slowniki.Zadania.CzynnoscZadania>` | podlista |  |  |
| Grupa | `Soneta.HR.ZKL.Slowniki.Zadania.GrupaZadan` | bazodanowe, tylko-odczyt | Grupa zadań |  |
| Nazwa | `string` |  |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Tresc | `string` | bazodanowe | Treść |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
