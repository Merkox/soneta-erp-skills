# Pola i właściwości klasy biznesowej: `Soneta.Place.ListaPlac`
Nazwa tabeli: `ListyPlac`
Tytuł: Listy płac
Opis: Dokument listy płac za określony okres rozliczeniowy. Grupuje wypłaty pracowników w ramach jednostki organizacyjnej, z ustaloną datą wypłaty, okresem naliczania i miesiącem deklaracji ZUS.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`

- pola bazodanowe: 17
- pola kalkulowane (z klas biznesowych): 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` |  |  |  |
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Bufor opisu analitycznego |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data naliczania listy płac |
| DataWyplaty | `Soneta.Types.Date` | bazodanowe |  | Data przekazania środków do dyspozycji pracownika. Na jej podstawie jest wyliczany mies,rok |
| Definicja | `Soneta.Place.DefinicjaListyPlac` | bazodanowe |  |  |
| DeklaracjeZa | `Soneta.Types.YearMonth` |  |  |  |
| DokumentyEwidencji | `Soneta.Business.SubTable<Soneta.Core.DokEwidencji>` |  |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` |  |  |  |
| Księgowanie | `Soneta.Place.KsięgowanieListyWorker` |  |  |  |
| MiesWstecz | `int` | bazodanowe |  |  |
| MiesiacZUS | `Soneta.Types.YearMonth` |  | Miesiąc ZUS | Miesiąc w ktorym zostaną rozliczone składki ZUS |
| MiesiacZUSDzien | `Soneta.Types.Date` | bazodanowe | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| MiesiącDeklaracji | `Soneta.Types.YearMonth` |  |  |  |
| Naliczanie | `Soneta.Place.TypNaliczenia` | bazodanowe, enum |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| NumerProceduryISO | `string` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  | Okres za jaki mają być naliczane wchodzące na wybraną listę wypłaty |
| OpisListyPlac | `string` | bazodanowe |  |  |
| PozycjeEwidencji | `Soneta.Business.SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` |  |  |  |
| PublikacjaWPulpitach | `bool` | bazodanowe |  |  |
| Seria | `string` | bazodanowe |  |  |
| TerminPłatnościSkładek | `Soneta.Types.Date` |  |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wyplaty | `Soneta.Business.SubTable<Soneta.Place.Wyplata>` |  |  |  |
| Zatwierdzona | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypNaliczenia (`Soneta.Place.TypNaliczenia`)
- `PłatnaZGóry` = 1 — Płatna z góry
- `PłatnaZDołu` = 2
