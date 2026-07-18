# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.UslugaNieruch`
Nazwa tabeli: `UslugiNieruch`
Tytuł: Usługa nieruchomości
Opis: Przypisanie usług (towarów) do nieruchomości wraz ze stawkami, ilościami i okresem obowiązywania. Służy do konfiguracji cyklicznych opłat za media i usługi powiązane z obiektem, z możliwością zastosowania algorytmu naliczania.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.RealEstate.Models.Database.Config.DefinicjaAlgorytmuUslugi` | bazodanowe |  |  |
| Ilosc | `double` | bazodanowe | Ilość |  |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nieruchomosc |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres |  |
| Stawka | `Currency` | bazodanowe | Stawka |  |
| Usluga | `Soneta.Towary.Towar` | bazodanowe | Usługa |  |
