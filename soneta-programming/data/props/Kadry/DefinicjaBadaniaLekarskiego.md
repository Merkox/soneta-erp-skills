# Pola i właściwości klasy biznesowej: `Soneta.Kadry.DefinicjaBadaniaLekarskiego`
Nazwa tabeli: `DefBadanLek`
Tytuł: Definicje badań lekarskich
Opis: Definicja typu badania lekarskiego (wstępne, okresowe, kontrolne). Określa cykliczność badań, termin kolejnego badania, powiązanie z następną definicją badania oraz sposób wyliczania terminu (od daty badania lub od daty ważności).
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `IManagedRowDefinion`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Cykliczne | `bool` | bazodanowe |  |  |
| Kreatory | `SubTable<Soneta.Core.ManagedRowCreator>` | podlista |  |  |
| NastepneDefinicja | `Soneta.Kadry.DefinicjaBadaniaLekarskiego` | bazodanowe |  |  |
| NastepneTermin | `int` | bazodanowe |  |  |
| NastepneTerminOd | `Soneta.Kadry.SposóbWyliczaniaTerminu` (enum) | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| TylkoPosrednio | `bool` | bazodanowe | Utwórz tylko pośrednio |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### SposóbWyliczaniaTerminu (`Soneta.Kadry.SposóbWyliczaniaTerminu`)
- `OdTerminu` = 0 — Od terminu
- `OdDatyWykonania` = 1
