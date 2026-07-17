# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProOperacjaZlecenia`
Nazwa tabeli: `ProOperacjeZlec`
Tytuł: Operacje zleceń
Opis: Element szczegółowy zlecenia produkcyjnego (ProZlecenie). Reprezentuje pojedynczą operację do wykonania w ramach zlecenia z przypisaną definicją operacji, definicją meldunku, terminami rozpoczęcia i zakończenia, sposobem wyceny oraz stanem realizacji i ilością zameldowaną.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `Zlecenie` → `ProZlecenie`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 25

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas operacji zlecenia. |
| CzasMiedzyoperacyjny | `Soneta.Types.TimeSec` | bazodanowe | Czas międzyoperacyjny | Czas międzyoperacyjny operacji zlecenia. |
| CzasRozpoczecia | `Soneta.Types.TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia operacji zlecenia. |
| CzasZakonczenia | `Soneta.Types.TimeSec` |  | Czas zakończenia | Czas zakończenia operacji zlecenia. |
| DataRozpoczecia | `Soneta.Types.Date` |  | Data rozpoczęcia | Data rozpoczęcia operacji zlecenia. |
| DataZakonczenia | `Soneta.Types.Date` |  | Data zakończenia | Data zakończenia operacji zlecenia. |
| DefinicjaMeldunku | `Soneta.ProdukcjaPro.ProDefinicjaMeldunku` | bazodanowe | Definicja meldunku | Definicja meldunku dla operacji zlecenia. |
| DefinicjaOperacji | `Soneta.ProdukcjaPro.ProDefinicjaOperacji` | bazodanowe | Definicja operacji | Definicja operacji dla operacji zlecenia. |
| DoRealizacji | `bool` |  | Do realizacji | Operacja zlecenia do realizacji. |
| IloscDoZameldowania | `Soneta.Types.Amount` | bazodanowe | Ilość do zameldowania | Ilość pozostała do zameldowania operacji zlecenia. |
| IloscZameldowana | `Soneta.Types.Amount` | bazodanowe | Ilość zameldowana | Ilość zameldowana operacji zlecenia. |
| IloscZameldowanaProcent | `Soneta.Types.Percent` |  | Ilość zameldowana [%] | Procentowy wskaźnik ilości zameldowanej dla operacji zlecenia. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProKalkulacjaOperacjiZlecenia` |  |  | Kalkulacja operacji zlecenia. |
| Kalkulacje | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProKalkulacjaOperacjiZlecenia>` |  |  |  |
| Lp | `int` | bazodanowe |  | Liczba porządkowa operacji zlecenia. |
| Materialy | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProMaterialOperacjiZlecenia>` |  |  |  |
| Meldunki | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProMeldunek>` |  |  |  |
| Odpady | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProOdpadOperacjiZlecenia>` |  |  |  |
| OperacjaTechnologii | `Soneta.ProdukcjaPro.ProOperacjaTechnologii` | bazodanowe | Operacja technologii | Operacja technologii dla operacji zlecenia. |
| OperacjeNastepujace | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProOperacjaZleceniaPoprzedzajaca>` |  | Operacje następujące | Operacje następujące dla operacji zlecenia. |
| OperacjePoprzedzajace | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProOperacjaZleceniaPoprzedzajaca>` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis operacji zlecenia. |
| Przygotowanie | `bool` |  |  | Operacja zlecenia w przygotowaniu. |
| RozliczeniaMaterialow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProRozliczenieMaterialu>` |  |  |  |
| RozliczeniaOdpadow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProRozliczenieOdpadu>` |  |  |  |
| RozliczeniaWyrobow | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProRozliczenieWyrobu>` |  |  |  |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia operacji zlecenia. |
| Rozpoczete | `bool` |  | Rozpoczęta | Operacja zlecenia rozpoczęta. |
| SposobWyceny | `Soneta.ProdukcjaPro.ProSposobWyceny` | bazodanowe, enum | Sposób wyceny | Sposób wyceny operacji zlecenia. |
| Stan | `Soneta.ProdukcjaPro.ProStanOperacjiZlecenia` | bazodanowe, enum |  | Stan operacji zlecenia. |
| TowarMeldowany | `Soneta.ProdukcjaPro.IProTowarMeldowany` |  | Towar meldowany | Towar meldowany dla operacji zlecenia. |
| TowaryMeldowane | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProTowarMeldowanyOperacjiZlecenia>` |  |  |  |
| Uslugi | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProUslugaOperacjiZlecenia>` |  |  |  |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` |  | Wydział | Wydział operacji zlecenia wskazany na zleceniu produkcyjnym. |
| Wyroby | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProWyrobOperacjiZlecenia>` |  |  |  |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia operacji zlecenia. |
| Zakonczone | `bool` |  | Zakończona | Operacja zlecenia zakończona. |
| Zasoby | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProZasobOperacjiZlecenia>` |  |  |  |
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
