# Pola i właściwości klasy biznesowej: `Soneta.Kalend.RozliczenieCzasuPracy`
Nazwa tabeli: `RozlCzasPracy`
Tytuł: Rozliczenia czasu pracy
Opis: Dokument rozliczenia czasu pracy pracownika (wniosek, zlecenie lub rozliczenie nadgodzin). Przechowuje stan dokumentu, datę, numer, serię oraz opis, i służy jako dokument aktualizacji kalendarza.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IManagedRowInfoHost`, `IDokument`, `IDokumentAktualizacjiKalendarza`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Date` | bazodanowe |  |  |
| DataDecyzji | `Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaRozliczeniaCzasuPracy` | bazodanowe, tylko-odczyt |  |  |
| DniKalendarzaHistorie | `SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` | podlista |  |  |
| DniPracyHistorie | `SubTable<Soneta.Kalend.DzienPracyHistoria>` | podlista |  |  |
| Elementy | `LpSubTable<Soneta.Kalend.ElementRozliczeniaCzasuPracy>` | podlista |  |  |
| ManagedState | `Soneta.Core.ManagedRowStates` (enum) | tylko-odczyt |  |  |
| Numer | `Soneta.Core.NumerDokumentu` (subrow) | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe, tylko-odczyt | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Key` | podlista |  |  |
| Numer.WgSymboluDokumentu | `Key` | podlista |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Seria | `string` | bazodanowe |  |  |
| Stan | `Soneta.Kalend.StanyRozliczeniaCzasuPracy` (enum) | bazodanowe |  |  |
| ZlecenieCzas | `Time` |  |  |  |
| ZlecenieData | `Date` |  |  |  |
| ZlecenieOdGodziny | `Time` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ManagedRowStates (`Soneta.Core.ManagedRowStates`)
- `Pending` = 1 — Wprowadzany
- `Active` = 2 — Przetwarzany
- `Finished` = 3 — Zakończony
- `Abandoned` = 4 — Porzucony
- `Removed` = 5 — Usunięty

### StanyRozliczeniaCzasuPracy (`Soneta.Kalend.StanyRozliczeniaCzasuPracy`)
- `Oczekujący` = 1
- `Anulowany` = 2
- `Zaakceptowany` = 3
- `Odrzucony` = 4
