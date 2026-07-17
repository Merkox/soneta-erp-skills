# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WniosekPracyZdalnej`
Nazwa tabeli: `WnioskiPracZdal`
Tytuł: Wnioski o pracę zdalną
Opis: Wniosek pracownika o pracę zdalną. Przechowuje okres wnioskowanej pracy zdalnej, stan akceptacji, kierownika zatwierdzającego, datę decyzji, lokalizację oraz powiązanie z definicją rodzaju pracy zdalnej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentAktualizacjiKalendarza`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 5

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataDecyzji | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaRodzajuPracyZdalnej` | bazodanowe |  |  |
| DniKalendarzaHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` |  |  |  |
| DniPracyHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienPracyHistoria>` |  |  |  |
| IlośćDni | `int` |  |  |  |
| Kierownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Lokalizacja | `Soneta.Kadry.LokalizacjaPracyZdalnej` | bazodanowe |  |  |
| Okres | `Soneta.Types.FromTo` | bazodanowe |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` |  |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| SearchKey | `string` |  |  |  |
| Stan | `Soneta.Kalend.StanyWnioskuPracyZdalnej` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanyWnioskuPracyZdalnej (`Soneta.Kalend.StanyWnioskuPracyZdalnej`)
- `Wprowadzany` = 1
- `Oczekujący` = 2
- `Zaakceptowany` = 3
- `Odrzucony` = 4
- `Anulowany` = 5
