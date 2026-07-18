# Pola i właściwości klasy biznesowej: `Soneta.Workflow.Dms.IK.ChronoOrdDefEn`
Nazwa tabeli: `ChronoOrdDefEns`
Tytuł: Dostępność składu chronologicznego
Opis: Tabela konfiguracyjna dla obsługi elementów składów chronologicznych. Zawiera informacje na temat definicji dokumentów podstawowych, w których uruchomiono obsługę składów chronologicznych.
Tabela konfiguracyjna: Tak
Guided: root

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Definition | `Soneta.Workflow.Dms.IK.Interfaces.IChronoOrderHostDefinition` | bazodanowe, iface-ref | Definicja | Definicja dla której jest dostępny skład |
| IsEnabled | `bool` | bazodanowe | Dostępność | Widoczność składu |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Definition | `IChronoOrderHostDefinition` | `BasicDocumentDefinition` |
