# Pola i właściwości klasy biznesowej: `Soneta.Kalend.DefinicjaZestawieniaCzasu`
Nazwa tabeli: `DefZestawCzasu`
Tytuł: Definicje zestawień czasu
Opis: Konfigurowalna definicja zestawienia czasu pracy. Określa rodzaj zestawienia, sposób powiązania z danymi, algorytm obliczeniowy oraz widoczność w pulpicie pracownika.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Blokada | `bool` | bazodanowe |  |  |
| CellCode | `string` |  |  |  |
| ExtenderCode | `string` |  |  |  |
| Multi | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Powiazanie | `Soneta.Kalend.PowiązaniaZestawieniaCzasu` | bazodanowe, enum |  |  |
| PulpitPracownika | `bool` | bazodanowe |  |  |
| Rodzaj | `Soneta.Kalend.RodzajeZestawieniaCzasu` | bazodanowe, enum |  |  |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
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
