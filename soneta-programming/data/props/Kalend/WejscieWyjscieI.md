# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WejscieWyjscieI`
Nazwa tabeli: `WejsciaWyjsciaI`
Tytuł: Dane z RCP
Opis: Element szczegółowy pracownika (Pracownik). Dane z importu czytnika RCP — pojedynczy rekord wejścia/wyjścia z datą, godziną, typem operacji, stanem weryfikacji, adresem lokalizacji i trybem pracy (np. zdalna).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| CzytnikRCP | `Soneta.Kalend.CzytnikRCP` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DefinicjaZdarzenia | `Soneta.Kalend.DefinicjaZdarzeniaRCP` | bazodanowe |  |  |
| Godzina | `Soneta.Types.Time` | bazodanowe |  |  |
| NormaCzas | `Soneta.Types.Time` |  | Norma (czas) |  |
| NormaGodzinyOdDo | `string` |  | Norma (godziny) |  |
| NormaOdGodziny | `Soneta.Types.Time` |  | Norma (od godziny) |  |
| Operacja | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| Stan | `Soneta.Kalend.TypWeryfikacjiWeWy` | bazodanowe, enum |  |  |
| TrybPracy | `Soneta.Core.Enums.RcpWorkMode` | bazodanowe, enum |  |  |
| Typ | `Soneta.Kalend.TypWejsciaWyjscia` | bazodanowe, enum |  |  |
| Uwagi | `string` | bazodanowe |  |  |
| WeWyO | `Soneta.Kalend.WejscieWyjscieO` | bazodanowe |  |  |
| Zaimportowany | `bool` | bazodanowe |  |  |
| Zmodyfikowany | `bool` | bazodanowe |  |  |

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

### TypWeryfikacjiWeWy (`Soneta.Kalend.TypWeryfikacjiWeWy`)
- `Nieoznaczony` = 0
- `Aktywny` = 1
- `Nieaktywny` = 2
