# Pola i właściwości klasy biznesowej: `Soneta.RMK.KosztRMK`
Nazwa tabeli: `KosztyRMK`
Tytuł: Koszty RMK
Opis: Koszt rozliczany międzyokresowo (RMK). Definiuje parametry rozliczania kosztu w czasie: algorytm naliczania (liniowy, degresywny), okres rozliczeń, datę rozpoczęcia odpisów, minimalną kwotę odpisu oraz proporcjonalność pierwszego odpisu. Obsługuje odrębne algorytmy bilansowe i podatkowe.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`, `IZrodloPodzielnikaKosztow`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Algorytm | `Soneta.RMK.AlgorytmRMK` (enum) | bazodanowe |  | Określa rodzaj algorytmu, wg którego naliczna są rozliczenia |
| AlgorytmPodatkowy | `Soneta.RMK.AlgorytmRMK` (enum) | bazodanowe |  | Określa rodzaj algorytmu, wg którego naliczna są rozliczenia |
| CentrumKosztow | `Soneta.Core.CentrumKosztow` | bazodanowe |  | Centrum kosztów |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| GrupaKosztow | `string` | bazodanowe |  | Grupa kosztów |
| MinimalnaKwotaOdpisu | `decimal` | bazodanowe |  | Określa kwotę poniżej której nie będą pozostawiane odpisy na kolejną ratę |
| Naliczanie | `Soneta.RMK.NaliczanieRMK` (enum) | bazodanowe |  | Określa od jakiej wartości naliczane są rozliczenia |
| Nazwa | `string` | bazodanowe |  | Nazwa kosztu |
| Nieaktywny | `bool` | bazodanowe |  | Aktywność kosztu |
| Obroty | `SubTable<Soneta.RMK.ObrotRMK>` | podlista |  |  |
| Oddzial | `Soneta.Core.OddzialFirmy` | bazodanowe |  | Oddział firmy |
| OkresRozliczen | `Soneta.RMK.OkresRozliczenRMK` (enum) | bazodanowe |  | Określa w jakich okresach naliczane są rozliczenia |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis kosztu |
| OpisAlgorytmu | `string` | tylko-odczyt |  |  |
| OpisAlgorytmuPodatkowego | `string` | tylko-odczyt |  |  |
| ParametrAlgorytmu | `decimal` | bazodanowe |  | Określa parametr rozliczeń wg wybranego algorytmu |
| ParametrAlgorytmuPodatkowego | `decimal` | bazodanowe |  | Określa parametr rozliczeń wg wybranego algorytmu |
| PierwszyOdpisProporcjonalny | `bool` | bazodanowe |  | Określa, że pierwszy odpis będzie proporcjonalny do ilości dni |
| Podzielniki | `SubTable<Soneta.Core.PodzielnikKosztow>` | podlista |  |  |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| RozliczajOdDnia | `Date` | bazodanowe |  | Określa od jakiej daty naliczane są rozliczenia |
| Segment | `string` | tylko-odczyt |  |  |
| Symbol | `string` | bazodanowe |  | Symbol kosztu |
| Wielooddzialowosc | `bool` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### AlgorytmRMK (`Soneta.RMK.AlgorytmRMK`)
- `Procentowy` = 0 — Procentowy
- `Kwotowy` = 1 — Kwotowy
- `Ratalny` = 2 — Ratalny (nadrzędna ilość rat)
- `RatalnyProporcjonalny` = 3 — Ratalny (nadrzędna proporcjonalność)
- `Dzienny` = 4 — Dzienny (wg obrotów)

### NaliczanieRMK (`Soneta.RMK.NaliczanieRMK`)
- `WgWartosciAktualnej` = 0 — Wg wartości aktualnej
- `WgWartosciPoprzedniegoMiesiaca` = 1 — Wg wartości poprzedniego miesiaca

### OkresRozliczenRMK (`Soneta.RMK.OkresRozliczenRMK`)
- `Miesieczny` = 0 — Miesięczny
- `Kwartalny` = 1 — Kwartalny
- `Polroczny` = 2 — Półroczny
- `Roczny` = 3 — Roczny
