# Pola i właściwości klasy biznesowej: `Soneta.Zadania.PlanowanyPrzeglad`
Nazwa tabeli: `PlanPrzeglady`
Tytuł: Planowany przegląd urządzenia
Opis: Harmonogram przeglądów urządzeń serwisowych. Definiuje planowany termin i zakres przeglądu, może być powiązany z zadaniem CRM realizującym przegląd lub oznaczony jako anulowany.
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllDayEvent | `bool` | tylko-odczyt |  |  |
| AnulowaniePowod | `MemoText` | bazodanowe, podlista | Powód anulowania | Powód anulowania przeglądu |
| Anulowany | `bool` | bazodanowe | Anulowany | Czy przegląd został anulowany |
| Description | `string` | tylko-odczyt |  |  |
| End | `System.DateTime` | tylko-odczyt |  |  |
| Nazwa | `string` | bazodanowe | Nazwa | Nazwa przeglądu. |
| Opis | `MemoText` | bazodanowe, podlista | Opis | Dokładny opis przeglądu |
| Resource | `object` | tylko-odczyt |  |  |
| Settings | `SchedulerSettings` | tylko-odczyt |  |  |
| Start | `System.DateTime` | tylko-odczyt |  |  |
| Termin | `Date` | bazodanowe | Data przeglądu | Planowana data przeglądu |
| Text | `string` |  |  |  |
| Urzadzenie | `Soneta.Zadania.Urzadzenie` | bazodanowe | Urządzenie, którego dotyczy przegląd | Urządzenie, którego dotyczy przegląd |
| Zadanie | `Soneta.Zadania.Zadanie` | bazodanowe | Zadanie | Zadanie które jest efektem realizacji tego przeglądu |
