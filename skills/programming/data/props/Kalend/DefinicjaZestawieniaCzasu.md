# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaZestawieniaCzasu`
Nazwa tabeli: `DefZestawCzasu`
Tytuł: Definicje zestawień czasu
Opis: Konfigurowalna definicja zestawienia czasu pracy. Określa rodzaj zestawienia, sposób powiązania z danymi, algorytm obliczeniowy oraz widoczność w pulpicie pracownika.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `MemoText` | bazodanowe, podlista |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| CellCode | `string` |  |  |  |
| ExtenderCode | `string` |  |  |  |
| Multi | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Powiazanie | `Soneta.Kalend.PowiązaniaZestawieniaCzasu` (enum) | bazodanowe |  |  |
| PulpitPracownika | `bool` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kalend.RodzajeZestawieniaCzasu` (enum) | bazodanowe |  |  |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| SourceCode | `string` |  |  |  |
| WierszeDowolnegoTypu | `bool` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PowiązaniaZestawieniaCzasu (`Soneta.Kalend.PowiązaniaZestawieniaCzasu`)
- `Brak` = 0
- `DokumentAktualizacjiPlanuPracy` = 1
- `DokumentAktualizacjiCzasuPracy` = 2

### RodzajeZestawieniaCzasu (`Soneta.Kalend.RodzajeZestawieniaCzasu`)
- `KalendarzPlanu` = 1
- `KalendarzPracy` = 2
- `Zestawienie` = 3
- `Grafik` = 4
