# Pola i właściwości klasy biznesowej: `Soneta.Place.ListaPlac`
Nazwa tabeli: `ListyPlac`
Tytuł: Listy płac
Opis: Dokument listy płac za określony okres rozliczeniowy. Grupuje wypłaty pracowników w ramach jednostki organizacyjnej, z ustaloną datą wypłaty, okresem naliczania i miesiącem deklaracji ZUS.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentKsiegowalny`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Bufor | `bool` |  |  |  |
| BuforOpisuAnalitycznego | `bool` | bazodanowe |  | Bufor opisu analitycznego |
| Data | `Date` | bazodanowe |  | Data naliczania listy płac |
| DataWyplaty | `Date` | bazodanowe |  | Data przekazania środków do dyspozycji pracownika. Na jej podstawie jest wyliczany mies,rok |
| Definicja | `Soneta.Place.DefinicjaListyPlac` | bazodanowe |  |  |
| DeklaracjeZa | `YearMonth` | tylko-odczyt |  |  |
| DokumentyEwidencji | `SubTable<Soneta.Core.DokEwidencji>` | podlista |  |  |
| Ewidencja | `Soneta.Core.DokEwidencji` | tylko-odczyt |  |  |
| Księgowanie | `Soneta.Place.KsięgowanieListyWorker` | tylko-odczyt |  |  |
| MiesWstecz | `int` | bazodanowe |  |  |
| MiesiacZUS | `YearMonth` |  | Miesiąc ZUS | Miesiąc w ktorym zostaną rozliczone składki ZUS |
| MiesiacZUSDzien | `Date` | bazodanowe, tylko-odczyt | Miesiąc deklaracji ZUS | Miesiąc w którym zostaną rozliczone składki ZUS |
| MiesiącDeklaracji | `YearMonth` | tylko-odczyt |  |  |
| Naliczanie | `Soneta.Place.TypNaliczenia` (enum) | bazodanowe |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| NumerProceduryISO | `string` | bazodanowe, tylko-odczyt |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  | Okres za jaki mają być naliczane wchodzące na wybraną listę wypłaty |
| OpisListyPlac | `string` | bazodanowe |  |  |
| PozycjeEwidencji | `SubTable<Soneta.Core.PozycjaEwidencjiZbiorczej>` | podlista |  |  |
| PublikacjaWPulpitach | `bool` | bazodanowe |  |  |
| Seria | `string` | bazodanowe |  |  |
| TerminPłatnościSkładek | `Date` | tylko-odczyt |  |  |
| Wydzial | `Soneta.Kadry.Wydzial` | bazodanowe | Jednostka organizacyjna |  |
| Wyplaty | `SubTable<Soneta.Place.Wyplata>` | podlista |  |  |
| Zatwierdzona | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypNaliczenia (`Soneta.Place.TypNaliczenia`)
- `PłatnaZGóry` = 1 — Płatna z góry
- `PłatnaZDołu` = 2
