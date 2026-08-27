# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WejscieWyjscieI`
Nazwa tabeli: `WejsciaWyjsciaI`
Tytuł: Dane z RCP
Opis: Element szczegółowy pracownika (Pracownik). Dane z importu czytnika RCP — pojedynczy rekord wejścia/wyjścia z datą, godziną, typem operacji, stanem weryfikacji, adresem lokalizacji i trybem pracy (np. zdalna).
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Adres | `Soneta.Core.IRcpAddress` | bazodanowe |  |  |
| CzytnikRCP | `Soneta.Kalend.CzytnikRCP` | bazodanowe |  |  |
| Data | `Date` | bazodanowe |  |  |
| DefinicjaZdarzenia | `Soneta.Kalend.DefinicjaZdarzeniaRCP` | bazodanowe |  |  |
| Godzina | `Time` | bazodanowe |  |  |
| NormaCzas | `Time` | tylko-odczyt | Norma (czas) |  |
| NormaGodzinyOdDo | `string` | tylko-odczyt | Norma (godziny) |  |
| NormaOdGodziny | `Time` | tylko-odczyt | Norma (od godziny) |  |
| Operacja | `int` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Stan | `Soneta.Kalend.TypWeryfikacjiWeWy` (enum) | bazodanowe |  |  |
| TrybPracy | `Soneta.Core.Enums.RcpWorkMode` (enum) | bazodanowe |  |  |
| Typ | `Soneta.Kalend.TypWejsciaWyjscia` (enum) | bazodanowe |  |  |
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
