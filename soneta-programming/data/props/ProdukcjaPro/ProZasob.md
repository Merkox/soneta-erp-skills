# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZasob`
Nazwa tabeli: `ProZasoby`
Tytuł: Zasoby produkcyjne
Opis: Kartoteka zasobów produkcyjnych (maszyn, stanowisk, narzędzi). Definiuje dostępne zasoby wraz z ich wydajnością, stawkami kosztowymi i przypisaniem do wydziałów, wykorzystywane przy planowaniu i harmonogramowaniu operacji produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie zasobu. |
| BlokadaRejestracji | `bool` | bazodanowe | Blokada rejestracji | Zablokowanie rejestracji czasów prac dla zasobu. |
| DefinicjaAkordu | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe | Definicja akordu | Definicja akordu dla zasobu. |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Ilosc | `int` | bazodanowe | Ilość | Ilość zasobu. |
| Kod | `string` | bazodanowe |  | Kod zasobu. |
| Nazwa | `string` | bazodanowe |  | Nazwa zasobu. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis zasobu. |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| RelacjePozycjiKompetencji | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProRelacjaZasobPozycjaKompetencji>` |  |  |  |
| RelacjeUrzadzen | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProRelacjaZasobUrzadzenie>` |  |  |  |
| Rodzaj | `Soneta.ProdukcjaPro.ProRodzajZasobu` | bazodanowe, enum | Rodzaj zasobu | Rodzaj zasobu. |
| Stawka | `Soneta.ProdukcjaPro.ProStawka` | bazodanowe |  | Stawka zasobu. |
| Wariantowosci | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProWariantowoscZasobu>` |  |  |  |
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
