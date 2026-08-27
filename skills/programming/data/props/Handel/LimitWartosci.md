# Pola i właściwości klasy biznesowej: `Soneta.Handel.LimitWartosci`
Nazwa tabeli: `LimityWartosci`
Tytuł: Limity wartości dokumentu.
Opis: Element szczegółowy definicji dokumentu handlowego (DefDokHandlowego). Przechowuje limity wartości (minimalne, maksymalne) w danej walucie dla definicji dokumentu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Definicja` → `DefDokHandlowego`
Selektor: pole `Typ` (`Soneta.Handel.LimitWartosciTyp`) — wiele typów w jednej tabeli, podtypów: 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Handel.DefDokHandlowego` | bazodanowe, guided-parent | Definicja | Limity wartości dotyczą wybranej definicji dokumentu handlowego. |
| Typ | `Soneta.Handel.LimitWartosciTyp` (enum) | bazodanowe, tylko-odczyt, selektor | Typ | Typ limitu wartości |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe, tylko-odczyt | Waluta | Waluta limitu wartości |
| Wartosc | `Currency` | bazodanowe | Wartość | Wartość limitu w walucie |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Standardowy` | 1 | `Soneta.Handel.LimitWartosci` | Limit wartości dokumentu |
| `OdwrotneObciazenie` | 2 | `Soneta.Handel.LimitOdwrotnegoObciazenia` | Limit wartości odwrotnego obciążenia |
| `IOSS` | 4 | `Soneta.Handel.LimitIOSS` | Limit IOSS |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### LimitWartosciTyp (`Soneta.Handel.LimitWartosciTyp`)
- `Brak` = 0
- `Standardowy` = 1
- `OdwrotneObciazenie` = 2
- `IOSS` = 4
