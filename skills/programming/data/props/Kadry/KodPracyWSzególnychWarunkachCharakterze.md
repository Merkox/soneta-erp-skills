# Pola i właściwości klasy biznesowej: `Soneta.Kadry.KodPracyWSzególnychWarunkachCharakterze`
Nazwa tabeli: `KodyPracySzWaCha`
Tytuł: Kody pracy w szczególnych warunkach lub o szczególnym charakterze
Opis: Słownik kodów pracy w szczególnych warunkach lub o szczególnym charakterze zgodnych z ustawą o emeryturach pomostowych. Zawiera kategorię, kod i nazwę stanowiska uprawniającego do wcześniejszej emerytury.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| CalaNazwa | `string` | tylko-odczyt |  |  |
| Kategoria | `Soneta.Kadry.KategoriaPracyWSzególnychWarunkachCharakterze` (enum) | bazodanowe |  |  |
| Kod | `string` | bazodanowe |  |  |
| Nazwa | `string` | tylko-odczyt |  |  |
| Nazwa1 | `string` | bazodanowe |  |  |
| Nazwa2 | `string` | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### KategoriaPracyWSzególnychWarunkachCharakterze (`Soneta.Kadry.KategoriaPracyWSzególnychWarunkachCharakterze`)
- `PracaWSzególnychWarunkach` = 1 — Kod pracy w szczególnych warunkach
- `PracaOSzególnymCharakterze` = 2 — Kod pracy o szczególnym charakterze
