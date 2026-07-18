# Pola i właściwości klasy biznesowej: `Soneta.HR.ZKL.Slowniki.Kwalifikacje.PoziomWyksztalcenia`
Nazwa tabeli: `ZklPozWykszt`
Tytuł: Poziomy wykształcenia
Opis: Zawiera klasyfikację poziomów wykształcenia formalnego. W profilu kwalifikacji wspiera zgodność z wymaganiami formalnymi stanowiska.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IZklPozycjaSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Priorytet | `int` | bazodanowe |  |  |
| TypSzkoly | `Soneta.HR.ZKL.Enums.TypSzkołyZKL` (enum) | bazodanowe | Typ szkoły |  |
| ZklSlownik | `Soneta.HR.IZklSlownik` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypSzkołyZKL (`Soneta.HR.ZKL.Enums.TypSzkołyZKL`)
- `Inna` = 0 — Inne
- `ZasadniczaSzkołaZawodowa` = 10 — Zasadnicza szkoła zawodowa
- `ŚredniaSzkołaOgólnokształcąca` = 20 — Średnia szkoła ogólnokształcąca
- `ŚredniaSzkołaZawodowa` = 30 — Średnia szkoła zawodowa
- `SzkołaPolicealna` = 40 — Szkoła policealna
- `SzkołaPodyplomowa` = 50 — Szkoła podyplomowa
- `SzkołaWyższa` = 60 — Szkoła wyższa
