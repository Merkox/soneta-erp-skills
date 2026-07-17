# Pola i właściwości klasy biznesowej: `Soneta.Kalend.RozliczenieCzasuPracy`
Nazwa tabeli: `RozlCzasPracy`
Tytuł: Rozliczenia czasu pracy
Opis: Dokument rozliczenia czasu pracy pracownika (wniosek, zlecenie lub rozliczenie nadgodzin). Przechowuje stan dokumentu, datę, numer, serię oraz opis, i służy jako dokument aktualizacji kalendarza.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IManagedRowInfoHost`, `IDokument`, `IDokumentAktualizacjiKalendarza`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| DataDecyzji | `Soneta.Types.Date` | bazodanowe |  |  |
| Definicja | `Soneta.Kalend.DefinicjaRozliczeniaCzasuPracy` | bazodanowe |  |  |
| DniKalendarzaHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienKalendarzaHistoria>` |  |  |  |
| DniPracyHistorie | `Soneta.Business.SubTable<Soneta.Kalend.DzienPracyHistoria>` |  |  |  |
| Elementy | `Soneta.Business.LpSubTable<Soneta.Kalend.ElementRozliczeniaCzasuPracy>` |  |  |  |
| ManagedState | `Soneta.Core.ManagedRowStates` | enum |  |  |
| Numer | `Soneta.Core.NumerDokumentu` | bazodanowe |  |  |
| Numer.Numer | `int` | bazodanowe |  |  |
| Numer.NumerPelny | `string` |  |  |  |
| Numer.Pelny | `string` | bazodanowe | Numer pełny |  |
| Numer.Symbol | `string` | bazodanowe |  |  |
| Numer.WgNumeruDokumentu | `Soneta.Business.Key` |  |  |  |
| Numer.WgSymboluDokumentu | `Soneta.Business.Key` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Seria | `string` | bazodanowe |  |  |
| Stan | `Soneta.Kalend.StanyRozliczeniaCzasuPracy` | bazodanowe, enum |  |  |
| ZlecenieCzas | `Soneta.Types.Time` |  |  |  |
| ZlecenieData | `Soneta.Types.Date` |  |  |  |
| ZlecenieOdGodziny | `Soneta.Types.Time` |  |  |  |

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
