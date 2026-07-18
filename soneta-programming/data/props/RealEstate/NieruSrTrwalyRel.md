# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruSrTrwalyRel`
Nazwa tabeli: `NieruSrTrwaleRel`
Tytuł: Relacje nieruchomości do środków trwałych
Opis: Tabela powiązań nieruchomości ze środkami trwałymi i wyposażeniem. Umożliwia przypisanie środków trwałych do nieruchomości z uwzględnieniem wydziału oraz okresu obowiązywania powiązania.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres |  |
| SrodekTrwaly | `Soneta.SrodkiTrwale.SrodekTrwalyBase` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe |  |  |
