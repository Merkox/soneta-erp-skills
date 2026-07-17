# Pola i właściwości klasy biznesowej: `Soneta.Business.FeatureSetDefinition`
Nazwa tabeli: `FSDefs`
Tytuł: Definicje zestawu pól
Opis: Definiuje zestawy pól (grupy cech) wyświetlane jako zakładki na formularzach obiektów. Pozwala konfigurować widoczność, priorytet i warunki aktywacji zestawu.
Tabela konfiguracyjna: Tak
Guided: root

- pola bazodanowe: 20
- pola kalkulowane (z klas biznesowych): 16

| Pole | Typ | Rodzaj | Tytuł | Opis |
|------|-----|--------|-------|------|
| AllowUserMode | `bool` |  |  |  |
| Automatic | `bool` | bazodanowe | Automatyczna | Grupa automatyczna  |
| ClassName | `string` |  |  |  |
| Code | `Soneta.Business.MemoText` | bazodanowe |  | Algorytm (C#) ustalania widoczności zestawu pól dla obiektu |
| CodeActive | `bool` | bazodanowe | Algorytm włączony | Określa, czy algorytm wyliczania widoczności jest aktywny |
| ConfigurationKey | `string` | bazodanowe | Klucz | Określa klucz wyboru konfiguracji |
| ConfigurationKeyObj | `Soneta.Business.UI.IConfigurationKey` |  |  |  |
| ConverSets | `string` |  | Zestawy przykrywane |  |
| ConveredBySets | `string` |  | Zestawy przykrywające |  |
| DefaultFileName | `string` |  |  |  |
| DefaultIdentifier | `string` |  |  |  |
| DefaultProject | `Soneta.Business.Compiler.RuntimeProject` |  |  |  |
| Description | `string` | bazodanowe | Opis | Opis objaśniający zastosowanie zestawu pól |
| Documents | `System.Collections.Generic.IEnumerable<Soneta.Business.Compiler.IRuntimeDocument>` |  |  |  |
| FeatureFilter | `Soneta.Business.FeatureDefinition` | bazodanowe | Cecha filtrująca | Cecha aktywująca działanie zestawu |
| FeatureFilterValue | `string` | bazodanowe | Wartość filtrująca | Wartość cechy aktywująca działanie zestawu |
| FeatureSetDefinitionItems | `Soneta.Business.LpSubTable<Soneta.Business.FeatureSetDefinitionItem>` |  |  |  |
| GeneralPageHidden | `bool` | bazodanowe | Ukryj 'Ogólne' | Gdy widoczna pierwsza zakładka określa, czy ma być ukryta zakładka 'Ogólne' |
| GeneralPageVisible | `bool` |  |  |  |
| HostDefinition | `Soneta.Business.UI.IConfigurationKey` | bazodanowe | Definicja obiektu | Definicja obiektu aktywująca działanie zestawu |
| HostName | `string` | bazodanowe | Typ danych | Typ danych, którego dotyczy definicja |
| HostRowType | `System.Type` |  |  |  |
| Independent | `bool` | bazodanowe | Niezależny od innych | Określa zestaw, którego pola bezwarunkowo muszą znajdować się na formularzu |
| Locked | `bool` | bazodanowe | Blokada | Określa, czy definicja jest aktualnie zablokowana |
| Name | `string` | bazodanowe | Nazwa | Nazwa cechy |
| NameWithCondition | `string` |  |  |  |
| NonVisibilityCondition | `bool` |  |  |  |
| Priority | `int` | bazodanowe |  | Priorytet zestawu pól, uwzględniany przy kolejności wyświetlania |
| RuntimeInfo | `Soneta.Business.Compiler.RuntimeDefinitionInfo` | bazodanowe |  |  |
| RuntimeInfo.FileName | `string` | bazodanowe | Nazwa pliku |  |
| RuntimeInfo.Identifier | `string` | bazodanowe | Identyfikator |  |
| RuntimeInfo.Project | `Soneta.Business.Compiler.RuntimeProject` | bazodanowe | Projekt |  |
| RuntimeInfo.WgProject | `Soneta.Business.Key` |  |  |  |
| StorageContext | `Soneta.Tools.IStorageContext` |  |  |  |
| StorageContextName | `string` | bazodanowe | Kontekst konfiguracji | Kontekst konfiguracji aktywujący działanie zestawu |
| Target | `Soneta.Business.Db.FeatureSetDefinitionTargets` | bazodanowe, enum | Zakładka | Określe miejsce, w którym zestaw pól jest uwzględniany |

## Enumy

Dozwolone wartości typów enum użytych w polach powyżej (`wartość` — Tytuł).

### FeatureSetDefinitionTargets (`Soneta.Business.Db.FeatureSetDefinitionTargets`)
- `None` = 0 — Wszystkie
- `AdditionalPage` = 1 — Zakładka Dodatkowe
- `GeneralPage` = 2 — Zakładka Ogólne
- `FirstPage` = 3 — Zakładka Użytkownika
- `UserDefinedPage` = 4 — Modułowa Zakładka Użytkownika
