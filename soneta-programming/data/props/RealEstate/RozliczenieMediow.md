# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.RozliczenieMediow`
Nazwa tabeli: `RozMediow`
Tytuł: Rozliczenia mediów
Opis: Rejestr rozliczeń zużycia mediów dla nieruchomości i lokali. Przechowuje dane o zużyciu, prognozach, stawkach i okresach rozliczeniowych, stanowiąc podstawę do generowania dokumentów handlowych obciążających najemców za media.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDocumentHostCRM`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ActualConsumption | `double` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe | Data | Data rozliczenia. |
| Definicja | `Soneta.RealEstate.Models.Database.Config.DefinicjaRozliczeniaMediow` | bazodanowe | Definicja | Definicja rozliczenia. |
| DokumentyCRM | `SubTable<Soneta.Zadania.DokumentCRM>` | podlista |  |  |
| Ilosc | `double` | bazodanowe | Ilość | Ilość. |
| IsDefaultService | `bool` |  |  |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe | Kontrahent | Kontrahent |
| Last | `Soneta.RealEstate.Models.Database.RozliczenieMediow` | tylko-odczyt |  |  |
| LastConsumption | `double` | tylko-odczyt |  |  |
| LastMainCounterConsumptionDifference | `double` | tylko-odczyt |  |  |
| Lokal | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Lokal | Lokal do której przypisane jest rozliczenie. |
| MainCounterConsumptionDifference | `double` | tylko-odczyt |  |  |
| Nieruchomosc | `Soneta.RealEstate.Models.Database.Nieruchomosc` | bazodanowe | Nieruchomość | Nieruchomość do której przypisane jest rozliczenie. |
| NoOwner | `bool` | tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista | Okres | Okres rozliczenia. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Opis |
| PeriodConflict | `bool` | tylko-odczyt |  |  |
| PodlegaKorekcie | `bool` | bazodanowe | Podlega korekcie | Podlega korekcie na podstawie zużycia |
| Prognoza | `double` | bazodanowe | Prognoza | Prognoza zużycia w okresie |
| Stawka | `Currency` | bazodanowe |  | Stawka |
| TowarUsluga | `Soneta.Towary.Towar` | bazodanowe | Usługa | Towar typu usługa, do rozliczenia użycia. |
| UslugaNieruch | `Soneta.RealEstate.UslugaNieruch` | bazodanowe | Usługa nieruchomości | Usługa nieruchomości |
| Zdarzenia | `SubTable<Soneta.RealEstate.Models.Database.NieruchomoscZdarzenie>` | podlista |  |  |
| Zuzycie | `double` | bazodanowe | Zużycie | Zużycie w okresie |
