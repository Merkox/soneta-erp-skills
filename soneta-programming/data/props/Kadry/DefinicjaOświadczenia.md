# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaOświadczenia`
Nazwa tabeli: `DefOswiadczen`
Tytuł: Definicje oświadczeń
Opis: Definicja typu oświadczenia pracowniczego (np. o korzystaniu z uprawnień rodzicielskich, PIT-2). Określa nazwę, okres ważności (roczny, bezterminowy) oraz dostępność na pulpicie pracownika w aplikacji webowej.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| OkresIlosc | `int` | bazodanowe | Ilość miesięcy/lat |  |
| OkresWaznosci | `Soneta.Kadry.OkresyWażnościOświadczeń` | bazodanowe, enum | Okres ważności |  |
| PulpitPracownika | `bool` | bazodanowe |  |  |
| Treści | `Soneta.Business.SubTable<Soneta.Kadry.TreśćOświadczenia>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OkresyWażnościOświadczeń (`Soneta.Kadry.OkresyWażnościOświadczeń`)
- `Dowolny` = 0
- `Bezterminowe` = 1 — Bezterminowe (do czasu odwołania)
- `Miesiące` = 2
- `Lata` = 3
