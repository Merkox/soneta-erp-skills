# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaŚwiadczeniaSocjalnego`
Nazwa tabeli: `DefSwiadczSocjal`
Tytuł: Definicje świadczeń socjalnych
Opis: Słownik definicji świadczeń socjalnych (np. zapomogi, dopłaty do wypoczynku, paczki świąteczne). Zawiera nazwę, powiązany element płacowy do rozliczenia oraz domyślną kwotę świadczenia.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
