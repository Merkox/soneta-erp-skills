# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruWydzialRel`
Nazwa tabeli: `NieruWydzialyRel`
Tytuł: Relacje urządzeń do jednostek organizacyjnych
Opis: Tabela powiązań nieruchomości z jednostkami organizacyjnymi (wydziałami). Umożliwia przypisanie obiektów nieruchomości do struktury organizacyjnej firmy z uwzględnieniem okresu obowiązywania przypisania.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Obiekt |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe |  |  |
