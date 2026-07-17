# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PozycjaWynikuZestKS`
Nazwa tabeli: `PozycjeWynZestKS`
Tytuł: Pozycje wyników zestawień księgowych
Opis: Element szczegółowy wyniku zestawienia księgowego (WynikZestKS). Przechowuje wiersz (pozycję) w zapisanym wyniku raportu z symbolem, numerem, identyfikatorem i opisem. Pozycje tworzą hierarchię nadrzędna-podrzędna odzwierciedlającą strukturę zestawienia.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Wynik` → `WynikZestKS`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Identyfikator | `string` | bazodanowe |  | Opcjonalny identyfikator pozycji |
| Komorki | `Soneta.Business.SubTable<Soneta.Ksiega.KomorkaWynikuZestKS>` |  |  |  |
| KomorkiUI | `Soneta.Ksiega.KomorkaWynikuZestKS[]` |  |  |  |
| Nadrzedna | `Soneta.Ksiega.PozycjaWynikuZestKS` | bazodanowe |  |  |
| Numer | `string` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Subpozycje | `Soneta.Business.SubTable<Soneta.Ksiega.PozycjaWynikuZestKS>` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Wynik | `Soneta.Ksiega.WynikZestKS` | bazodanowe, guided-parent |  |  |
