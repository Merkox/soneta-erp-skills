# Pola i właściwości klasy biznesowej: `Soneta.ProdukcjaPro.ProStawka`
Nazwa tabeli: `ProStawki`
Tytuł: Stawki produkcyjne
Opis: Cennik stawek stosowanych przy kalkulacji kosztów produkcji. Określa stawki roboczogodzin, maszynogodzin oraz inne stawki kosztowe przypisane do wydziałów, wykorzystywane przy wycenie operacji i zleceń produkcyjnych.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  | Zablokowanie stawki. |
| Domyslna | `bool` | bazodanowe | Domyślna | Domyślna stawka dla wskazanego rodzaju zasobu. |
| Kod | `string` | bazodanowe |  | Kod stawki. |
| Nazwa | `string` | bazodanowe |  | Nazwa stawki. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis stawki. |
| RodzajZasobu | `Soneta.ProdukcjaPro.ProRodzajZasobu` | bazodanowe, enum | Rodzaj zasobu | Rodzaj zasobu dla stawki. |
| Typ | `Soneta.ProdukcjaPro.ProTypStawki` | bazodanowe, enum |  | Typ stawki. |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość | Wartość stawki. |
| Wydzial | `Soneta.ProdukcjaPro.ProWydzial` | bazodanowe | Wydział | Wydział stawki. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### ProRodzajZasobu (`Soneta.ProdukcjaPro.ProRodzajZasobu`)
- `None` = 0
- `GniazdoProdukcyjne` = 1 — Gniazdo produkcyjne
- `JednostkaRobocza` = 2 — Jednostka robocza
- `Narzedzie` = 4 — Narzędzie
- `Kooperacja` = 8 — Kooperacja
- `All` = 15 — Wszystkie

### ProTypStawki (`Soneta.ProdukcjaPro.ProTypStawki`)
- `None` = 0
- `Godzinowa` = 1
- `Ilosciowa` = 2 — Ilościowa
- `All` = 3 — Wszystkie
