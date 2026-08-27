# Pola i właściwości klasy biznesowej: `Soneta.Kalend.ZasobRN`
Nazwa tabeli: `ZasobyRN`
Tytuł: Zasoby
Opis: Element szczegółowy strefy pracy (StrefaPracy). Zasób magazynu nadgodzin — rejestruje partię czasu nadgodzinowego (naliczonego lub rozliczonego) dla pracownika w danym dniu, z określonym kierunkiem operacji.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Strefa` → `StrefaPracy`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| Kierunek | `Soneta.Kalend.KierunekMagazynuNadgodzin` (enum) | bazodanowe, tylko-odczyt |  |  |
| Partia | `Soneta.Kalend.PartiaRN` (subrow) | bazodanowe |  |  |
| Partia.Czas | `Time` | bazodanowe, tylko-odczyt |  |  |
| Partia.CzasExt | `Time` | tylko-odczyt |  |  |
| Partia.Kierunek | `Soneta.Kalend.KierunekMagazynuNadgodzin` (enum) | tylko-odczyt |  |  |
| Partia.Rozliczany | `Time` | bazodanowe, tylko-odczyt |  |  |
| Partia.RozliczanyExt | `Time` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  | Pracownik, dla którego został naliczony zasób magazynu nadgodzin. |
| Strefa | `Soneta.Kalend.StrefaPracy` | bazodanowe, tylko-odczyt, guided-parent |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekMagazynuNadgodzin (`Soneta.Kalend.KierunekMagazynuNadgodzin`)
- `RozliczenieNadgodzin` = -1
- `NieDotyczy` = 0 — Razem
- `NadgodzinyDoRozliczenia` = 1
