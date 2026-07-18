# Pola i właściwości klasy biznesowej: `Soneta.Handel.Paczka`
Nazwa tabeli: `Paczki`
Opis: Paczka kurierska powiązana z dokumentem handlowym i przesyłką spedytora. Zawiera wymiary, masę, typ paczki oraz odniesienie do paczki wzorcowej.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument handlowy |  |
| IdPaczki | `System.Guid` | bazodanowe |  |  |
| Masa | `Soneta.Towary.Quantity` | bazodanowe | Masa |  |
| Niestandardowa | `bool` | bazodanowe | Niestandardowa |  |
| Opis | `string` | bazodanowe | Opis |  |
| PaczkaWzorcowa | `Soneta.Handel.PaczkaWzorcowa` | bazodanowe | Paczka |  |
| PrzesylkaSpedytor | `Soneta.Handel.PrzesylkaSpedyt` | bazodanowe | Przesyłka kurierska |  |
| Typ | `Soneta.Handel.RodzajPaczki` (enum) | bazodanowe | Typ |  |
| Uwagi | `string` | bazodanowe | Opis |  |
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
