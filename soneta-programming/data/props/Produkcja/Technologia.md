# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.Technologia`
Nazwa tabeli: `Technologie`
Tytuł: Technologie produkcyjne
Opis: Definicja technologii produkcyjnej opisująca sposób wytworzenia produktu. Technologia wzorcowa zawiera kod, nazwę, stan zatwierdzenia oraz algorytm podziału kosztu; po powiązaniu ze zleceniem produkcyjnym (DokumentHandlowy) powstaje kopia robocza technologii z parametrami planowania (daty, sposób planowania).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IKosztTechnHost`, `IZasobTechHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmPodzialuKosztu | `Soneta.Produkcja.KosztWytworzenia.AlgorytmPodzialu` (enum) | bazodanowe | Algorytm podzialu kosztu | Algorytm proporcjonalnego podziału kosztu na części przypadające na produkowane produkty. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie technologii. Zablokowane technologie nie będą wyświetlane na listach wyboru. |
| Bufor | `bool` | tylko-odczyt |  | Określa czy technologia jest w buforze. |
| CzasOd | `TimeSec` | bazodanowe | Czas rozpoczęcia | Czas rozpoczęcia technologii. |
| DataOd | `Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia technologii. |
| GanttItems | `System.Collections.Generic.List<Soneta.Produkcja.Technologia.GanttItem>` | podlista |  |  |
| JestAktywneZlecenie | `bool` | tylko-odczyt | Jest aktywne zlecenie | Z technologią powiązane jest aktywne zlecenie produkcyjne. |
| JestZlecenie | `bool` | tylko-odczyt | Jest zlecenie | Z technologią powiązane jest zlecenie produkcyjne. |
| Kod | `string` | bazodanowe | Kod technologii | Symbol, skrócona nazwa technologii. |
| Koszty | `SubTable<Soneta.Produkcja.KosztTechn>` | podlista |  |  |
| KosztyTechn | `SubTable<Soneta.Produkcja.KosztTechn>` | podlista |  |  |
| Nazwa | `string` | bazodanowe | Nazwa technologii | Pełna nazwa technologii. |
| Operacje | `LpSubTable<Soneta.Produkcja.Operacja>` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista | Opis technologii | Opis technologii. |
| OsobyTechn | `SubTable` | podlista | Osoby rzeczywiste | Osoby rzeczywiste powiązane z technologią. |
| OsobyTechnWzorcowe | `SubTable` | podlista | Osoby wzorcowe | Osoby wzorcowe powiązane z technologią. |
| Planowanie | `Soneta.Produkcja.Technologia.PlanowanieTechnologiiWorker` | tylko-odczyt |  |  |
| PolProdukty | `SubTable` | podlista | Półprodukty | Półprodukty powiązane z technologią. |
| PolProduktyArr | `Soneta.Produkcja.PozycjaTechn[]` | podlista | Półprodukty aktywne | Półprodukty powiązane z technologią. |
| PozycjeTechn | `SubTable<Soneta.Produkcja.PozycjaTechn>` | podlista |  |  |
| Produkty | `SubTable` | podlista |  | Produkty powiązane z technologią. |
| ProduktyArr | `Soneta.Produkcja.PozycjaTechn[]` | podlista | Produkty aktywne | Produkty powiązane z technologią. |
| Realizacja | `Soneta.Produkcja.Realizacja` | tylko-odczyt |  |  |
| Sposob | `Soneta.Produkcja.SposobPlanowania` (enum) | bazodanowe | Sposób planowania | Określa sposób planowania technologii. |
| Stan | `Soneta.Produkcja.StanTechnologii` (enum) | bazodanowe | Stan technologii | Określa stan technologii (bufor, zatwierdzona). |
| Surowce | `SubTable` | podlista |  | Surowce powiązane z technologią. |
| SurowceArr | `Soneta.Produkcja.PozycjaTechn[]` | podlista | Surowce aktywne | Aktywne surowce powiązane z technologią. |
| TechnologiaRow | `Soneta.Produkcja.Technologia` | tylko-odczyt |  |  |
| TechnologiaWzor | `Soneta.Produkcja.Technologia` | bazodanowe | Technologia wzorcowa | Określa technologię wzorcową dla danej technologii. |
| Wzorcowa | `bool` | tylko-odczyt |  | Określa czy technologia jest wzorcowa. |
| ZasobyTechn | `SubTable<Soneta.Produkcja.ZasobTechn>` | podlista |  |  |
| ZasobyTechnRzeczywiste | `SubTable` | podlista | Zasoby rzeczywiste | Zasoby rzeczywiste powiązane z technologią. |
| ZasobyTechnWzorcowe | `SubTable` | podlista | Zasoby wzorcowe | Zasoby wzorcowe powiązane z technologią. |
| Zatwierdzona | `bool` | tylko-odczyt |  | Określa czy technologia jest zatwierdzona. |
| Zlecenie | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Zlecenie produkcyjne | Zlecenie produkcyjne powiązane z kopią technologii wzorcowej. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AlgorytmPodzialu (`Soneta.Produkcja.KosztWytworzenia.AlgorytmPodzialu`)
- `Ilosc` = 0 — Wg ilości
- `Wspolczynnik` = 1 — Wg współczynnika
- `IloscWspolczynnik` = 2 — Wg ilości i współczynnika

### SposobPlanowania (`Soneta.Produkcja.SposobPlanowania`)
- `OdTeraz` = 0 — Od teraz
- `OdTerminu` = 1

### StanTechnologii (`Soneta.Produkcja.StanTechnologii`)
- `Bufor` = 0 — Bufor
- `Zatwierdzona` = 1
- `Razem` = 99
