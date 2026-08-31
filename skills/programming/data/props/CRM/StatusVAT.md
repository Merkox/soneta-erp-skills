# Pola i właściwości klasy biznesowej: `Soneta.CRM.StatusVAT`
Nazwa tabeli: `StatusyVAT`
Tytuł: Statusy VAT
Opis: Historia weryfikacji statusu VAT kontrahenta. Rejestruje wyniki sprawdzeń aktywności numeru VAT (np. w rejestrze podatników), wraz z datą, identyfikatorem zapytania i informacją zwrotną.
Tabela konfiguracyjna: Nie

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Aktualnosc | `Date` | bazodanowe | Data aktualności |  |
| Data | `System.DateTime` | bazodanowe | Data sprawdzenia |  |
| IdentyfikatorZapytania | `string` | bazodanowe | Identyfikator zapytania |  |
| Informacja | `string` | bazodanowe | Informacja |  |
| Kontrahent | `Soneta.CRM.Kontrahent` | bazodanowe |  |  |
| StatusNumeru | `Soneta.CRM.StatusNumeruVAT` (enum) | bazodanowe |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusNumeruVAT (`Soneta.CRM.StatusNumeruVAT`)
- `Brak` = 0 — Brak informacji
- `AktywnyVIES` = 1 — Aktywny w bazie VIES
- `NieaktywnyVIES` = 2 — Nieaktywny w bazie VIES
- `CzynnyMF` = 3 — Czynny (MF)
- `NiezarejestrowanyMF` = 4 — Niezarejestrowany (MF)
- `ZwolnionyMF` = 5 — Zwolniony (MF)
- `BrakMF` = 6 — Brak w wykazie (MF)
- `Weryfikacja` = 7 — Wymaga weryfikacji
