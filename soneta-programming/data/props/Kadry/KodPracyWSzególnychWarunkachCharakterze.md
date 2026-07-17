# Pola i właściwości klasy biznesowej: `Soneta.Kadry.KodPracyWSzególnychWarunkachCharakterze`
Nazwa tabeli: `KodyPracySzWaCha`
Tytuł: Kody pracy w szczególnych warunkach lub o szczególnym charakterze
Opis: Słownik kodów pracy w szczególnych warunkach lub o szczególnym charakterze zgodnych z ustawą o emeryturach pomostowych. Zawiera kategorię, kod i nazwę stanowiska uprawniającego do wcześniejszej emerytury.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| CalaNazwa | `string` |  |  |  |
| Kategoria | `Soneta.Kadry.KategoriaPracyWSzególnychWarunkachCharakterze` | bazodanowe, enum |  |  |
| Kod | `string` | bazodanowe |  |  |
| Nazwa | `string` |  |  |  |
| Nazwa1 | `string` | bazodanowe |  |  |
| Nazwa2 | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategoriaPracyWSzególnychWarunkachCharakterze (`Soneta.Kadry.KategoriaPracyWSzególnychWarunkachCharakterze`)
- `PracaWSzególnychWarunkach` = 1 — Kod pracy w szczególnych warunkach
- `PracaOSzególnymCharakterze` = 2 — Kod pracy o szczególnym charakterze
