# Pola i właściwości klasy biznesowej: `Soneta.Kalend.WniosekPracyZdalnej`
Nazwa tabeli: `WnioskiPracZdal`
Tytuł: Wnioski o pracę zdalną
Opis: Wniosek pracownika o pracę zdalną. Przechowuje okres wnioskowanej pracy zdalnej, stan akceptacji, kierownika zatwierdzającego, datę decyzji, lokalizację oraz powiązanie z definicją rodzaju pracy zdalnej.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IDokumentAktualizacjiKalendarza`

- pola bazodanowe (zapisywalne): 5
- pola kalkulowane (zapisywalne): 1
- pola tylko-odczyt: 4
- podlisty: 4
- subrowy: 0
- razem: 14

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DataDecyzji | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaRodzajuPracyZdalnej` | bazodanowe, tylko-odczyt |  |  |
| DniKalendarzaHistorie | `SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` | podlista |  |  |
| DniPracyHistorie | `SubTable<Soneta.Kalend.DzienPracyHistoria>` | podlista |  |  |
| IlośćDni | `int` |  |  |  |
| Kierownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Lokalizacja | `Soneta.Kadry.LokalizacjaPracyZdalnej` | bazodanowe |  |  |
| Okres | `FromTo` | bazodanowe, podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| PracHistoria | `Soneta.Kadry.PracHistoria` | tylko-odczyt |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| SearchKey | `string` | tylko-odczyt |  |  |
| Stan | `Soneta.Kalend.StanyWnioskuPracyZdalnej` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanyWnioskuPracyZdalnej (`Soneta.Kalend.StanyWnioskuPracyZdalnej`)
- `Wprowadzany` = 1
- `Oczekujący` = 2
- `Zaakceptowany` = 3
- `Odrzucony` = 4
- `Anulowany` = 5
