# Pola i właściwości klasy biznesowej: `Soneta.Kadry.KategoriaCzynnikowSzkodliwych`
Nazwa tabeli: `KatCzynnSzkod`
Tytuł: Kategorie czynników szkodliwych
Opis: Słownik kategorii czynników szkodliwych występujących w środowisku pracy (np. czynniki chemiczne, fizyczne, biologiczne). Służy do klasyfikacji zagrożeń na stanowiskach pracy.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` |  |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
