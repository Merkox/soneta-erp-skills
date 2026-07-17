# Pola i właściwości klasy biznesowej: `Soneta.Kadry.BadanieLekarskie`
Nazwa tabeli: `BadaniaLekarskie`
Tytuł: Badania lekarskie
Opis: Badanie lekarskie pracownika (wstępne, okresowe, kontrolne). Rejestruje termin skierowania, datę wykonania, datę ważności, wynik dotyczący pracy w okularach, kwotę i datę dofinansowania okularów korekcyjnych.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IManagedRowInfoHost`

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe | Data wykonania |  |
| DataDofinansowania | `Soneta.Types.Date` | bazodanowe | Data dofinansowania |  |
| Definicja | `Soneta.Kadry.DefinicjaBadaniaLekarskiego` | bazodanowe |  |  |
| Informacja | `string` |  |  |  |
| KwotaDofinansowania | `decimal` | bazodanowe | Kwota dofinansowania |  |
| ManagedState | `Soneta.Core.ManagedRowStates` | enum |  |  |
| Następne | `Soneta.Kadry.BadanieLekarskie` |  |  |  |
| NastępneDefinicja | `Soneta.Kadry.DefinicjaBadaniaLekarskiego` |  |  |  |
| NastępneTermin | `Soneta.Types.Date` |  | Termin następnego badania |  |
| Nazwa | `string` |  |  |  |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  |  |
| PracaWOkularach | `bool` | bazodanowe |  |  |
| Pracownik | `Soneta.Kadry.Pracownik` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  |  |
| WazneDo | `Soneta.Types.Date` | bazodanowe | Ważne do |  |
| Wykonane | `bool` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ManagedRowStates (`Soneta.Core.ManagedRowStates`)
- `Pending` = 1 — Wprowadzany
- `Active` = 2 — Przetwarzany
- `Finished` = 3 — Zakończony
- `Abandoned` = 4 — Porzucony
- `Removed` = 5 — Usunięty
