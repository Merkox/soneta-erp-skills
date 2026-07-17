# Pola i właściwości klasy biznesowej: `Soneta.Zadania.PlanowanyPrzeglad`
Nazwa tabeli: `PlanPrzeglady`
Tytuł: Planowany przegląd urządzenia
Opis: Harmonogram przeglądów urządzeń serwisowych. Definiuje planowany termin i zakres przeglądu, może być powiązany z zadaniem CRM realizującym przegląd lub oznaczony jako anulowany.
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 7
- pola kalkulowane (z klas biznesowych): 7

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` |  |  |  |
| AnulowaniePowod | `Soneta.Business.MemoText` | bazodanowe | Powód anulowania | Powód anulowania przeglądu |
| Anulowany | `bool` | bazodanowe | Anulowany | Czy przegląd został anulowany |
| Description | `string` |  |  |  |
| End | `System.DateTime` |  |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa przeglądu. |
| Opis | `Soneta.Business.MemoText` | bazodanowe | Opis | Dokładny opis przeglądu |
| Resource | `object` |  |  |  |
| Settings | `Soneta.Business.SchedulerSettings` |  |  |  |
| Start | `System.DateTime` |  |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe | Data przeglądu | Planowana data przeglądu |
| Text | `string` |  |  |  |
| Urzadzenie | `Soneta.Zadania.Urzadzenie` | bazodanowe | Urządzenie, którego dotyczy przegląd | Urządzenie, którego dotyczy przegląd |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe | Zadanie | Zadanie które jest efektem realizacji tego przeglądu |
