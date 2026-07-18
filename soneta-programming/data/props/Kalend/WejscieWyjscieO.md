# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WejscieWyjscieO`
Nazwa tabeli: `WejsciaWyjsciaO`
Tytuł: Oryginalne dane z RCP
Opis: Element szczegółowy pracownika (Pracownik). Oryginalne (niemodyfikowane) dane z czytnika RCP — kopia zapasowa rekordu wejścia/wyjścia z pierwotnymi wartościami daty i godziny, umożliwiająca śledzenie zmian wprowadzonych po imporcie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe (zapisywalne): 11
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 1
- subrowy: 0
- razem: 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| CzytnikRCP | `Soneta.Kalend.CzytnikRCP` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| DataEdytowana | `Date` | bazodanowe |  |  |
| DefinicjaZdarzenia | `Soneta.Kalend.DefinicjaZdarzeniaRCP` | bazodanowe |  |  |
| Godzina | `Time` | bazodanowe |  |  |
| GodzinaEdytowana | `Time` | bazodanowe |  |  |
| Operacja | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| TrybPracy | `Soneta.Core.Enums.RcpWorkMode` (enum) | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypWejsciaWyjscia` (enum) | bazodanowe |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| WeWyI | `SubTable<Soneta.Kalend.WejscieWyjscieI>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RcpWorkMode (`Soneta.Core.Enums.RcpWorkMode`)
- `Stationary` = 0 — Stacjonarna
- `Remote` = 1 — Zdalna
- `All` = 2 — Wszystkie

### TypWejsciaWyjscia (`Soneta.Kalend.TypWejsciaWyjscia`)
- `Niezdefiniowany` = 0
- `Wejscie` = 1 — Wejście
- `Wyjscie` = 2 — Wyjście
- `WejscieSluzbowe` = 3 — Wejście służbowe
- `WyjscieSluzbowe` = 4 — Wyjście służbowe
- `WejsciePrywatne` = 5 — Wejście prywatne
- `WyjsciePrywatne` = 6 — Wyjście prywatne
