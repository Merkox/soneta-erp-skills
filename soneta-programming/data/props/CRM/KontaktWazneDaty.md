# Pola i właściwości klasy biznesowej: `Soneta.CRM.Osoba_Kontrahent.KontaktWazneDaty`
Nazwa tabeli: `KntktyWazneDaty`
Tytuł: Ważna data
Opis: Rejestr ważnych dat powiązanych z osobami kontaktowymi (np. urodziny, rocznice współpracy). Umożliwia ustawienie przypomnień dla operatorów, wspierając budowanie relacji z klientami i partnerami biznesowymi.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Data | `Soneta.Types.Date` | bazodanowe |  |  |
| Kontakt | `Soneta.CRM.KontaktOsoba` | bazodanowe |  |  |
| Nazwa | `string` | bazodanowe |  |  |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| Opis | `string` | bazodanowe |  |  |
| Przypomnienie | `int` | bazodanowe |  |  |
| PrzypomnienieWg | `Soneta.CRM.RodzajPrzypomnienia` | bazodanowe, enum |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### RodzajPrzypomnienia (`Soneta.CRM.RodzajPrzypomnienia`)
- `Brak` = 0 — Brak
- `Przed` = 1 — Przed
- `Po` = 2 — Po
