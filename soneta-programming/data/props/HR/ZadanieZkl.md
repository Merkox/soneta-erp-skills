# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Zadania.ZadanieZkl`
Nazwa tabeli: `ZklZadania`
Tytuł: Zadania
Opis: Tabela zawiera definicje zadań w ZKL. Wykorzystywany w profilu zadań stanowi  podstawę do opisu obowiązków.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Czynnosci | `Soneta.Business.SubTable<Soneta.HR.ZKL.Slowniki.Zadania.CzynnoscZadania>` |  |  |  |
| Grupa | `Soneta.HR.ZKL.Slowniki.Zadania.GrupaZadan` | bazodanowe | Grupa zadań |  |
| Nazwa | `string` |  |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| Tresc | `string` | bazodanowe | Treść |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` |  |  |  |
