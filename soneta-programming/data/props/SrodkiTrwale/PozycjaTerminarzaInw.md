# Pola i właściwości klasy biznesowej: `Soneta.SrodkiTrwale.PozycjaTerminarzaInw`
Nazwa tabeli: `TerminarzInw`
Tytuł: Terminarz inwentarza
Opis: Pozycja terminarza inwentaryzacji środków trwałych. Definiuje planowaną datę i nazwę czynności inwentaryzacyjnej oraz rejestruje datę jej faktycznej realizacji, umożliwiając kontrolę harmonogramu spisu z natury.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataPlanowana | `Soneta.Types.Date` | bazodanowe |  | Planowana data realizacji |
| DataRealizacji | `Soneta.Types.Date` | bazodanowe |  | Data realizacji |
| Inwentarz | `Soneta.SrodkiTrwale.IInwentarz` | bazodanowe, iface-ref |  | Pozycja inwentarzu |
| Nazwa | `string` | bazodanowe |  | Nazwa pozycji terminarza |
| Opis | `string` | bazodanowe |  | Opis pozycji terminarza |
| StatusPozycji | `Soneta.SrodkiTrwale.StatusPozycjiTerminarza` | enum |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Inwentarz | `IInwentarz` | `SrodekTrwalyBase`, `Wyposazenie` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusPozycjiTerminarza (`Soneta.SrodkiTrwale.StatusPozycjiTerminarza`)
- `Brak` = 0
- `DoRealizacji` = 1
- `Zrealizowane` = 2
