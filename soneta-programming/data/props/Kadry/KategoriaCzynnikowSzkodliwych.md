# Pola i właściwości klasy biznesowej: `Soneta.Kadry.KategoriaCzynnikowSzkodliwych`
Nazwa tabeli: `KatCzynnSzkod`
Tytuł: Kategorie czynników szkodliwych
Opis: Słownik kategorii czynników szkodliwych występujących w środowisku pracy (np. czynniki chemiczne, fizyczne, biologiczne). Służy do klasyfikacji zagrożeń na stanowiskach pracy.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` |  |  |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |
