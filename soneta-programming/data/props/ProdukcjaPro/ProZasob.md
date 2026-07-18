# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZasob`
Nazwa tabeli: `ProZasoby`
Tytuł: Zasoby produkcyjne
Opis: Kartoteka zasobów produkcyjnych (maszyn, stanowisk, narzędzi). Definiuje dostępne zasoby wraz z ich wydajnością, stawkami kosztowymi i przypisaniem do wydziałów, wykorzystywane przy planowaniu i harmonogramowaniu operacji produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe (zapisywalne): 9
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 0
- podlisty: 6
- subrowy: 0
- razem: 15

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie zasobu. |
| BlokadaRejestracji | `bool` | bazodanowe | Blokada rejestracji | Zablokowanie rejestracji czasów prac dla zasobu. |
| DefinicjaAkordu | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe | Definicja akordu | Definicja akordu dla zasobu. |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Ilosc | `int` | bazodanowe | Ilość | Ilość zasobu. |
| Kod | `string` | bazodanowe |  | Kod zasobu. |
| Nazwa | `string` | bazodanowe |  | Nazwa zasobu. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis zasobu. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| RelacjePozycjiKompetencji | `LpSubTable<Soneta.ProdukcjaPro.ProRelacjaZasobPozycjaKompetencji>` | podlista |  |  |
| RelacjeUrzadzen | `LpSubTable<Soneta.ProdukcjaPro.ProRelacjaZasobUrzadzenie>` | podlista |  |  |
| Rodzaj | `Soneta.ProdukcjaPro.ProRodzajZasobu` (enum) | bazodanowe | Rodzaj zasobu | Rodzaj zasobu. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka zasobu. |
| Wariantowosci | `LpSubTable<Soneta.ProdukcjaPro.ProWariantowoscZasobu>` | podlista |  |  |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział zasobu. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRodzajZasobu (`Soneta.ProdukcjaPro.ProRodzajZasobu`)
- `None` = 0
- `GniazdoProdukcyjne` = 1 — Gniazdo produkcyjne
- `JednostkaRobocza` = 2 — Jednostka robocza
- `Narzedzie` = 4 — Narzędzie
- `Kooperacja` = 8 — Kooperacja
- `All` = 15 — Wszystkie
