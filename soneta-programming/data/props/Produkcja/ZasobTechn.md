# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ZasobTechn`
Nazwa tabeli: `ZasobyTechn`
Tytuł: Zasoby wzorcowe lub rzeczywiste przypisane do obiektów produkcyjnych
Opis: Przypisanie zasobu produkcyjnego (wzorcowego lub rzeczywistego) do technologii lub operacji. Określa typ zasobu, wymaganą ilość oraz powiązanie z zasobem wzorcowym, co pozwala definiować wymagania sprzętowe i osobowe dla poszczególnych etapów procesu produkcyjnego.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` |  |  | Określa zablokowanie rekordu. Zablokowane rekordy nie będą wyświetlane na listach wyboru. |
| Host | `Soneta.Produkcja.IZasobTechHost` | bazodanowe, iface-ref |  |  |
| Ilosc | `int` | bazodanowe | Ilość |  |
| ProdZasob | `Soneta.Produkcja.IProdZasob` | bazodanowe, iface-ref |  |  |
| Technologia | `Soneta.Produkcja.Technologia` | bazodanowe |  |  |
| Typ | `Soneta.Produkcja.TypZasobuTechn` | bazodanowe, enum |  |  |
| ZasobTechnWzorcowy | `Soneta.Produkcja.ZasobTechn` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IZasobTechHost` | `Operacja`, `Technologia` |
| ProdZasob | `IProdZasob` | `ProdOsoba`, `ProdOsobaWzorcowa`, `ProdZasob`, `ProdZasobWzorcowy` |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypZasobuTechn (`Soneta.Produkcja.TypZasobuTechn`)
- `None` = 0
- `Wzorcowy` = 1 — Zasob wzorcowy
- `Rzeczywisty` = 2 — Zasob rzeczywisty
- `OsobaWzorcowa` = 3 — Osoba wzorcowa
- `OsobaRzeczywista` = 4 — Osoba produkcyjna
