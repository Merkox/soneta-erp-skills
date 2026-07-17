# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaPracy`
Nazwa tabeli: `StrefyPracy`
Tytuł: Strefy dni
Opis: Element szczegółowy dnia pracy (DzienPracy). Strefa czasowa zarejestrowana w dniu pracy pracownika, zawierająca definicję strefy, godziny pracy, czas rozliczany, powiązanie z rozliczeniem nadgodzin oraz przypisaną czynność.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienPracy`
Implementuje interfejsy: `IRozliczenieNadgodzinHost`

- pola bazodanowe: 8
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.Time` |  |  |  |
| CzasRozliczany | `Soneta.Types.Time` | bazodanowe | Czas rozliczany |  |
| CzasRozliczanyWyliczony | `Soneta.Types.Time` |  | Czas rozliczany |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienPracy` | bazodanowe, guided-parent |  |  |
| Kierunek | `Soneta.Kalend.KierunekMagazynuNadgodzin` | enum |  |  |
| Obroty | `Soneta.Business.SubTable<Soneta.Kalend.ObrotRN>` |  |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kalend.ElementRozliczeniaCzasuPracy` | bazodanowe | Rozliczenie |  |
| Zasoby | `Soneta.Business.SubTable<Soneta.Kalend.ZasobRN>` |  |  |  |
| ZasobyDoRozliczenia | `Soneta.Business.SubTable<Soneta.Kalend.ZasobRN>` |  |  |  |
| Zasób | `Soneta.Kalend.ZasobRN` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekMagazynuNadgodzin (`Soneta.Kalend.KierunekMagazynuNadgodzin`)
- `RozliczenieNadgodzin` = -1
- `NieDotyczy` = 0 — Razem
- `NadgodzinyDoRozliczenia` = 1
