# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.DamageEvent`
Nazwa tabeli: `DamageEvents`
Tytuł: Szkody komunikacyjne
Opis: Rejestr szkód komunikacyjnych dotyczących pojazdów floty. Przechowuje dane o zdarzeniu, kierowcy, sprawcy, decyzji ubezpieczyciela, kwocie odszkodowania, powiązanej polisie oraz opiekunie prowadzącym sprawę.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`

- pola bazodanowe: 14
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Amount | `Soneta.Types.Currency` | bazodanowe | Kwota |  |
| Culprit | `Soneta.Business.IRezerwujacy` | bazodanowe | Sprawca |  |
| CulpritInsurer | `Soneta.CRM.Kontrahent` | bazodanowe | Ubezpieczyciel sprawcy |  |
| CulpritNumber | `string` | bazodanowe | Numer polisy sprawcy |  |
| CulpritRegNo | `string` | bazodanowe | Nr rej. sprawcy | Numer rejestracyjny pojazdu sprawcy |
| Date | `System.DateTime` | bazodanowe | Data zdarzenia |  |
| Decision | `Soneta.Zadania.Decision` | bazodanowe, enum | Decyzja ubezpieczyciela |  |
| DecisionName | `string` |  |  |  |
| Description | `Soneta.Business.MemoText` | bazodanowe | Opis zdarzenia |  |
| Driver | `Soneta.Business.IRezerwujacy` | bazodanowe | Kierowca |  |
| Guardian | `Soneta.CRM.KontaktOsoba` | bazodanowe | Opiekun | Opiekun szkody |
| Insurance | `Soneta.Vehicles.Insurance` | bazodanowe | Ubezpieczenie |  |
| Number | `string` | bazodanowe | Numer szkody |  |
| OwnDamage | `bool` | bazodanowe | Szkoda własna |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe | Pojazd |  |
| WiadomosciPowiazane | `Soneta.Business.SubTable<Soneta.CRM.ElementEmail>` |  |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Decision (`Soneta.Zadania.Decision`)
- `InProgress` = 0 — W toku
- `InProgressAppeal` = 1 — W toku - odwołanie
- `Positive` = 2 — Pozytywna
- `Negative` = 3 — Negatywna
