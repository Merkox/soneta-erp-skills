# Pola i właściwości klasy biznesowej: `Soneta.Vehicles.DamageEvent`
Nazwa tabeli: `DamageEvents`
Tytuł: Szkody komunikacyjne
Opis: Rejestr szkód komunikacyjnych dotyczących pojazdów floty. Przechowuje dane o zdarzeniu, kierowcy, sprawcy, decyzji ubezpieczyciela, kwocie odszkodowania, powiązanej polisie oraz opiekunie prowadzącym sprawę.
Tabela konfiguracyjna: Nie
Guided: root
Implementuje interfejsy: `IEmailElement`

- pola bazodanowe (zapisywalne): 12
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 2
- podlisty: 2
- subrowy: 0
- razem: 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Amount | `Currency` | bazodanowe | Kwota |  |
| Culprit | `IRezerwujacy` | bazodanowe | Sprawca |  |
| CulpritInsurer | `Soneta.CRM.Kontrahent` | bazodanowe | Ubezpieczyciel sprawcy |  |
| CulpritNumber | `string` | bazodanowe | Numer polisy sprawcy |  |
| CulpritRegNo | `string` | bazodanowe | Nr rej. sprawcy | Numer rejestracyjny pojazdu sprawcy |
| Date | `System.DateTime` | bazodanowe | Data zdarzenia |  |
| Decision | `Soneta.Zadania.Decision` (enum) | bazodanowe | Decyzja ubezpieczyciela |  |
| DecisionName | `string` | tylko-odczyt |  |  |
| Description | `MemoText` | bazodanowe, podlista | Opis zdarzenia |  |
| Driver | `IRezerwujacy` | bazodanowe | Kierowca |  |
| Guardian | `Soneta.CRM.KontaktOsoba` | bazodanowe | Opiekun | Opiekun szkody |
| Insurance | `Soneta.Vehicles.Insurance` | bazodanowe | Ubezpieczenie |  |
| Number | `string` | bazodanowe | Numer szkody |  |
| OwnDamage | `bool` | bazodanowe | Szkoda własna |  |
| Vehicle | `Soneta.Samochodowka.Pojazd` | bazodanowe, tylko-odczyt | Pojazd |  |
| WiadomosciPowiazane | `SubTable<Soneta.CRM.ElementEmail>` | podlista |  |  |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### Decision (`Soneta.Zadania.Decision`)
- `InProgress` = 0 — W toku
- `InProgressAppeal` = 1 — W toku - odwołanie
- `Positive` = 2 — Pozytywna
- `Negative` = 3 — Negatywna
