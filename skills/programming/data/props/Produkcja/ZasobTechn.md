# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ZasobTechn`
Nazwa tabeli: `ZasobyTechn`
Tytuł: Zasoby wzorcowe lub rzeczywiste przypisane do obiektów produkcyjnych
Opis: Przypisanie zasobu produkcyjnego (wzorcowego lub rzeczywistego) do technologii lub operacji. Określa typ zasobu, wymaganą ilość oraz powiązanie z zasobem wzorcowym, co pozwala definiować wymagania sprzętowe i osobowe dla poszczególnych etapów procesu produkcyjnego.
Tabela konfiguracyjna: Nie
Selektor: pole `Typ` (`Soneta.Produkcja.TypZasobuTechn`) — wiele typów w jednej tabeli, podtypów: 4

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | tylko-odczyt |  | Określa zablokowanie rekordu. Zablokowane rekordy nie będą wyświetlane na listach wyboru. |
| Host | `Soneta.Produkcja.IZasobTechHost` | bazodanowe, iface-ref |  |  |
| Ilosc | `int` | bazodanowe | Ilość |  |
| ProdZasob | `Soneta.Produkcja.IProdZasob` | bazodanowe, iface-ref |  |  |
| Technologia | `Soneta.Produkcja.Technologia` | bazodanowe |  |  |
| Typ | `Soneta.Produkcja.TypZasobuTechn` (enum) | bazodanowe, tylko-odczyt, selektor |  |  |
| ZasobTechnWzorcowy | `Soneta.Produkcja.ZasobTechn` | bazodanowe |  |  |

## Selektor — podtypy w jednej tabeli

Tabela przechowuje różne typy obiektów rozróżniane wartością selektora (pole `Typ`).
Każdy podtyp rejestruje `[assembly: BusinessRow(typeof(...), wartość)]`.

| Wartość | Nr | Klasa podtypu | Tytuł |
|---------|----|---------------|-------|
| `Wzorcowy` | 1 | `Soneta.Produkcja.ZasobTechnWzorcowy` |  |
| `Rzeczywisty` | 2 | `Soneta.Produkcja.ZasobTechnRzeczywisty` |  |
| `OsobaWzorcowa` | 3 | `Soneta.Produkcja.OsobaTechnWzorcowa` |  |
| `OsobaRzeczywista` | 4 | `Soneta.Produkcja.OsobaTechn` |  |

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
