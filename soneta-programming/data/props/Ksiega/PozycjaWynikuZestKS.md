# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PozycjaWynikuZestKS`
Nazwa tabeli: `PozycjeWynZestKS`
Tytuł: Pozycje wyników zestawień księgowych
Opis: Element szczegółowy wyniku zestawienia księgowego (WynikZestKS). Przechowuje wiersz (pozycję) w zapisanym wyniku raportu z symbolem, numerem, identyfikatorem i opisem. Pozycje tworzą hierarchię nadrzędna-podrzędna odzwierciedlającą strukturę zestawienia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wynik` → `WynikZestKS`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 6
- podlisty: 3
- subrowy: 0
- razem: 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Identyfikator | `string` | bazodanowe, tylko-odczyt |  | Opcjonalny identyfikator pozycji |
| Komorki | `SubTable<Soneta.Ksiega.KomorkaWynikuZestKS>` | podlista |  |  |
| KomorkiUI | `Soneta.Ksiega.KomorkaWynikuZestKS[]` | podlista |  |  |
| Nadrzedna | `Soneta.Ksiega.PozycjaWynikuZestKS` | bazodanowe, tylko-odczyt |  |  |
| Numer | `string` | bazodanowe, tylko-odczyt |  |  |
| Opis | `string` | bazodanowe, tylko-odczyt |  |  |
| Subpozycje | `SubTable<Soneta.Ksiega.PozycjaWynikuZestKS>` | podlista |  |  |
| Symbol | `string` | bazodanowe, tylko-odczyt |  |  |
| Wynik | `Soneta.Ksiega.WynikZestKS` | bazodanowe, tylko-odczyt, guided-parent |  |  |
