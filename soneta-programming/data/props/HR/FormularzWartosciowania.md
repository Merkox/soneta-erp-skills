# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Formularze.FormularzWartosciowania`
Nazwa tabeli: `ZklFormularzWart`
Tytuł: Formularze wartościowania
Opis: Dokument wartościowania stanowisk pracy. Grupuje stanowiska do wyceny punktowej na podstawie wybranej macierzy wartościowania, umożliwiając zbiorczą ocenę i zatwierdzenie wyników.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataWartosciowania | `Date` | bazodanowe | Data wartościowania |  |
| Macierz | `Soneta.HR.ZKL.Wartosciowanie.Macierze.MacierzWartosciowania` | bazodanowe | Macierz |  |
| Nazwa | `string` | bazodanowe | Nazwa |  |
| Stanowiska | `SubTable<Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.WartosciowanieStanowiska>` | podlista |  |  |
| Zatwierdzone | `bool` | bazodanowe, tylko-odczyt | Zatwierdzone |  |
