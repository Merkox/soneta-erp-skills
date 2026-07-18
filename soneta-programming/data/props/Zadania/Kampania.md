# Pola i właściwości klasy biznesowej: `Soneta.Zadania.Kampania`
Nazwa tabeli: `Kampanie`
Tytuł: Kampanie CRM
Opis: Kampania marketingowa CRM grupująca projekty i zadania w ramach wspólnego celu biznesowego. Zawiera daty, wartości planowane (sprzedaż, koszty, skuteczność) oraz osobę odpowiedzialną.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe (zapisywalne): 14
- pola kalkulowane (zapisywalne): 2
- pola tylko-odczyt: 12
- podlisty: 6
- subrowy: 1
- razem: 35

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| Cel | `MemoText` | bazodanowe, podlista | Cel | Opis celu prowadzenia kampanii CRM |
| Data | `Date` | tylko-odczyt |  |  |
| DataDo | `Date` | bazodanowe | Data zakończenia | Planowana data zakończenia kampanii |
| DataOd | `Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia kampanii |
| Definicja | `Soneta.Zadania.DefKampania` | bazodanowe |  | Definicja kampanii |
| Description | `string` | tylko-odczyt |  |  |
| End | `System.DateTime` | tylko-odczyt |  |  |
| IDokumentNumerPelny | `string` | tylko-odczyt | Numer pełny |  |
| Koszt | `Currency` | bazodanowe | Koszt | Zakładane koszty prowadzenia kampanii. |
| KosztPlan | `Currency` | tylko-odczyt |  |  |
| KosztRach | `Currency` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa kampanii | Krótka nazwa kampanii, na podstawie której będzie można ją wyszukiwać |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| OddzialFirmy | `Soneta.Core.OddzialFirmy` | bazodanowe | Oddział firmy | Oddział firmy do którego przypisana jest kampania. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis kampanii |
| Projekty | `SubTable<Soneta.Zadania.Projekt>` | podlista |  |  |
| Prowadzacy | `App.Operator` | bazodanowe | Odpowiedzialny | Osoba odpowiedzialna za prowadzenie kampanii |
| Przychod | `Currency` | bazodanowe | Sprzedaż | Zakładana wartość sprzedaży. |
| PrzychodPlan | `Currency` | tylko-odczyt |  |  |
| PrzychodRach | `Currency` | tylko-odczyt |  |  |
| Seria | `string` | bazodanowe | Seria | Seria kampanii. |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Skutecznosc | `Percent` | bazodanowe | Skuteczność | Zakładana skuteczność kampanii. |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Text | `string` |  |  |  |
| WartoscWyliczana | `bool` | bazodanowe | Wartość wyliczana | Zakładane wartości wyliczane na podstawie projektów |
| Zadania | `SubTable<Soneta.Zadania.Zadanie>` | podlista |  |  |
| Zakonczona | `bool` | bazodanowe | Zakończona | Kampania zakończona |
