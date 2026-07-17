# Pola i właściwości klasy biznesowej: `Soneta.Produkcja.ProdMeldunekBraku`
Nazwa tabeli: `ProdMeldBrakow`
Tytuł: Meldunki braków
Opis: Rejestr meldunków braków produkcyjnych zgłaszanych podczas realizacji operacji. Przechowuje kod meldunku, opis wady, powiązany towar i ilość braków, stan obsługi (nowy/zakończony), datę zgłoszenia oraz osobę zgłaszającą. Powiązanie z rejestracją prac (ProdHistoria) umożliwia identyfikację etapu produkcji, na którym powstał brak.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 10
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataZgloszenia | `System.DateTime` | bazodanowe | Data zgłoszenia | Data zgłoszenia meldunku braku. |
| Ilosc | `Soneta.Towary.Quantity` | bazodanowe | Ilość | Ilość meldunku braku. |
| Kod | `string` | bazodanowe |  | Kod, skrócona nazwa meldunku braku. |
| Operacja | `Soneta.Produkcja.Operacja` |  |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Określa operatora, który zgłosił awarię. |
| Opis | `Soneta.Business.MemoText` | bazodanowe |  | Opis meldunku braku. |
| ProdHistoria | `Soneta.Produkcja.ProdHistoria` | bazodanowe | Rejestracja | Określa rejestrację prac dla meldunku braku. |
| ProdOsoba | `Soneta.Produkcja.ProdOsoba` | bazodanowe | Osoba | Określa osobę rzeczywsitą, która zgłosiła awarię. |
| Stan | `Soneta.Produkcja.StanMeldunkuBraku` | bazodanowe, enum |  | Określa stan meldunku braku (nowy, zakończony). |
| Towar | `Soneta.Towary.Towar` | bazodanowe |  | Określa towar dla meldunku braku. |
| Wada | `string` | bazodanowe |  | Wada towaru dla meldunku braku. |
| Zglosil | `string` |  | Zgłosił | Określa pracownika, który zgłosił meldunek braku. |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StanMeldunkuBraku (`Soneta.Produkcja.StanMeldunkuBraku`)
- `Nowy` = 0
- `Zakonczony` = 10 — Zakończony
