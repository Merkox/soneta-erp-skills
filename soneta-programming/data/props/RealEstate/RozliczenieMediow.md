# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.RozliczenieMediow`
Nazwa tabeli: `RozMediow`
Tytuł: Rozliczenia mediów
Opis: Rejestr rozliczeń zużycia mediów dla nieruchomości i lokali. Przechowuje dane o zużyciu, prognozach, stawkach i okresach rozliczeniowych, stanowiąc podstawę do generowania dokumentów handlowych obciążających najemców za media.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDocumentHostCRM`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActualConsumption | `double` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data | Data rozliczenia. |
| Definicja | `Soneta.RealEstate.Models.Database.Config.DefinicjaRozliczeniaMediow` | bazodanowe | Definicja | Definicja rozliczenia. |
| DokumentyCRM | `Soneta.Business.SubTable<Soneta.Zadania.DokumentCRM>` |  |  |  |
| Ilosc | `double` | bazodanowe | Ilość | Ilość. |
| IsDefaultService | `bool` |  |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe | Kontrahent | Kontrahent |
| Last | `Soneta.RealEstate.Models.Database.RozliczenieMediow` |  |  |  |
| LastConsumption | `double` |  |  |  |
| LastMainCounterConsumptionDifference | `double` |  |  |  |
| Lokal | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Lokal | Lokal do której przypisane jest rozliczenie. |
| MainCounterConsumptionDifference | `double` |  |  |  |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nieruchomość | Nieruchomość do której przypisane jest rozliczenie. |
| NoOwner | `bool` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe | Okres | Okres rozliczenia. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Opis |
| PeriodConflict | `bool` |  |  |  |
| PodlegaKorekcie | `bool` | bazodanowe | Podlega korekcie | Podlega korekcie na podstawie zużycia |
| Prognoza | `double` | bazodanowe | Prognoza | Prognoza zużycia w okresie |
| Stawka | `Soneta.Types.Currency` | bazodanowe |  | Stawka |
| TowarUsluga | `Soneta.Towary.Towar` | bazodanowe | Usługa | Towar typu usługa, do rozliczenia użycia. |
| UslugaNieruch | `Soneta.RealEstate.UslugaNieruch` | bazodanowe | Usługa nieruchomości | Usługa nieruchomości |
| Zdarzenia | `Soneta.Business.SubTable<Soneta.RealEstate.Models.Database.NieruchomoscZdarzenie>` |  |  |  |
| Zuzycie | `double` | bazodanowe | Zużycie | Zużycie w okresie |
