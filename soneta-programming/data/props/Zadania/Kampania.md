# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Kampania`
Nazwa tabeli: `Kampanie`
Tytuł: Kampanie CRM
Opis: Kampania marketingowa CRM grupująca projekty i zadania w ramach wspólnego celu biznesowego. Zawiera daty, wartości planowane (sprzedaż, koszty, skuteczność) oraz osobę odpowiedzialną.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 18
- pola kalkulowane (z klas biznesowych): 17

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` |  |  |  |
| Cel | `Soneta.Business.MemoText` | bazodanowe | Cel | Opis celu prowadzenia kampanii CRM |
| Data | `Soneta.Types.Date` |  |  |  |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data zakończenia | Planowana data zakończenia kampanii |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia kampanii |
| Definicja | `Soneta.Zadania.DefKampania` | bazodanowe |  | Definicja kampanii |
| Description | `string` |  |  |  |
| End | `System.DateTime` |  |  |  |
| IDokumentNumerPelny | `string` |  | Numer pełny |  |
| Koszt | `Soneta.Types.Currency` | bazodanowe | Koszt | Zakładane koszty prowadzenia kampanii. |
| KosztPlan | `Soneta.Types.Currency` |  |  |  |
| KosztRach | `Soneta.Types.Currency` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa kampanii | Krótka nazwa kampanii, na podstawie której będzie można ją wyszukiwać |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest kampania. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis kampanii |
| Projekty | `Soneta.Business.SubTable<Soneta.Zadania.Projekt>` |  |  |  |
| Prowadzacy | `Soneta.Business.App.Operator` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie kampanii |
| Przychod | `Soneta.Types.Currency` | bazodanowe | Sprzedaż | Zakładana wartość sprzedaży. |
| PrzychodPlan | `Soneta.Types.Currency` |  |  |  |
| PrzychodRach | `Soneta.Types.Currency` |  |  |  |
| Seria | `string` | bazodanowe | Seria | Seria kampanii. |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Skutecznosc | `Soneta.Types.Percent` | bazodanowe | Skuteczność | Zakładana skuteczność kampanii. |
| Start | `System.DateTime` |  |  |  |
| Text | `string` |  |  |  |
| WartoscWyliczana | `bool` | bazodanowe | Wartość wyliczana | Zakładane wartości wyliczane na podstawie projektów |
| Zadania | `Soneta.Business.SubTable<Soneta.Zadania.Zadanie>` |  |  |  |
| Zakonczona | `bool` | bazodanowe | Zakończona | Kampania zakończona |
