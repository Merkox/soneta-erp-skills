# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProTechnologia`
Nazwa tabeli: `ProTechnologie`
Tytuł: Technologie produkcyjne
Opis: Kartoteka technologii produkcyjnych opisujących receptury wytwarzania wyrobów. Zawiera marszruty operacji, zestawienia materiałowe (BOM), normy czasowe i parametry jakościowe stanowiące podstawę generowania zleceń produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Archiwum | `bool` | tylko-odczyt |  | Technologia w archiwum. |
| Czas | `TimeSec` | bazodanowe |  | Czas technologii. |
| CzasUtworzenia | `TimeSec` | bazodanowe | Czas utworzenia | Czas utworzenia technologii. |
| DataDo | `Date` | bazodanowe | Data do | Data obowiązywania do technologii. |
| DataOd | `Date` | bazodanowe | Data od | Data obowiązywania od technologii. |
| DataUtworzenia | `Date` | bazodanowe | Data utworzenia | Data utworzenia technologii. |
| Domyslna | `bool` | bazodanowe | Domyślna | Technologia domyślna dla wskazanego towaru. |
| Ilosc | `Amount` | bazodanowe | Ilość | Ilość technologii. |
| IloscMinimalna | `double` | bazodanowe | Ilość minimalna | Ilość minimalna technologii. |
| IloscPrzeliczona | `Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla technologii. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProTechnologia.KalkulacjaTechnologii` | tylko-odczyt |  | Kalkulacja technologii. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność technologii. |
| MaterialyOperacjiTechnologii | `SubTable<Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiTechnologii>` | podlista |  |  |
| MaterialyOperacjiZlecenia | `SubTable<Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiZlecenia>` | podlista |  |  |
| Miedzywydzialowosc | `bool` | bazodanowe | Międzywydziałowość | Międzywydziałowość technologii. |
| Nazwa | `string` | bazodanowe |  | Nazwa technologii. |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  | Numer technologii. |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Operacje | `LpSubTable<Soneta.ProdukcjaPro.ProOperacjaTechnologii>` | podlista |  |  |
| Operator | `App.Operator` | bazodanowe |  | Operator tworzący technologię. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis technologii. |
| PozycjaGlowna | `Soneta.ProdukcjaPro.IProPozycjaGlowna` |  | Pozycja główna | Pozycja główna technologii. |
| PozycjeGlowne | `SubTable<Soneta.ProdukcjaPro.ProPozycjaGlownaTechnologii>` | podlista |  |  |
| Provider | `Soneta.ProdukcjaPro.ProDokument` | tylko-odczyt |  |  |
| Przygotowanie | `bool` | tylko-odczyt |  | Technologia w przygotowaniu. |
| Stan | `Soneta.ProdukcjaPro.ProStanTechnologii` (enum) | bazodanowe |  | Stan technologii. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar technologii. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział technologii. |
| Zatwierdzona | `bool` | tylko-odczyt |  | Technologia zatwierdzona. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProStanTechnologii (`Soneta.ProdukcjaPro.ProStanTechnologii`)
- `None` = 0
- `Przygotowanie` = 1
- `Zatwierdzona` = 2
- `Archiwum` = 4
- `All` = 7 — Wszystkie
