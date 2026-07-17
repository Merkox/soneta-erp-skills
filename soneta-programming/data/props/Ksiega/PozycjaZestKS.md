# Pola i właściwości klasy biznesowej: `Soneta.Ksiega.PozycjaZestKS`
Nazwa tabeli: `PozycjeZestKS`
Tytuł: Pozycje zestawień księgowych
Opis: Element szczegółowy zestawienia księgowego (ZestawienieKS). Definiuje wiersz (pozycję) raportu księgowego z symbolem, opisem i wyrażeniem obliczeniowym. Pozycje tworzą hierarchię (subpozycje) i mogą być sumowane automatycznie oraz chronione przed edycją.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `Zestawienie` → `ZestawienieKS`
Implementuje interfejsy: `IPozycjaZestawieniaRoot`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 9

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| BlokadaDodPozycji | `bool` | bazodanowe | Blokada dod subpozycji | Blokada możliwości dodawania subpozycji |
| BlokadaEdycji | `bool` | bazodanowe | Blokada edycji | Blokada możliwości edycji pozycji |
| BlokadaNumeru | `bool` | bazodanowe | Blokada Lp. | Blokada możliwości zmiany numeru pozycji |
| BlokadaWyrazenia | `bool` | bazodanowe | Blokada wyrażenia | Blokada możliwości zmiany wyrażenia pozycji |
| ClassName | `string` |  |  |  |
| Identyfikator | `string` | bazodanowe |  | Opcjonalny identyfikator pozycji |
| IsSystem | `bool` |  |  |  |
| Kod | `string` |  |  |  |
| Lp | `int` | bazodanowe |  |  |
| Numer | `string` |  |  |  |
| Opis | `string` | bazodanowe |  |  |
| OpisPelny | `string` |  |  | Opis pełny |
| Poziom | `int` |  |  | Poziom pozycji w zestawieniu |
| PozycjaNadrzedna | `Soneta.Ksiega.PozycjaZestKS` |  |  | Pozycja nadrzędna |
| RootPozycji | `Soneta.Ksiega.IPozycjaZestawieniaRoot` | bazodanowe, iface-ref |  |  |
| SubPozycje | `Soneta.Business.SubTable<Soneta.Ksiega.PozycjaZestKS>` |  |  |  |
| Sumowanie | `Soneta.Ksiega.SumowaniePozycji` | bazodanowe, enum |  |  |
| SumowanieZnak | `string` |  |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Typ | `Soneta.Ksiega.TypPozycjiZestawienia` | bazodanowe, enum |  |  |
| WylaczNumeracje | `bool` | bazodanowe |  |  |
| Wyrazenie | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Zestawienie | `Soneta.Ksiega.ZestawienieKS` | bazodanowe, guided-parent |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| RootPozycji | `IPozycjaZestawieniaRoot` | `PozycjaZestKS`, `ZestawienieKS` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SumowaniePozycji (`Soneta.Ksiega.SumowaniePozycji`)
- `Brak` = 0 — Brak
- `ZeZnakiemDodatnim` = 1
- `ZeZnakiemUjemnym` = 2

### TypPozycjiZestawienia (`Soneta.Ksiega.TypPozycjiZestawienia`)
- `Użytkownika` = 0 — Użytkownika
- `Przychody` = 1
- `PrzychodyPozaRP` = 2
- `KosztyBezReklamy` = 3
- `Reklama` = 4
- `Remanent` = 5
- `InnePrzychodyPozaRP` = 6
- `Koszty` = 7
- `KosztyPozaRP` = 8
- `InneKosztyPozaRP` = 9
