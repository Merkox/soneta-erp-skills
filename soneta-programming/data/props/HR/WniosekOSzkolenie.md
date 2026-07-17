# Pola i właściwości klasy biznesowej: `Soneta.HR.WniosekOSzkolenie`
Nazwa tabeli: `WnioskiOSzkol`
Tytuł: Wnioski o szkolenia
Opis: Wniosek pracownika o udział w szkoleniu. Rejestruje zgłoszenie, termin, etap realizacji, koszt oraz powiązanie z budżetem szkoleniowym, służąc do zarządzania procesem od zgłoszenia do rozliczenia.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IŹródłoUzyskaniaUprawnienia`, `IOcenaPracownika`, `IBazaZrodlaWyplaty`

- pola bazodanowe: 19
- pola kalkulowane (z klas biznesowych): 6

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Budzet | `Soneta.HR.BudżetSzkoleń` | bazodanowe |  |  |
| DataAnulowania | `Soneta.Types.Date` | bazodanowe |  |  |
| DataZgloszenia | `Soneta.Types.Date` | bazodanowe | Data zgłoszenia |  |
| Definicja | `Soneta.HR.DefinicjaSzkolenia` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  |  |  |
| ElementyOceny | `Soneta.Business.SubTable<Soneta.HR.ElementOcenyPracownika>` |  |  |  |
| Etap | `Soneta.HR.EtapRealizacjiSzkolenia` | bazodanowe |  |  |
| Kierownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| KorektaKosztu | `bool` | bazodanowe |  |  |
| Koszt | `Soneta.Types.Currency` | bazodanowe |  |  |
| Ocena | `string` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Realizacja | `Soneta.HR.RealizacjaSzkolenia` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieSwiadczenia` | bazodanowe |  |  |
| Rozliczenie.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Rozliczenie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Rozliczenie.Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Rozliczenie.Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Rozliczenie.Rozliczone | `bool` |  |  |  |
| Rozliczenie.WgElement | `Soneta.Business.Key` |  |  |  |
| SkierowanyPrzezZaklad | `bool` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| UkończoneSzkolenia | `Soneta.Business.SubTable<Soneta.HR.UkończoneSzkolenie>` |  |  |  |
| Uprawnienia | `Soneta.Business.SubTable<Soneta.HR.UprawnieniePracownika>` |  |  |  |
