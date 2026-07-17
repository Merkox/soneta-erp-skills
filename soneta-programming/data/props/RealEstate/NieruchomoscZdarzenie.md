# Pola i właściwości klasy biznesowej: `Soneta.RealEstate.Models.Database.NieruchomoscZdarzenie`
Nazwa tabeli: `NieruZdarzenia`
Tytuł: Zdarzenia nieruchmości
Opis: Rejestr zdarzeń związanych z nieruchomościami, takich jak przeglądy, odczyty liczników, szkody czy zgłoszenia serwisowe. Każde zdarzenie jest powiązane z zadaniem w module CRM i może zawierać dane finansowe, odczyty mediów oraz informacje o rozliczeniach.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 22
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| DataPowstania | `Soneta.Types.Date` | bazodanowe | Data powstania szkody | Data powstania szkody |
| DataUjawnienia | `Soneta.Types.Date` | bazodanowe | Data ujawnienia szkody | Data ujawnienia szkody |
| DataUsuniecia | `Soneta.Types.Date` | bazodanowe | Data usunięcia szkody | Data usunięcia szkody |
| DataUtworzenia | `Soneta.Types.Date` | bazodanowe | Data utworzenia | Data utworzenia |
| DataZgloszenia | `Soneta.Types.Date` | bazodanowe | Data zgłoszenia szkody | Data zgłoszenia szkody |
| Decyzja | `Soneta.Zadania.Decision` | bazodanowe, enum | Decyzja |  |
| DeklaracjaPodatkowaRozpoczecie | `string` | bazodanowe | Numer deklaracji podatkowej przy rozpoczęciu |  |
| DeklaracjaPodatkowaZakonczenie | `string` | bazodanowe | Numer deklaracji podatkowej przy zakończeniu |  |
| Kwota | `Soneta.Types.Currency` | bazodanowe | Kwota | Kwota |
| Numer | `string` | bazodanowe | Numer |  |
| Odczyt | `double` | bazodanowe | Odczyt | Odczyt pomiaru licznika |
| Oplacono | `Soneta.Zadania.PolicyPayments` | bazodanowe, enum | Opłacono |  |
| PowierzchniaUzytkowa | `double` | bazodanowe | Powierzchnia użytkowa |  |
| PrzedmiotNajmu | `string` | bazodanowe | Przedmiot najmu |  |
| Rozliczenie | `Soneta.RealEstate.Models.Database.RozliczenieMediow` | bazodanowe | Rozliczenie |  |
| Sprawca | `Soneta.CRM.Kontrahent` | bazodanowe | Sprawca |  |
| Uwagi | `Soneta.Business.MemoText` | bazodanowe | Uwagi |  |
| Wartosc | `Soneta.Types.Currency` | bazodanowe | Wartość |  |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe | Zadanie | Zadanie które jest efektem realizacji tego przeglądu |
| Zglaszajacy | `Soneta.CRM.Kontrahent` | bazodanowe | Zgłaszający |  |
| ZglaszajacyOsoba | `Soneta.CRM.KontaktOsoba` | bazodanowe | Zgłaszający |  |
| Zgloszono | `bool` | bazodanowe | Zgłoszono |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Decision (`Soneta.Zadania.Decision`)
- `InProgress` = 0 — W toku
- `InProgressAppeal` = 1 — W toku - odwołanie
- `Positive` = 2 — Pozytywna
- `Negative` = 3 — Negatywna

### PolicyPayments (`Soneta.Zadania.PolicyPayments`)
- `Yes` = 0 — Tak
- `No` = 1 — Nie
- `Partial` = 2 — Częściowo
