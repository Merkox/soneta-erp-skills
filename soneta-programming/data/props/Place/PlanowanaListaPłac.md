# Pola i właściwości klasy biznesowej: `Soneta.Place.PlanowanaListaPłac`
Nazwa tabeli: `PlanListyPlac`
Tytuł: Planowane listy płac
Opis: Dokument planowanej listy płac służący do naliczania rezerw na wynagrodzenia (np. rezerwy urlopowe). Grupuje planowane wypłaty za określony okres w ramach jednostki organizacyjnej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 12

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` |  |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data naliczania listy |
| DataWyplaty | `Soneta.Types.Date` | bazodanowe | Data wypłaty | Data przekazania środków do dyspozycji pracownika. Na jej podstawie jest wyliczany mies,rok |
| Definicja | `Soneta.Place.DefinicjaPlanowanejListyPłac` | bazodanowe |  |  |
| DefinicjaListyPlac | `Soneta.Place.DefinicjaListyPlac` | bazodanowe |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| Księgowanie | `Soneta.Place.PlanowanaListaPłac.KsięgowanieListyWorker` |  |  |  |
| MiesWstecz | `int` | bazodanowe | Miesięcy wstecz |  |
| MiesiacZUSDzien | `Soneta.Types.Date` | bazodanowe | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| MiesiącDeklaracji | `Soneta.Types.YearMonth` |  |  |  |
| MiesiącZUS | `Soneta.Types.YearMonth` |  | Miesiąc ZUS | Miesiąc w ktorym zostaną rozliczone składki ZUS |
| Naliczanie | `Soneta.Place.TypNaliczenia` | bazodanowe, enum |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Okres za jaki mają być naliczane wchodzące na wybraną listę wypłaty |
| PozycjeEwidencji | `Soneta.Business.SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` |  |  |  |
| Seria | `string` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wypłaty | `Soneta.Business.LpSubTable<Soneta.Place.PlanowanaWypłata>` |  |  |  |
| Zatwierdzona | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypNaliczenia (`Soneta.Place.TypNaliczenia`)
- `PłatnaZGóry` = 1 — Płatna z góry
- `PłatnaZDołu` = 2
