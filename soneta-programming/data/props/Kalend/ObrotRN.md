# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ObrotRN`
Nazwa tabeli: `ObrotyRN`
Tytuł: Obroty
Opis: Element szczegółowy strefy pracy (StrefaPracy). Obrót magazynu nadgodzin — rejestruje przepływ czasu nadgodzinowego między strefą naliczenia a strefą rozliczenia dla pracownika w danym dniu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `StrefaNadgodziny` → `StrefaPracy`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasRozliczany | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Nadgodziny | `Soneta.Kalend.PartiaRN` | bazodanowe |  |  |
| Nadgodziny.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Nadgodziny.CzasExt | `Soneta.Types.Time` |  |  |  |
| Nadgodziny.Kierunek | `Soneta.Kalend.KierunekMagazynuNadgodzin` | enum |  |  |
| Nadgodziny.Rozliczany | `Soneta.Types.Time` | bazodanowe |  |  |
| Nadgodziny.RozliczanyExt | `Soneta.Types.Time` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  | Pracownik, dla którego został naliczony obrót magazynu nadgodzin. |
| Rozliczenie | `Soneta.Kalend.PartiaRN` | bazodanowe |  |  |
| StrefaNadgodziny | `Soneta.Kalend.StrefaPracy` | bazodanowe, guided-parent |  |  |
| StrefaRozliczenie | `Soneta.Kalend.StrefaPracy` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekMagazynuNadgodzin (`Soneta.Kalend.KierunekMagazynuNadgodzin`)
- `RozliczenieNadgodzin` = -1
- `NieDotyczy` = 0 — Razem
- `NadgodzinyDoRozliczenia` = 1
