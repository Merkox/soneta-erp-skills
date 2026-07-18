# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.Operacja`
Nazwa tabeli: `Operacje`
Tytuł: Operacja produkcyjna
Opis: Element szczegółowy technologii (Technologia). Definiuje pojedynczą operację w procesie produkcyjnym, określając jej kolejność, ilości docelowe i wykonane, czasy planowanego startu i zakończenia, stan realizacji oraz parametry rozliczenia akordowego. Operacje tworzą sekwencję kroków wytwórczych z zależnościami poprzedzającymi.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IKosztTechnHost`, `IProdHistoriaZapis`, `IZasobTechHost`, `IKodowany`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktywna | `bool` | tylko-odczyt |  | Określa aktywność operacji. |
| Aktywnosc | `Soneta.Produkcja.Aktywnosc` (enum) | bazodanowe | Aktywność | Sposób wyznaczania aktywności dla operacji. |
| BaselineEndDate | `System.DateTime` |  |  |  |
| BaselineStartDate | `System.DateTime` |  |  |  |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie operacji. |
| CechaAktywnosc | `FeatureDefinition` | bazodanowe | Cecha aktywności | Definicja cechy algorytmicznej, służąca do wyliczenia aktywności. |
| CzasRzeczywisty | `TimeSec` | tylko-odczyt | Czas rzeczywisty | Czas liczony gdy co najmniej jeden pracownik dołączony jest do operacji. |
| CzasyTechn | `SubTable<Soneta.Produkcja.CzasTechn>` | podlista |  |  |
| DataWymagalnosci | `System.DateTime` | bazodanowe | Data wymagalności | Data wymagalności operacji. |
| DefinicjaAkordu | `Soneta.Kadry.DefinicjaAkordu` | bazodanowe | Definicja akordu | Nazwa definicji akordu, jeśli przypisana do operacji. |
| EndDate | `System.DateTime` |  |  |  |
| GantItem | `UI.Gantt.IGanttItem` |  |  |  |
| GantPoint | `UI.Gantt.GanttPointEnum` (enum) |  |  |  |
| IloscBrakow | `Amount` | bazodanowe | Ilość braków | Ilość braków w ramach operacji. |
| IloscDocelowa | `Amount` | bazodanowe | Ilość docelowa | Ilość do wykonania w ramach operacji. |
| IloscWykonana | `Amount` | bazodanowe | Ilość wykonana | Ilość wykonana w ramach operacji. |
| IsMileStone | `bool` |  |  |  |
| Kod | `string` | bazodanowe | Kod operacji | Symbol, skrócona nazwa operacji. |
| KodyKreskowe | `SubTable<Soneta.Core.KodKreskowy>` | podlista |  |  |
| Kontrola | `Soneta.Core.Kontrola` (enum) | tylko-odczyt |  |  |
| Koszty | `SubTable<Soneta.Produkcja.KosztTechn>` | podlista |  |  |
| Lp | `int` | bazodanowe | Lp | Liczba porządkowa operacji w ramach technologii. |
| Name | `string` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa operacji | Pełna nazwa operacji. |
| OperacjaBazowa | `Soneta.Produkcja.Operacja` | bazodanowe | Operacja bazowa | Określa operację z technologii wzorcowej dla danej operacji. |
| OperacjaPoprzednia | `Soneta.Produkcja.Operacja` | bazodanowe | Operacja porzedzająca bieżącą | Operacja poprzedzająca bieżącą operację. |
| OperacjaWzor | `Soneta.Produkcja.Operacja` | bazodanowe | Operacja wzorcowa | Określa operację wzorcową dla danej operacji. |
| OperacjePoprzedzajace | `SubTable<Soneta.Produkcja.OperacjaPoprzedzajaca>` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis operacji | Opis operacji. |
| OsobyTechn | `SubTable` | podlista | Osoby rzeczywiste | Osoby rzeczywiste powiązane z operacją. |
| OsobyTechnWzorcowe | `SubTable` | podlista | Osoby wzorcowe | Osoby wzorcowe powiązane z operacją. |
| Parent | `UI.Gantt.IGanttItem` |  |  |  |
| Planowanie | `Soneta.Produkcja.Operacja.PlanowanieOperacjiWorker` | tylko-odczyt |  |  |
| PlanowanyStart | `System.DateTime` | bazodanowe | Planowany start | Planowana data rozpoczęcia. |
| PlanowanyStop | `System.DateTime` | bazodanowe | Planowany stop | Planowana data zakończenia. |
| PolProdukty | `SubTable` | podlista | Półprodukty | Półprodukty powiązane z operacją. |
| PozycjeTechn | `SubTable<Soneta.Produkcja.PozycjaTechn>` | podlista |  |  |
| Predecessor | `UI.Gantt.IGanttPredecesor[]` | podlista |  |  |
| ProdHistorie | `SubTable<Soneta.Produkcja.ProdHistoria>` | podlista |  |  |
| Produkty | `SubTable` | podlista |  | Produkty powiązane z operacją. |
| Progress | `int` |  |  |  |
| Realizacja | `Soneta.Produkcja.Realizacja` | tylko-odczyt |  |  |
| Resources | `UI.Gantt.IGanttResource[]` | podlista |  |  |
| RozliczenieAkordowe | `bool` | bazodanowe | Rozliczenie akordowe | Określa czy operacja podlega rozliczeniu akordowemu. |
| SlownikBrakow | `Soneta.Produkcja.ProdSlownik` | bazodanowe |  | Słownik opisu braków dla operacji. |
| StanRealizacji | `Soneta.Handel.StanRealizacji` (enum) | bazodanowe | Stan realizacji | Stan realizacji operacji. |
| StartDate | `System.DateTime` |  |  |  |
| Surowce | `SubTable` | podlista |  | Surowce powiązane z operacją. |
| Technologia | `Soneta.Produkcja.Technologia` | bazodanowe | Technologia | Określa technologię przypisaną do operacji. |
| TechnologieWzor | `View` | podlista | Technologie wzorcowe | Określa technologie wzorcowe dla danej operacji. |
| WyswietlajWTechnologii | `bool` | tylko-odczyt | Wyświetlaj w technologii | Operacja w technologii powiązanej ze zleceniem produkcyjnym. |
| Wzorcowa | `bool` | tylko-odczyt |  | Operacja niepowiązana z technologią. |
| ZasobyTechn | `SubTable<Soneta.Produkcja.ZasobTechn>` | podlista |  |  |
| ZasobyTechnRzeczywiste | `SubTable` | podlista | Zasoby rzeczywiste | Zasoby rzeczywiste powiązane z operacją. |
| ZasobyTechnWzorcowe | `SubTable` | podlista | Zasoby wzorcowe | Zasoby wzorcowe powiązane z operacją. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### GanttPointEnum (`UI.Gantt.GanttPointEnum`)
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
