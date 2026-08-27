# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienRCP`
Nazwa tabeli: `DniRCP`
Tytuł: Dni RCP
Opis: Element szczegółowy pracownika (Pracownik). Dzień RCP pracownika — zagregowany zapis obecności z czytnika RCP dla danej daty, zawierający stan weryfikacji, status importu, godziny pracy, uwagi oraz ewentualne błędy.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bledy | `MemoText` | bazodanowe, podlista |  |  |
| BlokadaStref | `bool` |  |  |  |
| Czas | `Time` | tylko-odczyt |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  |  |
| DzienTygodnia | `Soneta.Kadry.Config.WeekDays` (enum) | tylko-odczyt |  |  |
| GetStrefyOrg | `System.Collections.Generic.List<Soneta.Kalend.PracaZdalnaRCP.StrefaDoRCP>` | podlista |  |  |
| KolorRCP | `System.Drawing.Color` | tylko-odczyt |  |  |
| KolorRCPFont | `System.Drawing.Color` | tylko-odczyt |  |  |
| OdGodziny | `Time` | tylko-odczyt |  |  |
| Praca | `Soneta.Kalend.CzasPracy` (subrow) | bazodanowe |  |  |
| Praca.Czas | `Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Time` |  |  |  |
| Praca.OdGodziny | `Time` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| RcpOK | `bool` | bazodanowe |  | Informacja o stanie rekordu po imporcie z RCP |
| StanRCP | `Soneta.Kalend.StanWeryfikacjiRCP` (enum) | bazodanowe |  | Informacja o stanie weryfikacji rekordu z RCP |
| Strefy | `SubTable<Soneta.Kalend.StrefaRCP>` | podlista |  |  |
| StrefyOrg | `MemoText` | bazodanowe, podlista |  |  |
| Uwagi | `MemoText` | bazodanowe, podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### WeekDays (`Soneta.Kadry.Config.WeekDays`)
- `Sunday` = 0 — Niedziela
- `Monday` = 1 — Poniedziałek
- `Tuesday` = 2 — Wtorek
- `Wednesday` = 3 — Środa
- `Thursday` = 4 — Czwartek
- `Friday` = 5 — Piątek
- `Saturday` = 6 — Sobota

### StanWeryfikacjiRCP (`Soneta.Kalend.StanWeryfikacjiRCP`)
- `DoWeryfikacji` = 0
- `PrzekazanyDoWyjaśnienia` = 1
- `DoZatwierdzenia` = 2
- `Modyfikowany` = 3
- `Naniesiony` = 4
- `Poprawny` = 5
- `Błędny` = 6
- `WymagaWeryfikacji` = 7
- `Wszystkie` = 10
