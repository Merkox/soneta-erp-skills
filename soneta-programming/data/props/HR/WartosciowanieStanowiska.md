# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Wartosciowanie.Konfiguracja.WartosciowanieStanowiska`
Nazwa tabeli: `ZklWartStanow`
Tytuł: Wartościowania stanowisk
Opis: Element szczegółowy formularza wartościowania (FormularzWartosciowania). Reprezentuje wynik wyceny punktowej konkretnego stanowiska w ramach formularza, powiązany z definicją stanowiska.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Formularz | `Soneta.HR.ZKL.Wartosciowanie.Formularze.FormularzWartosciowania` | bazodanowe | Formularz wartościowania |  |
| KategoriePracownikow | `string` | bazodanowe | Kategoria pracowników |  |
| Stanowisko | `Soneta.HR.DefinicjaStanowiska` | bazodanowe | Stanowisko |  |
| StanowiskoNaDzienWartosciowania | `Soneta.HR.DefinicjaStanowiskaHist` |  |  |  |
| WycenaPunktowa | `decimal` | bazodanowe | Wycena punktowa |  |
| WynikiPozycji | `Soneta.Business.SubTable<Soneta.HR.ZKL.Wartosciowanie.Wyniki.WynikPozycjiWartosciowania>` |  |  |  |
