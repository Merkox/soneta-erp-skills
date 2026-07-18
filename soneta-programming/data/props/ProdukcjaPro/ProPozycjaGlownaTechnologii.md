# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProPozycjaGlownaTechnologii`
Nazwa tabeli: `ProPGlownaT`
Tytuł: Główne pozycje technologii
Opis: Element szczegółowy technologii produkcyjnej (ProTechnologia). Wskazuje główną pozycję technologii (wyrób lub operację) stanowiącą punkt odniesienia dla przeliczania ilości i kosztów w ramach technologii.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Technologia` → `ProTechnologia`

- pola bazodanowe (zapisywalne): 2
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| PozycjaGlowna | `Soneta.ProdukcjaPro.IProPozycjaGlowna` | bazodanowe | Pozycja główna | Pozycja główna technologii. |
| Technologia | `Soneta.ProdukcjaPro.ProTechnologia` | bazodanowe, guided-parent |  | Technologia dla pozycji głównej technologii. |
