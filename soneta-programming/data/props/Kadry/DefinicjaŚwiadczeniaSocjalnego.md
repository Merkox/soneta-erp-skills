# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaŚwiadczeniaSocjalnego`
Nazwa tabeli: `DefSwiadczSocjal`
Tytuł: Definicje świadczeń socjalnych
Opis: Słownik definicji świadczeń socjalnych (np. zapomogi, dopłaty do wypoczynku, paczki świąteczne). Zawiera nazwę, powiązany element płacowy do rozliczenia oraz domyślną kwotę świadczenia.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 4
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Element | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Kwota | `Currency` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
