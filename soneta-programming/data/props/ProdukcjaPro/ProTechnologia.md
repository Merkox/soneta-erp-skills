# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProTechnologia`
Nazwa tabeli: `ProTechnologie`
Tytuł: Technologie produkcyjne
Opis: Kartoteka technologii produkcyjnych opisujących receptury wytwarzania wyrobów. Zawiera marszruty operacji, zestawienia materiałowe (BOM), normy czasowe i parametry jakościowe stanowiące podstawę generowania zleceń produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 21
- pola kalkulowane (z klas biznesowych): 13

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Archiwum | `bool` |  |  | Technologia w archiwum. |
| Czas | `Soneta.Types.TimeSec` | bazodanowe |  | Czas technologii. |
| CzasUtworzenia | `Soneta.Types.TimeSec` | bazodanowe | Czas utworzenia | Czas utworzenia technologii. |
| DataDo | `Soneta.Types.Date` | bazodanowe | Data do | Data obowiązywania do technologii. |
| DataOd | `Soneta.Types.Date` | bazodanowe | Data od | Data obowiązywania od technologii. |
| DataUtworzenia | `Soneta.Types.Date` | bazodanowe | Data utworzenia | Data utworzenia technologii. |
| Domyslna | `bool` | bazodanowe | Domyślna | Technologia domyślna dla wskazanego towaru. |
| Ilosc | `Soneta.Types.Amount` | bazodanowe | Ilość | Ilość technologii. |
| IloscMinimalna | `double` | bazodanowe | Ilość minimalna | Ilość minimalna technologii. |
| IloscPrzeliczona | `Soneta.Types.Amount` | bazodanowe | Ilość przeliczona | Ilość przeliczona na podstawową jednostkę miary dla technologii. |
| Kalkulacja | `Soneta.ProdukcjaPro.ProTechnologia.KalkulacjaTechnologii` |  |  | Kalkulacja technologii. |
| Krotnosc | `double` | bazodanowe | Krotność | Krotność technologii. |
| MaterialyOperacjiTechnologii | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiTechnologii>` |  |  |  |
| MaterialyOperacjiZlecenia | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProTechnologiaMaterialuOperacjiZlecenia>` |  |  |  |
| Miedzywydzialowosc | `bool` | bazodanowe | Międzywydziałowość | Międzywydziałowość technologii. |
| Nazwa | `string` | bazodanowe |  | Nazwa technologii. |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  | Numer technologii. |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Operacje | `Soneta.Business.LpSubTable<Soneta.ProdukcjaPro.ProOperacjaTechnologii>` |  |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator tworzący technologię. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis technologii. |
| PozycjaGlowna | `Soneta.ProdukcjaPro.IProPozycjaGlowna` |  | Pozycja główna | Pozycja główna technologii. |
| PozycjeGlowne | `Soneta.Business.SubTable<Soneta.ProdukcjaPro.ProPozycjaGlownaTechnologii>` |  |  |  |
| Provider | `Soneta.ProdukcjaPro.ProDokument` |  |  |  |
| Przygotowanie | `bool` |  |  | Technologia w przygotowaniu. |
| Stan | `Soneta.ProdukcjaPro.ProStanTechnologii` | bazodanowe, enum |  | Stan technologii. |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Towar technologii. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział technologii. |
| Zatwierdzona | `bool` |  |  | Technologia zatwierdzona. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProStanTechnologii (`Soneta.ProdukcjaPro.ProStanTechnologii`)
- `None` = 0
- `Przygotowanie` = 1
- `Zatwierdzona` = 2
- `Archiwum` = 4
- `All` = 7 — Wszystkie
