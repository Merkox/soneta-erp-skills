# Pola i właściwości klasy biznesowej: `Soneta.Core.HTTPLinkInfo`
Nazwa tabeli: `HTTPLinkInfos`
Opis: Informacja o linku HTTP udostępniającym dokument na zewnątrz. Przechowuje powiązanie z dokumentem, nazwę workera, parametry, daty generowania i ważności, operatora, uprawnienia oraz flagi (anonimowy, jednorazowy, anulowany, wykonany).
Tabela konfiguracyjna: Nie
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anonimowy | `bool` | bazodanowe |  |  |
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Date` | bazodanowe, tylko-odczyt |  | Data generowania |
| Dokument | `IGuidedRow` | bazodanowe, tylko-odczyt | Dokument | Udostępniany dokument |
| Operator | `App.Operator` | bazodanowe |  |  |
| Parametry | `string` | bazodanowe, tylko-odczyt |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  |  |
| Termin | `Date` | bazodanowe |  | Termin ważności |
| TylkoRaz | `bool` | bazodanowe |  |  |
| WebOperator | `IWebOperator` | bazodanowe, iface-ref |  |  |
| WorkerName | `string` | bazodanowe, tylko-odczyt |  |  |
| Wykonany | `bool` | bazodanowe, tylko-odczyt |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WebOperator | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |
