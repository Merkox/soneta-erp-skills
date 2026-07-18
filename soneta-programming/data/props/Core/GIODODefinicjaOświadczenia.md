# Pola i właściwości klasy biznesowej: `Soneta.Core.GIODODefinicjaOświadczenia`
Nazwa tabeli: `GIODODefOswiadcz`
Tytuł: Definicje oświadczeń
Opis: Definicja wzorca oświadczenia RODO (zgody na przetwarzanie danych). Określa nazwę, treść, rodzaj, symbol, numerację, cel przetwarzania, dostępność dla typów osób (pracownik, osoba kontaktowa, osoba fizyczna, uczestnik) oraz powiązanie z oświadczeniami wycofującymi.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IRightsSource`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe | Blokada | Definicja zablokowana |
| Cel | `Soneta.Core.GIODOCelPrzetwarzania` | bazodanowe |  |  |
| Domyslny | `bool` | bazodanowe |  |  |
| NeutralName | `string` | tylko-odczyt |  |  |
| Numeracja | `Soneta.Core.DefinicjaNumeracji` (subrow) | bazodanowe |  |  |
| Numeracja.PodczasEdycji | `bool` | bazodanowe |  |  |
| Numeracja.PodczasZapisu | `bool` |  |  |  |
| Numeracja.Separator | `string` | bazodanowe |  |  |
| Numeracja.Wzor | `string` | bazodanowe |  |  |
| OsobaFizyczna | `bool` | bazodanowe |  |  |
| OsobaKontakowa | `bool` | bazodanowe |  |  |
| Oswiadczenie | `string` | bazodanowe | Oświadczenie | Nazwa oświadczenia |
| Pracownik | `bool` | bazodanowe |  |  |
| Rodzaj | `Soneta.Core.RodzajeOświadczeńGIODO` (enum) | bazodanowe |  |  |
| Symbol | `string` | bazodanowe |  |  |
| Tresc | `MemoText` | bazodanowe, podlista | Oświadczenie | Treść oświadczenia |
| Uczestnik | `bool` | bazodanowe |  |  |
| ZgodyDoWycofania | `SubTable<Soneta.Core.GIODOWycofanieOświadczenia>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajeOświadczeńGIODO (`Soneta.Core.RodzajeOświadczeńGIODO`)
- `Oświadczenie` = 0 — Oświadczenie
- `UdzielenieZgody` = 1
- `WycofanieZgody` = 2
