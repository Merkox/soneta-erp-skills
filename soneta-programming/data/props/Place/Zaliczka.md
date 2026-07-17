# Pola i właściwości klasy biznesowej: `Soneta.Place.Zaliczka`
Nazwa tabeli: `Zaliczki`
Opis: Zaliczka udzielona pracownikowi do rozliczenia na przyszłych wypłatach. Rejestruje kwotę zaliczki, stan spłaty oraz definicję elementu wynagrodzenia służącego do potrącania rat.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DefinicjaSplaty | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  | Elementy wynagrodzenia |  |
| Pozostaje | `Soneta.Types.Currency` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Realizacja | `Soneta.Place.WypElementZaliczka.Realizacja` |  |  |  |
| Realizacje | `Soneta.Business.SubTable` |  |  |  |
| Splacono | `Soneta.Types.Currency` | bazodanowe | Spłacono |  |
| Spłaty | `Soneta.Business.SubTable<Soneta.Place.WypElement>` |  |  |  |
| Stan | `Soneta.Place.StanZaliczki` | bazodanowe, enum |  |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanZaliczki (`Soneta.Place.StanZaliczki`)
- `NieSpłacona` = 0 — Nie spłacona
- `CzęściowoSpłacona` = 1
- `CałkowicieSpłacona` = 2
