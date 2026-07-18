# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruSrTrwalyRel`
Nazwa tabeli: `NieruSrTrwaleRel`
Tytuł: Relacje nieruchomości do środków trwałych
Opis: Tabela powiązań nieruchomości ze środkami trwałymi i wyposażeniem. Umożliwia przypisanie środków trwałych do nieruchomości z uwzględnieniem wydziału oraz okresu obowiązywania powiązania.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 3
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 1
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres |  |
| SrodekTrwaly | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe |  |  |
