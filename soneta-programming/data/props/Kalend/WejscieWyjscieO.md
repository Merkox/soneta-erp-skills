# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WejscieWyjscieO`
Nazwa tabeli: `WejsciaWyjsciaO`
Tytuł: Oryginalne dane z RCP
Opis: Element szczegółowy pracownika (Pracownik). Oryginalne (niemodyfikowane) dane z czytnika RCP — kopia zapasowa rekordu wejścia/wyjścia z pierwotnymi wartościami daty i godziny, umożliwiająca śledzenie zmian wprowadzonych po imporcie.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| CzytnikRCP | `Soneta.Kalend.CzytnikRCP` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataEdytowana | `Soneta.Types.Date` | bazodanowe |  |  |
| DefinicjaZdarzenia | `Soneta.Kalend.DefinicjaZdarzeniaRCP` | bazodanowe |  |  |
| Godzina | `Soneta.Types.Time` | bazodanowe |  |  |
| GodzinaEdytowana | `Soneta.Types.Time` | bazodanowe |  |  |
| Operacja | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| TrybPracy | `Soneta.Core.Enums.RcpWorkMode` | bazodanowe, enum |  |  |
| Typ | `Soneta.Kalend.TypWejsciaWyjscia` | bazodanowe, enum |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| WeWyI | `Soneta.Business.SubTable<Soneta.Kalend.WejscieWyjscieI>` |  |  |  |

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
