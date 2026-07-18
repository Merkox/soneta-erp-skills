# Pola i właściwości klasy biznesowej: `Soneta.Kadry.SwiadczSocjalne`
Nazwa tabeli: `SwiadczeniaSoc`
Tytuł: Świadczenia socjalne
Opis: Świadczenie socjalne przyznane pracownikowi (np. zapomoga, dopłata do wypoczynku). Rejestruje datę przyznania, definicję świadczenia, dane rozliczeniowe (element płacowy, kwotę, okres) oraz opis.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 3
- podlisty: 4
- subrowy: 1
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kadry.DefinicjaŚwiadczeniaSocjalnego` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Rozliczenie | `Soneta.Kadry.RozliczenieSwiadczenia` (subrow) | bazodanowe |  |  |
| Rozliczenie.Data | `Date` | bazodanowe |  |  |
| Rozliczenie.Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Rozliczenie.Kwota | `Currency` | bazodanowe |  |  |
| Rozliczenie.Okres | `FromTo` | bazodanowe, podlista |  |  |
| Rozliczenie.Rozliczone | `bool` | tylko-odczyt |  |  |
| Rozliczenie.WgElement | `Key` | podlista |  |  |
