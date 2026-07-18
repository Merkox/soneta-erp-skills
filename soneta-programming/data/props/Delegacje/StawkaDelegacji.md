# Pola i właściwości klasy biznesowej: `Soneta.Delegacje.StawkaDelegacji`
Nazwa tabeli: `StawkiDelegacji`
Tytuł: Stawki delegacji
Opis: Element szczegółowy KrajDelegacji (KrajDelegacji). Definiuje historyczne stawki diet i limitów noclegowych obowiązujące dla danego kraju w określonym okresie. Umożliwia automatyczne rozliczanie delegacji według właściwych kwot zależnych od daty wyjazdu.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Kraj` → `KrajDelegacji`
Historia: Tak — zapis historyczny tabeli `KrajDelegacji`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `FromTo` | bazodanowe, podlista | Okres aktualności | Okres obowiązywania stawki |
| Dieta | `Currency` | bazodanowe | Wysokość diety | Wysokość diety |
| Kraj | `Soneta.Delegacje.KrajDelegacji` | bazodanowe, tylko-odczyt, guided-parent |  | Kraj delegacji |
| LimitNocleg | `Currency` | bazodanowe | Limit na nocleg | Limit wydatków na nocleg |
| Parent | `Row` | tylko-odczyt |  |  |
| SposobOpodatkowania | `Soneta.Kadry.SposobyUnikaniaPodwójnegoOpodatkowania` (enum) | bazodanowe |  | Rodzaj umowy o unikaniu podwójnego oodatkowania |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SposobyUnikaniaPodwójnegoOpodatkowania (`Soneta.Kadry.SposobyUnikaniaPodwójnegoOpodatkowania`)
- `NieDotyczy` = 0 — Nie dotyczy
- `ZasadaProgresji` = 1
- `ZasadaProporcjonalności` = 2
