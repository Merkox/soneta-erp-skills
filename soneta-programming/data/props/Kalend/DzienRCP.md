# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DzienRCP`
Nazwa tabeli: `DniRCP`
Tytuł: Dni RCP
Opis: Element szczegółowy pracownika (Pracownik). Dzień RCP pracownika — zagregowany zapis obecności z czytnika RCP dla danej daty, zawierający stan weryfikacji, status importu, godziny pracy, uwagi oraz ewentualne błędy.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Pracownik` → `Pracownik`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bledy | `Soneta.Business.MemoText` | bazodanowe |  |  |
| BlokadaStref | `bool` |  |  |  |
| Czas | `Soneta.Types.Time` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DzienTygodnia | `Soneta.Kadry.Config.WeekDays` | enum |  |  |
| GetStrefyOrg | `System.Collections.Generic.List<Soneta.Kalend.PracaZdalnaRCP.StrefaDoRCP>` |  |  |  |
| KolorRCP | `System.Drawing.Color` |  |  |  |
| KolorRCPFont | `System.Drawing.Color` |  |  |  |
| OdGodziny | `Soneta.Types.Time` |  |  |  |
| Praca | `Soneta.Kalend.CzasPracy` | bazodanowe |  |  |
| Praca.Czas | `Soneta.Types.Time` | bazodanowe |  |  |
| Praca.DoGodziny | `Soneta.Types.Time` |  |  |  |
| Praca.OdGodziny | `Soneta.Types.Time` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, guided-parent |  |  |
| RcpOK | `bool` | bazodanowe |  | Informacja o stanie rekordu po imporcie z RCP |
| StanRCP | `Soneta.Kalend.StanWeryfikacjiRCP` | bazodanowe, enum |  | Informacja o stanie weryfikacji rekordu z RCP |
| Strefy | `Soneta.Business.SubTable<Soneta.Kalend.StrefaRCP>` |  |  |  |
| StrefyOrg | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe |  |  |

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
