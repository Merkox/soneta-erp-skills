# Pola i właściwości klasy biznesowej: `Soneta.Handel.DaneEParagonu`
Nazwa tabeli: `DaneEParagony`
Tytuł: Dane e-paragonów.
Opis: Dane e-paragonu powiązane z dokumentem handlowym. Zawiera klucz idempotentności, URL, token, adres e-mail klienta oraz statusy wysyłki i e-paragonu.
Tabela konfiguracyjna: Nie

- pola bazodanowe (zapisywalne): 6
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresEMail | `string` | bazodanowe | Adres e-mail | Adres e-mail klienta. |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe, tylko-odczyt | Dokument handlowy |  |
| IdempotencyKey | `string` | bazodanowe | IdempotencyKey | IdempotencyKey |
| StatusEParagonu | `Soneta.Handel.StatusEParagonu` (enum) | bazodanowe | Status e-paragonu | Status e-paragonu. |
| StatusWysylki | `Soneta.Handel.StatusWysylkiEParagon` (enum) | bazodanowe | Status wysyłki | Status wysyłki. |
| Token | `string` | bazodanowe | Token | Token |
| Url | `string` | bazodanowe | Url | Url |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### StatusEParagonu (`Soneta.Handel.StatusEParagonu`)
- `Brak` = 0
- `Wystawiony` = 1
- `Oczekuje` = 2

### StatusWysylkiEParagon (`Soneta.Handel.StatusWysylkiEParagon`)
- `Brak` = 0
- `Wyslany` = 1 — Wysłany
