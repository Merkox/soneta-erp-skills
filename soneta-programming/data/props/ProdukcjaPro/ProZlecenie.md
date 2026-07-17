# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZlecenie`
Nazwa tabeli: `ProZlecenia`
Tytuł: Zlecenia produkcyjne
Opis: Zlecenia produkcyjne stanowiące główny dokument uruchamiający produkcję wyrobu. Zawierają harmonogram operacji, zapotrzebowanie materiałowe, przypisane zasoby i planowane terminy realizacji generowane na podstawie technologii.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 19

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas zlecenia. |
| CzasRozpoczecia | `Soneta.Types.TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia zlecenia. |
| CzasUtworzenia | `Soneta.Types.TimeSec` | bazodanowe | Czas utworzenia | Czas utworzenia zlecenia. |
| CzasZakonczenia | `Soneta.Types.TimeSec` |  | Czas zakończenia | Czas zakończenia zlecenia. |
| DataRozpoczecia | `Soneta.Types.Date` |  | Data rozpoczęcia | Data rozpoczęcia zlecenia. |
| DataUtworzenia | `Soneta.Types.Date` | bazodanowe | Data utworzenia | Data utworzenia zlecenia. |
| DataZakonczenia | `Soneta.Types.Date` |  | Data zakończenia | Data zakończenia zlecenia. |
| DoRealizacji | `bool` |  | Do realizacji | Zlecenie do realizacji. |
| ElementyPodzielnika | `Soneta.Business.SubTable<Soneta.Core.ElementPodzielnika>` |  |  |  |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość zlecenia. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla zlecenia. |
| IloscZameldowanaProcent | `Soneta.Types.Percent` |  | Ilość zameldowana [%] | Procentowy wskaźnik ilości zameldowanej dla zlecenia. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProZlecenie.KalkulacjaZlecenia` |  |  | Kalkulacja zlecenia. |
| Miedzywydzialowosc | `bool` | bazodanowe | Międzywydziałowość | Międzywydziałowość zlecenia. |
| Nazwa | `string` | bazodanowe |  | Nazwa zlecenia. |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  | Numer zlecenia. |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Operacje | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProOperacjaZlecenia>` |  |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator tworzący zlecenie. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis zlecenia. |
| PowiazaniaKontElementu | `Soneta.Business.SubTable` |  |  |  |
| Priorytet | `int` | bazodanowe |  | Priorytet zlecenia. |
| Provider | `Soneta.ProdukcjaPro.ProDokument` |  |  |  |
| Przygotowanie | `bool` |  |  | Zlecenie w przygotowaniu. |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia zlecenia. |
| Rozpoczete | `bool` |  | Rozpoczęte | Zlecenie rozpoczęte. |
| Stan | `Soneta.ProdukcjaPro.ProStanZlecenia` | bazodanowe, enum |  | Stan zlecenia. |
| Technologia | `Soneta.ProdukcjaPro.ProTechnologia` | bazodanowe |  | Technologia zlecenia. |
| TerminPlanowany | `Soneta.Types.Date` | bazodanowe | Termin planowany | Termin planowany zlecenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar zlecenia. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział zlecenia. |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia zlecenia. |
| Zakonczone | `bool` |  | Zakończone | Zlecenie zakończone. |
| ZleceniaNastepujace | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProZlecenie>` |  | Zlecenia następujące | Zlecenia następujące dla zlecenia. |
| ZleceniaPoprzedzajace | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProZlecenie>` |  | Zlecenia poprzedzające | Zlecenia poprzedzające dla zlecenia. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProStanZlecenia (`Soneta.ProdukcjaPro.ProStanZlecenia`)
- `None` = 0
- `Przygotowanie` = 1
- `DoRealizacji` = 2 — Do realizacji
- `Rozpoczete` = 4 — Rozpoczęte
- `Zakonczone` = 8 — Zakończone
- `All` = 15 — Wszystkie
