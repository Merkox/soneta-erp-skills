# Pola i właściwości klasy biznesowej: `Soneta.Handel.DaneEParagonu`
Nazwa tabeli: `DaneEParagony`
Tytuł: Dane e-paragonów.
Opis: Dane e-paragonu powiązane z dokumentem handlowym. Zawiera klucz idempotentności, URL, token, adres e-mail klienta oraz statusy wysyłki i e-paragonu.
Tabela konfiguracyjna: Nie

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AdresEMail | `string` | bazodanowe | Adres e-mail | Adres e-mail klienta. |
| Dokument | `Soneta.Handel.DokumentHandlowy` | bazodanowe | Dokument handlowy |  |
| IdempotencyKey | `string` | bazodanowe | IdempotencyKey | IdempotencyKey |
| StatusEParagonu | `Soneta.Handel.StatusEParagonu` | bazodanowe, enum | Status e-paragonu | Status e-paragonu. |
| StatusWysylki | `Soneta.Handel.StatusWysylkiEParagon` | bazodanowe, enum | Status wysyłki | Status wysyłki. |
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
