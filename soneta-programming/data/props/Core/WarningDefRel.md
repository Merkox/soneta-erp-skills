# Pola i właściwości klasy biznesowej: `Soneta.Core.WarningDefRel`
Nazwa tabeli: `WarningDefRels`
Tytuł: Relacje definicji warningów
Opis: Element szczegółowy hosta ostrzeżeń (IWarningHost). Powiązanie definicji warningu z konkretnym obiektem biznesowym, umożliwiające włączenie lub wyłączenie ostrzeżenia dla danego zapisu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 1
- pola kalkulowane (zapisywalne): 0
- pola tylko-odczyt: 1
- podlisty: 0
- subrowy: 0
- razem: 2

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| Host | `Soneta.Core.VerifiersConfig.IWarningHost` | bazodanowe, tylko-odczyt, iface-ref |  | Zapis, do którego przypisany jest dana definicja warningu |
| WarningDefinition | `Soneta.Core.WarningDef` | bazodanowe | Definicja warningu | Definicja warningu |

## Relacje interfejsowe

Pola, których typ jest interfejsem zadeklarowanym w `[TableInfo(Interfaces=...)]` innych tabel.
Pole może wskazywać na rekord dowolnej z poniższych tabel.

| Pole | Interfejs | Tabele implementujące |
|------|-----------|------------------------|
| Host | `IWarningHost` | `DefDokHandlowego` |
