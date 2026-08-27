# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProZlecenie`
Nazwa tabeli: `ProZlecenia`
Tytuł: Zlecenia produkcyjne
Opis: Zlecenia produkcyjne stanowiące główny dokument uruchamiający produkcję wyrobu. Zawierają harmonogram operacji, zapotrzebowanie materiałowe, przypisane zasoby i planowane terminy realizacji generowane na podstawie technologii.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IElementSlownika`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Czas | `TimeSec` | bazodanowe |  | Czas zlecenia. |
| CzasRozpoczecia | `TimeSec` |  | Czas rozpoczęcia | Czas rozpoczęcia zlecenia. |
| CzasUtworzenia | `TimeSec` | bazodanowe | Czas utworzenia | Czas utworzenia zlecenia. |
| CzasZakonczenia | `TimeSec` |  | Czas zakończenia | Czas zakończenia zlecenia. |
| DataRozpoczecia | `Date` |  | Data rozpoczęcia | Data rozpoczęcia zlecenia. |
| DataUtworzenia | `Date` | bazodanowe | Data utworzenia | Data utworzenia zlecenia. |
| DataZakonczenia | `Date` |  | Data zakończenia | Data zakończenia zlecenia. |
| DoRealizacji | `bool` | tylko-odczyt | Do realizacji | Zlecenie do realizacji. |
| ElementyPodzielnika | `SubTable<Soneta.Core.ElementPodzielnika>` | podlista |  |  |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość zlecenia. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla zlecenia. |
| IloscZameldowanaProcent | `Percent` | tylko-odczyt | Ilość zameldowana [%] | Procentowy wskaźnik ilości zameldowanej dla zlecenia. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProZlecenie.KalkulacjaZlecenia` | tylko-odczyt |  | Kalkulacja zlecenia. |
| Miedzywydzialowosc | `bool` | bazodanowe | Międzywydziałowość | Międzywydziałowość zlecenia. |
| Nazwa | `string` | bazodanowe |  | Nazwa zlecenia. |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  | Numer zlecenia. |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Operacje | `LpSubTable<Soneta.ProdukcjaPro.ProOperacjaZlecenia>` | podlista |  |  |
| Operator | `App.Operator` | bazodanowe |  | Operator tworzący zlecenie. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis zlecenia. |
| PowiazaniaKontElementu | `SubTable` | podlista |  |  |
| Priorytet | `int` | bazodanowe |  | Priorytet zlecenia. |
| Provider | `Soneta.ProdukcjaPro.ProDokument` | tylko-odczyt |  |  |
| Przygotowanie | `bool` | tylko-odczyt |  | Zlecenie w przygotowaniu. |
| Rozpoczecie | `System.DateTime` | bazodanowe | Rozpoczęcie | Data i czas rozpoczęcia zlecenia. |
| Rozpoczete | `bool` | tylko-odczyt | Rozpoczęte | Zlecenie rozpoczęte. |
| Stan | `Soneta.ProdukcjaPro.ProStanZlecenia` (enum) | bazodanowe |  | Stan zlecenia. |
| Technologia | `Soneta.ProdukcjaPro.ProTechnologia` | bazodanowe |  | Technologia zlecenia. |
| TerminPlanowany | `Date` | bazodanowe | Termin planowany | Termin planowany zlecenia. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar zlecenia. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział zlecenia. |
| Zakonczenie | `System.DateTime` | bazodanowe | Zakończenie | Data i czas zakończenia zlecenia. |
| Zakonczone | `bool` | tylko-odczyt | Zakończone | Zlecenie zakończone. |
| ZleceniaNastepujace | `SubTable<Soneta.ProdukcjaPro.ProZlecenie>` | podlista | Zlecenia następujące | Zlecenia następujące dla zlecenia. |
| ZleceniaPoprzedzajace | `SubTable<Soneta.ProdukcjaPro.ProZlecenie>` | podlista | Zlecenia poprzedzające | Zlecenia poprzedzające dla zlecenia. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProStanZlecenia (`Soneta.ProdukcjaPro.ProStanZlecenia`)
- `None` = 0
- `Przygotowanie` = 1
- `DoRealizacji` = 2 — Do realizacji
- `Rozpoczete` = 4 — Rozpoczęte
- `Zakonczone` = 8 — Zakończone
- `All` = 15 — Wszystkie
