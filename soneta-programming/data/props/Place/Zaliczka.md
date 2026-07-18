# Pola i właściwości klasy biznesowej: `Soneta.Place.Zaliczka`
Nazwa tabeli: `Zaliczki`
Opis: Zaliczka udzielona pracownikowi do rozliczenia na przyszłych wypłatach. Rejestruje kwotę zaliczki, stan spłaty oraz definicję elementu wynagrodzenia służącego do potrącania rat.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IBazaZrodlaWyplaty`, `IPowiązanieWypłaty`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DefinicjaSplaty | `Soneta.Place.DefinicjaElementu` | bazodanowe |  |  |
| Elementy | `SubTable<Soneta.Place.WypElement>` | podlista | Elementy wynagrodzenia |  |
| Pozostaje | `Currency` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Realizacja | `Soneta.Place.WypElementZaliczka.Realizacja` | tylko-odczyt |  |  |
| Realizacje | `SubTable` | podlista |  |  |
| Splacono | `Currency` | bazodanowe, tylko-odczyt | Spłacono |  |
| Spłaty | `SubTable<Soneta.Place.WypElement>` | podlista |  |  |
| Stan | `Soneta.Place.StanZaliczki` (enum) | bazodanowe, tylko-odczyt |  |  |
| Wartosc | `Currency` | bazodanowe, tylko-odczyt | Wartość |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanZaliczki (`Soneta.Place.StanZaliczki`)
- `NieSpłacona` = 0 — Nie spłacona
- `CzęściowoSpłacona` = 1
- `CałkowicieSpłacona` = 2
