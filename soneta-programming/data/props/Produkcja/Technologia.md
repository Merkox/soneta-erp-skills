# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.Technologia`
Nazwa tabeli: `Technologie`
Tytuł: Technologie produkcyjne
Opis: Definicja technologii produkcyjnej opisująca sposób wytworzenia produktu. Technologia wzorcowa zawiera kod, nazwę, stan zatwierdzenia oraz algorytm podziału kosztu; po powiązaniu ze zleceniem produkcyjnym (DokumentHandlowy) powstaje kopia robocza technologii z parametrami planowania (daty, sposób planowania).
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IKosztTechnHost`, `IZasobTechHost`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 24

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AlgorytmPodzialuKosztu | `Soneta.Produkcja.KosztWytworzenia.AlgorytmPodzialu` | bazodanowe, enum | Algorytm podzialu kosztu | Algorytm proporcjonalnego podziału kosztu na części przypadające na produkowane produkty. |
| Blokada | `bool` | bazodanowe | Zablokowana | Określa zablokowanie technologii. Zablokowane technologie nie będą wyświetlane na listach wyboru. |
| Bufor | `bool` |  |  | Określa czy technologia jest w buforze. |
| CzasOd | `Soneta.Types.TimeSec` | bazodanowe | Czas rozpoczęcia | Czas rozpoczęcia technologii. |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data rozpoczęcia | Data rozpoczęcia technologii. |
| GanttItems | `System.Collections.Generic.List<Soneta.Produkcja.Technologia.GanttItem>` |  |  |  |
| JestAktywneZlecenie | `bool` |  | Jest aktywne zlecenie | Z technologią powiązane jest aktywne zlecenie produkcyjne. |
| JestZlecenie | `bool` |  | Jest zlecenie | Z technologią powiązane jest zlecenie produkcyjne. |
| Kod | `string` | bazodanowe | Kod technologii | Symbol, skrócona nazwa technologii. |
| Koszty | `Soneta.Business.SubTable<Soneta.Produkcja.KosztTechn>` |  |  |  |
| KosztyTechn | `Soneta.Business.SubTable<Soneta.Produkcja.KosztTechn>` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa technologii | Pełna nazwa technologii. |
| Operacje | `Soneta.Business.LpSubTable<Soneta.Produkcja.Operacja>` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis technologii | Opis technologii. |
| OsobyTechn | `Soneta.Business.SubTable` |  | Osoby rzeczywiste | Osoby rzeczywiste powiązane z technologią. |
| OsobyTechnWzorcowe | `Soneta.Business.SubTable` |  | Osoby wzorcowe | Osoby wzorcowe powiązane z technologią. |
| Planowanie | `Soneta.Produkcja.Technologia.PlanowanieTechnologiiWorker` |  |  |  |
| PolProdukty | `Soneta.Business.SubTable` |  | Półprodukty | Półprodukty powiązane z technologią. |
| PolProduktyArr | `Soneta.Produkcja.PozycjaTechn[]` |  | Półprodukty aktywne | Półprodukty powiązane z technologią. |
| PozycjeTechn | `Soneta.Business.SubTable<Soneta.Produkcja.PozycjaTechn>` |  |  |  |
| Produkty | `Soneta.Business.SubTable` |  |  | Produkty powiązane z technologią. |
| ProduktyArr | `Soneta.Produkcja.PozycjaTechn[]` |  | Produkty aktywne | Produkty powiązane z technologią. |
| Realizacja | `Soneta.Produkcja.Realizacja` |  |  |  |
| Sposob | `Soneta.Produkcja.SposobPlanowania` | bazodanowe, enum | Sposób planowania | Określa sposób planowania technologii. |
| Stan | `Soneta.Produkcja.StanTechnologii` | bazodanowe, enum | Stan technologii | Określa stan technologii (bufor, zatwierdzona). |
| Surowce | `Soneta.Business.SubTable` |  |  | Surowce powiązane z technologią. |
| SurowceArr | `Soneta.Produkcja.PozycjaTechn[]` |  | Surowce aktywne | Aktywne surowce powiązane z technologią. |
| TechnologiaRow | `Soneta.Produkcja.Technologia` |  |  |  |
| TechnologiaWzor | `Soneta.Produkcja.Technologia` | bazodanowe | Technologia wzorcowa | Określa technologię wzorcową dla danej technologii. |
| Wzorcowa | `bool` |  |  | Określa czy technologia jest wzorcowa. |
| ZasobyTechn | `Soneta.Business.SubTable<Soneta.Produkcja.ZasobTechn>` |  |  |  |
| ZasobyTechnRzeczywiste | `Soneta.Business.SubTable` |  | Zasoby rzeczywiste | Zasoby rzeczywiste powiązane z technologią. |
| ZasobyTechnWzorcowe | `Soneta.Business.SubTable` |  | Zasoby wzorcowe | Zasoby wzorcowe powiązane z technologią. |
| Zatwierdzona | `bool` |  |  | Określa czy technologia jest zatwierdzona. |
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
