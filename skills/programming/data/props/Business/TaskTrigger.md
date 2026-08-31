# Pola i właściwości klasy biznesowej: `Soneta.Business.Db.TaskTrigger`
Nazwa tabeli: `TaskTriggers`
Tytuł: Kolekcja klas mających wpływ na przetworzenie taska
Opis: Wyzwalacz przypisany do definicji zadania. Określa klasę obiektu i algorytm, który uruchamia przetwarzanie zadania w odpowiedzi na zmiany danych.
Tabela konfiguracyjna: Tak
Guided: child — nadrzędna przez pole `TaskDefinition` → `TaskDefinition`
Implementuje interfejsy: `IWfPlugInItemReferenceHost`

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista |  | Kod metody która zwraca obkiekt do którego utworzona jest definicja zadania. |
| DataType | `System.Type` | tylko-odczyt |  |  |
| DefinitionType | `Db.DefinitionTypeEnum` (enum) | bazodanowe, tylko-odczyt | Tryb edycji | Określa tryb edycji definicji workflow |
| Purpose | `Db.TaskTriggerPurpose` (enum) | bazodanowe | Przeznaczenie |  |
| TableName | `string` | bazodanowe | Klasa | Klasa obiektu nadrzędanego. |
| TaskDefinition | `Db.TaskDefinition` | bazodanowe, guided-parent |  | Definicja zadania, do której jest przypisana klasa |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### DefinitionTypeEnum (`Db.DefinitionTypeEnum`)
- `Standard` = 0 — Wielozakładkowy
- `Engine` = 1 — Jednozakładkowy
- `None` = 2 — Brak

### TaskTriggerPurpose (`Db.TaskTriggerPurpose`)
- `Uniwersal` = 0 — Uniwersalny
- `Creator` = 1 — Uruchomienie nowego procesu
- `Activator` = 2 — Przeliczenie zadania
