# Pola i właściwości klasy biznesowej: `Soneta.Kalend.StrefaPracy`
Nazwa tabeli: `StrefyPracy`
Tytuł: Strefy dni
Opis: Element szczegółowy dnia pracy (DzienPracy). Strefa czasowa zarejestrowana w dniu pracy pracownika, zawierająca definicję strefy, godziny pracy, czas rozliczany, powiązanie z rozliczeniem nadgodzin oraz przypisaną czynność.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Dzien` → `DzienPracy`
Implementuje interfejsy: `IRozliczenieNadgodzinHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Time` | tylko-odczyt |  |  |
| CzasRozliczany | `Time` | bazodanowe | Czas rozliczany |  |
| CzasRozliczanyWyliczony | `Time` |  | Czas rozliczany |  |
| Czynnosc | `Soneta.Kalend.CzynnoscNaObiekcieDoPlanowania` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaStrefy` | bazodanowe |  |  |
| DefinicjaNet | `Soneta.Kalend.DefinicjaStrefy` |  |  |  |
| Dzien | `Soneta.Kalend.DzienPracy` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Kierunek | `Soneta.Kalend.KierunekMagazynuNadgodzin` (enum) | tylko-odczyt |  |  |
| Obroty | `SubTable<Soneta.Kalend.ObrotRN>` | podlista |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| Rozliczenie | `Soneta.Kalend.ElementRozliczeniaCzasuPracy` | bazodanowe, tylko-odczyt | Rozliczenie |  |
| Zasoby | `SubTable<Soneta.Kalend.ZasobRN>` | podlista |  |  |
| ZasobyDoRozliczenia | `SubTable<Soneta.Kalend.ZasobRN>` | podlista |  |  |
| Zasób | `Soneta.Kalend.ZasobRN` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KierunekMagazynuNadgodzin (`Soneta.Kalend.KierunekMagazynuNadgodzin`)
- `RozliczenieNadgodzin` = -1
- `NieDotyczy` = 0 — Razem
- `NadgodzinyDoRozliczenia` = 1
