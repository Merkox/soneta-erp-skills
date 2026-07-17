# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZasobRN`
Nazwa tabeli: `ZasobyRN`
Tytuł: Zasoby
Opis: Element szczegółowy strefy pracy (StrefaPracy). Zasób magazynu nadgodzin — rejestruje partię czasu nadgodzinowego (naliczonego lub rozliczonego) dla pracownika w danym dniu, z określonym kierunkiem operacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Strefa` → `StrefaPracy`

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 3

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Kierunek | `Soneta.Kalend.KierunekMagazynuNadgodzin` | bazodanowe, enum |  |  |
| Partia | `Soneta.Kalend.PartiaRN` | bazodanowe |  |  |
| Partia.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Partia.CzasExt | `Soneta.Types.Time` |  |  |  |
| Partia.Kierunek | `Soneta.Kalend.KierunekMagazynuNadgodzin` | enum |  |  |
| Partia.Rozliczany | `Soneta.Types.Time` | bazodanowe |  |  |
| Partia.RozliczanyExt | `Soneta.Types.Time` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  | Pracownik, dla którego został naliczony zasób magazynu nadgodzin. |
| Strefa | `Soneta.Kalend.StrefaPracy` | bazodanowe, guided-parent |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekMagazynuNadgodzin (`Soneta.Kalend.KierunekMagazynuNadgodzin`)
- `RozliczenieNadgodzin` = -1
- `NieDotyczy` = 0 — Razem
- `NadgodzinyDoRozliczenia` = 1
