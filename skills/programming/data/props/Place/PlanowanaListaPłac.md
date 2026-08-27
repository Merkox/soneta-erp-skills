# Pola i właściwości klasy biznesowej: `Soneta.Place.PlanowanaListaPłac`
Nazwa tabeli: `PlanListyPlac`
Tytuł: Planowane listy płac
Opis: Dokument planowanej listy płac służący do naliczania rezerw na wynagrodzenia (np. rezerwy urlopowe). Grupuje planowane wypłaty za określony okres w ramach jednostki organizacyjnej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` |  |  |  |
| Data | `Date` | bazodanowe |  | Data naliczania listy |
| DataWyplaty | `Date` | bazodanowe | Data wypłaty | Data przekazania środków do dyspozycji pracownika. Na jej podstawie jest wyliczany mies,rok |
| Definicja | `Soneta.Place.DefinicjaPlanowanejListyPłac` | bazodanowe |  |  |
| DefinicjaListyPlac | `Soneta.Place.DefinicjaListyPlac` | bazodanowe |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Księgowanie | `Soneta.Place.PlanowanaListaPłac.KsięgowanieListyWorker` | tylko-odczyt |  |  |
| MiesWstecz | `int` | bazodanowe | Miesięcy wstecz |  |
| MiesiacZUSDzien | `Date` | bazodanowe, tylko-odczyt | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| MiesiącDeklaracji | `YearMonth` | tylko-odczyt |  |  |
| MiesiącZUS | `YearMonth` |  | Miesiąc ZUS | Miesiąc w ktorym zostaną rozliczone składki ZUS |
| Naliczanie | `Soneta.Place.TypNaliczenia` (enum) | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  | Okres za jaki mają być naliczane wchodzące na wybraną listę wypłaty |
| PozycjeEwidencji | `SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` | podlista |  |  |
| Seria | `string` | bazodanowe |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wypłaty | `LpSubTable<Soneta.Place.PlanowanaWypłata>` | podlista |  |  |
| Zatwierdzona | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypNaliczenia (`Soneta.Place.TypNaliczenia`)
- `PłatnaZGóry` = 1 — Płatna z góry
- `PłatnaZDołu` = 2
