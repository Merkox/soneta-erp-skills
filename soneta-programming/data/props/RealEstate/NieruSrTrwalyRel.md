# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruSrTrwalyRel`
Nazwa tabeli: `NieruSrTrwaleRel`
Tytuł: Relacje nieruchomości do środków trwałych
Opis: Tabela powiązań nieruchomości ze środkami trwałymi i wyposażeniem. Umożliwia przypisanie środków trwałych do nieruchomości z uwzględnieniem wydziału oraz okresu obowiązywania powiązania.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres |  |
| SrodekTrwaly | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe |  |  |
