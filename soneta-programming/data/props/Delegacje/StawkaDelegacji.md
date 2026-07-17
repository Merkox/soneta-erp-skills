# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.StawkaDelegacji`
Nazwa tabeli: `StawkiDelegacji`
Tytuł: Stawki delegacji
Opis: Element szczegółowy KrajDelegacji (KrajDelegacji). Definiuje historyczne stawki diet i limitów noclegowych obowiązujące dla danego kraju w określonym okresie. Umożliwia automatyczne rozliczanie delegacji według właściwych kwot zależnych od daty wyjazdu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Kraj` → `KrajDelegacji`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Soneta.Types.FromTo` | bazodanowe | Okres aktualności | Okres obowiązywania stawki |
| Dieta | `Soneta.Types.Currency` | bazodanowe | Wysokość diety | Wysokość diety |
| Kraj | `Soneta.Delegacje.KrajDelegacji` | bazodanowe, guided-parent |  | Kraj delegacji |
| LimitNocleg | `Soneta.Types.Currency` | bazodanowe | Limit na nocleg | Limit wydatków na nocleg |
| Parent | `Soneta.Business.Row` |  |  |  |
| SposobOpodatkowania | `Soneta.Kadry.SposobyUnikaniaPodwójnegoOpodatkowania` | bazodanowe, enum |  | Rodzaj umowy o unikaniu podwójnego oodatkowania |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SposobyUnikaniaPodwójnegoOpodatkowania (`Soneta.Kadry.SposobyUnikaniaPodwójnegoOpodatkowania`)
- `NieDotyczy` = 0 — Nie dotyczy
- `ZasadaProgresji` = 1
- `ZasadaProporcjonalności` = 2
