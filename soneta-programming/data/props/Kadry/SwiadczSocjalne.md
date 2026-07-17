# Pola i właściwości klasy biznesowej: `Soneta.Kadry.SwiadczSocjalne`
Nazwa tabeli: `SwiadczeniaSoc`
Tytuł: Świadczenia socjalne
Opis: Świadczenie socjalne przyznane pracownikowi (np. zapomoga, dopłata do wypoczynku). Rejestruje datę przyznania, definicję świadczenia, dane rozliczeniowe (element płacowy, kwotę, okres) oraz opis.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kadry.DefinicjaŚwiadczeniaSocjalnego` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  |  |  |
| Nazwa | `string` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieSwiadczenia` | bazodanowe |  |  |
| Rozliczenie.Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Rozliczenie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Rozliczenie.Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Rozliczenie.Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Rozliczenie.Rozliczone | `bool` |  |  |  |
| Rozliczenie.WgElement | `Soneta.Business.Key` |  |  |  |
