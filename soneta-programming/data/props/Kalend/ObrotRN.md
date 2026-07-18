# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ObrotRN`
Nazwa tabeli: `ObrotyRN`
Tytuł: Obroty
Opis: Element szczegółowy strefy pracy (StrefaPracy). Obrót magazynu nadgodzin — rejestruje przepływ czasu nadgodzinowego między strefą naliczenia a strefą rozliczenia dla pracownika w danym dniu.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `StrefaNadgodziny` → `StrefaPracy`

- pola bazodanowe (zapisywalne): 0
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 10
- podlisty: 0
- subrowy: 2
- razem: 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| CzasRozliczany | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Nadgodziny | `Soneta.Kalend.PartiaRN` (subrow) | bazodanowe |  |  |
| Nadgodziny.Czas | `Time` | bazodanowe, tylko-odczyt |  |  |
| Nadgodziny.CzasExt | `Time` | tylko-odczyt |  |  |
| Nadgodziny.Kierunek | `Soneta.Kalend.KierunekMagazynuNadgodzin` (enum) | tylko-odczyt |  |  |
| Nadgodziny.Rozliczany | `Time` | bazodanowe, tylko-odczyt |  |  |
| Nadgodziny.RozliczanyExt | `Time` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  | Pracownik, dla którego został naliczony obrót magazynu nadgodzin. |
| Rozliczenie | `Soneta.Kalend.PartiaRN` (subrow) | bazodanowe |  |  |
| StrefaNadgodziny | `Soneta.Kalend.StrefaPracy` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| StrefaRozliczenie | `Soneta.Kalend.StrefaPracy` | bazodanowe, tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekMagazynuNadgodzin (`Soneta.Kalend.KierunekMagazynuNadgodzin`)
- `RozliczenieNadgodzin` = -1
- `NieDotyczy` = 0 — Razem
- `NadgodzinyDoRozliczenia` = 1
