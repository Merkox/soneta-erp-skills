# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.TaskTrigger`
Nazwa tabeli: `TaskTriggers`
Tytuł: Kolekcja klas mających wpływ na przetworzenie taska
Opis: Wyzwalacz przypisany do definicji zadania. Określa klasę obiektu i algorytm, który uruchamia przetwarzanie zadania w odpowiedzi na zmiany danych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `TaskDefinition` → `TaskDefinition`
Implementuje interfejsy: `IWfPlugInItemReferenceHost`

- pola bazodanowe: 5
- pola kalkulowane (z klas biznesowych): 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  | Kod metody która zwraca obkiekt do którego utworzona jest definicja zadania. |
| DataType | `System.Type` |  |  |  |
| DefinitionType | `Soneta.Business.Db.DefinitionTypeEnum` | bazodanowe, enum | Tryb edycji | Określa tryb edycji definicji workflow |
| Purpose | `Soneta.Business.Db.TaskTriggerPurpose` | bazodanowe, enum | Przeznaczenie |  |
| TableName | `string` | bazodanowe | Klasa | Klasa obiektu nadrzędanego. |
| TaskDefinition | `Soneta.Business.Db.TaskDefinition` | bazodanowe, guided-parent |  | Definicja zadania, do której jest przypisana klasa |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Soneta.Business.Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### TaskTriggerPurpose (`Soneta.Business.Db.TaskTriggerPurpose`)
- `Uniwersal` = 0 — Uniwersalny
- `Creator` = 1 — Uruchomienie nowego procesu
- `Activator` = 2 — Przeliczenie zadania
