# Pola i właściwości klasy biznesowej: `Soneta.HR.WniosekOSzkolenie`
Nazwa tabeli: `WnioskiOSzkol`
Tytuł: Wnioski o szkolenia
Opis: Wniosek pracownika o udział w szkoleniu. Rejestruje zgłoszenie, termin, etap realizacji, koszt oraz powiązanie z budżetem szkoleniowym, służąc do zarządzania procesem od zgłoszenia do rozliczenia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoUzyskaniaUprawnienia`, `IOcenaPracownika`, `IBazaZrodlaWyplaty`

- pola bazodanowe (zapisywalne): 15
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 7
- subrowy: 1
- razem: 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Budzet | `Soneta.HR.BudżetSzkoleń` | bazodanowe |  |  |
| DataAnulowania | `Date` | bazodanowe |  |  |
| DataZgloszenia | `Date` | bazodanowe | Data zgłoszenia |  |
| Definicja | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista |  |  |
| ElementyOceny | `SubTable<Soneta.HR.ElementOcenyPracownika>` | podlista |  |  |
| Etap | `Soneta.HR.EtapRealizacjiSzkolenia` | bazodanowe |  |  |
| Kierownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| KorektaKosztu | `bool` | bazodanowe |  |  |
| Koszt | `Currency` | bazodanowe |  |  |
| Ocena | `string` | bazodanowe |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Realizacja | `Soneta.HR.RealizacjaSzkolenia` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieSwiadczenia` (subrow) | bazodanowe |  |  |
| Rozliczenie.Data | `Date` | bazodanowe |  |  |
| Rozliczenie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Rozliczenie.Kwota | `Currency` | bazodanowe |  |  |
| Rozliczenie.Okres | `FromTo` | bazodanowe, podlista |  |  |
| Rozliczenie.Rozliczone | `bool` | tylko-odczyt |  |  |
| Rozliczenie.WgElement | `Key` | podlista |  |  |
| SkierowanyPrzezZaklad | `bool` | bazodanowe |  |  |
| Termin | `Date` | bazodanowe |  |  |
| UkończoneSzkolenia | `SubTable<Soneta.HR.UkończoneSzkolenie>` | podlista |  |  |
| Uprawnienia | `SubTable<Soneta.HR.UprawnieniePracownika>` | podlista |  |  |
