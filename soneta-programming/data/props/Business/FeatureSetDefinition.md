# Pola i właściwości klasy biznesowej: `Soneta.Business.FeatureSetDefinition`
Nazwa tabeli: `FSDefs`
Tytuł: Definicje zestawu pól
Opis: Definiuje zestawy pól (grupy cech) wyświetlane jako zakładki na formularzach obiektów. Pozwala konfigurować widoczność, priorytet i warunki aktywacji zestawu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe (zapisywalne): 17
- pola kalkulowane (zapisywalne): 3
- pola tylko-odczyt: 11
- podlisty: 4
- subrowy: 1
- razem: 36

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowUserMode | `bool` | tylko-odczyt |  |  |
| Automatic | `bool` | bazodanowe | Automatyczna | Grupa automatyczna  |
| ClassName | `string` | tylko-odczyt |  |  |
| Code | `MemoText` | bazodanowe, podlista |  | Algorytm (C#) ustalania widoczności zestawu pól dla obiektu |
| CodeActive | `bool` | bazodanowe | Algorytm włączony | Określa, czy algorytm wyliczania widoczności jest aktywny |
| ConfigurationKey | `string` | bazodanowe | Klucz | Określa klucz wyboru konfiguracji |
| ConfigurationKeyObj | `UI.IConfigurationKey` |  |  |  |
| ConverSets | `string` | tylko-odczyt | Zestawy przykrywane |  |
| ConveredBySets | `string` | tylko-odczyt | Zestawy przykrywające |  |
| DefaultFileName | `string` | tylko-odczyt |  |  |
| DefaultIdentifier | `string` | tylko-odczyt |  |  |
| DefaultProject | `Compiler.RuntimeProject` | tylko-odczyt |  |  |
| Description | `string` | bazodanowe | Opis | Opis objaśniający zastosowanie zestawu pól |
| Documents | `System.Collections.Generic.IEnumerable<Compiler.IRuntimeDocument>` | podlista |  |  |
| FeatureFilter | `FeatureDefinition` | bazodanowe | Cecha filtrująca | Cecha aktywująca działanie zestawu |
| FeatureFilterValue | `string` | bazodanowe | Wartość filtrująca | Wartość cechy aktywująca działanie zestawu |
| FeatureSetDefinitionItems | `LpSubTable<FeatureSetDefinitionItem>` | podlista |  |  |
| GeneralPageHidden | `bool` | bazodanowe | Ukryj 'Ogólne' | Gdy widoczna pierwsza zakładka określa, czy ma być ukryta zakładka 'Ogólne' |
| GeneralPageVisible | `bool` |  |  |  |
| HostDefinition | `UI.IConfigurationKey` | bazodanowe | Definicja obiektu | Definicja obiektu aktywująca działanie zestawu |
| HostName | `string` | bazodanowe, tylko-odczyt | Typ danych | Typ danych, którego dotyczy definicja |
| HostRowType | `System.Type` | tylko-odczyt |  |  |
| Independent | `bool` | bazodanowe | Niezależny od innych | Określa zestaw, którego pola bezwarunkowo muszą znajdować się na formularzu |
| Locked | `bool` | bazodanowe | Blokada | Określa, czy definicja jest aktualnie zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa cechy |
| NameWithCondition | `string` | tylko-odczyt |  |  |
| NonVisibilityCondition | `bool` | tylko-odczyt |  |  |
| Priority | `int` | bazodanowe |  | Priorytet zestawu pól, uwzględniany przy kolejności wyświetlania |
| RuntimeInfo | `Compiler.RuntimeDefinitionInfo` (subrow) | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Key` | podlista |  |  |
| StorageContext | `Soneta.Tools.IStorageContext` |  |  |  |
| StorageContextName | `string` | bazodanowe | Kontekst konfiguracji | Kontekst konfiguracji aktywujący działanie zestawu |
| Target | `Db.FeatureSetDefinitionTargets` (enum) | bazodanowe | Zakładka | Określe miejsce, w którym zestaw pól jest uwzględniany |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FeatureSetDefinitionTargets (`Db.FeatureSetDefinitionTargets`)
- `None` = 0 — Wszystkie
- `AdditionalPage` = 1 — Zakładka Dodatkowe
- `GeneralPage` = 2 — Zakładka Ogólne
- `FirstPage` = 3 — Zakładka Użytkownika
- `UserDefinedPage` = 4 — Modułowa Zakładka Użytkownika
