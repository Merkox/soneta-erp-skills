# Pola i właściwości klasy biznesowej: `Soneta.Core.HTTPLinkInfo`
Nazwa tabeli: `HTTPLinkInfos`
Opis: Informacja o linku HTTP udostępniającym dokument na zewnątrz. Przechowuje powiązanie z dokumentem, nazwę workera, parametry, daty generowania i ważności, operatora, uprawnienia oraz flagi (anonimowy, jednorazowy, anulowany, wykonany).
Tabela konfiguracyjna: Nie
Guided: root

- pola bazodanowe: 12
- pola kalkulowane (z klas biznesowych): 0

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Anonimowy | `bool` | bazodanowe |  |  |
| Anulowany | `bool` | bazodanowe |  |  |
| Data | `Soneta.Types.Date` | bazodanowe |  | Data generowania |
| Dokument | `Soneta.Business.IGuidedRow` | bazodanowe | Dokument | Udostępniany dokument |
| Operator | `Soneta.Business.App.Operator` | bazodanowe |  |  |
| Parametry | `string` | bazodanowe |  |  |
| RoleGuid | `System.Guid` | bazodanowe |  |  |
| Termin | `Soneta.Types.Date` | bazodanowe |  | Termin ważności |
| TylkoRaz | `bool` | bazodanowe |  |  |
| WebOperator | `Soneta.Business.IWebOperator` | bazodanowe, iface-ref |  |  |
| WorkerName | `string` | bazodanowe |  |  |
| Wykonany | `bool` | bazodanowe |  |  |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| WebOperator | `IWebOperator` | `KontaktOsoba`, `Pracownik`, `ProUzytkownikPaneluMeldunkowego` |
