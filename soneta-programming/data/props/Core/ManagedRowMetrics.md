# Pola i właściwości klasy biznesowej: `Soneta.Core.ManagedRowMetrics`
Nazwa tabeli: `ManRowsMetrics`
Tytuł: Metryki dokumentów
Opis: Element szczegółowy informacji o zarządzaniu (ManagedRowInfo). Wpis w metryce dokumentu rejestrujący zmianę stanu: numer porządkowy, operator, data i godzina, nazwę wpisu, dodatkowe informacje i treść.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ManagedRowInfo` → `ManagedRowInfo`

- pola bazodanowe: 9
- pola kalkulowane (z klas biznesowych): 1

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Autor | `Soneta.Business.GuidedRow` |  |  |  |
| Czas | `System.DateTime` | bazodanowe | Data i godzina | Data i godzina dokonania wpisu. |
| Definicja | `Soneta.Core.ManagedRowMetricsDefinition` | bazodanowe | Definicja | Definicja zapisu |
| Informacja | `string` | bazodanowe |  | Dodatkowe informacje dla wpisu. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wpisu. |
| ManagedRowInfo | `Soneta.Core.ManagedRowInfo` | bazodanowe, guided-parent |  |  |
| Nazwa | `string` | bazodanowe |  | Nazwa wpisu. |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  | Operator, który był zalogowany do systemu, który utworzył to zgłoszenie. |
| Tresc | `string` | bazodanowe | Treść | Treść wpisu |
| WebOperator | `Soneta.Business.IWebOperator` | bazodanowe, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WebOperator | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |
