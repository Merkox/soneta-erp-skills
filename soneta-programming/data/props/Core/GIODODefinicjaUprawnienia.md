# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODODefinicjaUprawnienia`
Nazwa tabeli: `GIODODefUprawn`
Tytuł: Definicje uprawnień
Opis: Definicja wzorca uprawnienia RODO do przetwarzania danych osobowych. Określa nazwę, treść, symbol, numerację, flagę blokady i domyślności oraz dostępność dla typów osób (pracownik, osoba kontaktowa).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

- pola bazodanowe: 11
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Definicja zablokowana |
| Domyslny | `bool` | bazodanowe |  |  |
| NeutralName | `string` |  |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| OsobaKontakowa | `bool` | bazodanowe |  |  |
| Pracownik | `bool` | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Uprawnienie | Treść uprawnienia |
| Uprawnienie | `string` | bazodanowe | Uprawnienie | Nazwa uprawnienia |
