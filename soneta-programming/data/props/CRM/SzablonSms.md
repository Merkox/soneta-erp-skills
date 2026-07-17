# Pola i właściwości klasy biznesowej: `Soneta.CRM.SzablonSms`
Nazwa tabeli: `SzablonySms`
Tytuł: Szablony SMS
Opis: Szablon wiadomości SMS wykorzystywany do masowej lub indywidualnej komunikacji z kontrahentami. Definiuje treść, odbiorcę i typ szablonu, umożliwiając szybkie wysyłanie powiadomień i przypomnień.
Tabela konfiguracyjna: Tak
Guided: root
Implementuje interfejsy: `ITemplate`

- pola bazodanowe: 6
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Blokada | `bool` | bazodanowe |  |  |
| Domyslna | `bool` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Odbiorca | `string` | bazodanowe |  |  |
| Tresc | `Soneta.Business.MemoText` | bazodanowe | Treść |  |
| Typ | `Soneta.CRM.TypDlaSzablonu` | bazodanowe, enum | Typ |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### TypDlaSzablonu (`Soneta.CRM.TypDlaSzablonu`)
- `Brak` = 0 — Brak
- `Zadanie` = 1
- `Kontrahent` = 2
- `KontaktOsoba` = 3
- `DokumentHandlowy` = 4
- `PracHistoria` = 5 — Pracownik (PracHistoria)
- `Projekt` = 6
- `SprawaWindykacyjna` = 7
