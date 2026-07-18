# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BadanieLekarskie`
Nazwa tabeli: `BadaniaLekarskie`
Tytuł: Badania lekarskie
Opis: Badanie lekarskie pracownika (wstępne, okresowe, kontrolne). Rejestruje termin skierowania, datę wykonania, datę ważności, wynik dotyczący pracy w okularach, kwotę i datę dofinansowania okularów korekcyjnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IManagedRowInfoHost`

- pola bazodanowe (zapisywalne): 8
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 7
- podlisty: 1
- subrowy: 0
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe | Data wykonania |  |
| DataDofinansowania | `Date` | bazodanowe | Data dofinansowania |  |
| Definicja | `Soneta.Kadry.DefinicjaBadaniaLekarskiego` | bazodanowe |  |  |
| Informacja | `string` | tylko-odczyt |  |  |
| KwotaDofinansowania | `decimal` | bazodanowe | Kwota dofinansowania |  |
| ManagedState | `Soneta.Core.ManagedRowStates` (enum) | tylko-odczyt |  |  |
| Następne | `Soneta.Kadry.BadanieLekarskie` | tylko-odczyt |  |  |
| NastępneDefinicja | `Soneta.Kadry.DefinicjaBadaniaLekarskiego` | tylko-odczyt |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Opis | `MemoText` | bazodanowe, podlista |  |  |
| PracaWOkularach | `bool` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe, tylko-odczyt |  |  |
| Termin | `Date` | bazodanowe |  |  |
| WazneDo | `Date` | bazodanowe | Ważne do |  |
| Wykonane | `bool` | tylko-odczyt |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ManagedRowStates (`Soneta.Core.ManagedRowStates`)
- `Pending` = 1 — Wprowadzany
- `Active` = 2 — Przetwarzany
- `Finished` = 3 — Zakończony
- `Abandoned` = 4 — Porzucony
- `Removed` = 5 — Usunięty
