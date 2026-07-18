# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaCzynnikowSzkodliwych`
Nazwa tabeli: `DefCzynnSzkod`
Tytuł: Definicje czynników szkodliwych
Opis: Definicja konkretnego czynnika szkodliwego w środowisku pracy (np. hałas, pył, promieniowanie). Każdy czynnik należy do kategorii i zawiera nazwę, opis oraz status blokady.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Kategoria | `Soneta.Kadry.KategoriaCzynnikowSzkodliwych` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Priorytet | `int` |  |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
