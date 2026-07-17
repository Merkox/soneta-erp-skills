# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.Operacja`
Nazwa tabeli: `Operacje`
Tytuł: Operacja produkcyjna
Opis: Element szczegółowy technologii (Technologia). Definiuje pojedynczą operację w procesie produkcyjnym, określając jej kolejność, ilości docelowe i wykonane, czasy planowanego startu i zakończenia, stan realizacji oraz parametry rozliczenia akordowego. Operacje tworzą sekwencję kroków wytwórczych z zależnościami poprzedzającymi.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IKosztTechnHost`, `IProdHistoriaZapis`, `IZasobTechHost`, `IKodowany`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 34

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywna | `bool` |  |  | Określa aktywność operacji. |
| Aktywnosc | `Soneta.Produkcja.Aktywnosc` | bazodanowe, enum | Aktywność | Sposób wyznaczania aktywności dla operacji. |
| BaselineEndDate | `System.DateTime` |  |  |  |
| BaselineStartDate | `System.DateTime` |  |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie operacji. |
| CechaAktywnosc | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha aktywności | Definicja cechy algorytmicznej, służąca do wyliczenia aktywności. |
| CzasRzeczywisty | `Soneta.Types.TimeSec` |  | Czas rzeczywisty | Czas liczony gdy co najmniej jeden pracownik dołączony jest do operacji. |
| CzasyTechn | `Soneta.Business.SubTable<Soneta.Produkcja.CzasTechn>` |  |  |  |
| DataWymagalnosci | `System.DateTime` | bazodanowe | Data wymagalności | Data wymagalności operacji. |
| DefinicjaAkordu | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe | Definicja akordu | Nazwa definicji akordu, jeśli przypisana do operacji. |
| EndDate | `System.DateTime` |  |  |  |
| GantItem | `Soneta.Business.UI.Gantt.IGanttItem` |  |  |  |
| GantPoint | `Soneta.Business.UI.Gantt.GanttPointEnum` | enum |  |  |
| IloscBrakow | `Soneta.Types.Amount` | bazodanowe | Ilość braków | Ilość braków w ramach operacji. |
| IloscDocelowa | `Soneta.Types.Amount` | bazodanowe | Ilość docelowa | Ilość do wykonania w ramach operacji. |
| IloscWykonana | `Soneta.Types.Amount` | bazodanowe | Ilość wykonana | Ilość wykonana w ramach operacji. |
| IsMileStone | `bool` |  |  |  |
| Kod | `string` | bazodanowe | Kod operacji | Symbol, skrócona nazwa operacji. |
| KodyKreskowe | `Soneta.Business.SubTable<Soneta.Core.KodKreskowy>` |  |  |  |
| Kontrola | `Soneta.Core.Kontrola` | enum |  |  |
| Koszty | `Soneta.Business.SubTable<Soneta.Produkcja.KosztTechn>` |  |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa operacji w ramach technologii. |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa operacji | Pełna nazwa operacji. |
| OperacjaBazowa | `Soneta.Produkcja.Operacja` | bazodanowe | Operacja bazowa | Określa operację z technologii wzorcowej dla danej operacji. |
| OperacjaPoprzednia | `Soneta.Produkcja.Operacja` | bazodanowe | Operacja porzedzająca bieżącą | Operacja poprzedzająca bieżącą operację. |
| OperacjaWzor | `Soneta.Produkcja.Operacja` | bazodanowe | Operacja wzorcowa | Określa operację wzorcową dla danej operacji. |
| OperacjePoprzedzajace | `Soneta.Business.SubTable<Soneta.Produkcja.OperacjaPoprzedzajaca>` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis operacji | Opis operacji. |
| OsobyTechn | `Soneta.Business.SubTable` |  | Osoby rzeczywiste | Osoby rzeczywiste powiązane z operacją. |
| OsobyTechnWzorcowe | `Soneta.Business.SubTable` |  | Osoby wzorcowe | Osoby wzorcowe powiązane z operacją. |
| Parent | `Soneta.Business.UI.Gantt.IGanttItem` |  |  |  |
| Planowanie | `Soneta.Produkcja.Operacja.PlanowanieOperacjiWorker` |  |  |  |
| PlanowanyStart | `System.DateTime` | bazodanowe | Planowany start | Planowana data rozpoczęcia. |
| PlanowanyStop | `System.DateTime` | bazodanowe | Planowany stop | Planowana data zakończenia. |
| PolProdukty | `Soneta.Business.SubTable` |  | Półprodukty | Półprodukty powiązane z operacją. |
| PozycjeTechn | `Soneta.Business.SubTable<Soneta.Produkcja.PozycjaTechn>` |  |  |  |
| Predecessor | `Soneta.Business.UI.Gantt.IGanttPredecesor[]` |  |  |  |
| ProdHistorie | `Soneta.Business.SubTable<Soneta.Produkcja.ProdHistoria>` |  |  |  |
| Produkty | `Soneta.Business.SubTable` |  |  | Produkty powiązane z operacją. |
| Progress | `int` |  |  |  |
| Realizacja | `Soneta.Produkcja.Realizacja` |  |  |  |
| Resources | `Soneta.Business.UI.Gantt.IGanttResource[]` |  |  |  |
| RozliczenieAkordowe | `bool` | bazodanowe | Rozliczenie akordowe | Określa czy operacja podlega rozliczeniu akordowemu. |
| SlownikBrakow | `Soneta.Produkcja.ProdSlownik` | bazodanowe |  | Słownik opisu braków dla operacji. |
| StanRealizacji | `Soneta.Handel.StanRealizacji` | bazodanowe, enum | Stan realizacji | Stan realizacji operacji. |
| StartDate | `System.DateTime` |  |  |  |
| Surowce | `Soneta.Business.SubTable` |  |  | Surowce powiązane z operacją. |
| Technologia | `Soneta.Produkcja.Technologia` | bazodanowe | Technologia | Określa technologię przypisaną do operacji. |
| TechnologieWzor | `Soneta.Business.View` |  | Technologie wzorcowe | Określa technologie wzorcowe dla danej operacji. |
| WyswietlajWTechnologii | `bool` |  | Wyświetlaj w technologii | Operacja w technologii powiązanej ze zleceniem produkcyjnym. |
| Wzorcowa | `bool` |  |  | Operacja niepowiązana z technologią. |
| ZasobyTechn | `Soneta.Business.SubTable<Soneta.Produkcja.ZasobTechn>` |  |  |  |
| ZasobyTechnRzeczywiste | `Soneta.Business.SubTable` |  | Zasoby rzeczywiste | Zasoby rzeczywiste powiązane z operacją. |
| ZasobyTechnWzorcowe | `Soneta.Business.SubTable` |  | Zasoby wzorcowe | Zasoby wzorcowe powiązane z operacją. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GanttPointEnum (`Soneta.Business.UI.Gantt.GanttPointEnum`)
- `None` = 0 — Brak
- `StartToStart` = 1 — Początek-Początek
- `StartToEnd` = 2 — Początek-Koniec
- `EndToStart` = 3 — Koniec-Początek
- `EndToEnd` = 4 — Koniec-Koniec

### Kontrola (`Soneta.Core.Kontrola`)
- `Brak` = 0
- `Ostrzeżenie` = 1
- `Błąd` = 2

### StanRealizacji (`Soneta.Handel.StanRealizacji`)
- `Brak` = 0
- `Planowana` = 10
- `Rozpoczęta` = 20
- `Wstrzymana` = 30
- `Wznowiona` = 40
- `Zakończona` = 50
- `Anulowana` = 60
- `Wszystkie` = 999

### Aktywnosc (`Soneta.Produkcja.Aktywnosc`)
- `Tak` = 0 — Tak
- `Nie` = 1
- `Warunkowo` = 2
