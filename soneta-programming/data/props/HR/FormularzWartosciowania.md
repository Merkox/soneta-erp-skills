# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Formularze.FormularzWartosciowania`
Nazwa tabeli: `ZklFormularzWart`
Tytuł: Formularze wartościowania
Opis: Dokument wartościowania stanowisk pracy. Grupuje stanowiska do wyceny punktowej na podstawie wybranej macierzy wartościowania, umożliwiając zbiorczą ocenę i zatwierdzenie wyników.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataWartosciowania | `Soneta.Types.Date` | bazodanowe | Data wartościowania |  |
| Macierz | `Soneta.HR.ZKL.Wartosciowanie.Macierze.MacierzWartosciowania` | bazodanowe | Macierz |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
| Stanowiska | `Soneta.Business.SubTable<Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.WartosciowanieStanowiska>` |  |  |  |
| Zatwierdzone | `bool` | bazodanowe | Zatwierdzone |  |
