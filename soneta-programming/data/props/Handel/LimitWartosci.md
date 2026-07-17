# Pola i właściwości klasy biznesowej: `Soneta.Handel.LimitWartosci`
Nazwa tabeli: `LimityWartosci`
Tytuł: Limity wartości dokumentu.
Opis: Element szczegółowy definicji dokumentu handlowego (DefDokHandlowego). Przechowuje limity wartości (minimalne, maksymalne) w danej walucie dla definicji dokumentu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Definicja` → `DefDokHandlowego`

- pola bazodanowe: 4
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definicja | `Soneta.Handel.DefDokHandlowego` | bazodanowe, guided-parent | Definicja | Limity wartości dotyczą wybranej definicji dokumentu handlowego. |
| Typ | `Soneta.Handel.LimitWartosciTyp` | bazodanowe, enum | Typ | Typ limitu wartości |
| Waluta | `Soneta.Waluty.Waluta` | bazodanowe | Waluta | Waluta limitu wartości |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość limitu w walucie |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### LimitWartosciTyp (`Soneta.Handel.LimitWartosciTyp`)
- `Brak` = 0
- `Standardowy` = 1
- `OdwrotneObciazenie` = 2
- `IOSS` = 4
