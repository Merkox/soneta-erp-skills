# Pola i właściwości klasy biznesowej: `Soneta.Core.ManagedRowMetrics`
Nazwa tabeli: `ManRowsMetrics`
Tytuł: Metryki dokumentów
Opis: Element szczegółowy informacji o zarządzaniu (ManagedRowInfo). Wpis w metryce dokumentu rejestrujący zmianę stanu: numer porządkowy, operator, data i godzina, nazwę wpisu, dodatkowe informacje i treść.
Tabela konfiguracyjna: Nie
Guided: child — nadrzędna przez pole `ManagedRowInfo` → `ManagedRowInfo`

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 9
- podlisty: 0
- subrowy: 0
- razem: 10

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Autor | `GuidedRow` | tylko-odczyt |  |  |
| Czas | `System.DateTime` | bazodanowe, tylko-odczyt | Data i godzina | Data i godzina dokonania wpisu. |
| Definicja | `Soneta.Core.ManagedRowMetricsDefinition` | bazodanowe, tylko-odczyt | Definicja | Definicja zapisu |
| Informacja | `string` | bazodanowe, tylko-odczyt |  | Dodatkowe informacje dla wpisu. |
| Lp | `int` | bazodanowe |  | Liczba porządkowa wpisu. |
| ManagedRowInfo | `Soneta.Core.ManagedRowInfo` | bazodanowe, tylko-odczyt, guided-parent |  |  |
| Nazwa | `string` | bazodanowe, tylko-odczyt |  | Nazwa wpisu. |
| Operator | `App.Operator` | bazodanowe, tylko-odczyt |  | Operator, który był zalogowany do systemu, który utworzył to zgłoszenie. |
| Tresc | `string` | bazodanowe, tylko-odczyt | Treść | Treść wpisu |
| WebOperator | `IWebOperator` | bazodanowe, tylko-odczyt, iface-ref |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WebOperator | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |
