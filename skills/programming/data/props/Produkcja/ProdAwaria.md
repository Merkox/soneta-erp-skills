# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdAwaria`
Nazwa tabeli: `ProdAwarie`
Tytuł: Awarie produkcyjne
Opis: Rejestr zgłoszeń awaryjnych na zasobach produkcyjnych. Przechowuje kod i opis awarii, zasób na którym wystąpiła, powiązaną operację, priorytet (niski/normalny/wysoki), stan obsługi (nowa/przekazana/zakończona), datę zgłoszenia oraz osobę i operatora zgłaszającego. Umożliwia śledzenie i rozliczanie przestojów produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataZgloszenia | `System.DateTime` | bazodanowe | Data zgłoszenia | Data zgłoszenia awarii. |
| IdentyfikatorZadania | `System.Guid` | bazodanowe | Identyfikator zadania | Identyfikator zadania powiązanego z awarią. |
| Kod | `string` | bazodanowe |  | Kod, skrócona nazwa zgłoszonej awarii. |
| NumerZadania | `string` | tylko-odczyt | Numer zlecenia | Numer zlecenia serwisowego. |
| Operacja | `Soneta.Produkcja.Operacja` | bazodanowe |  | Operacja na której wystąpiła awaria. |
| Operator | `App.Operator` | bazodanowe |  | Określa operatora, który zgłosił awarię. |
| Opis | `MemoText` | bazodanowe, podlista |  | Opis awarii. |
| Priorytet | `Soneta.Produkcja.PriorytetAwarii` (enum) | bazodanowe |  | Określa piorytet zgłoszenia (niski, normalny, wysoki). |
| ProdOsoba | `Soneta.Produkcja.ProdOsoba` | bazodanowe | Osoba | Określa osobę rzeczywsitą, która zgłosiła awarię. |
| ProdZasob | `Soneta.Produkcja.ProdZasob` | bazodanowe | Zasób | Zasób rzeczywisty na którym wystąpiła awaria. |
| Stan | `Soneta.Produkcja.StanAwarii` (enum) | bazodanowe |  | Określa stan awarii (nowa, przekazana, zakończona). |
| StanZadania | `string` | tylko-odczyt | Stan zlecenia | Stan zlecenia serwisowego. |
| Zglaszajacy | `string` | tylko-odczyt | Zgłaszający | Określa pracownika, który zgłosił awarię. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### PriorytetAwarii (`Soneta.Produkcja.PriorytetAwarii`)
- `Niski` = 3
- `Normalny` = 5
- `Wysoki` = 7

### StanAwarii (`Soneta.Produkcja.StanAwarii`)
- `Nowa` = 0
- `Przekazana` = 1
- `Zakonczona` = 2 — Zakończona
