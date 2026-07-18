# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.WartosciowanieStanowiska`
Nazwa tabeli: `ZklWartStanow`
Tytuł: Wartościowania stanowisk
Opis: Element szczegółowy formularza wartościowania (FormularzWartosciowania). Reprezentuje wynik wyceny punktowej konkretnego stanowiska w ramach formularza, powiązany z definicją stanowiska.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 5
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Formularz | `Soneta.HR.ZKL.Wartosciowanie.Formularze.FormularzWartosciowania` | bazodanowe, tylko-odczyt | Formularz wartościowania |  |
| KategoriePracownikow | `string` | bazodanowe, tylko-odczyt | Kategoria pracowników |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe, tylko-odczyt | Stanowisko |  |
| StanowiskoNaDzienWartosciowania | `Soneta.HR.DefinicjaStanowiskaHist` | tylko-odczyt |  |  |
| WycenaPunktowa | `decimal` | bazodanowe, tylko-odczyt | Wycena punktowa |  |
| WynikiPozycji | `SubTable<Soneta.HR.ZKL.Wartosciowanie.Wyniki.WynikPozycjiWartosciowania>` | podlista |  |  |
