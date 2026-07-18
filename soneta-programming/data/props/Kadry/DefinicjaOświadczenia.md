# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaOświadczenia`
Nazwa tabeli: `DefOswiadczen`
Tytuł: Definicje oświadczeń
Opis: Definicja typu oświadczenia pracowniczego (np. o korzystaniu z uprawnień rodzicielskich, PIT-2). Określa nazwę, okres ważności (roczny, bezterminowy) oraz dostępność na pulpicie pracownika w aplikacji webowej.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| OkresIlosc | `int` | bazodanowe | Ilość miesięcy/lat |  |
| OkresWaznosci | `Soneta.Kadry.OkresyWażnościOświadczeń` (enum) | bazodanowe | Okres ważności |  |
| PulpitPracownika | `bool` | bazodanowe |  |  |
| Treści | `SubTable<Soneta.Kadry.TreśćOświadczenia>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### OkresyWażnościOświadczeń (`Soneta.Kadry.OkresyWażnościOświadczeń`)
- `Dowolny` = 0
- `Bezterminowe` = 1 — Bezterminowe (do czasu odwołania)
- `Miesiące` = 2
- `Lata` = 3
