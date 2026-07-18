# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOperacjaZlecenia`
Nazwa tabeli: `ProOperacjeZlec`
Tytuł: Operacje zleceń
Opis: Element szczegółowy zlecenia produkcyjnego (ProZlecenie). Reprezentuje pojedynczą operację do wykonania w ramach zlecenia z przypisaną definicją operacji, definicją meldunku, terminami rozpoczęcia i zakończenia, sposobem wyceny oraz stanem realizacji i ilością zameldowaną.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zlecenie` → `ProZlecenie`

- pola bazodanowe (zapisywalne): 13
- pola kalkulowane (zapisywalne): 5
- pola tylko-odczyt: 7
- podlisty: 14
- subrowy: 0
- razem: 39

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `TimeSec` | bazodanowe |  | Czas operacji zlecenia. |
| CzasMiedzyoperacyjny | `TimeSec` | bazodanowe | Czas międzyoperacyjny | Czas międzyoperacyjny operacji zlecenia. |
| CzasRozpoczecia | `TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia operacji zlecenia. |
| CzasZakonczenia | `TimeSec` |  | Czas zakończenia | Czas zakończenia operacji zlecenia. |
| DataRozpoczecia | `Date` |  | Data rozpoczęcia | Data rozpoczęcia operacji zlecenia. |
| DataZakonczenia | `Date` |  | Data zakończenia | Data zakończenia operacji zlecenia. |
| DefinicjaMeldunku | `Soneta.ProdukcjaPro.ProDefinicjaMeldunku` | bazodanowe | Definicja meldunku | Definicja meldunku dla operacji zlecenia. |
| DefinicjaOperacji | `Soneta.ProdukcjaPro.ProDefinicjaOperacji` | bazodanowe | Definicja operacji | Definicja operacji dla operacji zlecenia. |
| DoRealizacji | `bool` | tylko-odczyt | Do realizacji | Operacja zlecenia do realizacji. |
| IloscDoZameldowania | `Amount` | bazodanowe | Ilość do zameldowania | Ilość pozostała do zameldowania operacji zlecenia. |
| IloscZameldowana | `Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana operacji zlecenia. |
| IloscZameldowanaProcent | `Percent` | tylko-odczyt | Ilość zameldowana [%] | Procentowy wskaźnik ilości zameldowanej dla operacji zlecenia. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiZlecenia` | tylko-odczyt |  | Kalkulacja operacji zlecenia. |
| Kalkulacje | `SubTable<Soneta.ProdukcjaPro.ProKalkulacjaOperacjiZlecenia>` | podlista |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa operacji zlecenia. |
| Materialy | `LpSubTable<Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia>` | podlista |  |  |
| Meldunki | `SubTable<Soneta.ProdukcjaPro.ProMeldunek>` | podlista |  |  |
| Odpady | `LpSubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiZlecenia>` | podlista |  |  |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | bazodanowe | Operacja technologii | Operacja technologii dla operacji zlecenia. |
| OperacjeNastepujace | `SubTable<Soneta.ProdukcjaPro.ProOperacjaZleceniaPoprzedzajaca>` | podlista | Operacje następujące | Operacje następujące dla operacji zlecenia. |
| OperacjePoprzedzajace | `LpSubTable<Soneta.ProdukcjaPro.ProOperacjaZleceniaPoprzedzajaca>` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis operacji zlecenia. |
| Przygotowanie | `bool` | tylko-odczyt |  | Operacja zlecenia w przygotowaniu. |
| RozliczeniaMaterialow | `SubTable<Soneta.ProdukcjaPro.ProRozliczenieMaterialu>` | podlista |  |  |
| RozliczeniaOdpadow | `SubTable<Soneta.ProdukcjaPro.ProRozliczenieOdpadu>` | podlista |  |  |
| RozliczeniaWyrobow | `SubTable<Soneta.ProdukcjaPro.ProRozliczenieWyrobu>` | podlista |  |  |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia operacji zlecenia. |
| Rozpoczete | `bool` | tylko-odczyt | Rozpoczęta | Operacja zlecenia rozpoczęta. |
| SposobWyceny | `Soneta.ProdukcjaPro.ProSposobWyceny` (enum) | bazodanowe | Sposób wyceny | Sposób wyceny operacji zlecenia. |
| Stan | `Soneta.ProdukcjaPro.ProStanOperacjiZlecenia` (enum) | bazodanowe |  | Stan operacji zlecenia. |
| TowarMeldowany | `Soneta.ProdukcjaPro.IProTowarMeldowany` |  | Towar meldowany | Towar meldowany dla operacji zlecenia. |
| TowaryMeldowane | `SubTable<Soneta.ProdukcjaPro.ProTowarMeldowanyOperacjiZlecenia>` | podlista |  |  |
| Uslugi | `LpSubTable<Soneta.ProdukcjaPro.ProUslugaOperacjiZlecenia>` | podlista |  |  |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | tylko-odczyt | Wydział | Wydział operacji zlecenia wskazany na zleceniu produkcyjnym. |
| Wyroby | `LpSubTable<Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia>` | podlista |  |  |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia operacji zlecenia. |
| Zakonczone | `bool` | tylko-odczyt | Zakończona | Operacja zlecenia zakończona. |
| Zasoby | `LpSubTable<Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia>` | podlista |  |  |
| Zlecenie | `Soneta.ProdukcjaPro.ProZlecenie` | bazodanowe, guided-parent |  | Zlecenie dla operacji zlecenia. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProSposobWyceny (`Soneta.ProdukcjaPro.ProSposobWyceny`)
- `None` = 0
- `Ilosc` = 1 — Wg ilości
- `Wspolczynnik` = 2 — Wg współczynnika
- `IloscWspolczynnik` = 4 — Wg ilości i współczynnika
- `MasaNetto` = 8 — Wg masy netto
- `MasaBrutto` = 16 — Wg masy brutto
- `CenaStala` = 32 — Wg ceny stałej
- `CenaReczna` = 64 — Wg ceny podanej ręcznie
- `All` = 127 — Wszystkie

### ProStanOperacjiZlecenia (`Soneta.ProdukcjaPro.ProStanOperacjiZlecenia`)
- `None` = 0
- `Przygotowanie` = 1
- `DoRealizacji` = 2 — Do realizacji
- `Rozpoczeta` = 4 — Rozpoczęta
- `Zakonczona` = 8 — Zakończona
- `All` = 15 — Wszystkie
