# Pola i właściwości klasy biznesowej: `Soneta.Handel.PaczkaWzorcowa`
Nazwa tabeli: `PaczkiWzorcowe`
Opis: Wzorcowy szablon paczki kurierskiej powiązany z systemem zewnętrznym (spedytorem). Definiuje domyślne wymiary, masę i typ paczki do wielokrotnego użycia.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Domyslna | `bool` | bazodanowe | Domyślna |  |
| Masa | `Soneta.Towary.Quantity` | bazodanowe | Masa |  |
| Niestandardowa | `bool` | bazodanowe | Niestandardowa |  |
| Opis | `string` | bazodanowe | Opis |  |
| Symbol | `string` | bazodanowe | Symbol | Symbol paczki wzorcowej |
| SystemZewn | `Soneta.Core.SystemZewn` | bazodanowe | System zewnętrzny |  |
| Typ | `Soneta.Handel.RodzajPaczki` (enum) | bazodanowe | Typ |  |
| Wymiary | `Soneta.Handel.Wymiary` (subrow) | bazodanowe |  |  |
| Wymiary.Dlugosc | `Soneta.Towary.Quantity` | bazodanowe | Długość |  |
| Wymiary.Objetosc | `Soneta.Towary.Quantity` | bazodanowe | Objętość |  |
| Wymiary.Szerokosc | `Soneta.Towary.Quantity` | bazodanowe | Szerokość |  |
| Wymiary.Wysokosc | `Soneta.Towary.Quantity` | bazodanowe | Wysokość |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajPaczki (`Soneta.Handel.RodzajPaczki`)
- `Paczka` = 0 — Paczka
- `Koperta` = 1 — Koperta
- `Paleta` = 2 — Paleta
